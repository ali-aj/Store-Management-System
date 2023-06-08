
namespace Final_Project_DB_Lab
{
    partial class vendorReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vendorReportForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vendors = new System.Windows.Forms.Panel();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.purchases = new System.Windows.Forms.Panel();
            this.purchaseLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customerInfo = new System.Windows.Forms.Panel();
            this.vendorGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.vendors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.purchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.customerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vendors
            // 
            this.vendors.BackColor = System.Drawing.Color.LightGreen;
            this.vendors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vendors.Controls.Add(this.vendorLabel);
            this.vendors.Controls.Add(this.pictureBox2);
            this.vendors.Controls.Add(this.label3);
            this.vendors.Location = new System.Drawing.Point(12, 12);
            this.vendors.Name = "vendors";
            this.vendors.Size = new System.Drawing.Size(462, 189);
            this.vendors.TabIndex = 6;
            // 
            // vendorLabel
            // 
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.vendorLabel.Location = new System.Drawing.Point(19, 96);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(63, 69);
            this.vendorLabel.TabIndex = 3;
            this.vendorLabel.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(296, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(26, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vendors";
            // 
            // purchases
            // 
            this.purchases.BackColor = System.Drawing.Color.LightBlue;
            this.purchases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purchases.Controls.Add(this.purchaseLabel);
            this.purchases.Controls.Add(this.pictureBox3);
            this.purchases.Controls.Add(this.label4);
            this.purchases.Location = new System.Drawing.Point(543, 12);
            this.purchases.Name = "purchases";
            this.purchases.Size = new System.Drawing.Size(468, 191);
            this.purchases.TabIndex = 7;
            // 
            // purchaseLabel
            // 
            this.purchaseLabel.AutoSize = true;
            this.purchaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.purchaseLabel.Location = new System.Drawing.Point(15, 105);
            this.purchaseLabel.Name = "purchaseLabel";
            this.purchaseLabel.Size = new System.Drawing.Size(136, 58);
            this.purchaseLabel.TabIndex = 4;
            this.purchaseLabel.Text = "0.0 $";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(287, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 187);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(25, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Purchases";
            // 
            // customerInfo
            // 
            this.customerInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerInfo.Controls.Add(this.vendorGrid);
            this.customerInfo.Controls.Add(this.panel2);
            this.customerInfo.Location = new System.Drawing.Point(12, 210);
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.Size = new System.Drawing.Size(997, 515);
            this.customerInfo.TabIndex = 9;
            // 
            // vendorGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.vendorGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.vendorGrid.ColumnHeadersHeight = 22;
            this.vendorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vendorGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.vendorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.vendorGrid.Location = new System.Drawing.Point(0, 58);
            this.vendorGrid.Name = "vendorGrid";
            this.vendorGrid.ReadOnly = true;
            this.vendorGrid.RowHeadersVisible = false;
            this.vendorGrid.RowHeadersWidth = 62;
            this.vendorGrid.RowTemplate.Height = 28;
            this.vendorGrid.Size = new System.Drawing.Size(993, 453);
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 58);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(341, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "VENDORS DETAIL";
            // 
            // vendorReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 737);
            this.Controls.Add(this.customerInfo);
            this.Controls.Add(this.purchases);
            this.Controls.Add(this.vendors);
            this.Name = "vendorReportForm";
            this.Text = "vendorReportForm";
            this.vendors.ResumeLayout(false);
            this.vendors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.purchases.ResumeLayout(false);
            this.purchases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.customerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vendorGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel vendors;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel purchases;
        private System.Windows.Forms.Label purchaseLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel customerInfo;
        private Guna.UI2.WinForms.Guna2DataGridView vendorGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}