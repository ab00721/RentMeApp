namespace RentMeApp.View
{
    partial class TransactionsDialog
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
            this.userTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TransactionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RentalTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RentalLabel = new System.Windows.Forms.Label();
            this.RentalTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.TransactionTableLayout.SuspendLayout();
            this.RentalTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalTransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userTableLayoutPanel
            // 
            this.userTableLayoutPanel.ColumnCount = 1;
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userTableLayoutPanel.Location = new System.Drawing.Point(2, 3);
            this.userTableLayoutPanel.Name = "userTableLayoutPanel";
            this.userTableLayoutPanel.RowCount = 1;
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.userTableLayoutPanel.Size = new System.Drawing.Size(868, 56);
            this.userTableLayoutPanel.TabIndex = 6;
            // 
            // TransactionTableLayout
            // 
            this.TransactionTableLayout.ColumnCount = 1;
            this.TransactionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TransactionTableLayout.Controls.Add(this.RentalTableLayout, 0, 0);
            this.TransactionTableLayout.Location = new System.Drawing.Point(2, 65);
            this.TransactionTableLayout.Name = "TransactionTableLayout";
            this.TransactionTableLayout.RowCount = 3;
            this.TransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TransactionTableLayout.Size = new System.Drawing.Size(868, 764);
            this.TransactionTableLayout.TabIndex = 7;
            // 
            // RentalTableLayout
            // 
            this.RentalTableLayout.ColumnCount = 1;
            this.RentalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RentalTableLayout.Controls.Add(this.RentalLabel, 0, 0);
            this.RentalTableLayout.Controls.Add(this.RentalTransactionDataGridView, 0, 1);
            this.RentalTableLayout.Location = new System.Drawing.Point(3, 3);
            this.RentalTableLayout.Name = "RentalTableLayout";
            this.RentalTableLayout.RowCount = 2;
            this.RentalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.064516F));
            this.RentalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.93549F));
            this.RentalTableLayout.Size = new System.Drawing.Size(862, 248);
            this.RentalTableLayout.TabIndex = 0;
            // 
            // RentalLabel
            // 
            this.RentalLabel.AutoSize = true;
            this.RentalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.RentalLabel.Location = new System.Drawing.Point(3, 0);
            this.RentalLabel.Name = "RentalLabel";
            this.RentalLabel.Size = new System.Drawing.Size(146, 17);
            this.RentalLabel.TabIndex = 0;
            this.RentalLabel.Text = "Rental Transations";
            // 
            // RentalTransactionDataGridView
            // 
            this.RentalTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalTransactionDataGridView.Location = new System.Drawing.Point(3, 23);
            this.RentalTransactionDataGridView.Name = "RentalTransactionDataGridView";
            this.RentalTransactionDataGridView.Size = new System.Drawing.Size(856, 222);
            this.RentalTransactionDataGridView.TabIndex = 1;
            // 
            // TransactionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 828);
            this.Controls.Add(this.TransactionTableLayout);
            this.Controls.Add(this.userTableLayoutPanel);
            this.Name = "TransactionsDialog";
            this.Text = "--";
            this.TransactionTableLayout.ResumeLayout(false);
            this.RentalTableLayout.ResumeLayout(false);
            this.RentalTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalTransactionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel userTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel TransactionTableLayout;
        private System.Windows.Forms.TableLayoutPanel RentalTableLayout;
        private System.Windows.Forms.Label RentalLabel;
        private System.Windows.Forms.DataGridView RentalTransactionDataGridView;
    }
}