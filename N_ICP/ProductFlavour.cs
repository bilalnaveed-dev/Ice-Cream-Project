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
    public partial class ProductFlavour : MainForm
    {
        public ProductFlavour()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myicedbConnectionString"].ConnectionString);



        private void ProductFlavour_Load(object sender, EventArgs e)
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT into flavours(f_id, p_name, f_name) values('" + id_txt.Text + "', '" + p_comboBox.Text + "', '" + f_name_txt.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                clear();
                show();

                MessageBox.Show(f_name_txt.Text + " Added Successfully...", "Record Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "UPDATE flavours set p_name = '" + p_comboBox.Text + "', f_name = '" + f_name_txt.Text + "' WHERE f_id = '" + id_txt.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                clear();
                show();

                MessageBox.Show(f_name_txt.Text + " Updated Successfully...", "Record Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "DELETE from flavours WHERE f_id = '" + id_txt.Text + "'";
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
                    id_txt.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    p_comboBox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    f_name_txt.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
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
            f_name_txt.Clear();
        }

        private void show()
        {
            try
            {
                string select = "SELECT * from flavours";
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
