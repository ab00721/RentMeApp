using RentMeApp.Controller;
using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RentMeApp.UserControls
{
    public partial class SearchFurnitureUserControl : UserControl
    {
        private readonly FurnitureController _furnitureController;
        private readonly List<Furniture> _furniture;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMemberUserControl"/> class.
        /// </summary>
        public SearchFurnitureUserControl()
        {
            InitializeComponent();
            ClearMessageLabel();
            _furnitureController = new FurnitureController();
            _furniture = this._furnitureController.GetFurniture();
            PopulateSearchByComboBox();
            AddButtonColumn();
        }

        /// <summary>
        /// Handles the Load event of the SearchMemberUserControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void SearchFurnitureUserControl_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            List<Furniture> searchResults = _furnitureController.GetFurniture();
            RefreshDataGridView(searchResults);
        }
        private void RefreshDataGridView(List<Furniture> furniture)
        {
            furnitureDataGridView.DataSource = null;
            furnitureDataGridView.DataSource = furniture;
        }

        private void AddButtonColumn()
        {
            DataGridViewButtonColumn addButtonColumn = new DataGridViewButtonColumn();
            addButtonColumn.Name = "AddButtonColumn";
            addButtonColumn.HeaderText = "Add To Cart";
            addButtonColumn.Text = "Add";
            addButtonColumn.UseColumnTextForButtonValue = true;
            furnitureDataGridView.Columns.Add(addButtonColumn);
        }

        private void FurnitureDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == furnitureDataGridView.Columns["AddButtonColumn"].Index)
            {
                Furniture furniture = _furniture[e.RowIndex];
                searchMessageLabel.Text = "Added one " + furniture.Name + " to cart.";
                searchMessageLabel.ForeColor = Color.Red;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string search = furnitureSearchTextBox.Text;
            try
            {
                switch (furnitureSearchComboBox.SelectedIndex)
                {
                    case 0:
                        SearchByID(search);
                        break;
                    case 1:
                        SearchByCategory(search);
                        break;
                    case 2:
                        SearchByStyle(search);
                        break;
                }
            }
            catch (Exception ex)
            {
                searchMessageLabel.Text = ex.Message;
                searchMessageLabel.ForeColor = Color.Red;
            }

        }

        private void SearchByID(string furnitureID)
        {
            if (!int.TryParse(furnitureID, out int id))
            {
                throw new Exception("Invalid Furniture ID");
            }
            if (id < 1)
            {
                throw new Exception("Furniture ID must be greater than 0");
            }
            List<Furniture> furniture = _furniture.FindAll(e => e.FurnitureID == id);

            if (furniture.Count == 0)
            {
                throw new Exception("No furniture found with the specified ID");
            }
            RefreshDataGridView(furniture);
        }

        private void SearchByCategory(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                throw new Exception("Invalid category");
            }
            List<Furniture> furniture = _furniture.FindAll(e => e.Category.Contains(category));

            if (furniture.Count == 0)
            {
                throw new Exception("No furniture found with the specified category");
            }

            RefreshDataGridView(furniture);
        }

        private void SearchByStyle(string style)
        {
            if (string.IsNullOrEmpty(style))
            {
                throw new Exception("Invalid style");
            }
            List<Furniture> furniture = _furniture.FindAll(e => e.Style.Contains(style));

            if (furniture.Count == 0)
            {
                throw new Exception("No furniture found with the specified style");
            }

            RefreshDataGridView(furniture);
        }

        private void FurnitureSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearMessageLabel();
        }

        private void FurnitureSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAll();
            RefreshDataGridView();
        }

        private void PopulateSearchByComboBox()
        {
            furnitureSearchComboBox.Items.Clear();
            furnitureSearchComboBox.Items.Add("Furniture ID");
            furnitureSearchComboBox.Items.Add("Category");
            furnitureSearchComboBox.Items.Add("Style");
            furnitureSearchComboBox.SelectedIndex = 0;
        }

        private void ClearMessageLabel()
        {
            searchMessageLabel.Text = string.Empty;
        }

        private void ClearAll()
        {
            furnitureSearchTextBox.Text = string.Empty;
            searchMessageLabel.Text = string.Empty;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            RefreshDataGridView();
        }

        
    }
}
