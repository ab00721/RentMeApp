using RentMeApp.DAL;
using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMeApp.Controller
{
    public class ReportController
    {
        private readonly ReportDAL _reportController;

        public List<Report> GetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            return _reportController.GetMostPopularFurnitureDuringDates(startDate, endDate);
        }
    }
}
