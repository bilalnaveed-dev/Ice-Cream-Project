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
    public partial class AddStock : MainForm
    {
        public AddStock()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myicedb.mdf;Integrated Security=True");

        private void add_stock_Click(object sender, EventArgs e)
        {
            if (order_status_textBox.Text == "Delivered")
            {
                try
                {
                    con.Open();
                    string query = "INSERT into current_stock(d_name, p_name, f_name, p_quantity, p_purchase_bill, order_status, date, month, year) values('" + d_textBox.Text + "', '" + p_txt.Text + "', '" + f_txt.Text + "', '" + quantity_txt.Text + "', '" + purchase_price_txt.Text + "', '" + order_status_textBox.Text + "', '" + date_dateTimePicker.Text + "', '" + month_dateTimePicker.Text + "', '" + year_dateTimePicker.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    show();

                    MessageBox.Show(" Added Successfully...", "Record Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Order Not Delivered", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_stock_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE from order_stock WHERE order_status = '" + order_status_textBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

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
                    d_textBox.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    p_txt.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    f_txt.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    quantity_txt.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    purchase_price_txt.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    order_status_textBox.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            con.Open();
            show();
            con.Close();
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
