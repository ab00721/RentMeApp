using System;

namespace RentMeConsole.Models
{
    /// <summary>
    /// Employee DTO class
    /// </summary>
    public class EmployeeDTO
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public int IsAdmin { get; set; }
        public string Username { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDTO"/> class.
        /// </summary>
        /// <param name="employeeID">The employee ID.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="sex">The sex.</param>
        /// <param name="dateOfBirth">The date of birth.</param>
        /// <param name="addressLine1">The address line 1.</param>
        /// <param name="addressLine2">The address line 2.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="phone">The phone.</param>
        /// <param name="isAdmin">The is admin.</param>
        /// <param name="username">The username.</param>
        public EmployeeDTO(int employeeID, string lastName, string firstName, string sex, DateTime dateOfBirth, string addressLine1, string addressLine2, string city, string state, string zip, string phone, int isAdmin, string username)
        {
            this.EmployeeID = employeeID;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Sex = sex;
            this.DateOfBirth = dateOfBirth;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phone;
            this.IsAdmin = isAdmin;
            this.Username = username;
        }
    }
}
