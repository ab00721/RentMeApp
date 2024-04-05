using System;

namespace RentMeApp.Model
{
    /// <summary>
    /// ReturnTransaction DTO class
    /// </summary>
    public class ReturnTransaction
    {
        public int ReturnTransactionID { get; set; }
        public int EmployeeID { get; set; }
        public int MemberID { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal TotalCost { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnTransaction"/> class.
        /// </summary>
        /// <param name="employeeID">The ID of the employee creating the return.</param>
        /// <param name="memberID">The ID of the member returning the furniture.</param>
        /// <param name="returnDate">The date of the transaction's creation.</param>
        /// <param name="totalCost">The total cost over the expected duration minus the total cost over the actual duration.</param>
        public ReturnTransaction(int employeeID, int memberID, DateTime returnDate, decimal totalCost)
        {
            EmployeeID = employeeID;
            MemberID = memberID;
            ReturnDate = returnDate;
            TotalCost = totalCost;
        }

        public ReturnTransaction() { }
    }
}
