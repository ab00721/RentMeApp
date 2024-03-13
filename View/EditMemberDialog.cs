﻿using RentMeApp.Controller;
using RentMeApp.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentMeApp.View
{
    public partial class EditMemberDialog : Form
    {
        private readonly MemberControllerX _MemberControllerX;
        private MemberX member;
        public EditMemberDialog()
        {
            InitializeComponent();
            this._MemberControllerX = new MemberControllerX();
            member = new MemberX();
        }

        private void EditMemberBtn_Click(object sender, EventArgs e)
        {
            int memberId = 5;
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            //DateTime dob = DateOnly.FromDateTime(DobDatePicker);
            string add1 = AddOneTextBox.Text;
            string add2 = AddTwoTextBox.Text;
            string city = CityTextBox.Text;
            string state = StateComboBox.SelectedItem.ToString();
            //int zip = ZipTextBox.Text;
            string phone = this.PhoneTextBox.Text;

            Boolean errorsExist = true;

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

            if (this.SexComboBox.SelectedItem == "-- Select --")
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

            if (string.IsNullOrEmpty(state))
            {
                StateErrorLabel.Text = "State cannot be null or empty.";
                errorsExist = true;
            }

            if (string.IsNullOrEmpty(phone))
            {
                PhoneErrorLabel.Text = "Phone cannot be null or empty.";
                errorsExist = true;
            }

            if (string.IsNullOrEmpty(phone))
            {
                PhoneErrorLabel.Text = "Phone cannot be null or empty.";
                errorsExist = true;
            }

            if (!Regex.IsMatch(phone, @"^\d{3}-\d{3}-\d{4}$"))
            {
                PhoneErrorLabel.Text = "Invalid phone number format\n###-###-####";
                errorsExist = true;
            }

            if (!errorsExist)
            {
                member.MemberID = memberId;
                member.FirstName = firstName;
                member.LastName = lastName;
                member.Sex = Convert.ToChar(SexComboBox.Text);
                //member.DateOfBirth = dob;
                member.Address1 = add1;
                member.Address2 = add2;
                member.City = city;
                member.State = state;
                //member.Zip = zip;
                member.Phone = phone;
                this._MemberControllerX.Register(member);

                MessageBox.Show("Member added successfully");
                DialogResult = DialogResult.OK;
            }
        }

        private void EditMemberDialog_Load(object sender, EventArgs e)
        {
            this.SexComboBox.SelectedItem = "-- Select --";
            this.StateComboBox.SelectedItem = "AL";
        }
    }
}
