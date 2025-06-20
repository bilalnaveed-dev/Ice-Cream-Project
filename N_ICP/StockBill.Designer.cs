
namespace N_ICP
{
    partial class StockBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.month_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.year_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.s_bill = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.clear_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // month_dateTimePicker
            // 
            this.month_dateTimePicker.CustomFormat = "MM";
            this.month_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.month_dateTimePicker.Location = new System.Drawing.Point(106, 427);
            this.month_dateTimePicker.Name = "month_dateTimePicker";
            this.month_dateTimePicker.Size = new System.Drawing.Size(229, 24);
            this.month_dateTimePicker.TabIndex = 2;
            // 
            // year_dateTimePicker
            // 
            this.year_dateTimePicker.CustomFormat = "yyyy";
            this.year_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.year_dateTimePicker.Location = new System.Drawing.Point(106, 473);
            this.year_dateTimePicker.Name = "year_dateTimePicker";
            this.year_dateTimePicker.Size = new System.Drawing.Size(229, 24);
            this.year_dateTimePicker.TabIndex = 3;
            // 
            // date_dateTimePicker
            // 
            this.date_dateTimePicker.CustomFormat = "dd";
            this.date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_dateTimePicker.Location = new System.Drawing.Point(106, 382);
            this.date_dateTimePicker.Name = "date_dateTimePicker";
            this.date_dateTimePicker.Size = new System.Drawing.Size(229, 24);
            this.date_dateTimePicker.TabIndex = 1;
            // 
            // s_bill
            // 
            this.s_bill.Location = new System.Drawing.Point(106, 334);
            this.s_bill.Name = "s_bill";
            this.s_bill.ReadOnly = true;
            this.s_bill.Size = new System.Drawing.Size(229, 24);
            this.s_bill.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 427);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 19);
            this.label13.TabIndex = 138;
            this.label13.Text = "Motnh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 473);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 19);
            this.label14.TabIndex = 137;
            this.label14.Text = "Year";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 19);
            this.label12.TabIndex = 139;
            this.label12.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 19);
            this.label6.TabIndex = 136;
            this.label6.Text = "Stock Bill of this Month";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(342, 158);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(825, 500);
            this.dataGridView.TabIndex = 132;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(202, 665);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(133, 40);
            this.clear_btn.TabIndex = 5;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(12, 665);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(133, 40);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // StockBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 717);
            this.Controls.Add(this.month_dateTimePicker);
            this.Controls.Add(this.year_dateTimePicker);
            this.Controls.Add(this.date_dateTimePicker);
            this.Controls.Add(this.s_bill);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.add_btn);
            this.Name = "StockBill";
            this.Text = "StockBill";
            this.Load += new System.EventHandler(this.StockBill_Load);
            this.Controls.SetChildIndex(this.add_btn, 0);
            this.Controls.SetChildIndex(this.clear_btn, 0);
            this.Controls.SetChildIndex(this.dataGridView, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.s_bill, 0);
            this.Controls.SetChildIndex(this.date_dateTimePicker, 0);
            this.Controls.SetChildIndex(this.year_dateTimePicker, 0);
            this.Controls.SetChildIndex(this.month_dateTimePicker, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker month_dateTimePicker;
        private System.Windows.Forms.DateTimePicker year_dateTimePicker;
        private System.Windows.Forms.DateTimePicker date_dateTimePicker;
        private System.Windows.Forms.TextBox s_bill;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button add_btn;
    }
}