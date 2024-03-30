using System;
using System.Data.SqlClient;

namespace RentMeApp.DAL
{
    /// <summary>
    /// The DAL that interacts with the authenticate controller. 
    /// </summary>
    public class AuthenticateDAL
    {
        /// <summary>
        /// Authenticates the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool Authenticate(string username, string password)
        {
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        "SELECT COUNT(*) FROM Login " +
                        "WHERE Username = @username and Password = HASHBYTES('MD5', @password)";

                    command.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
                    command.Parameters["@username"].Value = username;

                    command.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
                    command.Parameters["@password"].Value = password;

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count == 1;
                }
            }
        }

        /// <summary>
        /// Adds a new login entry to the database.
        /// </summary>
        /// <param name="username">The username of the login.</param>
        /// <param name="password">The password of the login.</param>
        public void AddLogin(string username, string password)
        {
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        "INSERT INTO Login (Username, Password) " +
                        "VALUES (@username, HASHBYTES('MD5', @password)";

                    command.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
                    command.Parameters["@username"].Value = username;

                    command.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
                    command.Parameters["@password"].Value = password;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
