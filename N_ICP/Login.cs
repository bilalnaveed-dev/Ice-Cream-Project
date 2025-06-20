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
    public partial class Login : MainForm
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myicedbConnectionString"].ConnectionString);


        public static string username = "";
        public static string status = "";

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * from Login WHERE username = '" + username_txt.Text + "' AND password = '" + password_txt.Text + "' AND status = '" + status_comboBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = username_txt.Text;
                    status = status_comboBox.Text;
                    if (status == "Distributor")
                    {
                        CheckOrder co = new CheckOrder();
                        co.ShowDialog();
                    }
                    else
                    {
                        IceCreamParlour icp = new IceCreamParlour();
                        icp.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Username, Password or Status Incorrect", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {

        }

        private void show_password_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password_checkBox.Checked)
            {
                password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                password_txt.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
