
namespace Final_Project_DB_Lab
{
    partial class inventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryForm));
            this.catPanel = new System.Windows.Forms.Panel();
            this.categoriesGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.productPanel = new System.Windows.Forms.Panel();
            this.prodGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.racknotxt = new System.Windows.Forms.MaskedTextBox();
            this.quantitytxt = new System.Windows.Forms.MaskedTextBox();
            this.barcodetxt = new System.Windows.Forms.MaskedTextBox();
            this.reordertxt = new System.Windows.Forms.MaskedTextBox();
            this.pricetxt = new System.Windows.Forms.MaskedTextBox();
            this.descriptxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.totalProdLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.prodIDtxt = new System.Windows.Forms.TextBox();
            this.searchbyid = new System.Windows.Forms.CheckBox();
            this.searchbyname = new System.Windows.Forms.CheckBox();
            this.searchbycategory = new System.Windows.Forms.CheckBox();
            this.shortlistbtn = new System.Windows.Forms.Button();
            this.catPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // catPanel
            // 
            this.catPanel.Controls.Add(this.categoriesGrid);
            this.catPanel.Controls.Add(this.panel8);
            this.catPanel.Location = new System.Drawing.Point(1116, 554);
            this.catPanel.Name = "catPanel";
            this.catPanel.Size = new System.Drawing.Size(447, 451);
            this.catPanel.TabIndex = 12;
            // 
            // categoriesGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.categoriesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.categoriesGrid.ColumnHeadersHeight = 22;
            this.categoriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.categoriesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categoriesGrid.Location = new System.Drawing.Point(0, 58);
            this.categoriesGrid.Name = "categoriesGrid";
            this.categoriesGrid.ReadOnly = true;
            this.categoriesGrid.RowHeadersVisible = false;
            this.categoriesGrid.RowHeadersWidth = 62;
            this.categoriesGrid.RowTemplate.Height = 28;
            this.categoriesGrid.Size = new System.Drawing.Size(447, 393);
            this.categoriesGrid.TabIndex = 6;
            this.categoriesGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.categoriesGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.categoriesGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.categoriesGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.categoriesGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.categoriesGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.categoriesGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categoriesGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.categoriesGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.categoriesGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.categoriesGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.categoriesGrid.ThemeStyle.HeaderStyle.Height = 22;
            this.categoriesGrid.ThemeStyle.ReadOnly = true;
            this.categoriesGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.categoriesGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.categoriesGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.categoriesGrid.ThemeStyle.RowsStyle.Height = 28;
            this.categoriesGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categoriesGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Wheat;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(447, 58);
            this.panel8.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(34, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(391, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "PRODUCT CATEGORIES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1586, 62);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(638, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY";
            // 
            // productPanel
            // 
            this.productPanel.Controls.Add(this.prodGrid);
            this.productPanel.Controls.Add(this.panel3);
            this.productPanel.Location = new System.Drawing.Point(21, 554);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1079, 451);
            this.productPanel.TabIndex = 14;
            // 
            // prodGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.prodGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.prodGrid.ColumnHeadersHeight = 22;
            this.prodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.prodGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodGrid.Location = new System.Drawing.Point(0, 58);
            this.prodGrid.Name = "prodGrid";
            this.prodGrid.ReadOnly = true;
            this.prodGrid.RowHeadersVisible = false;
            this.prodGrid.RowHeadersWidth = 62;
            this.prodGrid.RowTemplate.Height = 28;
            this.prodGrid.Size = new System.Drawing.Size(1079, 393);
            this.prodGrid.TabIndex = 6;
            this.prodGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.prodGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.prodGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.prodGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.prodGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.prodGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.prodGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prodGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.prodGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.prodGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.prodGrid.ThemeStyle.HeaderStyle.Height = 22;
            this.prodGrid.ThemeStyle.ReadOnly = true;
            this.prodGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.prodGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.prodGrid.ThemeStyle.RowsStyle.Height = 28;
            this.prodGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.prodGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodGrid_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1079, 58);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(434, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "PRODUCT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.racknotxt);
            this.panel2.Controls.Add(this.quantitytxt);
            this.panel2.Controls.Add(this.barcodetxt);
            this.panel2.Controls.Add(this.reordertxt);
            this.panel2.Controls.Add(this.pricetxt);
            this.panel2.Controls.Add(this.descriptxt);
            this.panel2.Controls.Add(this.nametxt);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.updatebtn);
            this.panel2.Controls.Add(this.addbtn);
            this.panel2.Controls.Add(this.deletebtn);
            this.panel2.Location = new System.Drawing.Point(21, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 397);
            this.panel2.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(14, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 29);
            this.label12.TabIndex = 15;
            this.label12.Text = "Rack No";
            // 
            // racknotxt
            // 
            this.racknotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.racknotxt.Location = new System.Drawing.Point(210, 301);
            this.racknotxt.Mask = "0000";
            this.racknotxt.Name = "racknotxt";
            this.racknotxt.Size = new System.Drawing.Size(796, 37);
            this.racknotxt.TabIndex = 14;
            this.racknotxt.ValidatingType = typeof(int);
            // 
            // quantitytxt
            // 
            this.quantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.quantitytxt.Location = new System.Drawing.Point(210, 122);
            this.quantitytxt.Mask = "0000";
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(796, 37);
            this.quantitytxt.TabIndex = 11;
            // 
            // barcodetxt
            // 
            this.barcodetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.barcodetxt.Location = new System.Drawing.Point(210, 212);
            this.barcodetxt.Mask = "000000";
            this.barcodetxt.Name = "barcodetxt";
            this.barcodetxt.Size = new System.Drawing.Size(796, 37);
            this.barcodetxt.TabIndex = 10;
            // 
            // reordertxt
            // 
            this.reordertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.reordertxt.Location = new System.Drawing.Point(210, 257);
            this.reordertxt.Mask = "0000";
            this.reordertxt.Name = "reordertxt";
            this.reordertxt.Size = new System.Drawing.Size(796, 37);
            this.reordertxt.TabIndex = 9;
            // 
            // pricetxt
            // 
            this.pricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.pricetxt.Location = new System.Drawing.Point(210, 76);
            this.pricetxt.Mask = "0000.00";
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(796, 37);
            this.pricetxt.TabIndex = 8;
            // 
            // descriptxt
            // 
            this.descriptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.descriptxt.Location = new System.Drawing.Point(210, 168);
            this.descriptxt.Name = "descriptxt";
            this.descriptxt.Size = new System.Drawing.Size(796, 37);
            this.descriptxt.TabIndex = 7;
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nametxt.Location = new System.Drawing.Point(210, 31);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(796, 37);
            this.nametxt.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(14, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 29);
            this.label11.TabIndex = 6;
            this.label11.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(14, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 29);
            this.label10.TabIndex = 6;
            this.label10.Text = "Barcode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(14, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(14, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Reorder Point";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(14, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(14, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name";
            // 
            // updatebtn
            // 
            this.updatebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updatebtn.BackgroundImage")));
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Location = new System.Drawing.Point(1053, 249);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(95, 79);
            this.updatebtn.TabIndex = 3;
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addbtn.BackgroundImage")));
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Location = new System.Drawing.Point(1053, 54);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(95, 79);
            this.addbtn.TabIndex = 5;
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletebtn.BackgroundImage")));
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Location = new System.Drawing.Point(1056, 151);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(95, 79);
            this.deletebtn.TabIndex = 4;
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.totalProdLabel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(1211, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(352, 181);
            this.panel4.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(214, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // totalProdLabel
            // 
            this.totalProdLabel.AutoSize = true;
            this.totalProdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.totalProdLabel.Location = new System.Drawing.Point(27, 96);
            this.totalProdLabel.Name = "totalProdLabel";
            this.totalProdLabel.Size = new System.Drawing.Size(42, 46);
            this.totalProdLabel.TabIndex = 1;
            this.totalProdLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(18, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Products";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Wheat;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.totalAmountLabel);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(1211, 294);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(352, 184);
            this.panel5.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.totalAmountLabel.Location = new System.Drawing.Point(15, 94);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(89, 37);
            this.totalAmountLabel.TabIndex = 1;
            this.totalAmountLabel.Text = "0.0 $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(18, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount";
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Wheat;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchbtn.Location = new System.Drawing.Point(518, 495);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(111, 44);
            this.searchbtn.TabIndex = 19;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // prodIDtxt
            // 
            this.prodIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.prodIDtxt.Location = new System.Drawing.Point(21, 495);
            this.prodIDtxt.Name = "prodIDtxt";
            this.prodIDtxt.Size = new System.Drawing.Size(491, 44);
            this.prodIDtxt.TabIndex = 18;
            this.prodIDtxt.Click += new System.EventHandler(this.receiptNotxt_Click);
            this.prodIDtxt.TextChanged += new System.EventHandler(this.prodIDtxt_TextChanged);
            // 
            // searchbyid
            // 
            this.searchbyid.AutoSize = true;
            this.searchbyid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchbyid.Location = new System.Drawing.Point(646, 505);
            this.searchbyid.Name = "searchbyid";
            this.searchbyid.Size = new System.Drawing.Size(153, 29);
            this.searchbyid.TabIndex = 20;
            this.searchbyid.Text = "Search By ID";
            this.searchbyid.UseVisualStyleBackColor = true;
            this.searchbyid.CheckedChanged += new System.EventHandler(this.searchbyid_CheckedChanged);
            // 
            // searchbyname
            // 
            this.searchbyname.AutoSize = true;
            this.searchbyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchbyname.Location = new System.Drawing.Point(833, 506);
            this.searchbyname.Name = "searchbyname";
            this.searchbyname.Size = new System.Drawing.Size(186, 29);
            this.searchbyname.TabIndex = 20;
            this.searchbyname.Text = "Search By Name";
            this.searchbyname.UseVisualStyleBackColor = true;
            this.searchbyname.CheckedChanged += new System.EventHandler(this.searchbyname_CheckedChanged);
            // 
            // searchbycategory
            // 
            this.searchbycategory.AutoSize = true;
            this.searchbycategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchbycategory.Location = new System.Drawing.Point(1050, 505);
            this.searchbycategory.Name = "searchbycategory";
            this.searchbycategory.Size = new System.Drawing.Size(214, 29);
            this.searchbycategory.TabIndex = 20;
            this.searchbycategory.Text = "Search By Category";
            this.searchbycategory.UseVisualStyleBackColor = true;
            this.searchbycategory.CheckedChanged += new System.EventHandler(this.searchbycategory_CheckedChanged);
            // 
            // shortlistbtn
            // 
            this.shortlistbtn.BackColor = System.Drawing.Color.Wheat;
            this.shortlistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shortlistbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shortlistbtn.Location = new System.Drawing.Point(1323, 496);
            this.shortlistbtn.Name = "shortlistbtn";
            this.shortlistbtn.Size = new System.Drawing.Size(240, 44);
            this.shortlistbtn.TabIndex = 21;
            this.shortlistbtn.Text = "Short List of Stocks";
            this.shortlistbtn.UseVisualStyleBackColor = false;
            this.shortlistbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // inventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shortlistbtn);
            this.Controls.Add(this.searchbycategory);
            this.Controls.Add(this.searchbyname);
            this.Controls.Add(this.searchbyid);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.prodIDtxt);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.catPanel);
            this.Name = "inventoryForm";
            this.Size = new System.Drawing.Size(1586, 1031);
            this.VisibleChanged += new System.EventHandler(this.inventoryForm_VisibleChanged);
            this.catPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.productPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel catPanel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label totalProdLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descriptxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox prodIDtxt;
        private Guna.UI2.WinForms.Guna2DataGridView categoriesGrid;
        private Guna.UI2.WinForms.Guna2DataGridView prodGrid;
        private System.Windows.Forms.MaskedTextBox quantitytxt;
        private System.Windows.Forms.MaskedTextBox barcodetxt;
        private System.Windows.Forms.MaskedTextBox reordertxt;
        private System.Windows.Forms.MaskedTextBox pricetxt;
        private System.Windows.Forms.MaskedTextBox racknotxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox searchbyid;
        private System.Windows.Forms.CheckBox searchbyname;
        private System.Windows.Forms.CheckBox searchbycategory;
        private System.Windows.Forms.Button shortlistbtn;
    }
}
