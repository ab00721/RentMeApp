using System;

namespace RentMeApp.Model
{
    /// <summary>
    /// Checked Out Item model class
    /// </summary>
    public class CheckedOutItem
    {
        public int FurnitureID { get; set; }
        public string Name { get; set; }
        public int QuantityOut { get; set; }
        public decimal DailyRate { get; set; }
        public int RentalTransactionID { get; set; }
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckedOutItem"/> class.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="quantityOut">The quantity out.</param>
        /// <param name="dailyRate">The daily rate.</param>
        /// <param name="rentalTransactionID">The rental transaction identifier.</param>
        /// <param name="dueDate">The due date.</param>
        /// <exception cref="System.ArgumentException">Name - Name cannot be null or empty</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Furniture ID - Furniture ID  has to be > 0</exception>
        public CheckedOutItem(int furnitureID, string name, int quantityOut, decimal dailyRate, int rentalTransactionID, DateTime dueDate)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name", "Name cannot be null or empty");
            }

            if (furnitureID <= 0)
            {
                throw new ArgumentOutOfRangeException("Furniture ID", "Furniture ID  has to be > 0");
            }

            if (quantityOut < 0)
            {
                throw new ArgumentOutOfRangeException("Furniture ID", "Furniture ID  has to be > 0");
            }

            this.FurnitureID = furnitureID;
            this.Name = name;
            this.QuantityOut = quantityOut;
            this.DailyRate = dailyRate;
            this.RentalTransactionID = rentalTransactionID;
            this.DueDate = dueDate;
        }
    }
}
