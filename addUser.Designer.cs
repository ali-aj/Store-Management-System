
namespace Final_Project_DB_Lab
{
    partial class addUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.customerInfo = new System.Windows.Forms.Panel();
            this.userGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.cashierCheck = new System.Windows.Forms.CheckBox();
            this.admincheck = new System.Windows.Forms.CheckBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.customerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
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
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(633, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD USER";
            // 
            // customerInfo
            // 
            this.customerInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerInfo.Controls.Add(this.userGrid);
            this.customerInfo.Controls.Add(this.panel2);
            this.customerInfo.Location = new System.Drawing.Point(46, 528);
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.Size = new System.Drawing.Size(1489, 477);
            this.customerInfo.TabIndex = 8;
            // 
            // userGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.userGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userGrid.ColumnHeadersHeight = 22;
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.userGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userGrid.Location = new System.Drawing.Point(0, 58);
            this.userGrid.Name = "userGrid";
            this.userGrid.ReadOnly = true;
            this.userGrid.RowHeadersVisible = false;
            this.userGrid.RowHeadersWidth = 62;
            this.userGrid.RowTemplate.Height = 28;
            this.userGrid.Size = new System.Drawing.Size(1485, 415);
            this.userGrid.TabIndex = 5;
            this.userGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.userGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.userGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.userGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.userGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.userGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.userGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userGrid.ThemeStyle.HeaderStyle.Height = 22;
            this.userGrid.ThemeStyle.ReadOnly = true;
            this.userGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.userGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userGrid.ThemeStyle.RowsStyle.Height = 28;
            this.userGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGrid_CellClick);
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
            this.label5.Location = new System.Drawing.Point(597, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "USERS DETAIL";
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.White;
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputPanel.Controls.Add(this.cashierCheck);
            this.inputPanel.Controls.Add(this.admincheck);
            this.inputPanel.Controls.Add(this.passwordtxt);
            this.inputPanel.Controls.Add(this.usernametxt);
            this.inputPanel.Controls.Add(this.Country);
            this.inputPanel.Controls.Add(this.City);
            this.inputPanel.Controls.Add(this.updatebtn);
            this.inputPanel.Controls.Add(this.deletebtn);
            this.inputPanel.Controls.Add(this.addbtn);
            this.inputPanel.Controls.Add(this.nametxt);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Location = new System.Drawing.Point(46, 86);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(1489, 418);
            this.inputPanel.TabIndex = 9;
            // 
            // cashierCheck
            // 
            this.cashierCheck.AutoSize = true;
            this.cashierCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cashierCheck.Location = new System.Drawing.Point(1171, 105);
            this.cashierCheck.Name = "cashierCheck";
            this.cashierCheck.Size = new System.Drawing.Size(139, 36);
            this.cashierCheck.TabIndex = 29;
            this.cashierCheck.Text = "Cashier";
            this.cashierCheck.UseVisualStyleBackColor = true;
            this.cashierCheck.CheckedChanged += new System.EventHandler(this.salesCheck_CheckedChanged);
            // 
            // admincheck
            // 
            this.admincheck.AutoSize = true;
            this.admincheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.admincheck.Location = new System.Drawing.Point(740, 105);
            this.admincheck.Name = "admincheck";
            this.admincheck.Size = new System.Drawing.Size(122, 36);
            this.admincheck.TabIndex = 29;
            this.admincheck.Text = "Admin";
            this.admincheck.UseVisualStyleBackColor = true;
            this.admincheck.CheckedChanged += new System.EventHandler(this.admincheck_CheckedChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.passwordtxt.Location = new System.Drawing.Point(738, 274);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(562, 39);
            this.passwordtxt.TabIndex = 28;
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.usernametxt.Location = new System.Drawing.Point(56, 274);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(566, 39);
            this.usernametxt.TabIndex = 27;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Country.Location = new System.Drawing.Point(733, 231);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(120, 29);
            this.Country.TabIndex = 25;
            this.Country.Text = "Password";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.City.Location = new System.Drawing.Point(51, 231);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(124, 29);
            this.City.TabIndex = 26;
            this.City.Text = "Username";
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
            this.updatebtn.Location = new System.Drawing.Point(1353, 288);
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
            this.deletebtn.Location = new System.Drawing.Point(1353, 170);
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
            this.addbtn.Location = new System.Drawing.Point(1353, 45);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(112, 85);
            this.addbtn.TabIndex = 20;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nametxt.Location = new System.Drawing.Point(52, 105);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(570, 39);
            this.nametxt.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(941, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(51, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.customerInfo);
            this.Controls.Add(this.panel1);
            this.Name = "addUser";
            this.Size = new System.Drawing.Size(1586, 1031);
            this.VisibleChanged += new System.EventHandler(this.addUser_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.customerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel customerInfo;
        private Guna.UI2.WinForms.Guna2DataGridView userGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cashierCheck;
        private System.Windows.Forms.CheckBox admincheck;
    }
}
