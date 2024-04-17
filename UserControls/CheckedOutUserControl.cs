using RentMeApp.Controller;
using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RentMeApp.UserControls
{
    public partial class CheckedOutUserControl : UserControl
    {
        private readonly RentalTransactionController _rentalTransactionController;
        private readonly CheckedOutItemController _checkedOutItemController;
        private readonly DataGridViewButtonColumn _returnButtonColumn;
        public List<CheckedOutItem> _checkedOutItems;
        public Member _member;

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

        public DataGridView CheckedOutDataGridView
        {
            get { return checkedOutDataGridView; }
        }
    }
}
