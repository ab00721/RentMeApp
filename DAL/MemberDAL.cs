using RentMeApp.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMeApp.DAL
{
    /// <summary>
    /// Member Data Access Layer
    /// </summary>
    public class MemberDAL
    {
        /// <summary>
        /// Gets the member information.
        /// </summary>
        /// <returns></returns>
        public List<MemberDTO> GetMemberInfo()
        {
            var members = new List<MemberDTO>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        "SELECT M.MemberID, M.FirstName, M.LastName, M.Phone " +
                        "FROM Member M "; 
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int memberIDOrdinal = reader.GetOrdinal("MemberID");
                        int firstNameOrdinal = reader.GetOrdinal("FirstName");
                        int lastNameOrdinal = reader.GetOrdinal("LastName");
                        int phoneOrdinal = reader.GetOrdinal("Phone");

                        while (reader.Read())
                        {
                            var memberID = reader.GetInt32(memberIDOrdinal);
                            var firstName = reader.GetString(firstNameOrdinal);
                            var lastName = reader.GetString(lastNameOrdinal);
                            var phone = reader.IsDBNull(phoneOrdinal) ? "" : reader.GetString(phoneOrdinal);
                            

                            members.Add(new MemberDTO(memberID, firstName, lastName, phone));
                        }
                    }
                }
            }
            return members;
        }
    }
}
