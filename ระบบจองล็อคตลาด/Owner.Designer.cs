
namespace ระบบจองล็อคตลาด
{
    partial class Owner
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
            this.ApprovePage = new System.Windows.Forms.ToolStripMenuItem();
            this.รายชอทรอการอนมตToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายชอททำการอนมตToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarketPage = new System.Windows.Forms.ToolStripMenuItem();
            this.LockMenegement = new System.Windows.Forms.ToolStripMenuItem();
            this.MargetPage = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeePage = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.รายชอพนกงานงหมดToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UtilityPage = new System.Windows.Forms.ToolStripMenuItem();
            this.UtilityPaper = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportPage = new System.Windows.Forms.ToolStripMenuItem();
            this.รายชอผToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายชอผทชำระคาจองแลวToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryBookingPage = new System.Windows.Forms.ToolStripMenuItem();
            this.RevenueReportData = new System.Windows.Forms.ToolStripMenuItem();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.LockStatusReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApprovePage,
            this.MarketPage,
            this.EmployeePage,
            this.UtilityPage,
            this.ReportPage,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ApprovePage;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1924, 57);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ApprovePage
            // 
            this.ApprovePage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.รายชอทรอการอนมตToolStripMenuItem,
            this.รายชอททำการอนมตToolStripMenuItem});
            this.ApprovePage.Image = global::ระบบจองล็อคตลาด.Properties.Resources.user1;
            this.ApprovePage.Name = "ApprovePage";
            this.ApprovePage.Size = new System.Drawing.Size(69, 53);
            this.ApprovePage.Text = "อนุมัติ";
            this.ApprovePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // รายชอทรอการอนมตToolStripMenuItem
            // 
            this.รายชอทรอการอนมตToolStripMenuItem.Name = "รายชอทรอการอนมตToolStripMenuItem";
            this.รายชอทรอการอนมตToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.รายชอทรอการอนมตToolStripMenuItem.Text = "รายชื่อที่รอการอนุมัติ";
            this.รายชอทรอการอนมตToolStripMenuItem.Click += new System.EventHandler(this.รายชอทรอการอนมตToolStripMenuItem_Click);
            // 
            // รายชอททำการอนมตToolStripMenuItem
            // 
            this.รายชอททำการอนมตToolStripMenuItem.Name = "รายชอททำการอนมตToolStripMenuItem";
            this.รายชอททำการอนมตToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.รายชอททำการอนมตToolStripMenuItem.Text = "รายชื่อที่ทำการอนุมัติแล้ว";
            this.รายชอททำการอนมตToolStripMenuItem.Click += new System.EventHandler(this.รายชอททำการอนมตToolStripMenuItem_Click);
            // 
            // MarketPage
            // 
            this.MarketPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LockMenegement,
            this.MargetPage});
            this.MarketPage.Image = global::ระบบจองล็อคตลาด.Properties.Resources.online_store1;
            this.MarketPage.Name = "MarketPage";
            this.MarketPage.Size = new System.Drawing.Size(96, 53);
            this.MarketPage.Text = "ล็อคตลาด";
            this.MarketPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // LockMenegement
            // 
            this.LockMenegement.Name = "LockMenegement";
            this.LockMenegement.Size = new System.Drawing.Size(217, 34);
            this.LockMenegement.Text = "การจัดการล็อค";
            this.LockMenegement.Click += new System.EventHandler(this.ตงคาลอคToolStripMenuItem_Click);
            // 
            // MargetPage
            // 
            this.MargetPage.Name = "MargetPage";
            this.MargetPage.Size = new System.Drawing.Size(217, 34);
            this.MargetPage.Text = "ข้อมูลตลาด";
            this.MargetPage.Click += new System.EventHandler(this.MargetPage_Click);
            // 
            // EmployeePage
            // 
            this.EmployeePage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeManagement,
            this.รายชอพนกงานงหมดToolStripMenuItem});
            this.EmployeePage.Image = global::ระบบจองล็อคตลาด.Properties.Resources.businessman;
            this.EmployeePage.Name = "EmployeePage";
            this.EmployeePage.Size = new System.Drawing.Size(87, 53);
            this.EmployeePage.Text = "พนักงาน";
            this.EmployeePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // EmployeeManagement
            // 
            this.EmployeeManagement.Name = "EmployeeManagement";
            this.EmployeeManagement.Size = new System.Drawing.Size(268, 34);
            this.EmployeeManagement.Text = "การจัดการพนักงาน";
            this.EmployeeManagement.Click += new System.EventHandler(this.EmployeeManagement_Click);
            // 
            // รายชอพนกงานงหมดToolStripMenuItem
            // 
            this.รายชอพนกงานงหมดToolStripMenuItem.Name = "รายชอพนกงานงหมดToolStripMenuItem";
            this.รายชอพนกงานงหมดToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.รายชอพนกงานงหมดToolStripMenuItem.Text = "รายชื่อพนักงานทั้งหมด";
            this.รายชอพนกงานงหมดToolStripMenuItem.Click += new System.EventHandler(this.รายชอพนกงานงหมดToolStripMenuItem_Click);
            // 
            // UtilityPage
            // 
            this.UtilityPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UtilityPaper});
            this.UtilityPage.Image = global::ระบบจองล็อคตลาด.Properties.Resources.payment;
            this.UtilityPage.Name = "UtilityPage";
            this.UtilityPage.Size = new System.Drawing.Size(144, 53);
            this.UtilityPage.Text = "บันทึกค่าน้ำค่าไฟ";
            this.UtilityPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // UtilityPaper
            // 
            this.UtilityPaper.Name = "UtilityPaper";
            this.UtilityPaper.Size = new System.Drawing.Size(247, 34);
            this.UtilityPaper.Text = "ใบบันทึกค่าน้ำค่าไฟ";
            this.UtilityPaper.Click += new System.EventHandler(this.UtilityPaper_Click);
            // 
            // ReportPage
            // 
            this.ReportPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LockStatusReport,
            this.รายชอผToolStripMenuItem,
            this.รายชอผทชำระคาจองแลวToolStripMenuItem,
            this.HistoryBookingPage,
            this.RevenueReportData,
            this.dashBoardToolStripMenuItem});
            this.ReportPage.Image = global::ระบบจองล็อคตลาด.Properties.Resources.newspaper;
            this.ReportPage.Name = "ReportPage";
            this.ReportPage.Size = new System.Drawing.Size(79, 53);
            this.ReportPage.Text = "รายงาน";
            this.ReportPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // รายชอผToolStripMenuItem
            // 
            this.รายชอผToolStripMenuItem.Name = "รายชอผToolStripMenuItem";
            this.รายชอผToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.รายชอผToolStripMenuItem.Text = "รายงานผู้จอง";
            this.รายชอผToolStripMenuItem.Click += new System.EventHandler(this.รายชอผToolStripMenuItem_Click);
            // 
            // รายชอผทชำระคาจองแลวToolStripMenuItem
            // 
            this.รายชอผทชำระคาจองแลวToolStripMenuItem.Name = "รายชอผทชำระคาจองแลวToolStripMenuItem";
            this.รายชอผทชำระคาจองแลวToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.รายชอผทชำระคาจองแลวToolStripMenuItem.Text = "รายชื่อผู้ชำระเงินแล้ว";
            this.รายชอผทชำระคาจองแลวToolStripMenuItem.Click += new System.EventHandler(this.รายชอผทชำระคาจองแลวToolStripMenuItem_Click);
            // 
            // HistoryBookingPage
            // 
            this.HistoryBookingPage.Name = "HistoryBookingPage";
            this.HistoryBookingPage.Size = new System.Drawing.Size(343, 34);
            this.HistoryBookingPage.Text = "ประวัติการจอง";
            this.HistoryBookingPage.Click += new System.EventHandler(this.HistoryBookingPage_Click);
            // 
            // RevenueReportData
            // 
            this.RevenueReportData.Name = "RevenueReportData";
            this.RevenueReportData.Size = new System.Drawing.Size(343, 34);
            this.RevenueReportData.Text = "รายงานรายได้";
            this.RevenueReportData.Click += new System.EventHandler(this.RevenueReportData_Click);
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.dashBoardToolStripMenuItem.Text = "รายงานผลประกอบการและการจอง";
            this.dashBoardToolStripMenuItem.Click += new System.EventHandler(this.dashBoardToolStripMenuItem_Click_1);
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
            this.label1.Location = new System.Drawing.Point(1751, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "เจ้าของตลาด";
            // 
            // LockStatusReport
            // 
            this.LockStatusReport.Name = "LockStatusReport";
            this.LockStatusReport.Size = new System.Drawing.Size(343, 34);
            this.LockStatusReport.Text = "รายงานสถานะล็อค";
            this.LockStatusReport.Click += new System.EventHandler(this.LockStatusReport_Click);
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = global::ระบบจองล็อคตลาด.Properties.Resources._16_June___fashion;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Owner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ApprovePage;
        private System.Windows.Forms.ToolStripMenuItem รายชอทรอการอนมตToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายชอททำการอนมตToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MarketPage;
        private System.Windows.Forms.ToolStripMenuItem LockMenegement;
        private System.Windows.Forms.ToolStripMenuItem EmployeePage;
        private System.Windows.Forms.ToolStripMenuItem รายชอพนกงานงหมดToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportPage;
        private System.Windows.Forms.ToolStripMenuItem รายชอผToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายชอผทชำระคาจองแลวToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeManagement;
        private System.Windows.Forms.ToolStripMenuItem UtilityPage;
        private System.Windows.Forms.ToolStripMenuItem UtilityPaper;
        private System.Windows.Forms.ToolStripMenuItem HistoryBookingPage;
        private System.Windows.Forms.ToolStripMenuItem MargetPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem RevenueReportData;
        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LockStatusReport;
    }
}