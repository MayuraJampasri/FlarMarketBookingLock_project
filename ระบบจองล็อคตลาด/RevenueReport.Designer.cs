
namespace ระบบจองล็อคตลาด
{
    partial class RevenueReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sherchbtn = new System.Windows.Forms.Button();
            this.BookingSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Totalbtn = new System.Windows.Forms.Button();
            this.Finebtn = new System.Windows.Forms.Button();
            this.Utilitybtn = new System.Windows.Forms.Button();
            this.Bookingbtn = new System.Windows.Forms.Button();
            this.dataRevenue = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TransactionMonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRevenue)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Sherchbtn);
            this.panel1.Controls.Add(this.BookingSearch);
            this.panel1.Location = new System.Drawing.Point(1360, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 62);
            this.panel1.TabIndex = 34;
            // 
            // Sherchbtn
            // 
            this.Sherchbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sherchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sherchbtn.Location = new System.Drawing.Point(227, 15);
            this.Sherchbtn.Name = "Sherchbtn";
            this.Sherchbtn.Size = new System.Drawing.Size(101, 34);
            this.Sherchbtn.TabIndex = 17;
            this.Sherchbtn.Text = "ค้นหา";
            this.Sherchbtn.UseVisualStyleBackColor = false;
            // 
            // BookingSearch
            // 
            this.BookingSearch.Location = new System.Drawing.Point(22, 19);
            this.BookingSearch.Name = "BookingSearch";
            this.BookingSearch.Size = new System.Drawing.Size(199, 26);
            this.BookingSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "รายงานรายได้";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Totalbtn);
            this.panel3.Controls.Add(this.Finebtn);
            this.panel3.Controls.Add(this.Utilitybtn);
            this.panel3.Controls.Add(this.Bookingbtn);
            this.panel3.Location = new System.Drawing.Point(1278, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 526);
            this.panel3.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_color_logo;
            this.pictureBox2.Location = new System.Drawing.Point(458, -300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1002, 394);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // Totalbtn
            // 
            this.Totalbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Totalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totalbtn.Image = global::ระบบจองล็อคตลาด.Properties.Resources.sum;
            this.Totalbtn.Location = new System.Drawing.Point(38, 32);
            this.Totalbtn.Name = "Totalbtn";
            this.Totalbtn.Size = new System.Drawing.Size(140, 97);
            this.Totalbtn.TabIndex = 31;
            this.Totalbtn.Text = "ทั้งหมด";
            this.Totalbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Totalbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Totalbtn.UseVisualStyleBackColor = true;
            this.Totalbtn.Click += new System.EventHandler(this.Totalbtn_Click);
            // 
            // Finebtn
            // 
            this.Finebtn.BackColor = System.Drawing.Color.OrangeRed;
            this.Finebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Finebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Finebtn.Image = global::ระบบจองล็อคตลาด.Properties.Resources.ticket;
            this.Finebtn.Location = new System.Drawing.Point(38, 402);
            this.Finebtn.Name = "Finebtn";
            this.Finebtn.Size = new System.Drawing.Size(140, 97);
            this.Finebtn.TabIndex = 30;
            this.Finebtn.Text = "ค่าปรับ";
            this.Finebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Finebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Finebtn.UseVisualStyleBackColor = false;
            this.Finebtn.Click += new System.EventHandler(this.Finebtn_Click);
            // 
            // Utilitybtn
            // 
            this.Utilitybtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Utilitybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Utilitybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utilitybtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Utilitybtn.Image = global::ระบบจองล็อคตลาด.Properties.Resources.settings;
            this.Utilitybtn.Location = new System.Drawing.Point(38, 271);
            this.Utilitybtn.Name = "Utilitybtn";
            this.Utilitybtn.Size = new System.Drawing.Size(140, 97);
            this.Utilitybtn.TabIndex = 29;
            this.Utilitybtn.Text = "ค่าน้ำค่าไฟ";
            this.Utilitybtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Utilitybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Utilitybtn.UseVisualStyleBackColor = false;
            this.Utilitybtn.Click += new System.EventHandler(this.Utilitybtn_Click);
            // 
            // Bookingbtn
            // 
            this.Bookingbtn.BackColor = System.Drawing.Color.Chartreuse;
            this.Bookingbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bookingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookingbtn.Image = global::ระบบจองล็อคตลาด.Properties.Resources.appointment__1_2;
            this.Bookingbtn.Location = new System.Drawing.Point(38, 151);
            this.Bookingbtn.Name = "Bookingbtn";
            this.Bookingbtn.Size = new System.Drawing.Size(140, 97);
            this.Bookingbtn.TabIndex = 28;
            this.Bookingbtn.Text = "ค่าจอง";
            this.Bookingbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bookingbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Bookingbtn.UseVisualStyleBackColor = false;
            this.Bookingbtn.Click += new System.EventHandler(this.Bookingbtn_Click);
            // 
            // dataRevenue
            // 
            this.dataRevenue.AllowUserToAddRows = false;
            this.dataRevenue.AllowUserToDeleteRows = false;
            this.dataRevenue.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRevenue.Location = new System.Drawing.Point(458, 218);
            this.dataRevenue.Name = "dataRevenue";
            this.dataRevenue.ReadOnly = true;
            this.dataRevenue.RowHeadersWidth = 62;
            this.dataRevenue.RowTemplate.Height = 28;
            this.dataRevenue.Size = new System.Drawing.Size(764, 505);
            this.dataRevenue.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "รายได้รวม";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 39;
            this.label3.Text = "บาท";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(198, 34);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(25, 32);
            this.Total.TabIndex = 40;
            this.Total.Text = "-";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Total);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(575, 757);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 103);
            this.panel2.TabIndex = 41;
            // 
            // TransactionMonth
            // 
            this.TransactionMonth.FormattingEnabled = true;
            this.TransactionMonth.Location = new System.Drawing.Point(95, 218);
            this.TransactionMonth.Name = "TransactionMonth";
            this.TransactionMonth.Size = new System.Drawing.Size(251, 28);
            this.TransactionMonth.TabIndex = 42;
            this.TransactionMonth.SelectedIndexChanged += new System.EventHandler(this.TransactionMonth_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "เลือกเดือน";
            // 
            // RevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TransactionMonth);
            this.Controls.Add(this.dataRevenue);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "RevenueReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevenueReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RevenueReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRevenue)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Sherchbtn;
        private System.Windows.Forms.TextBox BookingSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Totalbtn;
        private System.Windows.Forms.Button Finebtn;
        private System.Windows.Forms.Button Utilitybtn;
        private System.Windows.Forms.Button Bookingbtn;
        public System.Windows.Forms.DataGridView dataRevenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox TransactionMonth;
        private System.Windows.Forms.Label label4;
    }
}