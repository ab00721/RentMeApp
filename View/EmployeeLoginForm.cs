﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMeApp
{
    /// <summary>
    /// The employee login form dialog
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EmployeeLoginForm : Form
    {
        //private MainDashboardWithUserControl _mainDashboard;
        //private AuthenticateController _authenticateController;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeLoginForm"/> class.
        /// </summary>

        public EmployeeLoginForm()
        {
            InitializeComponent();
            ClearMessageLabel();
            //_authenticateController = new AuthenticateController();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearMessageLabel();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearMessageLabel();
        }

        private void ClearMessageLabel()
        {
            loginMessageLabel.Text = string.Empty;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            //bool isAuthenticated = _authenticateController.Authenticate(username, password);
            //if (isAuthenticated)

            if (username == "jane" && password == "test1234")
            {
                loginMessageLabel.Text = "login successful";
                loginMessageLabel.ForeColor = Color.Red;

                //this.Visible = false;
                //this._mainDashboard.ShowDialog();
                //mainForm.ShowDialog();
            }
            else
            {
                loginMessageLabel.Text = "Invalid username/password";
                loginMessageLabel.ForeColor = Color.Red;
            }
        }
    }
}
