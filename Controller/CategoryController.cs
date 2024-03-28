using RentMeApp.DAL;
using RentMeApp.Model;
using System.Collections.Generic;

namespace RentMeApp.Controllers
{
    /// <summary>
    /// The controller class that mediates b/w the CategoryDAL and the view.
    /// </summary>
    public class CategoryController
    {
        private readonly CategoryDAL _categorySource;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryController"/> class.
        /// </summary>
        public CategoryController()
        {
            _categorySource = new CategoryDAL();
        }

        /// <summary>
        /// Returns a list of all categories.
        /// </summary>
        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();

            foreach (Category category in _categorySource.GetAllCategories())
            {
                categories.Add(category);
            }

            return categories;
        }
    }
}
