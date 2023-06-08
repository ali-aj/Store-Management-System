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
    public partial class CustomerReportForm : Form
    {
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=F219088;PASSWORD=5736";
        OracleConnection connection;
        public CustomerReportForm()
        {
            InitializeComponent();
            setCustomerGrid();
            setPanels();
        }
        private void setPanels()
        {
            string query = "SELECT COUNT(*) FROM customer";
            connection = new OracleConnection(conStr);
            connection.Open();
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                this.customerLabel.Text = Convert.ToString(command.ExecuteScalar());
            }
            query = "SELECT SUM(sales_amount) FROM sales";
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                this.totalAmountLabel.Text = Convert.ToString(command.ExecuteScalar()) + " $";
                if (this.totalAmountLabel.Text == " $")
                {
                    this.totalAmountLabel.Text = "0.0 $";
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
            connection.Close();
        }
        private void setCustomerGrid()
        {
            connection = new OracleConnection(conStr);
            connection.Open();
            string query = "SELECT c.cus_cnic Cnic, c.cus_name Name, c.city_code City_Code, c.cus_contact Contact, a.city City, a.country Country FROM customer c, address a WHERE c.city_code = a.city_code";
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                customerGrid.DataSource = table;
            }
            connection.Close();
        }
    }
}
