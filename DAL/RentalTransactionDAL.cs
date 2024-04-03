using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RentMeApp.DAL
{
    /// <summary>
    /// The Data Access Layer for the RentalTransaction entity 
    /// </summary>
    public class RentalTransactionDAL
    {
        public int InsertRentalTransaction(RentalTransaction rentalTransaction)
        {
            int rentalTransactionID = 0;
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO RentalTransaction (EmployeeID, MemberID, RentalDate, DueDate, TotalCost) " +
                                          "VALUES (@EmployeeID, @MemberID, @RentalDate, @DueDate, @TotalCost);" +
                                          "SELECT SCOPE_IDENTITY();";

                    command.Parameters.Add("@EmployeeID", SqlDbType.Int);
                    command.Parameters["@EmployeeID"].Value = rentalTransaction.EmployeeID;

                    command.Parameters.Add("@MemberID", SqlDbType.Int);
                    command.Parameters["@MemberID"].Value = rentalTransaction.MemberID;

                    command.Parameters.Add("@RentalDate", SqlDbType.Date);
                    command.Parameters["@RentalDate"].Value = rentalTransaction.RentalDate;

                    command.Parameters.Add("@DueDate", SqlDbType.Date);
                    command.Parameters["@DueDate"].Value = rentalTransaction.DueDate;

                    command.Parameters.Add("@TotalCost", SqlDbType.Decimal);
                    command.Parameters["@TotalCost"].Value = rentalTransaction.TotalCost;

                    connection.Open();
                    rentalTransactionID = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return rentalTransactionID;
        }

        /// <summary>
        /// Gets all rental transactions.
        /// </summary>
        /// <returns>A list of all the rental transactions.</returns>
        public List<RentalTransaction> GetAllRentalTransactions()
        {
            List<RentalTransaction> rentalTransactions = new List<RentalTransaction>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM RentalTransaction", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RentalTransaction transaction = new RentalTransaction(
                                Convert.ToInt32(reader["EmployeeID"]),
                                Convert.ToInt32(reader["MemberID"]),
                                Convert.ToDateTime(reader["RentalDate"]),
                                Convert.ToDateTime(reader["DueDate"]),
                                Convert.ToDecimal(reader["TotalCost"])
                            );
                            transaction.RentalTransactionID = Convert.ToInt32(reader["RentalTransactionID"]);
                            rentalTransactions.Add(transaction);
                        }
                    }
                }
            }
            return rentalTransactions;
        }

        /// <summary>
        /// Gets a rental transaction.
        /// </summary>
        /// <param name="rentalTransactionID">A rental transaction ID.</param>
        /// <returns>The rental transaction with the given ID.</returns>
        public RentalTransaction GetRentalTransactionByRentalTransactionID(int rentalTransactionID)
        {
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM RentalTransaction WHERE RentalTransactionID = @RentalTransactionID";

                    command.Parameters.Add("@RentalTransactionID", SqlDbType.Int);
                    command.Parameters["@RentalTransactionID"].Value = rentalTransactionID;

                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new RentalTransaction(
                                Convert.ToInt32(reader["EmployeeID"]),
                                Convert.ToInt32(reader["MemberID"]),
                                Convert.ToDateTime(reader["RentalDate"]),
                                Convert.ToDateTime(reader["DueDate"]),
                                Convert.ToDecimal(reader["TotalCost"])
                            );
                        }
                    }
                }
            }
            return null;
        }
      
        /// Gets the rental transaction that is associated with a given rental line item ID.
        /// </summary>
        /// <param name="rentalLineItemID">The rental line item ID to use for finding a rental transaction.</param>
        /// <returns>The rental transaction with the given rental line item ID.</returns>
        public RentalTransaction GetRentalTransactionByRentalLineItemID(int rentalLineItemID)
        {
            RentalTransaction rentalTransaction = null;

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM RentalTransaction WHERE RentalTransactionID IN (SELECT RentalTransactionID FROM RentalLineItem WHERE RentalLineItemID = @RentalLineItemID)", connection))
                {
                    command.Parameters.Add("@RentalLineItemID", SqlDbType.Int);
                    command.Parameters["@RentalLineItemID"].Value = rentalLineItemID;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rentalTransaction = new RentalTransaction(
                                Convert.ToInt32(reader["EmployeeID"]),
                                Convert.ToInt32(reader["MemberID"]),
                                Convert.ToDateTime(reader["RentalDate"]),
                                Convert.ToDateTime(reader["DueDate"]),
                                Convert.ToDecimal(reader["TotalCost"])
                            );

                            rentalTransaction.RentalTransactionID = Convert.ToInt32(reader["RentalTransactionID"]);
                        }
                    }
                }
            }
            return rentalTransaction;
        }

        /// <summary>
        /// Gets all rental transactions by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
        public List<RentalTransaction> GetAllRentalTransactionsByMemberId(int memberID)
        {
            List<RentalTransaction> rentalTransactions = new List<RentalTransaction>();

            string selectStatement = "SELECT * FROM RentalTransaction WHERE MemberID = @MemberID";

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
                            RentalTransaction transaction = new RentalTransaction();

                            transaction.RentalTransactionID = (int)reader["RentalTransactionID"];
                            transaction.EmployeeID = (int)reader["EmployeeID"];
                            transaction.MemberID = (int)reader["MemberID"];
                            transaction.MemberID = (int)reader["MemberID"];
                            transaction.RentalDate = (DateTime)reader["RentalDate"];
                            transaction.DueDate = (DateTime)reader["DueDate"];
                            transaction.TotalCost = (decimal)reader["TotalCost"];

                            rentalTransactions.Add(transaction);
                        }
                    }
                }
            }
            return rentalTransactions;
        }

    }
}
