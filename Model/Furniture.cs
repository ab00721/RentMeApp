namespace RentMeConsole.Models
{
    public class Furniture
    {
        public int FurnitureID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Style Style { get; set; }
        public decimal DailyRate { get; set; }
        public int TotalQuantity { get; set; }
        public int InStockQuantity { get; set; }

        public Furniture(int id, string name, string description, Category category, Style style, decimal dailyRate, int totalQuantity, int inStockQuantity)
        {
            FurnitureID = id;
            Name = name;
            Description = description;
            Category = category;
            Style = style;
            DailyRate = dailyRate;
            TotalQuantity = totalQuantity;
            InStockQuantity = inStockQuantity;
        }
    }
}

