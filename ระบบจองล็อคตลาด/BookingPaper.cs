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
    public partial class BookingPaper : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();//ฐานข้อมูล
        public BookingPaper()
        {
            InitializeComponent();
            BookingNum.Focus();
        }

        private void BookingNum_KeyDown(object sender, KeyEventArgs e)
        {

            if (BookingNum.Text.Trim() == "")
            {
                ClearAll();
                paymentbtn.Enabled = true;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var bk = (from b in DB.Booking_market
                              join c in DB.Customer_market
                              on b.CustomerID equals c.CustomerID
                              join m in DB.Marketlocks
                              on b.Marketlock_ID equals m.Marketlock_ID
                              join p in DB.Category_product
                              on b.Typesofproductssold equals p.CategoryID
                              join em in DB.Employee_market
                              on b.EmployeeID equals em.EmployeeID
                              //where b.Paymentstatus == "Not yet paid"
                              select new
                              {
                                  BookID = b.BookingNumber,
                                  CusID = b.CustomerID,
                                  CusName = c.CustomerName,
                                  CusLastName = c.CustomerLastname,
                                  CusTel = c.CustomerPhone,
                                  CusEmail = c.CustomerEmail,
                                  LockID = b.Marketlock_ID,
                                  LockZone = m.MarketZonename,
                                  LockStatus = m.Marketlock_Status,
                                  LockSize = m.Marketlock_Size,
                                  BookingType = b.BookingDetails,
                                  SShopName = b.ShopName,
                                  ProductTypeName = p.CategoryName,
                                  ProductNum = b.Numberofproducts,
                                  Startdate = b.Dateofreservation,
                                  Enddate = b.Bookingenddate,
                                  Lockprice = b.LockPrice,
                                  Periot = b.ReservationPeriod,
                                  Total = b.PaymentAmount,
                                  EmpName = em.EmployeeName,
                                  PayStatus = b.Paymentstatus,
                                  TransactionDate = b.TransactionStartDate

                              }).Where(w => w.BookID == BookingNum.Text.Trim());
                    if (bk.Count() > 0)
                    {

                        BookingNum.Text = bk.FirstOrDefault().BookID.Trim();
                        if (bk.FirstOrDefault().PayStatus != "Completed" && bk.FirstOrDefault().PayStatus != "Payment failed")
                        {
                            ShowCusID.Text = bk.FirstOrDefault().CusID.ToString();
                            ShowCusName.Text = bk.FirstOrDefault().CusName.Trim();
                            ShowLastName.Text = bk.FirstOrDefault().CusLastName.Trim();
                            ShowTel.Text = bk.FirstOrDefault().CusTel.Trim();
                            ShowEmail.Text = bk.FirstOrDefault().CusEmail.Trim();
                            ShowLockID.Text = bk.FirstOrDefault().LockID.Trim();
                            ShowEmail.Text = bk.FirstOrDefault().CusEmail.Trim();
                            ShowLockID.Text = bk.FirstOrDefault().LockID.Trim();
                            ShowZone.Text = bk.FirstOrDefault().LockZone.Trim();
                            //ShowLockStatus.Text = bk.FirstOrDefault().LockStatus.Trim();
                            if (bk.FirstOrDefault().LockStatus == "Unavailable")
                            {
                                ShowLockStatus.Text = "จองแล้ว";
                            }
                            if (bk.FirstOrDefault().LockStatus == "Free")
                            {
                                ShowLockStatus.Text = "ว่าง";
                            }

                            ShowLockSize.Text = bk.FirstOrDefault().LockSize.Trim();
                            //ShowBookType.Text = bk.FirstOrDefault().BookingType.Trim();
                            if(bk.FirstOrDefault().BookingType == "Frequenter")
                            {
                                ShowBookType.Text = "ขาประจำ";
                            }
                            else if (bk.FirstOrDefault().BookingType == "Irregular")
                            {
                                ShowBookType.Text = "ขาจร";
                            }
                            ShowShopName.Text = bk.FirstOrDefault().SShopName.Trim();
                            ShowProductType.Text = bk.FirstOrDefault().ProductTypeName.Trim();
                            ShowProductQuantity.Text = bk.FirstOrDefault().ProductNum.Trim();
                            ShowStartDate.Text = bk.FirstOrDefault().Startdate.ToString();
                            ShowEndDate.Text = bk.FirstOrDefault().Enddate.ToString();
                            ShowBookingPrice.Text = bk.FirstOrDefault().Lockprice.ToString();
                            ShowPeriot.Text = bk.FirstOrDefault().Periot.ToString();
                            ShowTotal.Text = bk.FirstOrDefault().Total.ToString();
                            ShowEmpName.Text = bk.FirstOrDefault().EmpName.Trim();
                            ShowPayStatus.Text = bk.FirstOrDefault().PayStatus.Trim();
                            StartTransactionDate.Text = bk.FirstOrDefault().TransactionDate.ToString();
                            if (bk.FirstOrDefault().BookingType == "Frequenter")
                            {
                                ShowDeposit.Text = "1000";
                            }
                            else
                            {
                                ShowDeposit.Text = "0";
                            }
                        }
                        else
                        {
                            MessageBox.Show("ผู้จองท่านนี้ทำการชำระค่าจองแล้ว");
                            return;
                        }

                    }
                    //ตั้งเงื่อนไขว่า ถ้าเวลาเลยไป 3 วันแล้วยังไม่ได้มาชำระเงิน แล้วให้ขึ้นข้อความแดงตรงสถานะก่อน //
                    
                    DateTime d = DateTime.Parse(StartTransactionDate.Text); //เป็นประเภทเวลา
                    DateTime currentDate = DateTime.Now; //วันที่ปัจจุบัน
                    DateTime increateDate = d.AddDays(3);

                    if (currentDate > increateDate && bk.FirstOrDefault().PayStatus == "Not yet paid")
                    {
                        ShowPayStatus.Text = "ยังไม่ได้ชำระ";
                        ShowPayStatus.ForeColor = Color.OrangeRed;
                    }
                    else {
                        ShowPayStatus.Text = "ยังไม่ได้ชำระ";
                        ShowPayStatus.ForeColor = Color.Black;
                    }
                    

                }


            }
        }

        private void ShowProductType_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            //if (StartTransactionDate.Text != "") { 
            /*  DateTime d = DateTime.Parse(StartTransactionDate.Text); //เป็นประเภทเวลา
              DateTime currentDate = DateTime.Now; //วันที่ปัจจุบัน
              DateTime increateDate = d.AddDays(3);
              if (StartTransactionDate.Text != "")
              {
                  if (currentDate > increateDate)
              {
                  paymentbtn.Enabled = false;
                  MessageBox.Show("ไม่สามารถทำการชำระเงินได้ เนื่องจากเลยเวลาที่กำหนด ชำระเงิน");
              }
              else
              {

                  String data1 = BookingNum.Text;
                  //var booknum = 
                  PaymentPage p = new PaymentPage(data1);
                  p.ShowBookingID.Text = data1;
                  p.ShowDialog();

                  ClearAll();
              }
            }else
              {
                  return;
              }*/

            DateTime d;
            if (DateTime.TryParse(StartTransactionDate.Text, out d))
            {
                DateTime currentDate = DateTime.Now;
                DateTime increateDate = d.AddDays(3);

                if (currentDate > increateDate)
                {
                    paymentbtn.Enabled = false;
                    MessageBox.Show("ไม่สามารถทำการชำระเงินได้ เนื่องจากเลยเวลาที่กำหนด ชำระเงิน");
                }
                else
                {
                    String data1 = BookingNum.Text;
                    PaymentPage p = new PaymentPage(data1);
                    p.ShowBookingID.Text = data1;
                    p.ShowDialog();
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("ไม่พบเจอวันที่ทำการ");
            }
          
        }

        private void BookingNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookingPaper_Load(object sender, EventArgs e)
        {

        }

        private void ClearAll()
        {
            BookingNum.Text = "";
            ShowCusID.Text = "";
            ShowCusName.Text = "";
            ShowLastName.Text = "";
            ShowTel.Text = "";
            ShowEmail.Text = "";
            ShowLockID.Text = "";
            ShowEmail.Text = "";
            ShowLockID.Text = "";
            ShowZone.Text = "";
            ShowLockStatus.Text = "";
            ShowLockSize.Text = "";
            ShowBookType.Text = "";
            ShowShopName.Text = "";
            ShowProductType.Text = "";
            ShowProductQuantity.Text = "";
            ShowStartDate.Text = "";
            ShowEndDate.Text = "";
            ShowBookingPrice.Text = "";
            ShowPeriot.Text = "";
            ShowTotal.Text = "";
            ShowEmpName.Text = "";
            ShowPayStatus.Text = "";
            ShowDeposit.Text = "";
            StartTransactionDate.Text = "";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LockStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListCustombtn_Click(object sender, EventArgs e)
        {
            CustomerBookingList cl = new CustomerBookingList();
            cl.ShowDialog();
        }
    }
}
