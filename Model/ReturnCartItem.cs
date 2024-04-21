namespace RentMeApp.Model
{
    /// <summary>
    /// Represents a line in the return cart with optimal fields for 
    /// viewing the data in a data grid view
    /// </summary>
    public class ReturnCartItem
    {
        public int RentalLineItemID { get; set; } = 0;
        public int FurnitureID { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public decimal DailyRate { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public int ExpectedDuration { get; set; } = 0;
        public decimal AlreadyPaid { get; set; } = 0;
        public int ActualDuration { get; set; } = 0;

        public decimal ActualPrice
        {
            get
            {
                return DailyRate * ActualDuration * Quantity;
            }
        }

        public decimal Subtotal
        {
            get
            {
                return (DailyRate * ActualDuration) - AlreadyPaid;
            }
        }
    }
}