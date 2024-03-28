using RentMeConsole.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMeConsole.DAL
{
    public class CategoryDAL
    {
        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT Category FROM Category", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string categoryName = reader.GetString(0);
                            Category category = new Category(categoryName);
                            categories.Add(category);
                        }
                    }
                }
            }

            return categories;
        }
    }
}
