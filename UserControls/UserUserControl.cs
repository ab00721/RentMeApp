using System.Windows.Forms;

namespace RentMeApp.UserControls
{
    /// <summary>
    /// Current User user control
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class UserUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUserControl"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="name">The name.</param>
        public UserUserControl(string user, string name)
        {
            InitializeComponent();
            nameLabel.Text = "User: " + name; 
            userLabel.Text = "Username: " + user;
        }
    }
}
