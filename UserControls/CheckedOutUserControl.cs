using RentMeApp.Controller;
using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMeApp.UserControls
{
    /// <summary>
    /// User Control for Checked Out Items
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class CheckedOutUserControl : UserControl
    {
        private readonly RentalTransactionController _rentalTransactionController;
        private readonly CheckedOutItemController _checkedOutItemController;
        private readonly DataGridViewButtonColumn _returnButtonColumn;
        public List<CheckedOutItem> _checkedOutItems;
        public Member _member;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckedOutUserControl"/> class.
        /// </summary>
        /// <param name="selectedMember">The selected member.</param>
        public CheckedOutUserControl(Member selectedMember)
        {
            InitializeComponent();
            _rentalTransactionController = new RentalTransactionController();
            _checkedOutItemController = new CheckedOutItemController();
            _checkedOutItems = new List<CheckedOutItem>();
            _returnButtonColumn = new DataGridViewButtonColumn();
            ReturnButtonColumn();
            this._member = selectedMember;
        }

        /// <summary>
        /// Handles the Load event of the CheckedOutUserControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void CheckedOutUserControl_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            checkedOutDataGridView.Columns[0].HeaderText = "Return Item";
            checkedOutDataGridView.Columns[1].HeaderText = "Furniture ID";
            checkedOutDataGridView.Columns[2].HeaderText = "Furniture Name";
            checkedOutDataGridView.Columns[3].HeaderText = "Quantity Out";
            checkedOutDataGridView.Columns[4].HeaderText = "Daily Cost";
            checkedOutDataGridView.Columns[5].HeaderText = "Rental ID";
            checkedOutDataGridView.Columns[6].HeaderText = "Due Date";
        }

        /// <summary>
        /// Refreshes the data grid view.
        /// </summary>
        public void RefreshDataGridView()
        {
            RefreshDataGridView(this.GetCheckedOutFurnitureForMember(_member.MemberID));
        }
        private void RefreshDataGridView(List<CheckedOutItem> checkedOutItems)
        {
            _checkedOutItems = checkedOutItems;
            checkedOutDataGridView.DataSource = null;
            checkedOutDataGridView.DataSource = _checkedOutItems;
            checkedOutDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReturnButtonColumn()
        {
            _returnButtonColumn.Name = "ReturnButtonColumn";
            _returnButtonColumn.HeaderText = "Return";
            _returnButtonColumn.Text = "Return";
            _returnButtonColumn.UseColumnTextForButtonValue = true;
            checkedOutDataGridView.Columns.Add(_returnButtonColumn);
        }

        /// <summary>
        /// Gets the checked out furniture for member.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
        public List<CheckedOutItem> GetCheckedOutFurnitureForMember(int memberID)
        {
            List<CheckedOutItem> checkedOutItems = new List<CheckedOutItem>();
            List<RentalTransaction> rentalTransactions = _rentalTransactionController.GetAllRentalTransactionsByMemberId(memberID);

            foreach (RentalTransaction transaction in rentalTransactions)
            {
                List<CheckedOutItem> itemsInTransaction = _checkedOutItemController.GetCheckedOutItemsByRentalTransactionID(transaction.RentalTransactionID);
                checkedOutItems.AddRange(itemsInTransaction);
            }
            return checkedOutItems;
        }

        /// <summary>
        /// Gets the checked out data grid view.
        /// </summary>
        /// <value>
        /// The checked out data grid view.
        /// </value>
        public DataGridView CheckedOutDataGridView
        {
            get { return checkedOutDataGridView; }
        }
    }
}
