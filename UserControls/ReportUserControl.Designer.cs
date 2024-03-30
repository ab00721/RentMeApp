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
            this.StartDateTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.ReportTableLayout.SuspendLayout();
            this.StartDateTableLayout.SuspendLayout();
            this.EndDateTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportTableLayout
            // 
            this.ReportTableLayout.ColumnCount = 1;
            this.ReportTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ReportTableLayout.Controls.Add(this.EndDateTableLayout, 0, 1);
            this.ReportTableLayout.Controls.Add(this.StartDateTableLayout, 0, 0);
            this.ReportTableLayout.Location = new System.Drawing.Point(0, 0);
            this.ReportTableLayout.Name = "ReportTableLayout";
            this.ReportTableLayout.RowCount = 5;
            this.ReportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ReportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ReportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ReportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ReportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ReportTableLayout.Size = new System.Drawing.Size(622, 370);
            this.ReportTableLayout.TabIndex = 0;
            // 
            // StartDateTableLayout
            // 
            this.StartDateTableLayout.ColumnCount = 2;
            this.StartDateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.StartDateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.StartDateTableLayout.Controls.Add(this.StartDateDateTimePicker, 1, 0);
            this.StartDateTableLayout.Controls.Add(this.StartDateLabel, 0, 0);
            this.StartDateTableLayout.Location = new System.Drawing.Point(3, 3);
            this.StartDateTableLayout.Name = "StartDateTableLayout";
            this.StartDateTableLayout.RowCount = 1;
            this.StartDateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StartDateTableLayout.Size = new System.Drawing.Size(616, 31);
            this.StartDateTableLayout.TabIndex = 0;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(3, 0);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.StartDateLabel.Size = new System.Drawing.Size(80, 21);
            this.StartDateLabel.TabIndex = 0;
            this.StartDateLabel.Text = "Start Date:";
            // 
            // StartDateDateTimePicker
            // 
            this.StartDateDateTimePicker.Location = new System.Drawing.Point(105, 3);
            this.StartDateDateTimePicker.Name = "StartDateDateTimePicker";
            this.StartDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDateDateTimePicker.TabIndex = 1;
            // 
            // EndDateTableLayout
            // 
            this.EndDateTableLayout.ColumnCount = 2;
            this.EndDateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.EndDateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.EndDateTableLayout.Controls.Add(this.dateTimePicker1, 1, 0);
            this.EndDateTableLayout.Controls.Add(this.EndDateLabel, 0, 0);
            this.EndDateTableLayout.Location = new System.Drawing.Point(3, 40);
            this.EndDateTableLayout.Name = "EndDateTableLayout";
            this.EndDateTableLayout.RowCount = 1;
            this.EndDateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EndDateTableLayout.Size = new System.Drawing.Size(616, 31);
            this.EndDateTableLayout.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.Location = new System.Drawing.Point(3, 0);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.EndDateLabel.Size = new System.Drawing.Size(75, 21);
            this.EndDateLabel.TabIndex = 0;
            this.EndDateLabel.Text = "End Date:";
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReportTableLayout);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(622, 370);
            this.ReportTableLayout.ResumeLayout(false);
            this.StartDateTableLayout.ResumeLayout(false);
            this.StartDateTableLayout.PerformLayout();
            this.EndDateTableLayout.ResumeLayout(false);
            this.EndDateTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ReportTableLayout;
        private System.Windows.Forms.TableLayoutPanel StartDateTableLayout;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDateDateTimePicker;
        private System.Windows.Forms.TableLayoutPanel EndDateTableLayout;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label EndDateLabel;
    }
}
