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
    public partial class EmployeeDetails : MainForm
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myicedb.mdf;Integrated Security=True");

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            con.Open();
            show();
            con.Close();
        }

        private void show()
        {
            try
            {
                string select = "select a.e_name as 'Name',  b.e_cnic as 'CNIC', b.e_phone as 'Phone', b.e_address as 'Address', c.e_start_time as 'Start Time', c.e_end_time as 'End Time', d.salary as 'Salary' from employee a, employee_contact b, employee_duty_timing c, employee_income d where a.e_id = b.e_id and b.e_id = c.e_id and c.e_id = d.e_id";
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

        private void print_btn_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void print_preview_btn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.PageSettings.PrinterResolution.Kind = System.Drawing.Printing.PrinterResolutionKind.Custom;
            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 3, 6);

            int yPos = 220;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                string name = Convert.ToString(dataGridView.Rows[i].Cells[0].Value);
                string cnic = Convert.ToString(dataGridView.Rows[i].Cells[1].Value);
                string phone = Convert.ToString(dataGridView.Rows[i].Cells[2].Value);
                string address = Convert.ToString(dataGridView.Rows[i].Cells[3].Value);
                string start_time = Convert.ToString(dataGridView.Rows[i].Cells[4].Value);
                string end_time = Convert.ToString(dataGridView.Rows[i].Cells[5].Value);
                string salary = Convert.ToString(dataGridView.Rows[i].Cells[6].Value);

                e.Graphics.DrawString("Customer Details", new Font("Arial", 35, FontStyle.Bold), Brushes.Black, new Point(225, 75));
                e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, 170));
                e.Graphics.DrawString("Name", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, 185));
                e.Graphics.DrawString("CNIC", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(110, 185));
                e.Graphics.DrawString("Phone", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(210, 185));
                e.Graphics.DrawString("Address", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(310, 185));
                e.Graphics.DrawString("Start Time", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(510, 185));
                e.Graphics.DrawString("End Time", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(610, 185));
                e.Graphics.DrawString("Salary", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(710, 185));
                e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, 200));


                e.Graphics.DrawString(name.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString(cnic.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(110, yPos));
                e.Graphics.DrawString(phone.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(210, yPos));
                e.Graphics.DrawString(address.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(310, yPos));
                e.Graphics.DrawString(start_time.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(510, yPos));
                e.Graphics.DrawString(end_time.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(610, yPos));
                e.Graphics.DrawString(salary.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(710, yPos));
                yPos = yPos += 20;
            }
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, yPos));
        }
    }
}
