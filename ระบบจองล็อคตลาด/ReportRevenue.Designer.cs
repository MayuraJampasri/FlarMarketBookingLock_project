
namespace ระบบจองล็อคตลาด
{
    partial class ReportRevenue
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
            this.dataRevenue = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Totalbtn = new System.Windows.Forms.Button();
            this.Finebtn = new System.Windows.Forms.Button();
            this.Utilitybtn = new System.Windows.Forms.Button();
            this.Bookingbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Chaprajam = new System.Windows.Forms.Button();
            this.Chajorn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.MonthSelect = new System.Windows.Forms.ComboBox();
            this.MonthText = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataRevenue)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRevenue
            // 
            this.dataRevenue.AllowUserToAddRows = false;
            this.dataRevenue.AllowUserToDeleteRows = false;
            this.dataRevenue.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRevenue.Location = new System.Drawing.Point(404, 284);
            this.dataRevenue.Name = "dataRevenue";
            this.dataRevenue.ReadOnly = true;
            this.dataRevenue.RowHeadersWidth = 62;
            this.dataRevenue.RowTemplate.Height = 28;
            this.dataRevenue.Size = new System.Drawing.Size(966, 505);
            this.dataRevenue.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Totalbtn);
            this.panel3.Controls.Add(this.Finebtn);
            this.panel3.Controls.Add(this.Utilitybtn);
            this.panel3.Controls.Add(this.Bookingbtn);
            this.panel3.Location = new System.Drawing.Point(1417, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 482);
            this.panel3.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 53;
            this.label6.Text = "ทั้งหมด";
            // 
            // Totalbtn
            // 
            this.Totalbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Totalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totalbtn.Image = global::ระบบจองล็อคตลาด.Properties.Resources.sum;
            this.Totalbtn.Location = new System.Drawing.Point(36, 62);
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
            this.Finebtn.Location = new System.Drawing.Point(36, 371);
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
            this.Utilitybtn.Location = new System.Drawing.Point(36, 268);
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
            this.Bookingbtn.Location = new System.Drawing.Point(36, 165);
            this.Bookingbtn.Name = "Bookingbtn";
            this.Bookingbtn.Size = new System.Drawing.Size(140, 97);
            this.Bookingbtn.TabIndex = 28;
            this.Bookingbtn.Text = "ค่าจอง";
            this.Bookingbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bookingbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Bookingbtn.UseVisualStyleBackColor = false;
            this.Bookingbtn.Click += new System.EventHandler(this.Bookingbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(810, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 41;
            this.label1.Text = "รายงานรายได้";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(1037, 826);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(25, 32);
            this.Total.TabIndex = 40;
            this.Total.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1310, 826);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 39;
            this.label3.Text = "บาท";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(858, 826);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "รายได้รวม";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.Chaprajam);
            this.panel5.Controls.Add(this.Chajorn);
            this.panel5.Location = new System.Drawing.Point(1666, 286);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 275);
            this.panel5.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 26);
            this.label7.TabIndex = 54;
            this.label7.Text = "รูปแบบการจอง";
            // 
            // Chaprajam
            // 
            this.Chaprajam.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Chaprajam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chaprajam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chaprajam.Image = global::ระบบจองล็อคตลาด.Properties.Resources.sum;
            this.Chaprajam.Location = new System.Drawing.Point(25, 164);
            this.Chaprajam.Name = "Chaprajam";
            this.Chaprajam.Size = new System.Drawing.Size(140, 97);
            this.Chaprajam.TabIndex = 44;
            this.Chaprajam.Text = "ขาประจำ";
            this.Chaprajam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Chaprajam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Chaprajam.UseVisualStyleBackColor = false;
            this.Chaprajam.Click += new System.EventHandler(this.Chaprajam_Click);
            // 
            // Chajorn
            // 
            this.Chajorn.BackColor = System.Drawing.Color.Gold;
            this.Chajorn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chajorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chajorn.Image = global::ระบบจองล็อคตลาด.Properties.Resources.sum;
            this.Chajorn.Location = new System.Drawing.Point(25, 53);
            this.Chajorn.Name = "Chajorn";
            this.Chajorn.Size = new System.Drawing.Size(140, 97);
            this.Chajorn.TabIndex = 43;
            this.Chajorn.Text = "ขาจร";
            this.Chajorn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Chajorn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Chajorn.UseVisualStyleBackColor = false;
            this.Chajorn.Click += new System.EventHandler(this.Chajorn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(1450, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "เลือกเดือนเพื่อดูรายได้ทั้งหมดของเดือนนั้นๆ";
            // 
            // MonthSelect
            // 
            this.MonthSelect.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MonthSelect.FormattingEnabled = true;
            this.MonthSelect.Location = new System.Drawing.Point(1168, 196);
            this.MonthSelect.Name = "MonthSelect";
            this.MonthSelect.Size = new System.Drawing.Size(255, 28);
            this.MonthSelect.TabIndex = 56;
            this.MonthSelect.SelectedIndexChanged += new System.EventHandler(this.MonthSelect_SelectedIndexChanged);
            // 
            // MonthText
            // 
            this.MonthText.AutoSize = true;
            this.MonthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthText.Location = new System.Drawing.Point(791, 213);
            this.MonthText.Name = "MonthText";
            this.MonthText.Size = new System.Drawing.Size(22, 29);
            this.MonthText.TabIndex = 96;
            this.MonthText.Text = "-";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(640, 213);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(145, 29);
            this.label45.TabIndex = 97;
            this.label45.Text = "ประจำเดือน :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_color_logo;
            this.pictureBox2.Location = new System.Drawing.Point(470, -314);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1002, 394);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ระบบจองล็อคตลาด.Properties.Resources.printing;
            this.button1.Location = new System.Drawing.Point(1692, 773);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 97);
            this.button1.TabIndex = 55;
            this.button1.Text = "พิมพ์รายงาน";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ReportRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.MonthText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MonthSelect);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataRevenue);
            this.Name = "ReportRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportRevenue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRevenue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataRevenue;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Totalbtn;
        private System.Windows.Forms.Button Finebtn;
        private System.Windows.Forms.Button Utilitybtn;
        private System.Windows.Forms.Button Bookingbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Chajorn;
        private System.Windows.Forms.Button Chaprajam;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox MonthSelect;
        public System.Windows.Forms.Label MonthText;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button button1;
    }
}