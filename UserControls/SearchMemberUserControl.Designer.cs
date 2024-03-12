namespace RentMeApp.UserControls
{
    partial class SearchMemberUserControl
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
            this.memberIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.viewTransactionsButton = new System.Windows.Forms.Button();
            this.newReturnButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.editMemberButton = new System.Windows.Forms.Button();
            this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchMessageLabel = new System.Windows.Forms.Label();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.memberSearchComboBox = new System.Windows.Forms.ComboBox();
            this.memberSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.sexColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOfBirthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address1Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address2Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zipColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.searchTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberListView
            // 
            this.memberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.memberIDColumn,
            this.firstNameColumn,
            this.lastNameColumn,
            this.sexColumn,
            this.dateOfBirthColumn,
            this.address1Column,
            this.address2Column,
            this.cityColumn,
            this.stateColumn,
            this.zipColumn,
            this.phoneColumn});
            this.memberListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberListView.FullRowSelect = true;
            this.memberListView.HideSelection = false;
            this.memberListView.Location = new System.Drawing.Point(9, 83);
            this.memberListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memberListView.Name = "memberListView";
            this.memberListView.Size = new System.Drawing.Size(615, 197);
            this.memberListView.TabIndex = 7;
            this.memberListView.UseCompatibleStateImageBehavior = false;
            this.memberListView.View = System.Windows.Forms.View.Details;
            this.memberListView.SelectedIndexChanged += new System.EventHandler(this.MemberListView_SelectedIndexChanged);
            // 
            // memberIDColumn
            // 
            this.memberIDColumn.Text = "Member ID";
            this.memberIDColumn.Width = 100;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.Text = "First Name";
            this.firstNameColumn.Width = 100;
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.Text = "Last Name";
            this.lastNameColumn.Width = 100;
            // 
            // phoneColumn
            // 
            this.phoneColumn.Text = "Phone Number";
            this.phoneColumn.Width = 150;
            // 
            // memberTableLayoutPanel
            // 
            this.memberTableLayoutPanel.ColumnCount = 1;
            this.memberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.memberTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.memberTableLayoutPanel.Controls.Add(this.searchTableLayoutPanel, 0, 0);
            this.memberTableLayoutPanel.Controls.Add(this.memberListView, 0, 1);
            this.memberTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.memberTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.memberTableLayoutPanel.Name = "memberTableLayoutPanel";
            this.memberTableLayoutPanel.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.memberTableLayoutPanel.RowCount = 3;
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.39469F));
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.70481F));
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.memberTableLayoutPanel.Size = new System.Drawing.Size(633, 386);
            this.memberTableLayoutPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.06422F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.addMemberButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.viewTransactionsButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.newReturnButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.newOrderButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.editMemberButton, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 284);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 92);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // addMemberButton
            // 
            this.addMemberButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.Location = new System.Drawing.Point(2, 63);
            this.addMemberButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(149, 26);
            this.addMemberButton.TabIndex = 1;
            this.addMemberButton.Text = "Add New Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // viewTransactionsButton
            // 
            this.viewTransactionsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTransactionsButton.Enabled = false;
            this.viewTransactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTransactionsButton.Location = new System.Drawing.Point(296, 63);
            this.viewTransactionsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.viewTransactionsButton.Name = "viewTransactionsButton";
            this.viewTransactionsButton.Size = new System.Drawing.Size(162, 26);
            this.viewTransactionsButton.TabIndex = 2;
            this.viewTransactionsButton.Text = "View Transactions";
            this.viewTransactionsButton.UseVisualStyleBackColor = true;
            this.viewTransactionsButton.Click += new System.EventHandler(this.ViewTransactionsButton_Click);
            // 
            // newReturnButton
            // 
            this.newReturnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newReturnButton.Enabled = false;
            this.newReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newReturnButton.Location = new System.Drawing.Point(462, 63);
            this.newReturnButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.newReturnButton.Name = "newReturnButton";
            this.newReturnButton.Size = new System.Drawing.Size(151, 26);
            this.newReturnButton.TabIndex = 3;
            this.newReturnButton.Text = "New Return";
            this.newReturnButton.UseVisualStyleBackColor = true;
            this.newReturnButton.Click += new System.EventHandler(this.NewReturnButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newOrderButton.Enabled = false;
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(462, 33);
            this.newOrderButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(151, 24);
            this.newOrderButton.TabIndex = 4;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // editMemberButton
            // 
            this.editMemberButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editMemberButton.Enabled = false;
            this.editMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMemberButton.Location = new System.Drawing.Point(296, 33);
            this.editMemberButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.editMemberButton.Name = "editMemberButton";
            this.editMemberButton.Size = new System.Drawing.Size(162, 24);
            this.editMemberButton.TabIndex = 5;
            this.editMemberButton.Text = "Edit Member";
            this.editMemberButton.UseVisualStyleBackColor = true;
            this.editMemberButton.Click += new System.EventHandler(this.EditMemberButton_Click);
            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 5;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.5F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.5F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.searchTableLayoutPanel.Controls.Add(this.searchMessageLabel, 3, 1);
            this.searchTableLayoutPanel.Controls.Add(this.searchByLabel, 0, 0);
            this.searchTableLayoutPanel.Controls.Add(this.searchLabel, 2, 0);
            this.searchTableLayoutPanel.Controls.Add(this.memberSearchComboBox, 1, 0);
            this.searchTableLayoutPanel.Controls.Add(this.memberSearchTextBox, 3, 0);
            this.searchTableLayoutPanel.Controls.Add(this.searchButton, 4, 0);
            this.searchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTableLayoutPanel.Location = new System.Drawing.Point(9, 11);
            this.searchTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.RowCount = 2;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(615, 67);
            this.searchTableLayoutPanel.TabIndex = 6;
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.AutoSize = true;
            this.searchMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMessageLabel.Location = new System.Drawing.Point(355, 40);
            this.searchMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(65, 17);
            this.searchMessageLabel.TabIndex = 5;
            this.searchMessageLabel.Text = "message";
            // 
            // searchByLabel
            // 
            this.searchByLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByLabel.Location = new System.Drawing.Point(3, 11);
            this.searchByLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(87, 17);
            this.searchByLabel.TabIndex = 6;
            this.searchByLabel.Text = "Search By:";
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(287, 11);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(64, 17);
            this.searchLabel.TabIndex = 7;
            this.searchLabel.Text = "Search:";
            // 
            // memberSearchComboBox
            // 
            this.memberSearchComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memberSearchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSearchComboBox.FormattingEnabled = true;
            this.memberSearchComboBox.Location = new System.Drawing.Point(94, 7);
            this.memberSearchComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.memberSearchComboBox.Name = "memberSearchComboBox";
            this.memberSearchComboBox.Size = new System.Drawing.Size(155, 25);
            this.memberSearchComboBox.TabIndex = 8;
            this.memberSearchComboBox.SelectedIndexChanged += new System.EventHandler(this.MemberSearchComboBox_SelectedIndexChanged);
            // 
            // memberSearchTextBox
            // 
            this.memberSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memberSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSearchTextBox.Location = new System.Drawing.Point(355, 8);
            this.memberSearchTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.memberSearchTextBox.Name = "memberSearchTextBox";
            this.memberSearchTextBox.Size = new System.Drawing.Size(140, 23);
            this.memberSearchTextBox.TabIndex = 9;
            this.memberSearchTextBox.TextChanged += new System.EventHandler(this.MemberSearchTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(529, 7);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(84, 25);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // sexColumn
            // 
            this.sexColumn.Text = "Sex";
            // 
            // dateOfBirthColumn
            // 
            this.dateOfBirthColumn.Text = "Date of Birth";
            // 
            // address1Column
            // 
            this.address1Column.Text = "Address Line 1";
            // 
            // address2Column
            // 
            this.address2Column.Text = "Address Line 2";
            // 
            // cityColumn
            // 
            this.cityColumn.Text = "City";
            // 
            // stateColumn
            // 
            this.stateColumn.Text = "State";
            // 
            // zipColumn
            // 
            this.zipColumn.Text = "Zip";
            // 
            // SearchMemberUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memberTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SearchMemberUserControl";
            this.Size = new System.Drawing.Size(633, 386);
            this.Load += new System.EventHandler(this.SearchMemberUserControl_Load);
            this.memberTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView memberListView;
        private System.Windows.Forms.TableLayoutPanel memberTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button viewTransactionsButton;
        private System.Windows.Forms.Button newReturnButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button editMemberButton;
        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.Label searchMessageLabel;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ComboBox memberSearchComboBox;
        private System.Windows.Forms.TextBox memberSearchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ColumnHeader memberIDColumn;
        private System.Windows.Forms.ColumnHeader firstNameColumn;
        private System.Windows.Forms.ColumnHeader lastNameColumn;
        private System.Windows.Forms.ColumnHeader phoneColumn;
        private System.Windows.Forms.ColumnHeader sexColumn;
        private System.Windows.Forms.ColumnHeader dateOfBirthColumn;
        private System.Windows.Forms.ColumnHeader address1Column;
        private System.Windows.Forms.ColumnHeader address2Column;
        private System.Windows.Forms.ColumnHeader cityColumn;
        private System.Windows.Forms.ColumnHeader stateColumn;
        private System.Windows.Forms.ColumnHeader zipColumn;
    }
}
