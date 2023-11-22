
namespace ระบบจองล็อคตลาด
{
    partial class ListCustomerCheck_
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
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.รายละเอียดเพิ่มเติม = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sherchbtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ReData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "รายชื่อผู้รอการอนุมัติ";
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.รายละเอียดเพิ่มเติม});
            this.dataGridCustomer.Location = new System.Drawing.Point(573, 267);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.RowHeadersWidth = 62;
            this.dataGridCustomer.RowTemplate.Height = 28;
            this.dataGridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCustomer.Size = new System.Drawing.Size(903, 509);
            this.dataGridCustomer.TabIndex = 12;
            this.dataGridCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomer_CellContentClick);
            // 
            // รายละเอียดเพิ่มเติม
            // 
            this.รายละเอียดเพิ่มเติม.HeaderText = "รายละเอียดเพิ่มเติม";
            this.รายละเอียดเพิ่มเติม.MinimumWidth = 8;
            this.รายละเอียดเพิ่มเติม.Name = "รายละเอียดเพิ่มเติม";
            this.รายละเอียดเพิ่มเติม.Text = "รายละเอียดเพิ่มเติม";
            this.รายละเอียดเพิ่มเติม.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_color_logo;
            this.pictureBox1.Location = new System.Drawing.Point(503, -210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(998, 330);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ReData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(295, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 1062);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Sherchbtn);
            this.panel2.Controls.Add(this.SearchBox);
            this.panel2.Location = new System.Drawing.Point(759, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 62);
            this.panel2.TabIndex = 15;
            // 
            // Sherchbtn
            // 
            this.Sherchbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sherchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sherchbtn.Location = new System.Drawing.Point(291, 12);
            this.Sherchbtn.Name = "Sherchbtn";
            this.Sherchbtn.Size = new System.Drawing.Size(101, 34);
            this.Sherchbtn.TabIndex = 16;
            this.Sherchbtn.Text = "ค้นหา";
            this.Sherchbtn.UseVisualStyleBackColor = false;
            this.Sherchbtn.Click += new System.EventHandler(this.Sherchbtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(14, 16);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(250, 26);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // ReData
            // 
            this.ReData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReData.Location = new System.Drawing.Point(278, 219);
            this.ReData.Name = "ReData";
            this.ReData.Size = new System.Drawing.Size(115, 48);
            this.ReData.TabIndex = 4;
            this.ReData.Text = "รีเฟรซ";
            this.ReData.UseVisualStyleBackColor = false;
            this.ReData.Click += new System.EventHandler(this.ReData_Click);
            // 
            // ListCustomerCheck_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridCustomer);
            this.Controls.Add(this.panel1);
            this.Name = "ListCustomerCheck_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListCustomerCheck";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListCustomerCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.DataGridViewButtonColumn รายละเอียดเพิ่มเติม;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ReData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button Sherchbtn;
    }
}