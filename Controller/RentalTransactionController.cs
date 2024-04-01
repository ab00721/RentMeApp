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

        /// <summary>
        /// Adds a rental transaction.
        /// </summary>
        /// <param name="rentalTransaction">A rental transaction to add.</param>
        /// <returns>The ID of the just-added rental transaction.</returns>
        public int AddRentalTransaction(RentalTransaction rentalTransaction)
        {
            return _rentalTransactionSource.InsertRentalTransaction(rentalTransaction);
        }

        /// <summary>
        /// Gets all rental transactions.
        /// </summary>
        /// <returns>A list of rental transactions.</returns>
        public List<RentalTransaction> GetAllRentalTransactions()
        {
            return _rentalTransactionSource.GetAllRentalTransactions();
        }

        /// <summary>
        /// Gets a rental transaction.
        /// </summary>
        /// <param name="rentalTransactionID">A rental transaction ID.</param>
        /// <returns>The rental transaction with the given ID.</returns>
        public RentalTransaction GetRentalTransactionByRentalTransactionID(int rentalTransactionID)
        {
            return _rentalTransactionSource.GetRentalTransactionByRentalTransactionID(rentalTransactionID);
        }

        /// <summary>
        /// Gets the rental transaction that is associated with a given rental line item ID.
        /// </summary>
        /// <param name="rentalLineItemID">The rental line item ID to use for finding a rental transaction.</param>
        /// <returns>The rental transaction with the given rental line item ID.</returns>
        public RentalTransaction GetRentalTransactionByRentalLineItemID(int rentalLineItemID)
        {
            return _rentalTransactionSource.GetRentalTransactionByRentalLineItemID(rentalLineItemID);
        }
    }
}
