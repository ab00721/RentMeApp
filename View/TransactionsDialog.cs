using RentMeApp.Controller;
using RentMeApp.Model;
using RentMeApp.UserControls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMeApp.View
{
    /// <summary>
    /// Dialog to View Transaction Details 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class TransactionsDialog : Form
    {
        private readonly SearchMemberUserControl _searchMemberUserControl;
        private readonly UserUserControl _userUserControl;
        private readonly RentalTransactionController _rentalTransactionController;
        private readonly ReturnTransactionController _returnTransactionController;
        private List<RentalTransaction> _rentalTransactions;
        private List<RentalCartItem> _rentalLineItems;
        private List<ReturnTransaction> _returnTransactions;
        private List<ReturnCartItem> _returnLineItems;
        private Member _member;
        DataGridViewButtonColumn _addRentalButtonColumn;
        DataGridViewButtonColumn _addReturnButtonColumn;
        RentalPointOfSaleService _rentalPointOfSaleService;
        ReturnPointOfSaleService _returnPointOfSaleService;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsDialog"/> class.
        /// </summary>
        /// <param name="searchMemberUserController">The search member user controller.</param>
        /// <param name="username">The username.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="selectedMember">The selected member.</param>
        public TransactionsDialog(SearchMemberUserControl searchMemberUserController, string username, string firstName, Member selectedMember)
        {
            InitializeComponent();
            _userUserControl = new UserUserControl(username, firstName);
            this.userTableLayoutPanel.Controls.Add(_userUserControl);

            this._member = selectedMember;
            this._searchMemberUserControl = searchMemberUserController;
            this._rentalTransactionController = new RentalTransactionController();
            this._returnTransactionController = new ReturnTransactionController();
            this._rentalPointOfSaleService = new RentalPointOfSaleService();
            this._returnPointOfSaleService = new ReturnPointOfSaleService();

            this.RefreshRentalTransactionDataGridView();
            this.RefreshReturnTransactionDataGridView();

            AddRentalButtonColumn();
            AddReturnButtonColumn();

            MemberUserControl memberUserControl = new MemberUserControl(selectedMember);
            this.TransactionTableLayout.Controls.Add(memberUserControl);
        }

        /// <summary>
        /// Refreshes the rental transaction data grid view.
        /// </summary>
        public void RefreshRentalTransactionDataGridView()
        {
            RefreshRentalTransactionDataGridView(this._rentalTransactionController.GetAllRentalTransactionsByMemberId(this._member.MemberID));
        }

        private void RefreshRentalTransactionDataGridView(List<RentalTransaction> transactions)
        {
            _rentalTransactions = transactions;
            RentalTransactionDataGridView.DataSource = null;
            RentalTransactionDataGridView.DataSource = _rentalTransactions;
            RentalTransactionDataGridView.Columns[0].HeaderText = "Rental Transaction ID";
            RentalTransactionDataGridView.Columns[1].HeaderText = "Employee ID";
            RentalTransactionDataGridView.Columns[2].HeaderText = "Member ID";
            RentalTransactionDataGridView.Columns[3].HeaderText = "Rental Date";
            RentalTransactionDataGridView.Columns[4].HeaderText = "Due Date";
            RentalTransactionDataGridView.Columns[5].HeaderText = "Total Cost";
        }

        /// <summary>
        /// Refreshes the return transaction data grid view.
        /// </summary>
        public void RefreshReturnTransactionDataGridView()
        {
            RefreshReturnTransactionDataGridView(this._returnTransactionController.GetAllReturnTransactionsByMemberId(this._member.MemberID));
        }

        private void RefreshReturnTransactionDataGridView(List<ReturnTransaction> transactions)
        {
            _returnTransactions = transactions;
            ReturnTransactionDataGridView.DataSource = null;
            ReturnTransactionDataGridView.DataSource = _returnTransactions;
            ReturnTransactionDataGridView.Columns[0].HeaderText = "Return Transaction ID";
            ReturnTransactionDataGridView.Columns[1].HeaderText = "Employee ID";
            ReturnTransactionDataGridView.Columns[2].HeaderText = "Member ID";
            ReturnTransactionDataGridView.Columns[3].HeaderText = "Return Date";
            ReturnTransactionDataGridView.Columns[4].HeaderText = "Total Cost";
        }

        private void AddRentalButtonColumn()
        {
            _addRentalButtonColumn = new DataGridViewButtonColumn();
            _addRentalButtonColumn.Name = "AddButtonColumn";
            _addRentalButtonColumn.HeaderText = "";
            _addRentalButtonColumn.Text = "View Details";
            _addRentalButtonColumn.UseColumnTextForButtonValue = true;
            this.RentalTransactionDataGridView.Columns.Add(_addRentalButtonColumn);
        }

        private void AddReturnButtonColumn()
        {
            _addReturnButtonColumn = new DataGridViewButtonColumn();
            _addReturnButtonColumn.Name = "AddButtonColumn";
            _addReturnButtonColumn.HeaderText = "";
            _addReturnButtonColumn.Text = "View Details";
            _addReturnButtonColumn.UseColumnTextForButtonValue = true;
            this.ReturnTransactionDataGridView.Columns.Add(_addReturnButtonColumn);
        }

        private void RentalTransactionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == RentalTransactionDataGridView.Columns["AddButtonColumn"].Index)
            {
                RentalTransaction transaction = new RentalTransaction();

                transaction = _rentalTransactions[e.RowIndex];

                _rentalLineItems = this._rentalPointOfSaleService.GetRentalTransactionCartItems(transaction.RentalTransactionID);
                DetailsDataGridView.DataSource = null;
                DetailsDataGridView.DataSource = _rentalLineItems;
                DetailsDataGridView.Columns[0].HeaderText = "Furniture ID";
                DetailsDataGridView.Columns[1].HeaderText = "Name";
                DetailsDataGridView.Columns[2].HeaderText = "Daily Rate";
                DetailsDataGridView.Columns[3].HeaderText = "Quantity";
                DetailsDataGridView.Columns[4].HeaderText = "Price";

            }
        }

        private void ReturnTransactionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == ReturnTransactionDataGridView.Columns["AddButtonColumn"].Index)
            {
                ReturnTransaction transaction = new ReturnTransaction();

                transaction = _returnTransactions[e.RowIndex];

                _returnLineItems = this._returnPointOfSaleService.GetReturnTransactionCartItems(transaction.ReturnTransactionID);

                DetailsDataGridView.DataSource = null;
                DetailsDataGridView.DataSource = _returnLineItems;
                DetailsDataGridView.Columns[0].HeaderText = "Rental Line Item ID";
                DetailsDataGridView.Columns[1].HeaderText = "Furniture ID";
                DetailsDataGridView.Columns[2].HeaderText = "Name";
                DetailsDataGridView.Columns[3].HeaderText = "Daily Rate";
                DetailsDataGridView.Columns[4].HeaderText = "Quantity";
                DetailsDataGridView.Columns[5].HeaderText = "Expected Duration";
                DetailsDataGridView.Columns[6].HeaderText = "Already Paid";
                DetailsDataGridView.Columns[7].HeaderText = "Actual Duration";
                DetailsDataGridView.Columns[8].HeaderText = "Actual Price";
                DetailsDataGridView.Columns[9].HeaderText = "Subtotal";
            }
        }
    }
}


