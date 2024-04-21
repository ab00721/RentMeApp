namespace RentMeApp.UserControls
{
    partial class CheckedOutUserControl
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
            this.checkedOutDataGridView = new System.Windows.Forms.DataGridView();
            this.checkedOutLabel = new System.Windows.Forms.Label();
            this.checkedOutTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.checkedOutDataGridView)).BeginInit();
            this.checkedOutTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedOutDataGridView
            // 
            this.checkedOutDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.checkedOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkedOutDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedOutDataGridView.Location = new System.Drawing.Point(3, 42);
            this.checkedOutDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedOutDataGridView.Name = "checkedOutDataGridView";
            this.checkedOutDataGridView.ReadOnly = true;
            this.checkedOutDataGridView.RowHeadersWidth = 62;
            this.checkedOutDataGridView.RowTemplate.Height = 24;
            this.checkedOutDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.checkedOutDataGridView.Size = new System.Drawing.Size(995, 226);
            this.checkedOutDataGridView.TabIndex = 13;
            // 
            // checkedOutLabel
            // 
            this.checkedOutLabel.AutoSize = true;
            this.checkedOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedOutLabel.Location = new System.Drawing.Point(3, 0);
            this.checkedOutLabel.Name = "checkedOutLabel";
            this.checkedOutLabel.Size = new System.Drawing.Size(218, 25);
            this.checkedOutLabel.TabIndex = 14;
            this.checkedOutLabel.Text = "Checked Out Items:";
            // 
            // checkedOutTableLayoutPanel
            // 
            this.checkedOutTableLayoutPanel.ColumnCount = 1;
            this.checkedOutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.checkedOutTableLayoutPanel.Controls.Add(this.checkedOutDataGridView, 0, 1);
            this.checkedOutTableLayoutPanel.Controls.Add(this.checkedOutLabel, 0, 0);
            this.checkedOutTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedOutTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.checkedOutTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedOutTableLayoutPanel.Name = "checkedOutTableLayoutPanel";
            this.checkedOutTableLayoutPanel.RowCount = 2;
            this.checkedOutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.checkedOutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.checkedOutTableLayoutPanel.Size = new System.Drawing.Size(1001, 270);
            this.checkedOutTableLayoutPanel.TabIndex = 0;
            // 
            // CheckedOutUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedOutTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CheckedOutUserControl";
            this.Size = new System.Drawing.Size(1001, 270);
            this.Load += new System.EventHandler(this.CheckedOutUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkedOutDataGridView)).EndInit();
            this.checkedOutTableLayoutPanel.ResumeLayout(false);
            this.checkedOutTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.DataGridView checkedOutDataGridView;
        private System.Windows.Forms.Label checkedOutLabel;
        private System.Windows.Forms.TableLayoutPanel checkedOutTableLayoutPanel;
    }
}
