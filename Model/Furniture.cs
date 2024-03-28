using System;

namespace RentMeApp.Model
{
    /// <summary>
    /// Furniture model class
    /// </summary>
    public class Furniture
    {
        public int FurnitureID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Style { get; set; }
        public decimal DailyRate { get; set; }
        public int TotalQuantity { get; set; }
        public int InStockQuantity { get; set; }

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
        public Furniture(int furnitureID, string name, string description, string category, string style, decimal dailyRate, int totalQuantity, int inStockQuantity)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name", "Name cannot be null or empty");
            }

            if (string.IsNullOrEmpty(category))
            {
                throw new ArgumentException("category", "category cannot be null or empty");
            }

            if (furnitureID <= 0)
            {
                throw new ArgumentOutOfRangeException("Furniture ID", "Furniture ID  has to be > 0");
            }

            this.FurnitureID = furnitureID;
            this.Name = name;
            this.Description = description;
            this.Category = category;
            this.Style = style;
            this.DailyRate = dailyRate;
            this.TotalQuantity = totalQuantity;
            this.InStockQuantity = inStockQuantity;
        }
    }
}
