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
    public partial class rackForm : UserControl
    {
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=F219088;PASSWORD=5736";
        string query;
        OracleConnection connection;
        public rackForm()
        {
            InitializeComponent();
            query = "SELECT item_name Name, item_quantity Quantity, item_price Price, item_barcode Barcode, rack_no Rack, item_desc Description, reorder_point Reorder FROM item";
            setProdGrid(query);
            setRackGrid();
        }
        private void setProdGrid(string query)
        {
            connection = new OracleConnection(conStr);
            connection.Open();
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                productGrid.DataSource = table;
            }
            connection.Close();
        }
        private void setRackGrid()
        {
            query = "SELECT rack_no Rack_No, rack_location Location, rack_capacity Capacity, rack_strength Strength, cat_name Category FROM rack";
            connection = new OracleConnection(conStr);
            connection.Open();
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                rackGrid.DataSource = table;
            }
            connection.Close();
        }
        private void resetFields()
        {
            rackNotxt.Text = "";
            rackLoctxt.Text = "";
            rackCattxt.Text = "";
            rackCapatxt.Text = "";
            catNametxt.Text = "";
            descriptxt.Text = "";
            query = "SELECT item_name Name, item_quantity Quantity, item_price Price, item_barcode Barcode, rack_no Rack, item_desc Description, reorder_point Reorder FROM item";
            setProdGrid(query);
            setRackGrid();
        }

        private void addRackbtn_Click(object sender, EventArgs e)
        {
            if(rackLoctxt.Text == "" || !rackNotxt.MaskCompleted || !rackCapatxt.MaskCompleted || rackCattxt.Text == "")
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                if (checkCategoryExist())
                {
                    connection = new OracleConnection(conStr);
                    connection.Open();
                    query = "INSERT INTO rack VALUES(" + rackNotxt.Text + ",'" + rackLoctxt.Text + "'," + rackCapatxt.Text + ",0" +  ",'" + rackCattxt.Text + "')";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        try
                        {
                            command.ExecuteNonQuery();
                            resetFields();
                        }
                        catch
                        {
                            MessageBox.Show("Rack already exists.");
                        }
                    }
                    connection.Close();
                }
            }
        }
        private bool checkCategoryExist()
        {
            if(rackCattxt.Text == "")
            {
                query = "SELECT * FROM category WHERE cat_name = '" + catNametxt.Text + "'";
            }
            else if (catNametxt.Text == "")
            {
                query = "SELECT * FROM category WHERE cat_name = '" + rackCattxt.Text + "'";
            }
            connection = new OracleConnection(conStr);
            connection.Open();
            string result;
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                result = Convert.ToString(command.ExecuteScalar());
                if ((result != rackCattxt.Text && rackCattxt.Text != "") || (result != catNametxt.Text && catNametxt.Text != ""))
                {
                    MessageBox.Show("Category does not exist. Please insert category first.");
                    connection.Close();
                    return false;
                }
            }
            connection.Close();
            return true;
        }
        private bool checkRackExist()
        {
            query = "SELECT rack_no FROM rack WHERE rack_no = " + Convert.ToInt32(rackNotxt.Text);
            connection = new OracleConnection(conStr);
            connection.Open();
            int result;
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                result = Convert.ToInt32(Convert.ToString(command.ExecuteScalar()));
                if (result != Convert.ToInt32(rackNotxt.Text))
                {
                    MessageBox.Show("Rack does not exist.");
                    connection.Close();
                    return false;
                }
            }
            connection.Close();
            return true;
        }

        private void deleteRackbtn_Click(object sender, EventArgs e)
        {
            if(!rackNotxt.MaskCompleted)
            {
                MessageBox.Show("Please select the rack.");
            }
            else
            {
                if (checkRackExist())
                {
                    connection = new OracleConnection(conStr);
                    connection.Open();
                    query = "DELETE FROM rack WHERE rack_no = " + Convert.ToInt32(rackNotxt.Text);
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        resetFields();
                    }
                    connection.Close();
                }
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if(catNametxt.Text == "" || descriptxt.Text == "")
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                connection = new OracleConnection(conStr);
                connection.Open();
                query = "INSERT INTO category VALUES('" + catNametxt.Text + "','" + descriptxt.Text + "')";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        resetFields();
                    }
                    catch
                    {
                        MessageBox.Show("Category already exists.");
                    }
                }
                connection.Close();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (catNametxt.Text == "")
            {
                MessageBox.Show("Please select the category.");
            }
            else
            {
                if (checkCategoryExist())
                {
                    connection = new OracleConnection(conStr);
                    connection.Open();
                    query = "DELETE FROM category WHERE cat_name = '" + catNametxt.Text + "'";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        resetFields();
                    }
                    connection.Close();
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (catNametxt.Text == "")
            {
                MessageBox.Show("Please select the category.");
            }
            else if (descriptxt.Text != "")
            {
                if (checkCategoryExist())
                {
                    connection = new OracleConnection(conStr);
                    connection.Open();
                    query = "UPDATE category SET cat_description = '" + descriptxt.Text + "' WHERE cat_name = '" + catNametxt.Text + "'";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        resetFields();
                    }
                    connection.Close();
                }
            }
        }

        private void updateRackbtn_Click(object sender, EventArgs e)
        {
            if(!rackNotxt.MaskCompleted)
            {
                MessageBox.Show("Please select the rack.");
            }
            else
            {
                if (checkRackExist())
                {
                    if (rackLoctxt.Text != "")
                    {
                        connection = new OracleConnection(conStr);
                        connection.Open();
                        query = "UPDATE rack SET rack_location = '" + rackLoctxt.Text + "' WHERE rack_no = " + Convert.ToInt32(rackNotxt.Text);
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    if (rackCapatxt.MaskCompleted)
                    {
                        connection = new OracleConnection(conStr);
                        connection.Open();
                        query = "UPDATE rack SET rack_capacity = " + rackCapatxt.Text + " WHERE rack_no = " + Convert.ToInt32(rackNotxt.Text);
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                            setRackGrid();
                        }
                        connection.Close();
                    }
                    if (rackCattxt.Text != "") {
                        if (checkCategoryExist())
                        {
                            connection = new OracleConnection(conStr);
                            connection.Open();
                            query = "UPDATE rack SET cat_name = '" + rackCattxt.Text + "' WHERE rack_no = " + Convert.ToInt32(rackNotxt.Text);
                            using (OracleCommand command = new OracleCommand(query, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                            connection.Close();
                        }
                    }
                    resetFields();
                }
            }
        }

        private void rackForm_VisibleChanged(object sender, EventArgs e)
        {
            resetFields();
        }

        private void rackGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the row header or not
            if (e.RowIndex >= 0)
            {
                // Access the clicked row using the RowIndex property
                DataGridViewRow clickedRow = rackGrid.Rows[e.RowIndex];

                // Retrieve the data from the desired cells in the clicked row
                rackNotxt.Text = clickedRow.Cells[0].Value.ToString();  // Assuming the first column
                rackLoctxt.Text = clickedRow.Cells[1].Value.ToString();  // Assuming the second column
                rackCapatxt.Text = clickedRow.Cells[2].Value.ToString();  // Assuming the second column
                rackCattxt.Text = clickedRow.Cells[4].Value.ToString();  // Assuming the second column
            }
        }
    }
}
