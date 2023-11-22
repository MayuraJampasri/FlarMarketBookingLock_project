
namespace ระบบจองล็อคตลาด
{
    partial class PaymentPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.submitPayBtn = new System.Windows.Forms.Button();
            this.NotSubmitPaybtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Money = new System.Windows.Forms.RadioButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Banking = new System.Windows.Forms.RadioButton();
            this.wallet = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Cradit = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.ShowBookingID = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.insertSlipbtn = new System.Windows.Forms.Button();
            this.ShowSlipPath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Utility = new System.Windows.Forms.RadioButton();
            this.Fine = new System.Windows.Forms.RadioButton();
            this.Booking = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 57;
            this.label1.Text = "การชำระเงิน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 61;
            this.label2.Text = "เลขที่ใบจอง :";
            // 
            // submitPayBtn
            // 
            this.submitPayBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.submitPayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitPayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitPayBtn.Location = new System.Drawing.Point(772, 22);
            this.submitPayBtn.Name = "submitPayBtn";
            this.submitPayBtn.Size = new System.Drawing.Size(212, 68);
            this.submitPayBtn.TabIndex = 68;
            this.submitPayBtn.Text = "ยืนยันการชำระเงิน";
            this.submitPayBtn.UseVisualStyleBackColor = false;
            this.submitPayBtn.Click += new System.EventHandler(this.submitPayBtn_Click);
            // 
            // NotSubmitPaybtn
            // 
            this.NotSubmitPaybtn.BackColor = System.Drawing.Color.Red;
            this.NotSubmitPaybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotSubmitPaybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotSubmitPaybtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NotSubmitPaybtn.Location = new System.Drawing.Point(31, 22);
            this.NotSubmitPaybtn.Name = "NotSubmitPaybtn";
            this.NotSubmitPaybtn.Size = new System.Drawing.Size(228, 68);
            this.NotSubmitPaybtn.TabIndex = 69;
            this.NotSubmitPaybtn.Text = "ไม่ยืนยันการชำระเงิน";
            this.NotSubmitPaybtn.UseVisualStyleBackColor = false;
            this.NotSubmitPaybtn.Click += new System.EventHandler(this.NotSubmitPaybtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ระบบจองล็อคตลาด.Properties.Resources.credit_card;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(52, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.Money);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.Banking);
            this.groupBox2.Controls.Add(this.wallet);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.Cradit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(167, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 312);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รูปแบบการชำระเงิน";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Location = new System.Drawing.Point(431, 219);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(90, 30);
            this.Money.TabIndex = 82;
            this.Money.TabStop = true;
            this.Money.Text = "เงินสด";
            this.Money.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ระบบจองล็อคตลาด.Properties.Resources.money;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(344, 199);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(66, 61);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 72;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ระบบจองล็อคตลาด.Properties.Resources.e_wallet;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(52, 199);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 61);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 72;
            this.pictureBox4.TabStop = false;
            // 
            // Banking
            // 
            this.Banking.AutoSize = true;
            this.Banking.Location = new System.Drawing.Point(431, 93);
            this.Banking.Name = "Banking";
            this.Banking.Size = new System.Drawing.Size(138, 30);
            this.Banking.TabIndex = 80;
            this.Banking.TabStop = true;
            this.Banking.Text = "โอนธนาคาร";
            this.Banking.UseVisualStyleBackColor = true;
            // 
            // wallet
            // 
            this.wallet.AutoSize = true;
            this.wallet.Location = new System.Drawing.Point(142, 213);
            this.wallet.Name = "wallet";
            this.wallet.Size = new System.Drawing.Size(115, 30);
            this.wallet.TabIndex = 81;
            this.wallet.TabStop = true;
            this.wallet.Text = "E-wallet";
            this.wallet.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ระบบจองล็อคตลาด.Properties.Resources.mobile_banking;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(344, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 72;
            this.pictureBox3.TabStop = false;
            // 
            // Cradit
            // 
            this.Cradit.AutoSize = true;
            this.Cradit.Location = new System.Drawing.Point(142, 93);
            this.Cradit.Name = "Cradit";
            this.Cradit.Size = new System.Drawing.Size(126, 30);
            this.Cradit.TabIndex = 79;
            this.Cradit.TabStop = true;
            this.Cradit.Text = "บัตรเครดิต";
            this.Cradit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(782, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 32);
            this.label4.TabIndex = 77;
            this.label4.Text = "*";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_logo_black_on_transparent_background;
            this.pictureBox2.Location = new System.Drawing.Point(38, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_color_logo;
            this.logo.Location = new System.Drawing.Point(-368, -216);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1949, 287);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 71;
            this.logo.TabStop = false;
            // 
            // ShowBookingID
            // 
            this.ShowBookingID.AutoSize = true;
            this.ShowBookingID.BackColor = System.Drawing.Color.White;
            this.ShowBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBookingID.Location = new System.Drawing.Point(783, 113);
            this.ShowBookingID.Name = "ShowBookingID";
            this.ShowBookingID.Size = new System.Drawing.Size(25, 32);
            this.ShowBookingID.TabIndex = 73;
            this.ShowBookingID.Text = "-";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Controls.Add(this.insertSlipbtn);
            this.groupBox6.Controls.Add(this.ShowSlipPath);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(167, 673);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(613, 106);
            this.groupBox6.TabIndex = 74;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "หลักฐานการชำระเงิน";
            // 
            // insertSlipbtn
            // 
            this.insertSlipbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertSlipbtn.Location = new System.Drawing.Point(457, 39);
            this.insertSlipbtn.Name = "insertSlipbtn";
            this.insertSlipbtn.Size = new System.Drawing.Size(137, 48);
            this.insertSlipbtn.TabIndex = 75;
            this.insertSlipbtn.Text = "แนบสลิป";
            this.insertSlipbtn.UseVisualStyleBackColor = true;
            this.insertSlipbtn.Click += new System.EventHandler(this.insertSlipbtn_Click);
            // 
            // ShowSlipPath
            // 
            this.ShowSlipPath.Location = new System.Drawing.Point(38, 47);
            this.ShowSlipPath.Name = "ShowSlipPath";
            this.ShowSlipPath.Size = new System.Drawing.Size(398, 32);
            this.ShowSlipPath.TabIndex = 75;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ShowBookingID);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(64, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 843);
            this.panel1.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(840, 809);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 78;
            this.label5.Text = "* ควรเลือก";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.Utility);
            this.groupBox7.Controls.Add(this.Fine);
            this.groupBox7.Controls.Add(this.Booking);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(167, 167);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(594, 145);
            this.groupBox7.TabIndex = 75;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "ประเภทค่าใช้จ่าย";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(561, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 32);
            this.label3.TabIndex = 76;
            this.label3.Text = "*";
            // 
            // Utility
            // 
            this.Utility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Utility.Location = new System.Drawing.Point(220, 57);
            this.Utility.Name = "Utility";
            this.Utility.Size = new System.Drawing.Size(139, 61);
            this.Utility.TabIndex = 76;
            this.Utility.TabStop = true;
            this.Utility.Text = "ค่าน้ำค่าไฟ";
            this.Utility.UseVisualStyleBackColor = true;
            // 
            // Fine
            // 
            this.Fine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fine.Location = new System.Drawing.Point(409, 57);
            this.Fine.Name = "Fine";
            this.Fine.Size = new System.Drawing.Size(140, 61);
            this.Fine.TabIndex = 75;
            this.Fine.TabStop = true;
            this.Fine.Text = "ค่าปรับ";
            this.Fine.UseVisualStyleBackColor = true;
            // 
            // Booking
            // 
            this.Booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Booking.Location = new System.Drawing.Point(50, 57);
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(139, 61);
            this.Booking.TabIndex = 73;
            this.Booking.TabStop = true;
            this.Booking.Text = "การจอง";
            this.Booking.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.NotSubmitPaybtn);
            this.panel2.Controls.Add(this.submitPayBtn);
            this.panel2.Location = new System.Drawing.Point(33, 910);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 111);
            this.panel2.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(571, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 26);
            this.label6.TabIndex = 79;
            this.label6.Text = " ";
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1082, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentPage";
            this.Load += new System.EventHandler(this.PaymentPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitPayBtn;
        private System.Windows.Forms.Button NotSubmitPaybtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button insertSlipbtn;
        public System.Windows.Forms.TextBox ShowSlipPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton Fine;
        private System.Windows.Forms.RadioButton Booking;
        private System.Windows.Forms.RadioButton Utility;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Cradit;
        private System.Windows.Forms.RadioButton Money;
        private System.Windows.Forms.RadioButton wallet;
        private System.Windows.Forms.RadioButton Banking;
        public System.Windows.Forms.Label ShowBookingID;
        private System.Windows.Forms.Label label6;
    }
}