
namespace ระบบจองล็อคตลาด
{
    partial class Admin2
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
            this.button1 = new System.Windows.Forms.Button();
            this.NewCustomerbtn = new System.Windows.Forms.Button();
            this.LockMarket = new System.Windows.Forms.Button();
            this.Booking = new System.Windows.Forms.Button();
            this.Finance = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.HeadText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(774, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewCustomerbtn
            // 
            this.NewCustomerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewCustomerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCustomerbtn.Location = new System.Drawing.Point(234, 189);
            this.NewCustomerbtn.Name = "NewCustomerbtn";
            this.NewCustomerbtn.Size = new System.Drawing.Size(182, 63);
            this.NewCustomerbtn.TabIndex = 9;
            this.NewCustomerbtn.Text = "ผู้มาจองใหม่";
            this.NewCustomerbtn.UseVisualStyleBackColor = true;
            this.NewCustomerbtn.Click += new System.EventHandler(this.NewCustomerbtn_Click);
            // 
            // LockMarket
            // 
            this.LockMarket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LockMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockMarket.Location = new System.Drawing.Point(502, 189);
            this.LockMarket.Name = "LockMarket";
            this.LockMarket.Size = new System.Drawing.Size(182, 63);
            this.LockMarket.TabIndex = 10;
            this.LockMarket.Text = "ล็อคตลาด";
            this.LockMarket.UseVisualStyleBackColor = true;
            this.LockMarket.Click += new System.EventHandler(this.LockMarket_Click);
            // 
            // Booking
            // 
            this.Booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking.Location = new System.Drawing.Point(234, 304);
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(182, 63);
            this.Booking.TabIndex = 11;
            this.Booking.Text = "การจอง";
            this.Booking.UseVisualStyleBackColor = true;
            this.Booking.Click += new System.EventHandler(this.Booking_Click);
            // 
            // Finance
            // 
            this.Finance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Finance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finance.Location = new System.Drawing.Point(502, 304);
            this.Finance.Name = "Finance";
            this.Finance.Size = new System.Drawing.Size(182, 63);
            this.Finance.TabIndex = 12;
            this.Finance.Text = "การเงิน";
            this.Finance.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_color_logo;
            this.logo.Location = new System.Drawing.Point(-52, -388);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1002, 482);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // HeadText
            // 
            this.HeadText.AutoSize = true;
            this.HeadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadText.Location = new System.Drawing.Point(286, 32);
            this.HeadText.Name = "HeadText";
            this.HeadText.Size = new System.Drawing.Size(329, 40);
            this.HeadText.TabIndex = 13;
            this.HeadText.Text = "ระบบจองล็อคตลาดนัด";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(138, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 259);
            this.panel1.TabIndex = 14;
            // 
            // Admin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.HeadText);
            this.Controls.Add(this.Finance);
            this.Controls.Add(this.Booking);
            this.Controls.Add(this.LockMarket);
            this.Controls.Add(this.NewCustomerbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panel1);
            this.Name = "Admin2";
            this.Text = "Admin2";
            this.Load += new System.EventHandler(this.Admin2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NewCustomerbtn;
        private System.Windows.Forms.Button LockMarket;
        private System.Windows.Forms.Button Booking;
        private System.Windows.Forms.Button Finance;
        private System.Windows.Forms.Label HeadText;
        private System.Windows.Forms.Panel panel1;
    }
}