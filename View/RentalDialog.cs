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

            this.rentalShoppingCartUserControl.Username = username;
            this.rentalShoppingCartUserControl.Member = selectedMember;
        }

        private void RentalDialog_Load(object sender, EventArgs e)
        {
            this.rentalSearchFurnitureUserControl.SearchFurnitureUserControl_Load(sender, e);
            this.rentalSearchFurnitureUserControl.TurnOnAddButtonColumn();
            this.rentalSearchFurnitureUserControl.furnitureDataGridView.CellClick += FurnitureDataGridView_CellClick;
        }

        private void FurnitureDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.rentalSearchFurnitureUserControl.furnitureDataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                Furniture furniture = this.rentalSearchFurnitureUserControl._furniture[e.RowIndex];

                this.rentalShoppingCartUserControl.AddRentalLineItem(furniture, 1);
                this.rentalShoppingCartUserControl.RefreshCartAndTotals();
            }
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
