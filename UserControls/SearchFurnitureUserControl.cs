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
        public List<Furniture> _furniture;
        DataGridViewButtonColumn _addButtonColumn;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMemberUserControl"/> class.
        /// </summary>
        public SearchFurnitureUserControl()
        {
            InitializeComponent();
            ClearMessageLabel();
            _furnitureController = new FurnitureController();
            _furniture = this._furnitureController.GetFurniture();
            _addButtonColumn = new DataGridViewButtonColumn();
            PopulateSearchByComboBox();
            AddButtonColumn();
            TurnOffAddButtonColumn();
        }

        /// <summary>
        /// Handles the Load event of the SearchMemberUserControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void SearchFurnitureUserControl_Load(object sender, EventArgs e)
        {
            TurnOffAddButtonColumn();
            RefreshDataGridView();
        }

        /// <summary>
        /// Refreshes the data grid view.
        /// </summary>
        public void RefreshDataGridView()
        {
            RefreshDataGridView(this._furnitureController.GetFurniture());
        }
        private void RefreshDataGridView(List<Furniture> furniture)
        {
            _furniture = furniture;
            furnitureDataGridView.DataSource = null;
            furnitureDataGridView.DataSource = _furniture;
            furnitureDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AddButtonColumn()
        {
            _addButtonColumn = new DataGridViewButtonColumn();
            _addButtonColumn.Name = "AddButtonColumn";
            _addButtonColumn.HeaderText = "Add To Cart";
            _addButtonColumn.Text = "Add";
            _addButtonColumn.UseColumnTextForButtonValue = true;
            furnitureDataGridView.Columns.Add(_addButtonColumn);
        }

        private void TurnOffAddButtonColumn()
        {
            _addButtonColumn.Visible = false;
        }

        /// <summary>
        /// Turns the on add button column.
        /// </summary>
        public void TurnOnAddButtonColumn()
        {
            _addButtonColumn.Visible = true;
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
            List<Furniture> furniture = this._furnitureController.GetFurniture("searchID", furnitureID);

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
            List<Furniture> furniture = this._furnitureController.GetFurniture("searchCategory", category);

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
            List<Furniture> furniture = this._furnitureController.GetFurniture("searchStyle", style);

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
