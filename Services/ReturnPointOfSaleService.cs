using RentMeApp.Model;
using System.Collections.Generic;
using System;
using RentMeApp.Controller;
using System.Transactions;
using System.Linq;
using System.Windows.Forms;

/// <summary>
/// Service for return point of sale operations.
/// </summary>
public class ReturnPointOfSaleService
{
    private readonly List<ReturnLineItem> _returnLineItems;
    private readonly EmployeeController _employeeController = new EmployeeController();
    private readonly FurnitureController _furnitureController;
    private readonly RentalLineItemController _rentalLineItemController;
    private readonly RentalTransactionController _rentalTransactionController;
    private readonly ReturnLineItemController _returnLineItemController;
    private readonly ReturnTransactionController _returnTransactionController;

    private Member _member;
    private EmployeeDTO _employee;

    /// <summary>
    /// Initializes a new instance of the <see cref="ReturnPointOfSaleService"/> class.
    /// </summary>
    public ReturnPointOfSaleService()
    {
        _returnLineItems = new List<ReturnLineItem>();
        _employeeController = new EmployeeController();
        _furnitureController = new FurnitureController();
        _rentalLineItemController = new RentalLineItemController();
        _rentalTransactionController = new RentalTransactionController();
        _returnLineItemController = new ReturnLineItemController();
        _returnTransactionController = new ReturnTransactionController();
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
        }
        catch (Exception ex)
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
    /// Gets the list of return line items stored in the POS service.
    /// </summary>
    /// <returns>The list of return line items.</returns>
    public List<ReturnLineItem> GetReturnLineItems()
    {
        return _returnLineItems;
    }

    /// <summary>
    /// Gets the return cart items by converting the return line items.
    /// </summary>
    /// <param name="returnLineItems">Optional: The list of return line items to use.</param>
    /// <returns>The list of return cart items.</returns>
    public List<ReturnCartItem> GetReturnCartItems(List<ReturnLineItem> returnLineItems = null)
    {
        List<ReturnCartItem> returnCartItems = new List<ReturnCartItem>();

        List<ReturnLineItem> lineItems = returnLineItems ?? _returnLineItems;

        foreach (var returnLineItem in lineItems)
        {
            RentalTransaction rentalTransaction = _rentalTransactionController.GetRentalTransactionByRentalLineItemID(returnLineItem.RentalLineItemID);
            RentalLineItem rentalLineItem = _rentalLineItemController.GetRentalLineItemByID(returnLineItem.RentalLineItemID);
            Furniture furniture = _furnitureController.GetFurnitureByID(rentalLineItem.FurnitureID);

            ReturnCartItem returnCartItem = new ReturnCartItem();
            returnCartItem.RentalLineItemID = returnLineItem.RentalLineItemID;
            returnCartItem.FurnitureID = furniture.FurnitureID;
            returnCartItem.Name = furniture.Name;
            returnCartItem.DailyRate = furniture.DailyRate;
            returnCartItem.Quantity = returnLineItem.Quantity;

            int expectedDuration = DurationService.DurationInDays(rentalTransaction.RentalDate, rentalTransaction.DueDate);
            returnCartItem.ExpectedDuration = expectedDuration;
            returnCartItem.AlreadyPaid = rentalLineItem.DailyCost * returnLineItem.Quantity * expectedDuration;

            int actualDuration = DurationService.DurationInDays(rentalTransaction.RentalDate, DateTime.Now);
            returnCartItem.ActualDuration = actualDuration;

            returnCartItems.Add(returnCartItem);
        }

        return returnCartItems;
    }

    /// <summary>
    /// Adds a return line item to the list of items.
    /// </summary>
    /// <param name="rentalLineItemID">The ID of the associated rental line item.</param>
    /// <param name="quantity">The quantity of the furniture to add.</param>
    public void AddReturnLineItem(int rentalLineItemID, int quantity)
    {
        try
        {
            RentalLineItem rentalLineItem = _rentalLineItemController.GetRentalLineItemByID(rentalLineItemID);
            Furniture furniture = _furnitureController.GetFurnitureByID(rentalLineItem.FurnitureID);

            ReturnLineItem existingReturnLineItem = _returnLineItems.FirstOrDefault(item => item.RentalLineItemID == rentalLineItemID);
            if (existingReturnLineItem != null)
            {
                UpdateReturnLineItem(rentalLineItem, quantity);
            }
            else
            {
                ReturnLineItem item = new ReturnLineItem(rentalLineItem.RentalLineItemID, quantity, furniture.DailyRate * quantity);
                _returnLineItems.Add(item);
            }
        } catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Updates a return line item with the given rental line item and quantity.
    /// </summary>
    /// <param name="rentalLineItem">The rental line item to update.</param>
    /// <param name="newQuantity">The new quantity for the return line item.</param>
    public void UpdateReturnLineItem(RentalLineItem rentalLineItem, int newQuantity)
    {
        ReturnLineItem returnLineItem = _returnLineItems.FirstOrDefault(item => item.RentalLineItemID == rentalLineItem.RentalLineItemID);
        if (returnLineItem != null)
        {
            returnLineItem.Quantity = newQuantity;
        }
    }

    /// <summary>
    /// Removes the return line items associated with the given rental line item ID.
    /// </summary>
    /// <param name="rentalLineItemID">The ID of the rental line item.</param>
    public void RemoveReturnLineItems(int rentalLineItemID)
    {
        _returnLineItems.RemoveAll(_returnLineItems => _returnLineItems.RentalLineItemID == rentalLineItemID);
    }

    /// <summary>
    /// Gets the rental line item associated with the given return cart item.
    /// </summary>
    /// <param name="returnCartItem">The return cart item.</param>
    /// <returns>The rental line item associated with the return cart item.</returns>
    public RentalLineItem GetRentalLineItemByReturnCartItem(ReturnCartItem returnCartItem)
    {
        ReturnLineItem returnLineItem = _returnLineItems.FirstOrDefault(item => item.RentalLineItemID == returnCartItem.RentalLineItemID);
        if (returnLineItem != null)
        {
            return _rentalLineItemController.GetRentalLineItemByID(returnLineItem.RentalLineItemID);
        }
        return null;
    }

    /// <summary>
    /// Retrieve the cost of the a line item over the rental period
    /// which was calculated when the rental transaction was created.
    /// </summary>
    /// <returns>The line item's cost over the rental period (per the database).</returns>
    public decimal RetrieveLineItemCostPerDay(ReturnLineItem returnLineItem)
    {
        RentalLineItem rentalLineItem = _rentalLineItemController.GetRentalLineItemByID(returnLineItem.RentalLineItemID);
        return rentalLineItem.DailyCost * returnLineItem.Quantity;
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

        int duration = DurationService.DurationInDays(rentalTransaction.RentalDate, rentalTransaction.DueDate);

        expectedCost += costPerDay * duration;

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
    /// <param name="returnDate">The date the items are returned.</param>
    /// <returns>The line item's expeted cost over the rental period.</returns>
    public decimal CalculateAmountDue(DateTime returnDate)
    {
        decimal amountDue = 0;

        foreach (var lineItem in _returnLineItems)
        {
            decimal expectedCost = CalculateExpectedLineItemCostForDuration(lineItem);

            decimal actualCost = CalculateActualLineItemCostForDuration(lineItem, returnDate);

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
        ReturnTransaction returnTransaction = new ReturnTransaction(employee.EmployeeID, member.MemberID, DateTime.Now, CalculateAmountDue(DateTime.Now));
        return returnTransaction;
    }

    /// <summary>
    /// Saves a return transaction and associated return line items to the database.
    /// </summary>
    /// <param name="returnTransaction">The return transaction to save.</param>
    /// <param name="returnLineItems">The list of return line items to save.</param>
    /// <returns>The newly created ReturnTransactionID.</returns>
    public int SaveReturnTransaction(ReturnTransaction returnTransaction, List<ReturnLineItem> returnLineItems)
    {
        int returnTransactionID = 0;

        using (var scope = new TransactionScope())
        {
            try
            {
                // Save return transaction to the database and retrieve the ReturnTransactionID
                returnTransactionID = _returnTransactionController.AddReturnTransaction(returnTransaction);

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

        return returnTransactionID;
    }

    /// <summary>
    /// Checks if new quantity for a rental line item is valid.
    /// </summary>
    /// <param name="rentalLineItemID">The ID of the rental line item.</param>
    /// <param name="newQuantity">The integer to be the new quantity.</param>
    /// <exception cref="Exception">Thrown when the new quantity is invalid.</exception>
    public void ValidQuantity(int rentalLineItemID, int? newQuantity)
    {
        if (newQuantity == null)
        {
            throw new Exception("Invalid quantity. Quantity cannot be null.");
        }

        if (!int.TryParse(newQuantity.ToString(), out int parsedQuantity))
        {
            throw new Exception("Invalid quantity. Quantity must be a valid integer.");
        }

        if (parsedQuantity <= 0)
        {
            throw new Exception("Invalid quantity. Quantity must be greater than zero.");
        }

        RentalLineItem rentalLineItem = _rentalLineItemController.GetRentalLineItemByID(rentalLineItemID);
        int quantityOut = rentalLineItem.Quantity - rentalLineItem.QuantityReturned;

        if (parsedQuantity > quantityOut)
        {
            throw new Exception($"Cart quantity exceeds checked-out quantity.\n\nRental Line: {rentalLineItem.RentalLineItemID}\nFurniture ID:{rentalLineItem.FurnitureID}\n\nChecked-out Qty: {quantityOut}\nCart Qty: {parsedQuantity}");
        }
    }

    /// <summary>
    /// Checks all quantities in a DataGridView to ensure they do not exceed the checked-out quantities.
    /// </summary>
    /// <param name="dataGridView">The DataGridView with the quantities in it.</param>
    public void ValidAllQuantities(DataGridView dataGridView)
    {
        foreach (DataGridViewRow row in dataGridView.Rows)
        {
            if (row.Cells["Quantity"].Value != null && int.TryParse(row.Cells["Quantity"].Value.ToString(), out int newQuantity))
            {
                int rentalLineItemID = Convert.ToInt32(row.Cells["RentalLineItemID"].Value);
                ValidQuantity(rentalLineItemID, newQuantity);
            }
        }
    }

    /// <summary>
    /// Checks the quantity cell values in a DataGridView and re-styles invalid quantities.
    /// </summary>
    /// <param name="dataGridView">The DataGridView with the quantities in it.</param>
    /// <remarks>
    public void EvaluateQuantityCellValues(DataGridView dataGridView)
    {
        foreach (DataGridViewRow row in dataGridView.Rows)
        {
            if (row.Cells["Quantity"].Value != null && int.TryParse(row.Cells["Quantity"].Value.ToString(), out int newQuantity))
            {
                int rentalLineItemID = Convert.ToInt32(row.Cells["RentalLineItemID"].Value);

                try
                {
                    ValidQuantity(rentalLineItemID, newQuantity);
                    row.Cells["Quantity"].Style.BackColor = System.Drawing.SystemColors.Info;
                }
                catch (Exception)
                {
                    row.Cells["Quantity"].Style.BackColor = System.Drawing.Color.Pink;
                    row.Cells["Quantity"].ErrorText = "Invalid Quantity";
                }
            }
        }
    }

    /// <summary>
    /// Gets the return transaction by the given return transaction ID.
    /// </summary>
    /// <param name="returnTransactionID">The ID of the return transaction.</param>
    /// <returns>The return transaction.</returns>
    public ReturnTransaction GetReturnTransaction(int returnTransactionID)
    {
        return _returnTransactionController.GetReturnTransactionByReturnTransactionID(returnTransactionID);
    }

    /// <summary>
    /// Gets return cart items for a return transaction.
    /// </summary>
    /// <param name="returnTransactionID">A return transaction ID.</param>
    /// <returns>The list of return cart items for the given return transaction.</returns>
    public List<ReturnCartItem> GetReturnTransactionCartItems(int returnTransactionID)
    {
        List<ReturnLineItem> returnLineItems = _returnLineItemController.GetReturnLineItemsByReturnTransactionID(returnTransactionID);

        return GetReturnCartItems(returnLineItems);
    }
}
