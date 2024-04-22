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
    public partial class ReturnUserControl : UserControl
    {
        public event EventHandler ReturnTransactionSaved;

        private ReturnSummaryDialog _returnSummaryDialog;

        public string Username { get; set; }
        public Member Member { get; set; }

        internal ReturnPointOfSaleService _returnPointOfSaleService;

        private DataGridViewButtonColumn _removeButtonColumn;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnUserControl"/> class.
        /// </summary>
        public ReturnUserControl()
        {
            InitializeComponent();
            _returnPointOfSaleService = new ReturnPointOfSaleService();
        }

        /// <summary>
        /// Refreshes the data grid view, the cart, and the totals.
        /// </summary>
        public void RefreshCartAndTotals()
        {
            RefreshDataGridView();
            ConfigureDataGridView();
            StyleDataGridView();
            RefreshTotal();
            EvaluateQuantityCellValues();
        }

        /// <summary>
        /// Adds a return line item to the cart.
        /// </summary>
        /// <param name="checkedOutItem">The checked-out item to add.</param>
        /// <param name="quantity">The quantity of the furniture to add.</param>
        public void AddReturnLineItem(CheckedOutItem checkedOutItem, int quantity)
        {
            _returnPointOfSaleService.AddReturnLineItem(checkedOutItem.RentalLineItemID, quantity);
            RefreshCartAndTotals();
        }

        /// <summary>
        /// Removes the return line items from the cart that are associated with the given rental line itme.
        /// </summary>
        /// <param name="rentalLineItemID">The rentalLineItem to associated with the return line times to remove.</param>
        public void RemoveReturnLineItems(int rentalLineItemID)
        {
            _returnPointOfSaleService.RemoveReturnLineItems(rentalLineItemID);
            RefreshCartAndTotals();
        }

        /// <summary>
        /// Event handler for the load event of the ReturnUserControl.
        /// </summary>
        public void ReturnUserControl_Load(object sender, EventArgs e)
        {
            _returnPointOfSaleService.SetMember(Member);
            _returnPointOfSaleService.SetEmployee(Username);

            AddRemoveButtonColumn();
            RefreshCartAndTotals();
        }

        private void ReturnCartDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == returnCartDataGridView.Columns["RemoveButtonColumn"].Index && e.RowIndex >= 0)
            {
                ReturnCartItem cartItem = (ReturnCartItem)returnCartDataGridView.Rows[e.RowIndex].DataBoundItem;
                RemoveReturnLineItems(cartItem.RentalLineItemID);
                RefreshCartAndTotals();
            }
        }

        private void ReturnCartDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == returnCartDataGridView.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                DataGridViewCell cell = returnCartDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value != null && int.TryParse(cell.Value.ToString(), out int newQuantity) && newQuantity > 0)
                {
                    ReturnCartItem cartItem = (ReturnCartItem)returnCartDataGridView.Rows[e.RowIndex].DataBoundItem;
                    RentalLineItem rentalLineItem = _returnPointOfSaleService.GetRentalLineItemByReturnCartItem(cartItem);

                    _returnPointOfSaleService.UpdateReturnLineItem(rentalLineItem, newQuantity);
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

        private void ReturnCartDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("The quantity must be an integer.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EmptyButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to empty your cart?", "Empty Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _returnPointOfSaleService = new ReturnPointOfSaleService();
                _returnPointOfSaleService.SetMember(Member);
                _returnPointOfSaleService.SetEmployee(Username);

                RefreshCartAndTotals();
            }
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to proceed with return?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _returnPointOfSaleService.ValidAllQuantities(returnCartDataGridView);

                    EmployeeDTO employee = _returnPointOfSaleService.GetEmployee();
                    Member member = _returnPointOfSaleService.GetMember();

                    ReturnTransaction emptyTransaction = _returnPointOfSaleService.CreateReturnTransaction(employee, member);
                    List<ReturnLineItem> lineItems = _returnPointOfSaleService.GetReturnLineItems();
                    int transactionID = _returnPointOfSaleService.SaveReturnTransaction(emptyTransaction, lineItems);

                    ReturnTransactionSaved?.Invoke(this, EventArgs.Empty);

                    _returnSummaryDialog = new ReturnSummaryDialog(employee, member, transactionID);
                    _returnSummaryDialog.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConfigureDataGridView()
        {
            returnCartDataGridView.Columns[0].HeaderText = "Remove From Cart";
            returnCartDataGridView.Columns[1].HeaderText = "Rental Line";
            returnCartDataGridView.Columns[2].HeaderText = "Furniture ID";
            returnCartDataGridView.Columns[3].HeaderText = "Furniture Name";
            returnCartDataGridView.Columns[4].HeaderText = "Daily Cost";
            returnCartDataGridView.Columns[5].HeaderText = "Qty To Return";
            returnCartDataGridView.Columns[6].HeaderText = "Expected Duration";
            returnCartDataGridView.Columns[7].HeaderText = "Already Paid";
            returnCartDataGridView.Columns[8].HeaderText = "Actual Duration";
            returnCartDataGridView.Columns[9].HeaderText = "Actual Price";
            returnCartDataGridView.Columns[10].HeaderText = "Subtotal";
        }

        private void StyleDataGridView()
        {
            returnCartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            returnCartDataGridView.Columns["RentalLineItemID"].ReadOnly = true;
            returnCartDataGridView.Columns["FurnitureID"].ReadOnly = true;
            returnCartDataGridView.Columns["Name"].ReadOnly = true;
            returnCartDataGridView.Columns["DailyRate"].ReadOnly = true;
            returnCartDataGridView.Columns["Quantity"].ReadOnly = false;
            returnCartDataGridView.Columns["ExpectedDuration"].ReadOnly = true;
            returnCartDataGridView.Columns["AlreadyPaid"].ReadOnly = true;
            returnCartDataGridView.Columns["ActualDuration"].ReadOnly = true;
            returnCartDataGridView.Columns["ActualPrice"].ReadOnly = true;
            returnCartDataGridView.Columns["Subtotal"].ReadOnly = true;
        }

        private void EvaluateQuantityCellValues()
        {
            _returnPointOfSaleService.EvaluateQuantityCellValues(returnCartDataGridView);
        }

        private void RefreshDataGridView()
        {
            returnCartDataGridView.DataSource = null;
            returnCartDataGridView.DataSource = _returnPointOfSaleService.GetReturnCartItems();
        }

        private void RefreshTotal()
        {
            decimal total = _returnPointOfSaleService.CalculateAmountDue(DateTime.Now);
            returnTotalValueLabel.Text = $"{total:C}";
        }

        private void AddRemoveButtonColumn()
        {
            _removeButtonColumn = new DataGridViewButtonColumn();
            _removeButtonColumn.Name = "RemoveButtonColumn";
            _removeButtonColumn.HeaderText = "Remove From Cart";
            _removeButtonColumn.Text = "Remove";
            _removeButtonColumn.UseColumnTextForButtonValue = true;
            returnCartDataGridView.Columns.Add(_removeButtonColumn);
        }
    }
}
