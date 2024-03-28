using RentMeApp.DAL;
using RentMeApp.Model;
using System.Collections.Generic;

namespace RentMeApp.Controllers
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
        /// Adds a rental line item to the data.
        /// </summary>
        /// <param name="rentalTransactionID">The ID of the rental transaction.</param>
        /// <param name="furnitureID">The ID of the furniture.</param>
        /// <param name="quantity">The quantity of the furniture.</param>
        /// <param name="quantityReturned">The quantity of the furniture returned.</param>
        /// <param name="dailyCost">The daily cost of renting the furniture.</param>
        public void AddRentalLineItem(int rentalTransactionID, int furnitureID, int quantity, int quantityReturned, decimal dailyCost)
        {
            RentalLineItem rentalLineItem = new RentalLineItem(rentalTransactionID, furnitureID, quantity, quantityReturned, dailyCost);

            _rentalLineItemSource.InsertRentalLineItem(rentalLineItem);
        }

        /// <summary>
        /// Returns a list of rental line items by rental transaction ID.
        /// </summary>
        /// <param name="rentalTransactionID">The ID of the rental transaction.</param>
        public List<RentalLineItem> GetRentalLineItemsByRentalTransactionId(int rentalTransactionID)
        {
            return _rentalLineItemSource.GetRentalLineItemsByRentalTransactionId(rentalTransactionID);
        }
    }
}
