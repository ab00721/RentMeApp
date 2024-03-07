namespace RentMeApp.UserControls
{
    partial class LogoutUserControl
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.logoutGroupBox = new System.Windows.Forms.GroupBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(22, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 20);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "name";
            this.nameLabel.UseWaitCursor = true;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(580, 18);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(66, 20);
            this.logoutLinkLabel.TabIndex = 7;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.UseWaitCursor = true;
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // logoutGroupBox
            // 
            this.logoutGroupBox.AutoSize = true;
            this.logoutGroupBox.Controls.Add(this.usernameLabel);
            this.logoutGroupBox.Controls.Add(this.nameLabel);
            this.logoutGroupBox.Controls.Add(this.logoutLinkLabel);
            this.logoutGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutGroupBox.Location = new System.Drawing.Point(0, 0);
            this.logoutGroupBox.Name = "logoutGroupBox";
            this.logoutGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutGroupBox.Size = new System.Drawing.Size(652, 56);
            this.logoutGroupBox.TabIndex = 11;
            this.logoutGroupBox.TabStop = false;
            this.logoutGroupBox.UseWaitCursor = true;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(465, 18);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 20);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "username";
            this.usernameLabel.UseWaitCursor = true;
            // 
            // LogoutUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logoutGroupBox);
            this.Name = "LogoutUserControl";
            this.Size = new System.Drawing.Size(652, 56);
            this.logoutGroupBox.ResumeLayout(false);
            this.logoutGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.GroupBox logoutGroupBox;
        private System.Windows.Forms.Label usernameLabel;
    }
}
