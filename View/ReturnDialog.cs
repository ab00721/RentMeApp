using RentMeApp.Model;
using RentMeApp.UserControls;
using System;
using System.Windows.Forms;

namespace RentMeApp.View
{
    /// <summary>
    /// New Return Dialog Form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ReturnDialog : Form
    {
        private readonly bool transactionSaved = false;
        private readonly Member _member;

        internal CheckedOutUserControl checkedOutUserControl;
        internal DataGridView checkedOutDataGridView;
        internal ShoppingCartUserControl rentalShoppingCartUserControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnDialog"/> class.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="selectedMember">The selected member.</param>
        public ReturnDialog(string username, string firstName, Member selectedMember)
        {
            this._member = selectedMember;

            InitializeComponent();

            UserUserControl userUserControl = new UserUserControl(username, firstName);
            returnTableLayoutPanel.Controls.Add(userUserControl);

            MemberUserControl memberUserControl = new MemberUserControl(_member);
            returnTableLayoutPanel.Controls.Add(memberUserControl);

            checkedOutUserControl = new CheckedOutUserControl();
            checkedOutUserControl.Member = _member;
            returnTableLayoutPanel.Controls.Add(checkedOutUserControl);

            rentalShoppingCartUserControl = new ShoppingCartUserControl();
            returnTableLayoutPanel.Controls.Add(rentalShoppingCartUserControl);
        }        

        private void ReturnDialog_Load(object sender, EventArgs e)
        {
            checkedOutUserControl.CheckedOutUserControl_Load(sender, e);
            checkedOutUserControl.checkedOutDataGridView.CellClick += CheckedOutDataGridView_CellClick;
        }

        private void CheckedOutDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkedOutUserControl.checkedOutDataGridView.Columns["ReturnButtonColumn"] is DataGridViewButtonColumn)
            {
                DataGridViewRow row = checkedOutUserControl.checkedOutDataGridView.Rows[e.RowIndex];

                string furnitureName = row.Cells["Name"].Value.ToString();

                MessageBox.Show("You have selected to return " + furnitureName + ".", "Confirmation", MessageBoxButtons.OK);
            }
        }

        private void ReturnDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !transactionSaved)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit? Your return will not be saved.", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

