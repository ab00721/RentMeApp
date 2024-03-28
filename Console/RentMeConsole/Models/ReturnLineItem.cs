namespace RentMeConsole.Models
{
    public class ReturnLineItem
    {
        public int ReturnLineItemID { get; set; }
        public int RentalLineItemID { get; set; }
        public int ReturnTransactionID { get; set; }
        public int Quantity { get; set; }
        public decimal DailyCost { get; set; }

        public ReturnLineItem(int rentalLineItemID, int quantity, decimal dailyCost)
        {
            RentalLineItemID = rentalLineItemID;
            Quantity = quantity;
            DailyCost = dailyCost;
        }
    }
}
