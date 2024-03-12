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
            this.mainTabControl.SuspendLayout();
            this.membersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.membersTabPage);
            this.mainTabControl.Controls.Add(this.reportTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1046, 742);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // membersTabPage
            // 
            this.membersTabPage.Controls.Add(this.mainSearchMemberUserControl);
            this.membersTabPage.Location = new System.Drawing.Point(4, 34);
            this.membersTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.membersTabPage.Name = "membersTabPage";
            this.membersTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.membersTabPage.Size = new System.Drawing.Size(1038, 704);
            this.membersTabPage.TabIndex = 0;
            this.membersTabPage.Text = "Members";
            this.membersTabPage.UseVisualStyleBackColor = true;
            // 
            // mainSearchMemberUserControl
            // 
            this.mainSearchMemberUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSearchMemberUserControl.Location = new System.Drawing.Point(3, 4);
            this.mainSearchMemberUserControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainSearchMemberUserControl.Name = "mainSearchMemberUserControl";
            this.mainSearchMemberUserControl.Size = new System.Drawing.Size(1032, 696);
            this.mainSearchMemberUserControl.TabIndex = 0;
            // 
            // reportTabPage
            // 
            this.reportTabPage.Location = new System.Drawing.Point(4, 34);
            this.reportTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportTabPage.Size = new System.Drawing.Size(1038, 704);
            this.reportTabPage.TabIndex = 4;
            this.reportTabPage.Text = "Reports";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1046, 742);
            this.Controls.Add(this.mainTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Me App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboard_FormClosed);
            this.mainTabControl.ResumeLayout(false);
            this.membersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage membersTabPage;
        private System.Windows.Forms.TabPage reportTabPage;
        private UserControls.SearchMemberUserControl mainSearchMemberUserControl;
    }
}