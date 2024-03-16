using System;
using System.Windows.Forms;

namespace RentMeApp.View
{
    public partial class MemberUpdatedSuccessfully : Form
    {
        public MemberUpdatedSuccessfully(int MemberId)
        {
            InitializeComponent();
            this.MemberId.Text = MemberId.ToString();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void MemberUpdatedSuccessfully_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
