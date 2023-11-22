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
    public partial class LockReturn : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        Fine_market fm = new Fine_market();
        public LockReturn()
        {
            InitializeComponent();
            DateToReturnLock.Text = DateTime.Now.ToLongDateString();

            var finecost = from f in DB.Fine_market
                           select new
                           {
                               fineID = f.FineID,
                               fineType = f.FineType,
                               fineFee = f.FineFee
                           };
            Fine1.BeginUpdate();
            Fine1.DisplayMember = "fineType";
            Fine1.ValueMember = "fineID";
            Fine1.DataSource = finecost.ToList();
            Fine1.EndUpdate();

            Fine2.BeginUpdate();
            Fine2.DisplayMember = "fineType";
            Fine2.ValueMember = "fineID";
            Fine2.DataSource = finecost.ToList();
            Fine2.EndUpdate();

            BookingNumber.Focus();


        }

        private void UpdateFineValues() {
            if (Fine1.SelectedItem != null && Fine2.SelectedItem != null)
            {
                string fineId1 = Fine1.SelectedValue.ToString();
                string fineId2 = Fine2.SelectedValue.ToString();


                var fineValue1 = DB.Fine_market.FirstOrDefault(cl => cl.FineID == fineId1);
                var fineValue2 = DB.Fine_market.FirstOrDefault(cl => cl.FineID == fineId2);

                if (fineValue1 != null && fineValue2 != null)
                {
                    Value1.Text = fineValue1.FineFee.ToString();
                    Value2.Text = fineValue2.FineFee.ToString();
                }
            }

        }
        private void BookingNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (BookingNumber.Text.Trim() == "")
            {
                returnbtn.Enabled = true;
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter) //เมื่อพิมพ์แค่รหัส ข้อมูลที่เหลือก็แสดง
                {
                    var bk = (from b in DB.Booking_market
                              join l in DB.Marketlocks on b.Marketlock_ID equals l.Marketlock_ID
                              join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                              where b.Marketlock_ID == l.Marketlock_ID 
                              select new
                              {
                                  BookingID = b.BookingNumber,
                                  CusID = b.CustomerID,
                                  CusName = c.CustomerName,
                                  CusLname = c.CustomerLastname,
                                  BookDetail = b.BookingDetails,
                                  StartDate = b.Dateofreservation,
                                  EndDate = b.Bookingenddate,
                                  Period = b.ReservationPeriod,
                                  LockID = l.Marketlock_ID,
                                  LockSize = l.Marketlock_Size,
                                  LockeZone = l.MarketZonename,
                                  LockReturnID = b.LockReturnID
                              }).Where(w => w.BookingID == BookingNumber.Text);

                    if (bk.Count() > 0)
                    {
                        
                        BookingNumber.Text = bk.FirstOrDefault().BookingID.Trim();
                        ShowCusID.Text = bk.FirstOrDefault().CusID.ToString();
                        ShowCusName.Text = bk.FirstOrDefault().CusName.Trim();
                        ShowLastName.Text = bk.FirstOrDefault().CusLname.Trim();
                        ShowBookingType.Text = bk.FirstOrDefault().BookDetail.Trim();
                        ShowFirstDate.Text = bk.FirstOrDefault().StartDate.ToString();
                        ShowLastDate.Text = bk.FirstOrDefault().EndDate.ToString();
                        ShowBookingPeriot.Text = bk.FirstOrDefault().Period.ToString();
                        ShowLockID.Text = bk.FirstOrDefault().LockID.Trim();
                        ShowLockSize.Text = bk.FirstOrDefault().LockSize.Trim();
                        ShowLockType.Text = bk.FirstOrDefault().LockeZone.Trim();

                        ClaerCal();
                      
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลจร้า", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BookingNumber.Text = ""; //ลบข้อมูล
                        BookingNumber.Focus();
                    }
                }
            }
        }

        private void Calculatebtn_Click(object sender, EventArgs e)
        {


            Fine_market f = new Fine_market();
            //Booking_market bk = new Booking_market();

            if (ShowLastDate.Text == "-" || ShowLastDate.Text == "")
            {
                MessageBox.Show("กรุณาใส่ข้อมูลให้ครบถ้วน");
                return;
            }
            else
            {
                DateTime currentDate = DateTime.Now;
                DateTime lastBookingDateIrregular = DateTime.Parse(ShowLastDate.Text); //วันจองสุดท้ายของขาจร
                DateTime lastBookingDateFrequenter = DateTime.Parse(ShowLastDate.Text); //วันจองสุดท้ายขาประจำ
                                                                                         //DateTime SubtractOneWeek = lastBookingDateFrequenter.AddMonths(-1); //ลดอีก 1 อาทิตย์

                /* if (Fine1.SelectedItem != null && Fine2.SelectedItem != null)
                 {
                     string fineId1 = Fine1.SelectedValue.ToString();
                     string fineId2 = Fine2.SelectedValue.ToString();


                     var fineValue1 = DB.Fine_market.FirstOrDefault(cl => cl.FineID == fineId1);
                     var fineValue2 = DB.Fine_market.FirstOrDefault(cl => cl.FineID == fineId2);

                     if (fineValue1 != null && fineValue2 != null)
                     {
                         Value1.Text = fineValue1.FineFee.ToString();
                         Value2.Text = fineValue2.FineFee.ToString();
                     }
                 }*/


                if (ShowBookingType.Text == "Irregular")
                {
                    if (lastBookingDateIrregular < currentDate)
                    {
                        //ถ้ายกเลิกล็อคหลังวันสดท้ายจะมีการเก็บค่าปรับ
                        TimeSpan difference = currentDate - lastBookingDateIrregular;
                        int lateTime = difference.Days;
                        LatetimeNumber.Text = lateTime.ToString();
                        LatetimeNumber.ForeColor = Color.OrangeRed;
                    }
                    else if (lastBookingDateIrregular > currentDate)
                    {
                        /*TimeSpan difference = currentDate - lastBookingDateIrregular;
                        int lateTime = - difference.Days;*/
                        LatetimeNumber.Text = "0";
                        //LatetimeNumber.Text = lateTime.ToString();
                        LatetimeNumber.ForeColor = Color.Black;
                    }
                }
                else if (ShowBookingType.Text == "Frequenter")
                {
                    //ถ้ายกเลิกล็อคหลัง 1 อาทิตย์ก่อนขึ้นเดือนถัดไป จะมีการเก็บค่าปรับ
                    if (lastBookingDateFrequenter < currentDate)
                    {
                        TimeSpan difference = currentDate - lastBookingDateFrequenter;
                        int lateTime = difference.Days;
                        LatetimeNumber.Text = lateTime.ToString();
                        LatetimeNumber.ForeColor = Color.OrangeRed;
                    }
                    else if (lastBookingDateFrequenter > currentDate)
                    {
                        LatetimeNumber.Text = "0";
                        LatetimeNumber.ForeColor = Color.Black;
                    }

                }
                else
                {
                    return;
                }

            



            //part คำนวณ

            int Latetime = int.Parse(LatetimeNumber.Text);

            LateReturnFind.Text = (Latetime * 100).ToString(); //ค่าปรับคืนล็อคช้า


            decimal TotalValueFine;
            TotalValueFine = (decimal.Parse(Value1.Text) + decimal.Parse(Value2.Text) + Decimal.Parse(LateReturnFind.Text)); //ผลรวมค่าปรับ

            TotalValue.Text = TotalValueFine.ToString(); //แสดงค่าปรับทั้งหมดผ่านหน้าจอ 

        }
     }

        private void Fine1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFineValues();
        }

        private void Fine2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFineValues();
        }

        private void ClaerCal()
        {
            Fine1.SelectedValue = "F01";
            Fine2.SelectedValue = "F01";
            var fineValue1 = DB.Fine_market.FirstOrDefault(cl => cl.FineID == "F01");
            var fineValue2 = DB.Fine_market.FirstOrDefault(cl => cl.FineID == "F01");
            if (fineValue1 != null && fineValue2 != null)
            {
                Value1.Text = fineValue1.FineFee.ToString();
                Value2.Text = fineValue2.FineFee.ToString();
            }
            LatetimeNumber.Text = "-";
            LateReturnFind.Text = "-";
            TotalValue.Text = "-";
        }

        

        private void returnbtn_Click(object sender, EventArgs e)
        {
            Lock_return lr = new Lock_return();
            DateTime currentDate = DateTime.Now;
            DateTime lastBookingDate ; //วันจองสุดท้าย 
            DateTime StartBookingDate; //วันจองวันแรก

            if (MessageBox.Show("คุณต้องการทำรายการคืนล็อคใช่หรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (ShowLastDate.Text == "-" || ShowLastDate.Text == "")
                {
                    MessageBox.Show("ไม่พบวันจองวันสุดท้าย");
                    return;
                }
                else 
                {
                    lastBookingDate = DateTime.Parse(ShowLastDate.Text); //วันจองสุดท้าย 
                    StartBookingDate = DateTime.Parse(ShowFirstDate.Text);

                    if (BookingNumber.Text != lr.BookingID)
                  {

                        lr.BookingID = BookingNumber.Text;
                        lr.CustomerID = int.Parse(ShowCusID.Text);
                        lr.CustomerName = ShowCusName.Text;
                        lr.CustomerLastname = ShowLastName.Text;
                        lr.Marketlock_ID = ShowLockID.Text;
                        lr.BookingDetails = ShowBookingType.Text;
                        lr.LockReturnDate = DateTime.Parse(DateToReturnLock.Text);
                        lr.LateReturnPeriod = int.Parse(LatetimeNumber.Text);
                        lr.FineTypeID1 = Fine1.SelectedValue.ToString();
                        lr.FineTypeID2 = Fine2.SelectedValue.ToString();
                        lr.FineSum = decimal.Parse(TotalValue.Text);
                        lr.LockSize = ShowLockSize.Text;
                        lr.Bookingenddate = DateTime.Parse(ShowLastDate.Text);
                        if (decimal.Parse(TotalValue.Text) > 0)
                        {
                            lr.FinePayStatus = "ยังไม่ได้ชำระ";
                        }
                        else if (decimal.Parse(TotalValue.Text) == 0)
                        {
                            lr.FinePayStatus = "ไม่ต้องชำระ";
                        }

                        if (StartBookingDate > currentDate)
                        {
                            lr.LockReturnStatus = "คืนล็อคก่อนเวลา";
                        }
                        else if (StartBookingDate <= currentDate && lastBookingDate >= currentDate)
                        {
                            lr.LockReturnStatus = "คืนล็อคสำเร็จ";
                        }
                        else if (lastBookingDate < currentDate)
                        {
                            lr.LockReturnStatus = "คืนล็อคล่าช้า";
                        }
                        //lr.LockReturnStatus = "Complete Return";

                        DB.Lock_return.Add(lr);

                        //เพิ่มในฐานข้อมูล

                        DB.SaveChanges();
                        MessageBox.Show("คืนล็อคสำเร็จ");
                        
                  }
                  else if(BookingNumber.Text == lr.BookingID)
                    {
                        MessageBox.Show("ล็อคนี้ถูกคืนแล้ว");
                        returnbtn.Enabled = false;
                        return;
                    }


                //เปลี่ยนสถานะล็อคเมิ่อคืน
                  var booking = DB.Marketlocks.FirstOrDefault(b => b.Marketlock_ID == lr.Marketlock_ID);
                  if (booking != null)
                  {
                    if (booking.Marketlock_Status == "Unavailable")
                    {
                        // ถ้ามีการจองล็อค และต้องการให้เปลี่ยนสถานะล็อคจาก "วจองแล้ว" เป็น "ว่าง"

                        booking.Marketlock_Status = "Free";
                        booking.BookingNumber = null;
                        DB.SaveChanges(); // บันทึกการเปลี่ยนแปลงลงในฐานข้อมูล
                        
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถเปลี่ยนแปลงข้อมูล Marketlock_Status ได้");
                        return;
                    }
                  }

                   var LockReturnID = DB.Booking_market.FirstOrDefault(b => b.BookingNumber == lr.BookingID);
                   if (LockReturnID != null)
                   {
                    LockReturnID.LockReturnID = lr.Lock_ReturnID;
                        LockReturnID.Marketlock_ID = null;
                    DB.SaveChanges();
                   }
                   //กรณีผู้จองไม่ชำระค่าจอง(สถานะขึ้นเป็นสีแดง) ให้ทำการคืนล็อคได้
                    var BookStatus = DB.Booking_market.FirstOrDefault(b => b.BookingNumber == lr.BookingID);
                    if (BookStatus != null)
                    {
                        if(BookStatus.Paymentstatus == "Not yet paid") {
                            BookStatus.Paymentstatus = "Payment failed";
                            DB.SaveChanges();
                        }

                    }
                    FineBill fb = new FineBill();
                    fb.BookingNumber.Text = BookingNumber.Text;
                    fb.ShowDialog();

                    Clear();
                    ClaerCal();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ShowData();
        }

        private void LockReturn_Load(object sender, EventArgs e)
        {

        }

        private void CusList_Click(object sender, EventArgs e)
        {
            ListOfBookingCustomer cb = new ListOfBookingCustomer();
            cb.ShowDialog();
        }

        private void ShowData()
        {
            var rl = from r in DB.Lock_return
                     select new
                     {
                         LockRturnID = r.Lock_ReturnID,
                         BookID =r.BookingID,
                         CusID = r.CustomerID,
                         CusName = r.CustomerName,
                         CusLname = r.CustomerLastname,
                         LockID =  r.Marketlock_ID,
                         ReturnDate =  r.LockReturnDate,
                         EndDate = r.Bookingenddate,
                         ReturnStatus = r.LockReturnStatus
                     };

           if(rl.Count() >0)
            {
                dataReturn.DataSource = rl.ToList();

                if (dataReturn.RowCount > 0)
                {
                    dataReturn.Columns[0].HeaderText = "รหัสการคืน";
                    dataReturn.Columns[1].HeaderText = "เลขที่ใบจอง";
                    dataReturn.Columns[2].HeaderText = "รหัสลผู้จอง";
                    dataReturn.Columns[3].HeaderText = "ชื่อผู้จอง";
                    dataReturn.Columns[4].HeaderText = "นามสกุลผู้จอง";
                    dataReturn.Columns[5].HeaderText = "รหัสล็อค";
                    dataReturn.Columns[6].HeaderText = "วันที่คืนล็อค";
                    dataReturn.Columns[7].HeaderText = "วันสุดท้ายที่จอง";
                    dataReturn.Columns[8].HeaderText = "สถานะการคืน";


                    dataReturn.Columns[0].Width = 80;
                    dataReturn.Columns[1].Width = 80;
                    dataReturn.Columns[2].Width = 80;
                    dataReturn.Columns[3].Width = 100;
                    dataReturn.Columns[4].Width = 100;
                    dataReturn.Columns[5].Width = 80;
                    dataReturn.Columns[6].Width = 100;
                    dataReturn.Columns[7].Width = 100;
                    dataReturn.Columns[8].Width = 100;
                }
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            BookingNumber.Text = "";
            ShowCusID.Text = "";
            ShowCusName.Text = "";
            ShowLastName.Text = "";
            ShowBookingType.Text = "";
            ShowFirstDate.Text = "";
            ShowLastDate.Text = "";
            ShowBookingPeriot.Text = "";
            ShowLockID.Text = "";
            ShowLockType.Text = "";
            ShowLockSize.Text = "";
            ClaerCal();


        }
    }
}

