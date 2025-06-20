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
    public partial class MemberDetails : MainForm
    {
        public MemberDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myicedb.mdf;Integrated Security=True");

        private void MemberDetails_Load(object sender, EventArgs e)
        {
            con.Open();
            show();
            con.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT into members(m_id, m_name, m_cnic, m_phone, m_address) values('" + id_txt.Text + "','" + name_txt.Text + "', '" + cnic_txt.Text + "', '" + phone_txt.Text + "', '" + address_txt.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                clear();
                show();

                MessageBox.Show(name_txt.Text + " Added Successfully...", "Record Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE members set m_name = '" + name_txt.Text + "', m_cnic = '" + cnic_txt.Text + "', m_phone = '" + phone_txt.Text + "', m_address = '" + address_txt.Text + "' WHERE m_id = '" + id_txt.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                clear();
                show();

                MessageBox.Show(name_txt.Text + " Updated Successfully...", "Record Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE from members WHERE m_id = '" + id_txt.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                clear();
                show();

                MessageBox.Show(name_txt.Text + " Deleted Successfully...", "Record Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    id_txt.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    name_txt.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cnic_txt.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    phone_txt.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    address_txt.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            id_txt.Clear();
            name_txt.Clear();
            cnic_txt.Clear();
            phone_txt.Clear();
            address_txt.Clear();
            id_txt.Focus();
        }

        private void show()
        {
            try
            {
                string select = "SELECT * from members";
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
