using RentMeApp.DAL;
using RentMeApp.Model;
using System.Collections.Generic;

namespace RentMeApp.Controllers
{
    /// <summary>
    /// The controller class that mediates b/w the ReturnLineItemDAL and the view.
    /// </summary>
    public class ReturnLineItemController
    {
        private readonly ReturnLineItemDAL _returnLineItemSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnLineItemController"/> class.
        /// </summary>
        public ReturnLineItemController()
        {
            _returnLineItemSource = new ReturnLineItemDAL();
        }

        /// <summary>
        /// Adds a return line item to the data.
        /// </summary>
        /// <param name="rentalLineItemID">The ID of the rental line item.</param>
        /// <param name="returnTransactionID">The ID of the return transaction.</param>
        /// <param name="quantity">The quantity of the return line item.</param>
        /// <param name="dailyCost">The daily cost of the return line item.</param>
        public void AddReturnLineItem(int rentalLineItemID, int returnTransactionID, int quantity, decimal dailyCost)
        {
            ReturnLineItem returnLineItem = new ReturnLineItem(rentalLineItemID, returnTransactionID, quantity, dailyCost);
            _returnLineItemSource.InsertReturnLineItem(returnLineItem);
        }

        /// <summary>
        /// Returns a list of all return line items.
        /// </summary>
        public List<ReturnLineItem> GetAllReturnLineItems()
        {
            return _returnLineItemSource.GetAllReturnLineItems();
        }

        /// <summary>
        /// Returns a list of return line items by return transaction ID.
        /// </summary>
        /// <param name="returnTransactionID">The ID of the return transaction.</param>
        public List<ReturnLineItem> GetReturnLineItemsByReturnTransactionId(int returnTransactionID)
        {
            return _returnLineItemSource.GetReturnLineItemsByReturnTransactionId(returnTransactionID);
        }

        /// <summary>
        /// Returns a list of return line items by rental line item ID.
        /// </summary>
        /// <param name="rentalLineItemID">The ID of the rental line item.</param>
        public List<ReturnLineItem> GetReturnLineItemsByRentalLineItemId(int rentalLineItemID)
        {
            return _returnLineItemSource.GetReturnLineItemsByRentalLineItemID(rentalLineItemID);
        }
    }
}
