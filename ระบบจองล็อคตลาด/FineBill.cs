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
    public partial class FineBill : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        public FineBill()
        {

            InitializeComponent();
        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            String data1 = BookingNumber.Text;

            PaymentPage p = new PaymentPage(data1);
            p.ShowBookingID.Text = data1;
            p.ShowDialog();

            ClearAll();
        }

        private void FineBill_Load(object sender, EventArgs e)
        {

        }

        private void ListCustomer_Click(object sender, EventArgs e)
        {
            FineListForPay fp = new FineListForPay();
            fp.ShowDialog();
        }

        private void BookingNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (BookingNumber.Text.Trim() == "")
            {
                ClearAll();
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter) //เมื่อพิมพ์แค่รหัส ข้อมูลที่เหลือก็แสดง
                {
                   
                    var bk = (from b in DB.Lock_return
                             where b.BookingID == BookingNumber.Text 
                              select new
                              {
                                  BookID =  b.BookingID,
                                  CusID = b.CustomerID,
                                  Cusname =  b.CustomerName,
                                  CusLname = b.CustomerLastname,
                                  LockID =  b.Marketlock_ID,
                                  BookDetail = b.BookingDetails,
                                  PayStatus = b.FinePayStatus,
                                  FineID1 = b.FineTypeID1,
                                  FineID2 = b.FineTypeID2,
                                  LatePeriod = b.LateReturnPeriod,
                                  Amount = b.FineSum,
                                  ReturnDate = b.LockReturnDate,
                                 
                              }).Where(w => w.BookID == BookingNumber.Text);

                    if (bk.Count() > 0)
                    {
                        if (bk.FirstOrDefault().PayStatus != "ไม่ต้องชำระ") { 
                        BookingNumber.Text = bk.FirstOrDefault().BookID.Trim();
                        ShowCusID.Text = bk.FirstOrDefault().CusID.ToString();
                        ShowCusName.Text = bk.FirstOrDefault().Cusname.Trim();
                        ShowLastName.Text = bk.FirstOrDefault().CusLname.Trim();
                        ShowLockID.Text = bk.FirstOrDefault().LockID.Trim();
                        ShowBookingType.Text = bk.FirstOrDefault().BookDetail.Trim();
                        ShowPaymentStatus.Text = bk.FirstOrDefault().PayStatus.Trim();
                        LockReturnDate.Text = bk.FirstOrDefault().ReturnDate.ToString();

                        var finename1 = DB.Fine_market.FirstOrDefault(b => b.FineID == bk.FirstOrDefault().FineID1.Trim());
                        decimal finefee1, finefee2; //ไว้เก็บค่า

                        if (finename1 != null)
                        {
                            NameFine1.Text = finename1.FineType;
                            FineFee1.Text = finename1.FineFee.ToString();
                            finefee1 = finename1.FineFee.Value;
                        }
                        var finename2 = DB.Fine_market.FirstOrDefault(b => b.FineID == bk.FirstOrDefault().FineID2.Trim());
                        if (finename2 != null)
                        {
                            NameFine2.Text = finename2.FineType;
                            FineFee2.Text = finename2.FineFee.ToString();
                            finefee2 = finename2.FineFee.Value;
                        }

                        ShowLateTime.Text = bk.FirstOrDefault().LatePeriod.ToString();

                        decimal LateFee = (bk.FirstOrDefault().LatePeriod.Value * 100); //ค่าปรับเมื่อคืนล็อคช้า
                        ShowLatetimeFee.Text = LateFee.ToString();

                        decimal totalFee = decimal.Parse(FineFee1.Text) + decimal.Parse(FineFee2.Text) + LateFee;  //ผลรวมค่าปรับ
                        ShowFineTotal.Text = totalFee.ToString();

                        //แจ้งเตื่อนกรณี ชำระเกินเวลา
                        DateTime d = DateTime.Parse(LockReturnDate.Text); //เป็นประเภทเวลา
                        DateTime currentDate = DateTime.Now;

                        if (currentDate > d && bk.FirstOrDefault().PayStatus == "ยังไม่ได้ชำระ")
                        {
                            ShowPaymentStatus.ForeColor = Color.OrangeRed;
                        }
                        else ShowPaymentStatus.ForeColor = Color.Black;

                       }
                        else
                        {
                            MessageBox.Show("ผู้จองนี้ไม่มีการเสียค่าปรับ");
                            return;
                        }

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            BookingNumber.Text = "";
            ShowCusID.Text ="";
            ShowCusName.Text = "" ;
            ShowLastName.Text = "";
            ShowLockID.Text = "";
            ShowBookingType.Text = "";
            ShowPaymentStatus.Text = "";
            NameFine1.Text = "";
            FineFee1.Text = "0.00";
            NameFine2.Text = "";
            FineFee2.Text = "0.00";
            ShowLateTime.Text = "-";
            ShowFineTotal.Text = "0.00";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
