using System;
using System.Drawing;
using System.Windows.Forms;
using RentMeApp.Controller;
using RentMeApp.View;

namespace RentMeApp
{
    /// <summary>
    /// The employee login form dialog
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EmployeeLoginForm : Form
    {
        private MainDashboard _mainDashboard;
        //private AuthenticateController _authenticateController;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeLoginForm"/> class.
        /// </summary>
        public EmployeeLoginForm()
        {
            InitializeComponent();
            _mainDashboard = new MainDashboard(this, usernameTextBox.Text);
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
                using (_mainDashboard = new MainDashboard(this, username))
                {
                    this.Visible = false;
                    this._mainDashboard.ShowDialog();
                }
            }
            else
            {
                loginMessageLabel.Text = "Invalid username/password";
                loginMessageLabel.ForeColor = Color.Red;
            }
        }

        private void EmployeeLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
