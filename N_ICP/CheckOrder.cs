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
    public partial class CheckOrder : MainForm
    {
        public CheckOrder()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myicedb.mdf;Integrated Security=True");

        private void CheckOrder_Load(object sender, EventArgs e)
        {
            con.Open();
            show();
            con.Close();
        }

        private void update_stock_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE order_stock set order_status = '" + order_status_comboBox.Text + "' where p_name = '" + p_txt.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                show();

                MessageBox.Show(" Updated Successfully...", "Record Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    order_status_comboBox.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
