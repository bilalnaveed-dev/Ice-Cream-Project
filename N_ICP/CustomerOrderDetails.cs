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
    public partial class CustomerOrderDetails : MainForm
    {
        public CustomerOrderDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myicedb.mdf;Integrated Security=True");

        private void CustomerOrderDetails_Load(object sender, EventArgs e)
        {
            show();
        }

        private void show()
        {
            try
            {
                string select = "SELECT * from add_customer_order";
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

        private void print_preview_btn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.PageSettings.PrinterResolution.Kind = System.Drawing.Printing.PrinterResolutionKind.Custom;
            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 3, 6);

            int yPos = 220;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                string c_name = Convert.ToString(dataGridView.Rows[i].Cells[0].Value);
                string e_name = Convert.ToString(dataGridView.Rows[i].Cells[1].Value);
                string p_name = Convert.ToString(dataGridView.Rows[i].Cells[2].Value);
                string f_name = Convert.ToString(dataGridView.Rows[i].Cells[3].Value);
                string p_quantity = Convert.ToString(dataGridView.Rows[i].Cells[4].Value);
                string bill = Convert.ToString(dataGridView.Rows[i].Cells[5].Value);
                string discount = Convert.ToString(dataGridView.Rows[i].Cells[6].Value);
                string after_discount = Convert.ToString(dataGridView.Rows[i].Cells[7].Value);
                string date = Convert.ToString(dataGridView.Rows[i].Cells[8].Value);
                string month = Convert.ToString(dataGridView.Rows[i].Cells[9].Value);
                string year = Convert.ToString(dataGridView.Rows[i].Cells[10].Value);
                string time = Convert.ToString(dataGridView.Rows[i].Cells[11].Value);

                e.Graphics.DrawString("Customer Order Details", new Font("Arial", 35, FontStyle.Bold), Brushes.Black, new Point(225, 75));
                e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, 170));
                e.Graphics.DrawString("Customer", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, 185));
                e.Graphics.DrawString("Employee", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(90, 185));
                e.Graphics.DrawString("Product", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(170, 185));
                e.Graphics.DrawString("Flavour", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(230, 185)); //230
                e.Graphics.DrawString("Quantity", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(300, 185)); //
                e.Graphics.DrawString("Bill", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(370, 185));
                e.Graphics.DrawString("Discount", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(410, 185));
                e.Graphics.DrawString("Total Bill", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(480, 185));
                e.Graphics.DrawString("Date", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(560, 185));
                e.Graphics.DrawString("Month", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(600, 185));
                e.Graphics.DrawString("Year", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(650, 185));
                e.Graphics.DrawString("Time", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(700, 185));
                e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, 200));


                e.Graphics.DrawString(c_name.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString(e_name.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(90, yPos));
                e.Graphics.DrawString(p_name.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(170, yPos));
                e.Graphics.DrawString(f_name.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(230, yPos));
                e.Graphics.DrawString(p_quantity.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(300, yPos));
                e.Graphics.DrawString(bill.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(370, yPos));
                e.Graphics.DrawString(discount.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(440, yPos));
                e.Graphics.DrawString(after_discount.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(480, yPos));
                e.Graphics.DrawString(date.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(560, yPos));
                e.Graphics.DrawString(month.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(600, yPos));
                e.Graphics.DrawString(year.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(650, yPos));
                e.Graphics.DrawString(time.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(700, yPos));
                yPos = yPos += 20;
            }
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, yPos));
        }
    }
}
