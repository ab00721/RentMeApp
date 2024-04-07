namespace RentMeApp.View
{
    partial class RentalSummaryDialog
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
            this.rentalSummaryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // rentalSummaryTableLayoutPanel
            // 
            this.rentalSummaryTableLayoutPanel.ColumnCount = 1;
            this.rentalSummaryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rentalSummaryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rentalSummaryTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalSummaryTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.rentalSummaryTableLayoutPanel.Name = "rentalSummaryTableLayoutPanel";
            this.rentalSummaryTableLayoutPanel.RowCount = 4;
            this.rentalSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.rentalSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.rentalSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.rentalSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rentalSummaryTableLayoutPanel.Size = new System.Drawing.Size(1178, 744);
            this.rentalSummaryTableLayoutPanel.TabIndex = 0;
            // 
            // RentalSummaryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.rentalSummaryTableLayoutPanel);
            this.MinimizeBox = false;
            this.Name = "RentalSummaryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalSummaryDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rentalSummaryTableLayoutPanel;
    }
}