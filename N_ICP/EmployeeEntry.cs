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
    public partial class EmployeeEntry : MainForm
    {
        public EmployeeEntry()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myicedbConnectionString"].ConnectionString);

        string status = "Employee";

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT into employee(e_id, e_name) values('" + id_txt.Text + "', '" + name_txt.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();


                string query1 = "INSERT into login(username, password, status) values('" + username_txt.Text + "', '" + password_txt.Text + "', '" + status + "')";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();

                clear();
                show();
                show_login();

                MessageBox.Show(name_txt.Text + " Added Successfully...", "Record Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE employee set e_name = '" + name_txt.Text + "' WHERE e_id = '" + id_txt.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                string query1 = "UPDATE login set password = '" + password_txt.Text + "' WHERE username = '" + username_txt.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();

                clear();
                show();
                show_login();

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
                string query = "DELETE from employee WHERE e_id = '" + id_txt.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                string query1 = "DELETE from login WHERE username = '" + username_txt.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();

                clear();
                show();
                show_login();

                MessageBox.Show(name_txt.Text + " Deleted Successfully...", "Record Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            id_txt.Clear();
            name_txt.Clear();
            username_txt.Clear();
            password_txt.Clear();
            id_txt.Focus();
        }

        private void show()
        {
            try
            {
                string select = "SELECT * from employee";
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

        private void show_login()
        {
            try
            {
                string select = "SELECT * from login where status = '"+ status +"'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeEntry_Load(object sender, EventArgs e)
        {
            show();
            show_login();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    id_txt.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    name_txt.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    username_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    password_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
