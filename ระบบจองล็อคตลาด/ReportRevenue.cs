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

namespace ระบบจองล็อคตลาด
{
    public partial class ReportRevenue : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();//ฐานข้อมูล
        decimal Totalrevenue, TotalBooking, TotalUtility, TotalFind, TotalChaJorn, TotalChaprajum, TotalBook_jorn, TotalUtility_jorn, TotalFine_jorn, TotalBook_jam, TotalUtility_jam, TotalFine_jam;
        int selctedValue; //เก็บค่าตัวเลขที่เป็ฯเดือน
        public ReportRevenue()
        {
            InitializeComponent();
            MonthSelect.Items.Add(new { Text = "ทั้งหมด", Value = 0 });
            MonthSelect.Items.Add(new { Text = "มกราคม", Value = 1 });
            MonthSelect.Items.Add(new { Text = "กุมภาพันธ์", Value = 2 });
            MonthSelect.Items.Add(new { Text = "มีนาคม", Value = 3 });
            MonthSelect.Items.Add(new { Text = "เมษายน", Value = 4 });
            MonthSelect.Items.Add(new { Text = "พฤษภาคม", Value = 5 });
            MonthSelect.Items.Add(new { Text = "มิถุนายน", Value = 6 });
            MonthSelect.Items.Add(new { Text = "กรกฎาคม", Value = 7 });
            MonthSelect.Items.Add(new { Text = "สิงหาคม", Value = 8 });
            MonthSelect.Items.Add(new { Text = "กันยายน", Value = 9 });
            MonthSelect.Items.Add(new { Text = "ตุลาคม", Value = 10 });
            MonthSelect.Items.Add(new { Text = "พฤศจิกายน", Value = 11 });
            MonthSelect.Items.Add(new { Text = "ธันวาคม", Value = 12 });

            MonthSelect.DisplayMember = "Text";
            MonthSelect.ValueMember = "Value";

            MonthSelect.Text = "เลือกเดือน";
            ShowData();
            
        }

        private decimal ShowData()
        {
            MonthText.Text = "ทั้งหมด";
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        orderby b.BookingNumber
                        //where r.TransactionDate.Value.Month == selctedValue
            select new
                        {
                            RevID = r.RevenueID,
                            BookingNum = r.BookingNumber,
                            RevenueT = r.RevenueType,
                            Revenuenum = r.RevenueNum,
                            Transactiondate = r.TransactionDate,
                            BookingDetail  = b.BookingDetails

                        }).Distinct();


            if (data.Count() > 0)
            {
                dataRevenue.DataSource = data.ToList();
                if (dataRevenue.RowCount > 0)
                {
                    FromData();
                    decimal totalRevenue = data.Sum(item => item.Revenuenum) ?? 0;
                    Total.Text = totalRevenue.ToString("N2");
                   
                    return totalRevenue;
                }

            }
            return 0m;
        }

        private void FromData()
        {
            dataRevenue.Columns[0].HeaderText = "รหัสการชำระเงิน";
            dataRevenue.Columns[1].HeaderText = "เลขใบจอง";
            dataRevenue.Columns[2].HeaderText = "ประเภทรายได้";
            dataRevenue.Columns[3].HeaderText = "รายได้";
            dataRevenue.Columns[4].HeaderText = "วันที่ทำรายการ";
            dataRevenue.Columns[5].HeaderText = "รูปแบบการจอง";

            dataRevenue.Columns[0].Width = 60;
            dataRevenue.Columns[1].Width = 80;
            dataRevenue.Columns[2].Width = 100;
            dataRevenue.Columns[3].Width = 100;
            dataRevenue.Columns[4].Width = 100;
            dataRevenue.Columns[5].Width = 100;
        }

        private decimal ShowDataSelect(String selectType)
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where r.RevenueType == selectType
                        orderby b.BookingNumber
                        select new
                        {
                            RevID = r.RevenueID,
                            BookingNum = r.BookingNumber,
                            RevenueT = r.RevenueType,
                            Revenuenum = r.RevenueNum,
                            Transactiondate = r.TransactionDate,
                            BookingDetail = b.BookingDetails

                        }).Distinct();


            if (data.Count() > 0)
            {
                dataRevenue.DataSource = data.ToList();
                if (dataRevenue.RowCount > 0)
                {
                    FromData();
                    decimal totalRevenue = data.Sum(item => item.Revenuenum) ?? 0;
                    Total.Text = totalRevenue.ToString("N2");

                    return totalRevenue;
                }
            }
            return 0m;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SummaryReportPerMonth srm = new SummaryReportPerMonth();
            ReportRevenue rp = new ReportRevenue();
            
            srm.ShowDialog();
            srm.Activate();
        }

        /*private void reportPrint_Click(object sender, EventArgs e)
        {
            SummaryReportPerMonth srm = new SummaryReportPerMonth();
            ReportRevenue rp = new ReportRevenue();
            srm.crystalReportViewer1.ReportSource = rp;
            srm.ShowDialog();
            srm.Activate();
        }*/

        private decimal ShowBookingDetail(String selectBookingType)
        {
            //int selctedValue = MonthSelect.SelectedIndex + 1;

            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where b.BookingDetails == selectBookingType 
                        orderby b.BookingNumber
                        select new
                        {
                            RevID = r.RevenueID,
                            BookingNum = r.BookingNumber,
                            RevenueT = r.RevenueType,
                            Revenuenum = r.RevenueNum,
                            Transactiondate = r.TransactionDate,
                            BookingDetail = b.BookingDetails

                        }).Distinct();


            if (data.Count() > 0)
            {
                dataRevenue.DataSource = data.ToList();
                if (dataRevenue.RowCount > 0)
                {
                    FromData();
                    decimal totalRevenue = data.Sum(item => item.Revenuenum) ?? 0;
                    Total.Text = totalRevenue.ToString("N2");
                    return totalRevenue;
                }
            }
            return 0m;
        }

        private decimal ShowRevaenue2(String selectType, String selectBookingType)
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where (selectType == null || r.RevenueType == selectType) &&
                              (selectBookingType == null || b.BookingDetails == selectBookingType)
                        orderby b.BookingNumber
                        select new
                        {
                            RevID = r.RevenueID,
                            BookingNum = r.BookingNumber,
                            RevenueT = r.RevenueType,
                            Revenuenum = r.RevenueNum,
                            Transactiondate = r.TransactionDate,
                            BookingDetail = b.BookingDetails
                        }).Distinct();

            if (data.Count() > 0)
            {
                dataRevenue.DataSource = data.ToList();
                if (dataRevenue.RowCount > 0)
                {
                    FromData();
                    decimal totalRevenue = data.Sum(item => item.Revenuenum) ?? 0;
                    Total.Text = totalRevenue.ToString("N2");

                    return totalRevenue;
                }
            }
            return 0m;
        }
       
        

    private void ReportRevenue_Load(object sender, EventArgs e)
        {

        }

        private void Totalbtn_Click(object sender, EventArgs e)
        {
            Totalrevenue = ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardRevenue dr = new DashboardRevenue();
            dr.Show();
            
        }

        private void MonthSelect_SelectedIndexChanged(object sender, EventArgs e)
        {


            int selctedValue = (int)((dynamic)MonthSelect.SelectedItem).Value;

            if (selctedValue.ToString() != "") {
                MonthText.Text = MonthSelect.Text;

            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        orderby b.BookingNumber
                        where r.TransactionDate.Value.Month == selctedValue
                        select new
                        {
                            RevID = r.RevenueID,
                            BookingNum = r.BookingNumber,
                            RevenueT = r.RevenueType,
                            Revenuenum = r.RevenueNum,
                            Transactiondate = r.TransactionDate,
                            BookingDetail = b.BookingDetails
                        }).Distinct();


            if (data.Count() > 0)
            {
                dataRevenue.DataSource = data.ToList();
                if (dataRevenue.RowCount > 0)
                {
                    FromData();
                    decimal totalRevenue = data.Sum(item => item.Revenuenum) ?? 0;
                    Total.Text = totalRevenue.ToString("N2");

                    //return totalRevenue;
                }
            }
            else
            {
                    if (selctedValue == 0 || MonthSelect.Text == "ทั้งหมด") {

                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลสำหรับเดือนที่เลือก", "ข้อความแจ้งเตือน");
                    }
                
            }



                /*if (MonthSelect.Text != "")
                {
                    selctedValue = (int)((dynamic)MonthSelect.SelectedItem).Value;
                    ShowData();
                }*/
            }
            
        }

        private void Bookingbtn_Click(object sender, EventArgs e)
        {
            String selectType = "Booking";
            TotalBooking = ShowDataSelect(selectType);
            //int selctedValue = (int)((dynamic)MonthSelect.SelectedItem).Value;
            MonthSelect.Text = "ทั้งหมด";
        }

        private void Utilitybtn_Click(object sender, EventArgs e)
        {
            String selectType = "Utility Cost";
           TotalUtility = ShowDataSelect(selectType);
           MonthSelect.Text = "ทั้งหมด";
        }

        private void Finebtn_Click(object sender, EventArgs e)
        {
            String selectType = "Fine Cost";
            TotalFind = ShowDataSelect(selectType);
            MonthSelect.Text = "ทั้งหมด";
        }

        private void Chajorn_Click(object sender, EventArgs e)
        {
            String selectBookingType = "Irregular";
            TotalChaJorn = ShowBookingDetail(selectBookingType);
            MonthSelect.Text = "ทั้งหมด";
        }

        private void Chaprajam_Click(object sender, EventArgs e)
        {
            String selectBookingType = "Frequenter";
            TotalChaprajum = ShowBookingDetail(selectBookingType);
            MonthSelect.Text = "ทั้งหมด";
        }

    

       
    }
}
