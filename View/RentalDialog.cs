using System;
using System.Windows.Forms;
using RentMeApp.Model;
using RentMeApp.UserControls;

namespace RentMeApp.View
{
    /// <summary>
    /// New Order Rental Dialog Form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RentalDialog : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RentalDialog"/> class.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="selectedMember">The selected member.</param>
        public RentalDialog(string username, string firstName, Member selectedMember)
        {
            InitializeComponent();
            UserUserControl userUserControl = new UserUserControl(username, firstName);
            this.rentalTableLayoutPanel.Controls.Add(userUserControl);
            MemberUserControl memberUserControl = new MemberUserControl(selectedMember);
            this.rentalTableLayoutPanel.Controls.Add(memberUserControl);
        }

        private void RentalDialog_Load(object sender, EventArgs e)
        {
            this.rentalSearchFurnitureUserControl.SearchFurnitureUserControl_Load(sender, e);
            this.rentalSearchFurnitureUserControl.TurnOnAddButtonColumn();
        }

        private void RentalDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit? Your cart will not be saved.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        
    }
}
