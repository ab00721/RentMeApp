﻿namespace RentMeApp.View
{
    partial class LogoutForm
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
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.userLabel = new System.Windows.Forms.Label();
            this.logoutGroupBox = new System.Windows.Forms.GroupBox();
            this.logoutGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(617, 18);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(66, 20);
            this.logoutLinkLabel.TabIndex = 7;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.UseWaitCursor = true;
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(6, 18);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(46, 20);
            this.userLabel.TabIndex = 8;
            this.userLabel.Text = "user";
            this.userLabel.UseWaitCursor = true;
            // 
            // logoutGroupBox
            // 
            this.logoutGroupBox.Controls.Add(this.userLabel);
            this.logoutGroupBox.Controls.Add(this.logoutLinkLabel);
            this.logoutGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutGroupBox.Location = new System.Drawing.Point(0, 0);
            this.logoutGroupBox.Name = "logoutGroupBox";
            this.logoutGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutGroupBox.Size = new System.Drawing.Size(689, 51);
            this.logoutGroupBox.TabIndex = 9;
            this.logoutGroupBox.TabStop = false;
            this.logoutGroupBox.UseWaitCursor = true;
            // 
            // LogoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.logoutGroupBox);
            this.Name = "LogoutForm";
            this.Text = "LogoutForm";
            this.logoutGroupBox.ResumeLayout(false);
            this.logoutGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.GroupBox logoutGroupBox;
    }
}