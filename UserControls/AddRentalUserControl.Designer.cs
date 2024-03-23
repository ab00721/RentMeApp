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
            this.memberListView = new System.Windows.Forms.ListView();
            this.furnitureIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.styleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dailyRateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.availQuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBtnColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rentalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.furnitureSearchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.butttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.furnitureSearchComboBox = new System.Windows.Forms.ComboBox();
            this.searchMessageLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.furnitureSearchTexBox = new System.Windows.Forms.TextBox();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.memberLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.furnitureLabel = new System.Windows.Forms.Label();
            this.rentalTableLayoutPanel.SuspendLayout();
            this.furnitureSearchTableLayoutPanel.SuspendLayout();
            this.butttonsTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberListView
            // 
            this.memberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.furnitureIDColumn,
            this.nameColumn,
            this.descriptionColumn,
            this.categoryColumn,
            this.styleColumn,
            this.dailyRateColumn,
            this.availQuantityColumn,
            this.addBtnColumn});
            this.memberListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberListView.FullRowSelect = true;
            this.memberListView.HideSelection = false;
            this.memberListView.Location = new System.Drawing.Point(14, 237);
            this.memberListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memberListView.Name = "memberListView";
            this.memberListView.Size = new System.Drawing.Size(872, 210);
            this.memberListView.TabIndex = 7;
            this.memberListView.UseCompatibleStateImageBehavior = false;
            this.memberListView.View = System.Windows.Forms.View.Details;
            // 
            // furnitureIDColumn
            // 
            this.furnitureIDColumn.Text = "Furniture ID";
            this.furnitureIDColumn.Width = 100;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 100;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.Text = "Description";
            this.descriptionColumn.Width = 100;
            // 
            // categoryColumn
            // 
            this.categoryColumn.Text = "Category";
            this.categoryColumn.Width = 100;
            // 
            // styleColumn
            // 
            this.styleColumn.Text = "Style";
            this.styleColumn.Width = 100;
            // 
            // dailyRateColumn
            // 
            this.dailyRateColumn.Text = "Daily Rate";
            this.dailyRateColumn.Width = 100;
            // 
            // availQuantityColumn
            // 
            this.availQuantityColumn.Text = "Avail. Quantity";
            this.availQuantityColumn.Width = 100;
            // 
            // addBtnColumn
            // 
            this.addBtnColumn.Text = "";
            this.addBtnColumn.Width = 200;
            // 
            // rentalTableLayoutPanel
            // 
            this.rentalTableLayoutPanel.ColumnCount = 1;
            this.rentalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rentalTableLayoutPanel.Controls.Add(this.memberListView, 0, 1);
            this.rentalTableLayoutPanel.Controls.Add(this.furnitureSearchTableLayoutPanel, 0, 0);
            this.rentalTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.rentalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.rentalTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rentalTableLayoutPanel.Name = "rentalTableLayoutPanel";
            this.rentalTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.rentalTableLayoutPanel.RowCount = 4;
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rentalTableLayoutPanel.Size = new System.Drawing.Size(900, 900);
            this.rentalTableLayoutPanel.TabIndex = 2;
            // 
            // furnitureSearchTableLayoutPanel
            // 
            this.furnitureSearchTableLayoutPanel.ColumnCount = 5;
            this.furnitureSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.furnitureSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.furnitureSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.furnitureSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.furnitureSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.butttonsTableLayoutPanel, 4, 1);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.furnitureSearchComboBox, 1, 1);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.searchMessageLabel, 3, 2);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.searchLabel, 2, 1);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.furnitureSearchTexBox, 3, 1);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.searchByLabel, 0, 1);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.memberLabel, 0, 0);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.comboBox1, 1, 0);
            this.furnitureSearchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureSearchTableLayoutPanel.Location = new System.Drawing.Point(14, 17);
            this.furnitureSearchTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.furnitureSearchTableLayoutPanel.Name = "furnitureSearchTableLayoutPanel";
            this.furnitureSearchTableLayoutPanel.RowCount = 3;
            this.furnitureSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.furnitureSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.furnitureSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.furnitureSearchTableLayoutPanel.Size = new System.Drawing.Size(872, 150);
            this.furnitureSearchTableLayoutPanel.TabIndex = 11;
            // 
            // butttonsTableLayoutPanel
            // 
            this.butttonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butttonsTableLayoutPanel.ColumnCount = 1;
            this.butttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.butttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.butttonsTableLayoutPanel.Controls.Add(this.searchButton, 0, 0);
            this.butttonsTableLayoutPanel.Location = new System.Drawing.Point(744, 54);
            this.butttonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butttonsTableLayoutPanel.MaximumSize = new System.Drawing.Size(483, 48);
            this.butttonsTableLayoutPanel.Name = "butttonsTableLayoutPanel";
            this.butttonsTableLayoutPanel.RowCount = 1;
            this.butttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.butttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.butttonsTableLayoutPanel.Size = new System.Drawing.Size(124, 39);
            this.butttonsTableLayoutPanel.TabIndex = 11;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(4, 6);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 27);
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
            this.furnitureSearchComboBox.Location = new System.Drawing.Point(152, 57);
            this.furnitureSearchComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.furnitureSearchComboBox.Name = "furnitureSearchComboBox";
            this.furnitureSearchComboBox.Size = new System.Drawing.Size(227, 33);
            this.furnitureSearchComboBox.TabIndex = 8;
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchMessageLabel.AutoSize = true;
            this.searchMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMessageLabel.Location = new System.Drawing.Point(509, 111);
            this.searchMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(227, 25);
            this.searchMessageLabel.TabIndex = 5;
            this.searchMessageLabel.Text = "message";
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(408, 61);
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
            this.furnitureSearchTexBox.Location = new System.Drawing.Point(509, 58);
            this.furnitureSearchTexBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.furnitureSearchTexBox.Name = "furnitureSearchTexBox";
            this.furnitureSearchTexBox.Size = new System.Drawing.Size(227, 31);
            this.furnitureSearchTexBox.TabIndex = 9;
            // 
            // searchByLabel
            // 
            this.searchByLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchByLabel.Location = new System.Drawing.Point(17, 61);
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
            this.memberLabel.Location = new System.Drawing.Point(41, 12);
            this.memberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(103, 25);
            this.memberLabel.TabIndex = 12;
            this.memberLabel.Text = "Member:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 8);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 33);
            this.comboBox1.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.furnitureLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 175);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 54);
            this.tableLayoutPanel1.TabIndex = 12;
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
            this.furnitureSearchTableLayoutPanel.ResumeLayout(false);
            this.furnitureSearchTableLayoutPanel.PerformLayout();
            this.butttonsTableLayoutPanel.ResumeLayout(false);
            this.butttonsTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView memberListView;
        private System.Windows.Forms.TableLayoutPanel rentalTableLayoutPanel;
        private System.Windows.Forms.ColumnHeader furnitureIDColumn;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.ComboBox furnitureSearchComboBox;
        private System.Windows.Forms.TextBox furnitureSearchTexBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label searchMessageLabel;
        private System.Windows.Forms.TableLayoutPanel butttonsTableLayoutPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TableLayoutPanel furnitureSearchTableLayoutPanel;
        private System.Windows.Forms.Label memberLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader descriptionColumn;
        private System.Windows.Forms.ColumnHeader categoryColumn;
        private System.Windows.Forms.ColumnHeader styleColumn;
        private System.Windows.Forms.ColumnHeader dailyRateColumn;
        private System.Windows.Forms.ColumnHeader availQuantityColumn;
        private System.Windows.Forms.ColumnHeader addBtnColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label furnitureLabel;
    }
}
