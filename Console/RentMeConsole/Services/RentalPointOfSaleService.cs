using RentMeConsole.Controllers;
using RentMeConsole.Models;
using System.Collections.Generic;
using System;
using System.Transactions;
using RentMeConsole.Views;


/// <summary>
/// Service for rental point of sale operations.
/// </summary>
public class RentalPointOfSaleService
{
    private readonly AppSession _session;
    private readonly List<RentalLineItem> _lineItems;
    private readonly FurnitureController _furnitureController;
    private readonly RentalLineItemController _rentalLineItemController;
    private readonly RentalTransactionController _rentalTransactionController;

    /// <summary>
    /// Initializes a new instance of the <see cref="RentalPointOfSaleService"/> class.
    /// </summary>
    public RentalPointOfSaleService(AppSession session)
    {
        _session = session;
        _lineItems = new List<RentalLineItem>();
        _furnitureController = new FurnitureController(_session);
        _rentalLineItemController = new RentalLineItemController(_session);
        _rentalTransactionController = new RentalTransactionController(_session);
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
        RentalLineItem item = new RentalLineItem(furniture.FurnitureID, quantity, 0, furniture.DailyRate);
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
                int rentalTransactionID = _rentalTransactionController.AddRentalTransaction(rentalTransaction);

                foreach (var lineItem in lineItems)
                {
                    lineItem.RentalTransactionID = rentalTransactionID;
                    _rentalLineItemController.AddRentalLineItem(lineItem);
                }

                foreach (var lineItem in lineItems)
                {
                    _furnitureController.DecreaseFurnitureInStockQuantity(lineItem.FurnitureID, lineItem.Quantity);
                }

                scope.Complete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while saving rental transaction: " + ex.Message);
            }
        }
    }

    /// <summary>
    /// Takes a rental transaction ID and gets the details of the rental transaction and associated rental line items and furniture.
    /// </summary>
    /// <param name="rentalTransactionID">A rental transaction ID</param>
    /// <returns>A dictionary for a rental transaction and its associated data.</returns>
    public Dictionary<RentalTransaction, List<Tuple<RentalLineItem, Furniture>>> GetRentalTransactionDetails(int rentalTransactionID)
    {
        RentalTransaction rentalTransaction = _rentalTransactionController.GetRentalTransactionByRentalTransactionID(rentalTransactionID);
        List<RentalLineItem> lineItems = _rentalLineItemController.GetRentalLineItemsByRentalTransactionID(rentalTransactionID);
        List<Tuple<RentalLineItem, Furniture>> lineItemsWithFurniture = GetFurnitureItemsPerRentalLineItems(lineItems);
        Dictionary<RentalTransaction, List<Tuple<RentalLineItem, Furniture>>> rentalTransactionDetails = GetRentalTransactionWithRentalLineItemsAndFurniture(rentalTransaction, lineItemsWithFurniture);
        return rentalTransactionDetails;
    }

    /// <summary>
    /// Returns a dictionary that maps a rental transaction to its details.
    /// </summary>
    /// <param name=rentalTransaction">The return transaction.</param>
    /// <returns>A dictionary for a rental transaction and its associated data.</returns>
    private Dictionary<RentalTransaction, List<Tuple<RentalLineItem, Furniture>>> GetRentalTransactionWithRentalLineItemsAndFurniture(RentalTransaction rentalTransaction, List<Tuple<RentalLineItem, Furniture>> lineItemsWithFurniture)
    {
        Dictionary<RentalTransaction, List<Tuple<RentalLineItem, Furniture>>> rentalTransactionDetails = new Dictionary<RentalTransaction, List<Tuple<RentalLineItem, Furniture>>>();
        rentalTransactionDetails.Add(rentalTransaction, lineItemsWithFurniture);
        return rentalTransactionDetails;
    }

    /// <summary>
    /// Gets the furniture items and rental line items for the given rental line items.
    /// </summary>
    /// <param name="rentalLineItems">A list of rental line items.</param>
    /// <returns>A list of the rental lines item and furniture.</returns>
    private List<Tuple<RentalLineItem, Furniture>> GetFurnitureItemsPerRentalLineItems(List<RentalLineItem> rentalLineItems)
    {
        List<Tuple<RentalLineItem, Furniture>> lineItemsWithFurniture = new List<Tuple<RentalLineItem, Furniture>>();
        foreach (var rentalLineItem in rentalLineItems)
        {
            Furniture furniture = _furnitureController.GetFurnitureByID(rentalLineItem.FurnitureID);
            lineItemsWithFurniture.Add(new Tuple<RentalLineItem, Furniture>(rentalLineItem, furniture));
        }
        return lineItemsWithFurniture;
    }

    /// <summary>
    /// Shows the menu for the rental point of sale operations.
    /// </summary>
    public void ShowMenu()
    {
        RentalPointOfSaleView view = new RentalPointOfSaleView(_session);
        view.ShowMenu(_session.GetValues());
    }
}
