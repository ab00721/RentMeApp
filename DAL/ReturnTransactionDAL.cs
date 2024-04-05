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
        /// Adds a new return transaction.
        /// </summary>
        /// <param name="returnTransaction">The return transaction being added.</param>
        /// <returns>The ID of the just-added return transaction.</returns>
        public int InsertReturnTransaction(ReturnTransaction returnTransaction)
        {
            int returnTransactionID = 0;
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO ReturnTransaction (EmployeeID, MemberID, ReturnDate, TotalCost) " +
                                  "VALUES (@EmployeeID, @MemberID, @ReturnDate, @TotalCost); " +
                                  "SELECT SCOPE_IDENTITY();";

                    command.Parameters.Add("@EmployeeID", SqlDbType.Int);
                    command.Parameters["@EmployeeID"].Value = returnTransaction.EmployeeID;

                    command.Parameters.Add("@MemberID", SqlDbType.Int);
                    command.Parameters["@MemberID"].Value = returnTransaction.MemberID;

                    command.Parameters.Add("@ReturnDate", SqlDbType.Date);
                    command.Parameters["@ReturnDate"].Value = returnTransaction.ReturnDate;

                    command.Parameters.Add("@TotalCost", SqlDbType.Decimal);
                    command.Parameters["@TotalCost"].Value = returnTransaction.TotalCost;

                    connection.Open();
                    returnTransactionID = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return returnTransactionID;
        }

        /// <summary>
        /// Gets all return transactions.
        /// </summary>
        /// <returns>A list of all the return transactions.</returns>
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
        /// Gets a return transaction.
        /// </summary>
        /// <param name="returnTransactionId">A return transaction ID.</param>
        /// <returns>The return transaction with the given ID.</returns>
        public ReturnTransaction GetReturnTransactionByReturnTransactionID(int returnTransactionID)
        {
            ReturnTransaction returnTransaction = null;

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM ReturnTransaction WHERE ReturnTransactionID = @ReturnTransactionID", connection))
                {
                    command.Parameters.Add("@ReturnTransactionID", SqlDbType.Int);
                    command.Parameters["@ReturnTransactionID"].Value = returnTransactionID;

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

        
        public List<ReturnTransaction> GetAllReturnTransactionsByMemberId(int memberID)
        {
            List<ReturnTransaction> returnTransactions = new List<ReturnTransaction>();

            string selectStatement = "SELECT * FROM ReturnTransaction WHERE MemberID = @MemberID";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.Add("@MemberID", SqlDbType.Int);
                    command.Parameters["@MemberID"].Value = memberID;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnTransaction transaction = new ReturnTransaction();

                            transaction.ReturnTransactionID = (int)reader["ReturnTransactionID"];
                            transaction.EmployeeID = (int)reader["EmployeeID"];
                            transaction.MemberID = (int)reader["MemberID"];
                            transaction.ReturnDate = (DateTime)reader["ReturnDate"];
                            transaction.TotalCost = (decimal)reader["TotalCost"];

                            returnTransactions.Add(transaction);
                        }
                    }
                }
            }
            return returnTransactions;
        }

    }
}
