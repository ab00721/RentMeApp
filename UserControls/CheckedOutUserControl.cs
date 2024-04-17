using RentMeApp.Controller;
using RentMeApp.Model;
using RentMeApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RentMeApp.UserControls
{
    public partial class CheckedOutUserControl : UserControl
    {
        private readonly FurnitureController _furnitureController;
        private readonly RentalTransactionController _rentalTransactionController;
        private readonly RentalLineItemController _rentalLineItemController;
        DataGridViewButtonColumn _returnButtonColumn;
        public List<Furniture> _furniture;
        public List<RentalLineItem> _lineItems;
        public Member _member;

        public CheckedOutUserControl(Member selectedMember)
        {
            InitializeComponent();
            _furnitureController = new FurnitureController();
            _rentalTransactionController = new RentalTransactionController();
            _rentalLineItemController = new RentalLineItemController();
            _furniture = new List<Furniture>();
            _returnButtonColumn = new DataGridViewButtonColumn();
            ReturnButtonColumn();
            this._member = selectedMember;
        }

        public void CheckedOutUserControl_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            RefreshDataGridView(this.GetCheckedOutFurnitureForMember(_member.MemberID));
        }
        private void RefreshDataGridView(List<RentalLineItem> lineItems)
        {
            _lineItems = lineItems;
            checkedOutDataGridView.DataSource = null;
            checkedOutDataGridView.DataSource = _lineItems;
            checkedOutDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReturnButtonColumn()
        {
            _returnButtonColumn.Name = "ReturnButtonColumn";
            _returnButtonColumn.HeaderText = "Return";
            _returnButtonColumn.Text = "Return";
            _returnButtonColumn.UseColumnTextForButtonValue = true;
            checkedOutDataGridView.Columns.Add(_returnButtonColumn);
        }

        public List<RentalLineItem> GetCheckedOutFurnitureForMember(int memberID)
        {
            List<RentalLineItem> lineItems = new List<RentalLineItem>();
            List<RentalTransaction> rentalTransactions = _rentalTransactionController.GetAllRentalTransactionsByMemberId(memberID);

            foreach (RentalTransaction transaction in rentalTransactions)
            {
                lineItems = _rentalLineItemController.GetRentalLineItemsByRentalTransactionID(transaction.RentalTransactionID);
            }
            return lineItems;
        }

        public DataGridView CheckedOutDataGridView
        {
            get { return checkedOutDataGridView; }
        }

    }
}
