using RentMeConsole.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMeConsole.DAL
{
    public class FurnitureDAL
    {
        public List<Furniture> GetAllFurniture()
        {
            List<Furniture> furnitureList = new List<Furniture>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Furniture", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Category category = new Category(Convert.ToString(reader["Category"]));
                            Style style = new Style(Convert.ToString(reader["Style"]));

                            Furniture furniture = new Furniture(
                                Convert.ToInt32(reader["FurnitureID"]),
                                Convert.ToString(reader["Name"]),
                                Convert.ToString(reader["Description"]),
                                category,
                                style,
                                Convert.ToDecimal(reader["DailyRate"]),
                                Convert.ToInt32(reader["TotalQuantity"]),
                                Convert.ToInt32(reader["InStockQuantity"])
                            );

                            furnitureList.Add(furniture);
                        }
                    }
                }
            }

            return furnitureList;
        }
    }
}
