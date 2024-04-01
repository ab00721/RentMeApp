namespace RentMeApp.Model
{
    /// <summary>
    /// ReturnLineItem DTO class
    /// </summary>
    public class ReturnLineItem
    {
        public int ReturnLineItemID { get; set; }
        public int RentalLineItemID { get; set; }
        public int ReturnTransactionID { get; set; }
        public int Quantity { get; set; }
        public decimal DailyCost { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnLineItem"/> class.
        /// </summary>
        /// <param name="rentalLineItemID">The ID of the associated rental line item.</param>
        /// <param name="quantity">The number of furniture items being returned</param>
        /// <param name="dailyCost">The individual daily cost of renting the furniture item.</param>
        public ReturnLineItem(int rentalLineItemID, int quantity, decimal dailyCost)
        {
            RentalLineItemID = rentalLineItemID;
            Quantity = quantity;
            DailyCost = dailyCost;
        }
    }
}
