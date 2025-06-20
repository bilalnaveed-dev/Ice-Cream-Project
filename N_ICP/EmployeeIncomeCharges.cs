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
    public partial class EmployeeIncomeCharges : MainForm
    {
        public EmployeeIncomeCharges()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myicedb.mdf;Integrated Security=True");

        private void EmployeeIncomeCharges_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string select = "SELECT sum(salary) as total_salary from employee_income";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    e_salary_txt.Text = sdr["total_salary"].ToString();
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
                string query = "SELECT * from employee_income_charges WHERE month = '" + month_dateTimePicker.Text + "' AND year = '" + year_dateTimePicker.Text + "'";
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
                    string query1 = "INSERT into employee_income_charges(e_salary, date, month, year) values('" + e_salary_txt.Text + "', '" + date_dateTimePicker.Text + "', '" + month_dateTimePicker.Text + "', '" + year_dateTimePicker.Text + "')";
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
            e_salary_txt.Clear();
        }

        private void show()
        {
            try
            {
                string select = "SELECT * from employee_income_charges";
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
