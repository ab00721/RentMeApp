using System;

namespace RentMeApp.Model
{
    /// <summary>
    /// RentalTransaction DTO class
    /// </summary>
    public class RentalTransaction
    {
        public int RentalTransactionID { get; set; }
        public int EmployeeID { get; set; }
        public int MemberID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalCost { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalTransaction"/> class.
        /// </summary>
        /// <param name="employeeID">The ID of the employee associated with the rental transaction.</param>
        /// <param name="memberID">The ID of the member associated with the rental transaction.</param>
        /// <param name="rentalDate">The date of the rental transaction.</param>
        /// <param name="dueDate">The due date of the rental transaction.</param>
        /// <param name="totalCost">The total cost of the rental transaction.</param>
        public RentalTransaction(int employeeID, int memberID, DateTime rentalDate, DateTime dueDate, decimal totalCost)
        {
            EmployeeID = employeeID;
            MemberID = memberID;
            RentalDate = rentalDate;
            DueDate = dueDate;
            TotalCost = totalCost;
        }

        public RentalTransaction() { }
    }
}
