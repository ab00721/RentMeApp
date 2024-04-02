using RentMeApp.DAL;
using RentMeApp.Model;
using System.Collections.Generic;

namespace RentMeApp.Controller
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
        /// Adds a return line item.
        /// </summary>
        /// <param name="returnLineItem">The return line item to be added.</param>
        public void AddReturnLineItem(ReturnLineItem returnLineItem)
        {
            _returnLineItemSource.InsertReturnLineItem(returnLineItem);
        }

        /// <summary>
        /// Gets a return line item.
        /// </summary>
        /// <param name="returnLineItemID">A return line item ID.</param>
        /// <returns>The return line item with the given ID.</returns>
        public ReturnLineItem GetReturnLineItemByID(int returnLineItemID)
        {
            return _returnLineItemSource.GetReturnLineItemByID(returnLineItemID);
        }

        /// <summary>
        /// Gets all return line items.
        /// </summary>
        /// <returns>A list of return line items.</returns>
        public List<ReturnLineItem> GetAllReturnLineItems()
        {
            return _returnLineItemSource.GetAllReturnLineItems();
        }

        /// <summary>
        /// Gets the return line items by return transaction ID.
        /// </summary>
        /// <param name="returnTransactionID">A return transaction ID.</param>
        /// <returns>A list of the return line items for the given return transaction.</returns>
        public List<ReturnLineItem> GetReturnLineItemsByReturnTransactionID(int returnTransactionID)
        {
            return _returnLineItemSource.GetReturnLineItemsByReturnTransactionID(returnTransactionID);
        }

        /// <summary>
        /// Gets the return line items by rental line item ID.
        /// </summary>
        /// <param name="rentalLineItemID">A rental line item ID.</param>
        /// <returns>A list of the return line items for the given rental line item.</returns>
        public List<ReturnLineItem> GetReturnLineItemsByRentalLineItemID(int rentalLineItemID)
        {
            return _returnLineItemSource.GetReturnLineItemsByRentalLineItemID(rentalLineItemID);
        }
    }
}
