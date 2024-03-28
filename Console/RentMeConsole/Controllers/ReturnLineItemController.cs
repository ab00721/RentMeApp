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

        public void AddReturnLineItem(int rentalLineItemID, int returnTransactionID, int quantity, decimal dailyCost)
        {
            // ReturnLineItem returnLineItem = new ReturnLineItem(rentalLineItemID, returnTransactionID, quantity, dailyCost);
            // _returnLineItemSource.InsertReturnLineItem(returnLineItem);
        }

        public List<ReturnLineItem> GetAllReturnLineItems()
        {
            return _returnLineItemSource.GetAllReturnLineItems();
        }

        public List<ReturnLineItem> GetReturnLineItemsByReturnTransactionId(int returnTransactionID)
        {
            return _returnLineItemSource.GetReturnLineItemsByReturnTransactionId(returnTransactionID);
        }

        public List<ReturnLineItem> GetReturnLineItemsByRentalLineItemId(int rentalLineItemID)
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
