using RentMeApp.DAL;
using RentMeApp.Model;
using System.Collections.Generic;

namespace RentMeApp.Controller
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
    }
}
