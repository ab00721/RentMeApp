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
            this.RentalTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.RentalLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ReturnTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.ReturnLabel = new System.Windows.Forms.Label();
            this.TransactionTableLayout.SuspendLayout();
            this.RentalTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalTransactionDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnTransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userTableLayoutPanel
            // 
            this.userTableLayoutPanel.ColumnCount = 1;
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userTableLayoutPanel.Location = new System.Drawing.Point(3, 5);
            this.userTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userTableLayoutPanel.Name = "userTableLayoutPanel";
            this.userTableLayoutPanel.RowCount = 1;
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.userTableLayoutPanel.Size = new System.Drawing.Size(1168, 86);
            this.userTableLayoutPanel.TabIndex = 6;
            // 
            // TransactionTableLayout
            // 
            this.TransactionTableLayout.ColumnCount = 1;
            this.TransactionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TransactionTableLayout.Controls.Add(this.RentalTableLayout, 0, 1);
            this.TransactionTableLayout.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.TransactionTableLayout.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.TransactionTableLayout.Location = new System.Drawing.Point(3, 100);
            this.TransactionTableLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransactionTableLayout.Name = "TransactionTableLayout";
            this.TransactionTableLayout.RowCount = 5;
            this.TransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0012F));
            this.TransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.66287F));
            this.TransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.66287F));
            this.TransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.67287F));
            this.TransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.0002F));
            this.TransactionTableLayout.Size = new System.Drawing.Size(1168, 760);
            this.TransactionTableLayout.TabIndex = 7;
            // 
            // RentalTableLayout
            // 
            this.RentalTableLayout.ColumnCount = 1;
            this.RentalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RentalTableLayout.Controls.Add(this.RentalTransactionDataGridView, 0, 1);
            this.RentalTableLayout.Controls.Add(this.RentalLabel, 0, 0);
            this.RentalTableLayout.Location = new System.Drawing.Point(4, 96);
            this.RentalTableLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RentalTableLayout.Name = "RentalTableLayout";
            this.RentalTableLayout.RowCount = 2;
            this.RentalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.064516F));
            this.RentalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.93549F));
            this.RentalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.RentalTableLayout.Size = new System.Drawing.Size(1160, 207);
            this.RentalTableLayout.TabIndex = 0;
            // 
            // RentalTransactionDataGridView
            // 
            this.RentalTransactionDataGridView.AllowUserToDeleteRows = false;
            this.RentalTransactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RentalTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalTransactionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentalTransactionDataGridView.Location = new System.Drawing.Point(30, 19);
            this.RentalTransactionDataGridView.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.RentalTransactionDataGridView.Name = "RentalTransactionDataGridView";
            this.RentalTransactionDataGridView.ReadOnly = true;
            this.RentalTransactionDataGridView.RowHeadersWidth = 62;
            this.RentalTransactionDataGridView.RowTemplate.Height = 24;
            this.RentalTransactionDataGridView.Size = new System.Drawing.Size(1100, 185);
            this.RentalTransactionDataGridView.TabIndex = 13;
            this.RentalTransactionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalTransactionDataGridView_CellContentClick);
            // 
            // RentalLabel
            // 
            this.RentalLabel.AutoSize = true;
            this.RentalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.RentalLabel.Location = new System.Drawing.Point(30, 0);
            this.RentalLabel.Margin = new System.Windows.Forms.Padding(30, 0, 4, 0);
            this.RentalLabel.Name = "RentalLabel";
            this.RentalLabel.Size = new System.Drawing.Size(146, 16);
            this.RentalLabel.TabIndex = 0;
            this.RentalLabel.Text = "Rental Transations";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DetailsDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DetailsLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 530);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 207);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // DetailsDataGridView
            // 
            this.DetailsDataGridView.AllowUserToDeleteRows = false;
            this.DetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsDataGridView.Location = new System.Drawing.Point(30, 23);
            this.DetailsDataGridView.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.DetailsDataGridView.Name = "DetailsDataGridView";
            this.DetailsDataGridView.ReadOnly = true;
            this.DetailsDataGridView.RowHeadersWidth = 62;
            this.DetailsDataGridView.RowTemplate.Height = 24;
            this.DetailsDataGridView.Size = new System.Drawing.Size(1100, 181);
            this.DetailsDataGridView.TabIndex = 14;
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.DetailsLabel.Location = new System.Drawing.Point(30, 0);
            this.DetailsLabel.Margin = new System.Windows.Forms.Padding(30, 0, 4, 0);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(58, 17);
            this.DetailsLabel.TabIndex = 1;
            this.DetailsLabel.Text = "Details";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ReturnTransactionDataGridView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ReturnLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 313);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1160, 207);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // ReturnTransactionDataGridView
            // 
            this.ReturnTransactionDataGridView.AllowUserToDeleteRows = false;
            this.ReturnTransactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReturnTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnTransactionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReturnTransactionDataGridView.Location = new System.Drawing.Point(30, 23);
            this.ReturnTransactionDataGridView.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.ReturnTransactionDataGridView.Name = "ReturnTransactionDataGridView";
            this.ReturnTransactionDataGridView.ReadOnly = true;
            this.ReturnTransactionDataGridView.RowHeadersWidth = 62;
            this.ReturnTransactionDataGridView.RowTemplate.Height = 24;
            this.ReturnTransactionDataGridView.Size = new System.Drawing.Size(1100, 181);
            this.ReturnTransactionDataGridView.TabIndex = 14;
            this.ReturnTransactionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReturnTransactionDataGridView_CellContentClick);
            // 
            // ReturnLabel
            // 
            this.ReturnLabel.AutoSize = true;
            this.ReturnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ReturnLabel.Location = new System.Drawing.Point(30, 0);
            this.ReturnLabel.Margin = new System.Windows.Forms.Padding(30, 0, 4, 0);
            this.ReturnLabel.Name = "ReturnLabel";
            this.ReturnLabel.Size = new System.Drawing.Size(148, 17);
            this.ReturnLabel.TabIndex = 1;
            this.ReturnLabel.Text = "Return Transations";
            // 
            // TransactionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1172, 941);
            this.Controls.Add(this.TransactionTableLayout);
            this.Controls.Add(this.userTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Transactions";
            this.TransactionTableLayout.ResumeLayout(false);
            this.RentalTableLayout.ResumeLayout(false);
            this.RentalTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalTransactionDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnTransactionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel userTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel TransactionTableLayout;
        private System.Windows.Forms.TableLayoutPanel RentalTableLayout;
        private System.Windows.Forms.Label RentalLabel;
        private System.Windows.Forms.DataGridView RentalTransactionDataGridView;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DetailsDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView ReturnTransactionDataGridView;
        private System.Windows.Forms.Label ReturnLabel;
    }
}