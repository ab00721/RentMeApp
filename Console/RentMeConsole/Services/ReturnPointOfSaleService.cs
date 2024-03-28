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
    private readonly List<ReturnLineItem> _lineItems;
    private readonly FurnitureController _furnitureController;
    private readonly ReturnLineItemController _returnLineItemController;
    private readonly ReturnTransactionController _returnTransactionController;

    /// <summary>
    /// Initializes a new instance of the <see cref="ReturnPointOfSaleService"/> class.
    /// </summary>
    public ReturnPointOfSaleService(AppSession session)
    {
        _session = session;
        _returnDate = DateTime.Now;
        _lineItems = new List<ReturnLineItem>();
        _furnitureController = new FurnitureController(session);
        _returnLineItemController = new ReturnLineItemController(session);
        _returnTransactionController = new ReturnTransactionController(session);
    }

    /// <summary>
    /// Gets the list of return line items.
    /// </summary>
    /// <returns>The list of return line items.</returns>
    public List<ReturnLineItem> GetReturnLineItems()
    {
        return _lineItems;
    }

    /// <summary>
    /// Adds a return line item to the list of items.
    /// </summary>
    /// 
    /// <param name="rentalLineItem">The associated rental line item.</param>
    /// <param name="furniture">The furniture to add as a return line item.</param>
    /// <param name="quantity">The quantity of the furniture to add.</param>
    public void AddReturnLineItem(RentalLineItem rentalLineItem, int quantity)
    {
        Furniture furniture = _furnitureController.GetFurnitureByID(rentalLineItem.FurnitureID);
        ReturnLineItem item = new ReturnLineItem(rentalLineItem.RentalLineItemID, quantity, furniture.DailyRate * quantity);
        _lineItems.Add(item);
    }
}
