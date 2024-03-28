using RentMeApp.Controller;
using RentMeApp.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RentMeApp.UserControls
{
    /// <summary>
    /// Search Member User Control Class
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class SearchMemberUserControl : UserControl
    {
        //private readonly MemberControllerX _memberControllerX;
        private readonly MemberController _memberController;
        private Member _selectedMember;
        private string _username;
        private string _firstName;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMemberUserControl"/> class.
        /// </summary>
        public SearchMemberUserControl()
        {
            InitializeComponent();
            ClearMessageLabel();
            _memberController = new MemberController();
            PopulateSearchByComboBox();
        }

        /// <summary>
        /// Handles the Load event of the SearchMemberUserControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void SearchMemberUserControl_Load(object sender, EventArgs e)
        {
            ClearAll();
            this.RefreshListView();
        }

        /// <summary>
        /// Refreshes the ListView.
        /// </summary>
        public void RefreshListView()
        {
            this.RefreshListView(this._memberController.GetMemberInfo());
        }
        private void RefreshListView(List<Member> members)
        {
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
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DisableButtons();
            string search = memberSearchTextBox.Text;
            try
            {
                switch (memberSearchComboBox.SelectedIndex)
                {
                    case 0:
                        SearchByID(search);
                        break;
                    case 1:
                        SearchByName(search);
                        break;
                    case 2:
                        SearchByPhone(search);
                        break;
                }
            }
            catch (Exception ex)
            {
                searchMessageLabel.Text = ex.Message;
                searchMessageLabel.ForeColor = Color.Red;
            }

        }

        private void SearchByID(string memberID)
        {
            if (!int.TryParse(memberID, out int id))
            {
                throw new Exception("Invalid Member ID");
            }
            if (id < 1)
            {
                throw new Exception("Member ID must be greater than 0");
            }
            List<Member> members = this._memberController.GetMemberInfo("searchID", memberID);

            if (members.Count == 0)
            {
                throw new Exception("No members found with the specified ID");
            }
            RefreshListView(members);
        }

        private void SearchByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Invalid name");
            }
            List<Member> members = this._memberController.GetMemberInfo("searchName", name);

            if (members.Count == 0)
            {
                throw new Exception("No members found with the specified name");
            }

            RefreshListView(members);
        }

        private void SearchByPhone(string phone)
        {
            if (!Regex.IsMatch(phone, @"^\d{3}-\d{3}-\d{4}$"))
            {
                throw new Exception("Invalid phone number format\n###-###-####");
            }

            List<Member> members = this._memberController.GetMemberInfo("searchPhone", phone);

            if (members.Count == 0)
            {
                throw new Exception("No members found with the specified phone number");
            }

            RefreshListView(members);

        }

        private void MemberSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearMessageLabel();
        }

        private void MemberSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAll();
            RefreshListView();
        }

        private void PopulateSearchByComboBox()
        {
            memberSearchComboBox.Items.Clear();
            memberSearchComboBox.Items.Add("Member ID");
            memberSearchComboBox.Items.Add("First and Last Name");
            memberSearchComboBox.Items.Add("Phone");
            memberSearchComboBox.SelectedIndex = 0;
        }

        private void ClearMessageLabel()
        {
            searchMessageLabel.Text = string.Empty;
        }

        private void ClearAll()
        {
            memberSearchTextBox.Text = string.Empty;
            searchMessageLabel.Text = string.Empty;
            DisableButtons();
        }

        private void DisableButtons()
        {
            editMemberButton.Enabled = false;
            newOrderButton.Enabled = false;
            newReturnButton.Enabled = false;
            viewTransactionsButton.Enabled = false;
        }

        private void EnableButtons()
        {
            editMemberButton.Enabled = true;
            newOrderButton.Enabled = true;
            newReturnButton.Enabled = true;
            viewTransactionsButton.Enabled = true;
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            this.ClearMessageLabel();
            using (Form addMember = new View.AddMemberDialog(this, this._username, this._firstName))
            {
                DialogResult result = addMember.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.RefreshListView();
                }
                else if (result == DialogResult.Cancel)
                {
                    addMember.Close();
                }
            }
        }

        private void EditMemberButton_Click(object sender, EventArgs e)
        {
            this.ClearMessageLabel();
            if (memberListView.SelectedItems.Count > 0)
            {
                Member selectedMember = (Member)memberListView.SelectedItems[0].Tag;

                using (Form editMember = new View.EditMemberDialog(this._username, this._firstName, selectedMember))
                {
                    DialogResult result = editMember.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        this.RefreshListView();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        editMember.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("No member has been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            NewOrder(_selectedMember);
        }

        private void NewReturnButton_Click(object sender, EventArgs e)
        {
            NewReturn(_selectedMember);
        }

        private void ViewTransactionsButton_Click(object sender, EventArgs e)
        {
            ViewTransactions(_selectedMember);
        }

        private void NewOrder(Member member)
        {
            this.ClearMessageLabel();

            Member selectedMember = (Member)memberListView.SelectedItems[0].Tag;

            using (Form newOrder = new View.RentalDialog(this._username, this._firstName, selectedMember))
            {
                DialogResult result = newOrder.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.RefreshListView();
                }
                else if (result == DialogResult.Cancel)
                {
                    newOrder.Close();
                }
            }
        }

        private void NewReturn(Member member)
        {
            searchMessageLabel.Text = "New Return " + member.FirstName;
            searchMessageLabel.ForeColor = Color.Red;
        }

        private void ViewTransactions(Member member)
        {
            searchMessageLabel.Text = "View Transactions " + member.FirstName;
            searchMessageLabel.ForeColor = Color.Red;
        }

        private void MemberListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberListView.SelectedItems.Count > 0)
            {
                EnableButtons();
                _selectedMember = (Member)memberListView.SelectedItems[0].Tag;
            }
            else
            {
                DisableButtons();
                _selectedMember = null;
            } 
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            RefreshListView();
        }

        internal void DisplayUserDetails(string username, string firstName)
        {
            this._username = username;
            this._firstName = firstName;
        }
    }
}
