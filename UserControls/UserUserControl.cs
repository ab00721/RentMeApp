using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMeApp.UserControls
{
    public partial class UserUserControl : UserControl
    {
        public UserUserControl(string user, string name)
        {
            InitializeComponent();
            nameLabel.Text = name; 
            userLabel.Text = user;
        }
    }
}
