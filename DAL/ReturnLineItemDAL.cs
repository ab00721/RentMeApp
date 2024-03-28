using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RentMeApp.DAL
{
    /// <summary>
    /// The Data Access Layer for the ReturnLineItem entity 
    /// </summary>
    public class ReturnLineItemDAL
    {
        /// <summary>
        /// Adds a return line item to the data.
        /// </summary>
        /// <param name="returnLineItem">The rental line item to add.</param>
        public void InsertReturnLineItem(ReturnLineItem returnLineItem)
        {
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO ReturnLineItem (RentalLineItemID, ReturnTransactionID, Quantity, DailyCost) " +
                                          "VALUES (@RentalLineItemID, @ReturnTransactionID, @Quantity, @DailyCost)";

                    command.Parameters.Add("@RentalLineItemID", SqlDbType.Int);
                    command.Parameters["@RentalLineItemID"].Value = returnLineItem.RentalLineItemID;

                    command.Parameters.Add("@ReturnTransactionID", SqlDbType.Int);
                    command.Parameters["@ReturnTransactionID"].Value = returnLineItem.ReturnTransactionID;

                    command.Parameters.Add("@Quantity", SqlDbType.Int);
                    command.Parameters["@Quantity"].Value = returnLineItem.Quantity;

                    command.Parameters.Add("@DailyCost", SqlDbType.Decimal);
                    command.Parameters["@DailyCost"].Value = returnLineItem.DailyCost;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Returns a list of all return line items.
        /// </summary>
        public List<ReturnLineItem> GetAllReturnLineItems()
        {
            List<ReturnLineItem> returnLineItems = new List<ReturnLineItem>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM ReturnLineItem", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnLineItem item = new ReturnLineItem(
                                Convert.ToInt32(reader["RentalLineItemID"]),
                                Convert.ToInt32(reader["ReturnTransactionID"]),
                                Convert.ToInt32(reader["Quantity"]),
                                Convert.ToDecimal(reader["DailyCost"])
                            );
                            returnLineItems.Add(item);
                        }
                    }
                }
            }
            return returnLineItems;
        }

        /// <summary>
        /// Returns a list of return line items by return transaction ID.
        /// </summary>
        /// <param name="returnTransactionID">The ID of the return transaction.</param>
        public List<ReturnLineItem> GetReturnLineItemsByReturnTransactionId(int returnTransactionID)
        {
            List<ReturnLineItem> returnLineItems = new List<ReturnLineItem>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM ReturnLineItem WHERE ReturnTransactionID = @ReturnTransactionID", connection))
                {
                    command.Parameters.Add("@ReturnTransactionID", SqlDbType.Int);
                    command.Parameters["@ReturnTransactionID"].Value = returnTransactionID;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnLineItem item = new ReturnLineItem(
                                Convert.ToInt32(reader["RentalLineItemID"]),
                                Convert.ToInt32(reader["ReturnTransactionID"]),
                                Convert.ToInt32(reader["Quantity"]),
                                Convert.ToDecimal(reader["DailyCost"])
                            );
                            returnLineItems.Add(item);
                        }
                    }
                }
            }
            return returnLineItems;
        }

        /// <summary>
        /// Returns a list of return line items by rental line item ID.
        /// </summary>
        /// <param name="rentalLineItemID">The ID of the rental line item.</param>
        public List<ReturnLineItem> GetReturnLineItemsByRentalLineItemID(int rentalLineItemID)
        {
            List<ReturnLineItem> returnLineItems = new List<ReturnLineItem>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM ReturnLineItem WHERE RentalLineItemID = @RentalLineItemID", connection))
                {
                    command.Parameters.Add("@RentalLineItemID", SqlDbType.Int);
                    command.Parameters["@RentalLineItemID"].Value = rentalLineItemID;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnLineItem item = new ReturnLineItem(
                                Convert.ToInt32(reader["RentalLineItemID"]),
                                Convert.ToInt32(reader["ReturnTransactionID"]),
                                Convert.ToInt32(reader["Quantity"]),
                                Convert.ToDecimal(reader["DailyCost"])
                            );
                            returnLineItems.Add(item);
                        }
                    }
                }
            }
            return returnLineItems;
        }
    }
}
