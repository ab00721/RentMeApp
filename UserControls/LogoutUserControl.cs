using RentMeApp.View;
using System.Windows.Forms;

namespace RentMeApp.UserControls
{
    /// <summary>
    /// Logout User Control
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class LogoutUserControl : UserControl
    {
        private readonly EmployeeLoginForm _loginForm;
        private readonly MainDashboard _mainDashboard;
       
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoutForm"/> class.
        /// </summary>
        /// <param name="loginForm">The login form.</param>
        /// <param name="user">The user.</param>
        public LogoutUserControl(EmployeeLoginForm loginForm, string user, MainDashboard mainDashboard)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _mainDashboard = mainDashboard;
            userLabel.Text = user;
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _mainDashboard.Visible = false;
            _loginForm.Visible = true;
        }
    }
}
