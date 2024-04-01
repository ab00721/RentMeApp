using RentMeApp.Model;
using System.Collections.Generic;
using System;
using RentMeApp.Controller;
using System.Transactions;

/// <summary>
/// Service for return point of sale operations.
/// </summary>
public class ReturnPointOfSaleService
{
    private readonly DateTime _returnDate;
    private readonly List<ReturnLineItem> _returnLineItems;
    private readonly FurnitureController _furnitureController;
    private readonly RentalLineItemController _rentalLineItemController;
    private readonly RentalTransactionController _rentalTransactionController;
    private readonly ReturnLineItemController _returnLineItemController;
    private readonly ReturnTransactionController _returnTransactionController;

    /// <summary>
    /// Initializes a new instance of the <see cref="ReturnPointOfSaleService"/> class.
    /// </summary>
    public ReturnPointOfSaleService()
    {
        _returnDate = DateTime.Now;
        _returnLineItems = new List<ReturnLineItem>();
        _furnitureController = new FurnitureController();
        _rentalLineItemController = new RentalLineItemController();
        _rentalTransactionController = new RentalTransactionController();
        _returnLineItemController = new ReturnLineItemController();
        _returnTransactionController = new ReturnTransactionController();
    }

    /// <summary>
    /// Gets the list of return line items stored in the POS service.
    /// </summary>
    /// <returns>The list of return line items.</returns>
    public List<ReturnLineItem> GetReturnLineItems()
    {
        return _returnLineItems;
    }

    /// <summary>
    /// Adds a return line item to the list of items.
    /// </summary>
    /// 
    /// <param name="rentalLineItemID">The ID of the associated rental line item.</param>
    /// <param name="quantity">The quantity of the furniture to add.</param>
    public void AddReturnLineItem(int rentalLineItemID, int quantity)
    {
        RentalLineItem rentalLineItem = _rentalLineItemController.GetRentalLineItemByID(rentalLineItemID);
        Furniture furniture = _furnitureController.GetFurnitureByID(rentalLineItem.FurnitureID);
        ReturnLineItem item = new ReturnLineItem(rentalLineItem.RentalLineItemID, quantity, furniture.DailyRate * quantity);
        _returnLineItems.Add(item);
    }

    /// <summary>
    /// Retrieve the cost of the a line item over the rental period
    /// which was calculated when the rental transaction was created.
    /// </summary>
    /// <returns>The line item's cost over the rental period (per the database).</returns>
    public decimal RetrieveLineItemCostPerDay(ReturnLineItem lineItem)
    {
        RentalLineItem rentalLineItem = _rentalLineItemController.GetRentalLineItemByID(lineItem.RentalLineItemID);
        return rentalLineItem.DailyCost;
    }

    /// <summary>
    /// Calculates the expected cost of a line item over the rental period.
    /// </summary>
    /// <returns>The line item's expected cost over the rental period.</returns>
    public decimal CalculateExpectedLineItemCostForDuration(ReturnLineItem returnLineItem)
    {
        decimal expectedCost = 0;

        RentalTransaction rentalTransaction = _rentalTransactionController.GetRentalTransactionByRentalLineItemID(returnLineItem.RentalLineItemID);

        decimal costPerDay = RetrieveLineItemCostPerDay(returnLineItem);
        Console.WriteLine("Cost Per Day: " + costPerDay);

        int duration = DurationService.DurationInDays(rentalTransaction.RentalDate, rentalTransaction.DueDate);
        Console.WriteLine("Rental Date: " + rentalTransaction.RentalDate);
        Console.WriteLine("Due Date: " + rentalTransaction.DueDate);
        Console.WriteLine("Duration: " + duration);

        expectedCost += costPerDay * duration;
        Console.WriteLine("Expected Cost: " + expectedCost);

        return expectedCost;
    }

    /// <summary>
    /// Calculates the actual cost of a line item over the rental period.
    /// </summary>
    /// <returns>The line item's actual cost over the rental period.</returns>
    public decimal CalculateActualLineItemCostForDuration(ReturnLineItem returnLineItem, DateTime returnDate)
    {
        decimal actualCost = 0;

        RentalTransaction rentalTransaction = _rentalTransactionController.GetRentalTransactionByRentalLineItemID(returnLineItem.RentalLineItemID);
        actualCost += RetrieveLineItemCostPerDay(returnLineItem) * DurationService.DurationInDays(rentalTransaction.RentalDate, returnDate);

        return actualCost;
    }

    /// <summary>
    /// Calculates the actual cost of the line item over the rental period
    /// minus the expected cost of the line item over the rental period. This
    /// might be a positive or negative number. A positive number indicates
    /// additional charges, while a negative number indicates a refund.
    /// </summary>
    /// <returns>The line item's expeted cost over the rental period.</returns>
    public decimal CalculateAmountDue()
    {
        decimal amountDue = 0;

        foreach (var lineItem in _returnLineItems)
        {
            decimal expectedCost = CalculateExpectedLineItemCostForDuration(lineItem);
            Console.WriteLine("Expected Cost: " + expectedCost);

            decimal actualCost = CalculateActualLineItemCostForDuration(lineItem, _returnDate);
            Console.WriteLine("Actual Cost: " + actualCost);

            amountDue += actualCost - expectedCost;
        }

        return amountDue;
    }

    /// <summary>
    /// Creates a return transaction.
    /// </summary>
    /// <param name="employee">The employee performing the transaction.</param>
    /// <param name="member">The member returning the items.</param>
    /// <returns>The created return transaction.</returns>
    public ReturnTransaction CreateReturnTransaction(EmployeeDTO employee, Member member)
    {
        ReturnTransaction returnTransaction = new ReturnTransaction(employee.EmployeeID, member.MemberID, _returnDate, CalculateAmountDue());
        return returnTransaction;
    }
    
    /// <summary>
    /// Saves a return transaction and associated return line items to the database.
    /// </summary>
    /// <param name="returnTransaction">The return transaction to save.</param>
    /// <param name="returnLineItems">The list of return line items to save.</param>
    public void SaveReturnTransaction(ReturnTransaction returnTransaction, List<ReturnLineItem> returnLineItems)
    {
        using (var scope = new TransactionScope())
        {
            try
            {
                // Save return transaction to the database and retrieve the ReturnTransactionID
                int returnTransactionID = _returnTransactionController.AddReturnTransaction(returnTransaction);

                Console.WriteLine("Return Transaction ID: " + returnTransactionID);

                foreach (var returnLineItem in returnLineItems)
                {
                    returnLineItem.ReturnTransactionID = returnTransactionID;
                    _returnLineItemController.AddReturnLineItem(returnLineItem);
                }

                foreach (var returnLineItem in returnLineItems)
                {
                    RentalLineItem rentalLineItem = _rentalLineItemController.GetRentalLineItemByID(returnLineItem.RentalLineItemID);
                    rentalLineItem.QuantityReturned += returnLineItem.Quantity;
                    _rentalLineItemController.UpdateRentalLineItem(rentalLineItem);
                }

                foreach (var returnLineItem in returnLineItems)
                {
                    RentalLineItem rentalLineItem = _rentalLineItemController.GetRentalLineItemByID(returnLineItem.RentalLineItemID);
                    _furnitureController.IncreaseFurnitureInStockQuantity(rentalLineItem.FurnitureID, returnLineItem.Quantity);
                }

                scope.Complete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while saving return transaction: " + ex.Message);
            }
        }
    }

    /// <summary>
    /// Takes a return transaction ID and gets the details of the return transaction and associated line items and furniture.
    /// </summary>
    /// <param name="returnTransactionID">A return transaction ID</param>
    /// <returns>A dictionary for a return transaction and its associated data.</returns>
    public Dictionary<ReturnTransaction, List<Tuple<ReturnLineItem, RentalLineItem, Furniture>>> GetReturnTransactionDetails(int returnTransactionID)
    {
        ReturnTransaction returnTransaction = _returnTransactionController.GetReturnTransactionByReturnTransactionID(returnTransactionID);
        List<ReturnLineItem> returnLineItems = _returnLineItemController.GetReturnLineItemsByReturnTransactionID(returnTransactionID);
        List<Tuple<ReturnLineItem, RentalLineItem, Furniture>> details = GetFurnitureItemsAndRentalLineItemsPerReturnLineItems(returnLineItems);
        Dictionary<ReturnTransaction, List<Tuple<ReturnLineItem, RentalLineItem, Furniture>>> returnTransactionDetails = GetReturnTransactionWithAllLineItemsAndFurniture(returnTransaction, details);

        return returnTransactionDetails;
    }

    /// <summary>
    /// Returns a dictionary that maps a return transaction to its details.
    /// </summary>
    /// <param name="returnTransaction">The return transaction.</param>
    /// <param name="details">A list of tuples for line items, rental line items, and furniture.</param>
    /// <returns>A dictionary for a return transaction and its associated data.</returns>
    private Dictionary<ReturnTransaction, List<Tuple<ReturnLineItem, RentalLineItem, Furniture>>> GetReturnTransactionWithAllLineItemsAndFurniture(ReturnTransaction returnTransaction, List<Tuple<ReturnLineItem, RentalLineItem, Furniture>> details)
    {
        Dictionary<ReturnTransaction, List<Tuple<ReturnLineItem, RentalLineItem, Furniture>>> returnTransactionDetails = new Dictionary<ReturnTransaction, List<Tuple<ReturnLineItem, RentalLineItem, Furniture>>>();
        returnTransactionDetails.Add(returnTransaction, details);
        return returnTransactionDetails;
    }

    /// <summary>
    /// Gets the furniture items and rental line items for the given return line items.
    /// </summary>
    /// <param name="returnLineItems">A list of return line items.</param>
    /// <returns>A list of the return line items, rental line items, and furniture.</returns>
    private List<Tuple<ReturnLineItem, RentalLineItem, Furniture>> GetFurnitureItemsAndRentalLineItemsPerReturnLineItems(List<ReturnLineItem> returnLineItems)
    {
        List<Tuple<ReturnLineItem, RentalLineItem, Furniture>> details = new List<Tuple<ReturnLineItem, RentalLineItem, Furniture>>();
        foreach (var returnLineItem in returnLineItems)
        {
            RentalLineItem rentalLineItem = _rentalLineItemController.GetRentalLineItemByID(returnLineItem.RentalLineItemID);
            Furniture furniture = _furnitureController.GetFurnitureByID(rentalLineItem.FurnitureID);

            Tuple<ReturnLineItem, RentalLineItem, Furniture> detail = new Tuple<ReturnLineItem, RentalLineItem, Furniture>(returnLineItem, rentalLineItem, furniture);
            details.Add(detail);
        }
        return details;
    }
}
