using RentMeConsole.DAL;
using RentMeConsole.Models;
using RentMeConsole.Views;
using System.Collections.Generic;

namespace RentMeConsole.Controllers
{
    public class RentalLineItemController
    {
        private readonly AppSession _session;
        private readonly RentalLineItemDAL _rentalLineItemSource;

        public RentalLineItemController(AppSession session)
        {
            _session = session;
            _rentalLineItemSource = new RentalLineItemDAL();
        }

        public void AddRentalLineItem(RentalLineItem rentalLineItem)
        {
            _rentalLineItemSource.InsertRentalLineItem(rentalLineItem);
        }

        public List<RentalLineItem> GetRentalLineItemsByRentalTransactionId(int rentalTransactionID)
        {
            return _rentalLineItemSource.GetRentalLineItemsByRentalTransactionId(rentalTransactionID);
        }

        public void ShowMenu()
        {
            RentalLineItemView view = new RentalLineItemView(_session);
            view.ShowMenu(_session.GetValues());
        }
    }
}
