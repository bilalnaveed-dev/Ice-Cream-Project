using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_ICP
{
    public partial class IceCreamParlour : MainForm
    {
        public IceCreamParlour()
        {
            InitializeComponent();
        }

        private void employeeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeEntry ee = new EmployeeEntry();
            ee.ShowDialog();
        }

        private void employeeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeContact ec = new EmployeeContact();
            ec.ShowDialog();
        }

        private void employeeDutyTimingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeDutyTiming edt = new EmployeeDutyTiming();
            edt.ShowDialog();
        }

        private void employeeIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeIncome ei = new EmployeeIncome();
            ei.ShowDialog();
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeDetails ed = new EmployeeDetails();
            ed.ShowDialog();
        }

        private void distributorPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistributorPersonal dp = new DistributorPersonal();
            dp.ShowDialog();
        }

        private void distributorContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistributorContact dc = new DistributorContact();
            dc.ShowDialog();
        }

        private void distributorProfessionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistributorProfessional dp = new DistributorProfessional();
            dp.ShowDialog();
        }

        private void productCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductCategory pc = new ProductCategory();
            pc.ShowDialog();
        }

        private void productFlavourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductFlavour pf = new ProductFlavour();
            pf.ShowDialog();
        }

        private void orderStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderStock os = new OrderStock();
            os.ShowDialog();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStock ads = new AddStock();
            ads.ShowDialog();
        }

        private void currentStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentStock cs = new CurrentStock();
            cs.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer();
            ac.ShowDialog();
        }

        private void membersDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberDetails md = new MemberDetails();
            md.ShowDialog();
        }

        private void addCurrentOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerOrder aco = new AddCustomerOrder();
            aco.ShowDialog();
        }

        private void customerOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerOrderDetails cdo = new CustomerOrderDetails();
            cdo.ShowDialog();
        }

        private void discountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiscountDetails dd = new DiscountDetails();
            dd.ShowDialog();
        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rent r = new Rent();
            r.ShowDialog();
        }

        private void electricityBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElectricityBill eb = new ElectricityBill();
            eb.ShowDialog();
        }

        private void stockBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockBill sb = new StockBill();
            sb.ShowDialog();
        }

        private void employeeIncomeChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeIncomeCharges eic = new EmployeeIncomeCharges();
            eic.ShowDialog();
        }

        private void privilegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Privileges p = new Privileges();
            p.ShowDialog();
        }

        private void riderDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RiderDetails rd = new RiderDetails();
            rd.ShowDialog();
        }

        private void receiverDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceiverDetails rd = new ReceiverDetails();
            rd.ShowDialog();
        }

        private void customerFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerFeedBack cf = new CustomerFeedBack();
            cf.ShowDialog();
        }

        private void IceCreamParlour_Load(object sender, EventArgs e)
        {
            if (Login.status == "Employee")
            {
                employeeToolStripMenuItem.Enabled = false;
            }
            else
            {
                employeeToolStripMenuItem.Enabled = true;
            }
        }
    }
}
