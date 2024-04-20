using System.Windows.Forms;
using RentMeApp.Model;

namespace RentMeApp.UserControls
{
    /// <summary>
    /// Member User Controller
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class MemberUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberUserControl"/> class.
        /// </summary>
        /// <param name="member">The member.</param>
        public MemberUserControl(Member member)
        {
            InitializeComponent();
            nameLabel.Text = "Member Name: " + member.FirstName + " " + member.LastName;
            idLabel.Text = "Member ID: " + member.MemberID;
            phoneLabel.Text = "Phone: " + member.Phone;
            addressLabel.Text = "Address: " + member.AddressOne + ", " + member.City + " " + member.State + " " + member.Zip;
        }
    }
}
