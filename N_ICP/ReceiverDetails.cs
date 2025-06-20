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
    public partial class ReceiverDetails : MainForm
    {
        public ReceiverDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myicedb.mdf;Integrated Security=True");

        private void ReceiverDetails_Load(object sender, EventArgs e)
        {
            rider();
            receiver();
            products();
        }

        private void rider()
        {
            try
            {
                con.Open();
                string select = "SELECT r_name from rider_details";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    r_combo.Items.Add(sdr["r_name"].ToString());
                    r_combo.ValueMember = sdr["r_name"].ToString();
                    r_combo.DisplayMember = sdr["r_name"].ToString();
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void receiver()
        {
            try
            {
                con.Open();
                string select = "SELECT c_name from customer";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    rec_combo.Items.Add(sdr["c_name"].ToString());
                    rec_combo.ValueMember = sdr["c_name"].ToString();
                    rec_combo.DisplayMember = sdr["c_name"].ToString();
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    p_combo.Items.Add(sdr["p_name"].ToString());
                    p_combo.ValueMember = sdr["p_name"].ToString();
                    p_combo.DisplayMember = sdr["p_name"].ToString();
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void rec_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string select = "SELECT c_phone, c_address from customer where c_name = '" + rec_combo.Text + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    phone_txt.Text = sdr["c_phone"].ToString();
                    address_txt.Text = sdr["c_address"].ToString();
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void p_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            f_combo.Items.Clear();
            try
            {
                con.Open();
                string select = "SELECT f_name from flavours where p_name = '" + p_combo.Text + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    f_combo.Items.Add(sdr["f_name"].ToString());
                    f_combo.ValueMember = sdr["f_name"].ToString();
                    f_combo.DisplayMember = sdr["f_name"].ToString();
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT into receiver_detail(rid_name, r_name, r_phone, r_address, p_name) values('" + r_combo.Text + "', '" + rec_combo.Text + "', '" + phone_txt.Text + "', '" + address_txt.Text + "', '" + p_combo.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                string query1 = "INSERT into customer_feedback(c_name, p_category, f_name, c_feedback) values('" + rec_combo.Text + "', '" + p_combo.Text + "', '" + f_combo.Text + "', '" + feedback_txt.Text + "')";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();

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

        private void clear()
        {
            phone_txt.Clear();
            address_txt.Clear();
            f_combo.Items.Clear();
        }

        private void show()
        {
            try
            {
                string select = "SELECT * from receiver_detail";
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
