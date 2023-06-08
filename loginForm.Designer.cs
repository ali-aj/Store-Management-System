
namespace Final_Project_DB_Lab
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.showPassCheck = new System.Windows.Forms.CheckBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.loginPanel);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1586, 1001);
            this.mainPanel.TabIndex = 0;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Thistle;
            this.loginPanel.Controls.Add(this.showPassCheck);
            this.loginPanel.Controls.Add(this.loginbtn);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.passwordtxt);
            this.loginPanel.Controls.Add(this.usernametxt);
            this.loginPanel.Controls.Add(this.pictureBox4);
            this.loginPanel.Controls.Add(this.pictureBox3);
            this.loginPanel.Controls.Add(this.pictureBox2);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginPanel.Location = new System.Drawing.Point(915, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(671, 1001);
            this.loginPanel.TabIndex = 3;
            // 
            // showPassCheck
            // 
            this.showPassCheck.AutoSize = true;
            this.showPassCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.showPassCheck.Location = new System.Drawing.Point(48, 745);
            this.showPassCheck.Name = "showPassCheck";
            this.showPassCheck.Size = new System.Drawing.Size(179, 29);
            this.showPassCheck.TabIndex = 6;
            this.showPassCheck.Text = "Show Password";
            this.showPassCheck.UseVisualStyleBackColor = true;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn.Enabled = false;
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.loginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Image = ((System.Drawing.Image)(resources.GetObject("loginbtn.Image")));
            this.loginbtn.Location = new System.Drawing.Point(75, 814);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(511, 65);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(42, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(42, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordtxt.BackColor = System.Drawing.Color.Thistle;
            this.passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(75, 625);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(511, 36);
            this.passwordtxt.TabIndex = 3;
            this.passwordtxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            // 
            // usernametxt
            // 
            this.usernametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernametxt.BackColor = System.Drawing.Color.Thistle;
            this.usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernametxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(75, 443);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(511, 36);
            this.usernametxt.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(-218, 625);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1102, 99);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-218, 443);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1102, 99);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Final_Project_DB_Lab.Properties.Resources.protection;
            this.pictureBox2.Location = new System.Drawing.Point(237, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project_DB_Lab.Properties.Resources.login_pic;
            this.pictureBox1.Location = new System.Drawing.Point(-43, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1010, 1058);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "loginForm";
            this.Size = new System.Drawing.Size(1586, 1001);
            this.mainPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.CheckBox showPassCheck;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
