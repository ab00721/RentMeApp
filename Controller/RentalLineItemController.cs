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

        /// <summary>
        /// Adds a rental line item.
        /// </summary>
        /// <param name="rentalLineItem">A rental line item to be added.</param>
        public void AddRentalLineItem(RentalLineItem rentalLineItem)
        {
            _rentalLineItemSource.InsertRentalLineItem(rentalLineItem);
        }

        /// <summary>
        /// Updates a rental line item.
        /// </summary>
        /// <param name="rentalLineItem">The rental line item being updated.</param>
        public void UpdateRentalLineItem(RentalLineItem rentalLineItem)
        {
            _rentalLineItemSource.UpdateRentalLineItem(rentalLineItem);
        }

        /// <summary>
        /// Gets a rental line item.
        /// </summary>
        /// <param name="rentalLineItemID">A rental line item ID.</param>
        /// <returns>The rental line item with the given ID.</returns>
        public RentalLineItem GetRentalLineItemByID(int rentalLineItemID)
        {
            return _rentalLineItemSource.GetRentalLineItemByID(rentalLineItemID);
        }

        /// <summary>
        /// Gets a list of rental line items by rental transaction ID.
        /// </summary>
        /// <param name="rentalTransactionID">The ID of the rental transaction.</param>
        /// <returns>A list of rental line items associated with the given rental transaction ID.</returns>
        public List<RentalLineItem> GetRentalLineItemsByRentalTransactionID(int rentalTransactionID)
        {
            return _rentalLineItemSource.GetRentalLineItemsByRentalTransactionID(rentalTransactionID);
        }

        public List<RentalLineItem> GetCheckedOutLineItemsByRentalTransactionID(int rentalTransactionID)
        {
            return _rentalLineItemSource.GetCheckedOutLineItemsByRentalTransactionID(rentalTransactionID);
        }
    }
}
