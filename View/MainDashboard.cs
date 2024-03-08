using RentMeApp.UserControls;
using System;
using System.Windows.Forms;

namespace RentMeApp.View
{
    /// <summary>
    /// The Main Dashboard with Tab Control
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainDashboard : Form
    {
        private readonly LogoutUserControl _logoutUserControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainDashboard"/> class.
        /// </summary>
        /// <param name="loginForm">The login form.</param>
        /// <param name="user">The user.</param>
        public MainDashboard(EmployeeLoginForm loginForm, string user)
        {
            InitializeComponent();
            _logoutUserControl = new LogoutUserControl(loginForm, user, this)
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Dock = DockStyle.Top
            };
            this.Controls.Add(_logoutUserControl);
        }

        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab == mainTabControl.TabPages["membersTabPage"])
            {
                this.mainSearchMemberUserControl.SearchMemberUserControl_Load(sender, e);
            }
            if (mainTabControl.SelectedTab == mainTabControl.TabPages["rentalTabPage"])
            {

            }
            if (mainTabControl.SelectedTab == mainTabControl.TabPages["returnTabPage"])
            {

            }
            if (mainTabControl.SelectedTab == mainTabControl.TabPages["transactionTabPage"])
            {

            }
            if (mainTabControl.SelectedTab == mainTabControl.TabPages["reportTabPage"])
            {

            }
        }
    }
}
