namespace RentMeApp.View
{
    partial class ReturnDialog
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
            this.returnTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.returnTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnTableLayoutPanel
            // 
            this.returnTableLayoutPanel.AutoScroll = true;
            this.returnTableLayoutPanel.ColumnCount = 1;
            this.returnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.returnTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.returnTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnTableLayoutPanel.Name = "returnTableLayoutPanel";
            this.returnTableLayoutPanel.RowCount = 4;
            this.returnTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.returnTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.returnTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.returnTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 416F));
            this.returnTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.returnTableLayoutPanel.Size = new System.Drawing.Size(870, 571);
            this.returnTableLayoutPanel.TabIndex = 1;
           
            // 
            // ReturnDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(870, 571);
            this.Controls.Add(this.returnTableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnDialog_FormClosing);
            this.Load += new System.EventHandler(this.ReturnDialog_Load);
            this.returnTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel returnTableLayoutPanel;
    }
}