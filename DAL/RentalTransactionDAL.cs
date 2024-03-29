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
        /// <summary>
        /// Adds a rental transaction to the data.
        /// </summary>
        /// <param name="rentalTransaction">The rental transaction to be added.</param>
        public void InsertRentalTransaction(RentalTransaction rentalTransaction)
        {
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO RentalTransaction (EmployeeID, MemberID, RentalDate, DueDate, TotalCost) " +
                                          "VALUES (@EmployeeID, @MemberID, @RentalDate, @DueDate, @TotalCost)";

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
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Returns a list of all rental transactions.
        /// </summary
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
                            rentalTransactions.Add(transaction);
                        }
                    }
                }
            }
            return rentalTransactions;
        }

        /// <summary>
        /// Returns a rental transaction.
        /// </summary>
        /// <param name="rentalTransactionID">The ID of the rental transaction.</param>
        public RentalTransaction GetRentalTransactionByRentalTransactionId(int rentalTransactionID)
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
