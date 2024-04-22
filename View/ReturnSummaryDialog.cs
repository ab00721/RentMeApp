using RentMeApp.Model;
using RentMeApp.UserControls;
using System.Windows.Forms;

namespace RentMeApp.View
{
    /// <summary>
    /// Dialog for displaying the return confirmation page.
    /// </summary>
    public partial class ReturnSummaryDialog : Form
    {
        private readonly ReturnPointOfSaleService _returnPointOfSaleService;
        private readonly ReturnTransaction _transaction;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnSummaryDialog"/> class.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <param name="member">The member.</param>
        /// <param name="transactionID">The return transactionID.</param>
        public ReturnSummaryDialog(EmployeeDTO employee, Member member, int transactionID)
        {
            InitializeComponent();
            _returnPointOfSaleService = new ReturnPointOfSaleService();
            _transaction = _returnPointOfSaleService.GetReturnTransaction(transactionID);

            UserUserControl userUserControl = new UserUserControl(employee.Username, employee.FirstName);
            returnSummaryTableLayoutPanel.Controls.Add(userUserControl);

            MemberUserControl memberUserControl = new MemberUserControl(member);
            returnSummaryTableLayoutPanel.Controls.Add(memberUserControl);

            RefreshDataGridView();
            StyleDataGridView();
            ConfigureDataGridView();
            AssignLabelValues();
        }

        private void RefreshDataGridView()
        {
            returnSummaryDataGridView.DataSource = null;
            returnSummaryDataGridView.DataSource = _returnPointOfSaleService.GetReturnTransactionCartItems(_transaction.ReturnTransactionID);
        }

        private void ConfigureDataGridView()
        {
            returnSummaryDataGridView.Columns[0].HeaderText = "Rental Line";
            returnSummaryDataGridView.Columns[1].HeaderText = "Furniture ID";
            returnSummaryDataGridView.Columns[2].HeaderText = "Furniture Name";
            returnSummaryDataGridView.Columns[3].HeaderText = "Daily Cost";
            returnSummaryDataGridView.Columns[4].HeaderText = "Qty To Return";
            returnSummaryDataGridView.Columns[5].HeaderText = "Expected Duration";
            returnSummaryDataGridView.Columns[6].HeaderText = "Already Paid";
            returnSummaryDataGridView.Columns[7].HeaderText = "Actual Duration";
            returnSummaryDataGridView.Columns[8].HeaderText = "Actual Price";
            returnSummaryDataGridView.Columns[9].HeaderText = "Subtotal";
        }

        private void StyleDataGridView()
        {
            returnSummaryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            returnSummaryDataGridView.Columns["RentalLineItemID"].ReadOnly = true;
            returnSummaryDataGridView.Columns["FurnitureID"].ReadOnly = true;
            returnSummaryDataGridView.Columns["Name"].ReadOnly = true;
            returnSummaryDataGridView.Columns["DailyRate"].ReadOnly = true;
            returnSummaryDataGridView.Columns["Quantity"].ReadOnly = true;
            returnSummaryDataGridView.Columns["ExpectedDuration"].ReadOnly = true;
            returnSummaryDataGridView.Columns["AlreadyPaid"].ReadOnly = true;
            returnSummaryDataGridView.Columns["ActualDuration"].ReadOnly = true;
            returnSummaryDataGridView.Columns["ActualPrice"].ReadOnly = true;
            returnSummaryDataGridView.Columns["Subtotal"].ReadOnly = true;
        }

        private void AssignLabelValues()
        {
            returnDateValueLabel.Text = _transaction.ReturnDate.ToString("yyyy-MM-dd");
            totalValueLabel.Text = _transaction.TotalCost.ToString("C");
            transactionValueLabel.Text = _transaction.ReturnTransactionID.ToString();
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
