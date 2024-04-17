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
            this._member = selectedMember;
        }

        private void CheckedOutUserControl_Load(object sender, EventArgs e)
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

        public List<RentalLineItem> GetCheckedOutFurnitureForMember(int memberID)
        {
            //List<Furniture> checkedOutFurniture = new List<Furniture>();

            List<RentalLineItem> lineItems = new List<RentalLineItem>();
            List<RentalTransaction> rentalTransactions = _rentalTransactionController.GetAllRentalTransactionsByMemberId(memberID);

            foreach (RentalTransaction transaction in rentalTransactions)
            {
                // List<RentalLineItem> lineItems = _rentalLineItemController.GetRentalLineItemsByRentalTransactionID(transaction.RentalTransactionID);
                lineItems = _rentalLineItemController.GetRentalLineItemsByRentalTransactionID(transaction.RentalTransactionID);
                //foreach (RentalLineItem lineItem in lineItems)
                //{
                //   Furniture furniture = _furnitureController.GetFurnitureByID(lineItem.FurnitureID);
                //   checkedOutFurniture.Add(furniture);
                //}
            }
            return lineItems;
        }

    }
}
