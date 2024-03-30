using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RentMeApp.DAL
{
    /// <summary>
    /// The Data Access Layer for the RentalLineItem entity 
    /// </summary>
    public class RentalLineItemDAL
    {
        /// <summary>
        /// Adds a rental line item to the data.
        /// </summary>
        /// <param name="rentalLineItem">The rental line item to be added.</param>
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

        /// <summary>
        /// Returns a list of rental line items by rental transaction ID.
        /// </summary>
        /// <param name="rentalTransactionID">The ID of the rental transaction.</param>
        /// <returns>A list of rental line items.</returns>
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
                            item.RentalLineItemID = Convert.ToInt32(reader["RentalLineItemID"]);
                            rentalLineItems.Add(item);
                        }
                    }
                }
            }
            return rentalLineItems;
        }
    }
}
