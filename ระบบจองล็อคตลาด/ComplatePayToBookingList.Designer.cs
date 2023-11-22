
namespace ระบบจองล็อคตลาด
{
    partial class ComplatePayToBookingList
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sherchbtn = new System.Windows.Forms.Button();
            this.BookingSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataBoolingPay = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Fine = new System.Windows.Forms.Button();
            this.Utility = new System.Windows.Forms.Button();
            this.Booking = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBoolingPay)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataBoolingPay);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(100, -11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1723, 1073);
            this.panel2.TabIndex = 25;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_color_logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 910);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1723, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_color_logo;
            this.pictureBox2.Location = new System.Drawing.Point(349, -272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1002, 394);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Sherchbtn);
            this.panel1.Controls.Add(this.BookingSearch);
            this.panel1.Location = new System.Drawing.Point(1251, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 62);
            this.panel1.TabIndex = 24;
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
            this.Sherchbtn.Click += new System.EventHandler(this.Sherchbtn_Click);
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
            this.label1.Location = new System.Drawing.Point(271, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "ชื่อผู้ที่ชำระค่าใช้จ่ายแล้ว";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1256, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "กรอกเลขที่ใบจอง เช่น BK...";
            // 
            // dataBoolingPay
            // 
            this.dataBoolingPay.AllowUserToAddRows = false;
            this.dataBoolingPay.AllowUserToDeleteRows = false;
            this.dataBoolingPay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataBoolingPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBoolingPay.Location = new System.Drawing.Point(262, 339);
            this.dataBoolingPay.Name = "dataBoolingPay";
            this.dataBoolingPay.ReadOnly = true;
            this.dataBoolingPay.RowHeadersWidth = 62;
            this.dataBoolingPay.RowTemplate.Height = 28;
            this.dataBoolingPay.Size = new System.Drawing.Size(1020, 505);
            this.dataBoolingPay.TabIndex = 20;
            this.dataBoolingPay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBoolingPay_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Fine);
            this.panel3.Controls.Add(this.Utility);
            this.panel3.Controls.Add(this.Booking);
            this.panel3.Location = new System.Drawing.Point(1360, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 526);
            this.panel3.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ระบบจองล็อคตลาด.Properties.Resources.sum;
            this.button1.Location = new System.Drawing.Point(38, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 97);
            this.button1.TabIndex = 31;
            this.button1.Text = "ทั้งหมด";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Fine
            // 
            this.Fine.BackColor = System.Drawing.Color.OrangeRed;
            this.Fine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fine.Image = global::ระบบจองล็อคตลาด.Properties.Resources.ticket;
            this.Fine.Location = new System.Drawing.Point(38, 402);
            this.Fine.Name = "Fine";
            this.Fine.Size = new System.Drawing.Size(140, 97);
            this.Fine.TabIndex = 30;
            this.Fine.Text = "ค่าปรับ";
            this.Fine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Fine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Fine.UseVisualStyleBackColor = false;
            this.Fine.Click += new System.EventHandler(this.Fine_Click);
            // 
            // Utility
            // 
            this.Utility.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Utility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Utility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utility.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Utility.Image = global::ระบบจองล็อคตลาด.Properties.Resources.settings;
            this.Utility.Location = new System.Drawing.Point(38, 271);
            this.Utility.Name = "Utility";
            this.Utility.Size = new System.Drawing.Size(140, 97);
            this.Utility.TabIndex = 29;
            this.Utility.Text = "ค่าน้ำค่าไฟ";
            this.Utility.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Utility.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Utility.UseVisualStyleBackColor = false;
            this.Utility.Click += new System.EventHandler(this.Utility_Click);
            // 
            // Booking
            // 
            this.Booking.BackColor = System.Drawing.Color.Chartreuse;
            this.Booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking.Image = global::ระบบจองล็อคตลาด.Properties.Resources.appointment__1_2;
            this.Booking.Location = new System.Drawing.Point(38, 151);
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(140, 97);
            this.Booking.TabIndex = 28;
            this.Booking.Text = "ค่าจอง";
            this.Booking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Booking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Booking.UseVisualStyleBackColor = false;
            this.Booking.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComplatePayToBookingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel2);
            this.Name = "ComplatePayToBookingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComplatePayToBookingList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ComplatePayToBookingList_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBoolingPay)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Sherchbtn;
        private System.Windows.Forms.TextBox BookingSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dataBoolingPay;
        private System.Windows.Forms.Button Booking;
        private System.Windows.Forms.Button Fine;
        private System.Windows.Forms.Button Utility;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
    }
}