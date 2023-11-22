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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void NewCustomerRegis_Click(object sender, EventArgs e)
        {
            NewCustomer_ nc = new NewCustomer_();
            nc.MdiParent = this;
            nc.Show();
        }

        private void BookingAdd_Click(object sender, EventArgs e)
        {
            BookingLock_ bk = new BookingLock_();
            bk.MdiParent = this;
            bk.Show();
        }

        private void ListOfCusToWait_Click(object sender, EventArgs e)
        {
            CustomerWaitForApprove cw = new CustomerWaitForApprove();
            cw.MdiParent = this;
            cw.Show();
        }

        private void MarketStatus_Click(object sender, EventArgs e)
        {
            lockStatus_ ls = new lockStatus_();
            ls.MdiParent = this;
            ls.Show();
        }

        private void ListOfCusBook_Click(object sender, EventArgs e)
        {
        }

        private void ZoneName_Click(object sender, EventArgs e)
        {
            LockMarket_ lm = new LockMarket_();
            lm.MdiParent = this;
            lm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากระบบใช่หรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Hide();
                Login2 l2 = new Login2();
                l2.ShowDialog();
            }
            

        }

        private void รายชอผจองToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerBookingList cb = new CustomerBookingList();
            cb.MdiParent = this;
            cb.Show();
        }

        

        private void PaymentPayper_Click(object sender, EventArgs e)
        {
            BookingPaper bk = new BookingPaper();
            bk.MdiParent = this;
            bk.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void MarketLock_Click(object sender, EventArgs e)
        {

        }

        

        private void UtibilityPage_Click(object sender, EventArgs e)
        {
            UtibilityBill ub = new UtibilityBill();
            ub.MdiParent = this;
            ub.Show();
        }

        

        private void รายชอผทชำระแลวToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplatePayToBookingList co = new ComplatePayToBookingList();
            co.MdiParent = this;
            co.Show();
        }

        private void ReceiptPage_Click_1(object sender, EventArgs e)
        {

             String data1 = "",data2 ="", data3 = "", data4= "", data5= "", data6 = "";
             int data0 = 0;
             Receipt re = new Receipt(data0,data1,data2,data3,data4,data5,data6);
             re.MdiParent = this;
             re.Show();
        }

        private void LockReturnPage_Click(object sender, EventArgs e)
        {
            LockReturn lr = new LockReturn();
            lr.MdiParent = this;
            lr.Show();
        }

        private void FinePage_Click(object sender, EventArgs e)
        {
            FineBill fb = new FineBill();
            fb.MdiParent = this;
            fb.Show();
        }

        private void RockReturnPage_Click(object sender, EventArgs e)
        {
            LockReturn lr = new LockReturn();
            lr.MdiParent = this;
            lr.Show();
        }

        private void Booking_Click(object sender, EventArgs e)
        {

        }

        private void specificationsPage_Click(object sender, EventArgs e)
        {
            test t = new test();
            t.MdiParent = this;
            t.Show();
        }

        private void BookingDetailPage_Click(object sender, EventArgs e)
        {
            BookingData bd = new BookingData();
            bd.MdiParent = this;
            bd.Show();
        }
    }
}
