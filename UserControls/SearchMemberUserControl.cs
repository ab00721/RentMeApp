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
    public partial class SearchMemberUserControl : UserControl
    {
        private readonly MemberControllerX _memberControllerX;
        public SearchMemberUserControl()
        {
            InitializeComponent();
            ClearMessageLabel();
            _memberControllerX = new MemberControllerX();
        }

        private void SearchMemberUserControl_Load(object sender, EventArgs e)
        {
            this.RefreshDataGrid();
        }

        
        /// <summary>
        /// Refreshes the data grid.
        /// </summary>
        public void RefreshDataGrid()
        {
            this.memberDataGridView.DataSource = null;
            this.memberDataGridView.DataSource = this._memberControllerX.GetMemberInfoX();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void MemberSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearMessageLabel();
        }

        private void MemberSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearMessageLabel();
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearMessageLabel()
        {
            searchMessageLabel.Text = string.Empty;
        }

    }
}
