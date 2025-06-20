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
    public partial class EmployeeContact : MainForm
    {
        public EmployeeContact()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myicedbConnectionString"].ConnectionString);


        private void EmployeeContact_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string select = "SELECT e_id from employee";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    id_comboBox.Items.Add(sdr["e_id"].ToString());
                    id_comboBox.ValueMember = sdr["e_id"].ToString();
                    id_comboBox.DisplayMember = sdr["e_id"].ToString();
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

        private void id_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string select = "SELECT e_name from employee";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    name_txt.Text = sdr["e_name"].ToString();
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
                string query = "INSERT into employee_contact(e_id, e_cnic, e_phone, e_address) values('" + id_comboBox.Text + "', '" + cnic_txt.Text + "', '" + phone_txt.Text + "', '" + address_txt.Text + "')";
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
                string query = "UPDATE employee_contact set e_cnic = '" + cnic_txt.Text + "', e_phone = '" + phone_txt.Text + "', e_address = '" + address_txt.Text + "' WHERE e_id = '" + id_comboBox.Text + "'";
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
                string query = "DELETE from employee_contact WHERE e_id = '" + id_comboBox.Text + "'";
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
                    id_comboBox.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cnic_txt.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    phone_txt.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    address_txt.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            name_txt.Clear();
            cnic_txt.Clear();
            phone_txt.Clear();
            address_txt.Clear();
            id_comboBox.Focus();
        }

        private void show()
        {
            try
            {
                string select = "SELECT * from employee_contact";
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
