
namespace ระบบจองล็อคตลาด
{
    partial class EmployeeData_
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataEmployee = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EnShearh = new System.Windows.Forms.TextBox();
            this.Sherchbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "รายชื่อพนักงาน";
            // 
            // dataEmployee
            // 
            this.dataEmployee.AllowUserToAddRows = false;
            this.dataEmployee.AllowUserToDeleteRows = false;
            this.dataEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployee.Location = new System.Drawing.Point(26, 262);
            this.dataEmployee.Name = "dataEmployee";
            this.dataEmployee.ReadOnly = true;
            this.dataEmployee.RowHeadersWidth = 62;
            this.dataEmployee.RowTemplate.Height = 28;
            this.dataEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEmployee.Size = new System.Drawing.Size(1466, 747);
            this.dataEmployee.TabIndex = 4;
            this.dataEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataEmployee.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmployee_CellContentDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(-14, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1955, 20);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.EnShearh);
            this.panel1.Controls.Add(this.Sherchbtn);
            this.panel1.Location = new System.Drawing.Point(1106, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 62);
            this.panel1.TabIndex = 9;
            // 
            // EnShearh
            // 
            this.EnShearh.Location = new System.Drawing.Point(18, 19);
            this.EnShearh.Name = "EnShearh";
            this.EnShearh.Size = new System.Drawing.Size(250, 26);
            this.EnShearh.TabIndex = 2;
            // 
            // Sherchbtn
            // 
            this.Sherchbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sherchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sherchbtn.Image = global::ระบบจองล็อคตลาด.Properties.Resources.search;
            this.Sherchbtn.Location = new System.Drawing.Point(284, 15);
            this.Sherchbtn.Name = "Sherchbtn";
            this.Sherchbtn.Size = new System.Drawing.Size(101, 34);
            this.Sherchbtn.TabIndex = 19;
            this.Sherchbtn.Text = "ค้นหา";
            this.Sherchbtn.UseVisualStyleBackColor = false;
            this.Sherchbtn.Click += new System.EventHandler(this.Sherchbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.dataEmployee);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(195, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1522, 1056);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_color_logo;
            this.pictureBox1.Location = new System.Drawing.Point(264, -170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1937, 265);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeData_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "EmployeeData_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeData";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox EnShearh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Sherchbtn;
        public System.Windows.Forms.DataGridView dataEmployee;
    }
}