using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ระบบจองล็อคตลาด
{
    public partial class BookingData : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        public BookingData()
        {
            InitializeComponent();
            ShowBookID.Focus();
        }

        private void BookingData_Load(object sender, EventArgs e)
        {
            ShowBookID.Focus();
        }

        private void ShowBookID_KeyDown(object sender, KeyEventArgs e)
        {
            if (ShowBookID.Text.Trim() == "")
            {
                ClearAll_Click();
            }
            else
            {
                if (e.KeyCode == Keys.Enter) //เมื่อพิมพ์แค่รหัส ข้อมูลที่เหลือก็แสดง
                {
                    var cs = (from b in DB.Booking_market 
                              join c in DB.Customer_market on b.CustomerID equals c.CustomerID
                              join l in DB.Marketlocks on c.CustomerLog_ID equals l.Marketlock_ID
                              join p in DB.Category_product on b.Typesofproductssold equals p.CategoryID
                              select new { 
                        BookID =  b.BookingNumber,
                        CusID =  c.CustomerID,
                        CusName = c.CustomerName,
                        CusLname =  c.CustomerLastname,
                        CusPhone = c.CustomerPhone,
                        CusEmail = c.CustomerEmail,
                        LockID = c.CustomerLog_ID,
                        Locksize = l.Marketlock_Size,
                        LockZone = l.MarketZonename,
                        Bookdetail = b.BookingDetails,
                        Shopn = b.ShopName,
                        CatName = p.CategoryName,
                        ProductNum = b.Numberofproducts,
                        StartDate = b.Dateofreservation,
                        EndDate = b.Bookingenddate,
                        returnID = b.LockReturnID
                    
                    }).Where(w => w.BookID == ShowBookID.Text);

                    if(cs.Count() > 0)
                    {
                        ShowBookID.Text = cs.FirstOrDefault().BookID.Trim();
                        ShowCusID.Text = cs.FirstOrDefault().CusID.ToString();
                        ShowCusName.Text = cs.FirstOrDefault().CusName.Trim();
                        ShowCusLname.Text = cs.FirstOrDefault().CusLname.Trim();
                        ShowCusTel.Text = cs.FirstOrDefault().CusPhone.Trim();
                        ShowCusEmail.Text = cs.FirstOrDefault().CusEmail.Trim();
                        ShowLockID.Text = cs.FirstOrDefault().LockID.Trim();
                        ShowLockZone.Text = cs.FirstOrDefault().LockZone.Trim();
                        ShowLockSize.Text = cs.FirstOrDefault().Locksize.Trim();
                        
                        if(cs.FirstOrDefault().Bookdetail == "Irregular")
                        {
                            ShowBookDetail.Text = "ขาจร";
                        }
                        else if (cs.FirstOrDefault().Bookdetail == "Frequenter")
                        {
                            ShowBookDetail.Text = "ขาประจำ";
                        }

                        ShowShopName.Text = cs.FirstOrDefault().Shopn.Trim();
                        ShowProductType.Text = cs.FirstOrDefault().CatName.Trim();
                        ShowProductNum.Text = cs.FirstOrDefault().ProductNum.Trim();
                        ShowStartdate.Text = cs.FirstOrDefault().StartDate.ToString();
                        ShowEndDate.Text = cs.FirstOrDefault().EndDate.ToString();
                        if (cs.FirstOrDefault().returnID == null)
                        {
                            ShowBookingStatus.Text = "ยังจองอยู่";
                            ShowBookingStatus.ForeColor = Color.Green;
                        }
                        else if (cs.FirstOrDefault().returnID != null)
                        {
                            ShowBookingStatus.Text = "ยกเลิกการจองแล้ว";
                            ShowBookingStatus.ForeColor = Color.DarkRed;
                        }
                        
                    }
                }
            }
        }

        private void ClearAll_Click()
        {
            ShowBookID.Text = "";
            ShowCusID.Text = "";
            ShowCusName.Text = "";
            ShowCusLname.Text = "";
            ShowCusTel.Text = "";
            ShowCusEmail.Text = "";
            ShowLockID.Text = "";
            ShowLockZone.Text = "";
            ShowLockSize.Text = "";
            ShowBookDetail.Text = "";
            ShowShopName.Text = "";
            ShowProductType.Text = "";
            ShowProductNum.Text = "";
            ShowStartdate.Text = "";
            ShowEndDate.Text = "";
            ShowBookingStatus.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking_market bm = new Booking_market();
            ReportBooking rb = new ReportBooking();
            ReportBookingData rbd = new ReportBookingData();

            
            rb.SetParameterValue("BookingID", ShowBookID.Text);

            rbd.crystalReportViewer1.ReportSource = rb;
            rbd.ShowDialog();
            rbd.Activate();
            //crystalReportViewer1.Refresh();
        }
        






        }
}

