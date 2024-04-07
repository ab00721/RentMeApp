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
            this.rentalSummaryInnerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.orderSummaryLabel = new System.Windows.Forms.Label();
            this.rentalSummaryDataGridView = new System.Windows.Forms.DataGridView();
            this.rentalSummaryTotalsTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.returnDateValueLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.transactionValueLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.rentalSummaryTableLayoutPanel.SuspendLayout();
            this.rentalSummaryInnerTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalSummaryDataGridView)).BeginInit();
            this.rentalSummaryTotalsTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentalSummaryTableLayoutPanel
            // 
            this.rentalSummaryTableLayoutPanel.ColumnCount = 1;
            this.rentalSummaryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rentalSummaryTableLayoutPanel.Controls.Add(this.rentalSummaryInnerTableLayoutPanel, 0, 2);
            this.rentalSummaryTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalSummaryTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.rentalSummaryTableLayoutPanel.Name = "rentalSummaryTableLayoutPanel";
            this.rentalSummaryTableLayoutPanel.RowCount = 4;
            this.rentalSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.rentalSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.rentalSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 700F));
            this.rentalSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rentalSummaryTableLayoutPanel.Size = new System.Drawing.Size(1178, 794);
            this.rentalSummaryTableLayoutPanel.TabIndex = 0;
            // 
            // rentalSummaryInnerTableLayoutPanel
            // 
            this.rentalSummaryInnerTableLayoutPanel.ColumnCount = 3;
            this.rentalSummaryInnerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.rentalSummaryInnerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.rentalSummaryInnerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.rentalSummaryInnerTableLayoutPanel.Controls.Add(this.orderSummaryLabel, 1, 0);
            this.rentalSummaryInnerTableLayoutPanel.Controls.Add(this.rentalSummaryDataGridView, 1, 1);
            this.rentalSummaryInnerTableLayoutPanel.Controls.Add(this.rentalSummaryTotalsTableLayoutPanel1, 1, 2);
            this.rentalSummaryInnerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalSummaryInnerTableLayoutPanel.Location = new System.Drawing.Point(3, 203);
            this.rentalSummaryInnerTableLayoutPanel.Name = "rentalSummaryInnerTableLayoutPanel";
            this.rentalSummaryInnerTableLayoutPanel.RowCount = 4;
            this.rentalSummaryInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.rentalSummaryInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.rentalSummaryInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.rentalSummaryInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rentalSummaryInnerTableLayoutPanel.Size = new System.Drawing.Size(1172, 694);
            this.rentalSummaryInnerTableLayoutPanel.TabIndex = 0;
            // 
            // orderSummaryLabel
            // 
            this.orderSummaryLabel.AutoSize = true;
            this.orderSummaryLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.orderSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSummaryLabel.Location = new System.Drawing.Point(61, 0);
            this.orderSummaryLabel.Name = "orderSummaryLabel";
            this.orderSummaryLabel.Size = new System.Drawing.Size(175, 70);
            this.orderSummaryLabel.TabIndex = 0;
            this.orderSummaryLabel.Text = "Order Summary";
            this.orderSummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rentalSummaryDataGridView
            // 
            this.rentalSummaryDataGridView.AllowUserToAddRows = false;
            this.rentalSummaryDataGridView.AllowUserToDeleteRows = false;
            this.rentalSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalSummaryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalSummaryDataGridView.Location = new System.Drawing.Point(61, 73);
            this.rentalSummaryDataGridView.Name = "rentalSummaryDataGridView";
            this.rentalSummaryDataGridView.ReadOnly = true;
            this.rentalSummaryDataGridView.RowHeadersWidth = 62;
            this.rentalSummaryDataGridView.RowTemplate.Height = 28;
            this.rentalSummaryDataGridView.Size = new System.Drawing.Size(1048, 244);
            this.rentalSummaryDataGridView.TabIndex = 1;
            // 
            // rentalSummaryTotalsTableLayoutPanel1
            // 
            this.rentalSummaryTotalsTableLayoutPanel1.ColumnCount = 3;
            this.rentalSummaryTotalsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.rentalSummaryTotalsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.rentalSummaryTotalsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.returnDateLabel, 1, 0);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.returnDateValueLabel, 2, 0);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.totalLabel, 1, 1);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.totalValueLabel, 2, 1);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.transactionLabel, 1, 2);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.transactionValueLabel, 2, 2);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.closeButton, 2, 3);
            this.rentalSummaryTotalsTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalSummaryTotalsTableLayoutPanel1.Location = new System.Drawing.Point(61, 323);
            this.rentalSummaryTotalsTableLayoutPanel1.Name = "rentalSummaryTotalsTableLayoutPanel1";
            this.rentalSummaryTotalsTableLayoutPanel1.RowCount = 4;
            this.rentalSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rentalSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rentalSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rentalSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rentalSummaryTotalsTableLayoutPanel1.Size = new System.Drawing.Size(1048, 244);
            this.rentalSummaryTotalsTableLayoutPanel1.TabIndex = 2;
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLabel.Location = new System.Drawing.Point(422, 0);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(308, 61);
            this.returnDateLabel.TabIndex = 0;
            this.returnDateLabel.Text = "Return Date:";
            this.returnDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // returnDateValueLabel
            // 
            this.returnDateValueLabel.AutoSize = true;
            this.returnDateValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnDateValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateValueLabel.Location = new System.Drawing.Point(736, 0);
            this.returnDateValueLabel.Name = "returnDateValueLabel";
            this.returnDateValueLabel.Size = new System.Drawing.Size(309, 61);
            this.returnDateValueLabel.TabIndex = 1;
            this.returnDateValueLabel.Text = "1970-01-01";
            this.returnDateValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(422, 61);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(308, 61);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValueLabel.Location = new System.Drawing.Point(736, 61);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(309, 61);
            this.totalValueLabel.TabIndex = 3;
            this.totalValueLabel.Text = "$0.00";
            this.totalValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionLabel.Location = new System.Drawing.Point(422, 122);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(308, 61);
            this.transactionLabel.TabIndex = 4;
            this.transactionLabel.Text = "Return Transaction ID:";
            this.transactionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transactionValueLabel
            // 
            this.transactionValueLabel.AutoSize = true;
            this.transactionValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionValueLabel.Location = new System.Drawing.Point(736, 122);
            this.transactionValueLabel.Name = "transactionValueLabel";
            this.transactionValueLabel.Size = new System.Drawing.Size(309, 61);
            this.transactionValueLabel.TabIndex = 5;
            this.transactionValueLabel.Text = "0";
            this.transactionValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(736, 186);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(309, 55);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RentalSummaryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 794);
            this.Controls.Add(this.rentalSummaryTableLayoutPanel);
            this.MinimizeBox = false;
            this.Name = "RentalSummaryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalSummaryDialog";
            this.rentalSummaryTableLayoutPanel.ResumeLayout(false);
            this.rentalSummaryInnerTableLayoutPanel.ResumeLayout(false);
            this.rentalSummaryInnerTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalSummaryDataGridView)).EndInit();
            this.rentalSummaryTotalsTableLayoutPanel1.ResumeLayout(false);
            this.rentalSummaryTotalsTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rentalSummaryTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel rentalSummaryInnerTableLayoutPanel;
        private System.Windows.Forms.Label orderSummaryLabel;
        private System.Windows.Forms.DataGridView rentalSummaryDataGridView;
        private System.Windows.Forms.TableLayoutPanel rentalSummaryTotalsTableLayoutPanel1;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.Label returnDateValueLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Label transactionValueLabel;
        private System.Windows.Forms.Button closeButton;
    }
}