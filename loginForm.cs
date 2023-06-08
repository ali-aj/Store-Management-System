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
    public partial class loginForm : UserControl
    {
        public event EventHandler<string> MyEvent;
        public string name, role;
        public loginForm()
        {
            InitializeComponent();
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            if (!showPassCheck.Checked)
            {
                this.passwordtxt.PasswordChar = '*';
            }
            else
            {
                this.passwordtxt.PasswordChar = '\0';
            }
            if (passwordtxt.Text.Length >= 8)
            {
                loginbtn.Enabled = true;
            }
            else
            {
                loginbtn.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text == "" || passwordtxt.Text == "")
            {
                MessageBox.Show("Fill all the fields.");
            }
            else
            {
                string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=F219088;PASSWORD=5736";
                string query = "SELECT name, user_role FROM users WHERE user_name = '" + this.usernametxt.Text + "' AND user_password = '" + this.passwordtxt.Text + "'";
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        OracleDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            MessageBox.Show("Invalid Credentials");
                            this.usernametxt.Text = "";
                            this.passwordtxt.Text = "";
                        }
                        else
                        {
                            string name = reader.GetString(0);
                            string role = reader.GetString(1);
                            this.Visible = false;
                            this.usernametxt.Text = "";
                            this.passwordtxt.Text = "";
                            // Raise the event with the data
                            if (MyEvent != null)
                            {
                                MyEvent(this, name + '-' + role);
                            }
                        }
                        reader.Close();
                    }
                }
            }
        }
    }
}
