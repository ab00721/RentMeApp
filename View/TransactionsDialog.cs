using RentMeApp.Controller;
using RentMeApp.Model;
using RentMeApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMeApp.View
{
    public partial class TransactionsDialog : Form
    {
        private readonly SearchMemberUserControl _searchMemberUserControl;
        private readonly UserUserControl _userUserControl;
        private readonly RentalTransactionController _rentalTransactionController;
        private List<RentalTransaction> rentalTransactions;
        private Member member;
        DataGridViewButtonColumn _addButtonColumn;


        public TransactionsDialog(SearchMemberUserControl searchMemberUserController, string username, string firstName, Member selectedMember)
        {
            InitializeComponent();
            _userUserControl = new UserUserControl(username, firstName);
            this.userTableLayoutPanel.Controls.Add(_userUserControl);
            this._searchMemberUserControl = searchMemberUserController;
            this.member = selectedMember;
            this._rentalTransactionController = new RentalTransactionController();
            this.RefreshRentalTransactionDataGridView();
            _addButtonColumn = new DataGridViewButtonColumn();
            AddButtonColumn();
            MemberUserControl memberUserControl = new MemberUserControl(selectedMember);
            this.TransactionTableLayout.Controls.Add(memberUserControl);
        }

        public void RefreshRentalTransactionDataGridView()
        {
            RefreshRentalTransactionDataGridView(this._rentalTransactionController.GetAllRentalTransactionsByMemberId(this.member.MemberID));
        }

        private void RefreshRentalTransactionDataGridView(List<RentalTransaction> transactions)
        {
            rentalTransactions = transactions;
            RentalTransactionDataGridView.DataSource = null;
            RentalTransactionDataGridView.DataSource = rentalTransactions;
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
                MessageBox.Show(e.RowIndex.ToString());

                rentalTransactions = this._rentalTransactionController.GetAllRentalTransactionsByMemberId(this.member.MemberID);
                DetailsDataGridView.DataSource = null;
                DetailsDataGridView.DataSource = rentalTransactions;
            }
        }
    }
}


