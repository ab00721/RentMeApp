using RentMeApp.Model;
using System.Data.SqlClient;

namespace RentMeApp.DAL
{
    /// <summary>
    /// Employee Data Access Layer  
    /// </summary>
    public class EmployeeDAL
    {
        /// <summary>
        /// Gets the employee information.
        /// </summary>
        /// <returns></returns>
        public EmployeeDTO GetEmployeeByUsername(string username)
        {
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        "SELECT E.FirstName, E.IsAdmin " +
                        "FROM Employee E " +
                        "WHERE E.Username = @Username";

                    command.Parameters.Add("@Username", System.Data.SqlDbType.VarChar);
                    command.Parameters["@Username"].Value = username;

                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int firstNameOrdinal = reader.GetOrdinal("FirstName");
                        int isAdminOrdinal = reader.GetOrdinal("IsAdmin");

                        while (reader.Read())
                        {
                            var firstName = reader.GetString(firstNameOrdinal);
                            var isAdmin = reader.GetInt32(isAdminOrdinal);

                            return new EmployeeDTO(firstName, username, isAdmin);
                        }
                    }
                }
            }
            return null;
        }
    }
}
