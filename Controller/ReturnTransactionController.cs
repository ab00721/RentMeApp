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

        public int AddReturnTransaction(ReturnTransaction returnTransaction)
        {
            return _returnTransactionSource.InsertReturnTransaction(returnTransaction);
        }

        public List<ReturnTransaction> GetAllReturnTransactions()
        {
            return _returnTransactionSource.GetAllReturnTransactions();
        }

        public ReturnTransaction GetReturnTransactionByReturnTransactionID(int returnTransactionId)
        {
            return _returnTransactionSource.GetReturnTransactionByReturnTransactionId(returnTransactionId);
        }
    }
}
