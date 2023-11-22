
namespace ระบบจองล็อคตลาด
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.NewCustomerRegis = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfCusToWait = new System.Windows.Forms.ToolStripMenuItem();
            this.MarketLock = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoneName = new System.Windows.Forms.ToolStripMenuItem();
            this.MarketStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.Booking = new System.Windows.Forms.ToolStripMenuItem();
            this.BookingAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.รายชอผจองToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookingDetailPage = new System.Windows.Forms.ToolStripMenuItem();
            this.Payment = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentPayper = new System.Windows.Forms.ToolStripMenuItem();
            this.UtibilityPage = new System.Windows.Forms.ToolStripMenuItem();
            this.FinePage = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceiptPage = new System.Windows.Forms.ToolStripMenuItem();
            this.RockReturnPage = new System.Windows.Forms.ToolStripMenuItem();
            this.specificationsPage = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomer,
            this.MarketLock,
            this.Booking,
            this.Payment,
            this.RockReturnPage,
            this.specificationsPage,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.newCustomer;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1924, 57);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newCustomer
            // 
            this.newCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewCustomerRegis,
            this.ListOfCusToWait});
            this.newCustomer.Image = global::ระบบจองล็อคตลาด.Properties.Resources.user;
            this.newCustomer.Name = "newCustomer";
            this.newCustomer.Size = new System.Drawing.Size(90, 53);
            this.newCustomer.Text = "ผู้จองใหม่";
            this.newCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // NewCustomerRegis
            // 
            this.NewCustomerRegis.Name = "NewCustomerRegis";
            this.NewCustomerRegis.Size = new System.Drawing.Size(314, 34);
            this.NewCustomerRegis.Text = "แบบฟอร์มลงทะเบียนผู้จองใหม่";
            this.NewCustomerRegis.Click += new System.EventHandler(this.NewCustomerRegis_Click);
            // 
            // ListOfCusToWait
            // 
            this.ListOfCusToWait.Name = "ListOfCusToWait";
            this.ListOfCusToWait.Size = new System.Drawing.Size(314, 34);
            this.ListOfCusToWait.Text = "รายชื่อผู้กำลังถูกอนุมัติ";
            this.ListOfCusToWait.Click += new System.EventHandler(this.ListOfCusToWait_Click);
            // 
            // MarketLock
            // 
            this.MarketLock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoneName,
            this.MarketStatus});
            this.MarketLock.Image = global::ระบบจองล็อคตลาด.Properties.Resources.online_store;
            this.MarketLock.Name = "MarketLock";
            this.MarketLock.Size = new System.Drawing.Size(96, 53);
            this.MarketLock.Text = "ล๊อคตลาด";
            this.MarketLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MarketLock.Click += new System.EventHandler(this.MarketLock_Click);
            // 
            // ZoneName
            // 
            this.ZoneName.Name = "ZoneName";
            this.ZoneName.Size = new System.Drawing.Size(270, 34);
            this.ZoneName.Text = "ข้อมูลตลาด";
            this.ZoneName.Click += new System.EventHandler(this.ZoneName_Click);
            // 
            // MarketStatus
            // 
            this.MarketStatus.Name = "MarketStatus";
            this.MarketStatus.Size = new System.Drawing.Size(270, 34);
            this.MarketStatus.Text = "สถานะล็อค";
            this.MarketStatus.Click += new System.EventHandler(this.MarketStatus_Click);
            // 
            // Booking
            // 
            this.Booking.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookingAdd,
            this.รายชอผจองToolStripMenuItem,
            this.BookingDetailPage});
            this.Booking.Image = global::ระบบจองล็อคตลาด.Properties.Resources.calendar;
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(80, 53);
            this.Booking.Text = "การจอง";
            this.Booking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Booking.Click += new System.EventHandler(this.Booking_Click);
            // 
            // BookingAdd
            // 
            this.BookingAdd.Name = "BookingAdd";
            this.BookingAdd.Size = new System.Drawing.Size(323, 34);
            this.BookingAdd.Text = "แบบฟอร์มการจอง";
            this.BookingAdd.Click += new System.EventHandler(this.BookingAdd_Click);
            // 
            // รายชอผจองToolStripMenuItem
            // 
            this.รายชอผจองToolStripMenuItem.Name = "รายชอผจองToolStripMenuItem";
            this.รายชอผจองToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.รายชอผจองToolStripMenuItem.Text = "รายงานผู้จอง";
            this.รายชอผจองToolStripMenuItem.Click += new System.EventHandler(this.รายชอผจองToolStripMenuItem_Click);
            // 
            // BookingDetailPage
            // 
            this.BookingDetailPage.Name = "BookingDetailPage";
            this.BookingDetailPage.Size = new System.Drawing.Size(323, 34);
            this.BookingDetailPage.Text = "ใบรายละเอียดการจองของผู้จอง";
            this.BookingDetailPage.Click += new System.EventHandler(this.BookingDetailPage_Click);
            // 
            // Payment
            // 
            this.Payment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaymentPayper,
            this.UtibilityPage,
            this.FinePage,
            this.ReceiptPage});
            this.Payment.Image = global::ระบบจองล็อคตลาด.Properties.Resources.dollar;
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(77, 53);
            this.Payment.Text = "การเงิน";
            this.Payment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // PaymentPayper
            // 
            this.PaymentPayper.Name = "PaymentPayper";
            this.PaymentPayper.Size = new System.Drawing.Size(270, 34);
            this.PaymentPayper.Text = "ใบแจ้งชำระเงินค่าจอง";
            this.PaymentPayper.Click += new System.EventHandler(this.PaymentPayper_Click);
            // 
            // UtibilityPage
            // 
            this.UtibilityPage.Name = "UtibilityPage";
            this.UtibilityPage.Size = new System.Drawing.Size(270, 34);
            this.UtibilityPage.Text = "ใบแจ้งชำระค่าน้ำค่าไฟ";
            this.UtibilityPage.Click += new System.EventHandler(this.UtibilityPage_Click);
            // 
            // FinePage
            // 
            this.FinePage.Name = "FinePage";
            this.FinePage.Size = new System.Drawing.Size(270, 34);
            this.FinePage.Text = "ใบแจ้งค่าปรับ";
            this.FinePage.Click += new System.EventHandler(this.FinePage_Click);
            // 
            // ReceiptPage
            // 
            this.ReceiptPage.Name = "ReceiptPage";
            this.ReceiptPage.Size = new System.Drawing.Size(270, 34);
            this.ReceiptPage.Text = "ใบเสร็จ";
            this.ReceiptPage.Click += new System.EventHandler(this.ReceiptPage_Click_1);
            // 
            // RockReturnPage
            // 
            this.RockReturnPage.Image = global::ระบบจองล็อคตลาด.Properties.Resources.calendar1;
            this.RockReturnPage.Name = "RockReturnPage";
            this.RockReturnPage.Size = new System.Drawing.Size(105, 53);
            this.RockReturnPage.Text = "การคืนล็อค";
            this.RockReturnPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RockReturnPage.Click += new System.EventHandler(this.RockReturnPage_Click);
            // 
            // specificationsPage
            // 
            this.specificationsPage.Image = global::ระบบจองล็อคตลาด.Properties.Resources.newspaper1;
            this.specificationsPage.Name = "specificationsPage";
            this.specificationsPage.Size = new System.Drawing.Size(172, 53);
            this.specificationsPage.Text = "ข้อกำหนดและเงื่อนไข";
            this.specificationsPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.specificationsPage.Click += new System.EventHandler(this.specificationsPage_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::ระบบจองล็อคตลาด.Properties.Resources.log_out;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(85, 53);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1730, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "พนักงาน";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ระบบจองล็อคตลาด.Properties.Resources.c89de51c98da7d806d85519168aae96ac_25805363_190303_0016;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newCustomer;
        private System.Windows.Forms.ToolStripMenuItem NewCustomerRegis;
        private System.Windows.Forms.ToolStripMenuItem ListOfCusToWait;
        private System.Windows.Forms.ToolStripMenuItem MarketLock;
        private System.Windows.Forms.ToolStripMenuItem ZoneName;
        private System.Windows.Forms.ToolStripMenuItem MarketStatus;
        private System.Windows.Forms.ToolStripMenuItem Booking;
        private System.Windows.Forms.ToolStripMenuItem BookingAdd;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายชอผจองToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Payment;
        private System.Windows.Forms.ToolStripMenuItem PaymentPayper;
        private System.Windows.Forms.ToolStripMenuItem UtibilityPage;
        private System.Windows.Forms.ToolStripMenuItem ReceiptPage;
        private System.Windows.Forms.ToolStripMenuItem FinePage;
        private System.Windows.Forms.ToolStripMenuItem RockReturnPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem specificationsPage;
        private System.Windows.Forms.ToolStripMenuItem BookingDetailPage;
    }
}