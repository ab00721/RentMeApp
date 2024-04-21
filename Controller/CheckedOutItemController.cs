using RentMeApp.DAL;
using RentMeApp.Model;
using System.Collections.Generic;

namespace RentMeApp.Controller
{
    internal class CheckedOutItemController
    {
        private readonly CheckedOutItemDAL _checkedOutItemSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureController"/> class.
        /// </summary>
        public CheckedOutItemController()
        {
            _checkedOutItemSource = new CheckedOutItemDAL();
        }

        public List<CheckedOutItem> GetCheckedOutItemsByRentalTransactionID(int rentalTransactionID)
        {
            return _checkedOutItemSource.GetCheckedOutItemsByRentalTransactionID(rentalTransactionID);
        }

        public bool CheckedOutItemsExistForMember(int memberID)
        {
            return _checkedOutItemSource.CheckedOutItemsExistForMember(memberID);
        }
    }
}
