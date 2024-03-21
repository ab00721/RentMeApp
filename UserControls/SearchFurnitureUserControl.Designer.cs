namespace RentMeApp.UserControls
{
    partial class SearchFurnitureUserControl
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
            this.furnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.furnitureSearchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.furnitureSearchComboBox = new System.Windows.Forms.ComboBox();
            this.furnitureSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchMessageLabel = new System.Windows.Forms.Label();
            this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.furnitureTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataGridView)).BeginInit();
            this.furnitureSearchTableLayoutPanel.SuspendLayout();
            this.searchTableLayoutPanel.SuspendLayout();
            this.furnitureTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // furnitureDataGridView
            // 
            this.furnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureDataGridView.Location = new System.Drawing.Point(14, 135);
            this.furnitureDataGridView.Name = "furnitureDataGridView";
            this.furnitureDataGridView.RowHeadersWidth = 62;
            this.furnitureDataGridView.RowTemplate.Height = 24;
            this.furnitureDataGridView.Size = new System.Drawing.Size(1015, 454);
            this.furnitureDataGridView.TabIndex = 12;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(122, 6);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(126, 37);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // furnitureSearchTableLayoutPanel
            // 
            this.furnitureSearchTableLayoutPanel.ColumnCount = 2;
            this.furnitureSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.furnitureSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.clearButton, 1, 0);
            this.furnitureSearchTableLayoutPanel.Controls.Add(this.searchButton, 0, 0);
            this.furnitureSearchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureSearchTableLayoutPanel.Location = new System.Drawing.Point(509, 59);
            this.furnitureSearchTableLayoutPanel.Name = "furnitureSearchTableLayoutPanel";
            this.furnitureSearchTableLayoutPanel.RowCount = 1;
            this.furnitureSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.furnitureSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.furnitureSearchTableLayoutPanel.Size = new System.Drawing.Size(503, 50);
            this.furnitureSearchTableLayoutPanel.TabIndex = 10;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(349, 8);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(151, 34);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // searchByLabel
            // 
            this.searchByLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByLabel.Location = new System.Drawing.Point(3, 15);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(127, 25);
            this.searchByLabel.TabIndex = 6;
            this.searchByLabel.Text = "Search By:";
            // 
            // furnitureSearchComboBox
            // 
            this.furnitureSearchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.furnitureSearchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureSearchComboBox.FormattingEnabled = true;
            this.furnitureSearchComboBox.Location = new System.Drawing.Point(170, 11);
            this.furnitureSearchComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.furnitureSearchComboBox.Name = "furnitureSearchComboBox";
            this.furnitureSearchComboBox.Size = new System.Drawing.Size(333, 33);
            this.furnitureSearchComboBox.TabIndex = 8;
            // 
            // furnitureSearchTextBox
            // 
            this.furnitureSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.furnitureSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureSearchTextBox.Location = new System.Drawing.Point(170, 68);
            this.furnitureSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.furnitureSearchTextBox.Name = "furnitureSearchTextBox";
            this.furnitureSearchTextBox.Size = new System.Drawing.Size(333, 31);
            this.furnitureSearchTextBox.TabIndex = 9;
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(3, 71);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(93, 25);
            this.searchLabel.TabIndex = 7;
            this.searchLabel.Text = "Search:";
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchMessageLabel.AutoSize = true;
            this.searchMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMessageLabel.Location = new System.Drawing.Point(509, 15);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(99, 25);
            this.searchMessageLabel.TabIndex = 5;
            this.searchMessageLabel.Text = "message";
            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 3;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.51376F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.37156F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchTableLayoutPanel.Controls.Add(this.searchByLabel, 0, 0);
            this.searchTableLayoutPanel.Controls.Add(this.furnitureSearchComboBox, 1, 0);
            this.searchTableLayoutPanel.Controls.Add(this.furnitureSearchTextBox, 1, 1);
            this.searchTableLayoutPanel.Controls.Add(this.searchLabel, 0, 1);
            this.searchTableLayoutPanel.Controls.Add(this.searchMessageLabel, 2, 0);
            this.searchTableLayoutPanel.Controls.Add(this.furnitureSearchTableLayoutPanel, 2, 1);
            this.searchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTableLayoutPanel.Location = new System.Drawing.Point(14, 16);
            this.searchTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.RowCount = 2;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(1015, 112);
            this.searchTableLayoutPanel.TabIndex = 6;
            // 
            // furnitureTableLayoutPanel
            // 
            this.furnitureTableLayoutPanel.ColumnCount = 1;
            this.furnitureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.furnitureTableLayoutPanel.Controls.Add(this.searchTableLayoutPanel, 0, 0);
            this.furnitureTableLayoutPanel.Controls.Add(this.furnitureDataGridView, 0, 1);
            this.furnitureTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.furnitureTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.furnitureTableLayoutPanel.Name = "furnitureTableLayoutPanel";
            this.furnitureTableLayoutPanel.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.furnitureTableLayoutPanel.RowCount = 3;
            this.furnitureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.furnitureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.32058F));
            this.furnitureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.825137F));
            this.furnitureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.furnitureTableLayoutPanel.Size = new System.Drawing.Size(1043, 628);
            this.furnitureTableLayoutPanel.TabIndex = 3;
            // 
            // SearchFurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.furnitureTableLayoutPanel);
            this.Name = "SearchFurnitureUserControl";
            this.Size = new System.Drawing.Size(1043, 628);
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataGridView)).EndInit();
            this.furnitureSearchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            this.furnitureTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView furnitureDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TableLayoutPanel furnitureSearchTableLayoutPanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.ComboBox furnitureSearchComboBox;
        private System.Windows.Forms.TextBox furnitureSearchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label searchMessageLabel;
        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel furnitureTableLayoutPanel;
    }
}
