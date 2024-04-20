namespace RentMeApp.UserControls
{
    partial class ReturnUserControl
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
            this.returnCartLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.returnCartLabel = new System.Windows.Forms.Label();
            this.returnCartDataGridView = new System.Windows.Forms.DataGridView();
            this.returnTotalsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.returnTotalLabel = new System.Windows.Forms.Label();
            this.returnTotalValueLabel = new System.Windows.Forms.Label();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.returnCartLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnCartDataGridView)).BeginInit();
            this.returnTotalsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnCartLayoutPanel
            // 
            this.returnCartLayoutPanel.ColumnCount = 2;
            this.returnCartLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.returnCartLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.returnCartLayoutPanel.Controls.Add(this.returnCartLabel, 0, 0);
            this.returnCartLayoutPanel.Controls.Add(this.returnCartDataGridView, 0, 1);
            this.returnCartLayoutPanel.Controls.Add(this.returnTotalsLayoutPanel, 0, 2);
            this.returnCartLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnCartLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.returnCartLayoutPanel.Name = "returnCartLayoutPanel";
            this.returnCartLayoutPanel.RowCount = 2;
            this.returnCartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.returnCartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.returnCartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.returnCartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.returnCartLayoutPanel.Size = new System.Drawing.Size(1043, 480);
            this.returnCartLayoutPanel.TabIndex = 0;
            // 
            // returnCartLabel
            // 
            this.returnCartLabel.AutoSize = true;
            this.returnCartLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.returnCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnCartLabel.Location = new System.Drawing.Point(3, 0);
            this.returnCartLabel.Name = "returnCartLabel";
            this.returnCartLabel.Size = new System.Drawing.Size(133, 70);
            this.returnCartLabel.TabIndex = 0;
            this.returnCartLabel.Text = "Return Cart";
            this.returnCartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // returnCartDataGridView
            // 
            this.returnCartDataGridView.AllowUserToAddRows = false;
            this.returnCartDataGridView.AllowUserToDeleteRows = false;
            this.returnCartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.returnCartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnCartLayoutPanel.SetColumnSpan(this.returnCartDataGridView, 2);
            this.returnCartDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnCartDataGridView.Location = new System.Drawing.Point(3, 73);
            this.returnCartDataGridView.Name = "returnCartDataGridView";
            this.returnCartDataGridView.RowHeadersWidth = 62;
            this.returnCartLayoutPanel.SetRowSpan(this.returnCartDataGridView, 2);
            this.returnCartDataGridView.RowTemplate.Height = 28;
            this.returnCartDataGridView.Size = new System.Drawing.Size(1037, 210);
            this.returnCartDataGridView.TabIndex = 1;
            this.returnCartDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReturnCartDataGridView_CellClick);
            this.returnCartDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReturnCartDataGridView_CellValueChanged);
            this.returnCartDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ReturnCartDataGridView_DataError);
            // 
            // returnTotalsLayoutPanel
            // 
            this.returnTotalsLayoutPanel.ColumnCount = 4;
            this.returnCartLayoutPanel.SetColumnSpan(this.returnTotalsLayoutPanel, 2);
            this.returnTotalsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.returnTotalsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5F));
            this.returnTotalsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.returnTotalsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.returnTotalsLayoutPanel.Controls.Add(this.returnTotalLabel, 1, 1);
            this.returnTotalsLayoutPanel.Controls.Add(this.returnTotalValueLabel, 2, 1);
            this.returnTotalsLayoutPanel.Controls.Add(this.checkoutButton, 2, 2);
            this.returnTotalsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnTotalsLayoutPanel.Location = new System.Drawing.Point(3, 289);
            this.returnTotalsLayoutPanel.Name = "returnTotalsLayoutPanel";
            this.returnTotalsLayoutPanel.RowCount = 5;
            this.returnTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.returnTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.returnTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.returnTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.returnTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.returnTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.returnTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.returnTotalsLayoutPanel.Size = new System.Drawing.Size(1037, 188);
            this.returnTotalsLayoutPanel.TabIndex = 2;
            // 
            // returnTotalLabel
            // 
            this.returnTotalLabel.AutoSize = true;
            this.returnTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnTotalLabel.Location = new System.Drawing.Point(521, 20);
            this.returnTotalLabel.Name = "returnTotalLabel";
            this.returnTotalLabel.Size = new System.Drawing.Size(268, 40);
            this.returnTotalLabel.TabIndex = 4;
            this.returnTotalLabel.Text = "Total:";
            this.returnTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // returnTotalValueLabel
            // 
            this.returnTotalValueLabel.AutoSize = true;
            this.returnTotalValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnTotalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnTotalValueLabel.Location = new System.Drawing.Point(795, 20);
            this.returnTotalValueLabel.Name = "returnTotalValueLabel";
            this.returnTotalValueLabel.Size = new System.Drawing.Size(227, 40);
            this.returnTotalValueLabel.TabIndex = 5;
            this.returnTotalValueLabel.Text = "$0.00";
            this.returnTotalValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkoutButton
            // 
            this.checkoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.Location = new System.Drawing.Point(795, 63);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(227, 54);
            this.checkoutButton.TabIndex = 6;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // ReturnUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.returnCartLayoutPanel);
            this.Name = "ReturnUserControl";
            this.Size = new System.Drawing.Size(1043, 480);
            this.Load += new System.EventHandler(this.ReturnUserControl_Load);
            this.returnCartLayoutPanel.ResumeLayout(false);
            this.returnCartLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnCartDataGridView)).EndInit();
            this.returnTotalsLayoutPanel.ResumeLayout(false);
            this.returnTotalsLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel returnCartLayoutPanel;
        private System.Windows.Forms.Label returnCartLabel;
        internal System.Windows.Forms.DataGridView returnCartDataGridView;
        private System.Windows.Forms.TableLayoutPanel returnTotalsLayoutPanel;
        private System.Windows.Forms.Label returnTotalLabel;
        private System.Windows.Forms.Label returnTotalValueLabel;
        private System.Windows.Forms.Button checkoutButton;
    }
}
