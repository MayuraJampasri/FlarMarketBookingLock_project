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
    public partial class Admin2 : Form
    {
        // public int currentReservationNumber = 1; //เลขใบจอง
        public Admin2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewCustomer_ nc = new NewCustomer_();
            nc.ShowDialog();

        }

        private void LockMarket_Click(object sender, EventArgs e)
        {
            LockMarket_ lg = new LockMarket_();
            lg.ShowDialog();
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            BookingLock_ bk = new BookingLock_();
            bk.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();

        }

        private void NewCustomerbtn_Click(object sender, EventArgs e)
        {
            NewCustomer_ nc = new NewCustomer_();
            nc.ShowDialog();
        }

        private void Admin2_Load(object sender, EventArgs e)
        {

        }
    }
}

