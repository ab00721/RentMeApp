using RentMeConsole.DAL;
using RentMeConsole.Models;
using RentMeConsole.Views;
using System.Collections.Generic;

namespace RentMeConsole.Controllers
{
    public class ReturnLineItemController
    {
        private readonly AppSession _session;
        private readonly ReturnLineItemDAL _returnLineItemSource;

        public ReturnLineItemController(AppSession session)
        {
            _session = session;
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

        public void ShowMenu()
        {
            ReturnLineItemView view = new ReturnLineItemView(_session);
            view.ShowMenu(_session.GetValues());
        }
    }
}
