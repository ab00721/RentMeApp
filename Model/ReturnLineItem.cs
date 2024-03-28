using System;

namespace RentMeApp.Models
{
    public class ReturnLineItem
    {
        public int ReturnLineItemID { get; set; }
        public int RentalLineItemID { get; set; }
        public int ReturnTransactionID { get; set; }
        public int Quantity { get; set; }
        public decimal DailyCost { get; set; }

        public ReturnLineItem(int rentalLineItemID, int returnTransactionID, int quantity, decimal dailyCost)
        {
            RentalLineItemID = rentalLineItemID;
            ReturnTransactionID = returnTransactionID;
            Quantity = quantity;
            DailyCost = dailyCost;
        }
    }
}
