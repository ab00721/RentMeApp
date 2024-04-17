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
        private readonly CheckedOutUserControl _checkedOutUserControl;
        private readonly DataGridView _checkedOutDataGridView;
        private readonly bool transactionSaved = false;
        private readonly Member _member;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnDialog"/> class.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="selectedMember">The selected member.</param>
        public ReturnDialog(string username, string firstName, Member selectedMember)
        {
            InitializeComponent();

            this._member = selectedMember;

            UserUserControl userUserControl = new UserUserControl(username, firstName);
            returnTableLayoutPanel.Controls.Add(userUserControl);

            MemberUserControl memberUserControl = new MemberUserControl(_member);
            returnTableLayoutPanel.Controls.Add(memberUserControl);

            _checkedOutUserControl = new CheckedOutUserControl(_member);
            returnTableLayoutPanel.Controls.Add(_checkedOutUserControl);

            _checkedOutDataGridView = _checkedOutUserControl.CheckedOutDataGridView;
        }        

        private void ReturnDialog_Load(object sender, EventArgs e)
        {
            _checkedOutUserControl.CheckedOutUserControl_Load(sender, e);
            _checkedOutDataGridView.CellClick += CheckedOutDataGridView_CellClick;
        }

        private void CheckedOutDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == _checkedOutDataGridView.Columns["ReturnButtonColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = _checkedOutDataGridView.Rows[e.RowIndex];

                string furnitureName = row.Cells["Name"].Value.ToString();

                returnCartLabel.Text = "Return furniture: " + furnitureName;

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
