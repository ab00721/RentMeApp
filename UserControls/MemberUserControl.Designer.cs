namespace RentMeApp.UserControls
{
    partial class MemberUserControl
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
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.memberTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.memberTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(2, 31);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 17);
            this.idLabel.TabIndex = 9;
            this.idLabel.Text = "id";
            this.idLabel.UseWaitCursor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(2, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 17);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "name";
            this.nameLabel.UseWaitCursor = true;
            // 
            // memberTableLayoutPanel
            // 
            this.memberTableLayoutPanel.ColumnCount = 2;
            this.memberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.84496F));
            this.memberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.15504F));
            this.memberTableLayoutPanel.Controls.Add(this.idLabel, 0, 1);
            this.memberTableLayoutPanel.Controls.Add(this.nameLabel, 0, 0);
            this.memberTableLayoutPanel.Controls.Add(this.phoneLabel, 1, 0);
            this.memberTableLayoutPanel.Controls.Add(this.addressLabel, 1, 1);
            this.memberTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.memberTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.memberTableLayoutPanel.Name = "memberTableLayoutPanel";
            this.memberTableLayoutPanel.RowCount = 2;
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.memberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.memberTableLayoutPanel.Size = new System.Drawing.Size(645, 56);
            this.memberTableLayoutPanel.TabIndex = 1;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(260, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(50, 16);
            this.phoneLabel.TabIndex = 11;
            this.phoneLabel.Text = "phone";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(260, 31);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(64, 16);
            this.addressLabel.TabIndex = 12;
            this.addressLabel.Text = "address";
            // 
            // MemberUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memberTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MemberUserControl";
            this.Size = new System.Drawing.Size(645, 56);
            this.memberTableLayoutPanel.ResumeLayout(false);
            this.memberTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TableLayoutPanel memberTableLayoutPanel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
    }
}
