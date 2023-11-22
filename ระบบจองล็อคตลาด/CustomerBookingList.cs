using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ระบบจองล็อคตลาด
{
    public partial class CustomerBookingList : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        public CustomerBookingList()
        {
            InitializeComponent();

           
        }

        private void CustomerBookingList_Load(object sender, EventArgs e)
        {
            Readdata();

            var GroupPay = from b in DB.Booking_market
                           join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                           where b.Paymentstatus == "Completed"
                           group b by b.Paymentstatus into statusGroup
                           select new
                           {
                               PayStatus = statusGroup.Key,
                               TotalPay = statusGroup.Count()
                           };
            int totalPayComplate = 0;

            foreach (var status in GroupPay)
            {
                totalPayComplate += status.TotalPay;
            }
            PaidNum.Text = totalPayComplate.ToString();


            var GroupPayNot = from b in DB.Booking_market
                           join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                           where b.Paymentstatus == "Not yet paid"
                           group b by b.Paymentstatus into statusGroup
                           select new
                           {
                               PayStatus = statusGroup.Key,
                               TotalPay = statusGroup.Count()
                           };
            int totalPayNot = 0;

            foreach (var status in GroupPayNot)
            {
                totalPayNot += status.TotalPay;
            }
            NotPaidNum.Text = totalPayNot.ToString();


             var GroupPayFail = from b in DB.Booking_market
                               join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                               where b.Paymentstatus == "Payment failed"
                                group b by b.Paymentstatus into statusGroup
                               select new
                               {
                                   PayStatus = statusGroup.Key,
                                   TotalPay = statusGroup.Count()
                               };
            int totalPayFail = 0;

            foreach (var status in GroupPayFail)
            {
                totalPayFail += status.TotalPay;
            }
            PaidFailNum.Text = totalPayFail.ToString();


            Totallll.Text = (totalPayComplate + totalPayNot + totalPayFail).ToString();

            var GroupJorn = from b in DB.Booking_market
                           join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                           where b.BookingDetails == "Irregular"
                            group b by b.Paymentstatus into statusGroup
                           select new
                           {
                               PayStatus = statusGroup.Key,
                               TotalPay = statusGroup.Count()
                           };
            int totalChaJorn = 0; //จำนวนขาจร

            foreach (var status in GroupJorn)
            {
                totalChaJorn += status.TotalPay;
            }
            IrregularNum.Text = totalChaJorn.ToString();


            var GroupJam = from b in DB.Booking_market
                            join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                            where b.BookingDetails == "Frequenter"
                           group b by b.Paymentstatus into statusGroup
                            select new
                            {
                                PayStatus = statusGroup.Key,
                                TotalPay = statusGroup.Count()
                            };
            int totalChaPrajam = 0; //จำนวนขาจร

            foreach (var status in GroupJam)
            {
                totalChaPrajam += status.TotalPay;
            }
            FrequenterNum.Text = totalChaPrajam.ToString();

        }

        private void Readdata()
        {
            var bk = from b in DB.Booking_market
                     join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                     
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
                         TranscaDate = b.TransactionStartDate,
                         returnID = b.LockReturnID
                         
                     };
            if (bk.Count() >= 0)
            {
                dataGridCustomer2.DataSource = bk.ToList();
                FormBooking();
            }
        }
        private void FormBooking()
        {
            if (dataGridCustomer2.RowCount > 0)
            {
                dataGridCustomer2.Columns[0].HeaderText = "เลขที่ใบจอง";
                dataGridCustomer2.Columns[1].HeaderText = "รหัสผู้จอง";
                dataGridCustomer2.Columns[2].HeaderText = "ชื่อผู้จอง";
                dataGridCustomer2.Columns[3].HeaderText = "รหัสล้อค";
                dataGridCustomer2.Columns[4].HeaderText = "หมายเลขโทรศัพท์";
                dataGridCustomer2.Columns[5].HeaderText = "อีเมลล์";
                dataGridCustomer2.Columns[6].HeaderText = "สถานะการชำระเงิน";
                dataGridCustomer2.Columns[7].HeaderText = "รูปแบบการจอง";
                dataGridCustomer2.Columns[8].HeaderText = "ชื่อร้าน";
                dataGridCustomer2.Columns[9].HeaderText = "วันที่เริ่มตั้งร้าน";
                dataGridCustomer2.Columns[10].HeaderText = "วันสุดท้ายที่ตั้งร้าน";
                dataGridCustomer2.Columns[11].HeaderText = "วันที่ทำรายการ";
                dataGridCustomer2.Columns[12].HeaderText = "รหัสคืนล็อค";

                dataGridCustomer2.Columns[0].Width = 80;
                dataGridCustomer2.Columns[1].Width = 60;
                dataGridCustomer2.Columns[2].Width = 100;
                dataGridCustomer2.Columns[3].Width = 100;
                dataGridCustomer2.Columns[4].Width = 80;
                dataGridCustomer2.Columns[5].Width = 100;
                dataGridCustomer2.Columns[6].Width = 100;
                dataGridCustomer2.Columns[7].Width = 100;
                dataGridCustomer2.Columns[8].Width = 100;
                dataGridCustomer2.Columns[9].Width = 100;
                dataGridCustomer2.Columns[10].Width = 100;
                dataGridCustomer2.Columns[11].Width = 100;
                dataGridCustomer2.Columns[12].Width = 100;
            }
        }

        private void Sherchbtn_Click(object sender, EventArgs e)
        {
            int InputCusID;
            if (BookingSearch.Text == "")
            {
                Readdata();
                
            }
            else
            {
                
                var bk = from b in DB.Booking_market
                         join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                         where b.BookingNumber == BookingSearch.Text || b.Marketlock_ID == BookingSearch.Text
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
                             TranscaDate = b.TransactionStartDate,
                             returnID = b.LockReturnID
                         };
                if (bk.Count() >= 0)
                {
                    dataGridCustomer2.DataSource = bk.ToList();
                    FormBooking();
                }
            
          }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Readdata();
            BookingSearch.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridCustomer2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DateTime? d = dataGridCustomer2.Rows[e.RowIndex].Cells["TranscaDate"].Value as DateTime?; //วันที่ทำการจอง
            DateTime? end = dataGridCustomer2.Rows[e.RowIndex].Cells["EndDate"].Value as DateTime?;
            DateTime? increateDate = d.Value.AddDays(3); //ล่วงหน้า 3 วัน
            DateTime currentDate = DateTime.Now; //วันที่ปัจจุบัน
            //string? returnID = dataGridCustomer2.Rows[e.RowIndex].Cells["returnID"].Value as string?; 

            if (e.ColumnIndex == dataGridCustomer2.Columns["PayStatus"].Index && e.Value != null)
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

            if (e.ColumnIndex == dataGridCustomer2.Columns["BookDetail"].Index && e.Value != null)
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

            if (e.ColumnIndex == dataGridCustomer2.Columns["StartDate"].Index && e.Value != null)
            {
                e.CellStyle.BackColor = Color.LawnGreen;
                e.CellStyle.ForeColor = Color.Black;
            }
            if (e.ColumnIndex == dataGridCustomer2.Columns["EndDate"].Index && e.Value != null)
            {
                string returnID = dataGridCustomer2.Rows[e.RowIndex].Cells["returnID"].Value as string;
                if (currentDate > end && returnID != null)
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.SaddleBrown;
                    e.CellStyle.ForeColor = Color.LawnGreen;
                }
                /* e.CellStyle.BackColor = Color.SaddleBrown;
                 e.CellStyle.ForeColor = Color.LawnGreen;
                 string returnID = dataGridCustomer2.Rows[e.RowIndex].Cells["returnID"].Value as string;

                 if (currentDate > end && returnID != null)
                 {
                     e.CellStyle.BackColor = Color.Red;
                     e.CellStyle.ForeColor = Color.White;
                 }*/
            }

            if (e.ColumnIndex == dataGridCustomer2.Columns["TranscaDate"].Index && e.Value != null)
            {
             
                /*if (currentDate > increateDate )
                {
                    e.CellStyle.ForeColor = Color.OrangeRed;
                }*/
                 e.CellStyle.ForeColor = Color.Black;


                /*if (e.ColumnIndex == dataGridCustomer2.Columns["EndDate"].Index && e.Value != null)
                {
                    string returnID = dataGridCustomer2.Rows[e.RowIndex].Cells["returnID"].Value as string;

                    if (!string.IsNullOrEmpty(returnID))
                    {
                        if (currentDate != null)
                        {
                            if (currentDate > increateDate)
                            {
                                e.CellStyle.ForeColor = Color.OrangeRed;
                            }
                            else
                            {
                                e.CellStyle.ForeColor = Color.Black;
                            }
                        }
                    }*/
                }
                //ในกรณีนี้ เราใช้ string.IsNullOrEmpty(returnID) เพื่อตรวจสอบว่า returnID ไม่เป็น null หรือ string.Empty(ค่าว่าง) และเราตรวจสอบว่า currentDate ไม่เป็น null โดยใช้การทดสอบ currentDate != null.ทั้งสองเงื่อนไขควรช่วยให้คุณควบคุมสถานการณ์ที่ถูกต้องและให้ผลลัพธ์ตามที่คุณต้องการในการกำหนดสีของเซลล์ใน DataGridView.
        }
        private void complate_Click(object sender, EventArgs e)
        {
            var bk = from b in DB.Booking_market
                     join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                     where b.Paymentstatus == "Completed"
                     select new
                     {
                         BookingID = b.BookingNumber,
                         CusID = b.CustomerID,
                         Cusname = c.CustomerName,
                         LOCKID =c.CustomerLog_ID,
                         CusPhone = c.CustomerPhone,
                         CusEmail = c.CustomerEmail,
                         PayStatus = b.Paymentstatus,
                         BookDetail = b.BookingDetails,
                         Shopname = b.ShopName,
                         StartDate = b.Dateofreservation,
                         EndDate = b.Bookingenddate,
                         TranscaDate = b.TransactionStartDate,
                         returnID = b.LockReturnID
                     };
            if (bk.Count() >= 0)
            {
                dataGridCustomer2.DataSource = bk.ToList();
                FormBooking();
            }

        }

        private void incomplate_Click(object sender, EventArgs e)
        {
            var bk = from b in DB.Booking_market
                     join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                     where b.Paymentstatus == "Not yet paid"
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
                         TranscaDate = b.TransactionStartDate,
                         returnID = b.LockReturnID
                     };
            if (bk.Count() >= 0)
            {
                dataGridCustomer2.DataSource = bk.ToList();
                FormBooking();
            }

        }

        private void Totalbtn_Click(object sender, EventArgs e)
        {
            var bk = from b in DB.Booking_market
                     join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                     
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
                         TranscaDate = b.TransactionStartDate,
                         returnID = b.LockReturnID
                     };
            if (bk.Count() >= 0)
            {
                dataGridCustomer2.DataSource = bk.ToList();
                FormBooking();
            }
        }

        private void PayFailbtn_Click(object sender, EventArgs e)
        {
            var bk = from b in DB.Booking_market
                     join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                     where b.Paymentstatus == "Payment failed"
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
                         TranscaDate = b.TransactionStartDate,
                         returnID = b.LockReturnID
                     };
            if (bk.Count() >= 0)
            {
                dataGridCustomer2.DataSource = bk.ToList();
                FormBooking();
            }
        }

        private void returnLockList_Click(object sender, EventArgs e)
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
                         TranscaDate = b.TransactionStartDate,
                         returnID = b.LockReturnID
                     };
            if (bk.Count() >= 0)
            {
                dataGridCustomer2.DataSource = bk.ToList();
                FormBooking();
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            var bk = from b in DB.Booking_market
                     join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                     where b.LockReturnID != null
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
                         TranscaDate = b.TransactionStartDate,
                         returnID = b.LockReturnID
                     };
            if (bk.Count() >= 0)
            {
                dataGridCustomer2.DataSource = bk.ToList();
                FormBooking();
            }
        }

        private void IrregularBtn_Click(object sender, EventArgs e)
        {
            var bk = from b in DB.Booking_market
                     join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                     where b.BookingDetails == "Irregular"
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
                         TranscaDate = b.TransactionStartDate,
                         returnID = b.LockReturnID

                     };
            if (bk.Count() >= 0)
            {
                dataGridCustomer2.DataSource = bk.ToList();


                FormBooking();
            }


        }

        private void FormBooking2()
        {
            if (dataGridCustomer2.RowCount > 0)
            {
                dataGridCustomer2.Columns[0].HeaderText = "เลขที่ใบจอง";
                dataGridCustomer2.Columns[1].HeaderText = "รหัสผู้จอง";
                dataGridCustomer2.Columns[2].HeaderText = "ชื่อผู้จอง";
                dataGridCustomer2.Columns[3].HeaderText = "นามสกุลผู้จอง";
                dataGridCustomer2.Columns[4].HeaderText = "รหัสล้อค";
                dataGridCustomer2.Columns[5].HeaderText = "หมายเลขโทรศัพท์";
                dataGridCustomer2.Columns[6].HeaderText = "รูปแบบการจอง";
                dataGridCustomer2.Columns[7].HeaderText = "รูปแบบกาชำระเงิน";



                dataGridCustomer2.Columns[0].Width = 80;
                dataGridCustomer2.Columns[1].Width = 60;
                dataGridCustomer2.Columns[2].Width = 100;
                dataGridCustomer2.Columns[3].Width = 100;
                dataGridCustomer2.Columns[4].Width = 80;
                dataGridCustomer2.Columns[5].Width = 100;
                dataGridCustomer2.Columns[6].Width = 100;
                dataGridCustomer2.Columns[7].Width = 100;

            }
        }

        private void Frequenter_Click(object sender, EventArgs e)
        {
            var bk = from b in DB.Booking_market
                     join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                     where b.BookingDetails == "Frequenter"
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
                         TranscaDate = b.TransactionStartDate,
                         returnID = b.LockReturnID

                     };
            if (bk.Count() >= 0)
            {
                dataGridCustomer2.DataSource = bk.ToList();


                FormBooking();
            }
        }

        
    }
}
