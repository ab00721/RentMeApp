using RentMeApp.Model;
using System.Collections.Generic;
using System;
using RentMeApp.Controller;
using System.Transactions;
using System.Linq;
using System.Runtime.Serialization;

/// <summary>
/// Service for rental point of sale operations.
/// </summary>
public class RentalPointOfSaleService
{
    private readonly List<RentalLineItem> _lineItems;
    private readonly EmployeeController _employeeController;
    private readonly FurnitureController _furnitureController;
    private readonly RentalLineItemController _rentalLineItemController;
    private readonly RentalTransactionController _rentalTransactionController;
    private readonly DateTime _rentalDate;

    private DateTime _dueDate;
    private Member _member;
    private EmployeeDTO _employee;

    /// <summary>
    /// Initializes a new instance of the <see cref="RentalPointOfSaleService"/> class.
    /// </summary>
    public RentalPointOfSaleService()
    {
        _lineItems = new List<RentalLineItem>();
        _employeeController = new EmployeeController();
        _furnitureController = new FurnitureController();
        _rentalLineItemController = new RentalLineItemController();
        _rentalTransactionController = new RentalTransactionController();
        _rentalDate = DateTime.Now;

        _dueDate = DateTime.Now;
    }

    /// <summary>
    /// Sets the member renting the items.
    /// </summary>
    /// <param name="member">The member renting the items.</param>
    public void SetMember(Member member)
    {
        _member = member;
    }

    /// <summary>
    /// Gets the member renting the items.
    /// </summary>
    /// <returns>The member renting the items.</returns>
    public Member GetMember()
    {
        return _member;
    }

    /// <summary>
    /// Sets the employee for renting the items.
    /// </summary>
    /// <param name="username">The username of the employee for renting the items.</param>
    public void SetEmployee(string username)
    {
        try
        {
            _employee = _employeeController.GetEmployeeByUsername(username);
        } catch (Exception ex)
        {
            Console.WriteLine("Error while setting employee: " + ex.Message);
        }
    }

    /// <summary>
    /// Gets the employee for renting the items.
    /// </summary>
    /// <returns>The employee for renting the items.</returns>
    public EmployeeDTO GetEmployee()
    {
        return _employee;
    }

    /// <summary>
    /// Sets the due date for returning the rental items.
    /// </summary>
    /// <param name="dueDate">The due date for returning the items.</param>
    public void SetDueDate(DateTime dueDate)
    {
        _dueDate = dueDate;
    }

    /// <summary>
    /// Gets the due date for returning the rental items.
    /// </summary>
    /// <returns>The due date for returning the items.</returns>
    public DateTime GetDueDate()
    {
        return _dueDate;
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
    /// Gets the list of rental cart items.
    /// </summary>
    /// <returns>The list of rental cart items.</returns>
    public List<RentalCartItem> GetRentalCartItems()
    {
        var _cartItems = new List<RentalCartItem>();
        foreach (var lineItem in _lineItems)
        {
            Furniture furniture = _furnitureController.GetFurnitureByID(lineItem.FurnitureID);
            _cartItems.Add(new RentalCartItem(furniture, lineItem.Quantity, furniture.DailyRate));
        }
        return _cartItems;
    }

    /// <summary>
    /// Gets the furniture based on the FurnitureID of the RentalCartItem.
    /// </summary>
    /// <param name="rentalCartItem">The rental cart item.</param>
    /// <returns>The furniture associated with the rental cart item.</returns>
    public Furniture GetFurnitureByRentalCartItem(RentalCartItem rentalCartItem)
    {
        Furniture furniture = _furnitureController.GetFurnitureByID(rentalCartItem.FurnitureID);
        return furniture;
    }

    /// <summary>
    /// Adds a rental line item to the list of items.
    /// </summary>
    /// <param name="furniture">The furniture to add as a rental line item.</param>
    /// <param name="quantity">The quantity of the furniture to add.</param>
    public void AddRentalLineItem(Furniture furniture, int quantity)
    {
        RentalLineItem existingItem = _lineItems.Find(item => item.FurnitureID == furniture.FurnitureID);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            RentalLineItem newItem = new RentalLineItem(furniture.FurnitureID, quantity, 0, furniture.DailyRate);
            _lineItems.Add(newItem);
        }
    }

    /// <summary>
    /// Updates a rental line item with the given furniture and quantity.
    /// </summary>
    /// <param name="furniture">The furniture to update.</param>
    /// <param name="quantity">The new quantity.</param>
    public void UpdateRentalLineItem(Furniture furniture, int quantity)
    {
        RentalLineItem existingItem = _lineItems.Find(item => item.FurnitureID == furniture.FurnitureID);
        if (existingItem != null)
        {
            existingItem.Quantity = quantity;
        }
        else
        {
            RentalLineItem newItem = new RentalLineItem(furniture.FurnitureID, quantity, 0, furniture.DailyRate);
            _lineItems.Add(newItem);
        }
    }

    /// <summary>
    /// Removes rental line items from the list that have the given furniture.
    /// </summary>
    /// <param name="furniture">The furniture to remove from rental line items.</param>
    public void RemoveRentalLineItem(Furniture furniture)
    {
        _lineItems.RemoveAll(item => item.FurnitureID == furniture.FurnitureID);
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
    /// <param name="rentalLineItem">The rental line item.</param>
    /// <param name="rentalDate">The rental date (optional).</param>
    /// <param name="dueDate">The due date (optional).</param>
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
    /// <param name="rentalLineItems">The list of rental line items.</param>
    /// <param name="rentalDate">The rental date (optional).</param>
    /// <param name="dueDate">The due date (optional).</param>
    /// <returns>The transaction's expected cost over the rental period.</returns>
    public decimal CalculateExpectedTransactionCostForDuration(DateTime rentalDate = default, DateTime dueDate = default)
    {
        rentalDate = rentalDate == default ? _rentalDate : rentalDate;
        dueDate = dueDate == default ? _dueDate : dueDate;

        if (_lineItems == null)
        {
            return 0;
        }

        decimal transactionCost = 0;
        foreach (var lineItem in _lineItems)
        {
            transactionCost += CalculateExpectedLineCostForDuration(lineItem, rentalDate, dueDate);
        }
        return transactionCost;
    }

    /// <summary>
    /// Creates a rental transaction.
    /// </summary>
    /// <returns>The created rental transaction.</returns>
    public RentalTransaction CreateRentalTransaction()
    {
        decimal cost = CalculateExpectedTransactionCostForDuration(_rentalDate, _dueDate);

        RentalTransaction rentalTransaction = new RentalTransaction(_employee.EmployeeID, _member.MemberID, _rentalDate, _dueDate, cost);

        return rentalTransaction;
    }

    /// <summary>
    /// Saves a rental transaction and associated rental line items to the database.
    /// </summary>
    /// <param name="rentalTransaction">The rental transaction to save.</param>
    /// <param name="lineItems">The list of rental line items to save.</param>
    /// <returns>The rental transaction ID.</returns>
    public int SaveRentalTransaction(RentalTransaction rentalTransaction, List<RentalLineItem> lineItems)
    {
        using (var scope = new TransactionScope())
        {
            try
            {
                CheckInStockQuantities(lineItems);

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
                return rentalTransactionID;
            }
            catch (InsufficentStockException ise)
            {
                throw new InsufficentStockException(ise.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while saving rental transaction: " + ex.Message);
            }
        }
    }

    /// <summary>
    /// Checks the stock quantities for the given rental line items.
    /// Throws an exception if the stock quantity is insufficient.
    /// </summary>
    /// <param name="rentalLineItems">The list of rental line items.</param>
    public void CheckInStockQuantities(List<RentalLineItem> rentalLineItems)
    {
        foreach (var lineItem in rentalLineItems)
        {
            Furniture furniture = _furnitureController.GetFurnitureByID(lineItem.FurnitureID);
            if (furniture.InStockQuantity < lineItem.Quantity)
            {
                throw new InsufficentStockException("Insufficient stock quantity for item: " + furniture.Name);
            }
        }
    }

    /// <summary>
    /// Gets rental cart items for a rental transaction.
    /// </summary>
    /// <param name="rentalTransactionID">A rental transaction ID.</param>
    /// <returns>The list of rental cart items for the given rental transaction.</returns>
    public List<RentalCartItem> GetRentalTransactionCartItems(int rentalTransactionID)
    {
        Dictionary<RentalTransaction, List<Tuple<RentalLineItem, Furniture>>> rentalTransactionDetails = GetRentalTransactionDetails(rentalTransactionID);

        List<Tuple<RentalLineItem, Furniture>> lineItemsWithFurniture = rentalTransactionDetails.Values.FirstOrDefault();

        var rentalCartItems = new List<RentalCartItem>();
        foreach (var tuple in lineItemsWithFurniture)
        {
            RentalLineItem rentalLineItem = tuple.Item1;
            Furniture furniture = tuple.Item2;

            rentalCartItems.Add(new RentalCartItem(furniture, rentalLineItem.Quantity, furniture.DailyRate));
        }

        return rentalCartItems;
    }

    /// <summary>
    /// Takes a rental transaction ID and gets the details of the rental transaction and associated rental line items and furniture.
    /// </summary>
    /// <param name="rentalTransactionID">A rental transaction ID</param>
    /// <returns>A dictionary for a rental transaction and its details.</returns>
    public Dictionary<RentalTransaction, List<Tuple<RentalLineItem, Furniture>>> GetRentalTransactionDetails(int rentalTransactionID)
    {
        RentalTransaction rentalTransaction = _rentalTransactionController.GetRentalTransactionByRentalTransactionID(rentalTransactionID);

        List<RentalLineItem> lineItems = _rentalLineItemController.GetRentalLineItemsByRentalTransactionID(rentalTransactionID);

        List<Tuple<RentalLineItem, Furniture>> lineItemsWithFurniture = GetFurnitureItemsPerRentalLineItems(lineItems);

        Dictionary<RentalTransaction, List<Tuple<RentalLineItem, Furniture>>> rentalTransactionDetails = GetRentalTransactionWithRentalLineItemsAndFurniture(rentalTransaction, lineItemsWithFurniture);

        return rentalTransactionDetails;
    }

    /// <summary>
    /// Returns a dictionary that matches a rental transaction to its details.
    /// </summary>
    /// <param name=rentalTransaction">The return transaction.</param>
    /// <returns>A dictionary for a rental transaction and its details.</returns>
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
    /// Gets the rental transaction by the given rental transaction ID.
    /// </summary>
    /// <param name="rentalTransactionID">The ID of the rental transaction.</param>
    /// <returns>The rental transaction.</returns>
    public RentalTransaction GetRentalTransaction(int rentalTransactionID)
    {
        return _rentalTransactionController.GetRentalTransactionByRentalTransactionID(rentalTransactionID);
    }
}

/// <summary>
/// Exception thrown when there is insufficient stock quantity for a rental item.
/// </summary>
[Serializable]
internal class InsufficentStockException : Exception
{
    public InsufficentStockException(string message) : base(message)
    {
    }
}