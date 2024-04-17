using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMeApp.Model
{
    public class CheckedOutItem
    {
        public int FurnitureID { get; set; }
        public string Name { get; set; }
        public int QuantityOut { get; set; }
        public decimal DailyRate { get; set; }
        public int RentalTransactionID { get; set; }
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Furniture"/> class.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        /// <param name="category">The category.</param>
        /// <param name="style">The style.</param>
        /// <param name="dailyRate">The daily rate.</param>
        /// <param name="totalQuantity">The total quantity.</param>
        /// <param name="inStockQuantity">The in stock quantity.</param>
        /// <exception cref="System.ArgumentException">
        /// Name - Name cannot be null or empty
        /// or
        /// category - category cannot be null or empty
        /// </exception>
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
