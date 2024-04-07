using RentMeApp.Model;
using RentMeApp.UserControls;
using System;
using System.Windows.Forms;

namespace RentMeApp.View
{
    public partial class RentalSummaryDialog : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RentalDialog"/> class.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="selectedMember">The selected member.</param>
        public RentalSummaryDialog(string username, string firstName, Member selectedMember)
        {
            InitializeComponent();
            UserUserControl userUserControl = new UserUserControl(username, firstName);
            this.rentalSummaryTableLayoutPanel.Controls.Add(userUserControl);
            MemberUserControl memberUserControl = new MemberUserControl(selectedMember);
            this.rentalSummaryTableLayoutPanel.Controls.Add(memberUserControl);

            // this.rentalShoppingCartUserControl.Username = username;
            // this.rentalShoppingCartUserControl.Member = selectedMember;
        }
    }
}
