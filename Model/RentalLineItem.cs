namespace RentMeApp.Model
{
    /// <summary>
    /// RentalLineItem DTO class
    /// </summary>
    public class RentalLineItem
    {
        public int RentalLineItemID { get; set; }
        public int RentalTransactionID { get; set; }
        public int FurnitureID { get; set; }
        public int Quantity { get; set; }
        public int QuantityReturned { get; set; }
        public decimal DailyCost { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalLineItem"/> class.
        /// </summary>
        /// <param name="furnitureID">The furniture item's ID.</param>
        /// <param name="quantity">The number of furniture items rented.</param>
        /// <param name="quantityReturned">The number of furniture items returned so far.</param>
        /// <param name="dailyCost">The individual daily cost of renting the furniture item.</param>
        public RentalLineItem(int furnitureID, int quantity, int quantityReturned, decimal dailyCost)
        {
            FurnitureID = furnitureID;
            Quantity = quantity;
            QuantityReturned = quantityReturned;
            DailyCost = dailyCost;
        }
    }
}
