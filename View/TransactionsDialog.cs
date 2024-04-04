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
        private readonly RentalLineItemController _rentalLineItemController;
        private List<RentalTransaction> _rentalTransactions;
        private List<RentalLineItem> _rentalLineItems;
        private Member _member;
        DataGridViewButtonColumn _addButtonColumn;

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
            this._rentalLineItemController = new RentalLineItemController();

            this.RefreshRentalTransactionDataGridView();

            _addButtonColumn = new DataGridViewButtonColumn();
            AddButtonColumn();

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

        private void AddButtonColumn()
        {
            _addButtonColumn = new DataGridViewButtonColumn();
            _addButtonColumn.Name = "AddButtonColumn";
            _addButtonColumn.HeaderText = "";
            _addButtonColumn.Text = "View Details";
            _addButtonColumn.UseColumnTextForButtonValue = true;
            this.RentalTransactionDataGridView.Columns.Add(_addButtonColumn);
        }

        private void RentalTransactionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == RentalTransactionDataGridView.Columns["AddButtonColumn"].Index)
            {
                RentalTransaction transaction = new RentalTransaction();

                transaction = _rentalTransactions[e.RowIndex];

                _rentalLineItems = this._rentalLineItemController.GetRentalLineItemsByRentalTransactionID(transaction.RentalTransactionID);
                DetailsDataGridView.DataSource = null;
                DetailsDataGridView.DataSource = _rentalLineItems;
                DetailsDataGridView.Columns[0].HeaderText = "Rental Line Item ID";
                DetailsDataGridView.Columns[1].HeaderText = "Rental Transaction ID";
                DetailsDataGridView.Columns[2].HeaderText = "Furniture ID";
                DetailsDataGridView.Columns[3].HeaderText = "Quantity";
                DetailsDataGridView.Columns[4].HeaderText = "Quantity Returned";
                DetailsDataGridView.Columns[5].HeaderText = "Daily Cost";
            }
        }
    }
}


