using RentMeApp.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMeApp.DAL
{
    /// <summary>
    /// Furniture Data Access Layer  
    /// </summary>
    public class FurnitureDAL
    {
        /// <summary>
        /// Gets the furniture.
        /// </summary>
        /// <returns></returns>
        public List<Furniture> GetFurniture()
        {
            var furniture = new List<Furniture>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        "SELECT F.FurnitureID, F.Name, F.Description, F.Category, F.Style, F.DailyRate, F.TotalQuantity, F.InStockQuantity " +
                        "FROM Furniture F ";
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int furnitureIDOrdinal = reader.GetOrdinal("FurnitureID");
                        int nameOrdinal = reader.GetOrdinal("Name");
                        int descriptionOrdinal = reader.GetOrdinal("Description");
                        int categoryOrdinal = reader.GetOrdinal("Category");
                        int styleOrdinal = reader.GetOrdinal("Style");
                        int dailyRateOrdinal = reader.GetOrdinal("DailyRate");
                        int totalQuantityOrdinal = reader.GetOrdinal("TotalQuantity");
                        int inStockQuantityOrdinal = reader.GetOrdinal("InStockQuantity");

                        while (reader.Read())
                        {
                            var furnitureID = reader.GetInt32(furnitureIDOrdinal);
                            var name = reader.GetString(nameOrdinal);
                            var description = reader.GetString(descriptionOrdinal);
                            var category = reader.GetString(categoryOrdinal);
                            var style = reader.GetString(styleOrdinal);
                            var dailyRate = reader.GetDecimal(dailyRateOrdinal);
                            var totalQuantity = reader.GetInt32(totalQuantityOrdinal);
                            var inStockQuantity = reader.GetInt32(inStockQuantityOrdinal);
                           
                            furniture.Add(new Furniture(furnitureID, name, description, category, style, dailyRate, totalQuantity, inStockQuantity));
                        }
                    }
                }
            }
            return furniture;
        }
    }
}
