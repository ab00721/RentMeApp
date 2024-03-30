using RentMeConsole.DAL;
using RentMeConsole.Models;
using RentMeConsole.Views;
using System;
using System.Collections.Generic;

namespace RentMeConsole.Controllers
{
    public class ReturnTransactionController
    {
        private readonly AppSession _session;
        private readonly ReturnTransactionDAL _returnTransactionSource;

        public ReturnTransactionController(AppSession session)
        {
            _session = session;
            _returnTransactionSource = new ReturnTransactionDAL();
        }

        public int AddReturnTransaction(ReturnTransaction returnTransaction)
        {
            return _returnTransactionSource.InsertReturnTransaction(returnTransaction);
        }

        public List<ReturnTransaction> GetAllReturnTransactions()
        {
            return _returnTransactionSource.GetAllReturnTransactions();
        }

        public ReturnTransaction GetReturnTransactionByReturnTransactionId(int returnTransactionId)
        {
            return _returnTransactionSource.GetReturnTransactionByReturnTransactionId(returnTransactionId);
        }

        public void ShowMenu()
        {
            ReturnTransactionView view = new ReturnTransactionView(_session);
            view.ShowMenu(_session.GetValues());
        }
    }
}
