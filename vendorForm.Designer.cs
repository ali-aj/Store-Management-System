
namespace Final_Project_DB_Lab
{
    partial class vendorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vendorForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.citycodetxt = new System.Windows.Forms.MaskedTextBox();
            this.countrytxt = new System.Windows.Forms.TextBox();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.MaskedTextBox();
            this.numbertxt = new System.Windows.Forms.MaskedTextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contacttxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerInfo = new System.Windows.Forms.Panel();
            this.vendorGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.purchaseHistory = new System.Windows.Forms.Panel();
            this.purchaseGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.vendorReportbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.customerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.purchaseHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGrid)).BeginInit();
            this.panel5.SuspendLayout();
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
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(633, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENDORS";
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.White;
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputPanel.Controls.Add(this.label7);
            this.inputPanel.Controls.Add(this.citycodetxt);
            this.inputPanel.Controls.Add(this.countrytxt);
            this.inputPanel.Controls.Add(this.citytxt);
            this.inputPanel.Controls.Add(this.Country);
            this.inputPanel.Controls.Add(this.City);
            this.inputPanel.Controls.Add(this.idtxt);
            this.inputPanel.Controls.Add(this.numbertxt);
            this.inputPanel.Controls.Add(this.updatebtn);
            this.inputPanel.Controls.Add(this.deletebtn);
            this.inputPanel.Controls.Add(this.addbtn);
            this.inputPanel.Controls.Add(this.nametxt);
            this.inputPanel.Controls.Add(this.label);
            this.inputPanel.Controls.Add(this.label6);
            this.inputPanel.Controls.Add(this.contacttxt);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Location = new System.Drawing.Point(49, 101);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(886, 489);
            this.inputPanel.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(606, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "XXXXX";
            // 
            // citycodetxt
            // 
            this.citycodetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.citycodetxt.Location = new System.Drawing.Point(458, 56);
            this.citycodetxt.Mask = "00000";
            this.citycodetxt.Name = "citycodetxt";
            this.citycodetxt.Size = new System.Drawing.Size(367, 39);
            this.citycodetxt.TabIndex = 29;
            // 
            // countrytxt
            // 
            this.countrytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.countrytxt.Location = new System.Drawing.Point(458, 181);
            this.countrytxt.Name = "countrytxt";
            this.countrytxt.Size = new System.Drawing.Size(367, 39);
            this.countrytxt.TabIndex = 28;
            // 
            // citytxt
            // 
            this.citytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.citytxt.Location = new System.Drawing.Point(58, 181);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(367, 39);
            this.citytxt.TabIndex = 27;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Country.Location = new System.Drawing.Point(587, 140);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(95, 29);
            this.Country.TabIndex = 25;
            this.Country.Text = "Country";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.City.Location = new System.Drawing.Point(187, 140);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(53, 29);
            this.City.TabIndex = 26;
            this.City.Text = "City";
            // 
            // idtxt
            // 
            this.idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.idtxt.Location = new System.Drawing.Point(457, 299);
            this.idtxt.Mask = "00000";
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(367, 39);
            this.idtxt.TabIndex = 24;
            this.idtxt.ValidatingType = typeof(int);
            // 
            // numbertxt
            // 
            this.numbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numbertxt.Location = new System.Drawing.Point(57, 299);
            this.numbertxt.Mask = "0000-0000000";
            this.numbertxt.Name = "numbertxt";
            this.numbertxt.Size = new System.Drawing.Size(367, 39);
            this.numbertxt.TabIndex = 23;
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
            this.updatebtn.Location = new System.Drawing.Point(266, 382);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(112, 85);
            this.updatebtn.TabIndex = 21;
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
            this.deletebtn.Location = new System.Drawing.Point(384, 382);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(112, 85);
            this.deletebtn.TabIndex = 22;
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
            this.addbtn.Location = new System.Drawing.Point(502, 382);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(112, 85);
            this.addbtn.TabIndex = 20;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nametxt.Location = new System.Drawing.Point(58, 56);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(367, 39);
            this.nametxt.TabIndex = 18;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label.Location = new System.Drawing.Point(605, 257);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 29);
            this.label.TabIndex = 16;
            this.label.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(164, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "XXXX-XXXXXXX";
            // 
            // contacttxt
            // 
            this.contacttxt.AutoSize = true;
            this.contacttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contacttxt.Location = new System.Drawing.Point(146, 257);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(187, 29);
            this.contacttxt.TabIndex = 13;
            this.contacttxt.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(587, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "City Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(187, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // customerInfo
            // 
            this.customerInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerInfo.Controls.Add(this.vendorGrid);
            this.customerInfo.Controls.Add(this.panel2);
            this.customerInfo.Location = new System.Drawing.Point(49, 618);
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.Size = new System.Drawing.Size(1489, 399);
            this.customerInfo.TabIndex = 7;
            // 
            // vendorGrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.vendorGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.vendorGrid.ColumnHeadersHeight = 22;
            this.vendorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vendorGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.vendorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.vendorGrid.Location = new System.Drawing.Point(0, 58);
            this.vendorGrid.Name = "vendorGrid";
            this.vendorGrid.ReadOnly = true;
            this.vendorGrid.RowHeadersVisible = false;
            this.vendorGrid.RowHeadersWidth = 62;
            this.vendorGrid.RowTemplate.Height = 28;
            this.vendorGrid.Size = new System.Drawing.Size(1485, 337);
            this.vendorGrid.TabIndex = 5;
            this.vendorGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.vendorGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.vendorGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.vendorGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.vendorGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.vendorGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.vendorGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.vendorGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.vendorGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.vendorGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.vendorGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.vendorGrid.ThemeStyle.HeaderStyle.Height = 22;
            this.vendorGrid.ThemeStyle.ReadOnly = true;
            this.vendorGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.vendorGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.vendorGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.vendorGrid.ThemeStyle.RowsStyle.Height = 28;
            this.vendorGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.vendorGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.vendorGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorGrid_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1485, 58);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(588, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "VENDORS DETAIL";
            // 
            // purchaseHistory
            // 
            this.purchaseHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purchaseHistory.Controls.Add(this.purchaseGrid);
            this.purchaseHistory.Controls.Add(this.panel5);
            this.purchaseHistory.Location = new System.Drawing.Point(981, 101);
            this.purchaseHistory.Name = "purchaseHistory";
            this.purchaseHistory.Size = new System.Drawing.Size(557, 439);
            this.purchaseHistory.TabIndex = 6;
            // 
            // purchaseGrid
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.purchaseGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.purchaseGrid.ColumnHeadersHeight = 22;
            this.purchaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchaseGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.purchaseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchaseGrid.Location = new System.Drawing.Point(0, 58);
            this.purchaseGrid.Name = "purchaseGrid";
            this.purchaseGrid.ReadOnly = true;
            this.purchaseGrid.RowHeadersVisible = false;
            this.purchaseGrid.RowHeadersWidth = 62;
            this.purchaseGrid.RowTemplate.Height = 28;
            this.purchaseGrid.Size = new System.Drawing.Size(553, 377);
            this.purchaseGrid.TabIndex = 5;
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
            this.panel5.TabIndex = 3;
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
            // vendorReportbtn
            // 
            this.vendorReportbtn.BackColor = System.Drawing.Color.Wheat;
            this.vendorReportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorReportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vendorReportbtn.Location = new System.Drawing.Point(981, 546);
            this.vendorReportbtn.Name = "vendorReportbtn";
            this.vendorReportbtn.Size = new System.Drawing.Size(555, 44);
            this.vendorReportbtn.TabIndex = 22;
            this.vendorReportbtn.Text = "Generate Report";
            this.vendorReportbtn.UseVisualStyleBackColor = false;
            this.vendorReportbtn.Click += new System.EventHandler(this.vendorReportbtn_Click);
            // 
            // vendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vendorReportbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.customerInfo);
            this.Controls.Add(this.purchaseHistory);
            this.Name = "vendorForm";
            this.Size = new System.Drawing.Size(1586, 1031);
            this.VisibleChanged += new System.EventHandler(this.vendorForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.customerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vendorGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.purchaseHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel customerInfo;
        private System.Windows.Forms.Panel purchaseHistory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countrytxt;
        private System.Windows.Forms.TextBox citytxt;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.MaskedTextBox idtxt;
        private System.Windows.Forms.MaskedTextBox numbertxt;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label contacttxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView purchaseGrid;
        private Guna.UI2.WinForms.Guna2DataGridView vendorGrid;
        private System.Windows.Forms.MaskedTextBox citycodetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button vendorReportbtn;
    }
}
