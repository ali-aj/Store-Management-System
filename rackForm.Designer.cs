
namespace Final_Project_DB_Lab
{
    partial class rackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rackForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rackGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.addCategoryPanel = new System.Windows.Forms.Panel();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.descriptxt = new System.Windows.Forms.TextBox();
            this.catNametxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addRackPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.rackCapatxt = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rackNotxt = new System.Windows.Forms.MaskedTextBox();
            this.updateRackbtn = new System.Windows.Forms.Button();
            this.deleteRackbtn = new System.Windows.Forms.Button();
            this.addRackbtn = new System.Windows.Forms.Button();
            this.rackCattxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rackLoctxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rackGrid)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.addCategoryPanel.SuspendLayout();
            this.addRackPanel.SuspendLayout();
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
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(681, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "RACKS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rackGrid);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(26, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 423);
            this.panel2.TabIndex = 8;
            // 
            // rackGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.rackGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rackGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rackGrid.ColumnHeadersHeight = 22;
            this.rackGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rackGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.rackGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rackGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.rackGrid.Location = new System.Drawing.Point(0, 58);
            this.rackGrid.Name = "rackGrid";
            this.rackGrid.ReadOnly = true;
            this.rackGrid.RowHeadersVisible = false;
            this.rackGrid.RowHeadersWidth = 62;
            this.rackGrid.RowTemplate.Height = 28;
            this.rackGrid.Size = new System.Drawing.Size(686, 365);
            this.rackGrid.TabIndex = 5;
            this.rackGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.rackGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.rackGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.rackGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.rackGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.rackGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.rackGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.rackGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rackGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.rackGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rackGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.rackGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.rackGrid.ThemeStyle.HeaderStyle.Height = 22;
            this.rackGrid.ThemeStyle.ReadOnly = true;
            this.rackGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.rackGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.rackGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rackGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.rackGrid.ThemeStyle.RowsStyle.Height = 28;
            this.rackGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.rackGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.rackGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rackGrid_CellClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Wheat;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(686, 58);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(265, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "RACKS";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.productGrid);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(739, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 498);
            this.panel3.TabIndex = 9;
            // 
            // productGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.productGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.productGrid.ColumnHeadersHeight = 22;
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.productGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productGrid.Location = new System.Drawing.Point(0, 58);
            this.productGrid.Name = "productGrid";
            this.productGrid.ReadOnly = true;
            this.productGrid.RowHeadersVisible = false;
            this.productGrid.RowHeadersWidth = 62;
            this.productGrid.RowTemplate.Height = 28;
            this.productGrid.Size = new System.Drawing.Size(820, 440);
            this.productGrid.TabIndex = 5;
            this.productGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.productGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.productGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.productGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.productGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.productGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.productGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.productGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.productGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.productGrid.ThemeStyle.HeaderStyle.Height = 22;
            this.productGrid.ThemeStyle.ReadOnly = true;
            this.productGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.productGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productGrid.ThemeStyle.RowsStyle.Height = 28;
            this.productGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(820, 58);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(323, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "PRODUCTS";
            // 
            // addCategoryPanel
            // 
            this.addCategoryPanel.BackColor = System.Drawing.Color.White;
            this.addCategoryPanel.Controls.Add(this.updatebtn);
            this.addCategoryPanel.Controls.Add(this.deletebtn);
            this.addCategoryPanel.Controls.Add(this.addbtn);
            this.addCategoryPanel.Controls.Add(this.descriptxt);
            this.addCategoryPanel.Controls.Add(this.catNametxt);
            this.addCategoryPanel.Controls.Add(this.label6);
            this.addCategoryPanel.Controls.Add(this.label5);
            this.addCategoryPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCategoryPanel.Location = new System.Drawing.Point(739, 612);
            this.addCategoryPanel.Name = "addCategoryPanel";
            this.addCategoryPanel.Size = new System.Drawing.Size(820, 402);
            this.addCategoryPanel.TabIndex = 10;
            // 
            // updatebtn
            // 
            this.updatebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updatebtn.BackgroundImage")));
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Location = new System.Drawing.Point(251, 294);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(95, 79);
            this.updatebtn.TabIndex = 2;
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletebtn.BackgroundImage")));
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Location = new System.Drawing.Point(352, 294);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(95, 79);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addbtn.BackgroundImage")));
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Location = new System.Drawing.Point(453, 294);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(95, 79);
            this.addbtn.TabIndex = 2;
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // descriptxt
            // 
            this.descriptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.descriptxt.Location = new System.Drawing.Point(96, 214);
            this.descriptxt.Name = "descriptxt";
            this.descriptxt.Size = new System.Drawing.Size(623, 37);
            this.descriptxt.TabIndex = 1;
            // 
            // catNametxt
            // 
            this.catNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.catNametxt.Location = new System.Drawing.Point(99, 78);
            this.catNametxt.Name = "catNametxt";
            this.catNametxt.Size = new System.Drawing.Size(623, 37);
            this.catNametxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(245, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Category  Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(287, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category Name";
            // 
            // addRackPanel
            // 
            this.addRackPanel.BackColor = System.Drawing.Color.White;
            this.addRackPanel.Controls.Add(this.label11);
            this.addRackPanel.Controls.Add(this.rackCapatxt);
            this.addRackPanel.Controls.Add(this.label10);
            this.addRackPanel.Controls.Add(this.rackNotxt);
            this.addRackPanel.Controls.Add(this.updateRackbtn);
            this.addRackPanel.Controls.Add(this.deleteRackbtn);
            this.addRackPanel.Controls.Add(this.addRackbtn);
            this.addRackPanel.Controls.Add(this.rackCattxt);
            this.addRackPanel.Controls.Add(this.label8);
            this.addRackPanel.Controls.Add(this.label9);
            this.addRackPanel.Controls.Add(this.rackLoctxt);
            this.addRackPanel.Controls.Add(this.label4);
            this.addRackPanel.Controls.Add(this.label7);
            this.addRackPanel.Location = new System.Drawing.Point(26, 537);
            this.addRackPanel.Name = "addRackPanel";
            this.addRackPanel.Size = new System.Drawing.Size(686, 477);
            this.addRackPanel.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(597, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "XXXX";
            // 
            // rackCapatxt
            // 
            this.rackCapatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rackCapatxt.Location = new System.Drawing.Point(27, 247);
            this.rackCapatxt.Mask = "0000";
            this.rackCapatxt.Name = "rackCapatxt";
            this.rackCapatxt.Size = new System.Drawing.Size(623, 37);
            this.rackCapatxt.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(597, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "XXXX";
            // 
            // rackNotxt
            // 
            this.rackNotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rackNotxt.Location = new System.Drawing.Point(30, 62);
            this.rackNotxt.Mask = "0000";
            this.rackNotxt.Name = "rackNotxt";
            this.rackNotxt.Size = new System.Drawing.Size(623, 37);
            this.rackNotxt.TabIndex = 13;
            this.rackNotxt.ValidatingType = typeof(int);
            // 
            // updateRackbtn
            // 
            this.updateRackbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateRackbtn.BackgroundImage")));
            this.updateRackbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateRackbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateRackbtn.FlatAppearance.BorderSize = 0;
            this.updateRackbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.updateRackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateRackbtn.Location = new System.Drawing.Point(180, 389);
            this.updateRackbtn.Name = "updateRackbtn";
            this.updateRackbtn.Size = new System.Drawing.Size(95, 79);
            this.updateRackbtn.TabIndex = 10;
            this.updateRackbtn.UseVisualStyleBackColor = true;
            this.updateRackbtn.Click += new System.EventHandler(this.updateRackbtn_Click);
            // 
            // deleteRackbtn
            // 
            this.deleteRackbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteRackbtn.BackgroundImage")));
            this.deleteRackbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteRackbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteRackbtn.FlatAppearance.BorderSize = 0;
            this.deleteRackbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteRackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRackbtn.Location = new System.Drawing.Point(281, 389);
            this.deleteRackbtn.Name = "deleteRackbtn";
            this.deleteRackbtn.Size = new System.Drawing.Size(95, 79);
            this.deleteRackbtn.TabIndex = 11;
            this.deleteRackbtn.UseVisualStyleBackColor = true;
            this.deleteRackbtn.Click += new System.EventHandler(this.deleteRackbtn_Click);
            // 
            // addRackbtn
            // 
            this.addRackbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addRackbtn.BackgroundImage")));
            this.addRackbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addRackbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRackbtn.FlatAppearance.BorderSize = 0;
            this.addRackbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addRackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRackbtn.Location = new System.Drawing.Point(382, 389);
            this.addRackbtn.Name = "addRackbtn";
            this.addRackbtn.Size = new System.Drawing.Size(95, 79);
            this.addRackbtn.TabIndex = 12;
            this.addRackbtn.UseVisualStyleBackColor = true;
            this.addRackbtn.Click += new System.EventHandler(this.addRackbtn_Click);
            // 
            // rackCattxt
            // 
            this.rackCattxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rackCattxt.Location = new System.Drawing.Point(27, 336);
            this.rackCattxt.Name = "rackCattxt";
            this.rackCattxt.Size = new System.Drawing.Size(623, 37);
            this.rackCattxt.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(220, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "Rack Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(220, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "Rack Capacity";
            // 
            // rackLoctxt
            // 
            this.rackLoctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rackLoctxt.Location = new System.Drawing.Point(27, 151);
            this.rackLoctxt.Name = "rackLoctxt";
            this.rackLoctxt.Size = new System.Drawing.Size(623, 37);
            this.rackLoctxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(219, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rack Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(228, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Rack Number";
            // 
            // rackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addRackPanel);
            this.Controls.Add(this.addCategoryPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "rackForm";
            this.Size = new System.Drawing.Size(1586, 1031);
            this.VisibleChanged += new System.EventHandler(this.rackForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rackGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.addCategoryPanel.ResumeLayout(false);
            this.addCategoryPanel.PerformLayout();
            this.addRackPanel.ResumeLayout(false);
            this.addRackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel addCategoryPanel;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox descriptxt;
        private System.Windows.Forms.TextBox catNametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel addRackPanel;
        private System.Windows.Forms.TextBox rackCattxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rackLoctxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateRackbtn;
        private System.Windows.Forms.Button deleteRackbtn;
        private System.Windows.Forms.Button addRackbtn;
        private Guna.UI2.WinForms.Guna2DataGridView rackGrid;
        private Guna.UI2.WinForms.Guna2DataGridView productGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox rackNotxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox rackCapatxt;
    }
}
