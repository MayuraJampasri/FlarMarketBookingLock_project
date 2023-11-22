
namespace ระบบจองล็อคตลาด
{
    partial class CustomerWaitForApprove
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
            this.DataOfCustomer = new System.Windows.Forms.DataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.textSherch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sherchbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataOfCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "รายชื่อผู้จองที่รอการอนุมัติ";
            // 
            // DataOfCustomer
            // 
            this.DataOfCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataOfCustomer.Location = new System.Drawing.Point(83, 338);
            this.DataOfCustomer.Name = "DataOfCustomer";
            this.DataOfCustomer.RowHeadersWidth = 62;
            this.DataOfCustomer.RowTemplate.Height = 28;
            this.DataOfCustomer.Size = new System.Drawing.Size(1326, 611);
            this.DataOfCustomer.TabIndex = 1;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // textSherch
            // 
            this.textSherch.Location = new System.Drawing.Point(17, 16);
            this.textSherch.Name = "textSherch";
            this.textSherch.Size = new System.Drawing.Size(250, 26);
            this.textSherch.TabIndex = 2;
            this.textSherch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Sherchbtn);
            this.panel1.Controls.Add(this.textSherch);
            this.panel1.Location = new System.Drawing.Point(1275, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 62);
            this.panel1.TabIndex = 4;
            // 
            // Sherchbtn
            // 
            this.Sherchbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sherchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sherchbtn.Image = global::ระบบจองล็อคตลาด.Properties.Resources.search;
            this.Sherchbtn.Location = new System.Drawing.Point(273, 12);
            this.Sherchbtn.Name = "Sherchbtn";
            this.Sherchbtn.Size = new System.Drawing.Size(101, 34);
            this.Sherchbtn.TabIndex = 20;
            this.Sherchbtn.Text = "ค้นหา";
            this.Sherchbtn.UseVisualStyleBackColor = false;
            this.Sherchbtn.Click += new System.EventHandler(this.Sherchbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_color_logo;
            this.pictureBox2.Location = new System.Drawing.Point(468, -155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1001, 265);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.DataOfCustomer);
            this.panel3.Location = new System.Drawing.Point(209, -26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1508, 1080);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1236, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "กรอกรหัสผู้จอง";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_logo_black_on_transparent_background;
            this.pictureBox1.Location = new System.Drawing.Point(61, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerWaitForApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "CustomerWaitForApprove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerWaitForApprove";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerWaitForApprove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataOfCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataOfCustomer;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox textSherch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Sherchbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}