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
    public partial class vendorForm : UserControl
    {
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=F219088;PASSWORD=5736";
        OracleConnection connection;
        public vendorForm()
        {
            InitializeComponent();
            setPurchaseGrid();
            setVendorGrid();
        }
        private void setPurchaseGrid()
        {
            connection = new OracleConnection(conStr);
            connection.Open();
            string query = "SELECT p.pur_id ID, p.pur_amount Amount, p.pur_date P_Date, v.ven_name Vendor FROM purchases p, vendor v  WHERE p.ven_id = v.ven_id";
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
        private void resetFields()
        {
            nametxt.Text = "";
            idtxt.Text = "";
            citycodetxt.Text = "";
            citytxt.Text = "";
            countrytxt.Text = "";
            numbertxt.Text = "";
            setPurchaseGrid();
            setVendorGrid();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (!idtxt.MaskCompleted)
            {
                MessageBox.Show("Please select a vendor.");
            }
            else
            {
                connection = new OracleConnection(conStr);
                connection.Open();
                string query = "DELETE FROM vendor WHERE ven_id = " + idtxt.Text;
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        resetFields();
                        setVendorGrid();
                    }
                    catch { MessageBox.Show("Vendor does not exists."); }
                }
                connection.Close();
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" || !idtxt.MaskCompleted || citytxt.Text == "" || countrytxt.Text == "" || !citycodetxt.MaskCompleted || !numbertxt.MaskCompleted)
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
                    catch { }
                }
                query = "INSERT INTO vendor VALUES (" + idtxt.Text + ",'" + nametxt.Text + "','" + numbertxt.Text + "','" + citycodetxt.Text + "')";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        resetFields();
                        setVendorGrid();
                    }
                    catch { MessageBox.Show("Vendor already exists."); }
                }
                connection.Close();
            }
        }
        private void updateVendor(string query)
        {
            connection = new OracleConnection(conStr);
            connection.Open();
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                try { command.ExecuteNonQuery(); }
                catch { MessageBox.Show("Vendor does not exist."); }
            }
            connection.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (!idtxt.MaskCompleted)
            {
                MessageBox.Show("Please select a vendor.");
            }
            else
            {
                string query;
                if (nametxt.Text != "")
                {
                    query = "UPDATE vendor SET ven_name = '" + nametxt.Text + "' WHERE ven_id = " + idtxt.Text;
                    updateVendor(query);
                }
                if (numbertxt.MaskCompleted)
                {
                    query = "UPDATE vendor SET ven_contact = '" + numbertxt.Text + "' WHERE ven_id = " + idtxt.Text;
                    updateVendor(query);
                }
                if (citycodetxt.MaskCompleted && citytxt.Text != "" && countrytxt.Text != "")
                {
                    query = "UPDATE address SET city = '" + citytxt.Text + "', country = '" + countrytxt.Text + "' WHERE city_code = '" + citycodetxt.Text + "'";
                    connection = new OracleConnection(conStr);
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        try { command.ExecuteNonQuery(); }
                        catch { }
                    }
                    connection.Close();
                }
                resetFields();
            }
        }

        private void vendorGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the row header or not
            if (e.RowIndex >= 0)
            {
                // Access the clicked row using the RowIndex property
                DataGridViewRow clickedRow = vendorGrid.Rows[e.RowIndex];

                // Retrieve the data from the desired cells in the clicked row
                nametxt.Text = clickedRow.Cells[0].Value.ToString();  // Assuming the first column
                idtxt.Text = clickedRow.Cells[1].Value.ToString();  // Assuming the second column
                numbertxt.Text = clickedRow.Cells[2].Value.ToString();  // Assuming the second column
                citycodetxt.Text = clickedRow.Cells[3].Value.ToString();  // Assuming the second column
                citytxt.Text = clickedRow.Cells[4].Value.ToString();  // Assuming the second column
                countrytxt.Text = clickedRow.Cells[5].Value.ToString();  // Assuming the second column
            }
        }

        private void vendorForm_VisibleChanged(object sender, EventArgs e)
        {
            resetFields();
            setPurchaseGrid();
            setVendorGrid();
        }

        private void vendorReportbtn_Click(object sender, EventArgs e)
        {
            vendorReportForm obj = new vendorReportForm();
            obj.ShowDialog();
        }
    }
}
