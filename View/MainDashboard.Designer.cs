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
            this.rentalTabPage = new System.Windows.Forms.TabPage();
            this.returnTabPage = new System.Windows.Forms.TabPage();
            this.transactionTabPage = new System.Windows.Forms.TabPage();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.searchMemberUserControl1 = new RentMeApp.UserControls.SearchMemberUserControl();
            this.mainTabControl.SuspendLayout();
            this.membersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.membersTabPage);
            this.mainTabControl.Controls.Add(this.rentalTabPage);
            this.mainTabControl.Controls.Add(this.returnTabPage);
            this.mainTabControl.Controls.Add(this.transactionTabPage);
            this.mainTabControl.Controls.Add(this.reportTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(800, 450);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // membersTabPage
            // 
            this.membersTabPage.Controls.Add(this.searchMemberUserControl1);
            this.membersTabPage.Location = new System.Drawing.Point(4, 29);
            this.membersTabPage.Name = "membersTabPage";
            this.membersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.membersTabPage.Size = new System.Drawing.Size(792, 417);
            this.membersTabPage.TabIndex = 0;
            this.membersTabPage.Text = "Members";
            this.membersTabPage.UseVisualStyleBackColor = true;
            // 
            // rentalTabPage
            // 
            this.rentalTabPage.Location = new System.Drawing.Point(4, 29);
            this.rentalTabPage.Name = "rentalTabPage";
            this.rentalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rentalTabPage.Size = new System.Drawing.Size(792, 331);
            this.rentalTabPage.TabIndex = 1;
            this.rentalTabPage.Text = "Rental";
            this.rentalTabPage.UseVisualStyleBackColor = true;
            // 
            // returnTabPage
            // 
            this.returnTabPage.Location = new System.Drawing.Point(4, 29);
            this.returnTabPage.Name = "returnTabPage";
            this.returnTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.returnTabPage.Size = new System.Drawing.Size(792, 331);
            this.returnTabPage.TabIndex = 2;
            this.returnTabPage.Text = "Return";
            this.returnTabPage.UseVisualStyleBackColor = true;
            // 
            // transactionTabPage
            // 
            this.transactionTabPage.Location = new System.Drawing.Point(4, 29);
            this.transactionTabPage.Name = "transactionTabPage";
            this.transactionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.transactionTabPage.Size = new System.Drawing.Size(792, 331);
            this.transactionTabPage.TabIndex = 3;
            this.transactionTabPage.Text = "Transactions";
            this.transactionTabPage.UseVisualStyleBackColor = true;
            // 
            // reportTabPage
            // 
            this.reportTabPage.Location = new System.Drawing.Point(4, 29);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportTabPage.Size = new System.Drawing.Size(792, 331);
            this.reportTabPage.TabIndex = 4;
            this.reportTabPage.Text = "Reports";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // searchMemberUserControl1
            // 
            this.searchMemberUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchMemberUserControl1.Location = new System.Drawing.Point(3, 3);
            this.searchMemberUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchMemberUserControl1.Name = "searchMemberUserControl1";
            this.searchMemberUserControl1.Size = new System.Drawing.Size(786, 411);
            this.searchMemberUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTabControl);
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
        private System.Windows.Forms.TabPage rentalTabPage;
        private System.Windows.Forms.TabPage returnTabPage;
        private System.Windows.Forms.TabPage transactionTabPage;
        private System.Windows.Forms.TabPage reportTabPage;
        private UserControls.SearchMemberUserControl searchMemberUserControl1;
    }
}