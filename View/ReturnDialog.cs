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
        private bool transactionSaved = false;
        private Member _member;

        public ReturnDialog(string username, string firstName, Member selectedMember)
        {
            InitializeComponent();

            this._member = selectedMember;

            UserUserControl userUserControl = new UserUserControl(username, firstName);
            returnTableLayoutPanel.Controls.Add(userUserControl);

            MemberUserControl memberUserControl = new MemberUserControl(_member);
            returnTableLayoutPanel.Controls.Add(memberUserControl);

            CheckedOutUserControl checkedOutUserControl = new CheckedOutUserControl(_member);
            returnTableLayoutPanel.Controls.Add(checkedOutUserControl);
        }

        private void ReturnDialog_Load(object sender, EventArgs e)
        {

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
