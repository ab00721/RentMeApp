using System.Data.SqlClient;

namespace RentMeApp.DAL
{
    /// <summary>
    /// Class to connect to the database
    /// </summary>
    public class RentMeDBConnection
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns>database connection</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                // "Data Source=localhost;Initial Catalog=cs6232-g5; " +
                // "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=cs6232-g5;" +
                "Data Source=REG-DBARBERO3\\SQLEXPRESS;Initial Catalog=cs6232-g5; " +
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
