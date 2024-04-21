namespace RentMeApp.View
{
    partial class ReturnSummaryDialog
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
            this.returnSummaryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.returnSummaryInnerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.orderSummaryLabel = new System.Windows.Forms.Label();
            this.returnSummaryDataGridView = new System.Windows.Forms.DataGridView();
            this.returnSummaryTotalsTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.transactionValueLabel = new System.Windows.Forms.Label();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.returnDateValueLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.returnSummaryTableLayoutPanel.SuspendLayout();
            this.returnSummaryInnerTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnSummaryDataGridView)).BeginInit();
            this.returnSummaryTotalsTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnSummaryTableLayoutPanel
            // 
            this.returnSummaryTableLayoutPanel.ColumnCount = 1;
            this.returnSummaryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.returnSummaryTableLayoutPanel.Controls.Add(this.returnSummaryInnerTableLayoutPanel, 0, 2);
            this.returnSummaryTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnSummaryTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.returnSummaryTableLayoutPanel.Name = "returnSummaryTableLayoutPanel";
            this.returnSummaryTableLayoutPanel.RowCount = 4;
            this.returnSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.returnSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.returnSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 750F));
            this.returnSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.returnSummaryTableLayoutPanel.Size = new System.Drawing.Size(1178, 844);
            this.returnSummaryTableLayoutPanel.TabIndex = 0;
            // 
            // returnSummaryInnerTableLayoutPanel
            // 
            this.returnSummaryInnerTableLayoutPanel.ColumnCount = 3;
            this.returnSummaryInnerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.returnSummaryInnerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.returnSummaryInnerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.returnSummaryInnerTableLayoutPanel.Controls.Add(this.orderSummaryLabel, 1, 0);
            this.returnSummaryInnerTableLayoutPanel.Controls.Add(this.returnSummaryDataGridView, 1, 1);
            this.returnSummaryInnerTableLayoutPanel.Controls.Add(this.returnSummaryTotalsTableLayoutPanel1, 1, 2);
            this.returnSummaryInnerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnSummaryInnerTableLayoutPanel.Location = new System.Drawing.Point(3, 203);
            this.returnSummaryInnerTableLayoutPanel.Name = "returnSummaryInnerTableLayoutPanel";
            this.returnSummaryInnerTableLayoutPanel.RowCount = 4;
            this.returnSummaryInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.returnSummaryInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.returnSummaryInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.returnSummaryInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.returnSummaryInnerTableLayoutPanel.Size = new System.Drawing.Size(1172, 744);
            this.returnSummaryInnerTableLayoutPanel.TabIndex = 0;
            // 
            // orderSummaryLabel
            // 
            this.orderSummaryLabel.AutoSize = true;
            this.orderSummaryLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.orderSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSummaryLabel.ForeColor = System.Drawing.Color.Green;
            this.orderSummaryLabel.Location = new System.Drawing.Point(61, 0);
            this.orderSummaryLabel.Name = "orderSummaryLabel";
            this.orderSummaryLabel.Size = new System.Drawing.Size(222, 70);
            this.orderSummaryLabel.TabIndex = 0;
            this.orderSummaryLabel.Text = "Return Confirmation";
            this.orderSummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // returnSummaryDataGridView
            // 
            this.returnSummaryDataGridView.AllowUserToAddRows = false;
            this.returnSummaryDataGridView.AllowUserToDeleteRows = false;
            this.returnSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnSummaryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnSummaryDataGridView.Location = new System.Drawing.Point(61, 73);
            this.returnSummaryDataGridView.Name = "returnSummaryDataGridView";
            this.returnSummaryDataGridView.ReadOnly = true;
            this.returnSummaryDataGridView.RowHeadersWidth = 62;
            this.returnSummaryDataGridView.RowTemplate.Height = 28;
            this.returnSummaryDataGridView.Size = new System.Drawing.Size(1048, 244);
            this.returnSummaryDataGridView.TabIndex = 1;
            // 
            // returnSummaryTotalsTableLayoutPanel1
            // 
            this.returnSummaryTotalsTableLayoutPanel1.ColumnCount = 3;
            this.returnSummaryTotalsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.returnSummaryTotalsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.returnSummaryTotalsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.returnSummaryTotalsTableLayoutPanel1.Controls.Add(this.transactionLabel, 1, 0);
            this.returnSummaryTotalsTableLayoutPanel1.Controls.Add(this.transactionValueLabel, 2, 0);
            this.returnSummaryTotalsTableLayoutPanel1.Controls.Add(this.returnDateLabel, 1, 1);
            this.returnSummaryTotalsTableLayoutPanel1.Controls.Add(this.returnDateValueLabel, 2, 1);
            this.returnSummaryTotalsTableLayoutPanel1.Controls.Add(this.totalLabel, 1, 4);
            this.returnSummaryTotalsTableLayoutPanel1.Controls.Add(this.totalValueLabel, 2, 4);
            this.returnSummaryTotalsTableLayoutPanel1.Controls.Add(this.closeButton, 2, 5);
            this.returnSummaryTotalsTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnSummaryTotalsTableLayoutPanel1.Location = new System.Drawing.Point(61, 323);
            this.returnSummaryTotalsTableLayoutPanel1.Name = "returnSummaryTotalsTableLayoutPanel1";
            this.returnSummaryTotalsTableLayoutPanel1.RowCount = 6;
            this.returnSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.returnSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.returnSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.returnSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.returnSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.returnSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.returnSummaryTotalsTableLayoutPanel1.Size = new System.Drawing.Size(1048, 294);
            this.returnSummaryTotalsTableLayoutPanel1.TabIndex = 2;
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionLabel.Location = new System.Drawing.Point(422, 0);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(308, 73);
            this.transactionLabel.TabIndex = 4;
            this.transactionLabel.Text = "Return Transaction ID:";
            this.transactionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transactionValueLabel
            // 
            this.transactionValueLabel.AutoSize = true;
            this.transactionValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionValueLabel.Location = new System.Drawing.Point(736, 0);
            this.transactionValueLabel.Name = "transactionValueLabel";
            this.transactionValueLabel.Size = new System.Drawing.Size(309, 73);
            this.transactionValueLabel.TabIndex = 5;
            this.transactionValueLabel.Text = "0";
            this.transactionValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLabel.Location = new System.Drawing.Point(422, 73);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(308, 73);
            this.returnDateLabel.TabIndex = 0;
            this.returnDateLabel.Text = "Return Date:";
            this.returnDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // returnDateValueLabel
            // 
            this.returnDateValueLabel.AutoSize = true;
            this.returnDateValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnDateValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateValueLabel.Location = new System.Drawing.Point(736, 73);
            this.returnDateValueLabel.Name = "returnDateValueLabel";
            this.returnDateValueLabel.Size = new System.Drawing.Size(309, 73);
            this.returnDateValueLabel.TabIndex = 1;
            this.returnDateValueLabel.Text = "1970-01-01";
            this.returnDateValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(422, 150);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(308, 73);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValueLabel.Location = new System.Drawing.Point(736, 150);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(309, 73);
            this.totalValueLabel.TabIndex = 3;
            this.totalValueLabel.Text = "$0.00";
            this.totalValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(736, 226);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(309, 65);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ReturnSummaryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.returnSummaryTableLayoutPanel);
            this.MinimizeBox = false;
            this.Name = "ReturnSummaryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnSummaryDialog";
            this.returnSummaryTableLayoutPanel.ResumeLayout(false);
            this.returnSummaryInnerTableLayoutPanel.ResumeLayout(false);
            this.returnSummaryInnerTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnSummaryDataGridView)).EndInit();
            this.returnSummaryTotalsTableLayoutPanel1.ResumeLayout(false);
            this.returnSummaryTotalsTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel returnSummaryTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel returnSummaryInnerTableLayoutPanel;
        private System.Windows.Forms.Label orderSummaryLabel;
        private System.Windows.Forms.DataGridView returnSummaryDataGridView;
        private System.Windows.Forms.TableLayoutPanel returnSummaryTotalsTableLayoutPanel1;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.Label returnDateValueLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Label transactionValueLabel;
        private System.Windows.Forms.Button closeButton;
    }
}