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
    public partial class Privileges : MainForm
    {
        public Privileges()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myicedb.mdf;Integrated Security=True");

        private void Privileges_Load(object sender, EventArgs e)
        {
            rent();
            electricity_bill();
            stock_bill();
            employee_income_charges();
            sales();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            all_expenses_textBox.Text = "0";
            profit_textBox.Text = "0";
            loss_textBox.Text = "0";
            rent_txt.Text = "0";
            electricity_bill_txt.Text = "0";
            stock_bill_txt.Text = "0";
            employee_income_charges_txt.Text = "0";
            sales_txt.Text = "0";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * from privileges WHERE month = '" + month_dateTimePicker.Text + "' AND year = '" + year_dateTimePicker.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Privileges Already Check", "Rend Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query1 = "INSERT into privileges(all_expenses, all_sales, profit, loss, date, month, year) values('" + all_expenses_textBox.Text + "', '" + sales_txt.Text + "', '" + profit_textBox.Text + "','" + loss_textBox.Text + "', '" + date_dateTimePicker.Text + "', '" + month_dateTimePicker.Text + "', '" + year_dateTimePicker.Text + "')";
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

        private void rent()
        {
            try
            {
                con.Open();
                string select = "SELECT sum(r_rent) as total_rent from rent WHERE month = '" + month_dateTimePicker.Text + "' AND year = '" + year_dateTimePicker.Text + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    rent_txt.Text = sdr["total_rent"].ToString();
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

        private void electricity_bill()
        {
            try
            {
                con.Open();
                string select = "SELECT sum(b_bill) as total_bill from electricity_bill WHERE month = '" + month_dateTimePicker.Text + "' AND year = '" + year_dateTimePicker.Text + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    electricity_bill_txt.Text = sdr["total_bill"].ToString();
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

        private void stock_bill()
        {
            try
            {
                con.Open();
                string select = "SELECT sum(p_purchase_bill) as total_purchases from current_stock WHERE month = '" + month_dateTimePicker.Text + "' AND year = '" + year_dateTimePicker.Text + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    stock_bill_txt.Text = sdr["total_purchases"].ToString();
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

        private void employee_income_charges()
        {
            try
            {
                con.Open();
                string select = "SELECT sum(salary) as total_salary from employee_income";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    employee_income_charges_txt.Text = sdr["total_salary"].ToString();
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

        private void sales()
        {
            try
            {
                con.Open();
                string select = "SELECT sum(bill_after_discount) as total_sales from add_customer_order WHERE month = '" + month_dateTimePicker.Text + "' AND year = '" + year_dateTimePicker.Text + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    sales_txt.Text = sdr["total_sales"].ToString();
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

        private void show()
        {
            try
            {
                string select = "SELECT * from privileges";
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

        private void add_expense_btn_Click(object sender, EventArgs e)
        {
            all_expenses_textBox.Text = (Convert.ToDecimal(rent_txt.Text) + Convert.ToDecimal(electricity_bill_txt.Text) + Convert.ToDecimal(stock_bill_txt.Text) + Convert.ToDecimal(employee_income_charges_txt.Text)).ToString();
        }

        private void check_p_or_l_btn_Click(object sender, EventArgs e)
        {
            decimal p_or_l = Convert.ToDecimal(sales_txt.Text) - Convert.ToDecimal(all_expenses_textBox.Text);
            if (p_or_l > 0)
            {
                profit_textBox.Text = p_or_l.ToString();
                loss_textBox.Text = "0";
            }
            else
            {
                loss_textBox.Text = (p_or_l * (-1)).ToString();
                profit_textBox.Text = "0";
            }  
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            rent();
            electricity_bill();
            stock_bill();
            employee_income_charges();
            sales();
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
                string all_expenses = Convert.ToString(dataGridView.Rows[i].Cells[0].Value);
                string all_sales = Convert.ToString(dataGridView.Rows[i].Cells[1].Value);
                string profit = Convert.ToString(dataGridView.Rows[i].Cells[2].Value);
                string loss = Convert.ToString(dataGridView.Rows[i].Cells[3].Value);
                string date = Convert.ToString(dataGridView.Rows[i].Cells[4].Value);
                string month = Convert.ToString(dataGridView.Rows[i].Cells[5].Value);
                string year = Convert.ToString(dataGridView.Rows[i].Cells[6].Value);

                e.Graphics.DrawString("Monthly Financial Report", new Font("Arial", 35, FontStyle.Bold), Brushes.Black, new Point(225, 75));
                e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, 170));
                e.Graphics.DrawString("Expenses", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, 185));
                e.Graphics.DrawString("Sales", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(110, 185));
                e.Graphics.DrawString("Profit", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(210, 185));
                e.Graphics.DrawString("Loss", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(310, 185)); //230
                e.Graphics.DrawString("Date", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(410, 185)); //
                e.Graphics.DrawString("Month", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(510, 185));
                e.Graphics.DrawString("Year", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(610, 185));
                e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, 200));


                e.Graphics.DrawString(all_expenses.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString(all_sales.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(110, yPos));
                e.Graphics.DrawString(profit.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(210, yPos));
                e.Graphics.DrawString(loss.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(310, yPos));
                e.Graphics.DrawString(date.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(410, yPos));
                e.Graphics.DrawString(month.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(510, yPos));
                e.Graphics.DrawString(year.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(610, yPos));
                yPos = yPos += 20;
            }
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, yPos));
        }
    }
}
