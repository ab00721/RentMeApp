using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMeApp.DAL
{
    public class CheckedOutItemDAL
    {
        public List<CheckedOutItem> GetCheckedOutItemsByRentalTransactionID(int rentalTransactionID)
        {
            List<CheckedOutItem> checkedOutItems = new List<CheckedOutItem>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(
                    "SELECT RLI.FurnitureID, F.Name, (RLI.Quantity - RLI.QuantityReturned) AS QuantityOut, RLI.RentalTransactionID, RLI.DailyCost, RT.DueDate " +
                    "FROM RentalLineItem RLI " +
                    "INNER JOIN Furniture F ON RLI.FurnitureID = F.FurnitureID " +
                    "INNER JOIN RentalTransaction RT ON RLI.RentalTransactionID = RT.RentalTransactionID " +
                    "WHERE RLI.RentalTransactionID = @RentalTransactionID", connection))
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
                                Convert.ToDateTime(reader["DueDate"])
                            );
                            
                            checkedOutItems.Add(item);
                        }
                    }
                }
            }

            return checkedOutItems;
        }
    }
}
