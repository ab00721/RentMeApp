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
        /// Gets a return line item.
        /// </summary>
        /// <param name="returnLineItemID">A return line item ID.</param>
        /// <returns>The return line item with the given ID.</returns>
        public ReturnLineItem GetReturnLineItemByID(int returnLineItemID)
        {
            ReturnLineItem returnLineItem = null;

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM ReturnLineItem WHERE ReturnLineItemID = @ReturnLineItemID", connection))
                {
                    command.Parameters.Add("@ReturnLineItemID", SqlDbType.Int);
                    command.Parameters["@ReturnLineItemID"].Value = returnLineItemID;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            returnLineItem = new ReturnLineItem(
                                Convert.ToInt32(reader["RentalLineItemID"]),
                                Convert.ToInt32(reader["Quantity"]),
                                Convert.ToDecimal(reader["DailyCost"])
                            );
                            returnLineItem.ReturnLineItemID = Convert.ToInt32(reader["ReturnLineItemID"]);
                            returnLineItem.ReturnTransactionID = Convert.ToInt32(reader["ReturnTransactionID"]);
                        }
                    }
                }
            }
            return returnLineItem;
        }

        /// <summary>
        /// Gets all return line items.
        /// </summary>
        /// <returns>A list of return line items.</returns>
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
                                Convert.ToInt32(reader["Quantity"]),
                                Convert.ToDecimal(reader["DailyCost"])
                            );
                            item.ReturnLineItemID = Convert.ToInt32(reader["ReturnLineItemID"]);
                            item.ReturnTransactionID = Convert.ToInt32(reader["ReturnTransactionID"]);
                            returnLineItems.Add(item);
                        }
                    }
                }
            }
            return returnLineItems;
        }

        /// <summary>
        /// Gets the return line items by return transaction ID.
        /// </summary>
        /// <param name="returnTransactionID">A return transaction ID.</param>
        /// <returns>A list of the return line items for the given return transaction.</returns>
        public List<ReturnLineItem> GetReturnLineItemsByReturnTransactionID(int returnTransactionID)
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
                                Convert.ToInt32(reader["Quantity"]),
                                Convert.ToDecimal(reader["DailyCost"])
                            );
                            item.ReturnLineItemID = Convert.ToInt32(reader["ReturnLineItemID"]);
                            item.ReturnTransactionID = Convert.ToInt32(reader["ReturnTransactionID"]);
                            returnLineItems.Add(item);
                        }
                    }
                }
            }
            return returnLineItems;
        }

        /// <summary>
        /// Gets the return line items by rental line item ID.
        /// </summary>
        /// <param name="rentalLineItemID">A rental line item ID.</param>
        /// <returns>A list of the return line items for the given rental line item.</returns>
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
                                Convert.ToInt32(reader["Quantity"]),
                                Convert.ToDecimal(reader["DailyCost"])
                            );
                            item.ReturnLineItemID = Convert.ToInt32(reader["ReturnLineItemID"]);
                            item.ReturnTransactionID = Convert.ToInt32(reader["ReturnTransactionID"]);
                            returnLineItems.Add(item);
                        }
                    }
                }
            }
            return returnLineItems;
        }
    }
}
