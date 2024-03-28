using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RentMeApp.DAL
{
    /// <summary>
    /// The Data Access Layer for the ReturnTransaction entity 
    /// </summary>
    public class ReturnTransactionDAL
    {
        /// <summary>
        /// Adds a return transaction to the data.
        /// </summary>
        /// <param name="returnTransaction">The return transaction to add.</param>
        public void InsertReturnTransaction(ReturnTransaction returnTransaction)
        {
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO ReturnTransaction (EmployeeID, MemberID, ReturnDate, TotalCost) " +
                                          "VALUES (@EmployeeID, @MemberID, @ReturnDate, @TotalCost)";

                    command.Parameters.Add("@EmployeeID", SqlDbType.Int);
                    command.Parameters["@EmployeeID"].Value = returnTransaction.EmployeeID;

                    command.Parameters.Add("@MemberID", SqlDbType.Int);
                    command.Parameters["@MemberID"].Value = returnTransaction.MemberID;

                    command.Parameters.Add("@ReturnDate", SqlDbType.Date);
                    command.Parameters["@ReturnDate"].Value = returnTransaction.ReturnDate;

                    command.Parameters.Add("@TotalCost", SqlDbType.Decimal);
                    command.Parameters["@TotalCost"].Value = returnTransaction.TotalCost;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Returns a list of all return transactions.
        /// </summary
        public List<ReturnTransaction> GetAllReturnTransactions()
        {
            List<ReturnTransaction> returnTransactions = new List<ReturnTransaction>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM ReturnTransaction", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnTransaction transaction = new ReturnTransaction(
                                Convert.ToInt32(reader["EmployeeID"]),
                                Convert.ToInt32(reader["MemberID"]),
                                Convert.ToDateTime(reader["ReturnDate"]),
                                Convert.ToDecimal(reader["TotalCost"])
                            );
                            returnTransactions.Add(transaction);
                        }
                    }
                }
            }
            return returnTransactions;
        }

        /// <summary>
        /// Returns a return transaction.
        /// </summary>
        /// <param name="returnTransactionID">The ID of the return transaction.</param>
        public ReturnTransaction GetReturnTransactionByReturnTransactionId(int returnTransactionId)
        {
            ReturnTransaction returnTransaction = null;

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM ReturnTransaction WHERE ReturnTransactionId = @ReturnTransactionId", connection))
                {
                    command.Parameters.Add("@ReturnTransactionId", SqlDbType.Int);
                    command.Parameters["@ReturnTransactionId"].Value = returnTransactionId;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            returnTransaction = new ReturnTransaction(
                                Convert.ToInt32(reader["EmployeeID"]),
                                Convert.ToInt32(reader["MemberID"]),
                                Convert.ToDateTime(reader["ReturnDate"]),
                                Convert.ToDecimal(reader["TotalCost"])
                            );
                        }
                    }
                }
            }
            return returnTransaction;
        }
    }
}
