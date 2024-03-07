using System;
using System.Windows.Forms;

namespace RentMeApp.View
{
    /// <summary>
    /// The logout form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LogoutForm : Form
    {
        private readonly EmployeeLoginForm _loginForm;
        private String _user;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogoutForm"/> class.
        /// </summary>
        /// <param name="loginForm">The login form.</param>
        /// <param name="user">The user.</param>
        public LogoutForm(EmployeeLoginForm loginForm, string user)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _user = user;
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            _loginForm.Visible = true;
        }
    }
}
