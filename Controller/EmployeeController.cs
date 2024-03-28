using RentMeApp.DAL;
using RentMeApp.Model;

namespace RentMeApp.Controller
{
    /// <summary>
    /// Controller class for Employees
    /// </summary>
    public class EmployeeController
    {
        private readonly EmployeeDAL _employeeSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        public EmployeeController()
        {
            this._employeeSource = new EmployeeDAL();
        }

        /// <summary>
        /// Gets the employee by username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public EmployeeDTO GetEmployeeByUsername(string username)
        {
            return this._employeeSource.GetEmployeeByUsername(username);
        }

    }
}
