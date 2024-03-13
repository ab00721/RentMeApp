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
            this.mainSearchMemberUserControl = new RentMeApp.UserControls.SearchMemberUserControl();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.userTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainTabControl.SuspendLayout();
            this.membersTabPage.SuspendLayout();
            this.userTableLayoutPanel.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.membersTabPage);
            this.mainTabControl.Controls.Add(this.reportTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(3, 62);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1089, 529);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // membersTabPage
            // 
            this.membersTabPage.Controls.Add(this.mainSearchMemberUserControl);
            this.membersTabPage.Location = new System.Drawing.Point(4, 29);
            this.membersTabPage.Name = "membersTabPage";
            this.membersTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.membersTabPage.Size = new System.Drawing.Size(1081, 496);
            this.membersTabPage.TabIndex = 0;
            this.membersTabPage.Text = "Members";
            this.membersTabPage.UseVisualStyleBackColor = true;
            // 
            // mainSearchMemberUserControl
            // 
            this.mainSearchMemberUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSearchMemberUserControl.Location = new System.Drawing.Point(3, 3);
            this.mainSearchMemberUserControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainSearchMemberUserControl.Name = "mainSearchMemberUserControl";
            this.mainSearchMemberUserControl.Size = new System.Drawing.Size(1075, 490);
            this.mainSearchMemberUserControl.TabIndex = 0;
            // 
            // reportTabPage
            // 
            this.reportTabPage.Location = new System.Drawing.Point(4, 29);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.reportTabPage.Size = new System.Drawing.Size(1082, 495);
            this.reportTabPage.TabIndex = 4;
            this.reportTabPage.Text = "Reports";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(1002, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.logoutLinkLabel.Size = new System.Drawing.Size(84, 36);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // userTableLayoutPanel
            // 
            this.userTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTableLayoutPanel.ColumnCount = 2;
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.19739F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.80261F));
            this.userTableLayoutPanel.Controls.Add(this.logoutLinkLabel, 1, 0);
            this.userTableLayoutPanel.Location = new System.Drawing.Point(3, 2);
            this.userTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTableLayoutPanel.Name = "userTableLayoutPanel";
            this.userTableLayoutPanel.RowCount = 1;
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userTableLayoutPanel.Size = new System.Drawing.Size(1089, 54);
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
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1095, 594);
            this.mainTableLayoutPanel.TabIndex = 3;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1095, 594);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Me App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboard_FormClosed);
            this.mainTabControl.ResumeLayout(false);
            this.membersTabPage.ResumeLayout(false);
            this.userTableLayoutPanel.ResumeLayout(false);
            this.userTableLayoutPanel.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage membersTabPage;
        private System.Windows.Forms.TabPage reportTabPage;
        private UserControls.SearchMemberUserControl mainSearchMemberUserControl;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TableLayoutPanel userTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
    }
}