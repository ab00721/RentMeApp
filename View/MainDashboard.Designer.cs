namespace RentMeApp.View
{
    partial class MainDashboard
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.membersTabPage = new System.Windows.Forms.TabPage();
            this.furnitureTabPage = new System.Windows.Forms.TabPage();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.userTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainSearchMemberUserControl = new RentMeApp.UserControls.SearchMemberUserControl();
            this.mainSearchFurnitureUserControl = new RentMeApp.UserControls.SearchFurnitureUserControl();
            this.reportUserControl1 = new RentMeApp.UserControls.ReportUserControl();
            this.mainTabControl.SuspendLayout();
            this.membersTabPage.SuspendLayout();
            this.furnitureTabPage.SuspendLayout();
            this.reportTabPage.SuspendLayout();
            this.userTableLayoutPanel.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.membersTabPage);
            this.mainTabControl.Controls.Add(this.furnitureTabPage);
            this.mainTabControl.Controls.Add(this.reportTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(2, 55);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(713, 411);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // membersTabPage
            // 
            this.membersTabPage.Controls.Add(this.mainSearchMemberUserControl);
            this.membersTabPage.Location = new System.Drawing.Point(4, 26);
            this.membersTabPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.membersTabPage.Name = "membersTabPage";
            this.membersTabPage.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.membersTabPage.Size = new System.Drawing.Size(705, 381);
            this.membersTabPage.TabIndex = 0;
            this.membersTabPage.Text = "Members";
            this.membersTabPage.UseVisualStyleBackColor = true;
            // 
            // furnitureTabPage
            // 
            this.furnitureTabPage.Controls.Add(this.mainSearchFurnitureUserControl);
            this.furnitureTabPage.Location = new System.Drawing.Point(4, 26);
            this.furnitureTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.furnitureTabPage.Name = "furnitureTabPage";
            this.furnitureTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.furnitureTabPage.Size = new System.Drawing.Size(705, 381);
            this.furnitureTabPage.TabIndex = 5;
            this.furnitureTabPage.Text = "Furniture";
            this.furnitureTabPage.UseVisualStyleBackColor = true;
            // 
            // reportTabPage
            // 
            this.reportTabPage.Controls.Add(this.reportUserControl1);
            this.reportTabPage.Location = new System.Drawing.Point(4, 26);
            this.reportTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportTabPage.Size = new System.Drawing.Size(705, 381);
            this.reportTabPage.TabIndex = 6;
            this.reportTabPage.Text = "Reports";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(639, 0);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.logoutLinkLabel.Size = new System.Drawing.Size(72, 29);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // userTableLayoutPanel
            // 
            this.userTableLayoutPanel.AutoSize = true;
            this.userTableLayoutPanel.ColumnCount = 2;
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.19739F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.80261F));
            this.userTableLayoutPanel.Controls.Add(this.logoutLinkLabel, 1, 0);
            this.userTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTableLayoutPanel.Location = new System.Drawing.Point(2, 1);
            this.userTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.userTableLayoutPanel.Name = "userTableLayoutPanel";
            this.userTableLayoutPanel.RowCount = 1;
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userTableLayoutPanel.Size = new System.Drawing.Size(713, 50);
            this.userTableLayoutPanel.TabIndex = 2;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.mainTabControl, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.userTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(717, 469);
            this.mainTableLayoutPanel.TabIndex = 3;
            // 
            // mainSearchMemberUserControl
            // 
            this.mainSearchMemberUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSearchMemberUserControl.Location = new System.Drawing.Point(2, 3);
            this.mainSearchMemberUserControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mainSearchMemberUserControl.Name = "mainSearchMemberUserControl";
            this.mainSearchMemberUserControl.Size = new System.Drawing.Size(701, 375);
            this.mainSearchMemberUserControl.TabIndex = 0;
            // 
            // mainSearchFurnitureUserControl
            // 
            this.mainSearchFurnitureUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSearchFurnitureUserControl.Location = new System.Drawing.Point(2, 2);
            this.mainSearchFurnitureUserControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainSearchFurnitureUserControl.Name = "mainSearchFurnitureUserControl";
            this.mainSearchFurnitureUserControl.Size = new System.Drawing.Size(701, 377);
            this.mainSearchFurnitureUserControl.TabIndex = 0;
            // 
            // reportUserControl1
            // 
            this.reportUserControl1.Location = new System.Drawing.Point(0, 0);
            this.reportUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.reportUserControl1.Name = "reportUserControl1";
            this.reportUserControl1.Size = new System.Drawing.Size(709, 385);
            this.reportUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(717, 469);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Me App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboard_FormClosed);
            this.mainTabControl.ResumeLayout(false);
            this.membersTabPage.ResumeLayout(false);
            this.furnitureTabPage.ResumeLayout(false);
            this.reportTabPage.ResumeLayout(false);
            this.userTableLayoutPanel.ResumeLayout(false);
            this.userTableLayoutPanel.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage membersTabPage;
        private UserControls.SearchMemberUserControl mainSearchMemberUserControl;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TableLayoutPanel userTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TabPage furnitureTabPage;
        private System.Windows.Forms.TabPage reportTabPage;
        private UserControls.SearchFurnitureUserControl mainSearchFurnitureUserControl;
        private UserControls.ReportUserControl reportUserControl1;
    }
}