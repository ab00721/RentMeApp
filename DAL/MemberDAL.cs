using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        /// <summary>
        /// Gets the member information.
        /// </summary>
        /// <param name="searchBy">The search by.</param>
        /// <param name="searchCriteria">The search criteria.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Invalid search</exception>
        public List<Member> GetMemberInfo(string searchBy, string searchCriteria)
        {
            var members = new List<Member>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    string search = "";
                    switch (searchBy)
                    {
                        case "searchID":
                            search = "M.MemberID = @SearchID";
                            break;
                        case "searchName":
                            search = "LOWER(M.FirstName + ' ' + M.LastName) LIKE LOWER(@SearchName)";
                            break;
                        case "searchPhone":
                            search = "M.Phone LIKE @SearchPhone";
                            break;
                        default:
                            throw new ArgumentException("Invalid search");
                    }
                    command.CommandText =
                        "SELECT M.MemberID, M.FirstName, M.LastName, M.Sex, M.DateOfBirth, M.AddressLine1, M.AddressLine2, M.City, M.State, M.Zip, M.Phone " +
                        "FROM Member M " +
                        "WHERE " + search;
                    command.Parameters.Add("@SearchID", SqlDbType.VarChar);
                    command.Parameters["@SearchID"].Value = searchCriteria;
                    command.Parameters.Add("@SearchName", SqlDbType.VarChar);
                    command.Parameters["@SearchName"].Value = "%" + searchCriteria + "%";
                    command.Parameters.Add("@SearchPhone", SqlDbType.VarChar);
                    command.Parameters["@SearchPhone"].Value = "%" + searchCriteria + "%";
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

        /// <summary>
        /// Inserts the new member.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns></returns>
        public int InsertNewMember(Member member)
        {
            int memberId;
            string insertStatement = "INSERT INTO [dbo].[Member] ([LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) OUTPUT Inserted.MemberID " +
                "VALUES (@LastName, @FirstName, @Sex, @DateOfBirth, @AddressLine1, @AddressLine2, @City, @State, @Zip, @Phone)";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.Add("@LastName", SqlDbType.VarChar);
                    insertCommand.Parameters["@LastName"].Value = member.LastName;

                    insertCommand.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    insertCommand.Parameters["@FirstName"].Value = member.FirstName;

                    insertCommand.Parameters.Add("@Sex", SqlDbType.Char);
                    insertCommand.Parameters["@Sex"].Value = member.Sex == "-- Select --" ? DBNull.Value : (object)member.Sex;

                    insertCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date);
                    insertCommand.Parameters["@DateOfBirth"].Value = member.DateOfBirth;

                    insertCommand.Parameters.Add("@AddressLine1", SqlDbType.VarChar);
                    insertCommand.Parameters["@AddressLine1"].Value = member.AddressOne;

                    insertCommand.Parameters.Add("@AddressLine2", SqlDbType.VarChar);
                    insertCommand.Parameters["@AddressLine2"].Value = string.IsNullOrEmpty(member.AddressTwo) ? DBNull.Value : (object)member.AddressTwo;

                    insertCommand.Parameters.Add("@City", SqlDbType.VarChar);
                    insertCommand.Parameters["@City"].Value = member.City;

                    insertCommand.Parameters.Add("@State", SqlDbType.Char);
                    insertCommand.Parameters["@State"].Value = member.State;

                    insertCommand.Parameters.Add("@Zip", SqlDbType.VarChar);
                    insertCommand.Parameters["@Zip"].Value = member.Zip;

                    insertCommand.Parameters.Add("@Phone", SqlDbType.VarChar);
                    insertCommand.Parameters["@Phone"].Value = string.IsNullOrEmpty(member.Phone) ? DBNull.Value : (object)member.Phone;

                    memberId = (int)insertCommand.ExecuteScalar();
                }
            }
            return memberId;
        }

        /// <summary>
        /// Updates the existing member.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns>The number of rows affected.</returns>
        public int UpdateExistingMember(Member member)
        {
            int rowsAffected;
            string updateStatement = "UPDATE [dbo].[Member] SET [LastName] = @LastName, [FirstName] = @FirstName, [Sex] = @Sex, [DateOfBirth] = @DateOfBirth, [AddressLine1] = @AddressLine1, [AddressLine2] = @AddressLine2, [City] = @City, [State] = @State, [Zip] = @Zip, [Phone] = @Phone WHERE [MemberID] = @MemberID";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.Add("@LastName", SqlDbType.VarChar);
                    updateCommand.Parameters["@LastName"].Value = member.LastName;

                    updateCommand.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    updateCommand.Parameters["@FirstName"].Value = member.FirstName;

                    updateCommand.Parameters.Add("@Sex", SqlDbType.Char);
                    updateCommand.Parameters["@Sex"].Value = member.Sex == "-- Select --" ? DBNull.Value : (object)member.Sex;

                    updateCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date);
                    updateCommand.Parameters["@DateOfBirth"].Value = member.DateOfBirth;

                    updateCommand.Parameters.Add("@AddressLine1", SqlDbType.VarChar);
                    updateCommand.Parameters["@AddressLine1"].Value = member.AddressOne;

                    updateCommand.Parameters.Add("@AddressLine2", SqlDbType.VarChar);
                    updateCommand.Parameters["@AddressLine2"].Value = string.IsNullOrEmpty(member.AddressTwo) ? DBNull.Value : (object)member.AddressTwo;

                    updateCommand.Parameters.Add("@City", SqlDbType.VarChar);
                    updateCommand.Parameters["@City"].Value = member.City;

                    updateCommand.Parameters.Add("@State", SqlDbType.Char);
                    updateCommand.Parameters["@State"].Value = member.State;

                    updateCommand.Parameters.Add("@Zip", SqlDbType.VarChar);
                    updateCommand.Parameters["@Zip"].Value = member.Zip;

                    updateCommand.Parameters.Add("@Phone", SqlDbType.VarChar);
                    updateCommand.Parameters["@Phone"].Value = string.IsNullOrEmpty(member.Phone) ? DBNull.Value : (object)member.Phone;

                    updateCommand.Parameters.Add("@MemberID", SqlDbType.Int);
                    updateCommand.Parameters["@MemberID"].Value = member.MemberID;

                    rowsAffected = updateCommand.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}
