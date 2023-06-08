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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;

namespace Final_Project_DB_Lab
{
    public partial class dashboardForm : UserControl
    {
        string query;
        public dashboardForm()
        {
            InitializeComponent();
            setDashboard();
            displaySalesPurchases();
        }
        public void setDashboard()
        {
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=F219088;PASSWORD=5736";
            query = "SELECT COUNT(*) FROM customer";
            using (OracleConnection connection = new OracleConnection(conStr))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    this.customerLabel.Text = Convert.ToString(command.ExecuteScalar());
                }
                query = "SELECT COUNT(*) FROM vendor";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    this.vendorLabel.Text = Convert.ToString(command.ExecuteScalar());
                }

                query = "SELECT SUM(pur_amount) FROM purchases";
                decimal purchase = 0;
                string purchases;
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    this.purchaseLabel.Text = Convert.ToString(command.ExecuteScalar());
                    purchases = this.purchaseLabel.Text;
                    if (this.purchaseLabel.Text == "")
                    {
                        this.purchaseLabel.Text = "0.0 $";
                    }
                    else
                    {
                        purchase = Convert.ToDecimal(this.purchaseLabel.Text);
                        this.purchaseLabel.Text += " $";
                    }
                }
                query = "SELECT SUM(exp_amount) FROM expenses";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    this.purchaseLabel.Text = Convert.ToString(command.ExecuteScalar());
                    if (this.purchaseLabel.Text == "")
                    {
                        this.purchaseLabel.Text = "0.0 $";
                    }
                    else
                    {
                        purchase += Convert.ToInt32(this.purchaseLabel.Text);
                        this.purchaseLabel.Text = Convert.ToString(purchase) + " $";
                    }
                }

                query = "SELECT SUM(sale_quantity) FROM sales_items";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    this.soldLabel.Text = Convert.ToString(command.ExecuteScalar());
                    if (this.soldLabel.Text == "")
                    {
                        this.soldLabel.Text = "0";
                    }
                }
                query = "SELECT SUM(sales_amount) FROM sales";
                string revenues, expenses;
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    revenues = Convert.ToString(command.ExecuteScalar());
                    this.revenueLabel.Text = revenues + " $";
                    if (this.revenueLabel.Text == " $")
                    {
                        this.revenueLabel.Text = "0.0 $";
                    }
                }
                query = "SELECT SUM(exp_amount) FROM expenses";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    expenses = Convert.ToString(command.ExecuteScalar());
                }
                if (expenses != "" && purchases != "")
                {
                    decimal total_expenses = Convert.ToDecimal(expenses) + Convert.ToDecimal(purchases);
                    if ((Convert.ToDecimal(revenues) - total_expenses) < 0)
                    {
                        this.lossLabel.Text = Convert.ToString(Convert.ToDecimal(revenues) - total_expenses) + " $";
                    }
                    else
                    {
                        this.profitLabel.Text = Convert.ToString(Convert.ToDecimal(revenues) - total_expenses) + " $";
                    }
                }
            }
        }
        public void displaySalesPurchases()
        {
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=F219088;PASSWORD=5736";
            using (OracleConnection connection = new OracleConnection(conStr))
            {
                connection.Open();
                query = "SELECT s.sales_id S_ID, s.sales_amount S_Amount, c.cus_name Customer FROM sales s, customer c WHERE s.cus_cnic = c.cus_cnic";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    OracleDataAdapter adapter = new OracleDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    salesGrid.DataSource = table;
                }
                query = "SELECT p.pur_id P_ID, p.pur_amount P_Amount, v.ven_name Vendor FROM purchases p, vendor v WHERE p.ven_id = v.ven_id";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    OracleDataAdapter adapter = new OracleDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    purchaseGrid.DataSource = table;
                }
            }
        }

        private void customers_DoubleClick(object sender, EventArgs e)
        {
            //customerReport cus_Report = new customerReport();
            //cus_Report.Dock = DockStyle.Fill;
            //centerPanel.Controls.Add(addUser1);
            //cus_Report.Visible = true;
            //this.Visible = false;
            
        }

        private void customers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vendors_Click(object sender, EventArgs e)
        {

        }

        private void dashboardForm_VisibleChanged(object sender, EventArgs e)
        {
            setDashboard();
            displaySalesPurchases();
        }
    }
}
