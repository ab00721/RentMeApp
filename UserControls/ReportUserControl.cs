using RentMeApp.Controller;
using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMeApp.UserControls
{
    public partial class ReportUserControl : UserControl
    {
        private readonly ReportController _reportController;
        public ReportUserControl()
        {
            InitializeComponent();
            _reportController = new ReportController();
        }

        private void GenerateReportBtn_Click(object sender, EventArgs e)
        {
            List<Report> reports = _reportController.GetMostPopularFurnitureDuringDates(this.StartDateDateTimePicker.Value, this.EndDateDateTimePicker.Value);
            MessageBox.Show(reports.Count.ToString());
        }
    }
}
