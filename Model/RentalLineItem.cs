namespace RentMeConsole.Models
{
    public class RentalLineItem
    {
        public int RentalLineItemID { get; set; }
        public int RentalTransactionID { get; set; }
        public int FurnitureID { get; set; }
        public int Quantity { get; set; }
        public int QuantityReturned { get; set; }
        public decimal DailyCost { get; set; }

        public RentalLineItem(int rentalTransactionID, int furnitureID, int quantity, int quantityReturned, decimal dailyCost)
        {
            RentalTransactionID = rentalTransactionID;
            FurnitureID = furnitureID;
            Quantity = quantity;
            QuantityReturned = quantityReturned;
            DailyCost = dailyCost;
        }
    }
}
