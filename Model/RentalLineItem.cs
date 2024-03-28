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
        /// <param name="rentalTransactionID">The ID of the rental transaction.</param>
        /// <param name="furnitureID">The ID of the furniture.</param>
        /// <param name="quantity">The quantity of the furniture.</param>
        /// <param name="quantityReturned">The quantity of the furniture returned.</param>
        /// <param name="dailyCost">The daily cost of renting the furniture.</param>
        public RentalLineItem(int rentalTransactionID, int furnitureID, int quantity, int quantityReturned, decimal dailyCost)
        {
            RentalTransactionID = rentalTransactionID;
            FurnitureID = furnitureID;
            Quantity = quantity;
            QuantityReturned = quantityReturned;
            DailyCost = dailyCost;
        }
    }
}
