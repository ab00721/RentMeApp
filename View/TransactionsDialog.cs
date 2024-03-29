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

        public TransactionsDialog(SearchMemberUserControl searchMemberUserController, string username, string firstName, Member selectedMember)
        {
            InitializeComponent();
            _userUserControl = new UserUserControl(username, firstName);
            this.userTableLayoutPanel.Controls.Add(_userUserControl);
            this._searchMemberUserControl = searchMemberUserController;
            this.member = selectedMember;
            this._rentalTransactionController = new RentalTransactionController();
            this.SetMemberInfoTableLayout(this.member);
            this.RefreshDataGridView();
        }

        private void SetMemberInfoTableLayout(Member selectedMember)
        {
            this.MemberIdInfoLabel.Text = selectedMember.MemberID.ToString();
            this.MemberNameInfoLabel.Text = selectedMember.FirstName.ToString() + " " + selectedMember.LastName.ToString();
            this.MemberInfoTabelLayout.BorderStyle = BorderStyle.FixedSingle;
        }

        public void RefreshDataGridView()
        {
            RefreshDataGridView(this._rentalTransactionController.GetAllRentalTransactionsByMemberId(this.member.MemberID));
        }

        private void RefreshDataGridView(List<RentalTransaction> transactions)
        {
            rentalTransactions = transactions;
            RentalTransactionDataGridView.DataSource = null;
            RentalTransactionDataGridView.DataSource = rentalTransactions;
        }
    }
}


