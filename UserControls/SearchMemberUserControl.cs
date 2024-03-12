using RentMeApp.Controller;
using RentMeApp.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using RentMeApp.View;

namespace RentMeApp.UserControls
{
    /// <summary>
    /// Search Member User Control Class
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class SearchMemberUserControl : UserControl
    {
        private readonly MemberControllerX _memberControllerX;
        private readonly List<MemberX> _members;
        private MemberX _selectedMember;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMemberUserControl"/> class.
        /// </summary>
        public SearchMemberUserControl()
        {
            InitializeComponent();
            ClearMessageLabel();
            PopulateSearchByComboBox();
            _memberControllerX = new MemberControllerX();
            _members = this._memberControllerX.GetMemberInfoX();
        }

        /// <summary>
        /// Handles the Load event of the SearchMemberUserControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void SearchMemberUserControl_Load(object sender, EventArgs e)
        {
            ClearAll();
            this.RefreshListView(_members);
        }

        private void RefreshListView(List<MemberX> members)
        {
            memberListView.Items.Clear();

            if (members.Count > 0)
            {
                memberListView.Columns.Add("Member ID", 50);
                memberListView.Columns.Add("First Name", 100);
                memberListView.Columns.Add("Last Name", 100);
                memberListView.Columns.Add("Sex", 50);
                memberListView.Columns.Add("Date of Birth", 100);
                memberListView.Columns.Add("Address Line 1", 100);
                memberListView.Columns.Add("Address Line 2", 100);
                memberListView.Columns.Add("City", 100);
                memberListView.Columns.Add("State", 50);
                memberListView.Columns.Add("Zip", 100);
                memberListView.Columns.Add("Phone", 100);

                ListViewItem item;

                foreach (MemberX member in this._memberControllerX.GetMemberInfoX())
                {
                    item = new ListViewItem(member.MemberID.ToString());
                    item.SubItems.Add(member.FirstName);
                    item.SubItems.Add(member.LastName);
                    item.SubItems.Add(member.Sex.ToString());
                    item.SubItems.Add(member.DateOfBirth.ToString());
                    item.SubItems.Add(member.Address1);
                    item.SubItems.Add(member.Address2);
                    item.SubItems.Add(member.City);
                    item.SubItems.Add(member.State);
                    item.SubItems.Add(member.Zip.ToString());
                    item.SubItems.Add(member.Phone);



                    this.memberListView.Items.Add(item);
                }
            }
            else
            {
                searchMessageLabel.Text = "No members match search.";
                searchMessageLabel.ForeColor = Color.Red;
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
            List<MemberX> members = _members.FindAll(e => e.MemberID == id);

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
            List<MemberX> members = _members.FindAll(e => (e.FirstName + " " + e.LastName).Contains(name));

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

            List<MemberX> members = _members.FindAll(e => e.Phone == phone);

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
            ClearMessageLabel();
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
            memberSearchComboBox.SelectedIndex = 0;
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
            using (Form addMember = new View.AddMemberDialog())
            {
                DialogResult result = addMember.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.RefreshListView(_members);
                }
                else if (result == DialogResult.Cancel)
                {
                    addMember.Close();
                }
            }
        }


        private void EditMemberButton_Click(object sender, EventArgs e)
        {
            EditMember(_selectedMember);
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

        private void EditMember(MemberX member)
        {
            searchMessageLabel.Text = "Edit " + member.FirstName;
            searchMessageLabel.ForeColor = Color.Red;
        }

        private void NewOrder(MemberX member)
        {
            searchMessageLabel.Text = "New Order " + member.FirstName;
            searchMessageLabel.ForeColor = Color.Red;
        }

        private void NewReturn(MemberX member)
        {
            searchMessageLabel.Text = "New Return " + member.FirstName;
            searchMessageLabel.ForeColor = Color.Red;
        }

        private void ViewTransactions(MemberX member)
        {
            searchMessageLabel.Text = "View Transactions " + member.FirstName;
            searchMessageLabel.ForeColor = Color.Red;
        }

        private void MemberListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberListView.SelectedItems.Count > 0)
            {
                EnableButtons();
                _selectedMember = (MemberX)memberListView.SelectedItems[0].Tag;
            }
            else
            {
                DisableButtons();
                _selectedMember = null;
            } 
        }
    }
}
