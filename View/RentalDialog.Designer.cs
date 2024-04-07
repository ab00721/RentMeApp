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
            this.rentalShoppingCartUserControl = new RentMeApp.UserControls.ShoppingCartUserControl();
            this.rentalTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentalTableLayoutPanel
            // 
            this.rentalTableLayoutPanel.AutoScroll = true;
            this.rentalTableLayoutPanel.ColumnCount = 1;
            this.rentalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rentalTableLayoutPanel.Controls.Add(this.rentalSearchFurnitureUserControl, 0, 2);
            this.rentalTableLayoutPanel.Controls.Add(this.rentalShoppingCartUserControl, 0, 3);
            this.rentalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.rentalTableLayoutPanel.Name = "rentalTableLayoutPanel";
            this.rentalTableLayoutPanel.RowCount = 5;
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 520F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.rentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rentalTableLayoutPanel.Size = new System.Drawing.Size(1218, 1244);
            this.rentalTableLayoutPanel.TabIndex = 0;
            // 
            // rentalSearchFurnitureUserControl
            // 
            this.rentalSearchFurnitureUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalSearchFurnitureUserControl.Location = new System.Drawing.Point(3, 203);
            this.rentalSearchFurnitureUserControl.Name = "rentalSearchFurnitureUserControl";
            this.rentalSearchFurnitureUserControl.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.rentalSearchFurnitureUserControl.Size = new System.Drawing.Size(1212, 494);
            this.rentalSearchFurnitureUserControl.TabIndex = 0;
            // 
            // rentalShoppingCartUserControl
            // 
            this.rentalShoppingCartUserControl.BackColor = System.Drawing.SystemColors.Control;
            this.rentalShoppingCartUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalShoppingCartUserControl.Location = new System.Drawing.Point(3, 703);
            this.rentalShoppingCartUserControl.Member = null;
            this.rentalShoppingCartUserControl.Name = "rentalShoppingCartUserControl";
            this.rentalShoppingCartUserControl.Padding = new System.Windows.Forms.Padding(25, 0, 40, 0);
            this.rentalShoppingCartUserControl.Size = new System.Drawing.Size(1212, 514);
            this.rentalShoppingCartUserControl.TabIndex = 0;
            this.rentalShoppingCartUserControl.Username = null;
            // 
            // RentalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 1244);
            this.Controls.Add(this.rentalTableLayoutPanel);
            this.MinimizeBox = false;
            this.Name = "RentalDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RentalDialog_FormClosing);
            this.Load += new System.EventHandler(this.RentalDialog_Load);
            this.rentalTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rentalTableLayoutPanel;
        private UserControls.SearchFurnitureUserControl rentalSearchFurnitureUserControl;
        private UserControls.ShoppingCartUserControl rentalShoppingCartUserControl;
    }
}