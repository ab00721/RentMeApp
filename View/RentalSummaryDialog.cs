using RentMeApp.Model;
using RentMeApp.UserControls;
using System.Transactions;
using System.Windows.Forms;

namespace RentMeApp.View
{
    public partial class RentalSummaryDialog : Form
    {
        private readonly RentalPointOfSaleService _rentalPointOfSaleService;
        private readonly RentalTransaction _transaction;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalSummaryDialog"/> class.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <param name="member">The member.</param>
        /// <param name="transactionID">The rental transactionID.</param>
        public RentalSummaryDialog(EmployeeDTO employee, Member member, int transactionID)
        {
            InitializeComponent();
            _rentalPointOfSaleService = new RentalPointOfSaleService();
            _transaction = _rentalPointOfSaleService.GetRentalTransaction(transactionID);

            UserUserControl userUserControl = new UserUserControl(employee.Username, employee.FirstName);
            this.rentalSummaryTableLayoutPanel.Controls.Add(userUserControl);

            MemberUserControl memberUserControl = new MemberUserControl(member);
            this.rentalSummaryTableLayoutPanel.Controls.Add(memberUserControl);

            RefreshDataGridView();
            StyleDataGridView();
            AssignLabelValues();
        }

        private void RefreshDataGridView()
        {
            rentalSummaryDataGridView.DataSource = null;
            rentalSummaryDataGridView.DataSource = _rentalPointOfSaleService.GetRentalTransactionCartItems(_transaction.RentalTransactionID);
        }

        private void StyleDataGridView()
        {
            rentalSummaryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rentalSummaryDataGridView.Columns["FurnitureID"].ReadOnly = true;
            rentalSummaryDataGridView.Columns["Name"].ReadOnly = true;
            rentalSummaryDataGridView.Columns["DailyRate"].ReadOnly = true;
            rentalSummaryDataGridView.Columns["Quantity"].ReadOnly = true;
            rentalSummaryDataGridView.Columns["Price"].ReadOnly = true;
        }

        private void AssignLabelValues()
        {
            returnDateValueLabel.Text = _transaction.DueDate.ToString("yyyy-MM-dd");
            totalValueLabel.Text = _transaction.TotalCost.ToString("C");
            transactionValueLabel.Text = _transaction.RentalTransactionID.ToString();
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
