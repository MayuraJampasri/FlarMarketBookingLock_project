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
    public partial class UtibilityBill : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();//ฐานข้อมูล
        public UtibilityBill()
        {
           


            InitializeComponent();
        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            Booking_market bk = new Booking_market();
            var UtilityPay = DB.Booking_market.FirstOrDefault(b => b.BookingNumber == BookingNumber.Text);
            if (UtilityPay != null)
            {
                if (UtilityPay.LockReturnID == null) { 
                String Booknum = BookingNumber.Text;
                PaymentPage p = new PaymentPage(Booknum);
                p.ShowBookingID.Text = Booknum;
                p.ShowDialog();

                ClearAll();
                ShowData();
               }
                else
                {
                    MessageBox.Show("ผู้จองท่านนี้คืนล็อคแล้ว ไม่สามารถชำระค่าน้ำค่าไฟได้");
                    var UtilityStatus = DB.Utility_Market.FirstOrDefault(b => b.BookingNumber == BookingNumber.Text);
                    if (UtilityStatus != null)
                    { 
                        UtilityStatus.PaymentStatus = "ชำระเงินไม่สำเร็จ";
                        DB.SaveChanges();
                    }
                        paymentbtn.Enabled = false;
                    //return;
                }
            }
        }

        private void BookingNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (BookingNumber.Text.Trim() == "")
            {
                ClearAll();
                paymentbtn.Enabled = true;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var ut = (from u in DB.Utility_Market 
                              //join b in DB.Booking_market on u.BookingNumber equals b.BookingNumber
                              where u.BookingNumber == BookingNumber.Text.Trim() //คนที่มีรายชื่อในตารางบันทึกค่าน้ำค่าไฟเท่านั้น
                              select new { 
                                  BookID = u.BookingNumber,
                                  UtiliID = u.UtilityID,
                                  CusID = u.CustomerID,
                                  Cusname = u.CustomerName,
                                  CusLname =  u.CustomerLname,
                                  BookType =u.BookingDetail,
                                  DurationUsed = u.DurationUsed,
                                  EndDate = u.EndDate,
                                  PayStatus = u.PaymentStatus,
                                  Amount = u.UtilityAmount,
                                  LockID = u.LockID,
                                  LockZone = u.MarketZonename,
                                  
                              });
                    if (ut.Count() > 0)
                    {
                        BookingNumber.Text = ut.FirstOrDefault().BookID.Trim();
                        
                           if (ut.FirstOrDefault().PayStatus != "Completed") //คนที่ชำระค่าน้ำไฟแล้ว
                           {
                            BookingNumber.Text = ut.FirstOrDefault().BookID;
                            ShowCusID.Text = ut.FirstOrDefault().CusID.ToString();
                            ShowCusName.Text = ut.FirstOrDefault().Cusname;
                            ShowLastName.Text = ut.FirstOrDefault().CusLname;
                            ShowUtilityID.Text = ut.FirstOrDefault().UtiliID.ToString();
                            ShowLockID.Text = ut.FirstOrDefault().LockID;
                            ShowBookingType.Text = ut.FirstOrDefault().BookType;
                            ShowLockType.Text = ut.FirstOrDefault().LockZone;
                            ShowUtilityUsed.Text = ut.FirstOrDefault().DurationUsed.ToString();
                            ShowPayStatus.Text = ut.FirstOrDefault().PayStatus;
                            ShowUtilityUsed2.Text = ut.FirstOrDefault().DurationUsed.ToString();
                            ShowUtibilityFee.Text = ut.FirstOrDefault().Amount.ToString();
                            ShowUtibilityTotal.Text = ut.FirstOrDefault().Amount.ToString();
                            LastDate.Text = ut.FirstOrDefault().EndDate.ToString();
                            //LastDate.Text = ut.FirstOrDefault().LastDate.ToString();
                            }
                            else
                            {
                            MessageBox.Show("ผู้จองท่านนี้ทำการชำระแล้ว");
                            return;
                             }
                         
                    }
                }
            }
        }

        private void ClearAll()
        {
            BookingNumber.Text = "";
            ShowCusID.Text = "";
            ShowCusName.Text = "";
            ShowLastName.Text = "";
            ShowUtilityID.Text = "";
            ShowLockID.Text = "";
            ShowBookingType.Text = "";
            ShowLockType.Text = "";
            ShowUtilityUsed.Text = "";
            ShowPayStatus.Text = "";
            ShowUtilityUsed2.Text = "";
            ShowUtibilityFee.Text = "";
            ShowUtibilityTotal.Text = "";
            LastDate.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UtibilityBill_Load(object sender, EventArgs e)
        {

        }
        private void ShowData()
        {
            var ut = (from u in DB.Utility_Market
                      where u.PaymentStatus == "ยังไม่ชำระ"
                      select new
                      {
                          BookID = u.BookingNumber,
                          UtiliID = u.UtilityID,
                          CusID = u.CustomerID,
                          Cusname = u.CustomerName,
                          CusLname = u.CustomerLname,
                          BookType = u.BookingDetail,
                          DurationUsed = u.DurationUsed,
                          EndDate = u.EndDate,
                          PayStatus = u.PaymentStatus,
                          Amount = u.UtilityAmount,
                          LockID = u.LockID,
                          LockZone = u.MarketZonename
                          
                      });
            if (ut.Count() > 0)
            {
                dataUtilityNotPay.DataSource = ut.ToList();

                if (dataUtilityNotPay.RowCount > 0)
                {
                    dataUtilityNotPay.Columns[0].HeaderText = "เลขใบจอง";
                    dataUtilityNotPay.Columns[1].HeaderText = "รหัสค่าสถารณูปโภค";
                    dataUtilityNotPay.Columns[2].HeaderText = "รหัสผู้จอง";
                    dataUtilityNotPay.Columns[3].HeaderText = "ชื่อผู้จอง";
                    dataUtilityNotPay.Columns[4].HeaderText = "นามสกุลผู้จอง";
                    dataUtilityNotPay.Columns[5].HeaderText = "รูปแบบการจอง";
                    dataUtilityNotPay.Columns[6].HeaderText = "รอบเวลาในการชำระเงิน(วัน)";
                    dataUtilityNotPay.Columns[7].HeaderText = "วันสุดท้ายที่จอง";
                    dataUtilityNotPay.Columns[8].HeaderText = "สถานะการชำระเงิน";
                    dataUtilityNotPay.Columns[9].HeaderText = "ค่าใช้จ่ายทั้งหมด";
                    dataUtilityNotPay.Columns[10].HeaderText = "รหัสล็อค";
                    dataUtilityNotPay.Columns[11].HeaderText = "โซน";

                    dataUtilityNotPay.Columns[0].Width = 80;
                    dataUtilityNotPay.Columns[1].Width = 90;
                    dataUtilityNotPay.Columns[2].Width = 80;
                    dataUtilityNotPay.Columns[3].Width = 90;
                    dataUtilityNotPay.Columns[4].Width = 90;
                    dataUtilityNotPay.Columns[5].Width = 100;
                    dataUtilityNotPay.Columns[6].Width = 100;
                    dataUtilityNotPay.Columns[7].Width = 100;
                    dataUtilityNotPay.Columns[8].Width = 100;
                    dataUtilityNotPay.Columns[9].Width = 80;
                    dataUtilityNotPay.Columns[10].Width = 100;
                    dataUtilityNotPay.Columns[11].Width = 100;
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ShowData();
            }

        private void ListCustomer_Click(object sender, EventArgs e)
        {

        }

        private void dataUtilityNotPay_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int? DurationDate = dataUtilityNotPay.Rows[e.RowIndex].Cells["DurationUsed"].Value as int?;
            DateTime? end = dataUtilityNotPay.Rows[e.RowIndex].Cells["EndDate"].Value as DateTime?;
            DateTime currentDate = DateTime.Now;

            if (e.ColumnIndex == dataUtilityNotPay.Columns["PayStatus"].Index && e.Value != null)
            {
                if (DurationDate == 30)
                {
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if(DurationDate < 30)
                {
                    e.CellStyle.ForeColor = Color.Salmon;
                }
            }

            if (e.ColumnIndex == dataUtilityNotPay.Columns["EndDate"].Index && e.Value != null)
            {
                if (currentDate > end)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;
                }
                else if (currentDate < end)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.White;
                }
                
            }
            }
    }
}
