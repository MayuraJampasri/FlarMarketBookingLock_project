using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ระบบจองล็อคตลาด
{
    public partial class PaymentPage : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        private byte[] imageData;
        Payment_Market p = new Payment_Market();
        public PaymentPage(String data)
        {
            InitializeComponent();
            //ShowBookingID.Text = data;
            ClearAll();
        }

        private void insertSlipbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files (*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";

            if (op.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = op.FileName;
                //แสดงชื่อไฟล์
                ShowSlipPath.Text = Path.GetFileName(selectedFileName);

                imageData = File.ReadAllBytes(op.FileName); //ตัวแปรไว้เก็บไฟล์ภาพ
                // ทำการแทรกข้อมูลลงในฐานข้อมูล
                //InsertImageDataIntoDatabase(selectedFileName, imageData);


            }
        }


        private void submitPayBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files (*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            //byte[] imageData = File.ReadAllBytes(op.SafeFileName); //เก็บไฟล์ภาพ*/

            //Payment_Market p = new Payment_Market();
            Revenue_Table r = new Revenue_Table();

            //p.PaymentID = int
            //if (ShowSlipPath.Text != "") //การแนบสลิป 
            // {
            if (ShowBookingID.Text != "") { 
            if (Booking.Checked != default || Utility.Checked != default || Fine.Checked != default)
            {


                if (Cradit.Checked)
                {
                    p.PaymentType = "Credit Card";
                }
                else if (Banking.Checked)
                {
                    p.PaymentType = "Internet Banking";
                }
                else if (wallet.Checked)
                {
                    p.PaymentType = "E-wallet";
                }
                else if (Money.Checked)
                {
                    p.PaymentType = "Money";
                }

                //การเลือกประเภทรายได้
                if (Booking.Checked)
                {
                    r.RevenueType = "Booking";
                        //var bookingPrice = DB.Booking_market.FirstOrDefault(b => b.BookingNumber == ShowBookingID.Text);  //ทำการตรวจสอบว่าเลรหัสตรงกันไหม
                        var bookingPrice = (from b in DB.Booking_market
                                            join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                                            where b.BookingNumber == ShowBookingID.Text
                                            select new
                                            {
                                                BookingID = b.BookingNumber,
                                                CustomerID = b.CustomerID,
                                                PaymentAmount = b.PaymentAmount,
                                                CustomerName = c.CustomerName,
                                                CustomerLastname = c.CustomerLastname
                                                // เพิ่มคอลัมน์อื่น ๆ ที่คุณต้องการเข้ารหัส
                                            }).FirstOrDefault();
                        if (bookingPrice != null)
                    {
                        r.BookingNumber = bookingPrice.BookingID;
                        r.RevenueNum = bookingPrice.PaymentAmount; //นำค่าจองมาเก็บในตารางจอง
                        r.CustomerID = bookingPrice.CustomerID;
                       

                    }

                }
                else if (Utility.Checked)
                {

                    r.RevenueType = "Utility Cost";
                    var bookingPrice = DB.Utility_Market.FirstOrDefault(b => b.BookingNumber == ShowBookingID.Text);  //ทำการตรวจสอบว่าเลรหัสตรงกันไหม
                    if (bookingPrice != null)
                    {
                        r.BookingNumber = bookingPrice.BookingNumber;
                        r.RevenueNum = bookingPrice.UtilityAmount; //นำค่าจองมาเก็บในตารางจอง
                        r.CustomerID = bookingPrice.CustomerID;
                        

                    }

                }
                else if (Fine.Checked)
                {

                    r.RevenueType = "Fine Cost";
                    var bookingPrice = DB.Lock_return.FirstOrDefault(b => b.BookingID == ShowBookingID.Text);  //ทำการตรวจสอบว่าเลรหัสตรงกันไหม
                    if (bookingPrice != null)
                    {
                        r.BookingNumber = bookingPrice.BookingID;
                        r.RevenueNum = bookingPrice.FineSum; //นำค่าจองมาเก็บในตารางจอง
                        r.CustomerID = bookingPrice.CustomerID;
                      

                    }
                }


                //เก็บชื่อไฟล์
                p.SlipPath = ShowSlipPath.Text;
                //เก็บไฟล์ภาพ
                p.SlipImg = imageData;

                p.BookingNumber = ShowBookingID.Text; //เก็บหมายเลขจอง

                r.TransactionDate = DateTime.Now;


                DB.Payment_Market.Add(p); //save ค่าลงตาราง Payment
                DB.Revenue_Table.Add(r); //save ค่าลงตาราง Revenue

                DB.SaveChanges();
                //เปลี่ยนสถานะเมื่อมีการชำระเงินแล้ว ในตารางการจอง



                if (r.RevenueType == "Booking") //เลือกเป็นการจอง

                {
                    var booking = DB.Booking_market.FirstOrDefault(b => b.BookingNumber == p.BookingNumber);
                    if (booking != null)
                    {
                        if (booking.Paymentstatus == "Not yet paid")
                        {
                            // ถ้ามีการจองล็อค และต้องการให้เปลี่ยนสถานะล็อคจาก "ว่าง" เป็น "จองแล้ว"

                            booking.Paymentstatus = "Completed";

                            DB.SaveChanges(); // บันทึกการเปลี่ยนแปลงลงในฐานข้อมูล
                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถเปลี่ยนแปลงข้อมูล Booking_market ได้");
                            return;
                        }
                    }
                }
                else if (r.RevenueType == "Utility Cost")
                {
                    var booking = DB.Utility_Market.FirstOrDefault(b => b.BookingNumber == p.BookingNumber);
                    if (booking != null)
                    {
                        if (booking.PaymentStatus == "ยังไม่ชำระ")
                        {
                            // ถ้ามีการจองล็อค และต้องการให้เปลี่ยนสถานะล็อคจาก "ว่าง" เป็น "จองแล้ว"

                            booking.PaymentStatus = "ชำระแล้ว";

                            DB.SaveChanges(); // บันทึกการเปลี่ยนแปลงลงในฐานข้อมูล
                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถเปลี่ยนแปลงข้อมูลได้");
                            return;
                        }
                    }
                }
                else if (r.RevenueType == "Fine Cost")
                {
                    var booking = DB.Lock_return.FirstOrDefault(b => b.BookingID == p.BookingNumber);
                    if (booking != null)
                    {
                        if (booking.FinePayStatus == "ยังไม่ได้ชำระ")
                        {

                            booking.FinePayStatus = "ชำระแล้ว";

                            DB.SaveChanges(); // บันทึกการเปลี่ยนแปลงลงในฐานข้อมูล
                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถเปลี่ยนแปลงข้อมูลได้");
                            return;
                        }
                    }
                }

                Completed com = new Completed();
                com.ShowDialog();

                if (Booking.Checked)
                {
                    var bill = (from b in DB.Revenue_Table
                                join pay in DB.Payment_Market on b.BookingNumber equals pay.BookingNumber
                                join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                                where b.BookingNumber == ShowBookingID.Text && b.RevenueType == "Booking"
                                select new
                                {
                                    b.RevenueID,
                                    b.BookingNumber,
                                    b.CustomerID,
                                    c.CustomerName,
                                    c.CustomerLastname,
                                    b.RevenueType,
                                    b.RevenueNum,
                                    pay.PaymentType
                                }).FirstOrDefault();
                    //var bill = DB.Revenue_Table.FirstOrDefault(b => b.BookingNumber == ShowBookingID.Text && b.RevenueType == "Booking");
                    if (bill != null)
                    {

                        int data0 = bill.RevenueID;
                        String data1 = bill.BookingNumber;
                        String data2 = bill.CustomerID.ToString();
                        String data3 = bill.CustomerName;
                        String data4 = bill.CustomerLastname;
                        String data5 = bill.RevenueType;
                        String data6 = bill.RevenueNum.ToString();
                        // String data7 = bill.PaymentType;


                        Receipt re = new Receipt(data0, data1, data2, data3, data4, data5, data6); //ใส่หน้าใบเสร็จ 

                        re.ShowreceiptNumber.Text = data0.ToString();
                        re.ShowBookingID.Text = data1;
                        re.ShowCusID.Text = data2;
                        re.ShowCusName.Text = data3;
                        re.ShowCusLastname.Text = data4;
                        re.ShowPaymentList.Text = data5;
                        re.ShowPayment.Text = data6;
                        re.ShowTotal.Text = data6;
                        // re.ShowTypePayment.Text = data7;
                        re.ShowDialog();

                           // this.Hide();
                        }
                }
                else if (Utility.Checked)
                {

                    var bill = (from b in DB.Revenue_Table
                                join pay in DB.Payment_Market on b.BookingNumber equals pay.BookingNumber
                                join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                                where b.BookingNumber == ShowBookingID.Text && b.RevenueType == "Utility Cost"
                                select new
                                {
                                    b.RevenueID,
                                    b.BookingNumber,
                                    b.CustomerID,
                                    c.CustomerName,
                                    c.CustomerLastname,
                                    b.RevenueType,
                                    b.RevenueNum,
                                    pay.PaymentType
                                }).FirstOrDefault();
                    if (bill != null)
                    {

                        int data0 = bill.RevenueID;
                        String data1 = bill.BookingNumber;
                        String data2 = bill.CustomerID.ToString();
                        String data3 = bill.CustomerName;
                        String data4 = bill.CustomerLastname;
                        String data5 = bill.RevenueType;
                        String data6 = bill.RevenueNum.ToString();
                        //String data7 = bill.PaymentType;

                        Receipt re = new Receipt(data0, data1, data2, data3, data4, data5, data6); //ใส่หน้าใบเสร็จ 

                        re.ShowreceiptNumber.Text = data0.ToString();
                        re.ShowBookingID.Text = data1;
                        re.ShowCusID.Text = data2;
                        re.ShowCusName.Text = data3;
                        re.ShowCusLastname.Text = data4;
                        re.ShowPaymentList.Text = data5;
                        re.ShowPayment.Text = data6;
                        re.ShowTotal.Text = data6;
                        // re.ShowTypePayment.Text = data7;
                        re.ShowDialog();

                            //this.Hide();
                        }
                }
                else if (Fine.Checked)
                {
                    var bill = (from b in DB.Revenue_Table
                                join pay in DB.Payment_Market on b.BookingNumber equals pay.BookingNumber
                                join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                                where b.BookingNumber == ShowBookingID.Text && b.RevenueType == "Fine Cost"
                                select new
                                {
                                    b.RevenueID,
                                    b.BookingNumber,
                                    b.CustomerID,
                                    c.CustomerName,
                                    c.CustomerLastname,
                                    b.RevenueType,
                                    b.RevenueNum,
                                    pay.PaymentType
                                }).FirstOrDefault();
                    if (bill != null)
                    {

                        int data0 = bill.RevenueID;
                        String data1 = bill.BookingNumber;
                        String data2 = bill.CustomerID.ToString();
                        String data3 = bill.CustomerName;
                        String data4 = bill.CustomerLastname;
                        String data5 = bill.RevenueType;
                        String data6 = bill.RevenueNum.ToString();
                        //String data7 = bill.PaymentType;

                        Receipt re = new Receipt(data0, data1, data2, data3, data4, data5, data6); //ใส่หน้าใบเสร็จ 

                        re.ShowreceiptNumber.Text = data0.ToString();
                        re.ShowBookingID.Text = data1;
                        re.ShowCusID.Text = data2;
                        re.ShowCusName.Text = data3;
                        re.ShowCusLastname.Text = data4;
                        re.ShowPaymentList.Text = data5;
                        re.ShowPayment.Text = data6;
                        re.ShowTotal.Text = data6;
                        //re.ShowTypePayment.Text = data7;
                        re.ShowDialog();

                           // this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("กรุณาใส่เลขที่ใบจองด้วยค่ะ");
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกค่าใช้จ่ายด้วยค่ะ");
                return;
            }
         }
            //MessageBox.Show("ไม่ปรากฎเลขที่ใบจอง");
            return;

        }
        private void PaymentPage_Load(object sender, EventArgs e)
        {

        }

        private void NotSubmitPaybtn_Click(object sender, EventArgs e)
        {
            ClearAll();
            this.Hide();
            incomplated In = new incomplated();
            In.ShowDialog();
            
            
        }

        private void ClearAll()
        {
            ShowBookingID.Text = "";
            Booking.Checked = false;
            Utility.Checked = false;
            Fine.Checked = false;
            Cradit.Checked = false;
            Banking.Checked = false;
            wallet.Checked = false;
            Money.Checked = false;
            ShowSlipPath.Text = "";
        }
       /* private void PaymentType()
        {
            if (Cradit.Checked)
            {
                p.PaymentType = "Credit Card";
            }
            else if (Banking.Checked)
            {
                p.PaymentType = "Internet Banking";
            }
            else if (wallet.Checked)
            {
                p.PaymentType = "E-wallet";
            }
            else if (Money.Checked)
            {
                p.PaymentType = "Money";
            }
        }*/
    }

    
}
