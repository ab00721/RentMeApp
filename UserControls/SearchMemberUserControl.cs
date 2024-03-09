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
        private readonly MemberControllerX _memberControllerX;
        private readonly List<MemberX> _members;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMemberUserControl"/> class.
        /// </summary>
        public SearchMemberUserControl()
        {
            InitializeComponent();
            ClearMessageLabel();
            PopulateSearchByComboBox();
            ConfigureActionColumns();
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
            this.RefreshDataGrid(_members);
        }

        private void RefreshDataGrid(List<MemberX> members)
        {
            this.memberDataGridView.DataSource = null;
            this.memberDataGridView.DataSource = members;
        }

        private void ConfigureActionColumns() { 

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn()
            {
                Name = "EditColumn",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
            };

            DataGridViewButtonColumn newOrder = new DataGridViewButtonColumn()
            {
                Name = "NewOrderColumn",
                HeaderText = "New Order",
                Text = "New Order",
                UseColumnTextForButtonValue = true,
            };

            DataGridViewButtonColumn newReturn = new DataGridViewButtonColumn()
            {
                Name = "NewReturnColumn",
                HeaderText = "New Return",
                Text = "New Return",
                UseColumnTextForButtonValue = true,
            };

            memberDataGridView.Columns.Add(edit);
            memberDataGridView.Columns.Add(newOrder);
            memberDataGridView.Columns.Add(newReturn);

            //edit.DisplayIndex = memberDataGridView.Columns.Count - 3;
            //newOrder.DisplayIndex = memberDataGridView.Columns.Count - 2;
            //newReturn.DisplayIndex = memberDataGridView.Columns.Count - 1;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
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
            RefreshDataGrid(members);
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

            RefreshDataGrid(members);
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

            RefreshDataGrid(members);

        }


        private void MemberSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearMessageLabel();
        }

        private void MemberSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearMessageLabel();
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {

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
        }

        private void MemberDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = memberDataGridView.Columns[e.ColumnIndex].Name;
                MemberX selectedMember = (MemberX)memberDataGridView.Rows[e.RowIndex].DataBoundItem;
                switch (columnName)
                {
                    case "EditColumn":
                        EditMember(selectedMember);
                        break;

                    case "NewOrderColumn":
                        NewOrder(selectedMember); 
                        break;

                    case "NewReturnColumn":
                        NewReturn(selectedMember);
                        break;
                }
            }
        }

        private void EditMember(MemberX selectedMember)
        {
            searchMessageLabel.Text = "edit " + selectedMember.FirstName;
        }

        private void NewOrder(MemberX selectedMember)
        {
            searchMessageLabel.Text = "new order " + selectedMember.FirstName;
        }

        private void NewReturn(MemberX selectedMember)
        {
            searchMessageLabel.Text = "new return " + selectedMember.FirstName;
        }
    }
}
