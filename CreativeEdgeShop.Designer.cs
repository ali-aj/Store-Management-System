
namespace Final_Project_DB_Lab
{
    partial class CreativeEdgeShop
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreativeEdgeShop));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.crossbtn = new System.Windows.Forms.Button();
            this.shopName = new System.Windows.Forms.Label();
            this.homepagePanel = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.adduserbtn = new System.Windows.Forms.Button();
            this.inventorybtn = new System.Windows.Forms.Button();
            this.rackbtn = new System.Windows.Forms.Button();
            this.vendorbtn = new System.Windows.Forms.Button();
            this.cusbtn = new System.Windows.Forms.Button();
            this.salesbtn = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.signasPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.expensebtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.resizebtn = new System.Windows.Forms.Button();
            this.addUser2 = new Final_Project_DB_Lab.addUser();
            this.loginForm1 = new Final_Project_DB_Lab.loginForm();
            this.inventoryForm1 = new Final_Project_DB_Lab.inventoryForm();
            this.rackForm1 = new Final_Project_DB_Lab.rackForm();
            this.salesForm1 = new Final_Project_DB_Lab.salesForm();
            this.vendorForm1 = new Final_Project_DB_Lab.vendorForm();
            this.customerForm1 = new Final_Project_DB_Lab.customerForm();
            this.dashboardForm1 = new Final_Project_DB_Lab.dashboardForm();
            this.expenseForm1 = new Final_Project_DB_Lab.ExpenseForm();
            this.headerPanel.SuspendLayout();
            this.homepagePanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.signasPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Azure;
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerPanel.Controls.Add(this.minimizebtn);
            this.headerPanel.Controls.Add(this.resizebtn);
            this.headerPanel.Controls.Add(this.crossbtn);
            this.headerPanel.Controls.Add(this.shopName);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1920, 49);
            this.headerPanel.TabIndex = 2;
            // 
            // crossbtn
            // 
            this.crossbtn.BackColor = System.Drawing.Color.Azure;
            this.crossbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crossbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crossbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.crossbtn.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.crossbtn.FlatAppearance.BorderSize = 0;
            this.crossbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.crossbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crossbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.crossbtn.Location = new System.Drawing.Point(1861, 0);
            this.crossbtn.Name = "crossbtn";
            this.crossbtn.Size = new System.Drawing.Size(55, 45);
            this.crossbtn.TabIndex = 1;
            this.crossbtn.Text = "X";
            this.crossbtn.UseVisualStyleBackColor = false;
            this.crossbtn.Click += new System.EventHandler(this.crossbtn_Click);
            // 
            // shopName
            // 
            this.shopName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shopName.AutoSize = true;
            this.shopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.shopName.Location = new System.Drawing.Point(766, -1);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(360, 40);
            this.shopName.TabIndex = 0;
            this.shopName.Text = "Creative Edge Store";
            // 
            // homepagePanel
            // 
            this.homepagePanel.Controls.Add(this.centerPanel);
            this.homepagePanel.Controls.Add(this.sidebarPanel);
            this.homepagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homepagePanel.Location = new System.Drawing.Point(0, 49);
            this.homepagePanel.Name = "homepagePanel";
            this.homepagePanel.Size = new System.Drawing.Size(1920, 1001);
            this.homepagePanel.TabIndex = 3;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.expenseForm1);
            this.centerPanel.Controls.Add(this.addUser2);
            this.centerPanel.Controls.Add(this.loginForm1);
            this.centerPanel.Controls.Add(this.inventoryForm1);
            this.centerPanel.Controls.Add(this.rackForm1);
            this.centerPanel.Controls.Add(this.salesForm1);
            this.centerPanel.Controls.Add(this.vendorForm1);
            this.centerPanel.Controls.Add(this.customerForm1);
            this.centerPanel.Controls.Add(this.dashboardForm1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(334, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1586, 1001);
            this.centerPanel.TabIndex = 3;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebarPanel.Controls.Add(this.expensebtn);
            this.sidebarPanel.Controls.Add(this.adduserbtn);
            this.sidebarPanel.Controls.Add(this.inventorybtn);
            this.sidebarPanel.Controls.Add(this.rackbtn);
            this.sidebarPanel.Controls.Add(this.vendorbtn);
            this.sidebarPanel.Controls.Add(this.cusbtn);
            this.sidebarPanel.Controls.Add(this.salesbtn);
            this.sidebarPanel.Controls.Add(this.dashboardbtn);
            this.sidebarPanel.Controls.Add(this.signasPanel);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(334, 1001);
            this.sidebarPanel.TabIndex = 2;
            // 
            // adduserbtn
            // 
            this.adduserbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.adduserbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.adduserbtn.FlatAppearance.BorderSize = 0;
            this.adduserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adduserbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduserbtn.ForeColor = System.Drawing.Color.White;
            this.adduserbtn.Location = new System.Drawing.Point(0, 714);
            this.adduserbtn.Name = "adduserbtn";
            this.adduserbtn.Size = new System.Drawing.Size(334, 73);
            this.adduserbtn.TabIndex = 8;
            this.adduserbtn.Text = "Add User";
            this.adduserbtn.UseVisualStyleBackColor = false;
            this.adduserbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // inventorybtn
            // 
            this.inventorybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.inventorybtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventorybtn.FlatAppearance.BorderSize = 0;
            this.inventorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventorybtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorybtn.ForeColor = System.Drawing.Color.White;
            this.inventorybtn.Location = new System.Drawing.Point(0, 641);
            this.inventorybtn.Name = "inventorybtn";
            this.inventorybtn.Size = new System.Drawing.Size(334, 73);
            this.inventorybtn.TabIndex = 7;
            this.inventorybtn.Text = "Inventory";
            this.inventorybtn.UseVisualStyleBackColor = false;
            this.inventorybtn.Click += new System.EventHandler(this.inventorybtn_Click);
            // 
            // rackbtn
            // 
            this.rackbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.rackbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rackbtn.FlatAppearance.BorderSize = 0;
            this.rackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rackbtn.ForeColor = System.Drawing.Color.White;
            this.rackbtn.Location = new System.Drawing.Point(0, 568);
            this.rackbtn.Name = "rackbtn";
            this.rackbtn.Size = new System.Drawing.Size(334, 73);
            this.rackbtn.TabIndex = 6;
            this.rackbtn.Text = "Racks";
            this.rackbtn.UseVisualStyleBackColor = false;
            this.rackbtn.Click += new System.EventHandler(this.rackbtn_Click);
            // 
            // vendorbtn
            // 
            this.vendorbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.vendorbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vendorbtn.FlatAppearance.BorderSize = 0;
            this.vendorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorbtn.ForeColor = System.Drawing.Color.White;
            this.vendorbtn.Location = new System.Drawing.Point(0, 495);
            this.vendorbtn.Name = "vendorbtn";
            this.vendorbtn.Size = new System.Drawing.Size(334, 73);
            this.vendorbtn.TabIndex = 4;
            this.vendorbtn.Text = "Vendors";
            this.vendorbtn.UseVisualStyleBackColor = false;
            this.vendorbtn.Click += new System.EventHandler(this.vendorbtn_Click);
            // 
            // cusbtn
            // 
            this.cusbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.cusbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cusbtn.FlatAppearance.BorderSize = 0;
            this.cusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusbtn.ForeColor = System.Drawing.Color.White;
            this.cusbtn.Location = new System.Drawing.Point(0, 422);
            this.cusbtn.Name = "cusbtn";
            this.cusbtn.Size = new System.Drawing.Size(334, 73);
            this.cusbtn.TabIndex = 3;
            this.cusbtn.Text = "Customers";
            this.cusbtn.UseVisualStyleBackColor = false;
            this.cusbtn.Click += new System.EventHandler(this.cusbtn_Click);
            // 
            // salesbtn
            // 
            this.salesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.salesbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesbtn.FlatAppearance.BorderSize = 0;
            this.salesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesbtn.ForeColor = System.Drawing.Color.White;
            this.salesbtn.Location = new System.Drawing.Point(0, 349);
            this.salesbtn.Name = "salesbtn";
            this.salesbtn.Size = new System.Drawing.Size(334, 73);
            this.salesbtn.TabIndex = 2;
            this.salesbtn.Text = "Sales";
            this.salesbtn.UseVisualStyleBackColor = false;
            this.salesbtn.Click += new System.EventHandler(this.salesbtn_Click);
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.dashboardbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardbtn.FlatAppearance.BorderSize = 0;
            this.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbtn.ForeColor = System.Drawing.Color.White;
            this.dashboardbtn.Location = new System.Drawing.Point(0, 276);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(334, 73);
            this.dashboardbtn.TabIndex = 0;
            this.dashboardbtn.Text = "Dashboard";
            this.dashboardbtn.UseVisualStyleBackColor = false;
            this.dashboardbtn.Click += new System.EventHandler(this.dashboardbtn_Click);
            // 
            // signasPanel
            // 
            this.signasPanel.Controls.Add(this.panel1);
            this.signasPanel.Controls.Add(this.logoutbtn);
            this.signasPanel.Controls.Add(this.label1);
            this.signasPanel.Controls.Add(this.pictureBox1);
            this.signasPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.signasPanel.Location = new System.Drawing.Point(0, 0);
            this.signasPanel.Name = "signasPanel";
            this.signasPanel.Size = new System.Drawing.Size(334, 276);
            this.signasPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userName);
            this.panel1.Location = new System.Drawing.Point(3, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 56);
            this.panel1.TabIndex = 7;
            // 
            // userName
            // 
            this.userName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.userName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userName.Location = new System.Drawing.Point(0, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(325, 56);
            this.userName.TabIndex = 0;
            this.userName.Text = "Please Login In First";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(115, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Signed As";
            // 
            // expensebtn
            // 
            this.expensebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.expensebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.expensebtn.FlatAppearance.BorderSize = 0;
            this.expensebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expensebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensebtn.ForeColor = System.Drawing.Color.White;
            this.expensebtn.Location = new System.Drawing.Point(0, 787);
            this.expensebtn.Name = "expensebtn";
            this.expensebtn.Size = new System.Drawing.Size(334, 73);
            this.expensebtn.TabIndex = 9;
            this.expensebtn.Text = "Expenses";
            this.expensebtn.UseVisualStyleBackColor = false;
            this.expensebtn.Click += new System.EventHandler(this.expensebtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.logoutbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutbtn.BackgroundImage")));
            this.logoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.logoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Location = new System.Drawing.Point(264, 66);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(64, 67);
            this.logoutbtn.TabIndex = 1;
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // minimizebtn
            // 
            this.minimizebtn.BackColor = System.Drawing.Color.Azure;
            this.minimizebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizebtn.BackgroundImage")));
            this.minimizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizebtn.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.minimizebtn.FlatAppearance.BorderSize = 0;
            this.minimizebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minimizebtn.Location = new System.Drawing.Point(1751, 0);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(55, 45);
            this.minimizebtn.TabIndex = 3;
            this.minimizebtn.UseVisualStyleBackColor = false;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // resizebtn
            // 
            this.resizebtn.BackColor = System.Drawing.Color.Azure;
            this.resizebtn.BackgroundImage = global::Final_Project_DB_Lab.Properties.Resources.copy;
            this.resizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resizebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.resizebtn.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.resizebtn.FlatAppearance.BorderSize = 0;
            this.resizebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.resizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resizebtn.Location = new System.Drawing.Point(1806, 0);
            this.resizebtn.Name = "resizebtn";
            this.resizebtn.Size = new System.Drawing.Size(55, 45);
            this.resizebtn.TabIndex = 2;
            this.resizebtn.UseVisualStyleBackColor = false;
            this.resizebtn.Click += new System.EventHandler(this.resizebtn_Click);
            // 
            // addUser2
            // 
            this.addUser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUser2.Location = new System.Drawing.Point(0, 0);
            this.addUser2.Name = "addUser2";
            this.addUser2.Size = new System.Drawing.Size(1586, 1001);
            this.addUser2.TabIndex = 7;
            this.addUser2.Visible = false;
            // 
            // loginForm1
            // 
            this.loginForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginForm1.Location = new System.Drawing.Point(0, 0);
            this.loginForm1.Name = "loginForm1";
            this.loginForm1.Size = new System.Drawing.Size(1586, 1001);
            this.loginForm1.TabIndex = 6;
            // 
            // inventoryForm1
            // 
            this.inventoryForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryForm1.Location = new System.Drawing.Point(0, 0);
            this.inventoryForm1.Name = "inventoryForm1";
            this.inventoryForm1.Size = new System.Drawing.Size(1586, 1001);
            this.inventoryForm1.TabIndex = 5;
            this.inventoryForm1.Visible = false;
            // 
            // rackForm1
            // 
            this.rackForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rackForm1.Location = new System.Drawing.Point(0, 0);
            this.rackForm1.Name = "rackForm1";
            this.rackForm1.Size = new System.Drawing.Size(1586, 1001);
            this.rackForm1.TabIndex = 4;
            this.rackForm1.Visible = false;
            // 
            // salesForm1
            // 
            this.salesForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesForm1.Location = new System.Drawing.Point(0, 0);
            this.salesForm1.Name = "salesForm1";
            this.salesForm1.Size = new System.Drawing.Size(1586, 1001);
            this.salesForm1.TabIndex = 3;
            this.salesForm1.Visible = false;
            // 
            // vendorForm1
            // 
            this.vendorForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorForm1.Location = new System.Drawing.Point(0, 0);
            this.vendorForm1.Name = "vendorForm1";
            this.vendorForm1.Size = new System.Drawing.Size(1586, 1001);
            this.vendorForm1.TabIndex = 2;
            this.vendorForm1.Visible = false;
            // 
            // customerForm1
            // 
            this.customerForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerForm1.Location = new System.Drawing.Point(0, 0);
            this.customerForm1.Name = "customerForm1";
            this.customerForm1.Size = new System.Drawing.Size(1586, 1001);
            this.customerForm1.TabIndex = 1;
            this.customerForm1.Visible = false;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardForm1.Location = new System.Drawing.Point(0, 0);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1586, 1001);
            this.dashboardForm1.TabIndex = 0;
            // 
            // expenseForm1
            // 
            this.expenseForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expenseForm1.Location = new System.Drawing.Point(0, 0);
            this.expenseForm1.Name = "expenseForm1";
            this.expenseForm1.Size = new System.Drawing.Size(1586, 1001);
            this.expenseForm1.TabIndex = 8;
            // 
            // CreativeEdgeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1050);
            this.Controls.Add(this.homepagePanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreativeEdgeShop";
            this.Text = "CreativeEdgeShop";
            this.Load += new System.EventHandler(this.CreativeEdgeShop_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.homepagePanel.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.sidebarPanel.ResumeLayout(false);
            this.signasPanel.ResumeLayout(false);
            this.signasPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Button resizebtn;
        private System.Windows.Forms.Button crossbtn;
        private System.Windows.Forms.Label shopName;
        private System.Windows.Forms.Panel homepagePanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel signasPanel;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Button vendorbtn;
        private System.Windows.Forms.Button cusbtn;
        private System.Windows.Forms.Button salesbtn;
        private System.Windows.Forms.Button rackbtn;
        private dashboardForm dashboardForm1;
        private customerForm customerForm1;
        private vendorForm vendorForm1;
        private salesForm salesForm1;
        private rackForm rackForm1;
        private System.Windows.Forms.Button inventorybtn;
        private inventoryForm inventoryForm1;
        private loginForm loginForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button adduserbtn;
        private addUser addUser2;
        private System.Windows.Forms.Button expensebtn;
        private ExpenseForm expenseForm1;
    }
}