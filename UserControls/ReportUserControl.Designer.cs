namespace RentMeApp.UserControls
{
    partial class ReportUserControl
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
            this.ReportTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.EndDateTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.EndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.StartDateTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.StartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.GenerateReportBtn = new System.Windows.Forms.Button();
            this.MostPopularFurnitureLabel = new System.Windows.Forms.Label();
            this.MostPopularFurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.ReportTableLayout.SuspendLayout();
            this.EndDateTableLayout.SuspendLayout();
            this.StartDateTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostPopularFurnitureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportTableLayout
            // 
            this.ReportTableLayout.ColumnCount = 1;
            this.ReportTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ReportTableLayout.Controls.Add(this.EndDateTableLayout, 0, 1);
            this.ReportTableLayout.Controls.Add(this.StartDateTableLayout, 0, 0);
            this.ReportTableLayout.Controls.Add(this.GenerateReportBtn, 0, 2);
            this.ReportTableLayout.Controls.Add(this.MostPopularFurnitureLabel, 0, 3);
            this.ReportTableLayout.Controls.Add(this.MostPopularFurnitureDataGridView, 0, 4);
            this.ReportTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportTableLayout.Location = new System.Drawing.Point(0, 0);
            this.ReportTableLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportTableLayout.Name = "ReportTableLayout";
            this.ReportTableLayout.RowCount = 5;
            this.ReportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ReportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ReportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ReportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ReportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ReportTableLayout.Size = new System.Drawing.Size(762, 494);
            this.ReportTableLayout.TabIndex = 0;
            // 
            // EndDateTableLayout
            // 
            this.EndDateTableLayout.ColumnCount = 2;
            this.EndDateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.EndDateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.EndDateTableLayout.Controls.Add(this.EndDateDateTimePicker, 1, 0);
            this.EndDateTableLayout.Controls.Add(this.EndDateLabel, 0, 0);
            this.EndDateTableLayout.Location = new System.Drawing.Point(4, 54);
            this.EndDateTableLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndDateTableLayout.Name = "EndDateTableLayout";
            this.EndDateTableLayout.RowCount = 1;
            this.EndDateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EndDateTableLayout.Size = new System.Drawing.Size(748, 34);
            this.EndDateTableLayout.TabIndex = 1;
            // 
            // EndDateDateTimePicker
            // 
            this.EndDateDateTimePicker.Location = new System.Drawing.Point(128, 5);
            this.EndDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndDateDateTimePicker.Name = "EndDateDateTimePicker";
            this.EndDateDateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.EndDateDateTimePicker.TabIndex = 1;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.Location = new System.Drawing.Point(4, 0);
            this.EndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.EndDateLabel.Size = new System.Drawing.Size(108, 33);
            this.EndDateLabel.TabIndex = 0;
            this.EndDateLabel.Text = "End Date:";
            // 
            // StartDateTableLayout
            // 
            this.StartDateTableLayout.ColumnCount = 2;
            this.StartDateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.StartDateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.StartDateTableLayout.Controls.Add(this.StartDateDateTimePicker, 1, 0);
            this.StartDateTableLayout.Controls.Add(this.StartDateLabel, 0, 0);
            this.StartDateTableLayout.Location = new System.Drawing.Point(4, 5);
            this.StartDateTableLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartDateTableLayout.Name = "StartDateTableLayout";
            this.StartDateTableLayout.RowCount = 1;
            this.StartDateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StartDateTableLayout.Size = new System.Drawing.Size(748, 34);
            this.StartDateTableLayout.TabIndex = 0;
            // 
            // StartDateDateTimePicker
            // 
            this.StartDateDateTimePicker.Location = new System.Drawing.Point(128, 5);
            this.StartDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartDateDateTimePicker.Name = "StartDateDateTimePicker";
            this.StartDateDateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.StartDateDateTimePicker.TabIndex = 1;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(4, 0);
            this.StartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.StartDateLabel.Size = new System.Drawing.Size(116, 33);
            this.StartDateLabel.TabIndex = 0;
            this.StartDateLabel.Text = "Start Date:";
            // 
            // GenerateReportBtn
            // 
            this.GenerateReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReportBtn.Location = new System.Drawing.Point(4, 103);
            this.GenerateReportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenerateReportBtn.Name = "GenerateReportBtn";
            this.GenerateReportBtn.Size = new System.Drawing.Size(146, 34);
            this.GenerateReportBtn.TabIndex = 2;
            this.GenerateReportBtn.Text = "Generate";
            this.GenerateReportBtn.UseVisualStyleBackColor = true;
            this.GenerateReportBtn.Click += new System.EventHandler(this.GenerateReportBtn_Click);
            // 
            // MostPopularFurnitureLabel
            // 
            this.MostPopularFurnitureLabel.AutoSize = true;
            this.MostPopularFurnitureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostPopularFurnitureLabel.Location = new System.Drawing.Point(4, 147);
            this.MostPopularFurnitureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MostPopularFurnitureLabel.Name = "MostPopularFurnitureLabel";
            this.MostPopularFurnitureLabel.Padding = new System.Windows.Forms.Padding(0, 23, 0, 0);
            this.MostPopularFurnitureLabel.Size = new System.Drawing.Size(231, 48);
            this.MostPopularFurnitureLabel.TabIndex = 4;
            this.MostPopularFurnitureLabel.Text = "Most Popular Furniture";
            // 
            // MostPopularFurnitureDataGridView
            // 
            this.MostPopularFurnitureDataGridView.AllowUserToDeleteRows = false;
            this.MostPopularFurnitureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MostPopularFurnitureDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MostPopularFurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MostPopularFurnitureDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MostPopularFurnitureDataGridView.Location = new System.Drawing.Point(4, 201);
            this.MostPopularFurnitureDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MostPopularFurnitureDataGridView.Name = "MostPopularFurnitureDataGridView";
            this.MostPopularFurnitureDataGridView.ReadOnly = true;
            this.MostPopularFurnitureDataGridView.RowHeadersWidth = 62;
            this.MostPopularFurnitureDataGridView.Size = new System.Drawing.Size(754, 288);
            this.MostPopularFurnitureDataGridView.TabIndex = 5;
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ReportTableLayout);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(762, 494);
            this.ReportTableLayout.ResumeLayout(false);
            this.ReportTableLayout.PerformLayout();
            this.EndDateTableLayout.ResumeLayout(false);
            this.EndDateTableLayout.PerformLayout();
            this.StartDateTableLayout.ResumeLayout(false);
            this.StartDateTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostPopularFurnitureDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ReportTableLayout;
        private System.Windows.Forms.TableLayoutPanel StartDateTableLayout;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDateDateTimePicker;
        private System.Windows.Forms.TableLayoutPanel EndDateTableLayout;
        private System.Windows.Forms.DateTimePicker EndDateDateTimePicker;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Button GenerateReportBtn;
        private System.Windows.Forms.Label MostPopularFurnitureLabel;
        private System.Windows.Forms.DataGridView MostPopularFurnitureDataGridView;
    }
}
