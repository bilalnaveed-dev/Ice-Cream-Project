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
    public partial class StockBill : MainForm
    {
        public StockBill()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myicedbConnectionString"].ConnectionString);



        private void StockBill_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string select = "SELECT sum(p_purchase_bill) as total_stock from order_stock where month = '" + month_dateTimePicker.Text + "' and year = '" + year_dateTimePicker.Text + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    s_bill.Text =  sdr["total_stock"].ToString();
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

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * from stock_bill WHERE month = '" + month_dateTimePicker.Text + "' AND year = '" + year_dateTimePicker.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Stock Bill Already Added", "Rend Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query1 = "INSERT into stock_bill(s_bill, date, month, year) values('" + s_bill.Text + "', '" + date_dateTimePicker.Text + "', '" + month_dateTimePicker.Text + "', '" + year_dateTimePicker.Text + "')";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.ExecuteNonQuery();

                    clear();
                    show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void clear()
        {
            s_bill.Clear();
        }

        private void show()
        {
            try
            {
                string select = "SELECT * from stock_bill";
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
