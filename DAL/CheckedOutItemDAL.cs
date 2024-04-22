using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace RentMeApp.DAL
{
    /// <summary>
    /// The Data Access Layer for the CheckedOutItem entity 
    /// </summary>
    public class CheckedOutItemDAL
    {

        /// <summary>
        /// Retrieves a list of checked-out items associated with a given rental transaction ID.
        /// </summary>
        /// <param name="rentalTransactionID">The ID of the rental transaction.</param>
        /// <returns>A list of the checked-out items.</returns>
        public List<CheckedOutItem> GetCheckedOutItemsByRentalTransactionID(int rentalTransactionID)
        {
            List<CheckedOutItem> checkedOutItems = new List<CheckedOutItem>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(
                    "SELECT RLI.FurnitureID, F.Name, (RLI.Quantity - RLI.QuantityReturned) AS QuantityOut, RLI.RentalTransactionID, RLI.RentalLineItemID, RLI.DailyCost, RT.DueDate " +
                    "FROM RentalLineItem RLI " +
                    "INNER JOIN Furniture F ON RLI.FurnitureID = F.FurnitureID " +
                    "INNER JOIN RentalTransaction RT ON RLI.RentalTransactionID = RT.RentalTransactionID " +
                    "WHERE RLI.RentalTransactionID = @RentalTransactionID AND (RLI.Quantity - RLI.QuantityReturned) > 0", connection))
                {
                    command.Parameters.Add("@RentalTransactionID", SqlDbType.Int);
                    command.Parameters["@RentalTransactionID"].Value = rentalTransactionID;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CheckedOutItem item = new CheckedOutItem(
                                Convert.ToInt32(reader["FurnitureID"]),
                                Convert.ToString(reader["Name"]),
                                Convert.ToInt32(reader["QuantityOut"]),
                                Convert.ToDecimal(reader["DailyCost"]),
                                Convert.ToInt32(reader["RentalTransactionID"]),
                                Convert.ToInt32(reader["RentalLineItemID"]),
                                Convert.ToDateTime(reader["DueDate"])
                            );

                            checkedOutItems.Add(item);
                        }
                    }
                }
            }

            return checkedOutItems;
        }

        /// <summary>
        /// Checks if checked-out items exist for a specific member ID.
        /// </summary>
        /// <param name="memberID">The member ID.</param>
        /// <returns>True if checked-out items exist for the member; otherwise, false.</returns>
        public bool CheckedOutItemsExistForMember(int memberID)
        {
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(
                    "SELECT COUNT(*) " +
                    "FROM RentalLineItem RLI " +
                    "INNER JOIN RentalTransaction RT ON RLI.RentalTransactionID = RT.RentalTransactionID " +
                    "WHERE RT.MemberID = @MemberID AND (RLI.Quantity - RLI.QuantityReturned) > 0", connection))
                {
                    command.Parameters.Add("@MemberID", SqlDbType.Int);
                    command.Parameters["@MemberID"].Value = memberID;

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
    }
}
