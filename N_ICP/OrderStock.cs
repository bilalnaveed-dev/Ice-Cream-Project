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
using System.Configuration;


namespace N_ICP
{
    public partial class OrderStock : MainForm
    {
        public OrderStock()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myicedbConnectionString"].ConnectionString);



        private void OrderStock_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                distributor();
                product();
                flavour();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            show();
            con.Close();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            if (quantity_txt.Text == "")
            {
                purchase_price_txt.Text = "0";
            }
            else
            {
                purchase_price_txt.Text = (Convert.ToDecimal(quantity_txt.Text) * Convert.ToDecimal(unit_price_txt.Text)).ToString();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT into order_stock(d_name, p_name, f_name, p_quantity, p_purchase_bill, order_status, date, month, year) values('" + d_comboBox.Text + "', '" + p_comboBox.Text + "', '" + f_comboBox.Text + "', '" + quantity_txt.Text + "', '" + purchase_price_txt.Text + "', '" + order_status_comboBox.Text + "', '" + date_dateTimePicker.Text + "', '" + month_dateTimePicker.Text + "', '" + year_dateTimePicker.Text + "')";
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE from order_stock WHERE p_name = '" + p_comboBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                clear();
                show();

                MessageBox.Show(" Deleted Successfully...", "Record Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    d_comboBox.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    p_comboBox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    f_comboBox.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    quantity_txt.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    purchase_price_txt.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    order_status_comboBox.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void distributor()
        {
            try
            {
                string select = "SELECT d_name from distributor_personal";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    d_comboBox.Items.Add(sdr["d_name"].ToString());
                    d_comboBox.ValueMember = sdr["d_name"].ToString();
                    d_comboBox.DisplayMember = sdr["d_name"].ToString();
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void product()
        {
            try
            {
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
        }

        private void flavour()
        {
            try
            {
                string select = "SELECT f_name from flavours";
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
        }

        private void p_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string select = "SELECT p_unit_price from products where p_name = '" + p_comboBox.Text + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    unit_price_txt.Text = sdr["p_unit_price"].ToString();
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void clear()
        {
            quantity_txt.Clear();
            purchase_price_txt.Clear();
            unit_price_txt.Clear();
        }

        private void show()
        {
            try
            {
                string select = "SELECT * from order_stock";
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
