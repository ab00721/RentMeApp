using RentMeApp.DAL;
using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMeApp.Controller
{
    public class ReportController
    {
        private readonly ReportDAL _reportDAL;

        public ReportController()
        {
            _reportDAL = new ReportDAL();
        }

        public List<Report> GetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            return _reportDAL.GetMostPopularFurnitureDuringDates(startDate, endDate);
        }
    }
}
