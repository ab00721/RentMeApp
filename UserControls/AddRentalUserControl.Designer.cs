namespace RentMeApp.UserControls
{
    partial class AddRentalUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.furnitureListView = new System.Windows.Forms.ListView();
            this.furnitureColumnFurnitureID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.furnitureColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.furnitureColumnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.furnitureColumnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.furnitureColumnStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.furnitureColumnDailyRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.furnitureColumnAvailQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.furnitureColumnAddBtn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rentalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.furnitureSearchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.furnitureSearchComboBox = new System.Windows.Forms.ComboBox();
            this.searchMessageLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.furnitureSearchTexBox = new System.Windows.Forms.TextBox();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.memberLabel = new System.Windows.Forms.Label();
            this.memberComboBox = new System.Windows.Forms.ComboBox();
            this.furnitureSubheadingTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.furnitureLabel = new System.Windows.Forms.Label();
            this.shoppingCartSubheadingLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.shoppingCartListView = new System.Windows.Forms.ListView();
            this.shoppingCartColumnFurnitureID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shoppingCartColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shoppingCartColumnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shoppingCartColumnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shoppingCartColumnStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shoppingCartColumnDailyRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shoppingCartColumnTotalRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shoppingCartColumnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shoppingCartColumnRemoveBtn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returnTotalsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.rentalTableLayoutPanel.SuspendLayout();
            this.furnitureSearchTableLayoutPanel.SuspendLayout();
            this.furnitureSubheadingTableLayoutPanel.SuspendLayout();
            this.shoppingCartSubheadingLayoutPanel.SuspendLayout();
            this.returnTotalsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // furnitureListView
            // 
            this.furnitureListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.furnitureColumnFurnitureID,
            this.furnitureColumnName,
            this.furnitureColumnDescription,
            this.furnitureColumnCategory,
            this.furnitureColumnStyle,
            this.furnitureColumnDailyRate,
            this.furnitureColumnAvailQuantity,
            this.furnitureColumnAddBtn});
            this.furnitureListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureListView.FullRowSelect = true;
            this.furnitureListView.HideSelection = false;
            this.furnitureListView.Location = new System.Drawing.Point(14, 267);
            this.furnitureListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.furnitureListView.Name = "furnitureListView";
            this.furnitureListView.Size = new System.Drawing.Size(846, 230);
            this.furnitureListView.TabIndex = 7;
            this.furnitureListView.UseCompatibleStateImageBehavior = false;
            this.furnitureListView.View = System.Windows.Forms.View.Details;
            // 
            // furnitureColumnFurnitureID
            // 
            this.furnitureColumnFurnitureID.Text = "Furniture ID";
            this.furnitureColumnFurnitureID.Width = 100;
            // 
            // furnitureColumnName
            // 
            this.furnitureColumnName.Text = "Name";
            this.furnitureColumnName.Width = 100;
            // 
            // furnitureColumnDescription
            // 
            this.furnitureColumnDescription.Text = "Description";
            this.furnitureColumnDescription.Width = 100;
            // 
            // furnitureColumnCategory
            // 
            this.furnitureColumnCategory.Text = "Category";
            this.furnitureColumnCategory.Width = 100;
            // 
            // furnitureColumnStyle
            // 
            this.furnitureColumnStyle.Text = "Style";
            this.furnitureColumnStyle.Width = 100;
            // 
            // furnitureColumnDailyRate
            // 
            this.furnitureColumnDailyRate.Text = "Daily Rate";
            this.furnitureColumnDailyRate.Width = 100;
            // 
            // furnitureColumnAvailQuantity
            // 
            this.furnitureColumnAvailQuantity.Text = "Avail. Quantity";
            this.furnitureColumnAvailQuantity.Width = 100;
            // 
            // furnitureColumnAddBtn
            // 
            this.furnitureColumnAddBtn.Text = "";
            this.furnitureColumnAddBtn.Width = 200;
            // 
            // rentalTableLayoutPanel
            // 
            this.rentalTableLayoutPanel.AutoScroll = true;
            this.rentalTableLayoutPanel.ColumnCount = 1;
            this.rentalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rentalTableLayoutPanel.Controls.Add(this.furnitureListView, 0, 1);
            this.rentalTableLayoutPanel.Controls.Add(this.furnitureSearchTableLayoutPanel, 0, 0);
            this.rentalTableLayoutPanel.Controls.Add(this.furnitureSubheadingTableLayoutPanel, 0, 1);
            this.rentalTableLayoutPanel.Controls.Add(this.shoppingCartSubheadingLayoutPanel, 0, 3);
            this.rentalTableLayoutPanel.Controls.Add(this.shoppingCartListView, 0, 4);
            this.rentalTableLayoutPanel.Controls.Add(this.returnTotalsTableLayoutPanel, 0, 5);
            this.rentalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.rentalTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rentalTableLayoutPanel.Name = "rentalTableLayoutPanel";
            this.rentalTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.rentalTableLayoutPanel.RowCount = 7;
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rentalTableLayoutPanel.Size = new System.Drawing.Size(900, 900);
            this.rentalTableLayoutPanel.TabIndex = 2;
            // 
            // furnitureSearchTableLayoutPanel
            // 
            this.furnitureSearchTableLayoutPanel.AutoSize = true;
            this.furnitureSearchTableLayoutPanel.ColumnCount = 5;
            this.furnitureSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.furnitureSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.furnitureSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.furnitureSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.furnitureSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.searchButton, 4, 1);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.furnitureSearchComboBox, 1, 1);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.searchMessageLabel, 3, 2);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.searchLabel, 2, 1);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.furnitureSearchTexBox, 3, 1);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.searchByLabel, 0, 1);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.memberLabel, 0, 0);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.memberComboBox, 1, 0);
            this.furnitureSearchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureSearchTableLayoutPanel.Location = new System.Drawing.Point(14, 17);
            this.furnitureSearchTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.furnitureSearchTableLayoutPanel.Name = "furnitureSearchTableLayoutPanel";
            this.furnitureSearchTableLayoutPanel.RowCount = 3;
            this.furnitureSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.furnitureSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.furnitureSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.furnitureSearchTableLayoutPanel.Size = new System.Drawing.Size(846, 180);
            this.furnitureSearchTableLayoutPanel.TabIndex = 11;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(721, 66);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 48);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // furnitureSearchComboBox
            // 
            this.furnitureSearchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.furnitureSearchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureSearchComboBox.FormattingEnabled = true;
            this.furnitureSearchComboBox.Location = new System.Drawing.Point(147, 73);
            this.furnitureSearchComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.furnitureSearchComboBox.Name = "furnitureSearchComboBox";
            this.furnitureSearchComboBox.Size = new System.Drawing.Size(220, 33);
            this.furnitureSearchComboBox.TabIndex = 8;
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchMessageLabel.AutoSize = true;
            this.searchMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMessageLabel.Location = new System.Drawing.Point(493, 137);
            this.searchMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(220, 25);
            this.searchMessageLabel.TabIndex = 5;
            this.searchMessageLabel.Text = "message";
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(392, 77);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(93, 25);
            this.searchLabel.TabIndex = 7;
            this.searchLabel.Text = "Search:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // furnitureSearchTexBox
            // 
            this.furnitureSearchTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.furnitureSearchTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureSearchTexBox.Location = new System.Drawing.Point(493, 74);
            this.furnitureSearchTexBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.furnitureSearchTexBox.Name = "furnitureSearchTexBox";
            this.furnitureSearchTexBox.Size = new System.Drawing.Size(220, 31);
            this.furnitureSearchTexBox.TabIndex = 9;
            // 
            // searchByLabel
            // 
            this.searchByLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchByLabel.Location = new System.Drawing.Point(12, 77);
            this.searchByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(127, 25);
            this.searchByLabel.TabIndex = 6;
            this.searchByLabel.Text = "Search By:";
            // 
            // memberLabel
            // 
            this.memberLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.memberLabel.AutoSize = true;
            this.memberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.memberLabel.Location = new System.Drawing.Point(36, 17);
            this.memberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(103, 25);
            this.memberLabel.TabIndex = 12;
            this.memberLabel.Text = "Member:";
            // 
            // memberComboBox
            // 
            this.memberComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.memberComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberComboBox.FormattingEnabled = true;
            this.memberComboBox.Location = new System.Drawing.Point(147, 13);
            this.memberComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.memberComboBox.Name = "memberComboBox";
            this.memberComboBox.Size = new System.Drawing.Size(220, 33);
            this.memberComboBox.TabIndex = 13;
            // 
            // furnitureSubheadingTableLayoutPanel
            // 
            this.furnitureSubheadingTableLayoutPanel.AutoSize = true;
            this.furnitureSubheadingTableLayoutPanel.ColumnCount = 1;
            this.furnitureSubheadingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.furnitureSubheadingTableLayoutPanel.Controls.Add(this.furnitureLabel, 0, 0);
            this.furnitureSubheadingTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureSubheadingTableLayoutPanel.Location = new System.Drawing.Point(13, 205);
            this.furnitureSubheadingTableLayoutPanel.Name = "furnitureSubheadingTableLayoutPanel";
            this.furnitureSubheadingTableLayoutPanel.RowCount = 1;
            this.furnitureSubheadingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.furnitureSubheadingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.furnitureSubheadingTableLayoutPanel.Size = new System.Drawing.Size(848, 54);
            this.furnitureSubheadingTableLayoutPanel.TabIndex = 12;
            // 
            // furnitureLabel
            // 
            this.furnitureLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.furnitureLabel.AutoSize = true;
            this.furnitureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureLabel.Location = new System.Drawing.Point(4, 14);
            this.furnitureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.furnitureLabel.Name = "furnitureLabel";
            this.furnitureLabel.Size = new System.Drawing.Size(114, 25);
            this.furnitureLabel.TabIndex = 13;
            this.furnitureLabel.Text = "Furniture:";
            // 
            // shoppingCartSubheadingLayoutPanel
            // 
            this.shoppingCartSubheadingLayoutPanel.ColumnCount = 1;
            this.shoppingCartSubheadingLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.shoppingCartSubheadingLayoutPanel.Controls.Add(this.shoppingCartLabel, 0, 0);
            this.shoppingCartSubheadingLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shoppingCartSubheadingLayoutPanel.Location = new System.Drawing.Point(13, 505);
            this.shoppingCartSubheadingLayoutPanel.Name = "shoppingCartSubheadingLayoutPanel";
            this.shoppingCartSubheadingLayoutPanel.RowCount = 1;
            this.shoppingCartSubheadingLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.shoppingCartSubheadingLayoutPanel.Size = new System.Drawing.Size(848, 54);
            this.shoppingCartSubheadingLayoutPanel.TabIndex = 13;
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartLabel.Location = new System.Drawing.Point(4, 17);
            this.shoppingCartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(169, 25);
            this.shoppingCartLabel.TabIndex = 14;
            this.shoppingCartLabel.Text = "Shopping Cart:";
            // 
            // shoppingCartListView
            // 
            this.shoppingCartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.shoppingCartColumnFurnitureID,
            this.shoppingCartColumnName,
            this.shoppingCartColumnDescription,
            this.shoppingCartColumnCategory,
            this.shoppingCartColumnStyle,
            this.shoppingCartColumnDailyRate,
            this.shoppingCartColumnTotalRate,
            this.shoppingCartColumnQuantity,
            this.shoppingCartColumnRemoveBtn});
            this.shoppingCartListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shoppingCartListView.FullRowSelect = true;
            this.shoppingCartListView.HideSelection = false;
            this.shoppingCartListView.Location = new System.Drawing.Point(14, 567);
            this.shoppingCartListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shoppingCartListView.Name = "shoppingCartListView";
            this.shoppingCartListView.Size = new System.Drawing.Size(846, 230);
            this.shoppingCartListView.TabIndex = 14;
            this.shoppingCartListView.UseCompatibleStateImageBehavior = false;
            this.shoppingCartListView.View = System.Windows.Forms.View.Details;
            // 
            // shoppingCartColumnFurnitureID
            // 
            this.shoppingCartColumnFurnitureID.Text = "Furniture ID";
            this.shoppingCartColumnFurnitureID.Width = 100;
            // 
            // shoppingCartColumnName
            // 
            this.shoppingCartColumnName.Text = "Name";
            this.shoppingCartColumnName.Width = 100;
            // 
            // shoppingCartColumnDescription
            // 
            this.shoppingCartColumnDescription.Text = "Description";
            this.shoppingCartColumnDescription.Width = 100;
            // 
            // shoppingCartColumnCategory
            // 
            this.shoppingCartColumnCategory.Text = "Category";
            this.shoppingCartColumnCategory.Width = 100;
            // 
            // shoppingCartColumnStyle
            // 
            this.shoppingCartColumnStyle.Text = "Style";
            this.shoppingCartColumnStyle.Width = 100;
            // 
            // shoppingCartColumnDailyRate
            // 
            this.shoppingCartColumnDailyRate.Text = "Daily Rate";
            this.shoppingCartColumnDailyRate.Width = 100;
            // 
            // shoppingCartColumnTotalRate
            // 
            this.shoppingCartColumnTotalRate.Text = "Total Rate";
            this.shoppingCartColumnTotalRate.Width = 100;
            // 
            // shoppingCartColumnQuantity
            // 
            this.shoppingCartColumnQuantity.Text = "Quantity";
            this.shoppingCartColumnQuantity.Width = 100;
            // 
            // shoppingCartColumnRemoveBtn
            // 
            this.shoppingCartColumnRemoveBtn.Text = "";
            // 
            // returnTotalsTableLayoutPanel
            // 
            this.returnTotalsTableLayoutPanel.ColumnCount = 3;
            this.returnTotalsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.returnTotalsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.returnTotalsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.returnTotalsTableLayoutPanel.Controls.Add(this.checkoutButton, 1, 3);
            this.returnTotalsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnTotalsTableLayoutPanel.Location = new System.Drawing.Point(13, 805);
            this.returnTotalsTableLayoutPanel.Name = "returnTotalsTableLayoutPanel";
            this.returnTotalsTableLayoutPanel.RowCount = 4;
            this.returnTotalsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.returnTotalsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.returnTotalsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.returnTotalsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.returnTotalsTableLayoutPanel.Size = new System.Drawing.Size(848, 234);
            this.returnTotalsTableLayoutPanel.TabIndex = 15;
            // 
            // checkoutButton
            // 
            this.checkoutButton.AutoSize = true;
            this.checkoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.Location = new System.Drawing.Point(495, 186);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(220, 48);
            this.checkoutButton.TabIndex = 11;
            this.checkoutButton.Text = "Check Out";
            this.checkoutButton.UseVisualStyleBackColor = true;
            // 
            // AddRentalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rentalTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "AddRentalUserControl";
            this.Size = new System.Drawing.Size(900, 900);
            this.Load += new System.EventHandler(this.AddRentalUserControl_Load);
            this.rentalTableLayoutPanel.ResumeLayout(false);
            this.rentalTableLayoutPanel.PerformLayout();
            this.furnitureSearchTableLayoutPanel.ResumeLayout(false);
            this.furnitureSearchTableLayoutPanel.PerformLayout();
            this.furnitureSubheadingTableLayoutPanel.ResumeLayout(false);
            this.furnitureSubheadingTableLayoutPanel.PerformLayout();
            this.shoppingCartSubheadingLayoutPanel.ResumeLayout(false);
            this.shoppingCartSubheadingLayoutPanel.PerformLayout();
            this.returnTotalsTableLayoutPanel.ResumeLayout(false);
            this.returnTotalsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView furnitureListView;
        private System.Windows.Forms.TableLayoutPanel rentalTableLayoutPanel;
        private System.Windows.Forms.ColumnHeader furnitureColumnFurnitureID;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.ComboBox furnitureSearchComboBox;
        private System.Windows.Forms.TextBox furnitureSearchTexBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label searchMessageLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TableLayoutPanel furnitureSearchTableLayoutPanel;
        private System.Windows.Forms.Label memberLabel;
        private System.Windows.Forms.ComboBox memberComboBox;
        private System.Windows.Forms.ColumnHeader furnitureColumnName;
        private System.Windows.Forms.ColumnHeader furnitureColumnDescription;
        private System.Windows.Forms.ColumnHeader furnitureColumnCategory;
        private System.Windows.Forms.ColumnHeader furnitureColumnStyle;
        private System.Windows.Forms.ColumnHeader furnitureColumnDailyRate;
        private System.Windows.Forms.ColumnHeader furnitureColumnAvailQuantity;
        private System.Windows.Forms.ColumnHeader furnitureColumnAddBtn;
        private System.Windows.Forms.TableLayoutPanel furnitureSubheadingTableLayoutPanel;
        private System.Windows.Forms.Label furnitureLabel;
        private System.Windows.Forms.TableLayoutPanel shoppingCartSubheadingLayoutPanel;
        private System.Windows.Forms.Label shoppingCartLabel;
        private System.Windows.Forms.ListView shoppingCartListView;
        private System.Windows.Forms.ColumnHeader shoppingCartColumnFurnitureID;
        private System.Windows.Forms.ColumnHeader shoppingCartColumnName;
        private System.Windows.Forms.ColumnHeader shoppingCartColumnDescription;
        private System.Windows.Forms.ColumnHeader shoppingCartColumnCategory;
        private System.Windows.Forms.ColumnHeader shoppingCartColumnStyle;
        private System.Windows.Forms.ColumnHeader shoppingCartColumnDailyRate;
        private System.Windows.Forms.ColumnHeader shoppingCartColumnTotalRate;
        private System.Windows.Forms.ColumnHeader shoppingCartColumnQuantity;
        private System.Windows.Forms.ColumnHeader shoppingCartColumnRemoveBtn;
        private System.Windows.Forms.TableLayoutPanel returnTotalsTableLayoutPanel;
        private System.Windows.Forms.Button checkoutButton;
    }
}
