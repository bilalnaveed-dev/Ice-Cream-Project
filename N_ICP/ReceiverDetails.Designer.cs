
namespace N_ICP
{
    partial class ReceiverDetails
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
            this.address_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.r_combo = new System.Windows.Forms.ComboBox();
            this.rec_combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p_combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.f_combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.feedback_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(106, 364);
            this.address_txt.Multiline = true;
            this.address_txt.Name = "address_txt";
            this.address_txt.ReadOnly = true;
            this.address_txt.Size = new System.Drawing.Size(229, 54);
            this.address_txt.TabIndex = 3;
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(106, 321);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.ReadOnly = true;
            this.phone_txt.Size = new System.Drawing.Size(229, 24);
            this.phone_txt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 93;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 92;
            this.label4.Text = "Phone";
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
            this.dataGridView.TabIndex = 89;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(12, 665);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(323, 40);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Update Details";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 84;
            this.label3.Text = "Receiver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 83;
            this.label2.Text = "Rider";
            // 
            // r_combo
            // 
            this.r_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.r_combo.FormattingEnabled = true;
            this.r_combo.Location = new System.Drawing.Point(106, 236);
            this.r_combo.Name = "r_combo";
            this.r_combo.Size = new System.Drawing.Size(229, 27);
            this.r_combo.TabIndex = 0;
            // 
            // rec_combo
            // 
            this.rec_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rec_combo.FormattingEnabled = true;
            this.rec_combo.Location = new System.Drawing.Point(106, 279);
            this.rec_combo.Name = "rec_combo";
            this.rec_combo.Size = new System.Drawing.Size(229, 27);
            this.rec_combo.TabIndex = 1;
            this.rec_combo.SelectedIndexChanged += new System.EventHandler(this.rec_combo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 84;
            this.label6.Text = "Product";
            // 
            // p_combo
            // 
            this.p_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_combo.FormattingEnabled = true;
            this.p_combo.Location = new System.Drawing.Point(106, 436);
            this.p_combo.Name = "p_combo";
            this.p_combo.Size = new System.Drawing.Size(229, 27);
            this.p_combo.TabIndex = 4;
            this.p_combo.SelectedIndexChanged += new System.EventHandler(this.p_combo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 84;
            this.label7.Text = "Flavour";
            // 
            // f_combo
            // 
            this.f_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.f_combo.FormattingEnabled = true;
            this.f_combo.Location = new System.Drawing.Point(106, 479);
            this.f_combo.Name = "f_combo";
            this.f_combo.Size = new System.Drawing.Size(229, 27);
            this.f_combo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 93;
            this.label8.Text = "Feedback";
            // 
            // feedback_txt
            // 
            this.feedback_txt.Location = new System.Drawing.Point(106, 512);
            this.feedback_txt.Multiline = true;
            this.feedback_txt.Name = "feedback_txt";
            this.feedback_txt.Size = new System.Drawing.Size(229, 54);
            this.feedback_txt.TabIndex = 6;
            // 
            // ReceiverDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 717);
            this.Controls.Add(this.f_combo);
            this.Controls.Add(this.p_combo);
            this.Controls.Add(this.rec_combo);
            this.Controls.Add(this.r_combo);
            this.Controls.Add(this.feedback_txt);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ReceiverDetails";
            this.Text = "ReceiverDetails";
            this.Load += new System.EventHandler(this.ReceiverDetails_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.add_btn, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.dataGridView, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.phone_txt, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.address_txt, 0);
            this.Controls.SetChildIndex(this.feedback_txt, 0);
            this.Controls.SetChildIndex(this.r_combo, 0);
            this.Controls.SetChildIndex(this.rec_combo, 0);
            this.Controls.SetChildIndex(this.p_combo, 0);
            this.Controls.SetChildIndex(this.f_combo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox r_combo;
        private System.Windows.Forms.ComboBox rec_combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox p_combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox f_combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox feedback_txt;
    }
}