using RentMeConsole.DAL;
using RentMeConsole.Models;
using RentMeConsole.Views;
using System.Collections.Generic;

namespace RentMeConsole.Controllers
{
    public class EmployeeController
    {
        private readonly AppSession _session;
        private readonly EmployeeDAL _employeeSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        public EmployeeController(AppSession session)
        {
            _session = session;
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

        /// <summary>
        /// Gets all the employees from the database.
        /// </summary>
        /// <returns>A list of EmployeeDTO objects representing all the employees.</returns>
        public List<EmployeeDTO> GetAllEmployees()
        {
            return this._employeeSource.GetAllEmployees();
        }

        public void ShowMenu()
        {
            EmployeeView view = new EmployeeView(_session);
            view.ShowMenu(_session.GetValues());
        }
    }
}
