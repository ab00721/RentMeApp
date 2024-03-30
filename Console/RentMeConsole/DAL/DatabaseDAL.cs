using System.Data.SqlClient;

namespace RentMeConsole.DAL
{
    public class DatabaseDAL
    {
        public void DeleteAllTransactions()
        {
            string[] tables = { "ReturnLineItem", "RentalLineItem", "ReturnTransaction", "RentalTransaction" };
            foreach (string table in tables)
            {
                DeleteAllRows(table);
            }
        }

        public void DeleteAllRows(string tableName)
        {
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                string deleteAllRowsScript = $"DELETE FROM {tableName}";

                using (SqlCommand command = new SqlCommand(deleteAllRowsScript, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
