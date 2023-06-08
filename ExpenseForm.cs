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
    public partial class ExpenseForm : UserControl
    {
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=F219088;PASSWORD=5736";
        OracleConnection connection;
        string query;
        public ExpenseForm()
        {
            InitializeComponent();
        }
        private void setPanels()
        {
            connection = new OracleConnection(conStr);
            connection.Open();
            query = "SELECT COUNT(*) FROM expenses";
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                this.expenseLabel.Text = Convert.ToString(command.ExecuteScalar());
                if (this.expenseLabel.Text == "")
                {
                    this.expenseLabel.Text = "0";
                }
            }
            query = "SELECT SUM(exp_amount) FROM expenses";
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                this.totalAmountLabel.Text = Convert.ToString(command.ExecuteScalar()) + " $";
                if (this.totalAmountLabel.Text == " $")
                {
                    this.totalAmountLabel.Text = "0.0 $";
                }
            }
            connection.Close();
        }
        private void setExpenseGrid()
        {
            connection = new OracleConnection(conStr);
            connection.Open();
            query = "SELECT e.exp_id ID, e.exp_amount Amount, e.exp_type Type, e.exp_name Name, e.exp_date E_Date, v.ven_name Vendor  FROM expenses e, vendor v WHERE e.ven_id = v.ven_id";
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                expenseGrid.DataSource = table;
            }
            connection.Close();
        }

        private void ExpenseForm_VisibleChanged(object sender, EventArgs e)
        {
            setExpenseGrid();
            setPanels();
            resetFields();
        }
        private void resetFields()
        {
            nametxt.Text = "";
            typetxt.Text = "";
            amounttxt.Text = "";
            vendortxt.Text = "";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if(nametxt.Text == "" || typetxt.Text == "" || !amounttxt.MaskCompleted || vendortxt.Text == "")
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                connection = new OracleConnection(conStr);
                connection.Open();
                DateTime currentDate = DateTime.Now;
                query = "INSERT INTO expenses VALUES(exp_id_SEQ.NEXTVAL, " + amounttxt.Text + ", '" + typetxt.Text + "', '" + nametxt.Text + "', TO_DATE('" + currentDate.ToShortDateString() + "', 'dd/mm/yyyy'), " + vendortxt.Text + ")";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    resetFields();
                    setExpenseGrid();
                    setPanels();
                }
                connection.Close();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
