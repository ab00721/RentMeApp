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

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnDialog"/> class.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="selectedMember">The selected member.</param>
        public ReturnDialog(string username, string firstName, Member selectedMember)
        {
            InitializeComponent();

            UserUserControl userUserControl = new UserUserControl(username, firstName);
            returnTableLayoutPanel.Controls.Add(userUserControl);

            MemberUserControl memberUserControl = new MemberUserControl(selectedMember);
            returnTableLayoutPanel.Controls.Add(memberUserControl);

            checkedOutUserControl.Member = selectedMember;

            returnUserControl.Username = username;
            returnUserControl.Member = selectedMember;
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
                try
                {
                    CheckedOutItem checkedOutItem = checkedOutUserControl._checkedOutItems[e.RowIndex];
                    returnUserControl.AddReturnLineItem(checkedOutItem, checkedOutItem.QuantityOut);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

