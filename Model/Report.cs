using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMeApp.Model
{
    /// <summary>
    /// Model to define a reporting object
    /// </summary>
    public class Report
    {
        public int FurnitureID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int CountOfRentalTransactions { get; set; }
        public int TotalTransactions { get; set; }
        public string PercentageOfTransactions { get; set; }
        public string PercentageBtwEighteenTwentyNine { get; set; }
        public string PercentageNotBtwEighteenTwentyNine { get; set; }

        public Report() { }
    }
}
