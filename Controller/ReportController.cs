using RentMeApp.DAL;
using RentMeApp.Model;
using System;
using System.Collections.Generic;

namespace RentMeApp.Controller
{
    /// <summary>
    /// Controller for reporting functionality
    /// </summary>
    public class ReportController
    {
        private readonly ReportDAL _reportDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportController"/> class.
        /// </summary>
        public ReportController()
        {
            _reportDAL = new ReportDAL();
        }

        /// <summary>
        /// Gets the most popular furniture during dates.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns></returns>
        public List<Report> GetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            return _reportDAL.GetMostPopularFurnitureDuringDates(startDate, endDate);
        }
    }
}
