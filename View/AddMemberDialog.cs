using RentMeApp.Controller;
using RentMeApp.Model;
using RentMeApp.UserControls;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RentMeApp.Extension;

namespace RentMeApp.View
{
    /// <summary>
    /// Create a new member
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddMemberDialog : Form
    {
        private readonly MemberController _MemberController;
        private readonly SearchMemberUserControl _searchMemberUserControl;
        private Member member;
        private readonly UserUserControl _userUserControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddMemberDialog"/> class.
        /// </summary>
        public AddMemberDialog(SearchMemberUserControl searchMemberUserController, string username, string firstName)
        {
            InitializeComponent();
            this._MemberController = new MemberController();
            member = new Member();
            _userUserControl = new UserUserControl(username, firstName);
            this.userTableLayoutPanel.Controls.Add(_userUserControl);
            this._searchMemberUserControl = searchMemberUserController;
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            Boolean errorsExist = false;
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            DateTime dob = DobDatePicker.Value;
            string add1 = AddOneTextBox.Text;
            string add2 = AddTwoTextBox.Text;
            string city = CityTextBox.Text;
            string state = StateComboBox.SelectedItem.ToString();
            string zip = ZipTextBox.Text;
            string phone = PhoneTextBox.Text;

            if (string.IsNullOrEmpty(zip))
            {
                ZipErrorLabel.Text = "Zip cannot be null or empty.";
                errorsExist = true;
            }

            if (string.IsNullOrEmpty(firstName))
            {
                FirstNameErrorLabel.Text = "First Name cannot be null or empty.";
                errorsExist = true;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                LastNameErrorLabel.Text = "Last Name cannot be null or empty.";
                errorsExist = true;
            }

            if (SexComboBox.ValueMember.Length > 1)
            {
                SexErrorLabel.Text = "Select appropriate value for sex.";
                errorsExist = true;
            }

            if (string.IsNullOrEmpty(add1))
            {
                AddOneErrorLabel.Text = "Address Line 1 cannot be null or empty.";
                errorsExist = true;
            }

            if (string.IsNullOrEmpty(city))
            {
                CityErrorLabel.Text = "City cannot be null or empty.";
                errorsExist = true;
            }

            if (string.IsNullOrEmpty(state) || state == "-- Select --")
            {
                StateErrorLabel.Text = "State cannot be null or empty.";
                errorsExist = true;
            }

            if (!string.IsNullOrEmpty(phone) && !Regex.IsMatch(phone, @"^\d{3}-\d{3}-\d{4}$"))
            {
                PhoneErrorLabel.Text = "Invalid phone number format\n###-###-####";
                errorsExist = true;
            }

            if (!errorsExist)
            {
                member.FirstName = firstName;
                member.LastName = lastName;
                member.Sex = SexComboBox.Text;
                member.DateOfBirth = dob;
                member.AddressOne = add1;
                member.AddressTwo = add2;
                member.City = city;
                member.State = state;
                member.Zip = zip;
                member.Phone = phone;
                member.MemberID = _MemberController.InsertNewMember(member);
                this._searchMemberUserControl.RefreshListView();

                MessageBox.Show($"Member created successfully. Member ID: {member.MemberID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }

        private void AddMemberDialog_Load(object sender, EventArgs e)
        {
            SexComboBox.SelectedItem = string.IsNullOrEmpty(member.Sex) ? "-- Select --" : (object)member.Sex;

            StateComboBox.Items.Add("-- Select --");
            foreach (USState state in Enum.GetValues(typeof(USState)))
            {
                StateComboBox.Items.Add(state);
            }

            StateComboBox.SelectedItem = string.IsNullOrEmpty(member.State) ? "-- Select --" : Enum.Parse(typeof(USState), member.State);
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FirstNameErrorLabel.Text = "";
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            LastNameErrorLabel.Text = "";
        }

        private void SexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SexErrorLabel.Text = "";
        }

        private void AddOneTextBox_TextChanged(object sender, EventArgs e)
        {
            AddOneErrorLabel.Text = "";
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            CityErrorLabel.Text = "";
        }

        private void ZipTextBox_TextChanged(object sender, EventArgs e)
        {
            ZipErrorLabel.Text = "";
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            PhoneErrorLabel.Text = "";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void StateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StateErrorLabel.Text = "";
        }
    }
}
