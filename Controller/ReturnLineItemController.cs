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

        public void AddReturnLineItem(ReturnLineItem returnLineItem)
        {
            _returnLineItemSource.InsertReturnLineItem(returnLineItem);
        }

        public ReturnLineItem GetReturnLineItemByID(int returnLineItemID)
        {
            return _returnLineItemSource.GetReturnLineItemByID(returnLineItemID);
        }

        public List<ReturnLineItem> GetAllReturnLineItems()
        {
            return _returnLineItemSource.GetAllReturnLineItems();
        }

        public List<ReturnLineItem> GetReturnLineItemsByReturnTransactionID(int returnTransactionID)
        {
            return _returnLineItemSource.GetReturnLineItemsByReturnTransactionID(returnTransactionID);
        }

        public List<ReturnLineItem> GetReturnLineItemsByRentalLineItemID(int rentalLineItemID)
        {
            return _returnLineItemSource.GetReturnLineItemsByRentalLineItemID(rentalLineItemID);
        }
    }
}
