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
    public partial class addUser : UserControl
    {
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=F219088;PASSWORD=5736";
        OracleConnection connection;
        string query;
        public addUser()
        {
            InitializeComponent();
            setUserGrid();
        }
        private void resetFields()
        {
            usernametxt.Text = "";
            passwordtxt.Text = "";
            admincheck.Checked = false;
            cashierCheck.Checked = false;
            nametxt.Text = "";
            setUserGrid();
        }
        private bool checkUserExist()
        {
            connection = new OracleConnection(conStr);
            connection.Open();
            query = "SELECT user_name FROM users WHERE user_name = '" + usernametxt.Text + "'";
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                if(command.ExecuteScalar().ToString() != usernametxt.Text)
                {
                    MessageBox.Show("User does not exist");
                    connection.Close();
                    return false;
                }
            }
            connection.Close();
            return true;
        }
        private void setUserGrid()
        {
            connection = new OracleConnection(conStr);
            connection.Open();
            query = "SELECT User_Name, Name, user_role Role, user_password Password FROM users";
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                userGrid.DataSource = table;
            }
            connection.Clone();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" || passwordtxt.Text == "" || usernametxt.Text == "" || (!admincheck.Checked && !cashierCheck.Checked))
            {
                MessageBox.Show("Please fill all fields.");
            }
            else
            {
                if(passwordtxt.Text.Length < 8)
                {
                    MessageBox.Show("Password must consist of atleast 8 characters.");
                }
                else
                {
                    string role = admincheck.Checked ? "Admin" : "Cashier";
                    connection = new OracleConnection(conStr);
                    connection.Open();
                    query = "INSERT INTO users VALUES ('" + usernametxt.Text + "','" + nametxt.Text + "','" + role + "','" + passwordtxt.Text + "')";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        try { command.ExecuteNonQuery(); resetFields(); }
                        catch { MessageBox.Show("User already exist with same username."); }
                    }
                    connection.Close();
                }
            }
        }

        private void admincheck_CheckedChanged(object sender, EventArgs e)
        {
            if (admincheck.Checked)
            {
                cashierCheck.Checked = false;
            }
            else
            {
                cashierCheck.Checked = true;
            }
        }

        private void salesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cashierCheck.Checked)
            {
                admincheck.Checked = false;
            }
            else
            {
                admincheck.Checked = true;
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if(usernametxt.Text == "")
            {
                MessageBox.Show("Please select a user.");
            }
            else
            {
                if (checkUserExist())
                {
                    connection = new OracleConnection(conStr);
                    connection.Open();
                    query = "DELETE FROM users WHERE user_name = '" + usernametxt.Text + "'";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        resetFields();
                    }
                    connection.Close();
                }
            }
        }

        private void addUser_VisibleChanged(object sender, EventArgs e)
        {
            resetFields();
            setUserGrid();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text == "")
            {
                MessageBox.Show("Please select a user.");
            }
            else
            {
                if (checkUserExist())
                {
                    connection = new OracleConnection(conStr);
                    connection.Open();
                    if (nametxt.Text != "")
                    {
                        query = "UPDATE users SET name = '" + nametxt.Text + "' WHERE user_name = '" + usernametxt.Text + "'";
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    if (passwordtxt.Text.Length >= 8)
                    {
                        query = "UPDATE users SET user_password = '" + passwordtxt.Text + "' WHERE user_name = '" + usernametxt.Text + "'";
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    if (admincheck.Checked || cashierCheck.Checked)
                    {
                        string role = admincheck.Checked ? "Admin" : "Cashier";
                        query = "UPDATE users SET user_role = '" + role + "' WHERE user_name = '" + usernametxt.Text + "'";
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                    resetFields();
                }
            }
        }

        private void userGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the row header or not
            if (e.RowIndex >= 0)
            {
                // Access the clicked row using the RowIndex property
                DataGridViewRow clickedRow = userGrid.Rows[e.RowIndex];

                // Retrieve the data from the desired cells in the clicked row
                usernametxt.Text = clickedRow.Cells[0].Value.ToString();  // Assuming the first column
                nametxt.Text = clickedRow.Cells[1].Value.ToString();  // Assuming the second column
                if(clickedRow.Cells[2].Value.ToString() == "Admin")
                {
                    admincheck.Checked = true;
                }
                else
                {
                    cashierCheck.Checked = true;
                }
                passwordtxt.Text = clickedRow.Cells[3].Value.ToString();  // Assuming the second column
            }
        }
    }
}
