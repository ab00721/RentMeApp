using System;

namespace RentMeApp.Model
{
    /// <summary>
    /// Employee DTO class
    /// </summary>
    public class EmployeeDTO
    {
        public string FirstName { get; set; }
        public string Username { get; set; }
        public int IsAdmin { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDTO"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="username">The username.</param>
        /// <param name="isAdmin">The is admin.</param>
        /// <exception cref="System.ArgumentException">
        /// First Name - First name cannot be null or empty
        /// or
        /// Username - Username cannot be null or empty
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Admin - Admin should be 0 or 1</exception>
        public EmployeeDTO(string firstName, string username, int isAdmin)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException("First Name", "First name cannot be null or empty");
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Username", "Username cannot be null or empty");
            }

            if (isAdmin < 0 || isAdmin > 1)
            {
                throw new ArgumentOutOfRangeException("Admin", "Admin should be 0 or 1");
            }

            this.FirstName = firstName;
            this.Username = username;
            this.IsAdmin = isAdmin;
        }
    }
}
