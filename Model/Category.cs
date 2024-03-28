namespace RentMeApp.Model
{
    /// <summary>
    /// Category DTO class
    /// </summary>
    public class Category
    {
        public string CategoryName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        /// <param name="categoryName">The name of the category.</param>
        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}
