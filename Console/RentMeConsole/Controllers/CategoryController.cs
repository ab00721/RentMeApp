using RentMeConsole.DAL;
using RentMeConsole.Models;
using System.Collections.Generic;

namespace RentMeConsole.Controllers
{
    public class CategoryController
    {
        private readonly CategoryDAL _categorySource;

        public CategoryController()
        {
            _categorySource = new CategoryDAL();
        }

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
