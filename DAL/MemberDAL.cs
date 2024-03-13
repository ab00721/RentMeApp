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
        public List<Member> GetMemberInfo()
        {
            var members = new List<Member>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        "SELECT M.MemberID, M.FirstName, M.LastName, M.Sex, M.DateOfBirth, M.AddressLine1, M.AddressLine2, M.City, M.State, M.Zip, M.Phone " +
                        "FROM Member M "; 
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int memberIDOrdinal = reader.GetOrdinal("MemberID");
                        int firstNameOrdinal = reader.GetOrdinal("FirstName");
                        int lastNameOrdinal = reader.GetOrdinal("LastName");
                        int sexOrdinal = reader.GetOrdinal("Sex");
                        int dateOfBirthOrdinal = reader.GetOrdinal("DateOfBirth");
                        int addressOneOrdinal = reader.GetOrdinal("AddressLine1");
                        int addressTwoOrdinal = reader.GetOrdinal("AddressLine2");
                        int cityOrdinal = reader.GetOrdinal("City");
                        int stateOrdinal = reader.GetOrdinal("State");
                        int zipOrdinal = reader.GetOrdinal("Zip");
                        int phoneOrdinal = reader.GetOrdinal("Phone");

                        while (reader.Read())
                        {
                            var memberID = reader.GetInt32(memberIDOrdinal);
                            var firstName = reader.GetString(firstNameOrdinal);
                            var lastName = reader.GetString(lastNameOrdinal);
                            var sex = reader.IsDBNull(sexOrdinal) ? "" : reader.GetString(sexOrdinal);
                            var dateOfBirth = reader.GetDateTime(dateOfBirthOrdinal);
                            var addressOne = reader.GetString(addressOneOrdinal);
                            var addressTwo = reader.IsDBNull(addressTwoOrdinal) ? "" : reader.GetString(addressTwoOrdinal);
                            var city = reader.GetString(cityOrdinal);
                            var state = reader.GetString(stateOrdinal);
                            var zip = reader.GetString(zipOrdinal);
                            var phone = reader.IsDBNull(phoneOrdinal) ? "" : reader.GetString(phoneOrdinal);
                            

                            members.Add(new Member(memberID, firstName, lastName, sex, dateOfBirth, addressOne, addressTwo, city, state, zip, phone));
                        }
                    }
                }
            }
            return members;
        }
    }
}
