namespace RentMeApp.View
{
    partial class RentalDialog
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
            this.rentalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rentalSearchFurnitureUserControl = new RentMeApp.UserControls.SearchFurnitureUserControl();
            this.shoppingCart = new System.Windows.Forms.Label();
            this.rentalTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentalTableLayoutPanel
            // 
            this.rentalTableLayoutPanel.ColumnCount = 1;
            this.rentalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rentalTableLayoutPanel.Controls.Add(this.rentalSearchFurnitureUserControl, 0, 2);
            this.rentalTableLayoutPanel.Controls.Add(this.shoppingCart, 0, 3);
            this.rentalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.rentalTableLayoutPanel.Name = "rentalTableLayoutPanel";
            this.rentalTableLayoutPanel.RowCount = 4;
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 592F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 552F));
            this.rentalTableLayoutPanel.Size = new System.Drawing.Size(1166, 1330);
            this.rentalTableLayoutPanel.TabIndex = 0;
            // 
            // rentalSearchFurnitureUserControl
            // 
            this.rentalSearchFurnitureUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalSearchFurnitureUserControl.Location = new System.Drawing.Point(3, 188);
            this.rentalSearchFurnitureUserControl.Name = "rentalSearchFurnitureUserControl";
            this.rentalSearchFurnitureUserControl.Size = new System.Drawing.Size(1160, 586);
            this.rentalSearchFurnitureUserControl.TabIndex = 0;
            // 
            // shoppingCart
            // 
            this.shoppingCart.AutoSize = true;
            this.shoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCart.Location = new System.Drawing.Point(3, 777);
            this.shoppingCart.Name = "shoppingCart";
            this.shoppingCart.Size = new System.Drawing.Size(375, 25);
            this.shoppingCart.TabIndex = 1;
            this.shoppingCart.Text = "Add Shopping Cart User Control Here";
            // 
            // RentalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 1330);
            this.Controls.Add(this.rentalTableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentalDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RentalDialog_FormClosing);
            this.Load += new System.EventHandler(this.RentalDialog_Load);
            this.rentalTableLayoutPanel.ResumeLayout(false);
            this.rentalTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rentalTableLayoutPanel;
        private UserControls.SearchFurnitureUserControl rentalSearchFurnitureUserControl;
        private System.Windows.Forms.Label shoppingCart;
    }
}