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
            this.sexColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOfBirthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressOneColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressTwoColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zipColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.butttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.memberSearchComboBox = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchMessageLabel = new System.Windows.Forms.Label();
            this.memberSearchTextBox = new System.Windows.Forms.TextBox();
            this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.viewTransactionsButton = new System.Windows.Forms.Button();
            this.newReturnButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.editMemberButton = new System.Windows.Forms.Button();
            this.memberTableLayoutPanel.SuspendLayout();
            this.searchTableLayoutPanel.SuspendLayout();
            this.butttonsTableLayoutPanel.SuspendLayout();
            this.buttonTableLayoutPanel.SuspendLayout();
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
            this.addressOneColumn,
            this.addressTwoColumn,
            this.cityColumn,
            this.stateColumn,
            this.zipColumn,
            this.phoneColumn});
            this.memberListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberListView.FullRowSelect = true;
            this.memberListView.HideSelection = false;
            this.memberListView.Location = new System.Drawing.Point(14, 178);
            this.memberListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memberListView.Name = "memberListView";
            this.memberListView.Size = new System.Drawing.Size(979, 291);
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
            // sexColumn
            // 
            this.sexColumn.Text = "Sex";
            // 
            // dateOfBirthColumn
            // 
            this.dateOfBirthColumn.Text = "Date Of Birth";
            // 
            // addressOneColumn
            // 
            this.addressOneColumn.Text = "Address Line 1";
            // 
            // addressTwoColumn
            // 
            this.addressTwoColumn.Text = "Address Line 2";
            // 
            // cityColumn
            // 
            this.cityColumn.Text = "City";
            this.cityColumn.Width = 59;
            // 
            // stateColumn
            // 
            this.stateColumn.Text = "State";
            // 
            // zipColumn
            // 
            this.zipColumn.Text = "Zip";
            // 
            // phoneColumn
            // 
            this.phoneColumn.Text = "Phone Number";
            this.phoneColumn.Width = 117;
            // 
            // memberTableLayoutPanel
            // 
            this.memberTableLayoutPanel.ColumnCount = 1;
            this.memberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.memberTableLayoutPanel.Controls.Add(this.searchTableLayoutPanel, 0, 0);
            this.memberTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 0, 2);
            this.memberTableLayoutPanel.Controls.Add(this.memberListView, 0, 1);
            this.memberTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.memberTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.memberTableLayoutPanel.Name = "memberTableLayoutPanel";
            this.memberTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.memberTableLayoutPanel.RowCount = 3;
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.68694F));
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.97496F));
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.15921F));
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.memberTableLayoutPanel.Size = new System.Drawing.Size(1007, 679);
            this.memberTableLayoutPanel.TabIndex = 2;
            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 3;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.51376F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.37156F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchTableLayoutPanel.Controls.Add(this.butttonsTableLayoutPanel, 2, 1);
            this.searchTableLayoutPanel.Controls.Add(this.searchByLabel, 0, 0);
            this.searchTableLayoutPanel.Controls.Add(this.memberSearchComboBox, 1, 0);
            this.searchTableLayoutPanel.Controls.Add(this.searchLabel, 0, 1);
            this.searchTableLayoutPanel.Controls.Add(this.searchMessageLabel, 2, 0);
            this.searchTableLayoutPanel.Controls.Add(this.memberSearchTextBox, 1, 1);
            this.searchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTableLayoutPanel.Location = new System.Drawing.Point(14, 18);
            this.searchTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.RowCount = 2;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.53465F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.46535F));
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(979, 149);
            this.searchTableLayoutPanel.TabIndex = 7;
            // 
            // butttonsTableLayoutPanel
            // 
            this.butttonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butttonsTableLayoutPanel.ColumnCount = 2;
            this.butttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.butttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.butttonsTableLayoutPanel.Controls.Add(this.clearButton, 1, 0);
            this.butttonsTableLayoutPanel.Controls.Add(this.searchButton, 0, 0);
            this.butttonsTableLayoutPanel.Location = new System.Drawing.Point(492, 85);
            this.butttonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butttonsTableLayoutPanel.MaximumSize = new System.Drawing.Size(483, 48);
            this.butttonsTableLayoutPanel.Name = "butttonsTableLayoutPanel";
            this.butttonsTableLayoutPanel.RowCount = 1;
            this.butttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.butttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.butttonsTableLayoutPanel.Size = new System.Drawing.Size(483, 48);
            this.butttonsTableLayoutPanel.TabIndex = 11;
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(245, 6);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(234, 36);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(4, 6);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(233, 36);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchByLabel
            // 
            this.searchByLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByLabel.Location = new System.Drawing.Point(4, 22);
            this.searchByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(127, 25);
            this.searchByLabel.TabIndex = 6;
            this.searchByLabel.Text = "Search By:";
            // 
            // memberSearchComboBox
            // 
            this.memberSearchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.memberSearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memberSearchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSearchComboBox.FormattingEnabled = true;
            this.memberSearchComboBox.Location = new System.Drawing.Point(165, 18);
            this.memberSearchComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.memberSearchComboBox.Name = "memberSearchComboBox";
            this.memberSearchComboBox.Size = new System.Drawing.Size(319, 33);
            this.memberSearchComboBox.TabIndex = 8;
            this.memberSearchComboBox.SelectedIndexChanged += new System.EventHandler(this.MemberSearchComboBox_SelectedIndexChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(4, 96);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(93, 25);
            this.searchLabel.TabIndex = 7;
            this.searchLabel.Text = "Search:";
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchMessageLabel.AutoSize = true;
            this.searchMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMessageLabel.Location = new System.Drawing.Point(492, 22);
            this.searchMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(483, 25);
            this.searchMessageLabel.TabIndex = 5;
            this.searchMessageLabel.Text = "message";
            // 
            // memberSearchTextBox
            // 
            this.memberSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.memberSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSearchTextBox.Location = new System.Drawing.Point(165, 93);
            this.memberSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.memberSearchTextBox.Name = "memberSearchTextBox";
            this.memberSearchTextBox.Size = new System.Drawing.Size(319, 31);
            this.memberSearchTextBox.TabIndex = 9;
            this.memberSearchTextBox.TextChanged += new System.EventHandler(this.MemberSearchTextBox_TextChanged);
            // 
            // buttonTableLayoutPanel
            // 
            this.buttonTableLayoutPanel.ColumnCount = 4;
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.06422F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTableLayoutPanel.Controls.Add(this.addMemberButton, 0, 2);
            this.buttonTableLayoutPanel.Controls.Add(this.viewTransactionsButton, 2, 2);
            this.buttonTableLayoutPanel.Controls.Add(this.newReturnButton, 3, 2);
            this.buttonTableLayoutPanel.Controls.Add(this.newOrderButton, 3, 1);
            this.buttonTableLayoutPanel.Controls.Add(this.editMemberButton, 2, 1);
            this.buttonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTableLayoutPanel.Location = new System.Drawing.Point(14, 479);
            this.buttonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            this.buttonTableLayoutPanel.RowCount = 3;
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.buttonTableLayoutPanel.Size = new System.Drawing.Size(979, 183);
            this.buttonTableLayoutPanel.TabIndex = 11;
            // 
            // addMemberButton
            // 
            this.addMemberButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.Location = new System.Drawing.Point(4, 128);
            this.addMemberButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(236, 49);
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
            this.viewTransactionsButton.Location = new System.Drawing.Point(472, 128);
            this.viewTransactionsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.viewTransactionsButton.Name = "viewTransactionsButton";
            this.viewTransactionsButton.Size = new System.Drawing.Size(256, 49);
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
            this.newReturnButton.Location = new System.Drawing.Point(736, 128);
            this.newReturnButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newReturnButton.Name = "newReturnButton";
            this.newReturnButton.Size = new System.Drawing.Size(239, 49);
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
            this.newOrderButton.Location = new System.Drawing.Point(736, 67);
            this.newOrderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(239, 49);
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
            this.editMemberButton.Location = new System.Drawing.Point(472, 67);
            this.editMemberButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editMemberButton.Name = "editMemberButton";
            this.editMemberButton.Size = new System.Drawing.Size(256, 49);
            this.editMemberButton.TabIndex = 5;
            this.editMemberButton.Text = "Edit Member";
            this.editMemberButton.UseVisualStyleBackColor = true;
            this.editMemberButton.Click += new System.EventHandler(this.EditMemberButton_Click);
            // 
            // SearchMemberUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memberTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "SearchMemberUserControl";
            this.Size = new System.Drawing.Size(1007, 679);
            this.Load += new System.EventHandler(this.SearchMemberUserControl_Load);
            this.memberTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            this.butttonsTableLayoutPanel.ResumeLayout(false);
            this.butttonsTableLayoutPanel.PerformLayout();
            this.buttonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView memberListView;
        private System.Windows.Forms.TableLayoutPanel memberTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel buttonTableLayoutPanel;
        private System.Windows.Forms.Button viewTransactionsButton;
        private System.Windows.Forms.Button newReturnButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button editMemberButton;
        private System.Windows.Forms.ColumnHeader memberIDColumn;
        private System.Windows.Forms.ColumnHeader firstNameColumn;
        private System.Windows.Forms.ColumnHeader lastNameColumn;
        private System.Windows.Forms.ColumnHeader phoneColumn;
        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.ComboBox memberSearchComboBox;
        private System.Windows.Forms.TextBox memberSearchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label searchMessageLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.TableLayoutPanel butttonsTableLayoutPanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ColumnHeader sexColumn;
        private System.Windows.Forms.ColumnHeader dateOfBirthColumn;
        private System.Windows.Forms.ColumnHeader addressOneColumn;
        private System.Windows.Forms.ColumnHeader addressTwoColumn;
        private System.Windows.Forms.ColumnHeader cityColumn;
        private System.Windows.Forms.ColumnHeader stateColumn;
        private System.Windows.Forms.ColumnHeader zipColumn;
    }
}
