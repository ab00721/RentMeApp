using RentMeApp.Model;
using System;
using System.Collections.Generic;
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
                        "SELECT E.EmployeeID, E.LastName, E.FirstName, E.Sex, E.DateOfBirth, E.AddressLine1, E.AddressLine2, E.City, E.State, E.Zip, E.Phone, E.IsAdmin " +
                        "FROM Employee E " +
                        "WHERE E.Username = @Username";

                    command.Parameters.Add("@Username", System.Data.SqlDbType.VarChar);
                    command.Parameters["@Username"].Value = username;

                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int employeeIDOrdinal = reader.GetOrdinal("EmployeeID");
                            int lastNameOrdinal = reader.GetOrdinal("LastName");
                            int firstNameOrdinal = reader.GetOrdinal("FirstName");
                            int sexOrdinal = reader.GetOrdinal("Sex");
                            int dateOfBirthOrdinal = reader.GetOrdinal("DateOfBirth");
                            int addressLine1Ordinal = reader.GetOrdinal("AddressLine1");
                            int addressLine2Ordinal = reader.GetOrdinal("AddressLine2");
                            int cityOrdinal = reader.GetOrdinal("City");
                            int stateOrdinal = reader.GetOrdinal("State");
                            int zipOrdinal = reader.GetOrdinal("Zip");
                            int phoneOrdinal = reader.GetOrdinal("Phone");
                            int isAdminOrdinal = reader.GetOrdinal("IsAdmin");

                            int employeeID = reader.GetInt32(employeeIDOrdinal);
                            string lastName = reader.GetString(lastNameOrdinal);
                            string firstName = reader.GetString(firstNameOrdinal);
                            string sex = reader.IsDBNull(sexOrdinal) ? "" : reader.GetString(sexOrdinal);
                            DateTime dateOfBirth = reader.GetDateTime(dateOfBirthOrdinal);
                            string addressLine1 = reader.GetString(addressLine1Ordinal);
                            string addressLine2 = reader.IsDBNull(addressLine2Ordinal) ? "" : reader.GetString(addressLine2Ordinal);
                            string city = reader.GetString(cityOrdinal);
                            string state = reader.GetString(stateOrdinal);
                            string zip = reader.GetString(zipOrdinal);
                            string phone = reader.GetString(phoneOrdinal);
                            int isAdmin = reader.GetInt32(isAdminOrdinal);

                            return new EmployeeDTO(employeeID, lastName, firstName, sex, dateOfBirth, addressLine1, addressLine2, city, state, zip, phone, isAdmin, username);
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Gets all the employees from the database.
        /// </summary>
        /// <returns>A list of EmployeeDTO objects representing all the employees.</returns>
        public List<EmployeeDTO> GetAllEmployees()
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        "SELECT E.EmployeeID, E.LastName, E.FirstName, E.Sex, E.DateOfBirth, E.AddressLine1, E.AddressLine2, E.City, E.State, E.Zip, E.Phone, E.IsAdmin, E.Username " +
                        "FROM Employee E";

                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int employeeIDOrdinal = reader.GetOrdinal("EmployeeID");
                            int lastNameOrdinal = reader.GetOrdinal("LastName");
                            int firstNameOrdinal = reader.GetOrdinal("FirstName");
                            int sexOrdinal = reader.GetOrdinal("Sex");
                            int dateOfBirthOrdinal = reader.GetOrdinal("DateOfBirth");
                            int addressLine1Ordinal = reader.GetOrdinal("AddressLine1");
                            int addressLine2Ordinal = reader.GetOrdinal("AddressLine2");
                            int cityOrdinal = reader.GetOrdinal("City");
                            int stateOrdinal = reader.GetOrdinal("State");
                            int zipOrdinal = reader.GetOrdinal("Zip");
                            int phoneOrdinal = reader.GetOrdinal("Phone");
                            int isAdminOrdinal = reader.GetOrdinal("IsAdmin");
                            int usernameOrdinal = reader.GetOrdinal("Username");

                            int employeeID = reader.GetInt32(employeeIDOrdinal);
                            string lastName = reader.GetString(lastNameOrdinal);
                            string firstName = reader.GetString(firstNameOrdinal);
                            string sex = reader.IsDBNull(sexOrdinal) ? "" : reader.GetString(sexOrdinal);
                            DateTime dateOfBirth = reader.GetDateTime(dateOfBirthOrdinal);
                            string addressLine1 = reader.GetString(addressLine1Ordinal);
                            string addressLine2 = reader.IsDBNull(addressLine2Ordinal) ? "" : reader.GetString(addressLine2Ordinal);
                            string city = reader.GetString(cityOrdinal);
                            string state = reader.GetString(stateOrdinal);
                            string zip = reader.GetString(zipOrdinal);
                            string phone = reader.GetString(phoneOrdinal);
                            int isAdmin = reader.GetInt32(isAdminOrdinal);
                            string username = reader.GetString(usernameOrdinal);

                            EmployeeDTO employee = new EmployeeDTO(employeeID, lastName, firstName, sex, dateOfBirth, addressLine1, addressLine2, city, state, zip, phone, isAdmin, username);
                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }
    }
}
