using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Final_Project_DB_Lab
{
    public partial class CreativeEdgeShop : Form
    {
        public string name, role;
        public CreativeEdgeShop()
        {
            InitializeComponent();
            hideForms();
            this.loginForm1.Visible = true;
            sidebarPanel.Enabled = false;
            this.WindowState = FormWindowState.Maximized;
            this.userName.TextAlign = ContentAlignment.MiddleCenter; 
            loginForm1.MyEvent += MyEventHandler;

            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=F219088;PASSWORD=5736";
            OracleConnection connection = new OracleConnection(conStr);
            connection.Open();
            using (OracleTransaction transaction = connection.BeginTransaction())
            {
                transaction.Commit();
            }
            connection.Close();
        }
        private void MyEventHandler(object sender, string data)
        {
            int i;
            name = "";
            role = "";
            for (i = 0; data[i] != '-'; i++)
            {
                name += data[i];
            }
            for(int j = i + 1; j < data.Length; j++)
            {
                role += data[j];
            }
            this.userName.Text = name;
            this.userName.TextAlign = ContentAlignment.MiddleCenter;
            sidebarPanel.Enabled = true;
            hideForms();
            if(role == "Cashier")
            {
                dashboardbtn.Enabled = false;
                cusbtn.Enabled = false;
                vendorbtn.Enabled = false;
                inventorybtn.Enabled = false;
                this.salesForm1.Visible = true;
                salesbtn.BackColor = Color.SaddleBrown;
            }
            else
            {
                dashboardbtn.Enabled = true;
                cusbtn.Enabled = true;
                vendorbtn.Enabled = true;
                inventorybtn.Enabled = true;
                this.dashboardForm1.Visible = true;
                dashboardbtn.BackColor = Color.SaddleBrown;
            }
        }

        private void CreativeEdgeShop_Load(object sender, EventArgs e)
        {

        }

        private void crossbtn_Click(object sender, EventArgs e)
        {
            hideForms();
            this.Close();
        }

        private void resizebtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                resizebtn.BackgroundImage = Final_Project_DB_Lab.Properties.Resources.maximize__1_;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                resizebtn.BackgroundImage = Final_Project_DB_Lab.Properties.Resources.copy;
            }
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cusbtn_Click(object sender, EventArgs e)
        {
            hideForms();
            cusbtn.BackColor = Color.SaddleBrown;
            customerForm1.Visible = true;
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            hideForms();
            dashboardbtn.BackColor = Color.SaddleBrown;
            dashboardForm1.Visible = true;
        }

        private void vendorbtn_Click(object sender, EventArgs e)
        {
            hideForms();
            vendorbtn.BackColor = Color.SaddleBrown;
            vendorForm1.Visible = true;
        }

        public void hideForms()
        {
            dashboardForm1.Visible = false;
            dashboardbtn.BackColor = Color.FromArgb(35, 40, 45);
            customerForm1.Visible = false;
            cusbtn.BackColor = Color.FromArgb(35, 40, 45);
            vendorForm1.Visible = false;
            vendorbtn.BackColor = Color.FromArgb(35, 40, 45);
            salesForm1.Visible = false;
            salesbtn.BackColor = Color.FromArgb(35, 40, 45);
            rackForm1.Visible = false;
            rackbtn.BackColor = Color.FromArgb(35, 40, 45);
            inventoryForm1.Visible = false;
            inventorybtn.BackColor = Color.FromArgb(35, 40, 45);
            loginForm1.Visible = false;
            adduserbtn.BackColor = Color.FromArgb(35, 40, 45);
            addUser2.Visible = false;
            expenseForm1.Visible = false;
            expensebtn.BackColor = Color.FromArgb(35, 40, 45);
        }

        private void salesbtn_Click(object sender, EventArgs e)
        {
            hideForms();
            salesbtn.BackColor = Color.SaddleBrown;
            salesForm1.Visible = true;
        }

        private void rackbtn_Click(object sender, EventArgs e)
        {
            hideForms();
            rackbtn.BackColor = Color.SaddleBrown;
            rackForm1.Visible = true;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            hideForms();
            this.sidebarPanel.Enabled = false;
            this.userName.Text = "Please Login In First";
            this.loginForm1.Visible = true;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            hideForms();
            adduserbtn.BackColor = Color.SaddleBrown;
            addUser2.Visible = true;
        }

        private void expensebtn_Click(object sender, EventArgs e)
        {
            hideForms();
            expensebtn.BackColor = Color.SaddleBrown;
            expenseForm1.Visible = true;
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            hideForms();
            inventorybtn.BackColor = Color.SaddleBrown;
            inventoryForm1.Visible = true;
        }
    }
}