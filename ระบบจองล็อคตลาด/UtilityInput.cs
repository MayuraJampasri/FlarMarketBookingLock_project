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
    public partial class UtilityInput : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();//ฐานข้อมูล
        Utility_Market um = new Utility_Market();
        login lg = new login();
        public UtilityInput()
        {
            InitializeComponent();
            ShowData();
            BillingDate.Text = DateTime.Now.ToString(); //เวลาจดบิลค่าน้ำไฟ

            /* WaterUnitNum.Maximum = 40;
             WaterUnitNum.Minimum = 1;

             ElecUnitNum.Maximum = 100;
             ElecUnitNum.Minimum = 1;*/

            periottxt.Text = "0";
            Feetext.Text  = "0";


           // LoginName.Text = lg.
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            int period = 30;
            if (BookingID.Text.Trim() == "")
            {
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter) //เมื่อพิมพ์แค่รหัส ข้อมูลที่เหลือก็แสดง
                {
                    var bk = (from b in DB.Booking_market
                              join l in DB.Marketlocks on b.Marketlock_ID equals l.Marketlock_ID
                              join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                              where b.Paymentstatus == "Completed"
                              select new
                              {
                                  BookID = b.BookingNumber,
                                  CusID = b.CustomerID,
                                  Cusname = c.CustomerName,
                                  CusLname = c.CustomerLastname,
                                  LockID = b.Marketlock_ID,
                                  Bookdetail = b.BookingDetails,
                                  Periot = b.ReservationPeriod,
                                  LockZone = l.MarketZonename,
                                  EndDate  = b.Bookingenddate

                              }).Where(w => w.BookID == BookingID.Text);

                    if (bk.Count() > 0)
                    {
                        BookingID.Text = bk.FirstOrDefault().BookID.Trim();
                        CusIDtxt.Text = bk.FirstOrDefault().CusID.ToString();
                        CusNametxt.Text = bk.FirstOrDefault().Cusname.Trim();
                        CusLastnametxt.Text = bk.FirstOrDefault().CusLname.Trim();
                        LockID.Text = bk.FirstOrDefault().LockID.Trim();
                        //BookingTypetxt.Text = bk.FirstOrDefault().Bookdetail.Trim();
                        ShowZone.Text = bk.FirstOrDefault().LockZone.Trim();
                        EndDatetxt.Text = bk.FirstOrDefault().EndDate.ToString();

                        if (bk.FirstOrDefault().Bookdetail == "Irregular")
                        {
                            BookingPeriodtxt.Text = bk.FirstOrDefault().Periot.ToString();
                            BookingTypetxt.Text = "ขาจร";
                            periottxt.Text = BookingPeriodtxt.Text;
                        }
                        else if (bk.FirstOrDefault().Bookdetail == "Frequenter")
                        {
                            BookingPeriodtxt.Text = period.ToString();
                            BookingTypetxt.Text = "ขาประจำ";
                            periottxt.Text = BookingPeriodtxt.Text;
                        }
                        ClearCal();

                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลจร้า", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BookingID.Text = " "; //ลบข้อมูล
                        BookingID.Focus();
                    }
                }
            }
        }

        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            decimal UtilityFeePerDay = 35;
            /*  //WaterFeetxt.Text = (int.Parse(WaterUnit.Text) *4).ToString(); // คำนวนค่าน้ำ
              WaterFeetxt.Text = ((WaterUnitNum.Value) * 8).ToString();
              //ElecFeetxt.Text = (int.Parse(ElecUnit.Text)*5).ToString(); // คำนวนค่าไฟ
              ElecFeetxt.Text = ((ElecUnitNum.Value) * 4).ToString();
              //TotalWithoutPeriod.Text = (int.Parse(WaterFeetxt.Text) + int.Parse(ElecFeetxt.Text)).ToString(); //คำนวนค่าไฟน้ำแบบยังไม่ได้รวมค่าอื่นๆ
              TotalWithoutPeriod2.Text = (int.Parse(WaterFeetxt.Text) + int.Parse(ElecFeetxt.Text)).ToString(); //คำนวนค่าไฟน้ำแบบยังไม่ได้รวมค่าอื่นๆ//
              Period2.Text = BookingPeriodtxt.Text; //ระยะเวลาจองค่าน้ำค่าไฟรวม
              TotalAmount.Text = ((int.Parse(TotalWithoutPeriod2.Text) *int.Parse(BookingPeriodtxt.Text))).ToString();
              //TotalAmount.Text = (int.Parse(TotalAmount.Text)+(double.Parse(TotalAmount.Text)*0.07)).ToString();
              //Vattxt.Text = (double.Parse(TotalAmount.Text) * 0.07).ToString("0.00"); //คำนวณภาษี */
          if (BookingPeriodtxt.Text != "") 
           { 

               if (BookingTypetxt.Text == "ขาประจำ")
               {
                    BookingTxt.Text = "ขาประจำ (Frequenter)";
                    BookingTxt.ForeColor = Color.Red;
                    periottxt.Text = BookingPeriodtxt.Text;
                    Feetext.Text = (int.Parse(periottxt.Text) * UtilityFeePerDay).ToString();
                }
               else if (BookingTypetxt.Text == "ขาจร")
               {
                    BookingTxt.Text = "ขาจร (Irregular)";
                    BookingTxt.ForeColor = Color.Blue;
                   periottxt.Text = BookingPeriodtxt.Text;
                    Feetext.Text = (int.Parse(periottxt.Text) * UtilityFeePerDay).ToString();
               }

           }
            else
            {
                MessageBox.Show("กรอกข้อมูลให้ครบถ้วน");
            }

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            decimal UtilityFeePermonth = 900;
            decimal UtilityFeePerDay = 35;
            bool SameBookingID = DB.Utility_Market.Any(b => b.BookingNumber == BookingID.Text);

            if (BookingID.Text != "" && BookingPeriodtxt.Text != "")
            {
                
                if (SameBookingID) //ไม่มีเลขล็อคที่ซ้ำกัน
                {
                    MessageBox.Show("หมายเลขจองนี้ซ้ำกับในระบบ กรุณากรอกหมายเลขจองใหม่");
                    return;
                }
                else
                {
                    //um.WaterFee = decimal.Parse(WaterFeetxt.Text); //ใช้น้ำต่อหน่วย
                    //um.ElectricityFee = decimal.Parse(ElecFeetxt.Text); //ใช้ไฟต่อหน่วย
                    // um.WaterUnit = (int)WaterUnitNum.Value; //คำนวนค่าน้ำ
                    // um.ElectricityUnit = (int)ElecUnitNum.Value; //คำนวนค่าไฟ
                    if (BookingTypetxt.Text == "ขาประจำ")
                    {
                        //um.UtilityAmount = UtilityFeePermonth; //รวมค่าน้ำค่าไฟรายเดือน 
                        um.UtilityAmount = UtilityFeePerDay * int.Parse(BookingPeriodtxt.Text);
                        um.BookingDetail = "ขาประจำ";
                    }
                    else if (BookingTypetxt.Text == "ขาจร")
                    {
                        
                        um.UtilityAmount = UtilityFeePerDay * int.Parse(BookingPeriodtxt.Text); //รวมค่าน้ำค่าไฟรายวัน
                        um.BookingDetail = "ขาจร";
                    }
                    um.Billing_Date = DateTime.Now; //วันที่บันทึก
                    um.BookingNumber = BookingID.Text; //เลขใบจอง
                    um.PaymentStatus = "ยังไม่ชำระ";
                    um.DurationUsed = int.Parse(BookingPeriodtxt.Text);
                    um.CustomerID = int.Parse(CusIDtxt.Text);
                    um.CustomerName = CusNametxt.Text;
                    um.CustomerLname = CusLastnametxt.Text;
                    um.LockID = LockID.Text;
                    um.MarketZonename = ShowZone.Text;
                    um.EndDate = DateTime.Parse(EndDatetxt.Text);

                    DB.Utility_Market.Add(um);

                    //เพิ่มในฐานข้อมูล

                    DB.SaveChanges();
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย");

                    var InputUtilityID = DB.Booking_market.FirstOrDefault(b => b.BookingNumber == um.BookingNumber);
                    if (InputUtilityID != null)
                    {
                        int UtilityID = um.UtilityID;
                        InputUtilityID.UtilityID = UtilityID; //UtilityID จาก ตาราง Utility ลงไปในตารางจอง
                        DB.SaveChanges();
                    }
                    ShowData();
                    //Clear();
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน");
                return;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            CusListWithoutRecordUtility cp = new CusListWithoutRecordUtility();
            cp.ShowDialog();
        }

        private void ShowData()
        {
            var ut = from u in DB.Utility_Market
                         //join b in DB.Booking_market on u.BookingNumber equals b.BookingNumber
                     select new
                     {
                         UtilityID = u.UtilityID,
                         BookingID = u.BookingNumber,
                         CusID = u.CustomerID,
                         Cusname = u.CustomerName,
                         UtilityTotal = u.UtilityAmount,
                         Duraton = u.DurationUsed,
                         EndDate = u.EndDate,
                         LockUD = u.LockID,
                         BookType = u.BookingDetail,
                         PayStatus = u.PaymentStatus
                     };
            if (ut.Count() > 0)
            {
                dataUtility.DataSource = ut.ToList();

                if (dataUtility.RowCount > 0)
                {
                    dataUtility.Columns[0].HeaderText = "รหัสค่าน้ำค่าไฟ";
                    dataUtility.Columns[1].HeaderText = "เลขที่ใบจอง";
                    dataUtility.Columns[2].HeaderText = "รหัสผู้จอง";
                    dataUtility.Columns[3].HeaderText = "ชื่อผู้จอง";
                    dataUtility.Columns[4].HeaderText = "รวมทั้งสิ้น";
                    dataUtility.Columns[5].HeaderText = "ระยะเวลา";
                    dataUtility.Columns[6].HeaderText = "วันสุดท้ายที่จอง";
                    dataUtility.Columns[7].HeaderText = "รหัสล็อค";
                    dataUtility.Columns[8].HeaderText = "รูปแบบการจอง";
                    dataUtility.Columns[9].HeaderText = "สถานะการชำระเงิน";
                    


                    dataUtility.Columns[0].Width = 80;
                    dataUtility.Columns[1].Width = 80;
                    dataUtility.Columns[2].Width = 100;
                    dataUtility.Columns[3].Width = 80;
                    dataUtility.Columns[4].Width = 100;
                    dataUtility.Columns[6].Width = 120;
                    dataUtility.Columns[8].Width = 120;
                    dataUtility.Columns[9].Width = 100;
                }
            }
        }


        private void dataUtility_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            BookingID.Text = dataUtility.Rows[e.RowIndex].Cells["BookingID"].Value.ToString();
            LockID.Text = dataUtility.Rows[e.RowIndex].Cells["LockUD"].Value.ToString();
            ShowZone.Text = dataUtility.Rows[e.RowIndex].Cells["ZoneName"].Value.ToString();
            CusIDtxt.Text = dataUtility.Rows[e.RowIndex].Cells["CusID"].Value.ToString();
            CusNametxt.Text = dataUtility.Rows[e.RowIndex].Cells["Cusname"].Value.ToString();
            CusLastnametxt.Text = dataUtility.Rows[e.RowIndex].Cells["CusLname"].Value.ToString();
            BookingTypetxt.Text = dataUtility.Rows[e.RowIndex].Cells["BookType"].Value.ToString();
            BookingPeriodtxt.Text = dataUtility.Rows[e.RowIndex].Cells["Duraton"].Value.ToString();

            int durationValue = (int)dataUtility.Rows[e.RowIndex].Cells["Duraton"].Value;

            if (durationValue == 30)
            {
                periottxt.Text = dataUtility.Rows[e.RowIndex].Cells["Duraton"].Value.ToString();
                Feetext.Text = dataUtility.Rows[e.RowIndex].Cells["UtilityTotal"].Value.ToString();
                // UtilityPerDayTotal.Text = "-";

            }
            else if (durationValue > 0 && durationValue < 30)
            {
                periottxt.Text = dataUtility.Rows[e.RowIndex].Cells["Duraton"].Value.ToString();
                Feetext.Text = dataUtility.Rows[e.RowIndex].Cells["UtilityTotal"].Value.ToString();
            }

        }

        private void UtilityInput_Load(object sender, EventArgs e)
        {
            //BookingID.Focus();
        }

        private void Clear()
        {
            BookingID.Text = "";
            CusIDtxt.Text = "";
            CusNametxt.Text = "";
            CusLastnametxt.Text = "";
            LockID.Text = "";
            BookingTypetxt.Text = "";
            ShowZone.Text = "";
            BookingPeriodtxt.Text = "";
            periottxt.Text = "0";
            //UtilityPerDayTotal.Text = "-";
            EndDatetxt.Text = "";
            Feetext.Text = "0";
        }
        private void ClearCal()
        {
            periottxt.Text = "-";
            //UtilityPerDayTotal.Text = "-";
            Feetext.Text = "0";
        }
        private void ClearAll_Click(object sender, EventArgs e)
        {
            BookingID.Text = "";
            CusIDtxt.Text = "";
            CusNametxt.Text = "";
            CusLastnametxt.Text = "";
            LockID.Text = "";
            BookingTypetxt.Text = "";
            ShowZone.Text = "";
            BookingPeriodtxt.Text = "";
            periottxt.Text = "0";
           // UtilityPerDayTotal.Text = "-";
            EndDatetxt.Text = "";
            Feetext.Text = "0";
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการลบรายการใช่หรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
              
                var ud = (from r in DB.Utility_Market
                          where r.BookingNumber == BookingID.Text
                          select r).FirstOrDefault();
                if (ud != null)
                {
                    if (ud.PaymentStatus != "ชำระแล้ว") { 
                    ud.BookingNumber = null; //ตัดการเชื่อมต่อกับ ตารางการจอง
                    DB.Utility_Market.Remove(ud);
                    DB.SaveChanges();

                    MessageBox.Show("ทำการลบรายการเรียบร้อย", "ผลการทำงาน");
                    ShowData();

                    var bk = (from b in DB.Booking_market
                              where b.BookingNumber == BookingID.Text
                              select b).FirstOrDefault();
                    if (bk != null)
                    {
                        bk.UtilityID = null;  //ตัดการเชื่อมต่อกับ ตารางน้ำไฟ
                        DB.SaveChanges();
                    }
                  }
                    else
                    {
                        MessageBox.Show("ไม่สามารถทำการลบรายการได้ เนื่องจากรายการถูกชำระเรียบร้อยแล้ว");
                        return;
                    }
                }
                
                
                /*var bk = (from b in DB.Booking_market
                          where b.BookingNumber == BookingID.Text
                          select b).FirstOrDefault();
                if (bk != null)
                {
                    bk.UtilityID = null;  //ตัดการเชื่อมต่อกับ ตารางน้ำไฟ
                    DB.SaveChanges();
                }*/
                
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการลบรายการใช่หรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                var ud = (from r in DB.Utility_Market
                          where r.BookingNumber == BookingID.Text
                          select r).FirstOrDefault();
                if (ud != null)
                {
                    if (ud.PaymentStatus != "ชำระแล้ว")
                    {
                        ud.BookingNumber = null; //ตัดการเชื่อมต่อกับ ตารางการจอง
                        DB.Utility_Market.Remove(ud);
                        DB.SaveChanges();

                        MessageBox.Show("ทำการลบรายการเรียบร้อย", "ผลการทำงาน");
                        ShowData();

                        var bk = (from b in DB.Booking_market
                                  where b.BookingNumber == BookingID.Text
                                  select b).FirstOrDefault();
                        if (bk != null)
                        {
                            bk.UtilityID = null;  //ตัดการเชื่อมต่อกับ ตารางน้ำไฟ
                            DB.SaveChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถทำการลบรายการได้ เนื่องจากรายการถูกชำระเรียบร้อยแล้ว");
                        return;
                    }
                }
            }
            }

        private void dataUtility_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataUtility.Columns["PayStatus"].Index && e.Value != null)
            {
                string payStatus = e.Value.ToString();
                if (payStatus == "ชำระแล้ว")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (payStatus == "ยังไม่ชำระ")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }
    }
}
    

