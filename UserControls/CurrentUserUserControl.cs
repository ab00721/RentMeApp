using RentMeApp.Controller;
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
    public partial class CurrentUserUserControl : UserControl
    {
        public CurrentUserUserControl()
        {
        }

        public CurrentUserUserControl(string user)
        {
            InitializeComponent();
            this.NameLabel.Text = user;
            this.UsernameLabel.Text = user;
        }
    }
}
