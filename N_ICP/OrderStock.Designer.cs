
namespace N_ICP
{
    partial class OrderStock
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.unit_price_txt = new System.Windows.Forms.TextBox();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.d_comboBox = new System.Windows.Forms.ComboBox();
            this.p_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.f_comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.month_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.year_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.purchase_price_txt = new System.Windows.Forms.TextBox();
            this.order_status_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView.TabIndex = 59;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(1035, 665);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(133, 40);
            this.delete_btn.TabIndex = 13;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(202, 665);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(133, 40);
            this.clear_btn.TabIndex = 12;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(12, 665);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(133, 40);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // unit_price_txt
            // 
            this.unit_price_txt.Location = new System.Drawing.Point(132, 389);
            this.unit_price_txt.Name = "unit_price_txt";
            this.unit_price_txt.ReadOnly = true;
            this.unit_price_txt.Size = new System.Drawing.Size(203, 24);
            this.unit_price_txt.TabIndex = 4;
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(132, 346);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(203, 24);
            this.quantity_txt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 56;
            this.label5.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "Distributor";
            // 
            // d_comboBox
            // 
            this.d_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.d_comboBox.FormattingEnabled = true;
            this.d_comboBox.Location = new System.Drawing.Point(132, 214);
            this.d_comboBox.Name = "d_comboBox";
            this.d_comboBox.Size = new System.Drawing.Size(203, 27);
            this.d_comboBox.TabIndex = 0;
            // 
            // p_comboBox
            // 
            this.p_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_comboBox.FormattingEnabled = true;
            this.p_comboBox.Location = new System.Drawing.Point(132, 257);
            this.p_comboBox.Name = "p_comboBox";
            this.p_comboBox.Size = new System.Drawing.Size(203, 27);
            this.p_comboBox.TabIndex = 1;
            this.p_comboBox.SelectedIndexChanged += new System.EventHandler(this.p_comboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 52;
            this.label6.Text = "Flavour";
            // 
            // f_comboBox
            // 
            this.f_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.f_comboBox.FormattingEnabled = true;
            this.f_comboBox.Location = new System.Drawing.Point(132, 303);
            this.f_comboBox.Name = "f_comboBox";
            this.f_comboBox.Size = new System.Drawing.Size(203, 27);
            this.f_comboBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Order Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 56;
            this.label8.Text = "Date";
            // 
            // date_dateTimePicker
            // 
            this.date_dateTimePicker.CustomFormat = "dd";
            this.date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_dateTimePicker.Location = new System.Drawing.Point(132, 542);
            this.date_dateTimePicker.Name = "date_dateTimePicker";
            this.date_dateTimePicker.Size = new System.Drawing.Size(203, 24);
            this.date_dateTimePicker.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 588);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 56;
            this.label9.Text = "Month";
            // 
            // month_dateTimePicker
            // 
            this.month_dateTimePicker.CustomFormat = "MM";
            this.month_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.month_dateTimePicker.Location = new System.Drawing.Point(132, 583);
            this.month_dateTimePicker.Name = "month_dateTimePicker";
            this.month_dateTimePicker.Size = new System.Drawing.Size(203, 24);
            this.month_dateTimePicker.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 629);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 19);
            this.label10.TabIndex = 56;
            this.label10.Text = "Year";
            // 
            // year_dateTimePicker
            // 
            this.year_dateTimePicker.CustomFormat = "yyyy";
            this.year_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.year_dateTimePicker.Location = new System.Drawing.Point(132, 624);
            this.year_dateTimePicker.Name = "year_dateTimePicker";
            this.year_dateTimePicker.Size = new System.Drawing.Size(203, 24);
            this.year_dateTimePicker.TabIndex = 10;
            // 
            // calculate_btn
            // 
            this.calculate_btn.Location = new System.Drawing.Point(132, 419);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(204, 28);
            this.calculate_btn.TabIndex = 5;
            this.calculate_btn.Text = "Calculate Price";
            this.calculate_btn.UseVisualStyleBackColor = true;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 462);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 19);
            this.label11.TabIndex = 56;
            this.label11.Text = "Purchase Price";
            // 
            // purchase_price_txt
            // 
            this.purchase_price_txt.Location = new System.Drawing.Point(132, 459);
            this.purchase_price_txt.Name = "purchase_price_txt";
            this.purchase_price_txt.ReadOnly = true;
            this.purchase_price_txt.Size = new System.Drawing.Size(203, 24);
            this.purchase_price_txt.TabIndex = 6;
            // 
            // order_status_comboBox
            // 
            this.order_status_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.order_status_comboBox.FormattingEnabled = true;
            this.order_status_comboBox.Items.AddRange(new object[] {
            "Ordered"});
            this.order_status_comboBox.Location = new System.Drawing.Point(132, 501);
            this.order_status_comboBox.Name = "order_status_comboBox";
            this.order_status_comboBox.Size = new System.Drawing.Size(203, 27);
            this.order_status_comboBox.TabIndex = 7;
            // 
            // OrderStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 717);
            this.Controls.Add(this.order_status_comboBox);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.year_dateTimePicker);
            this.Controls.Add(this.month_dateTimePicker);
            this.Controls.Add(this.date_dateTimePicker);
            this.Controls.Add(this.f_comboBox);
            this.Controls.Add(this.p_comboBox);
            this.Controls.Add(this.d_comboBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.add_btn);
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
            this.Name = "OrderStock";
            this.Text = "OrderStock";
            this.Load += new System.EventHandler(this.OrderStock_Load);
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
            this.Controls.SetChildIndex(this.add_btn, 0);
            this.Controls.SetChildIndex(this.clear_btn, 0);
            this.Controls.SetChildIndex(this.delete_btn, 0);
            this.Controls.SetChildIndex(this.dataGridView, 0);
            this.Controls.SetChildIndex(this.d_comboBox, 0);
            this.Controls.SetChildIndex(this.p_comboBox, 0);
            this.Controls.SetChildIndex(this.f_comboBox, 0);
            this.Controls.SetChildIndex(this.date_dateTimePicker, 0);
            this.Controls.SetChildIndex(this.month_dateTimePicker, 0);
            this.Controls.SetChildIndex(this.year_dateTimePicker, 0);
            this.Controls.SetChildIndex(this.calculate_btn, 0);
            this.Controls.SetChildIndex(this.order_status_comboBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox unit_price_txt;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox d_comboBox;
        private System.Windows.Forms.ComboBox p_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox f_comboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date_dateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker month_dateTimePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker year_dateTimePicker;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox purchase_price_txt;
        private System.Windows.Forms.ComboBox order_status_comboBox;
    }
}