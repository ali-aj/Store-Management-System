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
    public partial class vendorReportForm : Form
    {
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=F219088;PASSWORD=5736";
        OracleConnection connection;
        public vendorReportForm()
        {
            InitializeComponent();
            setPanels();
            setVendorGrid();
        }
        private void setPanels()
        {
            string query = "SELECT SUM(pur_amount) FROM purchases";
            connection = new OracleConnection(conStr);
            connection.Open();
            decimal purchases = 0;
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                this.purchaseLabel.Text = Convert.ToString(command.ExecuteScalar());
                if(this.purchaseLabel.Text == "")
                {
                    this.purchaseLabel.Text = "0.0 $";
                }
                else
                {
                    purchases = Convert.ToDecimal(this.purchaseLabel.Text);
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
                    purchases += Convert.ToInt32(this.purchaseLabel.Text);
                    this.purchaseLabel.Text = Convert.ToString(purchases) + " $";
                }
            }
            query = "SELECT COUNT(*) FROM vendor";
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                this.vendorLabel.Text = Convert.ToString(command.ExecuteScalar());
            }
            connection.Close();
        }
        private void setVendorGrid()
        {
            connection = new OracleConnection(conStr);
            connection.Open();
            string query = "SELECT v.ven_name Name, v.ven_id ID, v.ven_contact Contact, v.city_code City_Code, a.city City, a.country Country FROM vendor v, address a WHERE v.city_code = a.city_code";
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                vendorGrid.DataSource = table;
            }
            connection.Close();
        }
    }
}
