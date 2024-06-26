﻿namespace RentMeApp.View
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
            this.transactionLabel = new System.Windows.Forms.Label();
            this.transactionValueLabel = new System.Windows.Forms.Label();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.returnDateValueLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.pricePerDayLabel = new System.Windows.Forms.Label();
            this.pricePerDayValueLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationValueLabel = new System.Windows.Forms.Label();
            this.rentalDateLabel = new System.Windows.Forms.Label();
            this.rentalDateValueLabel = new System.Windows.Forms.Label();
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
            this.rentalSummaryTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentalSummaryTableLayoutPanel.Name = "rentalSummaryTableLayoutPanel";
            this.rentalSummaryTableLayoutPanel.RowCount = 4;
            this.rentalSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.rentalSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.rentalSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.rentalSummaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.rentalSummaryTableLayoutPanel.Size = new System.Drawing.Size(1047, 675);
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
            this.rentalSummaryInnerTableLayoutPanel.Location = new System.Drawing.Point(3, 162);
            this.rentalSummaryInnerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentalSummaryInnerTableLayoutPanel.Name = "rentalSummaryInnerTableLayoutPanel";
            this.rentalSummaryInnerTableLayoutPanel.RowCount = 4;
            this.rentalSummaryInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.rentalSummaryInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.rentalSummaryInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            this.rentalSummaryInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rentalSummaryInnerTableLayoutPanel.Size = new System.Drawing.Size(1041, 596);
            this.rentalSummaryInnerTableLayoutPanel.TabIndex = 0;
            // 
            // orderSummaryLabel
            // 
            this.orderSummaryLabel.AutoSize = true;
            this.orderSummaryLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.orderSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSummaryLabel.ForeColor = System.Drawing.Color.Green;
            this.orderSummaryLabel.Location = new System.Drawing.Point(55, 0);
            this.orderSummaryLabel.Name = "orderSummaryLabel";
            this.orderSummaryLabel.Size = new System.Drawing.Size(176, 56);
            this.orderSummaryLabel.TabIndex = 0;
            this.orderSummaryLabel.Text = "Rental Confirmation";
            this.orderSummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rentalSummaryDataGridView
            // 
            this.rentalSummaryDataGridView.AllowUserToAddRows = false;
            this.rentalSummaryDataGridView.AllowUserToDeleteRows = false;
            this.rentalSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalSummaryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalSummaryDataGridView.Location = new System.Drawing.Point(55, 58);
            this.rentalSummaryDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentalSummaryDataGridView.Name = "rentalSummaryDataGridView";
            this.rentalSummaryDataGridView.ReadOnly = true;
            this.rentalSummaryDataGridView.RowHeadersWidth = 62;
            this.rentalSummaryDataGridView.RowTemplate.Height = 28;
            this.rentalSummaryDataGridView.Size = new System.Drawing.Size(930, 162);
            this.rentalSummaryDataGridView.TabIndex = 1;
            // 
            // rentalSummaryTotalsTableLayoutPanel1
            // 
            this.rentalSummaryTotalsTableLayoutPanel1.ColumnCount = 3;
            this.rentalSummaryTotalsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.rentalSummaryTotalsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.rentalSummaryTotalsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.rentalDateValueLabel, 2, 1);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.rentalDateLabel, 1, 1);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.transactionLabel, 1, 0);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.transactionValueLabel, 2, 0);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.returnDateLabel, 1, 2);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.returnDateValueLabel, 2, 2);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.totalLabel, 1, 5);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.totalValueLabel, 2, 5);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.closeButton, 2, 6);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.pricePerDayLabel, 1, 3);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.pricePerDayValueLabel, 2, 3);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.durationLabel, 1, 4);
            this.rentalSummaryTotalsTableLayoutPanel1.Controls.Add(this.durationValueLabel, 2, 4);
            this.rentalSummaryTotalsTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalSummaryTotalsTableLayoutPanel1.Location = new System.Drawing.Point(55, 224);
            this.rentalSummaryTotalsTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentalSummaryTotalsTableLayoutPanel1.Name = "rentalSummaryTotalsTableLayoutPanel1";
            this.rentalSummaryTotalsTableLayoutPanel1.RowCount = 7;
            this.rentalSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.rentalSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.rentalSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.rentalSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.rentalSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.rentalSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.rentalSummaryTotalsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.rentalSummaryTotalsTableLayoutPanel1.Size = new System.Drawing.Size(930, 270);
            this.rentalSummaryTotalsTableLayoutPanel1.TabIndex = 2;
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionLabel.Location = new System.Drawing.Point(375, 0);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(273, 36);
            this.transactionLabel.TabIndex = 4;
            this.transactionLabel.Text = "Return Transaction ID:";
            this.transactionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transactionValueLabel
            // 
            this.transactionValueLabel.AutoSize = true;
            this.transactionValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionValueLabel.Location = new System.Drawing.Point(654, 0);
            this.transactionValueLabel.Name = "transactionValueLabel";
            this.transactionValueLabel.Size = new System.Drawing.Size(273, 36);
            this.transactionValueLabel.TabIndex = 5;
            this.transactionValueLabel.Text = "0";
            this.transactionValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLabel.Location = new System.Drawing.Point(375, 72);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(273, 36);
            this.returnDateLabel.TabIndex = 0;
            this.returnDateLabel.Text = "Return Date:";
            this.returnDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // returnDateValueLabel
            // 
            this.returnDateValueLabel.AutoSize = true;
            this.returnDateValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnDateValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateValueLabel.Location = new System.Drawing.Point(654, 72);
            this.returnDateValueLabel.Name = "returnDateValueLabel";
            this.returnDateValueLabel.Size = new System.Drawing.Size(273, 36);
            this.returnDateValueLabel.TabIndex = 1;
            this.returnDateValueLabel.Text = "1970-01-01";
            this.returnDateValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(375, 180);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(273, 45);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValueLabel.Location = new System.Drawing.Point(654, 180);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(273, 45);
            this.totalValueLabel.TabIndex = 3;
            this.totalValueLabel.Text = "$0.00";
            this.totalValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(654, 227);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(273, 41);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pricePerDayLabel
            // 
            this.pricePerDayLabel.AutoSize = true;
            this.pricePerDayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pricePerDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerDayLabel.Location = new System.Drawing.Point(375, 108);
            this.pricePerDayLabel.Name = "pricePerDayLabel";
            this.pricePerDayLabel.Size = new System.Drawing.Size(273, 36);
            this.pricePerDayLabel.TabIndex = 7;
            this.pricePerDayLabel.Text = "Price Per Day:";
            this.pricePerDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pricePerDayValueLabel
            // 
            this.pricePerDayValueLabel.AutoSize = true;
            this.pricePerDayValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pricePerDayValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerDayValueLabel.Location = new System.Drawing.Point(654, 108);
            this.pricePerDayValueLabel.Name = "pricePerDayValueLabel";
            this.pricePerDayValueLabel.Size = new System.Drawing.Size(273, 36);
            this.pricePerDayValueLabel.TabIndex = 8;
            this.pricePerDayValueLabel.Text = "$0.00";
            this.pricePerDayValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.Location = new System.Drawing.Point(375, 144);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(273, 36);
            this.durationLabel.TabIndex = 9;
            this.durationLabel.Text = "Rental Duration (Days):";
            this.durationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // durationValueLabel
            // 
            this.durationValueLabel.AutoSize = true;
            this.durationValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durationValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationValueLabel.Location = new System.Drawing.Point(654, 144);
            this.durationValueLabel.Name = "durationValueLabel";
            this.durationValueLabel.Size = new System.Drawing.Size(273, 36);
            this.durationValueLabel.TabIndex = 10;
            this.durationValueLabel.Text = "0";
            this.durationValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rentalDateLabel
            // 
            this.rentalDateLabel.AutoSize = true;
            this.rentalDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateLabel.Location = new System.Drawing.Point(375, 36);
            this.rentalDateLabel.Name = "rentalDateLabel";
            this.rentalDateLabel.Size = new System.Drawing.Size(273, 36);
            this.rentalDateLabel.TabIndex = 11;
            this.rentalDateLabel.Text = "Rental Date:";
            this.rentalDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rentalDateValueLabel
            // 
            this.rentalDateValueLabel.AutoSize = true;
            this.rentalDateValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalDateValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateValueLabel.Location = new System.Drawing.Point(654, 36);
            this.rentalDateValueLabel.Name = "rentalDateValueLabel";
            this.rentalDateValueLabel.Size = new System.Drawing.Size(273, 36);
            this.rentalDateValueLabel.TabIndex = 12;
            this.rentalDateValueLabel.Text = "1970-01-01";
            this.rentalDateValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RentalSummaryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 675);
            this.Controls.Add(this.rentalSummaryTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label pricePerDayLabel;
        private System.Windows.Forms.Label pricePerDayValueLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label durationValueLabel;
        private System.Windows.Forms.Label rentalDateValueLabel;
        private System.Windows.Forms.Label rentalDateLabel;
    }
}