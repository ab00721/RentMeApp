using System;

namespace RentMeApp.Model
{
    public class RentalTransaction
    {
        public int RentalTransactionID { get; set; }
        public int EmployeeID { get; set; }
        public int MemberID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalCost { get; set; }

        public RentalTransaction(int employeeID, int memberID, DateTime rentalDate, DateTime dueDate, decimal totalCost)
        {
            EmployeeID = employeeID;
            MemberID = memberID;
            RentalDate = rentalDate;
            DueDate = dueDate;
            TotalCost = totalCost;
        }
    }
}
