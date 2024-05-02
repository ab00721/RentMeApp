namespace RentMeApp.Model
{
    /// <summary>
    /// Represents a line in the rental cart with optimal fields for 
    /// viewing the data in a data grid view
    /// </summary>
    public class RentalCartItem
    {
        public int FurnitureID { get; set; }
        public string Name { get; set; }
        public decimal DailyRate { get; set; }
        public int Quantity { get; set; }
        public int QuantityReturned { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalCartItem"/> class.
        /// </summary>
        /// <param name="furniture">The furniture item.</param>
        /// <param name="quantity">The quantity of the furniture item.</param>
        /// <param name="dailyRate">The daily rental rate of the furniture item.</param>
        public RentalCartItem(Furniture furniture, int quantity, int quantityReturned, decimal dailyRate)
        {
            FurnitureID = furniture.FurnitureID;
            Name = furniture.Name;
            DailyRate = dailyRate;
            Quantity = quantity;
            QuantityReturned = quantityReturned;
            Price = dailyRate * quantity;
        }
    }
}
