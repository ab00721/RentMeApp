using RentMeApp.Model;
using RentMeApp.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMeApp.UserControls
{
    /// <summary>
    /// User control for the shopping cart feature.
    /// </summary>
    public partial class ShoppingCartUserControl : UserControl
    {
        public event EventHandler RentalTransactionSaved;

        private RentalSummaryDialog _rentalSummaryDialog;

        public string Username { get; set; }
        public Member Member { get; set; }

        internal RentalPointOfSaleService _rentalPointOfSaleService;

        private DataGridViewButtonColumn _removeButtonColumn;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCartUserControl"/> class.
        /// </summary>
        public ShoppingCartUserControl()
        {
            InitializeComponent();
            _rentalPointOfSaleService = new RentalPointOfSaleService();
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

        /// <summary>
        /// Event handler for the load event of the ShoppingCartUserControl.
        /// </summary>
        public void ShoppingCartUserControl_Load(object sender, EventArgs e)
        {
            _rentalPointOfSaleService.SetMember(Member);
            _rentalPointOfSaleService.SetEmployee(Username);

            AddRemoveButtonColumn();
            SetDatePickerMinDateToToday();
            RefreshCartAndTotals();
        }

        private void ShoppingCartDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == shoppingCartDataGridView.Columns["RemoveButtonColumn"].Index && e.RowIndex >= 0)
            {
                RentalCartItem cartItem = (RentalCartItem)shoppingCartDataGridView.Rows[e.RowIndex].DataBoundItem;
                Furniture furniture = _rentalPointOfSaleService.GetFurnitureByRentalCartItem(cartItem);
                RemoveRentalLineItem(furniture);
                RefreshCartAndTotals();
            }
        }

        private void ShoppingCartDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == shoppingCartDataGridView.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                DataGridViewCell cell = shoppingCartDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value != null && int.TryParse(cell.Value.ToString(), out int newQuantity) && newQuantity > 0)
                {
                    RentalCartItem cartItem = (RentalCartItem)shoppingCartDataGridView.Rows[e.RowIndex].DataBoundItem;
                    Furniture furniture = _rentalPointOfSaleService.GetFurnitureByRentalCartItem(cartItem);

                    _rentalPointOfSaleService.UpdateRentalLineItem(furniture, newQuantity);
                    RefreshCartAndTotals();
                }
                else
                {
                    cell.Style.BackColor = System.Drawing.Color.LightPink;
                    cell.ErrorText = "Invalid quantity";

                    MessageBox.Show("The quantity must be greater than 0.\n\nUse the \"Remove\" button if you intend to delete the line item.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShoppingCartDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("The quantity must be an integer.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RentalDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dueDate = rentalDateTimePicker.Value;
            _rentalPointOfSaleService.SetDueDate(dueDate);
            RefreshCartAndTotals();
        }

        private void EmptyButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to empty your cart?", "Empty Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _rentalPointOfSaleService = new RentalPointOfSaleService();
                _rentalPointOfSaleService.SetMember(Member);
                _rentalPointOfSaleService.SetEmployee(Username);

                RefreshCartAndTotals();
                SetDatePickerValueToToday();
            }
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to proceed with checkout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    EmployeeDTO employee = _rentalPointOfSaleService.GetEmployee();
                    Member member = _rentalPointOfSaleService.GetMember();

                    RentalTransaction emptyTransaction = _rentalPointOfSaleService.CreateRentalTransaction();
                    List<RentalLineItem> lineItems = _rentalPointOfSaleService.GetRentalLineItems();
                    int transactionID = _rentalPointOfSaleService.SaveRentalTransaction(emptyTransaction, lineItems);

                    RentalTransactionSaved?.Invoke(this, EventArgs.Empty);

                    _rentalSummaryDialog = new RentalSummaryDialog(employee, member, transactionID);
                    _rentalSummaryDialog.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StyleDataGridView()
        {
            shoppingCartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            shoppingCartDataGridView.Columns["FurnitureID"].ReadOnly = true;
            shoppingCartDataGridView.Columns["Name"].ReadOnly = true;
            shoppingCartDataGridView.Columns["DailyRate"].ReadOnly = true;
            shoppingCartDataGridView.Columns["Quantity"].ReadOnly = false;
            shoppingCartDataGridView.Columns["Quantity"].DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info;
            shoppingCartDataGridView.Columns["Price"].ReadOnly = true;
        }

        private void RefreshDataGridView()
        {
            shoppingCartDataGridView.DataSource = null;
            shoppingCartDataGridView.DataSource = _rentalPointOfSaleService.GetRentalCartItems();
        }

        private void RefreshDuration()
        {
            int duration = DurationService.RentalDurationInDays(DateTime.Now, _rentalPointOfSaleService.GetDueDate());
            daysRentedValueLabel.Text = $"{duration}";
        }

        private void RefreshTotal()
        {
            decimal total = _rentalPointOfSaleService.CalculateExpectedTransactionCostForDuration();
            rentalTotalValueLabel.Text = $"{total:C}";
        }

        private void SetDatePickerValueToToday()
        {
            rentalDateTimePicker.Value = DateTime.Today;
        }

        private void SetDatePickerMinDateToToday()
        {
            rentalDateTimePicker.MinDate = DateTime.Today;
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
