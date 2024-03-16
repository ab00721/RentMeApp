using System;
using System.Data.SqlClient;
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
        private readonly AuthenticateController _authenticateController;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeLoginForm"/> class.
        /// </summary>
        public EmployeeLoginForm()
        {
            InitializeComponent();
            ClearMessageLabel();
            _authenticateController = new AuthenticateController();
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
            try 
            {
                string username = usernameTextBox.Text.Trim();
                string password = passwordTextBox.Text;

                if (_authenticateController.Authenticate(username, password)) {
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
            catch (SqlException exception) {
                MessageBox.Show(exception.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
