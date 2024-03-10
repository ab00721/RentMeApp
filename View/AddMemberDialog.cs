using RentMeApp.Controller;
using RentMeApp.Model;
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
    public partial class AddMemberDialog : Form
    {
        private readonly MemberControllerX _MemberControllerX;
        private MemberX member;
        public AddMemberDialog()
        {
            InitializeComponent();
            this._MemberControllerX = new MemberControllerX();
            member = new MemberX();
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            member.LastName = this.LastNameTextBox.Text;
            member.FirstName = this.FirstNameTextBox.Text;
            member.Phone = this.PhoneTextBox.Text;
            member.MemberID = 5;
            this._MemberControllerX.Register(member);
        }
    }
}
