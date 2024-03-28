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
        /// <param name="employeeID">The ID of the employee.</param>
        /// <param name="memberID">The ID of the member.</param>
        /// <param name="returnDate">The return date.</param>
        /// <param name="totalCost">The total cost.</param>
        public ReturnTransaction(int employeeID, int memberID, DateTime returnDate, decimal totalCost)
        {
            EmployeeID = employeeID;
            MemberID = memberID;
            ReturnDate = returnDate;
            TotalCost = totalCost;
        }
    }
}
