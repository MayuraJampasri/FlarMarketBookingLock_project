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
    public partial class BookingLock_ : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();//ฐานข้อมูล

        Marketlock mk = new Marketlock();
        public BookingLock_()
        {
            InitializeComponent();
            
            //กำหนดค่าสูงสุดต่ำสุดแก่ตัวที่เลือกตัวเลข
            ProductCount.Maximum = 4000;
            ProductCount.Minimum = 100; //จำนวนสินค้า

            Perday.Maximum = 3;
            Perday.Minimum = 1; //วจำนวนวันที่จองขาจร

           // Permonth.Maximum = 1;
            //Permonth.Minimum = 1;

            //แทบเลือกพนักงานจอง
            var em = from e in DB.Employee_market select new {
                EmpID = e.EmployeeID,
                EmpName = e.EmployeeName,
                EmpLname = e.EmployeeLastname
            };
            employeeName.BeginUpdate();
            employeeName.DisplayMember = "EmpName";
            employeeName.ValueMember = "EmpID";
            employeeName.DataSource = em.ToList();
            employeeName.EndUpdate();

           
            //เลือกประเภทสินค้า

            var pr = from p in DB.Category_product
                     select new
                     {
                         ProductID = p.CategoryID,
                         ProductType= p.CategoryName
                     };
            ProductCategory.BeginUpdate();
            ProductCategory.DisplayMember = "ProductType";
            ProductCategory.ValueMember = "ProductID";
            ProductCategory.DataSource = pr.ToList();
            ProductCategory.EndUpdate();

            DataTable();
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            //ไปหน้าลูกค้าที่ผ่านการอนุมัติ
            CustomerList_ cL = new CustomerList_();
            cL.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //ไปหน้าสถานะล็อค
            lockStatus_ ls = new lockStatus_();
            ls.ShowDialog();
        }

        
        private void submitBtn_Click(object sender, EventArgs e)
        {

            //ปุ่มเลือกกดจอง (ปุ่มเขียว)
            //ใส่โค้ดในนี้นะ เป็นส่วนสำคัญ
            
            Customer_market c = new Customer_market();
            Employee_market em = new Employee_market();
            Marketlock ml = new Marketlock();
            Category_product cp = new Category_product();
            Booking_market bk = new Booking_market();
            int Deposit = 1000; //ค่ามัดจำ
            DateTime Datenow = DateTime.Now; //เวลาปัจจุบัน
            //TransactionDate.Text = Datenow.ToString(); //นำเวลาปัจจุบันไปแสดงบนหน้าจอ
            bool SameBookingID = DB.Booking_market.Any(b => b.BookingNumber == BookingNum.Text); //เมื่อเลขใบจองที่กรอกตรงกับเลขในฐาน
            //bool SameCusID = DB.Booking_market.Any(b => b.CustomerID == int.Parse(txtID.Text));

            bool BookhasLetter = BookingNum.Text.Any(char.IsLetter);
            bool BookhasDigit = BookingNum.Text.Any(char.IsDigit);

            String UpperBookID;
            

            var bookSta = DB.Marketlocks.FirstOrDefault(b => b.Marketlock_ID == txtlockID.Text.Trim());
            if (bookSta != null)
            {

                if (bookSta.Marketlock_Status == "Unavailable")
                {
                    MessageBox.Show("ล็อคนี้ถูกจองแล้ว");
                    return;
                }
                else
                {
                    if (BookingNum.Text != "" && txtID.Text != "" && txtlockID.Text != "" && ProductCategory.SelectedValue != null) //กรอกข้อมูลให้ครบ
                    {
                      if (BookhasLetter && BookhasDigit) {  //ตรวจสอบว่าเลขที่ใบจองที่ใส่เข้ามา ประกอบด้วยตัวเลขและตัวอักษรไหม
                        if (SameBookingID) //ไม่มีเลขล็อคที่ซ้ำกัน
                        {
                            MessageBox.Show("หมายเลขจองนี้ซ้ำกับในระบบ กรุณากรอกหมายเลขจองใหม่");
                            return;
                        }
                        /*else if (SameCusID)
                        {
                            MessageBox.Show("รหัสผู้จองนี้ซ้ำกับในระบบ กรุณากรอกหมายเลขจองใหม่");
                            return;
                        }*/
                        else
                        {

                            if (BookingDetail.Text == "Irregular" || BookingDetail.Text == "Frequenter" || BookingDetail.Text == "ขาประจำ" || BookingDetail.Text == "ขาจร") //ตรวจสอบว่ากรอกถูก
                            {

                                    if (StartDate.Value == null || StartDate2.Value == null)
                                    {
                                        MessageBox.Show("กรุณาเลือกวันจองในปฏิทิน");
                                        return;
                                    }
                                    else
                                    {
                                        if ((int)ProductCount.Value >= 4000)
                                        {
                                            MessageBox.Show("ปริมาณเกินกว่าที่กำหนด");
                                            return;
                                        }
                                        else {

                                            if (StartDate.Value < StartDate.MinDate || StartDate2.Value < StartDate2.MinDate)
                                            {
                                                MessageBox.Show("เลือกเวลาจองนี้ไม่ได้ เนื่องจากเป็นเวลาในอดีต");
                                                return;
                                            }
                                            else
                                            {
                                                
                                                UpperBookID = BookingNum.Text.Trim();
                                                //bk.BookingNumber = BookingNum.Text.Trim(); //เดิมคือ BK
                                                bk.BookingNumber = UpperBookID.ToUpper();
                                                bk.CustomerID = int.Parse(txtID.Text.Trim());
                                                
                                                bk.Marketlock_ID = txtlockID.Text.Trim();

                                                /*if (ml.Marketlock_Status == "Free" && txtlockID.Text.Trim() == ml.Marketlock_ID)
                                                {
                                                    ml.Marketlock_Status = "Unavailable"; //เปลี่ยนสถานะล็อคจากว่างเป็นจองแล้ว
                                                    DB.SaveChanges();
                                                }*/
                                                
                                                bk.ShopName = ShopTxt.Text.Trim();
                                                bk.Typesofproductssold = ProductCategory.SelectedValue.ToString();
                                                bk.Numberofproducts = ((int)ProductCount.Value).ToString();
                                                bk.Paymentstatus = "Not yet paid";
                                                bk.EmployeeID = employeeName.SelectedValue.ToString();
                                                bk.TransactionStartDate = Datenow; //นำเวลาปัจจุบันใส่ในตาราง

                                                int day = 1;
                                                //DateTime StartDate, EndDate;
                                                if (BookingDetail.Text == "Frequenter" || BookingDetail.Text == "ขาประจำ") //ขาประจำ
                                                {

                                                    bk.BookingDetails = "Frequenter";
                                                    //tabControl1.TabPages["tabPage1"].Enabled = false; //ล็อคแท็บการเลือกขาจร
                                                    if (txtlockID.Text.Trim() == bk.Marketlock_ID)
                                                    {
                                                        bk.LockPrice = decimal.Parse(ChaPrajamPrice.Text);
                                                        DateTime d = StartDate2.Value;
                                                        //d = Convert.ToDateTime(StartDate.Value);
                                                        bk.Dateofreservation = d;
                                                        //(int)Permonth.Value
                                                        DateTime newMonth = d.AddMonths(day);
                                                        bk.ReservationPeriod = day;
                                                        bk.Bookingenddate = newMonth;
                                                        bk.PaymentAmount = bk.LockPrice * 1;
                                                        bk.PaymentAmount = bk.PaymentAmount + Deposit;
                                                        //Tataltxt.Text = bk.PaymentAmount.ToString();
                                                        // Tataltxt.Text = bk.LockPrice.ToString();

                                                    }
                                                    else MessageBox.Show("ไม่มีแถวดังกล่าว");
                                                }

                                                else if (BookingDetail.Text == "Irregular" || BookingDetail.Text == "ขาจร") //ขาจร
                                                {
                                                    bk.BookingDetails = "Irregular";
                                                    //tabControl1.TabPages["tabPage2"].Enabled = false; //ล็อคแท็บการเลือกประจำ
                                                    if (bk.Marketlock_ID == txtlockID.Text.Trim())
                                                    {
                                                        bk.LockPrice = decimal.Parse(ChajornPrice.Text);

                                                        //bk.Bookingenddate;
                                                        DateTime d = StartDate.Value;
                                                        bk.Dateofreservation = d;
                                                        DateTime newMonth = d.AddDays((int)Perday.Value);
                                                        //(int)Perday.Value;
                                                        bk.ReservationPeriod = (int)Perday.Value;

                                                        if (bk.ReservationPeriod > 3)
                                                        {
                                                            MessageBox.Show("ไม่สามารถทำการจองเกิน 3 วัน");
                                                            return;
                                                        }
                                                        bk.Bookingenddate = newMonth;
                                                        bk.PaymentAmount = bk.LockPrice * (int)Perday.Value;
                                                        // bk.Bookingenddate = StartDate2.Value.AddDays(int.Parse(DivMonth.Text));
                                                        //bk.PaymentAmount = bk.LockPrice * int.Parse(DivMonth.Text);
                                                        //Tataltxt.Text = bk.PaymentAmount.ToString();

                                                        //Tataltxt.Text = bk.LockPrice.ToString();
                                                    }
                                                    else MessageBox.Show("ไม่มีแถวดังกล่าว");
                                                    // var booking = DB.Booking_market.FirstOrDefault(b => b.Marketlock_ID == ml.Marketlock_ID);

                                                }



                                                DB.Booking_market.Add(bk);

                                                //เพิ่มในฐานข้อมูล

                                                DB.SaveChanges();
                                                //Allclear();
                                          
                                     }

                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("ไม่มีรูปแบบการจองชื่อนี้ กรุณากรอกใหม่");
                                return;
                            }

                        }


                        /*DB.Booking_market.Add(bk);

                        //เพิ่มในฐานข้อมูล

                        DB.SaveChanges();*/
                        //Allclear();
                      }
                        else
                        {
                            MessageBox.Show("กรุณาเลขที่ใบจองให้ถูกต้อง");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                        return;
                    }

                    var booking = DB.Marketlocks.FirstOrDefault(b => b.Marketlock_ID == bk.Marketlock_ID);
                    if (booking != null)
                    {
                        if (booking.Marketlock_Status == "Free")
                        {
                            // ถ้ามีการจองล็อค และต้องการให้เปลี่ยนสถานะล็อคจาก "ว่าง" เป็น "จองแล้ว"

                            booking.Marketlock_Status = "Unavailable";
                            booking.BookingNumber = bk.BookingNumber;
                            DB.SaveChanges(); // บันทึกการเปลี่ยนแปลงลงในฐานข้อมูล

                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถเปลี่ยนแปลงข้อมูล Marketlock_Status ได้");
                            return;
                        }
                    }
                    /*var BookingStatus = DB.Booking_market.FirstOrDefault(bs => bs.CustomerID == c.CustomerID);
                    if (BookingStatus != null)
                    {
                        if (BookingStatus.Bookingstatus == null)
                        {
                            BookingStatus.Bookingstatus = c.CustomerStatus;
                            DB.SaveChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถเปลี่ยนแปลงข้อมูล CustomerStatus ได้");
                    }*/

                    var CusLock = DB.Customer_market.FirstOrDefault(cl => cl.CustomerID == bk.CustomerID);
                    if (CusLock != null)
                    {
                        if (CusLock.CustomerLog_ID == null)
                        {
                            CusLock.CustomerLog_ID = bk.Marketlock_ID;
                            DB.SaveChanges();
                        }
                    }
                }
            }
            else { 
                MessageBox.Show("กรอกข้อมูลให้ครบถ้วน");
                return;
            }
            
            Allclear();
            DataTable();
            
            BookingPaper bl = new BookingPaper();
            bl.BookingNum.Text = this.BookingData.CurrentRow.Cells[0].Value.ToString();
            bl.ShowDialog();
        }
        private void DataTable()
        {
            var bk = from b in DB.Booking_market
                     orderby b.BookingNumber descending
                     select new { 
                       BookID  = b.BookingNumber,
                       BookCusID = b.CustomerID,
                       BookLockID = b.Marketlock_ID,
                       ShopName = b.ShopName,
                       StartDate = b.Dateofreservation,
                       EndDate = b.Bookingenddate,
                       Period = b.ReservationPeriod,
                       Payment = b.PaymentAmount,
                       BookingType =  b.BookingDetails,
                       NumberProduct =  b.Numberofproducts
                     };
            if(bk.Count() > 0)
            {
                BookingData.DataSource = bk.ToList();
                /*if(BookingData.RowCount > 0)
                {

                }*/
            }
        }
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            int searchID;
            //โค้ดการใส่แค่รหัส ข้อมูลในตารางก็ปรากฎ
            if (txtID.Text.Trim() == "")
            {
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter) //เมื่อพิมพ์แค่รหัส ข้อมูลที่เหลือก็แสดง
                {
                    if (int.TryParse(txtID.Text, out searchID))
                    {
                        var cs = (from c in DB.Customer_market
                                  where c.CustomerStatus == "Approve"
                                  select new

                                  {
                                      CusID = c.CustomerID,
                                      CusName = c.CustomerName,
                                      CusLname = c.CustomerLastname,
                                      CusTel = c.CustomerPhone,
                                      BookingD = c.BookingDetails
                                  }).Where(w => w.CusID == searchID);

                        if (cs.Count() > 0)
                        {
                            txtID.Text = cs.FirstOrDefault().CusID.ToString();
                            txtName.Text = cs.FirstOrDefault().CusName.Trim();
                            txtLastname.Text = cs.FirstOrDefault().CusLname.Trim();
                            txtTel.Text = cs.FirstOrDefault().CusTel.Trim();
                            if (cs.FirstOrDefault().BookingD == "Frequenter")
                            {
                                BookingDetail.Text = "ขาประจำ";
                            }
                            else if (cs.FirstOrDefault().BookingD == "Irregular")
                            {
                                BookingDetail.Text = "ขาจร";
                            }
                            //BookingDetail.Text = cs.FirstOrDefault().BookingD.Trim();
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบข้อมูลจร้า", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtID.Text = " "; //ลบข้อมูล
                            txtID.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลจร้า", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = " "; //ลบข้อมูล
                        txtID.Focus();
                    }
                }
            }
        }
    

        private void ZoneSelect_SelectedIndexChanged(object sender, EventArgs e)
        { //หาวิธีให้ ค่าในdropdown โซน ทำการฟิวเตอร์ เพื่อแสดงผลลงในตาราง
            /*String LockID = ZoneSelect.SelectedValue.ToString();
            String LockSize = ZoneSelect.SelectedValue.ToString();
            txtlockID.Text = LockID.ToString();
            txtLockSize.Text = LockSize.ToString();*/

           /* if(ZoneSelect.SelectedIndex != null)
            {
                String selectedItem = ZoneSelect.SelectedItem.ToString();

                var ml = (from m in DB.Marketlocks 
                          where m.Marketlock_ID == selectedItem.ToString()
                          select new
                {
                    LockZone = m.Marketlock_Area,
                    LockID = m.Marketlock_ID,
                    LockSize = m.Marketlock_Size,
                    LockFrequn = m.Marketlock_Pricefrequenter,
                    LockIrrec = m.Marketlock_Priceirregular
                });
            }*/

        }

        private void txtlockID_KeyDown(object sender, KeyEventArgs e)
        {
            //โค้ดการใส่แค่รหัส ข้อมูลในตารางก็ปรากฎ
            if (txtlockID.Text.Trim() == "")
            {
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter) //เมื่อพิมพ์แค่รหัส ข้อมูลที่เหลือก็แสดง
                {
                    var lc = (from l in DB.Marketlocks
                              select new
                              {
                                  LockID = l.Marketlock_ID,
                                  LockZone = l.MarketZonename,
                                  LockSize = l.Marketlock_Size,
                                  LockPIrergular = l.PriceforIrregulars,
                                  LockPFreqienter = l.PriceforFrequenters,
                                  LockStatus = l.Marketlock_Status
                              }).Where(w => w.LockID == txtlockID.Text.Trim());

                    if (lc.Count() > 0)
                    {
                        txtlockID.Text = lc.FirstOrDefault().LockID.Trim();
                        Zonetxt.Text = lc.FirstOrDefault().LockZone.Trim();
                        txtLockSize.Text = lc.FirstOrDefault().LockSize.Trim();
                        ChajornPrice.Text = lc.FirstOrDefault().LockPIrergular.ToString();
                        ChaPrajamPrice.Text = lc.FirstOrDefault().LockPFreqienter.ToString();
                        LockStatustxt.Text = lc.FirstOrDefault().LockStatus.Trim();

                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลจร้า", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = " "; //ลบข้อมูล
                        txtID.Focus();
                    }
                }
            }
        }

        private void BookingLock__Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Allclear();
        }

        private void Allclear() {
            BookingNum.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtLastname.Text = "";
            txtlockID.Text = "";
            txtLockSize.Text = "";
            ShopTxt.Text = "";
            //bk.Typesofproductssold = ProductCategory.SelectedValue.ToString();
            //ProductAmount.Text = "";
            //bk.EmployeeID = employeeName.SelectedValue.ToString();
            Zonetxt.Text = "";
            txtLockSize.Text = "";
            LockStatustxt.Text = "";
            ChajornPrice.Text = "";
            ChaPrajamPrice.Text = "";
            StartDate.Value = DateTime.Now;
            StartDate2.Value = DateTime.Now;
            Perday.Value = 1;
            //Permonth.Value = 1;
            BookingDetail.Text = "";
            txtTel.Text = "";
            ProductCount.Value = 100;
            Perday.Value = 1;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void BookingData_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void BookingData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         /*   EditBookingLock ed = new EditBookingLock();
            ed.EditShopName.Text = this.BookingData.CurrentRow.Cells["ShopName"].Value.ToString();
            ed.ProductAmount.Text = this.BookingData.CurrentRow.Cells["NumberProduct"].Value.ToString();*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Frequenter = ขาประจำ\nIrregular = ขาจร");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Restaurant = โซนร้านอาหาร \nFashion = โซนแฟชั่น \nHomeappliances = โซนของใช้ทั่วไป \nHealth and beauty products = โซนสุขภาพและความสวยงาม \nFruit shop = โซนผักและผลไม้");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            StartDate.MinDate = DateTime.Now;
            StartDate.MaxDate = DateTime.MaxValue;
        }

        private void StartDate2_ValueChanged(object sender, EventArgs e)
        {
            StartDate2.MinDate = DateTime.Now;
            StartDate2.MaxDate = DateTime.MaxValue;
        }
    }
}
