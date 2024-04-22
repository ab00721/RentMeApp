using RentMeApp.DAL;
using RentMeApp.Model;
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
        /// Adds a new return transaction.
        /// </summary>
        /// <param name="returnTransaction">The return transaction being added.</param>
        /// <returns>The ID of the just-added return transaction.</returns>
        public int AddReturnTransaction(ReturnTransaction returnTransaction)
        {
            return _returnTransactionSource.InsertReturnTransaction(returnTransaction);
        }

        /// <summary>
        /// Gets all return transactions.
        /// </summary>
        /// <returns>A list of all the return transactions.</returns>
        public List<ReturnTransaction> GetAllReturnTransactions()
        {
            return _returnTransactionSource.GetAllReturnTransactions();
        }

        /// <summary>
        /// Gets a return transaction.
        /// </summary>
        /// <param name="returnTransactionId">A return transaction ID.</param>
        /// <returns>The return transaction with the given ID.</returns>
        public ReturnTransaction GetReturnTransactionByReturnTransactionID(int returnTransactionId)
        {
            return _returnTransactionSource.GetReturnTransactionByReturnTransactionID(returnTransactionId);
        }

        /// <summary>
        /// Gets all return transactions by member identifier.
        /// </summary>
        /// <param name="memberId">The member identifier.</param>
        /// <returns></returns>
        public List<ReturnTransaction> GetAllReturnTransactionsByMemberId(int memberId)
        {
            return _returnTransactionSource.GetAllReturnTransactionsByMemberId(memberId);
        }
    }
}
