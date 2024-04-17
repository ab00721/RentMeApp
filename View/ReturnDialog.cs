using RentMeApp.Model;
using RentMeApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMeApp.View
{
    public partial class ReturnDialog : Form
    {
        CheckedOutUserControl _checkedOutUserControl;
        DataGridView _checkedOutDataGridView;
        private bool transactionSaved = false;
        private readonly Member _member;

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

                string furnitrueID = row.Cells["FurnitureID"].Value.ToString();

                returnCartLabel.Text = "Return furniture:" + furnitrueID;

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
