using System;

namespace RentMeApp.UserControls
{
    partial class ShoppingCartUserControl
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
            this.shoppingCartLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.shoppingCartDataGridView = new System.Windows.Forms.DataGridView();
            this.rentalTotalsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.rentalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentalDurationLabel = new System.Windows.Forms.Label();
            this.daysRentedValueLabel = new System.Windows.Forms.Label();
            this.rentalTotalLabel = new System.Windows.Forms.Label();
            this.rentalTotalValueLabel = new System.Windows.Forms.Label();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.emptyButton = new System.Windows.Forms.Button();
            this.shoppingCartLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).BeginInit();
            this.rentalTotalsLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shoppingCartLayoutPanel
            // 
            this.shoppingCartLayoutPanel.ColumnCount = 2;
            this.shoppingCartLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shoppingCartLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shoppingCartLayoutPanel.Controls.Add(this.shoppingCartLabel, 0, 0);
            this.shoppingCartLayoutPanel.Controls.Add(this.shoppingCartDataGridView, 0, 1);
            this.shoppingCartLayoutPanel.Controls.Add(this.rentalTotalsLayoutPanel, 0, 2);
            this.shoppingCartLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.shoppingCartLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shoppingCartLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.shoppingCartLayoutPanel.Name = "shoppingCartLayoutPanel";
            this.shoppingCartLayoutPanel.RowCount = 2;
            this.shoppingCartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.shoppingCartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.shoppingCartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.shoppingCartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.shoppingCartLayoutPanel.Size = new System.Drawing.Size(1043, 480);
            this.shoppingCartLayoutPanel.TabIndex = 0;
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.shoppingCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartLabel.Location = new System.Drawing.Point(3, 0);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(162, 70);
            this.shoppingCartLabel.TabIndex = 0;
            this.shoppingCartLabel.Text = "Shopping Cart";
            this.shoppingCartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shoppingCartDataGridView
            // 
            this.shoppingCartDataGridView.AllowUserToAddRows = false;
            this.shoppingCartDataGridView.AllowUserToDeleteRows = false;
            this.shoppingCartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingCartLayoutPanel.SetColumnSpan(this.shoppingCartDataGridView, 2);
            this.shoppingCartDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shoppingCartDataGridView.Location = new System.Drawing.Point(3, 73);
            this.shoppingCartDataGridView.Name = "shoppingCartDataGridView";
            this.shoppingCartDataGridView.RowHeadersWidth = 62;
            this.shoppingCartLayoutPanel.SetRowSpan(this.shoppingCartDataGridView, 2);
            this.shoppingCartDataGridView.RowTemplate.Height = 28;
            this.shoppingCartDataGridView.Size = new System.Drawing.Size(1037, 210);
            this.shoppingCartDataGridView.TabIndex = 1;
            this.shoppingCartDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShoppingCartDataGridView_CellClick);
            this.shoppingCartDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShoppingCartDataGridView_CellValueChanged);
            // 
            // rentalTotalsLayoutPanel
            // 
            this.rentalTotalsLayoutPanel.ColumnCount = 4;
            this.shoppingCartLayoutPanel.SetColumnSpan(this.rentalTotalsLayoutPanel, 2);
            this.rentalTotalsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rentalTotalsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5F));
            this.rentalTotalsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.rentalTotalsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.rentalTotalsLayoutPanel.Controls.Add(this.dueDateLabel, 1, 1);
            this.rentalTotalsLayoutPanel.Controls.Add(this.rentalDateTimePicker, 2, 1);
            this.rentalTotalsLayoutPanel.Controls.Add(this.rentalDurationLabel, 1, 2);
            this.rentalTotalsLayoutPanel.Controls.Add(this.daysRentedValueLabel, 2, 2);
            this.rentalTotalsLayoutPanel.Controls.Add(this.rentalTotalLabel, 1, 3);
            this.rentalTotalsLayoutPanel.Controls.Add(this.rentalTotalValueLabel, 2, 3);
            this.rentalTotalsLayoutPanel.Controls.Add(this.checkoutButton, 2, 4);
            this.rentalTotalsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalTotalsLayoutPanel.Location = new System.Drawing.Point(3, 289);
            this.rentalTotalsLayoutPanel.Name = "rentalTotalsLayoutPanel";
            this.rentalTotalsLayoutPanel.RowCount = 7;
            this.rentalTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rentalTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.rentalTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.rentalTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.rentalTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rentalTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.rentalTotalsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rentalTotalsLayoutPanel.Size = new System.Drawing.Size(1037, 188);
            this.rentalTotalsLayoutPanel.TabIndex = 2;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(521, 20);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(268, 40);
            this.dueDateLabel.TabIndex = 0;
            this.dueDateLabel.Text = "Due Date:";
            this.dueDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rentalDateTimePicker
            // 
            this.rentalDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.rentalDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDateTimePicker.Location = new System.Drawing.Point(795, 23);
            this.rentalDateTimePicker.Name = "rentalDateTimePicker";
            this.rentalDateTimePicker.Size = new System.Drawing.Size(227, 31);
            this.rentalDateTimePicker.TabIndex = 1;
            this.rentalDateTimePicker.ValueChanged += new System.EventHandler(this.RentalDateTimePicker_ValueChanged);
            // 
            // rentalDurationLabel
            // 
            this.rentalDurationLabel.AutoSize = true;
            this.rentalDurationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDurationLabel.Location = new System.Drawing.Point(521, 60);
            this.rentalDurationLabel.Name = "rentalDurationLabel";
            this.rentalDurationLabel.Size = new System.Drawing.Size(268, 40);
            this.rentalDurationLabel.TabIndex = 2;
            this.rentalDurationLabel.Text = "Rental Duration (Days):";
            this.rentalDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // daysRentedValueLabel
            // 
            this.daysRentedValueLabel.AutoSize = true;
            this.daysRentedValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daysRentedValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysRentedValueLabel.Location = new System.Drawing.Point(795, 60);
            this.daysRentedValueLabel.Name = "daysRentedValueLabel";
            this.daysRentedValueLabel.Size = new System.Drawing.Size(227, 40);
            this.daysRentedValueLabel.TabIndex = 3;
            this.daysRentedValueLabel.Text = "0";
            this.daysRentedValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentalTotalLabel
            // 
            this.rentalTotalLabel.AutoSize = true;
            this.rentalTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalTotalLabel.Location = new System.Drawing.Point(521, 100);
            this.rentalTotalLabel.Name = "rentalTotalLabel";
            this.rentalTotalLabel.Size = new System.Drawing.Size(268, 40);
            this.rentalTotalLabel.TabIndex = 4;
            this.rentalTotalLabel.Text = "Total:";
            this.rentalTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rentalTotalValueLabel
            // 
            this.rentalTotalValueLabel.AutoSize = true;
            this.rentalTotalValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalTotalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalTotalValueLabel.Location = new System.Drawing.Point(795, 100);
            this.rentalTotalValueLabel.Name = "rentalTotalValueLabel";
            this.rentalTotalValueLabel.Size = new System.Drawing.Size(227, 40);
            this.rentalTotalValueLabel.TabIndex = 5;
            this.rentalTotalValueLabel.Text = "$0.00";
            this.rentalTotalValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkoutButton
            // 
            this.checkoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.Location = new System.Drawing.Point(795, 143);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(227, 54);
            this.checkoutButton.TabIndex = 6;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Controls.Add(this.emptyButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(840, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 64);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // emptyButton
            // 
            this.emptyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emptyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyButton.Location = new System.Drawing.Point(3, 11);
            this.emptyButton.Name = "emptyButton";
            this.emptyButton.Size = new System.Drawing.Size(194, 39);
            this.emptyButton.TabIndex = 0;
            this.emptyButton.Text = "Empty";
            this.emptyButton.UseVisualStyleBackColor = true;
            this.emptyButton.Click += new System.EventHandler(this.EmptyButton_Click);
            // 
            // ShoppingCartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.shoppingCartLayoutPanel);
            this.Name = "ShoppingCartUserControl";
            this.Size = new System.Drawing.Size(1043, 480);
            this.Load += new System.EventHandler(this.ShoppingCartUserControl_Load);
            this.shoppingCartLayoutPanel.ResumeLayout(false);
            this.shoppingCartLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).EndInit();
            this.rentalTotalsLayoutPanel.ResumeLayout(false);
            this.rentalTotalsLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel shoppingCartLayoutPanel;
        private System.Windows.Forms.Label shoppingCartLabel;
        internal System.Windows.Forms.DataGridView shoppingCartDataGridView;
        private System.Windows.Forms.TableLayoutPanel rentalTotalsLayoutPanel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.DateTimePicker rentalDateTimePicker;
        private System.Windows.Forms.Label rentalDurationLabel;
        private System.Windows.Forms.Label daysRentedValueLabel;
        private System.Windows.Forms.Label rentalTotalLabel;
        private System.Windows.Forms.Label rentalTotalValueLabel;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button emptyButton;
    }
}
