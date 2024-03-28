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
        /// <param name="rentalLineItemID">The ID of the rental line item.</param>
        /// <param name="returnTransactionID">The ID of the return transaction.</param>
        /// <param name="quantity">The quantity of the return line item.</param>
        /// <param name="dailyCost">The daily cost of the return line item.</param>
        public ReturnLineItem(int rentalLineItemID, int returnTransactionID, int quantity, decimal dailyCost)
        {
            RentalLineItemID = rentalLineItemID;
            ReturnTransactionID = returnTransactionID;
            Quantity = quantity;
            DailyCost = dailyCost;
        }
    }
}
