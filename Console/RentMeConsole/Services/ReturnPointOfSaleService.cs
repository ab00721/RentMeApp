using RentMeConsole.Models;
using System.Collections.Generic;
using System;
using RentMeConsole.Controllers;
using System.Transactions;
using RentMeConsole.Views;

/// <summary>
/// Service for return point of sale operations.
/// </summary>
public class ReturnPointOfSaleService
{
    private readonly AppSession _session;
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
    public ReturnPointOfSaleService(AppSession session)
    {
        _session = session;
        _returnDate = DateTime.Now;
        _returnLineItems = new List<ReturnLineItem>();
        _furnitureController = new FurnitureController(session);
        _rentalLineItemController = new RentalLineItemController(session);
        _rentalTransactionController = new RentalTransactionController(session);
        _returnLineItemController = new ReturnLineItemController(session);
        _returnTransactionController = new ReturnTransactionController(session);
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
        // Note: This method was rewritten to get cost from Furniture rather than RentalLineItem
        RentalLineItem rentalLineItem = _rentalLineItemController.GetRentalLineItemByID(lineItem.RentalLineItemID);
        Furniture furnitureItem = _furnitureController.GetFurnitureByID(rentalLineItem.FurnitureID);
        return furnitureItem.DailyRate;
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

                // Save return line items to the database
                foreach (var returnLineItem in returnLineItems)
                {
                    returnLineItem.ReturnTransactionID = returnTransactionID;
                    _returnLineItemController.AddReturnLineItem(returnLineItem);
                }

                // Save adjustments to rental line items data to the database
                foreach (var returnLineItem in returnLineItems)
                {
                    RentalLineItem rentalLineItem = _rentalLineItemController.GetRentalLineItemByID(returnLineItem.RentalLineItemID);
                    rentalLineItem.QuantityReturned += returnLineItem.Quantity;
                    _rentalLineItemController.UpdateRentalLineItem(rentalLineItem);
                }

                // Save adjustments to furniture data to the database
                foreach (var returnLineItem in returnLineItems)
                {
                    RentalLineItem rentalLineItem = _rentalLineItemController.GetRentalLineItemByID(returnLineItem.RentalLineItemID);
                    _furnitureController.IncreaseFurnitureInStockQuantity(rentalLineItem.FurnitureID, returnLineItem.Quantity);
                }

                scope.Complete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

    public void ShowMenu()
    {
        ReturnPointOfSaleView view = new ReturnPointOfSaleView(_session);
        view.ShowMenu(_session.GetValues());
    }
}
