using RentMeApp.DAL;
using RentMeApp.Model;
using System.Collections.Generic;

namespace RentMeApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the CheckedOutItemDAL and the view.
    /// </summary>
    public class CheckedOutItemController
    {
        private readonly CheckedOutItemDAL _checkedOutItemSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckedOutItemController"/> class.
        /// </summary>
        public CheckedOutItemController()
        {
            _checkedOutItemSource = new CheckedOutItemDAL();
        }

        /// <summary>
        /// Retrieves the list of checked out items by rental transaction ID.
        /// </summary>
        /// <param name="rentalTransactionID">The ID of the rental transaction.</param>
        /// <returns>The list of checked out items.</returns>
        public List<CheckedOutItem> GetCheckedOutItemsByRentalTransactionID(int rentalTransactionID)
        {
            return _checkedOutItemSource.GetCheckedOutItemsByRentalTransactionID(rentalTransactionID);
        }

        /// <summary>
        /// Checks if there are checked out items for a given member.
        /// </summary>
        /// <param name="memberID">The ID of the member.</param>
        /// <returns>True if there are checked out items for the member; otherwise, false.</returns>
        public bool CheckedOutItemsExistForMember(int memberID)
        {
            return _checkedOutItemSource.CheckedOutItemsExistForMember(memberID);
        }
    }
}
