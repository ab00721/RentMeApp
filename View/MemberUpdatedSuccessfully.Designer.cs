namespace RentMeApp.View
{
    partial class MemberUpdatedSuccessfully
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
            this.SuccessMessageLabel = new System.Windows.Forms.Label();
            this.MeemberIdLabel = new System.Windows.Forms.Label();
            this.MemberId = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SuccessMessageLabel
            // 
            this.SuccessMessageLabel.AutoSize = true;
            this.SuccessMessageLabel.Location = new System.Drawing.Point(118, 62);
            this.SuccessMessageLabel.Name = "SuccessMessageLabel";
            this.SuccessMessageLabel.Size = new System.Drawing.Size(150, 13);
            this.SuccessMessageLabel.TabIndex = 0;
            this.SuccessMessageLabel.Text = "Member Updated Successfully!";
            // 
            // MeemberIdLabel
            // 
            this.MeemberIdLabel.AutoSize = true;
            this.MeemberIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeemberIdLabel.Location = new System.Drawing.Point(135, 84);
            this.MeemberIdLabel.Name = "MeemberIdLabel";
            this.MeemberIdLabel.Size = new System.Drawing.Size(72, 13);
            this.MeemberIdLabel.TabIndex = 1;
            this.MeemberIdLabel.Text = "Member ID:";
            // 
            // MemberId
            // 
            this.MemberId.AutoSize = true;
            this.MemberId.Location = new System.Drawing.Point(208, 84);
            this.MemberId.Name = "MemberId";
            this.MemberId.Size = new System.Drawing.Size(0, 13);
            this.MemberId.TabIndex = 2;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(304, 161);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // MemberUpdatedSuccessfully
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 196);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.MemberId);
            this.Controls.Add(this.MeemberIdLabel);
            this.Controls.Add(this.SuccessMessageLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberUpdatedSuccessfully";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Updated Successfully";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemberUpdatedSuccessfully_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SuccessMessageLabel;
        private System.Windows.Forms.Label MeemberIdLabel;
        private System.Windows.Forms.Label MemberId;
        private System.Windows.Forms.Button OK;
    }
}