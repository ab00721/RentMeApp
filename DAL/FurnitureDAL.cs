﻿using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        /// <summary>
        /// Gets the furniture.
        /// </summary>
        /// <param name="searchBy">The search by.</param>
        /// <param name="searchCriteria">The search criteria.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Invalid search</exception>
        public List<Furniture> GetFurniture(string searchBy, string searchCriteria)
        {
            var furniture = new List<Furniture>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    string search = "";
                    switch (searchBy)
                    {
                        case "searchID":
                            search = "F.FurnitureID = @SearchID";
                            break;
                        case "searchCategory":
                            search = "LOWER(F.Category) LIKE LOWER(@SearchCategory)";
                            break;
                        case "searchStyle":
                            search = "LOWER(F.Style) LIKE LOWER(@SearchStyle)";
                            break;
                        default:
                            throw new ArgumentException("Invalid search");
                    }

                    command.CommandText =
                        "SELECT F.FurnitureID, F.Name, F.Description, F.Category, F.Style, F.DailyRate, F.TotalQuantity, F.InStockQuantity " +
                        "FROM Furniture F " +
                        "WHERE " + search;
                    command.Parameters.Add("@SearchID", SqlDbType.VarChar);
                    command.Parameters["@SearchID"].Value = searchCriteria;
                    command.Parameters.Add("@SearchCategory", SqlDbType.VarChar);
                    command.Parameters["@SearchCategory"].Value = "%" + searchCriteria + "%";
                    command.Parameters.Add("@SearchStyle", SqlDbType.VarChar);
                    command.Parameters["@SearchStyle"].Value = "%" + searchCriteria + "%";
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
