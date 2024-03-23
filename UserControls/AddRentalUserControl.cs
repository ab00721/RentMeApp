using RentMeApp.Controller;
using RentMeApp.Model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using RentMeApp.Extension;

namespace RentMeApp.UserControls
{
    /// <summary>
    /// Search Member User Control Class
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class AddRentalUserControl : UserControl
    {
        private readonly MemberController _memberController;
        private List<Member> _members;
        private Member _selectedMember;
        private string _username;
        private string _firstName;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRentalUserControl"/> class.
        /// </summary>
        public AddRentalUserControl()
        {
            InitializeComponent();
            ClearMessageLabel();
            PopulateSearchByComboBox();
            _memberController = new MemberController();
            _members = this._memberController.GetMemberInfo();

            Resize += AddRentalUserControl_Resize;
        }

        /// <summary>
        /// Handles the Load event of the AddRentalUserControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void AddRentalUserControl_Load(object sender, EventArgs e)
        {
            furnitureListView = ListViewColumnWidthService.Distribute(furnitureListView);
            shoppingCartListView = ListViewColumnWidthService.Distribute(shoppingCartListView);

            /*
            ClearAll();
            this.RefreshListView();
            */
        }

        private void AddRentalUserControl_Resize(object sender, EventArgs e)
        {
            furnitureListView = ListViewColumnWidthService.Distribute(furnitureListView);
            shoppingCartListView = ListViewColumnWidthService.Distribute(shoppingCartListView);
        }

        public void RefreshListView()
        {
            /*
            this._members = this._memberController.GetMemberInfo();
            this.RefreshListView(this._members);
            */
        }

        private void RefreshListView(List<Member> members)
        {
            /*
            memberListView.Items.Clear();
            _selectedMember = null;

            if (members.Count > 0)
            {
                Member member;
                for (int i = 0; i < members.Count; i++)
                {
                    member = members[i];
                    memberListView.Items.Add(member.MemberID.ToString());
                    memberListView.Items[i].SubItems.Add(member.FirstName.ToString());
                    memberListView.Items[i].SubItems.Add(member.LastName.ToString());
                    memberListView.Items[i].SubItems.Add(member.Sex.ToString());
                    memberListView.Items[i].SubItems.Add(member.DateOfBirth.ToShortDateString());
                    memberListView.Items[i].SubItems.Add(member.AddressOne.ToString());
                    memberListView.Items[i].SubItems.Add(member.AddressTwo.ToString());
                    memberListView.Items[i].SubItems.Add(member.City.ToString());
                    memberListView.Items[i].SubItems.Add(member.State.ToString());
                    memberListView.Items[i].SubItems.Add(member.Zip.ToString());
                    memberListView.Items[i].SubItems.Add(member.Phone.ToString());

                    memberListView.Items[i].Tag = member;
                }
            }
            */
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {

        }

        private void MemberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearMessageLabel();
        }

        private void PopulateSearchByComboBox()
        {
            furnitureSearchComboBox.Items.Clear();
            furnitureSearchComboBox.Items.Add("Furniture ID");
            furnitureSearchComboBox.Items.Add("Category");
            furnitureSearchComboBox.Items.Add("Style");
            furnitureSearchComboBox.SelectedIndex = 0;
        }

        private void ClearMessageLabel()
        {
            searchMessageLabel.Text = string.Empty;
        }

        private void ClearAll()
        {
            DisableButtons();
        }

        private void DisableButtons()
        {

        }

        private void EnableButtons()
        {

        }

        private void DisplayUserDetails(string username, string firstName)
        {
            this._username = username;
            this._firstName = firstName;
        }
    }
}
