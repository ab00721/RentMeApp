using RentMeConsole.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RentMeConsole.DAL
{
    public class RentalTransactionDAL
    {
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
    }
}
