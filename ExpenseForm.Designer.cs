
namespace Final_Project_DB_Lab
{
    partial class ExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.typetxt = new System.Windows.Forms.MaskedTextBox();
            this.amounttxt = new System.Windows.Forms.MaskedTextBox();
            this.vendortxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productPanel = new System.Windows.Forms.Panel();
            this.expenseGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.expenseLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(292, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXPENSES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.typetxt);
            this.panel2.Controls.Add(this.amounttxt);
            this.panel2.Controls.Add(this.vendortxt);
            this.panel2.Controls.Add(this.nametxt);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addbtn);
            this.panel2.Location = new System.Drawing.Point(17, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 397);
            this.panel2.TabIndex = 16;
            // 
            // typetxt
            // 
            this.typetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.typetxt.Location = new System.Drawing.Point(210, 209);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(796, 37);
            this.typetxt.TabIndex = 11;
            // 
            // amounttxt
            // 
            this.amounttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.amounttxt.Location = new System.Drawing.Point(210, 133);
            this.amounttxt.Mask = "0000.00";
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(796, 37);
            this.amounttxt.TabIndex = 8;
            // 
            // vendortxt
            // 
            this.vendortxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.vendortxt.Location = new System.Drawing.Point(210, 282);
            this.vendortxt.Name = "vendortxt";
            this.vendortxt.Size = new System.Drawing.Size(796, 37);
            this.vendortxt.TabIndex = 7;
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nametxt.Location = new System.Drawing.Point(210, 61);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(796, 37);
            this.nametxt.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(14, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 29);
            this.label11.TabIndex = 6;
            this.label11.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(14, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "Vendor ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(14, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(14, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name";
            // 
            // addbtn
            // 
            this.addbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addbtn.BackgroundImage")));
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Location = new System.Drawing.Point(1054, 154);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(95, 79);
            this.addbtn.TabIndex = 5;
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Wheat;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.totalAmountLabel);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(1210, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(352, 184);
            this.panel5.TabIndex = 18;
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
            // productPanel
            // 
            this.productPanel.Controls.Add(this.expenseGrid);
            this.productPanel.Controls.Add(this.panel3);
            this.productPanel.Location = new System.Drawing.Point(17, 497);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1545, 512);
            this.productPanel.TabIndex = 19;
            // 
            // expenseGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.expenseGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.expenseGrid.ColumnHeadersHeight = 22;
            this.expenseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expenseGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.expenseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expenseGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.expenseGrid.Location = new System.Drawing.Point(0, 58);
            this.expenseGrid.Name = "expenseGrid";
            this.expenseGrid.ReadOnly = true;
            this.expenseGrid.RowHeadersVisible = false;
            this.expenseGrid.RowHeadersWidth = 62;
            this.expenseGrid.RowTemplate.Height = 28;
            this.expenseGrid.Size = new System.Drawing.Size(1545, 454);
            this.expenseGrid.TabIndex = 6;
            this.expenseGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.expenseGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.expenseGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.expenseGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.expenseGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.expenseGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.expenseGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.expenseGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.expenseGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.expenseGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.expenseGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.expenseGrid.ThemeStyle.HeaderStyle.Height = 22;
            this.expenseGrid.ThemeStyle.ReadOnly = true;
            this.expenseGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.expenseGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.expenseGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.expenseGrid.ThemeStyle.RowsStyle.Height = 28;
            this.expenseGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.expenseGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1545, 58);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(692, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "EXPENSES";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.expenseLabel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(1210, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(352, 181);
            this.panel4.TabIndex = 20;
            // 
            // expenseLabel
            // 
            this.expenseLabel.AutoSize = true;
            this.expenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.expenseLabel.Location = new System.Drawing.Point(27, 96);
            this.expenseLabel.Name = "expenseLabel";
            this.expenseLabel.Size = new System.Drawing.Size(42, 46);
            this.expenseLabel.TabIndex = 1;
            this.expenseLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(18, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Expenses";
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExpenseForm";
            this.Size = new System.Drawing.Size(1586, 1031);
            this.VisibleChanged += new System.EventHandler(this.ExpenseForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.productPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expenseGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox typetxt;
        private System.Windows.Forms.MaskedTextBox amounttxt;
        private System.Windows.Forms.TextBox vendortxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel productPanel;
        private Guna.UI2.WinForms.Guna2DataGridView expenseGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label expenseLabel;
        private System.Windows.Forms.Label label3;
    }
}
