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
    public partial class ShortListItemsForm : Form
    {
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=F219088;PASSWORD=5736";
        OracleConnection connection;
        public ShortListItemsForm()
        {
            InitializeComponent();
            setItemGrid();
        }
        private void setItemGrid()
        {
            string query = "SELECT item_name Name, item_quantity Quantity, item_price Price, item_barcode Barcode, rack_no Rack, item_desc Description, reorder_point Reorder FROM item WHERE reorder_point > item_quantity";
            connection = new OracleConnection(conStr);
            connection.Open();
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                itemsGrid.DataSource = table;
            }
            connection.Close();
        }
    }
}
