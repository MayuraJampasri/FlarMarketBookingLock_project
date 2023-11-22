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
    public partial class CusListWithoutRecordUtility : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        public CusListWithoutRecordUtility()
        {
            InitializeComponent();
           
        }

        private void CusListWithoutRecordUtility_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            var lr = from l in DB.Booking_market
                     join  c in DB.Customer_market on l.CustomerID equals c.CustomerID
                     join m in DB.Marketlocks on l.Marketlock_ID equals m.Marketlock_ID
                     where l.UtilityID == null && l.Paymentstatus == "Completed"
                     select new
                     {
                        BookingID =  l.BookingNumber,
                         CusID = l.CustomerID,
                         CusName = c.CustomerName,
                         CusLname = c.CustomerLastname,
                         LockID = l.Marketlock_ID,
                         LockSize = m.Marketlock_Size,
                         BookDetail = l.BookingDetails,
                         StartDate = l.Dateofreservation,
                         EndDate = l.Bookingenddate
                        

                     };
            if (lr.Count() > 0)
            {
                CusData.DataSource = lr.ToList();
                if (CusData.RowCount > 0)
                {
                    FromData();

                }
            }
        }

        private void FromData()
        {
            CusData.Columns[0].HeaderText = "เลขใบจอง";
            CusData.Columns[1].HeaderText = "รหัสผู้จอง";
            CusData.Columns[2].HeaderText = "ชื่อผู้จอง";
            CusData.Columns[3].HeaderText = "นามสกุลผู้จอง";
            CusData.Columns[4].HeaderText = "รหัสล็อค";
            CusData.Columns[5].HeaderText = "ขนาดล็อค";
            CusData.Columns[6].HeaderText = "รูปแบบการจอง";
            CusData.Columns[7].HeaderText = "วันที่เริ่มจอง";
            CusData.Columns[8].HeaderText = "วันสุดท้ายที่จอง";

            CusData.Columns[0].Width = 70;
            CusData.Columns[1].Width = 70;
            CusData.Columns[2].Width = 100;
            CusData.Columns[3].Width = 100;
            CusData.Columns[4].Width = 70;
            CusData.Columns[5].Width = 80;
            CusData.Columns[6].Width = 100;
            CusData.Columns[7].Width = 100;
            CusData.Columns[8].Width = 100;
        }

        private void Sherchbtn_Click(object sender, EventArgs e)
        {

            if (SearchBox.Text == "")
            {
                ShowData();
            }
            else { 
            var lr = from l in DB.Booking_market
                     join c in DB.Customer_market on l.CustomerID equals c.CustomerID
                     join m in DB.Marketlocks on l.Marketlock_ID equals m.Marketlock_ID
                     where l.UtilityID == null && l.Paymentstatus == "Completed" && l.BookingNumber == SearchBox.Text
                     select new
                     {
                         BookingID = l.BookingNumber,
                         CusID = l.CustomerID,
                         CusName = c.CustomerName,
                         CusLname = c.CustomerLastname,
                         LockID = l.Marketlock_ID,
                         LockSize = m.Marketlock_Size,
                         BookDetail = l.BookingDetails,
                         StartDate = l.Dateofreservation,
                         EndDate = l.Bookingenddate
                     };
              if (lr.Count() > 0)
              {
                CusData.DataSource = lr.ToList();
                if (CusData.RowCount > 0)
                {
                    FromData();

                }
              }
            }
        }
    }
    
}
