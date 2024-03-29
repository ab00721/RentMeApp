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
            this.MemberInfoTabelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MemberIdLabel = new System.Windows.Forms.Label();
            this.MemberNameInfoLabel = new System.Windows.Forms.Label();
            this.MemberIdInfoLabel = new System.Windows.Forms.Label();
            this.MemberNameLabel = new System.Windows.Forms.Label();
            this.TransactionTableLayout.SuspendLayout();
            this.RentalTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalTransactionDataGridView)).BeginInit();
            this.MemberInfoTabelLayout.SuspendLayout();
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
            this.TransactionTableLayout.Controls.Add(this.RentalTableLayout, 0, 1);
            this.TransactionTableLayout.Controls.Add(this.MemberInfoTabelLayout, 0, 0);
            this.TransactionTableLayout.Location = new System.Drawing.Point(2, 65);
            this.TransactionTableLayout.Name = "TransactionTableLayout";
            this.TransactionTableLayout.RowCount = 4;
            this.TransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TransactionTableLayout.Size = new System.Drawing.Size(868, 764);
            this.TransactionTableLayout.TabIndex = 7;
            // 
            // RentalTableLayout
            // 
            this.RentalTableLayout.ColumnCount = 1;
            this.RentalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RentalTableLayout.Controls.Add(this.RentalLabel, 0, 0);
            this.RentalTableLayout.Controls.Add(this.RentalTransactionDataGridView, 0, 1);
            this.RentalTableLayout.Location = new System.Drawing.Point(3, 79);
            this.RentalTableLayout.Name = "RentalTableLayout";
            this.RentalTableLayout.RowCount = 2;
            this.RentalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.064516F));
            this.RentalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.93549F));
            this.RentalTableLayout.Size = new System.Drawing.Size(862, 223);
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
            this.RentalTransactionDataGridView.Location = new System.Drawing.Point(3, 20);
            this.RentalTransactionDataGridView.Name = "RentalTransactionDataGridView";
            this.RentalTransactionDataGridView.Size = new System.Drawing.Size(856, 200);
            this.RentalTransactionDataGridView.TabIndex = 1;
            // 
            // MemberInfoTabelLayout
            // 
            this.MemberInfoTabelLayout.ColumnCount = 2;
            this.MemberInfoTabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MemberInfoTabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.MemberInfoTabelLayout.Controls.Add(this.MemberIdLabel, 0, 0);
            this.MemberInfoTabelLayout.Controls.Add(this.MemberNameInfoLabel, 1, 1);
            this.MemberInfoTabelLayout.Controls.Add(this.MemberIdInfoLabel, 1, 0);
            this.MemberInfoTabelLayout.Controls.Add(this.MemberNameLabel, 0, 1);
            this.MemberInfoTabelLayout.Location = new System.Drawing.Point(3, 3);
            this.MemberInfoTabelLayout.Name = "MemberInfoTabelLayout";
            this.MemberInfoTabelLayout.RowCount = 2;
            this.MemberInfoTabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MemberInfoTabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MemberInfoTabelLayout.Size = new System.Drawing.Size(862, 70);
            this.MemberInfoTabelLayout.TabIndex = 8;
            // 
            // MemberIdLabel
            // 
            this.MemberIdLabel.AutoSize = true;
            this.MemberIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.MemberIdLabel.Location = new System.Drawing.Point(3, 0);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Size = new System.Drawing.Size(90, 17);
            this.MemberIdLabel.TabIndex = 0;
            this.MemberIdLabel.Text = "Member ID:";
            // 
            // MemberNameInfoLabel
            // 
            this.MemberNameInfoLabel.AutoSize = true;
            this.MemberNameInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.MemberNameInfoLabel.Location = new System.Drawing.Point(132, 35);
            this.MemberNameInfoLabel.Name = "MemberNameInfoLabel";
            this.MemberNameInfoLabel.Size = new System.Drawing.Size(0, 17);
            this.MemberNameInfoLabel.TabIndex = 3;
            // 
            // MemberIdInfoLabel
            // 
            this.MemberIdInfoLabel.AutoSize = true;
            this.MemberIdInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.MemberIdInfoLabel.Location = new System.Drawing.Point(132, 0);
            this.MemberIdInfoLabel.Name = "MemberIdInfoLabel";
            this.MemberIdInfoLabel.Size = new System.Drawing.Size(0, 17);
            this.MemberIdInfoLabel.TabIndex = 2;
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.AutoSize = true;
            this.MemberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.MemberNameLabel.Location = new System.Drawing.Point(3, 35);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(116, 17);
            this.MemberNameLabel.TabIndex = 1;
            this.MemberNameLabel.Text = "Member Name:";
            // 
            // TransactionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 828);
            this.Controls.Add(this.TransactionTableLayout);
            this.Controls.Add(this.userTableLayoutPanel);
            this.Name = "TransactionsDialog";
            this.Text = "View Transactions";
            this.TransactionTableLayout.ResumeLayout(false);
            this.RentalTableLayout.ResumeLayout(false);
            this.RentalTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalTransactionDataGridView)).EndInit();
            this.MemberInfoTabelLayout.ResumeLayout(false);
            this.MemberInfoTabelLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel userTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel TransactionTableLayout;
        private System.Windows.Forms.TableLayoutPanel RentalTableLayout;
        private System.Windows.Forms.Label RentalLabel;
        private System.Windows.Forms.DataGridView RentalTransactionDataGridView;
        private System.Windows.Forms.TableLayoutPanel MemberInfoTabelLayout;
        private System.Windows.Forms.Label MemberIdLabel;
        private System.Windows.Forms.Label MemberIdInfoLabel;
        private System.Windows.Forms.Label MemberNameLabel;
        private System.Windows.Forms.Label MemberNameInfoLabel;
    }
}