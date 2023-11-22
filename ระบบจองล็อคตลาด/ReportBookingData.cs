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
    public partial class ReportBookingData : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        Booking_market bm = new Booking_market();
        public ReportBookingData()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           // ReportBooking1.SetParameterValue;
        }
    }
}
