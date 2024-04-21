using RentMeApp.Controller;
using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMeApp.UserControls
{
    /// <summary>
    /// User Control for the report feature.
    /// </summary>
    public partial class ReportUserControl : UserControl
    {
        private readonly ReportController _reportController;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportUserControl"/> class.
        /// </summary>
        public ReportUserControl()
        {
            InitializeComponent();
            _reportController = new ReportController();
        }

        private void GenerateReportBtn_Click(object sender, EventArgs e)
        {
            List<Report> reports = _reportController.GetMostPopularFurnitureDuringDates(this.StartDateDateTimePicker.Value, this.EndDateDateTimePicker.Value);

            MostPopularFurnitureDataGridView.DataSource = null;
            MostPopularFurnitureDataGridView.DataSource = reports;
            MostPopularFurnitureDataGridView.Columns[0].HeaderText = "Furniture ID";
            MostPopularFurnitureDataGridView.Columns[1].HeaderText = "Category";
            MostPopularFurnitureDataGridView.Columns[2].HeaderText = "Name";
            MostPopularFurnitureDataGridView.Columns[3].HeaderText = "Count of Rentral Transactions";
            MostPopularFurnitureDataGridView.Columns[4].HeaderText = "Total Transactions";
            MostPopularFurnitureDataGridView.Columns[5].HeaderText = "% of Total Transactions";
            MostPopularFurnitureDataGridView.Columns[6].HeaderText = "% b/t 18-29";
            MostPopularFurnitureDataGridView.Columns[7].HeaderText = "% not b/t 18-29";
        }
    }
}
