using RentMeConsole.DAL;
using RentMeConsole.Models;
using RentMeConsole.Views;
using System.Collections.Generic;

namespace RentMeConsole.Controllers
{
    public class RentalTransactionController
    {
        private readonly AppSession _session;
        private readonly RentalTransactionDAL _rentalTransactionSource;

        public RentalTransactionController(AppSession session)
        {
            _session = session;
            _rentalTransactionSource = new RentalTransactionDAL();
        }

        public int AddRentalTransaction(RentalTransaction rentalTransaction)
        {
            return _rentalTransactionSource.InsertRentalTransaction(rentalTransaction);
        }

        public List<RentalTransaction> GetAllRentalTransactions()
        {
            return _rentalTransactionSource.GetAllRentalTransactions();
        }

        public RentalTransaction GetRentalTransactionByRentalTransactionId(int rentalTransactionID)
        {
            return _rentalTransactionSource.GetRentalTransactionByRentalTransactionId(rentalTransactionID);
        }

        public RentalTransaction GetRentalTransactionByRentalLineItemID(int rentalLineItemID)
        {
            return _rentalTransactionSource.GetRentalTransactionByRentalLineItemID(rentalLineItemID);
        }

        public void ShowMenu()
        {
            RentalTransactionView view = new RentalTransactionView(_session);
            view.ShowMenu(_session.GetValues());
        }
    }
}
