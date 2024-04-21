using RentMeApp.DAL;
using RentMeApp.Model;
using System;
using System.Collections.Generic;

namespace RentMeApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the ReportDAL and the view.
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
        /// Retrieves the most popular furniture during the specified dates.
        /// </summary>
        /// <param name="startDate">The start date of the period.</param>
        /// <param name="endDate">The end date of the period.</param>
        /// <returns>A list of <see cref="Report"/> objects representing the most popular furniture.</returns>
        public List<Report> GetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            return _reportDAL.GetMostPopularFurnitureDuringDates(startDate, endDate);
        }
    }
}
