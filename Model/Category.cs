namespace RentMeConsole.Models
{
    public class Category
    {
        public string CategoryName { get; set; }

        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}
