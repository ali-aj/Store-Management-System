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
    public partial class customerForm : UserControl
    {
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=F219088;PASSWORD=5736";
        OracleConnection connection;
        public customerForm()
        {
            InitializeComponent();
            setPurchaseGrid();
            setCustomerGrid();
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
        private void setPurchaseGrid()
        {
            connection = new OracleConnection(conStr);
            connection.Open();
            string query = "SELECT s.sales_id ID, s.sales_amount Amount, s.sales_date P_Date, c.cus_name Customer FROM sales s, customer c WHERE s.cus_cnic = c.cus_cnic";
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                purchaseGrid.DataSource = table;
            }
            connection.Close();
        }
        private void resetFields()
        {
            nametxt.Text = "";
            cnictxt.Text = "";
            citycodetxt.Text = "";
            citytxt.Text = "";
            countrytxt.Text = "";
            numbertxt.Text = "";
            setPurchaseGrid();
            setCustomerGrid();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" || !cnictxt.MaskCompleted || citytxt.Text == "" || countrytxt.Text == "" || !citycodetxt.MaskCompleted || !numbertxt.MaskCompleted) 
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                connection = new OracleConnection(conStr);
                connection.Open();
                string query = "INSERT INTO address VALUES ('" + citycodetxt.Text + "','" + citytxt.Text + "','" + countrytxt.Text + "')";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    try { command.ExecuteNonQuery(); }
                    catch {  }
                }
                query = "INSERT INTO customer VALUES ('" + cnictxt.Text + "','" + nametxt.Text + "','" + numbertxt.Text + "','" + citycodetxt.Text + "')";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    try { 
                        command.ExecuteNonQuery();
                        resetFields();
                        setCustomerGrid();
                    }
                    catch { MessageBox.Show("Customer already exists."); }
                }
                connection.Close();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if(!cnictxt.MaskCompleted)
            {
                MessageBox.Show("PLease select a customer.");
            }
            else
            {
                connection = new OracleConnection(conStr);
                connection.Open();
                string query = "DELETE FROM customer WHERE cus_cnic = '" + cnictxt.Text + "'";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        resetFields();
                        setCustomerGrid();
                    }
                    catch { MessageBox.Show("Customer does not exists."); }
                }
                connection.Close();
            }
        }
        private void updateCustomer(string query)
        {
            connection = new OracleConnection(conStr);
            connection.Open();
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                try { command.ExecuteNonQuery(); }
                catch { MessageBox.Show("Customer does not exist."); }
            }
            connection.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (!cnictxt.MaskCompleted)
            {
                MessageBox.Show("Please select a customer.");
            }
            else
            {
                string query;
                if(nametxt.Text != "")
                {
                    query = "UPDATE customer SET cus_name = '" + nametxt.Text + "' WHERE cus_cnic = '" + cnictxt.Text + "'";
                    updateCustomer(query);
                }
                if(numbertxt.MaskCompleted)
                {
                    query = "UPDATE customer SET cus_contact = '" + numbertxt.Text + "' WHERE cus_cnic = '" + cnictxt.Text + "'";
                    updateCustomer(query);
                }
                if (citycodetxt.MaskCompleted && citytxt.Text != "" && countrytxt.Text != "")
                {
                    query = "UPDATE address SET city = '" + citytxt.Text + "', country = '" + countrytxt.Text + "' WHERE city_code = '" + citycodetxt.Text + "'";
                    connection = new OracleConnection(conStr);
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        try { command.ExecuteNonQuery(); }
                        catch {  }
                    }
                    connection.Close();
                }
                resetFields();
            }
        }

        private void customerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the row header or not
            if (e.RowIndex >= 0)
            {
                // Access the clicked row using the RowIndex property
                DataGridViewRow clickedRow = customerGrid.Rows[e.RowIndex];

                // Retrieve the data from the desired cells in the clicked row
                cnictxt.Text = clickedRow.Cells[0].Value.ToString();  // Assuming the first column
                nametxt.Text = clickedRow.Cells[1].Value.ToString();  // Assuming the second column
                citycodetxt.Text = clickedRow.Cells[2].Value.ToString();  // Assuming the second column
                numbertxt.Text = clickedRow.Cells[3].Value.ToString();  // Assuming the second column
                citytxt.Text = clickedRow.Cells[4].Value.ToString();  // Assuming the second column
                countrytxt.Text = clickedRow.Cells[5].Value.ToString();  // Assuming the second colum
            }
        }

        private void customerForm_VisibleChanged(object sender, EventArgs e)
        {
            resetFields();
            setPurchaseGrid();
            setCustomerGrid();
        }

        public string generateCustomerReport()
        {
            DataTable dataTable = (DataTable)customerGrid.DataSource;
            StringBuilder contentBuilder = new StringBuilder();

            contentBuilder.AppendLine("Total Customers: " + (customerGrid.RowCount - 1).ToString());
            decimal total_amount = 0;
            foreach (DataGridViewRow row in purchaseGrid.Rows)
            {
                if (row.Cells["Amount"].Value != null && decimal.TryParse(row.Cells["Amount"].Value.ToString(), out decimal amount))
                {
                    total_amount += amount;
                }
            }
            contentBuilder.AppendLine("Total Amount Customers Spent: " + (total_amount).ToString());
            contentBuilder.AppendLine("\n\t\t\t\tCUSTOMER DETAILS");

            // Table data
            foreach (DataColumn column in dataTable.Columns)
            {
                contentBuilder.Append(column.ColumnName);
                contentBuilder.Append("\t");
            }
            contentBuilder.AppendLine();

            // Table data
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (object item in row.ItemArray)
                {
                    if (item != null)
                    {
                        contentBuilder.Append(item.ToString());
                    }
                    contentBuilder.Append("\t");
                }
                contentBuilder.AppendLine();
            }

            return contentBuilder.ToString();
        }

        private void customerReportbtn_Click(object sender, EventArgs e)
        {
            CustomerReportForm obj = new CustomerReportForm();
            obj.ShowDialog();
        }
    }
}