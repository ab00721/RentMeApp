namespace RentMeApp.View
{
    partial class CheckedOutFurnitureDialog
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
            this.checkedOutDataGridView = new System.Windows.Forms.DataGridView();
            this.checkedOutTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.checkedOutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checkedOutDataGridView)).BeginInit();
            this.checkedOutTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedOutDataGridView
            // 
            this.checkedOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkedOutDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedOutDataGridView.Location = new System.Drawing.Point(3, 32);
            this.checkedOutDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedOutDataGridView.Name = "checkedOutDataGridView";
            this.checkedOutDataGridView.RowHeadersWidth = 62;
            this.checkedOutDataGridView.RowTemplate.Height = 24;
            this.checkedOutDataGridView.Size = new System.Drawing.Size(794, 416);
            this.checkedOutDataGridView.TabIndex = 13;
            // 
            // checkedOutTableLayoutPanel
            // 
            this.checkedOutTableLayoutPanel.ColumnCount = 1;
            this.checkedOutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.checkedOutTableLayoutPanel.Controls.Add(this.checkedOutDataGridView, 0, 1);
            this.checkedOutTableLayoutPanel.Controls.Add(this.checkedOutLabel, 0, 0);
            this.checkedOutTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedOutTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.checkedOutTableLayoutPanel.Name = "checkedOutTableLayoutPanel";
            this.checkedOutTableLayoutPanel.RowCount = 2;
            this.checkedOutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.checkedOutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.33334F));
            this.checkedOutTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.checkedOutTableLayoutPanel.TabIndex = 14;
            // 
            // checkedOutLabel
            // 
            this.checkedOutLabel.AutoSize = true;
            this.checkedOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedOutLabel.Location = new System.Drawing.Point(3, 0);
            this.checkedOutLabel.Name = "checkedOutLabel";
            this.checkedOutLabel.Size = new System.Drawing.Size(175, 20);
            this.checkedOutLabel.TabIndex = 14;
            this.checkedOutLabel.Text = "Checked Out Items:";
            // 
            // CheckedOutFurnitureDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedOutTableLayoutPanel);
            this.Name = "CheckedOutFurnitureDialog";
            this.Text = "CheckedOutFurnitureDialog";
            ((System.ComponentModel.ISupportInitialize)(this.checkedOutDataGridView)).EndInit();
            this.checkedOutTableLayoutPanel.ResumeLayout(false);
            this.checkedOutTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView checkedOutDataGridView;
        private System.Windows.Forms.TableLayoutPanel checkedOutTableLayoutPanel;
        private System.Windows.Forms.Label checkedOutLabel;
    }
}