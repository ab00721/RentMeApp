using RentMeConsole.DAL;
using RentMeConsole.Models;
using System;
using System.Collections.Generic;

namespace RentMeConsole.Controllers
{
    /// <summary>
    /// The controller class that mediates b/w the RentalTransactionDAL and the view.
    /// </summary>
    public class RentalTransactionController
    {
        private readonly RentalTransactionDAL _rentalTransactionSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalTransactionController"/> class.
        /// </summary>
        public RentalTransactionController()
        {
            _rentalTransactionSource = new RentalTransactionDAL();
        }

        /// <summary>
        /// Adds a rental transaction to the data.
        /// </summary>
        /// <param name="employeeID">The ID of the employee associated with the rental transaction.</param>
        /// <param name="memberID">The ID of the member associated with the rental transaction.</param>
        /// <param name="rentalDate">The date of the rental transaction.</param>
        /// <param name="dueDate">The due date of the rental transaction.</param>
        /// <param name="totalCost">The total cost of the rental transaction.</param>
        public void AddRentalTransaction(int employeeID, int memberID, DateTime rentalDate, DateTime dueDate, decimal totalCost)
        {
            RentalTransaction rentalTransaction = new RentalTransaction(employeeID, memberID, rentalDate, dueDate, totalCost);
            _rentalTransactionSource.InsertRentalTransaction(rentalTransaction);
        }

        /// <summary>
        /// Returns a list of all rental transactions.
        /// </summary
        public List<RentalTransaction> GetAllRentalTransactions()
        {
            return _rentalTransactionSource.GetAllRentalTransactions();
        }

        /// <summary>
        /// Returns a rental transaction.
        /// </summary>
        /// <param name="rentalTransactionID">The ID of the rental transaction.</param>
        public RentalTransaction GetRentalTransactionByRentalTransactionId(int rentalTransactionID)
        {
            return _rentalTransactionSource.GetRentalTransactionByRentalTransactionId(rentalTransactionID);
        }
    }
}
