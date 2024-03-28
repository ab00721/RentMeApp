using RentMeApp.DAL;
using RentMeApp.Model;
using System;
using System.Collections.Generic;

namespace RentMeApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the ReturnTransactionDAL and the view.
    /// </summary>
    public class ReturnTransactionController
    {
        private readonly ReturnTransactionDAL _returnTransactionSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnTransactionController"/> class.
        /// </summary>
        public ReturnTransactionController()
        {
            _returnTransactionSource = new ReturnTransactionDAL();
        }

        /// <summary>
        /// Adds a return transaction to the data.
        /// </summary>
        /// <param name="employeeID">The ID of the employee.</param>
        /// <param name="memberID">The ID of the member.</param>
        /// <param name="returnDate">The return date.</param>
        /// <param name="totalCost">The total cost of the transaction.</param>
        public void AddReturnTransaction(int employeeID, int memberID, DateTime returnDate, decimal totalCost)
        {
            ReturnTransaction returnTransaction = new ReturnTransaction(employeeID, memberID, returnDate, totalCost);
            _returnTransactionSource.InsertReturnTransaction(returnTransaction);
        }

        /// <summary>
        /// Returns a list of all return transactions.
        /// </summary
        public List<ReturnTransaction> GetAllReturnTransactions()
        {
            return _returnTransactionSource.GetAllReturnTransactions();
        }

        /// <summary>
        /// Returns a return transaction.
        /// </summary>
        /// <param name="returnTransactionID">The ID of the return transaction.</param>
        public ReturnTransaction GetReturnTransactionByReturnTransactionId(int returnTransactionId)
        {
            return _returnTransactionSource.GetReturnTransactionByReturnTransactionId(returnTransactionId);
        }
    }
}
