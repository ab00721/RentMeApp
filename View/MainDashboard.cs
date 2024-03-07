using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private readonly LogoutForm _logoutForm;
        public MainDashboard(EmployeeLoginForm loginForm, string user) 
        {
            InitializeComponent();
            _loginForm = loginForm;
            _logoutForm = new LogoutForm(loginForm, user);
        }

        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab == mainTabControl.TabPages["membersTabPage"])
            {

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
