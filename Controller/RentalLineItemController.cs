using RentMeApp.DAL;
using RentMeApp.Model;
using System.Collections.Generic;

namespace RentMeApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the RentalLineItemDAL and the view.
    /// </summary>
    public class RentalLineItemController
    {
        private readonly RentalLineItemDAL _rentalLineItemSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalLineItemController"/> class.
        /// </summary>
        public RentalLineItemController()
        {
            _rentalLineItemSource = new RentalLineItemDAL();
        }

        public void AddRentalLineItem(RentalLineItem rentalLineItem)
        {
            _rentalLineItemSource.InsertRentalLineItem(rentalLineItem);
        }

        public void UpdateRentalLineItem(RentalLineItem rentalLineItem)
        {
            _rentalLineItemSource.UpdateRentalLineItem(rentalLineItem);
        }

        public RentalLineItem GetRentalLineItemByID(int rentalLineItemID)
        {
            return _rentalLineItemSource.GetRentalLineItemByID(rentalLineItemID);
        }

        public List<RentalLineItem> GetRentalLineItemsByRentalTransactionID(int rentalTransactionID)
        {
            return _rentalLineItemSource.GetRentalLineItemsByRentalTransactionID(rentalTransactionID);
        }
    }
}
