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
        private bool transactionSaved = false;

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
            rentalTableLayoutPanel.Controls.Add(userUserControl);

            MemberUserControl memberUserControl = new MemberUserControl(selectedMember);
            rentalTableLayoutPanel.Controls.Add(memberUserControl);

            rentalShoppingCartUserControl.Username = username;
            rentalShoppingCartUserControl.Member = selectedMember;

            rentalShoppingCartUserControl.RentalTransactionSaved += (sender, e) =>
            {
                transactionSaved = true;
                Close();
            };
        }

        private void RentalDialog_Load(object sender, EventArgs e)
        {
            rentalSearchFurnitureUserControl.SearchFurnitureUserControl_Load(sender, e);
            rentalSearchFurnitureUserControl.TurnOnAddButtonColumn();
            rentalSearchFurnitureUserControl.furnitureDataGridView.CellClick += FurnitureDataGridView_CellClick;
        }

        private void FurnitureDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rentalSearchFurnitureUserControl.furnitureDataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                Furniture furniture = rentalSearchFurnitureUserControl._furniture[e.RowIndex];

                rentalShoppingCartUserControl.AddRentalLineItem(furniture, 1);
                rentalShoppingCartUserControl.RefreshCartAndTotals();
            }
        }

        private void RentalDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !transactionSaved)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit? Your cart will not be saved.", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
