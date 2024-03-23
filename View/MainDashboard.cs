using RentMeApp.Controller;
using RentMeApp.Model;
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
        private readonly EmployeeLoginForm _loginForm;
        private readonly UserUserControl _userUserControl;
        private readonly EmployeeController _employeeController;
        private readonly EmployeeDTO _employee;
        private readonly AddRentalUserControl _addRentalUserControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainDashboard"/> class.
        /// </summary>
        /// <param name="loginForm">The login form.</param>
        /// <param name="user">The user.</param>
        public MainDashboard(EmployeeLoginForm loginForm, string user)
        {
            InitializeComponent();
            _employeeController = new EmployeeController();
            _employee = _employeeController.GetEmployeeByUsername(user);
            _loginForm = loginForm;
            ViewReports();

            _userUserControl = new UserUserControl(_employee.Username, _employee.FirstName);
            userTableLayoutPanel.Controls.Add(_userUserControl);

            mainSearchMemberUserControl.DisplayUserDetails(_employee.Username, _employee.FirstName);

            _addRentalUserControl = new AddRentalUserControl();
            mainTabControl.TabPages["rentalTabPage"].Controls.Add(_addRentalUserControl);
        }

        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab == mainTabControl.TabPages["membersTabPage"])
            {
                mainSearchMemberUserControl.SearchMemberUserControl_Load(sender, e);
            }
            if (mainTabControl.SelectedTab == mainTabControl.TabPages["rentalTabPage"])
            {
                addRentalUserControl.AddRentalUserControl_Load(sender, e);
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

        private void ViewReports()
        {
            if (_employee.IsAdmin == 0)
            {
                mainTabControl.TabPages.Remove(reportTabPage);
            }
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            _loginForm.Visible = true;
        }

        private void reportTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
