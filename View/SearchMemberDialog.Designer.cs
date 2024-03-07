namespace RentMeApp.View
{
    partial class SearchMemberDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.searchMessageLabel = new System.Windows.Forms.Label();
            this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.memberSearchComboBox = new System.Windows.Forms.ComboBox();
            this.memberSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            this.memberTableLayoutPanel.SuspendLayout();
            this.searchTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.FirstName,
            this.LastName,
            this.Sex,
            this.DateOfBirth,
            this.Address,
            this.Actions});
            this.memberDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberDataGridView.Location = new System.Drawing.Point(13, 99);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.RowHeadersWidth = 51;
            this.memberDataGridView.RowTemplate.Height = 24;
            this.memberDataGridView.Size = new System.Drawing.Size(774, 295);
            this.memberDataGridView.TabIndex = 0;
            // 
            // MemberID
            // 
            this.MemberID.HeaderText = "Member ID";
            this.MemberID.MinimumWidth = 6;
            this.MemberID.Name = "MemberID";
            this.MemberID.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.Width = 125;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date of Birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Actions";
            this.Actions.MinimumWidth = 6;
            this.Actions.Name = "Actions";
            this.Actions.Width = 125;
            // 
            // memberTableLayoutPanel
            // 
            this.memberTableLayoutPanel.ColumnCount = 1;
            this.memberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.memberTableLayoutPanel.Controls.Add(this.memberDataGridView, 0, 1);
            this.memberTableLayoutPanel.Controls.Add(this.addMemberButton, 0, 2);
            this.memberTableLayoutPanel.Controls.Add(this.searchTableLayoutPanel, 0, 0);
            this.memberTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.memberTableLayoutPanel.Name = "memberTableLayoutPanel";
            this.memberTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.memberTableLayoutPanel.RowCount = 3;
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.memberTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.memberTableLayoutPanel.TabIndex = 1;
            // 
            // addMemberButton
            // 
            this.addMemberButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.Location = new System.Drawing.Point(577, 407);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(210, 30);
            this.addMemberButton.TabIndex = 1;
            this.addMemberButton.Text = "Add New Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.AutoSize = true;
            this.searchMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMessageLabel.Location = new System.Drawing.Point(447, 48);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(77, 20);
            this.searchMessageLabel.TabIndex = 5;
            this.searchMessageLabel.Text = "message";
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
            this.searchTableLayoutPanel.Location = new System.Drawing.Point(13, 13);
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.RowCount = 2;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(774, 80);
            this.searchTableLayoutPanel.TabIndex = 6;
            // 
            // searchByLabel
            // 
            this.searchByLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByLabel.Location = new System.Drawing.Point(11, 14);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(102, 20);
            this.searchByLabel.TabIndex = 6;
            this.searchByLabel.Text = "Search By:";
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(367, 14);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(74, 20);
            this.searchLabel.TabIndex = 7;
            this.searchLabel.Text = "Search:";
            // 
            // memberSearchComboBox
            // 
            this.memberSearchComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memberSearchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSearchComboBox.FormattingEnabled = true;
            this.memberSearchComboBox.Location = new System.Drawing.Point(119, 12);
            this.memberSearchComboBox.Name = "memberSearchComboBox";
            this.memberSearchComboBox.Size = new System.Drawing.Size(206, 28);
            this.memberSearchComboBox.TabIndex = 8;
            // 
            // memberSearchTextBox
            // 
            this.memberSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memberSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSearchTextBox.Location = new System.Drawing.Point(447, 10);
            this.memberSearchTextBox.Name = "memberSearchTextBox";
            this.memberSearchTextBox.Size = new System.Drawing.Size(185, 27);
            this.memberSearchTextBox.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(659, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 31);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // SearchMemberDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memberTableLayoutPanel);
            this.Name = "SearchMemberDialog";
            this.Text = "SearchMemberDialog";
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            this.memberTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.TableLayoutPanel memberTableLayoutPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.Label searchMessageLabel;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ComboBox memberSearchComboBox;
        private System.Windows.Forms.TextBox memberSearchTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}