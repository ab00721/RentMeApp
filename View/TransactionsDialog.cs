using RentMeApp.UserControls;
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
    public partial class TransactionsDialog : Form
    {
        private readonly SearchMemberUserControl _searchMemberUserControl;
        private readonly UserUserControl _userUserControl;

        public TransactionsDialog(SearchMemberUserControl searchMemberUserController, string username, string firstName)
        {
            InitializeComponent();
            _userUserControl = new UserUserControl(username, firstName);
            this.userTableLayoutPanel.Controls.Add(_userUserControl);
            this._searchMemberUserControl = searchMemberUserController;
        }
    }
}
