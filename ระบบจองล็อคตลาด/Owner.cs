using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ระบบจองล็อคตลาด
{
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void รายชอทรอการอนมตToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //หน้าผู้จองที่กำลังถูกตรวจสอบประวัติ
            ListCustomerCheck_ wt = new ListCustomerCheck_();
            wt.MdiParent = this;
            wt.Show();
        }

        

        private void รายชอพนกงานงหมดToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //หน้ารายชื่อพนักงาน
            EmployeeData_ em = new EmployeeData_();
            em.MdiParent = this;
            em.Show();
        }

        private void รายชอททำการอนมตToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //หน้าผู้จองที่ถูกอนุมัติแล้ว
            CustomerList_ cl = new CustomerList_();
            cl.MdiParent = this;
            cl.Show();
        }

        private void รายชอผToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //หน้าผู้ที่จองแล้ว
            CustomerBookingList cb = new CustomerBookingList();
            cb.MdiParent = this;
            cb.Show();
        }

        private void ตงคาลอคToolStripMenuItem_Click(object sender, EventArgs e)
        { //หน้าจัดการล็อค เพิ่ม ลบ ล็อค
            LockMenagement_ lm = new LockMenagement_();
            lm.MdiParent = this;
            lm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากระบบใช่หรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Login2 l2 = new Login2();
                l2.ShowDialog();
            }
        }

        private void รายชอผทชำระคาจองแลวToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplatePayToBookingList co = new ComplatePayToBookingList();
            co.MdiParent = this;
            co.Show();
        }

        private void EmployeeManagement_Click(object sender, EventArgs e)
        {
            EmployeeMenagement em = new EmployeeMenagement();
            em.MdiParent = this;
            em.Show();
        }

        private void UtilityPaper_Click(object sender, EventArgs e)
        {
            UtilityInput ut = new UtilityInput();
            ut.MdiParent = this;
            ut.Show();
        }

        private void HistoryBookingPage_Click(object sender, EventArgs e)
        {
            HistoryBooking hb = new HistoryBooking();
            hb.MdiParent = this;
            hb.Show();
        }

        private void MargetPage_Click(object sender, EventArgs e)
        {
            LockMarket_ lm = new LockMarket_();
            lm.MdiParent = this;
            lm.Show();
        }

        private void RevenueReportData_Click(object sender, EventArgs e)
        {
           ReportRevenue rp = new ReportRevenue();
            rp.MdiParent = this;
            rp.Show();
        }

       

        private void dashBoardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DashboardRevenue db = new DashboardRevenue();
            db.MdiParent = this;
            db.Show();
        }

        private void LockStatusReport_Click(object sender, EventArgs e)
        {
            lockStatus_ rs = new lockStatus_();
            rs.MdiParent = this;
            rs.Show();
        }
    }
}
