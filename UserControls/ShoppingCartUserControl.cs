using RentMeApp.Model;
using System;
using System.Windows.Forms;

namespace RentMeApp.UserControls
{
    /// <summary>
    /// User control for the shopping cart feature.
    /// </summary>
    public partial class ShoppingCartUserControl : UserControl
    {
        internal RentalPointOfSaleService _rentalPointOfSaleService;
        DataGridViewButtonColumn _removeButtonColumn;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCartUserControl"/> class.
        /// </summary>
        public ShoppingCartUserControl()
        {
            InitializeComponent();
            _rentalPointOfSaleService = new RentalPointOfSaleService();
            AddRemoveButtonColumn();
            RefreshCartAndTotals();
        }

        /// <summary>
        /// Handles the Load event of the ShoppingCartUserControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void ShoppingCartUserControl_Load(object sender, EventArgs e)
        {
            RefreshCartAndTotals();
        }

        /// <summary>
        /// Handles the click event of the RemoveButton in the shoppingCartDataGridView.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        public void ShoppingCartDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == shoppingCartDataGridView.Columns["RemoveButtonColumn"].Index && e.RowIndex >= 0)
            {
                RentalCartItem cartItem = (RentalCartItem)shoppingCartDataGridView.Rows[e.RowIndex].DataBoundItem;
                Furniture furniture = _rentalPointOfSaleService.GetFurnitureByRentalCartItem(cartItem);

                RemoveRentalLineItem(furniture);

                RefreshCartAndTotals();
            }
        }

        /// <summary>
        /// Handles the CellValueChanged event of the shoppingCartDataGridView.
        /// Updates the rental line items in the pos service when the user changes the quantity column.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        public void ShoppingCartDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == shoppingCartDataGridView.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                int newQuantity = Convert.ToInt32(shoppingCartDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (newQuantity < 1)
                {
                    MessageBox.Show("The quantity cannot be less than 1.\nUse the \"Remove\" button if you intend to delete the line item.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newQuantity = 1;
                }

                RentalCartItem cartItem = (RentalCartItem)shoppingCartDataGridView.Rows[e.RowIndex].DataBoundItem;
                Furniture furniture = _rentalPointOfSaleService.GetFurnitureByRentalCartItem(cartItem);
                _rentalPointOfSaleService.UpdateRentalLineItem(furniture, newQuantity);
                RefreshCartAndTotals();
            }
        }

        /// <summary>
        /// Sets the due date in the rentalPointOfSaleService when rentalDateTimePicker value changes.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void RentalDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dueDate = rentalDateTimePicker.Value;
            _rentalPointOfSaleService.SetDueDate(dueDate);
            RefreshCartAndTotals();
        }

        /// <summary>
        /// Handles the click event of the emptyButton.
        /// Clears the rental point of sale service and refreshes the cart and totals.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void emptyButton_Click(object sender, EventArgs e)
        {
            _rentalPointOfSaleService = new RentalPointOfSaleService();
            RefreshCartAndTotals();
        }

        /// <summary>
        /// Refreshes the data grid view, the cart, and the totals.
        /// </summary>
        public void RefreshCartAndTotals()
        {
            RefreshDataGridView();
            StyleDataGridView();
            RefreshDuration();
            RefreshTotal();
        }

        private void StyleDataGridView()
        {
            this.shoppingCartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.shoppingCartDataGridView.Columns["FurnitureID"].ReadOnly = true;
            this.shoppingCartDataGridView.Columns["Name"].ReadOnly = true;
            this.shoppingCartDataGridView.Columns["DailyRate"].ReadOnly = true;
            this.shoppingCartDataGridView.Columns["Quantity"].ReadOnly = false;
            this.shoppingCartDataGridView.Columns["Quantity"].DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info;
            this.shoppingCartDataGridView.Columns["Price"].ReadOnly = true;
        }

        private void RefreshDataGridView()
        {
            shoppingCartDataGridView.DataSource = null;
            shoppingCartDataGridView.DataSource = _rentalPointOfSaleService.GetRentalCartItems();
        }

        private void RefreshDuration()
        {
            int duration = DurationService.DurationInDays(DateTime.Now, _rentalPointOfSaleService.GetDueDate());
            daysRentedValueLabel.Text = $"{duration}";
        }

        private void RefreshTotal()
        {
            decimal total = _rentalPointOfSaleService.CalculateExpectedTransactionCostForDuration();
            rentalTotalValueLabel.Text = $"{total:C}";
        }

        /// <summary>
        /// Adds a rental line item to the cart.
        /// </summary>
        /// <param name="furniture">The furniture to add.</param>
        /// <param name="quantity">The quantity of the furniture to add.</param>
        public void AddRentalLineItem(Furniture furniture, int quantity)
        {
            _rentalPointOfSaleService.AddRentalLineItem(furniture, quantity);
            RefreshCartAndTotals();
        }

        /// <summary>
        /// Removes a rental line item from the cart.
        /// </summary>
        /// <param name="furniture">The furniture to remove.</param>
        public void RemoveRentalLineItem(Furniture furniture)
        {
            _rentalPointOfSaleService.RemoveRentalLineItem(furniture);
            RefreshCartAndTotals();
        }

        private void AddRemoveButtonColumn()
        {
            _removeButtonColumn = new DataGridViewButtonColumn();
            _removeButtonColumn.Name = "RemoveButtonColumn";
            _removeButtonColumn.HeaderText = "Remove From Cart";
            _removeButtonColumn.Text = "Remove";
            _removeButtonColumn.UseColumnTextForButtonValue = true;
            shoppingCartDataGridView.Columns.Add(_removeButtonColumn);
        }
    }
}
