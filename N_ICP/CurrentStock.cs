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
    public partial class CurrentStock : MainForm
    {
        public CurrentStock()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myicedb.mdf;Integrated Security=True");
        string status = "Delivered";
        private void CurrentStock_Load(object sender, EventArgs e)
        {
            con.Open();
            show();
            con.Close();
        }

        private void show()
        {
            try
            {
                string select = "SELECT * from current_stock where order_status = '" + status + "'";
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.PageSettings.PrinterResolution.Kind = System.Drawing.Printing.PrinterResolutionKind.Custom;
            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 3, 6);

            int yPos = 220;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                string d_name = Convert.ToString(dataGridView.Rows[i].Cells[0].Value);
                string p_name = Convert.ToString(dataGridView.Rows[i].Cells[1].Value);
                string f_name = Convert.ToString(dataGridView.Rows[i].Cells[2].Value);
                string p_quantity = Convert.ToString(dataGridView.Rows[i].Cells[3].Value);
                string p_purchase_bill = Convert.ToString(dataGridView.Rows[i].Cells[4].Value);
                string order_status = Convert.ToString(dataGridView.Rows[i].Cells[5].Value);
                string date = Convert.ToString(dataGridView.Rows[i].Cells[6].Value);
                string month = Convert.ToString(dataGridView.Rows[i].Cells[7].Value);
                string year = Convert.ToString(dataGridView.Rows[i].Cells[8].Value);

                e.Graphics.DrawString("Current Stock", new Font("Arial", 35, FontStyle.Bold), Brushes.Black, new Point(225, 75));
                e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, 170));
                e.Graphics.DrawString("Distributor", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, 185));
                e.Graphics.DrawString("Product", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(110, 185));
                e.Graphics.DrawString("Flavour", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(210, 185));
                e.Graphics.DrawString("Quantity", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(310, 185));
                e.Graphics.DrawString("Purchase Bill", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(410, 185));
                e.Graphics.DrawString("Order Status", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(510, 185));
                e.Graphics.DrawString("Date", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(610, 185));
                e.Graphics.DrawString("Month", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(710, 185));
                e.Graphics.DrawString("Year", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(750, 185));
                e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, 200));


                e.Graphics.DrawString(d_name.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString(p_name.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(110, yPos));
                e.Graphics.DrawString(f_name.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(210, yPos));
                e.Graphics.DrawString(p_quantity.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(310, yPos));
                e.Graphics.DrawString(p_purchase_bill.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(410, yPos));
                e.Graphics.DrawString(order_status.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(510, yPos));
                e.Graphics.DrawString(date.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(610, yPos));
                e.Graphics.DrawString(month.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(710, yPos));
                e.Graphics.DrawString(year.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(750, yPos));
                yPos = yPos += 20;
            }
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, yPos));
        }

        private void print_preview_btn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
