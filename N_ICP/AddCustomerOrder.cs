using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace N_ICP
{
    public partial class AddCustomerOrder : MainForm
    {
        public AddCustomerOrder()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myicedb.mdf;Integrated Security=True");

        private void AddCustomerOrder_Load(object sender, EventArgs e)
        {
            e_textBox.Text = Login.username;
            products();
            show();
        }

        private void flavours()
        {
            try
            {
                con.Open();
                string select = "SELECT f_name from flavours where p_name = '" + p_comboBox.Text + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    f_comboBox.Items.Add(sdr["f_name"].ToString());
                    f_comboBox.ValueMember = sdr["f_name"].ToString();
                    f_comboBox.DisplayMember = sdr["f_name"].ToString();
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            show();
            con.Close();
        }

        private void products()
        {
            try
            {
                con.Open();
                string select = "SELECT p_name from products";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    p_comboBox.Items.Add(sdr["p_name"].ToString());
                    p_comboBox.ValueMember = sdr["p_name"].ToString();
                    p_comboBox.DisplayMember = sdr["p_name"].ToString();
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            show();
            con.Close();
        }

        private void c_or_m_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            c_comboBox.Items.Clear();
            if (c_or_m_comboBox.Text == "Member")
            {
                try
                {
                    con.Open();
                    string select = "SELECT m_id from members";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        c_comboBox.Items.Add(sdr["m_id"].ToString());
                        c_comboBox.ValueMember = sdr["m_id"].ToString();
                        c_comboBox.DisplayMember = sdr["m_id"].ToString();
                    }
                    sdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                show();
                con.Close();
            }
            else
            {
                try
                {
                    con.Open();
                    string select = "SELECT c_id from customer";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        c_comboBox.Items.Add(sdr["c_id"].ToString());
                        c_comboBox.ValueMember = sdr["c_id"].ToString();
                        c_comboBox.DisplayMember = sdr["c_id"].ToString();
                    }
                    sdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                show();
                con.Close();
            }
        }

        private void p_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            f_comboBox.Items.Clear();
            flavours();
            try
            {
                con.Open();
                string select = "SELECT p_unit_price from products where p_name = '" + p_comboBox.Text + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    unit_price_textBox.Text = sdr["p_unit_price"].ToString();
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void check_without_discount_button_Click(object sender, EventArgs e)
        {
            if (quantity_txt.Text == "")
            {
                MessageBox.Show("Don't Leave Quantity Empty...", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bill_without_discount.Text = (Convert.ToDecimal(quantity_txt.Text) * Convert.ToDecimal(sale_price_textBox.Text)).ToString();
            }
        }

        private void check_bill_with_discount_button_Click(object sender, EventArgs e)
        {
            if (discount_txt.Text == "")
            {
                MessageBox.Show("Don't Leave Discount Empty...", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal amount_after_discount = (Convert.ToDecimal(bill_without_discount.Text) - ((Convert.ToDecimal(bill_without_discount.Text) / 100) * Convert.ToDecimal(discount_txt.Text)));
                total_bill_with_discount_textBox.Text = (amount_after_discount).ToString();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT into add_customer_order(c_name, e_name, p_name, f_name, p_quantity, bill, discount, bill_after_discount, date, month, year, time) values('" + c_comboBox.Text + "', '" + e_textBox.Text + "', '" + p_comboBox.Text + "', '" + f_comboBox.Text + "', '" + quantity_txt.Text + "', '" + bill_without_discount.Text + "', '" + discount_txt.Text + "', '" + total_bill_with_discount_textBox.Text + "', '" + date_dateTimePicker.Text + "', '" + month_dateTimePicker.Text + "', '" + year_dateTimePicker.Text + "', '" + time_dateTimePicker.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                clear();
                show();

                MessageBox.Show(" Added Successfully...", "Record Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            quantity_txt.Text = "0";
            bill_without_discount.Text = "0";
            discount_txt.Text = "0";
            total_bill_with_discount_textBox.Text = "0";
            sale_price_textBox.Text = "0";
        }

        private void show()
        {
            try
            {
                string select = "SELECT * from add_customer_order";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
