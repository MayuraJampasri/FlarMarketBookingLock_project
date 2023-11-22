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
    public partial class Receipt : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();//ฐานข้อมูล
        public Receipt(int data0 , String data1, String data2, String data3, String data4, String data5, String data6 )
        {
            InitializeComponent();


        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void ShowBookingID_KeyDown(object sender, KeyEventArgs e)
        {
            int BillID;

            if (ShowreceiptNumber.Text.Trim() == "")
            {
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter) //เมื่อพิมพ์แค่รหัส ข้อมูลที่เหลือก็แสดง
                {
                    if (int.TryParse(ShowreceiptNumber.Text, out BillID))
                    {
                        var bill = (from b in DB.Revenue_Table
                                    join p in DB.Payment_Market on b.BookingNumber equals p.BookingNumber
                                    join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                                    select new
                                    {
                                        BillID = b.RevenueID,
                                        BookID = b.BookingNumber,
                                        CusID = b.CustomerID,
                                        Cusname = c.CustomerName,
                                        CusLname = c.CustomerLastname,
                                        BillType = b.RevenueType,
                                        BillNum = b.RevenueNum,
                                        

                                    }).Where(w => w.BillID == BillID);

                        if (bill.Count() > 0)
                        {
                            ShowBookingID.Text = bill.FirstOrDefault().BookID.Trim();
                            ShowCusID.Text = bill.FirstOrDefault().CusID.ToString();
                            ShowCusName.Text = bill.FirstOrDefault().Cusname.Trim();
                            ShowCusLastname.Text = bill.FirstOrDefault().CusLname.Trim();
                            ShowPaymentList.Text = bill.FirstOrDefault().BillType.Trim();
                            ShowPayment.Text = bill.FirstOrDefault().BillNum.ToString();
                            ShowTotal.Text = bill.FirstOrDefault().BillNum.ToString();
                            
                        }
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Cuslist_Click(object sender, EventArgs e)
        {
            ComplatePayToBookingList cl = new ComplatePayToBookingList();
            cl.ShowDialog();
        }

        
    }
}
