
namespace Final_Project_DB_Lab
{
    partial class customerForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseHistory = new System.Windows.Forms.Panel();
            this.purchaseGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.customerInfo = new System.Windows.Forms.Panel();
            this.customerGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.countrytxt = new System.Windows.Forms.TextBox();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.cnictxt = new System.Windows.Forms.MaskedTextBox();
            this.citycodetxt = new System.Windows.Forms.MaskedTextBox();
            this.numbertxt = new System.Windows.Forms.MaskedTextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contacttxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerReportbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.purchaseHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGrid)).BeginInit();
            this.panel5.SuspendLayout();
            this.customerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1586, 62);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(633, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMERS";
            // 
            // purchaseHistory
            // 
            this.purchaseHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purchaseHistory.Controls.Add(this.purchaseGrid);
            this.purchaseHistory.Controls.Add(this.panel5);
            this.purchaseHistory.Location = new System.Drawing.Point(981, 87);
            this.purchaseHistory.Name = "purchaseHistory";
            this.purchaseHistory.Size = new System.Drawing.Size(557, 439);
            this.purchaseHistory.TabIndex = 2;
            // 
            // purchaseGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.purchaseGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.purchaseGrid.ColumnHeadersHeight = 22;
            this.purchaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchaseGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.purchaseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchaseGrid.Location = new System.Drawing.Point(0, 58);
            this.purchaseGrid.Name = "purchaseGrid";
            this.purchaseGrid.ReadOnly = true;
            this.purchaseGrid.RowHeadersVisible = false;
            this.purchaseGrid.RowHeadersWidth = 62;
            this.purchaseGrid.RowTemplate.Height = 28;
            this.purchaseGrid.Size = new System.Drawing.Size(553, 377);
            this.purchaseGrid.TabIndex = 4;
            this.purchaseGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.purchaseGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.purchaseGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.purchaseGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.purchaseGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.purchaseGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.purchaseGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchaseGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.purchaseGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.purchaseGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.purchaseGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.purchaseGrid.ThemeStyle.HeaderStyle.Height = 22;
            this.purchaseGrid.ThemeStyle.ReadOnly = true;
            this.purchaseGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.purchaseGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.purchaseGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.purchaseGrid.ThemeStyle.RowsStyle.Height = 28;
            this.purchaseGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchaseGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Wheat;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(553, 58);
            this.panel5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(97, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "PURCHASE HISTORY";
            // 
            // customerInfo
            // 
            this.customerInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerInfo.Controls.Add(this.customerGrid);
            this.customerInfo.Controls.Add(this.panel2);
            this.customerInfo.Location = new System.Drawing.Point(49, 604);
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.Size = new System.Drawing.Size(1489, 399);
            this.customerInfo.TabIndex = 3;
            // 
            // customerGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.customerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.customerGrid.ColumnHeadersHeight = 22;
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.customerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerGrid.Location = new System.Drawing.Point(0, 58);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.ReadOnly = true;
            this.customerGrid.RowHeadersVisible = false;
            this.customerGrid.RowHeadersWidth = 62;
            this.customerGrid.RowTemplate.Height = 28;
            this.customerGrid.Size = new System.Drawing.Size(1485, 337);
            this.customerGrid.TabIndex = 3;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.customerGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.customerGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customerGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.customerGrid.ThemeStyle.HeaderStyle.Height = 22;
            this.customerGrid.ThemeStyle.ReadOnly = true;
            this.customerGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customerGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.customerGrid.ThemeStyle.RowsStyle.Height = 28;
            this.customerGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.customerGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGrid_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1485, 58);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(544, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "CUSTOMERS DETAIL";
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.White;
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputPanel.Controls.Add(this.countrytxt);
            this.inputPanel.Controls.Add(this.citytxt);
            this.inputPanel.Controls.Add(this.Country);
            this.inputPanel.Controls.Add(this.City);
            this.inputPanel.Controls.Add(this.cnictxt);
            this.inputPanel.Controls.Add(this.citycodetxt);
            this.inputPanel.Controls.Add(this.numbertxt);
            this.inputPanel.Controls.Add(this.updatebtn);
            this.inputPanel.Controls.Add(this.deletebtn);
            this.inputPanel.Controls.Add(this.addbtn);
            this.inputPanel.Controls.Add(this.nametxt);
            this.inputPanel.Controls.Add(this.label);
            this.inputPanel.Controls.Add(this.label7);
            this.inputPanel.Controls.Add(this.label6);
            this.inputPanel.Controls.Add(this.contacttxt);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Location = new System.Drawing.Point(49, 87);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(886, 489);
            this.inputPanel.TabIndex = 4;
            // 
            // countrytxt
            // 
            this.countrytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.countrytxt.Location = new System.Drawing.Point(458, 193);
            this.countrytxt.Name = "countrytxt";
            this.countrytxt.Size = new System.Drawing.Size(367, 39);
            this.countrytxt.TabIndex = 11;
            // 
            // citytxt
            // 
            this.citytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.citytxt.Location = new System.Drawing.Point(58, 193);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(367, 39);
            this.citytxt.TabIndex = 10;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Country.Location = new System.Drawing.Point(587, 152);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(95, 29);
            this.Country.TabIndex = 8;
            this.Country.Text = "Country";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.City.Location = new System.Drawing.Point(187, 152);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(53, 29);
            this.City.TabIndex = 9;
            this.City.Text = "City";
            // 
            // cnictxt
            // 
            this.cnictxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cnictxt.Location = new System.Drawing.Point(457, 311);
            this.cnictxt.Mask = "00000-0000000-0";
            this.cnictxt.Name = "cnictxt";
            this.cnictxt.Size = new System.Drawing.Size(367, 39);
            this.cnictxt.TabIndex = 7;
            // 
            // citycodetxt
            // 
            this.citycodetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.citycodetxt.Location = new System.Drawing.Point(458, 68);
            this.citycodetxt.Mask = "00000";
            this.citycodetxt.Name = "citycodetxt";
            this.citycodetxt.Size = new System.Drawing.Size(367, 39);
            this.citycodetxt.TabIndex = 6;
            // 
            // numbertxt
            // 
            this.numbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numbertxt.Location = new System.Drawing.Point(57, 311);
            this.numbertxt.Mask = "0000-0000000";
            this.numbertxt.Name = "numbertxt";
            this.numbertxt.Size = new System.Drawing.Size(367, 39);
            this.numbertxt.TabIndex = 6;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.White;
            this.updatebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updatebtn.BackgroundImage")));
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Location = new System.Drawing.Point(266, 394);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(112, 85);
            this.updatebtn.TabIndex = 5;
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.White;
            this.deletebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletebtn.BackgroundImage")));
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Location = new System.Drawing.Point(384, 394);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(112, 85);
            this.deletebtn.TabIndex = 5;
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.White;
            this.addbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addbtn.BackgroundImage")));
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Location = new System.Drawing.Point(502, 394);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(112, 85);
            this.addbtn.TabIndex = 5;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nametxt.Location = new System.Drawing.Point(58, 68);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(367, 39);
            this.nametxt.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label.Location = new System.Drawing.Point(605, 269);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(71, 29);
            this.label.TabIndex = 0;
            this.label.Text = "CNIC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(558, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "XXXXX-XXXXXXX-X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(164, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "XXXX-XXXXXXX";
            // 
            // contacttxt
            // 
            this.contacttxt.AutoSize = true;
            this.contacttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contacttxt.Location = new System.Drawing.Point(146, 269);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(187, 29);
            this.contacttxt.TabIndex = 0;
            this.contacttxt.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(587, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "City Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(187, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // customerReportbtn
            // 
            this.customerReportbtn.BackColor = System.Drawing.Color.Wheat;
            this.customerReportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerReportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerReportbtn.Location = new System.Drawing.Point(981, 532);
            this.customerReportbtn.Name = "customerReportbtn";
            this.customerReportbtn.Size = new System.Drawing.Size(555, 44);
            this.customerReportbtn.TabIndex = 23;
            this.customerReportbtn.Text = "Generate Report";
            this.customerReportbtn.UseVisualStyleBackColor = false;
            this.customerReportbtn.Click += new System.EventHandler(this.customerReportbtn_Click);
            // 
            // customerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerReportbtn);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.customerInfo);
            this.Controls.Add(this.purchaseHistory);
            this.Controls.Add(this.panel1);
            this.Name = "customerForm";
            this.Size = new System.Drawing.Size(1586, 1031);
            this.VisibleChanged += new System.EventHandler(this.customerForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.purchaseHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.customerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel purchaseHistory;
        private System.Windows.Forms.Panel customerInfo;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label contacttxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox numbertxt;
        private System.Windows.Forms.MaskedTextBox cnictxt;
        private System.Windows.Forms.TextBox countrytxt;
        private System.Windows.Forms.TextBox citytxt;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView customerGrid;
        private Guna.UI2.WinForms.Guna2DataGridView purchaseGrid;
        private System.Windows.Forms.MaskedTextBox citycodetxt;
        private System.Windows.Forms.Button customerReportbtn;
    }
}
