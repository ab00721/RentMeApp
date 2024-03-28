using System;

namespace RentMeApp.Models
{
    public class ReturnTransaction
    {
        public int ReturnTransactionID { get; set; }
        public int EmployeeID { get; set; }
        public int MemberID { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal TotalCost { get; set; }

        public ReturnTransaction(int employeeID, int memberID, DateTime returnDate, decimal totalCost)
        {
            EmployeeID = employeeID;
            MemberID = memberID;
            ReturnDate = returnDate;
            TotalCost = totalCost;
        }
    }
}
