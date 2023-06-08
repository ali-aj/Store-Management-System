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
    public partial class salesForm : UserControl
    {
        //bool currentReceipt = false;
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=F219088;PASSWORD=5736";
        DataTable receiptTable;
        OracleConnection connection;
        string query;
        public salesForm()
        {
            InitializeComponent();
        }
        private void setReceiptGrid()
        {
            query = "SELECT r.rec_no ID, r.total_amount Amount, s.cus_cnic  FROM receipt r, sales s WHERE r.sales_id = s.sales_id";
            connection = new OracleConnection(conStr);
            connection.Open();
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                receiptDetailGrid.DataSource = table;
            }
            connection.Close();
        }
        private void setItemGrid()
        {
            query = "SELECT item_quantity Quantity, item_name Name, item_price Price, item_barcode Barcode, rack_no Rack FROM item WHERE item_quantity > 0";
            connection = new OracleConnection(conStr);
            connection.Open();
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                addItemGrid.DataSource = table;
            }
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void receiptNotxt_Click(object sender, EventArgs e)
        {
            if(this.receiptNotxt.Text == "Enter item barcode")
            {
                this.receiptNotxt.Text = "";
            }
        }

        private void addItemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if(this.receiptNotxt.Text != "Enter item barcode")
            {
                query = "SELECT item_name Name, item_price Price, item_barcode Barcode, rack_no Rack FROM item WHERE item_barcode = '" + this.receiptNotxt.Text + "'";
                connection = new OracleConnection(conStr);
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    OracleDataAdapter adapter = new OracleDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    addItemGrid.DataSource = table;
                }
                connection.Close();
            }
        }

        private void addItemGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void resetFields()
        {
            itemPrice.Text = "0.0";
            gst.Text = "0.0";
            totalBill.Text = "0.0";
            totalItem.Text = "0";
            receipttxt.Text = "Enter Receipt No";
            receiptNotxt.Text = "Enter item barcode";
            receiptTable = new DataTable();
            receiptTable.Columns.Add("Item Name", typeof(string));
            receiptTable.Columns.Add("Quantity", typeof(int));
            receiptTable.Columns.Add("Unit Price", typeof(decimal));
            receiptTable.Columns.Add("Total Price", typeof(decimal));
            receiptTable.Columns.Add("Barcode", typeof(int));
            receiptGrid.DataSource = receiptTable;
        }

        private void addItemGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the row header or not
            if (e.RowIndex >= 0 && e.RowIndex < addItemGrid.RowCount - 1)
            {
                // Create a new instance of the Form class
                Form inputForm = new Form();

                // Set the title and size of the input form
                inputForm.Text = "Enter Quantity";
                inputForm.Size = new Size(260, 150);

                // Create a new instance of the TextBox class
                TextBox textBox = new TextBox();

                // Set the position and size of the textbox
                textBox.Location = new Point(20, 20);
                textBox.Size = new Size(200, 20);

                // Add the textbox to the input form
                inputForm.Controls.Add(textBox);

                // Create a OK button and set its properties
                Button okButton = new Button();
                okButton.Text = "OK";
                okButton.DialogResult = DialogResult.OK;
                okButton.Location = new Point(70, 50);

                // Add the OK button to the input form
                inputForm.Controls.Add(okButton);

                // Show the input form as a modal dialog and get the result
                inputForm.ShowDialog();
                int quantity = Convert.ToInt32(textBox.Text);
                DataGridViewRow clickedRow = addItemGrid.Rows[e.RowIndex];
                if (!Int32.TryParse(clickedRow.Cells[0].Value.ToString(), out int availableQuantity))
                {
                    MessageBox.Show("Invalid available quantity value.");
                }
                while (true)
                {
                    if (quantity <= 0 || quantity > availableQuantity)
                    {
                        MessageBox.Show("Desired quantity exceeds available quantity.");
                        textBox.Text = "";
                        inputForm.ShowDialog();
                        quantity = Convert.ToInt32(textBox.Text);
                    }
                    else
                    {
                        break;
                    }
                }
                decimal unit_price = Convert.ToDecimal(clickedRow.Cells[2].Value);
                decimal total_price = quantity * unit_price;
                bool check = false;
                foreach (DataGridViewRow row in receiptGrid.Rows)
                {
                    DataGridViewCellCollection cells = row.Cells;
                    int existingItemCode;
                    if (cells[4].Value != null && int.TryParse(cells[4].Value.ToString(), out existingItemCode))
                    {
                        if (existingItemCode == Convert.ToInt64(clickedRow.Cells[3].Value))
                        {
                            cells[1].Value = Convert.ToInt32(cells[1].Value) + quantity;
                            cells[3].Value = Convert.ToDecimal(cells[3].Value) + total_price;
                            check = true;
                            break;
                        }
                    }
                }
                if (check == false)
                {
                    receiptTable.Rows.Add(clickedRow.Cells[1].Value, quantity, unit_price, total_price, clickedRow.Cells[3].Value);
                }
                //if (currentReceipt == false)
                //{
                //    connection = new OracleConnection(conStr);
                //    connection.Open();
                //    using (OracleTransaction transaction = connection.BeginTransaction())
                //    {
                //        transaction.Save("BeforeSale");
                //        //transaction.Rollback(savePoint);
                //    }
                //    connection.Close();
                //}
                reduceQuantity(quantity, Convert.ToInt32(clickedRow.Cells[3].Value.ToString()), availableQuantity);

                totalItem.Text = (Convert.ToInt32(totalItem.Text) + quantity).ToString();
                itemPrice.Text = (Convert.ToDecimal(itemPrice.Text) + total_price).ToString();
                gst.Text = (Convert.ToDecimal(itemPrice.Text) * 0.17m).ToString();
                totalBill.Text = (Convert.ToDecimal(itemPrice.Text) + Convert.ToDecimal(gst.Text)).ToString();
                receiptGrid.DataSource = receiptTable;
                //currentReceipt = true;
            }
        }

        private void reduceQuantity(int quantity, int barcode, int availableQuantity)
        {
            connection = new OracleConnection(conStr);
            connection.Open();
            query = "UPDATE item SET item_quantity = " + (availableQuantity - quantity).ToString() + " WHERE item_barcode = " + barcode;
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
            connection.Close();
            setItemGrid();
        }

        private void salesForm_VisibleChanged(object sender, EventArgs e)
        {
            if (receiptGrid.Rows.Count > 1)
            {
                returnItems();
            }
            setItemGrid();
            setReceiptGrid();
            resetFields();
            //currentReceipt = false;
        }

        private void returnItems()
        {
            connection = new OracleConnection(conStr);
            connection.Open();
            foreach (DataGridViewRow row in receiptGrid.Rows)
            {
                if(row.Index == receiptGrid.Rows.Count - 1)
                {
                    break;
                }
                DataGridViewCellCollection cells = row.Cells;
                query = "UPDATE item SET item_quantity = item_quantity + " + cells[1].Value + " WHERE item_barcode = " + cells[4].Value;
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            if(receiptGrid.Rows.Count > 1)
            {
                returnItems();
            }
            setItemGrid();
            resetFields();
        }
        private string getCnic()
        {
            // Create a new instance of the Form class
            Form inputForm = new Form();

            // Set the title and size of the input form
            inputForm.Text = "Enter Cnic of Customer";
            inputForm.Size = new Size(350, 150);

            // Create a new instance of the TextBox class
            MaskedTextBox textBox = new MaskedTextBox();
            textBox.Mask = "00000-0000000-0";

            // Set the position and size of the textbox
            textBox.Location = new Point(20, 20);
            textBox.Size = new Size(200, 20);

            // Add the textbox to the input form
            inputForm.Controls.Add(textBox);

            // Create a OK button and set its properties
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(70, 50);

            // Add the OK button to the input form
            inputForm.Controls.Add(okButton);

            // Show the input form as a modal dialog and get the result
            inputForm.ShowDialog();
            return textBox.Text;
        }
        private string getUerName()
        {
            // Create a new instance of the Form class
            Form inputForm = new Form();

            // Set the title and size of the input form
            inputForm.Text = "Enter your username";
            inputForm.Size = new Size(350, 150);

            // Create a new instance of the TextBox class
            TextBox textBox = new TextBox();

            // Set the position and size of the textbox
            textBox.Location = new Point(20, 20);
            textBox.Size = new Size(200, 20);

            // Add the textbox to the input form
            inputForm.Controls.Add(textBox);

            // Create a OK button and set its properties
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(70, 50);

            // Add the OK button to the input form
            inputForm.Controls.Add(okButton);

            // Show the input form as a modal dialog and get the result
            inputForm.ShowDialog();
            return textBox.Text;
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            if(receiptGrid.RowCount > 1)
            {
                string cnic = getCnic();
                connection = new OracleConnection(conStr);
                connection.Open();
                bool check = false;
                DateTime currentDate = DateTime.Now;
                query = "INSERT INTO sales VALUES(sales_id_SEQ.NEXTVAL, TO_DATE('" + currentDate.ToShortDateString() + "', 'dd/mm/yyyy'), " + totalBill.Text + ",'" + cnic + "')";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        check = true;
                    }
                    catch
                    {
                        MessageBox.Show("Customer does not exist.");
                    }
                }
                if (check)
                {
                    int rows = receiptGrid.RowCount - 1;
                    foreach (DataGridViewRow row in receiptGrid.Rows)
                    {
                        DataGridViewCellCollection cells = row.Cells;
                        int barcode = Convert.ToInt32(cells[4].Value);
                        query = "SELECT item_id FROM item WHERE item_barcode = " + barcode;
                        int id;
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            id = Convert.ToInt32(command.ExecuteScalar());
                        }
                        query = "SELECT sales_id FROM sales ORDER BY sales_id desc";
                        int salesID;
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            salesID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        bool check1 = false;
                        while (true)
                        {
                            string userName = getUerName();
                            query = "INSERT INTO receipt VALUES(rec_no_SEQ.NEXTVAL, TO_DATE(' " + currentDate.ToShortDateString() + "', 'dd/mm/yyyy'), " + itemPrice.Text + ", " + gst.Text + ", " + totalBill.Text + ", 0,'" + userName + "', " + salesID + ")";
                            using (OracleCommand command = new OracleCommand(query, connection))
                            {
                                try
                                {
                                    command.ExecuteNonQuery();
                                    check1 = true;
                                }
                                catch
                                {
                                    MessageBox.Show("User does not exist.");
                                }
                            }
                            if (check1)
                            {
                                break;
                            }
                        }
                        query = "INSERT INTO sales_items VALUES(" + salesID + "," + id + "," + cells[1].Value + "," + cells[2].Value + ")";
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        rows--;
                        if (rows == 0)
                        {
                            break;
                        }
                    }
                    resetFields();
                    setItemGrid();
                    setReceiptGrid();
                }
                connection.Close();
            }
        }

        private bool checkReceiptExist(int recNo)
        {
            query = "SELECT rec_no FROM receipt WHERE rec_no = " + recNo;
            connection = new OracleConnection(conStr);
            connection.Open();
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                if(Convert.ToInt32(command.ExecuteScalar()) != recNo)
                {
                    MessageBox.Show("Receipt does not exist");
                    connection.Close();
                    return false;
                }
            }
            connection.Close();
            return true;
        }

        private void refundbtn_Click(object sender, EventArgs e)
        {
            if(receipttxt.Text!= "Enter Receipt No")
            {
                if (checkReceiptExist(Convert.ToInt32(receipttxt.Text)))
                {
                    query = "salesRecordDelete";
                    //query = "DELETE FROM receipt WHERE rec_no = " + receipttxt.Text;
                    connection = new OracleConnection(conStr);
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("recNo", OracleDbType.Int32).Value = receipttxt.Text;
                        int rows = command.ExecuteNonQuery();
                        resetFields();
                        setReceiptGrid();
                    }
                    connection.Close();
                }
            }
        }

        private void receipttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void receipttxt_Click(object sender, EventArgs e)
        {
            if (receipttxt.Text == "Enter Receipt No")
            {
                receipttxt.Text = "";
            }
        }
    }
}