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
    public partial class ListOfBookingCustomer : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        public ListOfBookingCustomer()
        {
            InitializeComponent();
        }

        private void ListOfBookingCustomer_Load(object sender, EventArgs e)
        {
            var bk = from b in DB.Booking_market
                     join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                     where b.LockReturnID == null
                     select new
                     {
                         BookingID = b.BookingNumber,
                         CusID = b.CustomerID,
                         Cusname = c.CustomerName,
                         LOCKID = c.CustomerLog_ID,
                         CusPhone = c.CustomerPhone,
                         CusEmail = c.CustomerEmail,
                         PayStatus = b.Paymentstatus,
                         BookDetail = b.BookingDetails,
                         Shopname = b.ShopName,
                         StartDate = b.Dateofreservation,
                         EndDate = b.Bookingenddate,

                     };
            if (bk.Count() >= 0)
            {
                dataCustomerBooking.DataSource = bk.ToList();
                FormBooking();
            }
        }

        private void FormBooking()
        {
            if (dataCustomerBooking.RowCount > 0)
            {
                dataCustomerBooking.Columns[0].HeaderText = "เลขที่ใบจอง";
                dataCustomerBooking.Columns[1].HeaderText = "รหัสผู้จอง";
                dataCustomerBooking.Columns[2].HeaderText = "ชื่อผู้จอง";
                dataCustomerBooking.Columns[3].HeaderText = "รหัสล้อค";
                dataCustomerBooking.Columns[4].HeaderText = "หมายเลขโทรศัพท์";
                dataCustomerBooking.Columns[5].HeaderText = "อีเมลล์";
                dataCustomerBooking.Columns[6].HeaderText = "สถานะการชำระเงิน";
                dataCustomerBooking.Columns[7].HeaderText = "รูปแบบการจอง";
                dataCustomerBooking.Columns[8].HeaderText = "ชื่อร้าน";
                dataCustomerBooking.Columns[9].HeaderText = "วันที่เริ่มตั้งร้าน";
                dataCustomerBooking.Columns[10].HeaderText = "วันสุดท้ายที่ตั้งร้าน";


                dataCustomerBooking.Columns[0].Width = 80;
                dataCustomerBooking.Columns[1].Width = 60;
                dataCustomerBooking.Columns[2].Width = 100;
                dataCustomerBooking.Columns[3].Width = 100;
                dataCustomerBooking.Columns[4].Width = 80;
                dataCustomerBooking.Columns[5].Width = 100;
                dataCustomerBooking.Columns[6].Width = 100;
                dataCustomerBooking.Columns[7].Width = 100;
                dataCustomerBooking.Columns[8].Width = 100;
                dataCustomerBooking.Columns[9].Width = 100;
                dataCustomerBooking.Columns[10].Width = 100;
             
            }
        }

        private void dataCustomerBooking_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataCustomerBooking.Columns["BookDetail"].Index && e.Value != null)
            {
                string BookType = e.Value.ToString();

                if (BookType == "Irregular")
                {
                    e.CellStyle.BackColor = Color.Gold;
                }
                else if (BookType == "Frequenter")
                {

                    e.CellStyle.BackColor = Color.DeepSkyBlue;
                    e.CellStyle.ForeColor = Color.White;
                }
            }

            if (e.ColumnIndex == dataCustomerBooking.Columns["PayStatus"].Index && e.Value != null)
            {
                string lockStatus = e.Value.ToString();

                if (lockStatus == "Completed")
                {
                    e.CellStyle.ForeColor = Color.Green; // ล็อคว่างขึ้นสีเขียว
                }
                else if (lockStatus == "Not yet paid")
                {
                    e.CellStyle.ForeColor = Color.Red; // ล็อคจองขึ้นเป็นสีแดง
                }
            }

            if (e.ColumnIndex == dataCustomerBooking.Columns["StartDate"].Index && e.Value != null)
            {
                e.CellStyle.BackColor = Color.LawnGreen;
                e.CellStyle.ForeColor = Color.Black;
            }
            if (e.ColumnIndex == dataCustomerBooking.Columns["EndDate"].Index && e.Value != null)
            {
                /*string returnID = dataGridCustomer2.Rows[e.RowIndex].Cells["returnID"].Value as string;
                if (currentDate > end && returnID != null)
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }*/
               // else
                //{
                    e.CellStyle.BackColor = Color.SaddleBrown;
                    e.CellStyle.ForeColor = Color.LawnGreen;
               // }
            }
            }
    }
}
