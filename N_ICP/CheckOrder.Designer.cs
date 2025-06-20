
namespace N_ICP
{
    partial class CheckOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.year_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.month_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.update_stock = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.purchase_price_txt = new System.Windows.Forms.TextBox();
            this.unit_price_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.order_status_comboBox = new System.Windows.Forms.ComboBox();
            this.f_txt = new System.Windows.Forms.TextBox();
            this.p_txt = new System.Windows.Forms.TextBox();
            this.d_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // year_dateTimePicker
            // 
            this.year_dateTimePicker.CustomFormat = "yyyy";
            this.year_dateTimePicker.Enabled = false;
            this.year_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.year_dateTimePicker.Location = new System.Drawing.Point(132, 598);
            this.year_dateTimePicker.Name = "year_dateTimePicker";
            this.year_dateTimePicker.Size = new System.Drawing.Size(203, 24);
            this.year_dateTimePicker.TabIndex = 9;
            // 
            // month_dateTimePicker
            // 
            this.month_dateTimePicker.CustomFormat = "MM";
            this.month_dateTimePicker.Enabled = false;
            this.month_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.month_dateTimePicker.Location = new System.Drawing.Point(132, 557);
            this.month_dateTimePicker.Name = "month_dateTimePicker";
            this.month_dateTimePicker.Size = new System.Drawing.Size(203, 24);
            this.month_dateTimePicker.TabIndex = 8;
            // 
            // date_dateTimePicker
            // 
            this.date_dateTimePicker.CustomFormat = "dd";
            this.date_dateTimePicker.Enabled = false;
            this.date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_dateTimePicker.Location = new System.Drawing.Point(132, 516);
            this.date_dateTimePicker.Name = "date_dateTimePicker";
            this.date_dateTimePicker.Size = new System.Drawing.Size(203, 24);
            this.date_dateTimePicker.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.Location = new System.Drawing.Point(342, 158);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(825, 500);
            this.dataGridView.TabIndex = 80;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // update_stock
            // 
            this.update_stock.Location = new System.Drawing.Point(12, 665);
            this.update_stock.Name = "update_stock";
            this.update_stock.Size = new System.Drawing.Size(323, 40);
            this.update_stock.TabIndex = 10;
            this.update_stock.Text = "Update Stock";
            this.update_stock.UseVisualStyleBackColor = true;
            this.update_stock.Click += new System.EventHandler(this.update_stock_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 603);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 19);
            this.label10.TabIndex = 75;
            this.label10.Text = "Year";
            // 
            // purchase_price_txt
            // 
            this.purchase_price_txt.Enabled = false;
            this.purchase_price_txt.Location = new System.Drawing.Point(132, 433);
            this.purchase_price_txt.Name = "purchase_price_txt";
            this.purchase_price_txt.ReadOnly = true;
            this.purchase_price_txt.Size = new System.Drawing.Size(203, 24);
            this.purchase_price_txt.TabIndex = 5;
            // 
            // unit_price_txt
            // 
            this.unit_price_txt.Enabled = false;
            this.unit_price_txt.Location = new System.Drawing.Point(132, 389);
            this.unit_price_txt.Name = "unit_price_txt";
            this.unit_price_txt.ReadOnly = true;
            this.unit_price_txt.Size = new System.Drawing.Size(203, 24);
            this.unit_price_txt.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 562);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 74;
            this.label9.Text = "Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 77;
            this.label8.Text = "Date";
            // 
            // quantity_txt
            // 
            this.quantity_txt.Enabled = false;
            this.quantity_txt.Location = new System.Drawing.Point(132, 346);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(203, 24);
            this.quantity_txt.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 19);
            this.label11.TabIndex = 78;
            this.label11.Text = "Purchase Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 76;
            this.label5.Text = "Unit Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 72;
            this.label7.Text = "Order Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "Flavour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 71;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 68;
            this.label3.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Distributor";
            // 
            // order_status_comboBox
            // 
            this.order_status_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.order_status_comboBox.FormattingEnabled = true;
            this.order_status_comboBox.Items.AddRange(new object[] {
            "Delivered",
            "Not Available"});
            this.order_status_comboBox.Location = new System.Drawing.Point(132, 475);
            this.order_status_comboBox.Name = "order_status_comboBox";
            this.order_status_comboBox.Size = new System.Drawing.Size(203, 27);
            this.order_status_comboBox.TabIndex = 6;
            // 
            // f_txt
            // 
            this.f_txt.Enabled = false;
            this.f_txt.Location = new System.Drawing.Point(132, 303);
            this.f_txt.Name = "f_txt";
            this.f_txt.Size = new System.Drawing.Size(203, 24);
            this.f_txt.TabIndex = 2;
            // 
            // p_txt
            // 
            this.p_txt.Enabled = false;
            this.p_txt.Location = new System.Drawing.Point(132, 257);
            this.p_txt.Name = "p_txt";
            this.p_txt.Size = new System.Drawing.Size(203, 24);
            this.p_txt.TabIndex = 1;
            // 
            // d_textBox
            // 
            this.d_textBox.Enabled = false;
            this.d_textBox.Location = new System.Drawing.Point(132, 214);
            this.d_textBox.Name = "d_textBox";
            this.d_textBox.Size = new System.Drawing.Size(203, 24);
            this.d_textBox.TabIndex = 0;
            // 
            // CheckOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 717);
            this.Controls.Add(this.f_txt);
            this.Controls.Add(this.p_txt);
            this.Controls.Add(this.d_textBox);
            this.Controls.Add(this.order_status_comboBox);
            this.Controls.Add(this.year_dateTimePicker);
            this.Controls.Add(this.month_dateTimePicker);
            this.Controls.Add(this.date_dateTimePicker);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.update_stock);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.purchase_price_txt);
            this.Controls.Add(this.unit_price_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "CheckOrder";
            this.Text = "CheckOrder";
            this.Load += new System.EventHandler(this.CheckOrder_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.quantity_txt, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.unit_price_txt, 0);
            this.Controls.SetChildIndex(this.purchase_price_txt, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.update_stock, 0);
            this.Controls.SetChildIndex(this.dataGridView, 0);
            this.Controls.SetChildIndex(this.date_dateTimePicker, 0);
            this.Controls.SetChildIndex(this.month_dateTimePicker, 0);
            this.Controls.SetChildIndex(this.year_dateTimePicker, 0);
            this.Controls.SetChildIndex(this.order_status_comboBox, 0);
            this.Controls.SetChildIndex(this.d_textBox, 0);
            this.Controls.SetChildIndex(this.p_txt, 0);
            this.Controls.SetChildIndex(this.f_txt, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker year_dateTimePicker;
        private System.Windows.Forms.DateTimePicker month_dateTimePicker;
        private System.Windows.Forms.DateTimePicker date_dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button update_stock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox purchase_price_txt;
        private System.Windows.Forms.TextBox unit_price_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox order_status_comboBox;
        private System.Windows.Forms.TextBox f_txt;
        private System.Windows.Forms.TextBox p_txt;
        private System.Windows.Forms.TextBox d_textBox;
    }
}