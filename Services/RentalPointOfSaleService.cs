using RentMeApp.Model;
using System.Collections.Generic;
using System;
using RentMeApp.Controller;
using System.Transactions;

/// <summary>
/// Service for rental point of sale operations.
/// </summary>
public class RentalPointOfSaleService
{
    private readonly List<RentalLineItem> _lineItems;
    private readonly FurnitureController _furnitureController;
    private readonly RentalLineItemController _rentalLineItemController;
    private readonly RentalTransactionController _rentalTransactionController;

    /// <summary>
    /// Initializes a new instance of the <see cref="RentalPointOfSaleService"/> class.
    /// </summary>
    public RentalPointOfSaleService()
    {
        _lineItems = new List<RentalLineItem>();
        _furnitureController = new FurnitureController();
        _rentalLineItemController = new RentalLineItemController();
        _rentalTransactionController = new RentalTransactionController();
    }

    /// <summary>
    /// Gets the list of rental line items.
    /// </summary>
    /// <returns>The list of rental line items.</returns>
    public List<RentalLineItem> GetRentalLineItems()
    {
        return _lineItems;
    }

    /// <summary>
    /// Adds a rental line item to the list of items.
    /// </summary>
    /// <param name="furniture">The furniture to add as a rental line item.</param>
    /// <param name="quantity">The quantity of the furniture to add.</param>
    public void AddRentalLineItem(Furniture furniture, int quantity)
    {
        RentalLineItem item = new RentalLineItem(furniture.FurnitureID, quantity, 0, furniture.DailyRate * quantity);
        _lineItems.Add(item);
    }

    /// <summary>
    /// Calculates the cost of the a line item over the rental period.
    /// </summary>
    /// <returns>The line item's cost over the rental period.</returns>
    public decimal CalculateLineCostPerDay(RentalLineItem lineItem)
    {
        decimal lineCost = 0;

        Furniture furnitureItem = _furnitureController.GetFurnitureByID(lineItem.FurnitureID);
        lineCost += furnitureItem.DailyRate * lineItem.Quantity;

        return lineCost;
    }

    /// <summary>
    /// Calculates the expected cost of the line item over the rental period.
    /// </summary>
    /// <returns>The line item's expected cost over the rental period.</returns>
    public decimal CalculateExpectedLineCostForDuration(RentalLineItem rentalLineItem, DateTime rentalDate, DateTime dueDate)
    {
        decimal expectedCost = 0;

        expectedCost += CalculateLineCostPerDay(rentalLineItem) * DurationService.DurationInDays(rentalDate, dueDate);

        return expectedCost;
    }

    /// <summary>
    /// Calculates the expected cost of the transaction over the rental period.
    /// </summary>
    /// <returns>The transaction's expeted cost over the rental period.</returns>
    public decimal CalculateExpectedTransactionCostForDuration(List<RentalLineItem> rentalLineItems, DateTime rentalDate, DateTime dueDate)
    {
        decimal transactionCost = 0;

        foreach (var lineItem in rentalLineItems)
        {
            transactionCost += CalculateExpectedLineCostForDuration(lineItem, rentalDate, dueDate);
        }

        return transactionCost;
    }

    /// <summary>
    /// Creates a rental transaction.
    /// </summary>
    /// <param name="employee">The employee performing the transaction.</param>
    /// <param name="member">The member renting the items.</param>
    /// <param name="dueDate">The due date for returning the items.</param>
    /// <returns>The created rental transaction.</returns>
    public RentalTransaction CreateRentalTransaction(EmployeeDTO employee, Member member, DateTime dueDate)
    {
        RentalTransaction rentalTransaction = new RentalTransaction(employee.EmployeeID, member.MemberID, DateTime.Now, dueDate, CalculateExpectedTransactionCostForDuration(GetRentalLineItems(), DateTime.Now, dueDate));
        return rentalTransaction;
    }

    /// <summary>
    /// Saves a rental transaction and associated rental line items to the database.
    /// </summary>
    /// <param name="rentalTransaction">The rental transaction to save.</param>
    /// <param name="lineItems">The list of rental line items to save.</param>
    public void SaveRentalTransaction(RentalTransaction rentalTransaction, List<RentalLineItem> lineItems)
    {
        using (var scope = new TransactionScope())
        {
            try
            {
                // Save rental transaction to the database and retrieve the RentalTransactionID
                int rentalTransactionID = _rentalTransactionController.AddRentalTransaction(rentalTransaction);

                // Save rental line items to the database
                foreach (var lineItem in lineItems)
                {
                    lineItem.RentalTransactionID = rentalTransactionID;
                    _rentalLineItemController.AddRentalLineItem(lineItem);
                }

                // Save adjustments to furniture data to the database
                foreach (var lineItem in lineItems)
                {
                    _furnitureController.DecreaseFurnitureInStockQuantity(lineItem.FurnitureID, lineItem.Quantity);
                }

                scope.Complete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

    /// <summary>
    /// Gets the details of a rental transaction including the associated rental line items.
    /// </summary>
    /// <param name="rentalTransactionID">The ID of the rental transaction.</param>
    /// <returns>A dictionary containing the rental transaction and its associated rental line items.</returns>
    public Dictionary<RentalTransaction, List<Tuple<RentalLineItem, Furniture>>> GetRentalTransactionDetails(int rentalTransactionID)
    {
        Dictionary<RentalTransaction, List<Tuple<RentalLineItem, Furniture>>> rentalTransactionDetails = new Dictionary<RentalTransaction, List<Tuple<RentalLineItem, Furniture>>>();

        RentalTransaction rentalTransaction = _rentalTransactionController.GetRentalTransactionByRentalTransactionId(rentalTransactionID);
        List<RentalLineItem> lineItems = _rentalLineItemController.GetRentalLineItemsByRentalTransactionID(rentalTransactionID);

        List<Tuple<RentalLineItem, Furniture>> lineItemsWithFurniture = new List<Tuple<RentalLineItem, Furniture>>();

        foreach (var lineItem in lineItems)
        {
            Furniture furniture = _furnitureController.GetFurnitureByID(lineItem.FurnitureID);
            lineItemsWithFurniture.Add(new Tuple<RentalLineItem, Furniture>(lineItem, furniture));
        }

        rentalTransactionDetails.Add(rentalTransaction, lineItemsWithFurniture);

        return rentalTransactionDetails;
    }
}
