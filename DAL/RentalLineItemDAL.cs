using RentMeApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RentMeApp.DAL
{
    public class RentalLineItemDAL
    {
        public void InsertRentalLineItem(RentalLineItem rentalLineItem)
        {
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO RentalLineItem (RentalTransactionID, FurnitureID, Quantity, QuantityReturned, DailyCost) VALUES (@RentalTransactionID, @FurnitureID, @Quantity, @QuantityReturned, @DailyCost)";

                    command.Parameters.Add("@RentalTransactionID", SqlDbType.Int);
                    command.Parameters["@RentalTransactionID"].Value = rentalLineItem.RentalTransactionID;

                    command.Parameters.Add("@FurnitureID", SqlDbType.Int);
                    command.Parameters["@FurnitureID"].Value = rentalLineItem.FurnitureID;

                    command.Parameters.Add("@Quantity", SqlDbType.Int);
                    command.Parameters["@Quantity"].Value = rentalLineItem.Quantity;

                    command.Parameters.Add("@QuantityReturned", SqlDbType.Int);
                    command.Parameters["@QuantityReturned"].Value = rentalLineItem.QuantityReturned;

                    command.Parameters.Add("@DailyCost", SqlDbType.Decimal);
                    command.Parameters["@DailyCost"].Value = rentalLineItem.DailyCost;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<RentalLineItem> GetRentalLineItemsByRentalTransactionId(int rentalTransactionID)
        {
            List<RentalLineItem> rentalLineItems = new List<RentalLineItem>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM RentalLineItem WHERE RentalTransactionID = @RentalTransactionID", connection))
                {
                    command.Parameters.Add("@RentalTransactionID", SqlDbType.Int);
                    command.Parameters["@RentalTransactionID"].Value = rentalTransactionID;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RentalLineItem item = new RentalLineItem(
                                Convert.ToInt32(reader["RentalTransactionID"]),
                                Convert.ToInt32(reader["FurnitureID"]),
                                Convert.ToInt32(reader["Quantity"]),
                                Convert.ToInt32(reader["QuantityReturned"]),
                                Convert.ToDecimal(reader["DailyCost"])
                            );
                            rentalLineItems.Add(item);
                        }
                    }
                }
            }
            return rentalLineItems;
        }
    }
}
