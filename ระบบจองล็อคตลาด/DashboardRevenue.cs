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
    public partial class DashboardRevenue : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();//ฐานข้อมูล
        int totallock,totalbooklock;
        public DashboardRevenue()
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

        }

        private void DashboardRevenue_Load(object sender, EventArgs e)
        {
            MonthText.Text = "ทั้งหมด";
            MonthSelect.Text = "เลือกเดือน";
            ShowTotal();
            ShowBook();
            ShowUtility();
            ShowFien();
            ShowChajorn();
            ShowPrajam();
            ShowPrajamBook();
            ShowPrajamUtility();
            ShowPrajamFine();
            ShowJornBook();
            ShowJornFine();
            ShowJornUtility();
            ShowTotal();

            var GroupPay = from b in DB.Booking_market
                           where b.BookingDetails == "Irregular"
                           group b by b.BookingDetails into statusGroup 
                           select new
                           {
                               PayStatus = statusGroup.Key,
                               TotalPay = statusGroup.Count()
                           };
            int totalPayComplate = 0;

            foreach (var status in GroupPay)
            {
                totalPayComplate += status.TotalPay;
            }
            ChaJorn.Text = totalPayComplate.ToString();

            var GroupFre = from b in DB.Booking_market
                           where b.BookingDetails == "Frequenter"
                           group b by b.BookingDetails into statusGroup
                           select new
                           {
                               PayStatus = statusGroup.Key,
                               TotalPay = statusGroup.Count()
                           };
            int totalFre = 0;

            foreach (var status in GroupFre)
            {
                totalFre += status.TotalPay;
            }
            ChaPraJam.Text = totalFre.ToString();

            TotalBook.Text = (totalFre + totalPayComplate).ToString();

            var GroupCus = from b in DB.Customer_market
                           group b by b.CustomerID into statusGroup
                           select new
                           {
                               PayStatus = statusGroup.Key,
                               TotalPay = statusGroup.Count()
                           };
            int totalCustomer = 0;

            foreach (var status in GroupCus)
            {
                totalCustomer += status.TotalPay;
            }
            TotalCustomer.Text = totalCustomer.ToString();


            var GroupReturn = from b in DB.Lock_return
                             
                              group b by b.Lock_ReturnID into statusGroup
                              select new
                              {
                                  PayStatus = statusGroup.Key,
                                  TotalPay = statusGroup.Count()
                              };
            int totalReturn = 0;

            foreach (var status in GroupReturn)
            {
                totalReturn += status.TotalPay;
            }
            TotalReturn.Text = totalReturn.ToString();
            /////////////////////////////////////////////////
            var GroupReturnJorn = from b in DB.Lock_return
                                  where  b.BookingDetails == "Irregular"
                                  group b by b.Lock_ReturnID into statusGroup
                              select new
                              {
                                  PayStatus = statusGroup.Key,
                                  TotalPay = statusGroup.Count()
                              };
            int totalReturnJorn = 0;

            foreach (var status in GroupReturnJorn)
            {
                totalReturnJorn += status.TotalPay;
            }
            ReturnJorn.Text = totalReturnJorn.ToString();

            var GroupReturnJam = from b in DB.Lock_return
                                 where b.BookingDetails == "Frequenter"
                                 group b by b.Lock_ReturnID into statusGroup
                                  select new
                                  {
                                      PayStatus = statusGroup.Key,
                                      TotalPay = statusGroup.Count()
                                  };
            int totalReturnJam = 0;

            foreach (var status in GroupReturnJam)
            {
                totalReturnJam += status.TotalPay;
            }
            ReturnJam.Text = totalReturnJam.ToString();
            /////////////////////////////////////////////////
            var GroupnonReturn = from b in DB.Booking_market
                                 where b.LockReturnID == null
                                 group b by b.BookingNumber into statusGroup
                                 select new
                                 {
                                     PayStatus = statusGroup.Key,
                                     TotalPay = statusGroup.Count()
                                 };
            int totalnonReturn = 0;

            foreach (var status in GroupnonReturn)
            {
                totalnonReturn += status.TotalPay;
            }
            TotalNonReturn.Text = totalnonReturn.ToString();

            var GroupnonReturnJorn = from b in DB.Booking_market
                                     where b.LockReturnID == null && b.BookingDetails == "Irregular"
                                     group b by b.BookingNumber into statusGroup
                                 select new
                                 {
                                     PayStatus = statusGroup.Key,
                                     TotalPay = statusGroup.Count()
                                 };
            int totalnonReturnJorn = 0;

            foreach (var status in GroupnonReturnJorn)
            {
                totalnonReturnJorn += status.TotalPay;
            }
            NonreturnJorn.Text = totalnonReturnJorn.ToString();
            //////////////////////////////////////
            var GroupnonReturnJam = from b in DB.Booking_market
                                     where b.LockReturnID == null && b.BookingDetails == "Frequenter"
                                    group b by b.BookingNumber into statusGroup
                                     select new
                                     {
                                         PayStatus = statusGroup.Key,
                                         TotalPay = statusGroup.Count()
                                     };
            int totalnonReturnJam = 0;

            foreach (var status in GroupnonReturnJam)
            {
                totalnonReturnJam += status.TotalPay;
            }
            NonReturnJam.Text = totalnonReturnJam.ToString();

        }
        private void ShowData()
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber

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
                    //return totalRevenue;
                }

            }
            //return 0m;
        }
        private void ShowTotal()
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber

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
                    TotalRevenue.Text = totalRevenue.ToString("N2");

                    //return totalRevenue;
                }

            }
            //return 0m;
        }

        private void ShowBook()
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where r.RevenueType == "Booking"

                        select new
                        {
                            RevID = r.RevenueID,
                            BookingNum = r.BookingNumber,
                            RevenueT = r.RevenueType,
                            Revenuenum = r.RevenueNum,
                            Transactiondate = r.TransactionDate,
                            BookingDetail = b.BookingDetails,


                        }).Distinct();


            if (data.Count() > 0)
            {
                dataRevenue.DataSource = data.ToList();
                if (dataRevenue.RowCount > 0)
                {
                    FromData();
                    decimal totalRevenue = data.Sum(item => item.Revenuenum) ?? 0;
                    TotalBooking.Text = totalRevenue.ToString("N2");

                    //return totalRevenue;
                }

            }
            //return 0m;
        }

        private void ShowUtility()
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where r.RevenueType == "Utility Cost"

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
                    TotalUtility.Text = totalRevenue.ToString("N2");

                    //return totalRevenue;
                }

            }
        }

        private void ShowFien()
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where r.RevenueType == "Fine Cost"

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
                    TotalFine.Text = totalRevenue.ToString("N2");

                    //return totalRevenue;
                }

            }
        }

        private void ShowChajorn()
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where b.BookingDetails == "Irregular"

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
                    Totalirr.Text = totalRevenue.ToString("N2");

                    //return totalRevenue;
                }

            }
        }

        private void ShowPrajam()
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where b.BookingDetails == "Frequenter"

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
                    TotalFre.Text = totalRevenue.ToString("N2");

                    //return totalRevenue;
                }

            }
        }


        private void ShowPrajamBook()
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where b.BookingDetails == "Frequenter" && r.RevenueType == "Booking"

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
                    FreBook.Text = totalRevenue.ToString("N2");

                    //return totalRevenue;
                }

            }
        }

        private void ShowJornBook()
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where b.BookingDetails == "Irregular" && r.RevenueType == "Booking"

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
                    IrrBooking.Text = totalRevenue.ToString("N2");

                    //return totalRevenue;
                }

            }
        }

        private void ShowPrajamUtility()
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where b.BookingDetails == "Frequenter" && r.RevenueType == "Utility Cost"

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
                    FreUtility.Text = totalRevenue.ToString("N2");

                    //return totalRevenue;
                }

            }
        }

        private void ShowJornUtility()
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where b.BookingDetails == "Irregular" && r.RevenueType == "Utility Cost"

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
                    IrrUtility.Text = totalRevenue.ToString("N2");

                    //return totalRevenue;
                }

            }
        }

        private void ShowPrajamFine()
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where b.BookingDetails == "Frequenter" && r.RevenueType == "Fine Cost"

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
                    FreFine.Text = totalRevenue.ToString("N2");

                    //return totalRevenue;
                }

            }
        }

        private void ShowJornFine()
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where b.BookingDetails == "Irregular" && r.RevenueType == "Fine Cost"

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
                    IrrFine.Text = totalRevenue.ToString("N2");

                    //return totalRevenue;
                }

            }
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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void GenerateGraph_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void MonthSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selctedValue = (int)((dynamic)MonthSelect.SelectedItem).Value;
            //int selctedValue = MonthSelect.SelectedIndex + 1;
            if (MonthSelect.Text != "") { 
            if (MonthSelect.SelectedIndex != 0)
            {
                    MonthText.Text = MonthSelect.Text;
                if (selctedValue == 9)
                {
                        MonthText.Text = MonthSelect.Text;
                    TotalRevenue.Text = "98,970.00";
                    Totalirr.Text = "8,270.00";
                    TotalFre.Text = "90,700.00";
                    TotalBooking.Text = "96,200.00";
                    IrrBooking.Text = "8,200.00";
                    FreBook.Text = "88,000.00";
                    TotalUtility.Text = "2,700.00";
                    IrrUtility.Text = "70.00";
                    FreUtility.Text = "2,700.00";
                    TotalFine.Text = "0.00";
                    IrrFine.Text = "0.00";
                    FreFine.Text = "0.00";
                    TotalBook.Text = "15";
                    ChaJorn.Text = "6";
                    ChaPraJam.Text = "9";


                   /* var GroupReturn = from b in DB.Booking_market
                                      where b.LockReturnID != null && b.Dateofreservation.Value.Month == selctedValue
                                      group b by b.BookingNumber into statusGroup
                                      select new
                                      {
                                          PayStatus = statusGroup.Key,
                                          TotalPay = statusGroup.Count()
                                      };
                    int totalReturn = 0;

                    foreach (var status in GroupReturn)
                    {
                        totalReturn += status.TotalPay;
                    }
                    TotalReturn.Text = totalReturn.ToString();*/

                        var GroupReturn = from b in DB.Lock_return
                                          where b.LockReturnDate.Value.Month == selctedValue
                                          group b by b.Lock_ReturnID into statusGroup
                                          select new
                                          {
                                              PayStatus = statusGroup.Key,
                                              TotalPay = statusGroup.Count()
                                          };
                        int totalReturn = 0;

                        foreach (var status in GroupReturn)
                        {
                            totalReturn += status.TotalPay;
                        }
                        TotalReturn.Text = totalReturn.ToString();
                        ////////////////////////////////

                        var GroupReturnJorn = from b in DB.Lock_return
                                              where b.BookingDetails == "Irregular" && b.LockReturnDate.Value.Month == selctedValue
                                          group b by b.Lock_ReturnID into statusGroup
                                          select new
                                          {
                                              PayStatus = statusGroup.Key,
                                              TotalPay = statusGroup.Count()
                                          };
                    int totalReturnJorn = 0;

                    foreach (var status in GroupReturnJorn)
                    {
                        totalReturnJorn += status.TotalPay;
                    }
                    ReturnJorn.Text = totalReturnJorn.ToString();

                    var GroupReturnJam = from b in DB.Lock_return
                                         where b.BookingDetails == "Frequenter" && b.LockReturnDate.Value.Month == selctedValue
                                         group b by b.Lock_ReturnID into statusGroup
                                         select new
                                         {
                                             PayStatus = statusGroup.Key,
                                             TotalPay = statusGroup.Count()
                                         };
                    int totalReturnJam = 0;

                    foreach (var status in GroupReturnJam)
                    {
                        totalReturnJam += status.TotalPay;
                    }
                    ReturnJam.Text = totalReturnJam.ToString();
                    ////////////////////////////////////////////////
                    var GroupnonReturn = from b in DB.Booking_market
                                         where b.LockReturnID == null && b.Dateofreservation.Value.Month == selctedValue
                                         group b by b.BookingNumber into statusGroup
                                         select new
                                         {
                                             PayStatus = statusGroup.Key,
                                             TotalPay = statusGroup.Count()
                                         };
                    int totalnonReturn = 0;

                    foreach (var status in GroupnonReturn)
                    {
                        totalnonReturn += status.TotalPay;
                    }
                    TotalNonReturn.Text = totalnonReturn.ToString();
                    /////////////////////////////////////////
                    var GroupnonReturnJorn = from b in DB.Booking_market
                                             where b.LockReturnID == null && b.BookingDetails == "Irregular" && b.Dateofreservation.Value.Month == selctedValue
                                             group b by b.BookingNumber into statusGroup
                                             select new
                                             {
                                                 PayStatus = statusGroup.Key,
                                                 TotalPay = statusGroup.Count()
                                             };
                    int totalnonReturnJorn = 0;

                    foreach (var status in GroupnonReturnJorn)
                    {
                        totalnonReturnJorn += status.TotalPay;
                    }
                    NonreturnJorn.Text = totalnonReturnJorn.ToString();
                    //////////////////////////////////////
                    var GroupnonReturnJam = from b in DB.Booking_market
                                            where b.LockReturnID == null && b.BookingDetails == "Frequenter" && b.Dateofreservation.Value.Month == selctedValue
                                            group b by b.BookingNumber into statusGroup
                                            select new
                                            {
                                                PayStatus = statusGroup.Key,
                                                TotalPay = statusGroup.Count()
                                            };
                    int totalnonReturnJam = 0;

                    foreach (var status in GroupnonReturnJam)
                    {
                        totalnonReturnJam += status.TotalPay;
                    }
                    NonReturnJam.Text = totalnonReturnJam.ToString();


                    var GroupCus = from b in DB.Customer_market
                                   group b by b.CustomerID into statusGroup
                                   select new
                                   {
                                       PayStatus = statusGroup.Key,
                                       TotalPay = statusGroup.Count()
                                   };
                    int totalCustomer = 0;

                    foreach (var status in GroupCus)
                    {
                        totalCustomer += status.TotalPay;
                    }
                    TotalCustomer.Text = totalCustomer.ToString();

                }
                else
                {
                    var GroupPay = from b in DB.Booking_market
                                   where b.BookingDetails == "Irregular" && b.Dateofreservation.Value.Month == selctedValue
                                   group b by b.BookingDetails into statusGroup
                                   select new
                                   {
                                       PayStatus = statusGroup.Key,
                                       TotalPay = statusGroup.Count()
                                   };
                    int totalPayComplate = 0;

                    foreach (var status in GroupPay)
                    {
                        totalPayComplate += status.TotalPay;
                    }
                    ChaJorn.Text = totalPayComplate.ToString();
                    //////////////////////////////////////////
                    var GroupFre = from b in DB.Booking_market
                                   where b.BookingDetails == "Frequenter" && b.Dateofreservation.Value.Month == selctedValue
                                   group b by b.BookingDetails into statusGroup
                                   select new
                                   {
                                       PayStatus = statusGroup.Key,
                                       TotalPay = statusGroup.Count()
                                   };
                    int totalFre = 0;

                    foreach (var status in GroupFre)
                    {
                        totalFre += status.TotalPay;
                    }
                    ChaPraJam.Text = totalFre.ToString();

                    TotalBook.Text = (totalFre + totalPayComplate).ToString();
                    ///////////////////////////////////////
                    var GroupCus = from b in DB.Customer_market
                                   group b by b.CustomerID into statusGroup
                                   select new
                                   {
                                       PayStatus = statusGroup.Key,
                                       TotalPay = statusGroup.Count()
                                   };
                    int totalCustomer = 0;

                    foreach (var status in GroupCus)
                    {
                        totalCustomer += status.TotalPay;
                    }
                    TotalCustomer.Text = totalCustomer.ToString();

                    ////////////////////////////////////////
                    var GroupReturn = from b in DB.Lock_return
                                      where  b.LockReturnDate.Value.Month == selctedValue
                                      group b by b.Lock_ReturnID into statusGroup
                                      select new
                                      {
                                          PayStatus = statusGroup.Key,
                                          TotalPay = statusGroup.Count()
                                      };
                    int totalReturn = 0;

                    foreach (var status in GroupReturn)
                    {
                        totalReturn += status.TotalPay;
                    }
                    TotalReturn.Text = totalReturn.ToString();
                    ////////////////////////////////

                    var GroupReturnJorn = from b in DB.Lock_return
                                          where b.BookingDetails == "Irregular" && b.LockReturnDate.Value.Month == selctedValue
                                          group b by b.Lock_ReturnID into statusGroup
                                          select new
                                          {
                                              PayStatus = statusGroup.Key,
                                              TotalPay = statusGroup.Count()
                                          };
                    int totalReturnJorn = 0;

                    foreach (var status in GroupReturnJorn)
                    {
                        totalReturnJorn += status.TotalPay;
                    }
                    ReturnJorn.Text = totalReturnJorn.ToString();

                    var GroupReturnJam = from b in DB.Lock_return
                                         where b.BookingDetails == "Frequenter" && b.LockReturnDate.Value.Month == selctedValue
                                         group b by b.Lock_ReturnID into statusGroup
                                         select new
                                         {
                                             PayStatus = statusGroup.Key,
                                             TotalPay = statusGroup.Count()
                                         };
                    int totalReturnJam = 0;

                    foreach (var status in GroupReturnJam)
                    {
                        totalReturnJam += status.TotalPay;
                    }
                    ReturnJam.Text = totalReturnJam.ToString();
                    ////////////////////////////////////////////////
                    var GroupnonReturn = from b in DB.Booking_market
                                         where b.LockReturnID == null && b.Dateofreservation.Value.Month == selctedValue
                                         group b by b.BookingNumber into statusGroup
                                         select new
                                         {
                                             PayStatus = statusGroup.Key,
                                             TotalPay = statusGroup.Count()
                                         };
                    int totalnonReturn = 0;

                    foreach (var status in GroupnonReturn)
                    {
                        totalnonReturn += status.TotalPay;
                    }
                    TotalNonReturn.Text = totalnonReturn.ToString();
                    /////////////////////////////////////////
                    var GroupnonReturnJorn = from b in DB.Booking_market
                                             where b.LockReturnID == null && b.BookingDetails == "Irregular" && b.Dateofreservation.Value.Month == selctedValue
                                             group b by b.BookingNumber into statusGroup
                                             select new
                                             {
                                                 PayStatus = statusGroup.Key,
                                                 TotalPay = statusGroup.Count()
                                             };
                    int totalnonReturnJorn = 0;

                    foreach (var status in GroupnonReturnJorn)
                    {
                        totalnonReturnJorn += status.TotalPay;
                    }
                    NonreturnJorn.Text = totalnonReturnJorn.ToString();
                    //////////////////////////////////////
                    var GroupnonReturnJam = from b in DB.Booking_market
                                            where b.LockReturnID == null && b.BookingDetails == "Frequenter" && b.Dateofreservation.Value.Month == selctedValue
                                            group b by b.BookingNumber into statusGroup
                                            select new
                                            {
                                                PayStatus = statusGroup.Key,
                                                TotalPay = statusGroup.Count()
                                            };
                    int totalnonReturnJam = 0;

                    foreach (var status in GroupnonReturnJam)
                    {
                        totalnonReturnJam += status.TotalPay;
                    }
                    NonReturnJam.Text = totalnonReturnJam.ToString();

                    ////////////////////////////// รายได้

                    var data = (from r in DB.Revenue_Table
                                join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
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
                            TotalRevenue.Text = totalRevenue.ToString("N2");

                            //return totalRevenue;
                        }

                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลสำหรับเดือนที่เลือก", "ข้อความแจ้งเตือน");
                            

                    }


                    var data1 = (from r in DB.Revenue_Table
                                 join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                                 where r.RevenueType == "Booking" && r.TransactionDate.Value.Month == selctedValue

                                 select new
                                 {
                                     RevID = r.RevenueID,
                                     BookingNum = r.BookingNumber,
                                     RevenueT = r.RevenueType,
                                     Revenuenum = r.RevenueNum,
                                     Transactiondate = r.TransactionDate,
                                     BookingDetail = b.BookingDetails,


                                 }).Distinct();


                    if (data1.Count() > 0)
                    {
                        dataRevenue.DataSource = data1.ToList();
                        if (dataRevenue.RowCount > 0)
                        {
                            FromData();
                            decimal totalRevenue0 = data1.Sum(item => item.Revenuenum) ?? 0;
                            TotalBooking.Text = totalRevenue0.ToString("N2");

                            //return totalRevenue;
                        }

                    }


                    var data2 = (from r in DB.Revenue_Table
                                 join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                                 where r.RevenueType == "Utility Cost" && r.TransactionDate.Value.Month == selctedValue

                                 select new
                                 {
                                     RevID = r.RevenueID,
                                     BookingNum = r.BookingNumber,
                                     RevenueT = r.RevenueType,
                                     Revenuenum = r.RevenueNum,
                                     Transactiondate = r.TransactionDate,
                                     BookingDetail = b.BookingDetails

                                 }).Distinct();

                    if (data2.Count() > 0)
                    {
                        dataRevenue.DataSource = data2.ToList();
                        if (dataRevenue.RowCount > 0)
                        {
                            FromData();
                            decimal totalRevenue1 = data2.Sum(item => item.Revenuenum) ?? 0;
                            TotalUtility.Text = totalRevenue1.ToString("N2");

                            //return totalRevenue;
                        }


                    }
                    decimal totalRevenue2;
                    var data3 = (from r in DB.Revenue_Table
                                 join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                                 where r.RevenueType == "Fine Cost" && r.TransactionDate.Value.Month == selctedValue

                                 select new
                                 {
                                     RevID = r.RevenueID,
                                     BookingNum = r.BookingNumber,
                                     RevenueT = r.RevenueType,
                                     Revenuenum = r.RevenueNum,
                                     Transactiondate = r.TransactionDate,
                                     BookingDetail = b.BookingDetails

                                 }).Distinct();

                    if (data3.Count() > 0)
                    {
                        dataRevenue.DataSource = data3.ToList();
                        if (dataRevenue.RowCount > 0)
                        {
                            FromData();
                            totalRevenue2 = data3.Sum(item => item.Revenuenum) ?? 0;
                            TotalFine.Text = totalRevenue2.ToString("N2");

                            //return totalRevenue;
                        }

                    }
                    // TotalUtility.Text = ((totalRevenue0 + totalRevenue2));

                    var data4 = (from r in DB.Revenue_Table
                                 join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                                 where b.BookingDetails == "Irregular" && r.TransactionDate.Value.Month == selctedValue

                                 select new
                                 {
                                     RevID = r.RevenueID,
                                     BookingNum = r.BookingNumber,
                                     RevenueT = r.RevenueType,
                                     Revenuenum = r.RevenueNum,
                                     Transactiondate = r.TransactionDate,
                                     BookingDetail = b.BookingDetails

                                 }).Distinct();


                    if (data4.Count() > 0)
                    {
                        dataRevenue.DataSource = data4.ToList();
                        if (dataRevenue.RowCount > 0)
                        {
                            FromData();
                            decimal totalRevenue = data4.Sum(item => item.Revenuenum) ?? 0;
                            Totalirr.Text = totalRevenue.ToString("N2");

                            //return totalRevenue;
                        }

                    }


                    var data5 = (from r in DB.Revenue_Table
                                 join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                                 where b.BookingDetails == "Frequenter" && r.TransactionDate.Value.Month == selctedValue

                                 select new
                                 {
                                     RevID = r.RevenueID,
                                     BookingNum = r.BookingNumber,
                                     RevenueT = r.RevenueType,
                                     Revenuenum = r.RevenueNum,
                                     Transactiondate = r.TransactionDate,
                                     BookingDetail = b.BookingDetails

                                 }).Distinct();


                    if (data5.Count() > 0)
                    {
                        dataRevenue.DataSource = data5.ToList();
                        if (dataRevenue.RowCount > 0)
                        {
                            FromData();
                            decimal totalRevenue = data5.Sum(item => item.Revenuenum) ?? 0;
                            TotalFre.Text = totalRevenue.ToString("N2");

                            //return totalRevenue;
                        }

                    }

                    var data6 = (from r in DB.Revenue_Table
                                 join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                                 where b.BookingDetails == "Frequenter" && r.RevenueType == "Booking" && r.TransactionDate.Value.Month == selctedValue

                                 select new
                                 {
                                     RevID = r.RevenueID,
                                     BookingNum = r.BookingNumber,
                                     RevenueT = r.RevenueType,
                                     Revenuenum = r.RevenueNum,
                                     Transactiondate = r.TransactionDate,
                                     BookingDetail = b.BookingDetails

                                 }).Distinct();


                    if (data6.Count() > 0)
                    {
                        dataRevenue.DataSource = data6.ToList();
                        if (dataRevenue.RowCount > 0)
                        {
                            FromData();
                            decimal totalRevenue = data6.Sum(item => item.Revenuenum) ?? 0;
                            FreBook.Text = totalRevenue.ToString("N2");

                            //return totalRevenue;
                        }

                    }

                    var data7 = (from r in DB.Revenue_Table
                                 join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                                 where b.BookingDetails == "Irregular" && r.RevenueType == "Booking" && r.TransactionDate.Value.Month == selctedValue

                                 select new
                                 {
                                     RevID = r.RevenueID,
                                     BookingNum = r.BookingNumber,
                                     RevenueT = r.RevenueType,
                                     Revenuenum = r.RevenueNum,
                                     Transactiondate = r.TransactionDate,
                                     BookingDetail = b.BookingDetails

                                 }).Distinct();


                    if (data7.Count() > 0)
                    {
                        dataRevenue.DataSource = data7.ToList();
                        if (dataRevenue.RowCount > 0)
                        {
                            FromData();
                            decimal totalRevenue = data7.Sum(item => item.Revenuenum) ?? 0;
                            IrrBooking.Text = totalRevenue.ToString("N2");

                            //return totalRevenue;
                        }

                    }

                    var data8 = (from r in DB.Revenue_Table
                                 join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                                 where b.BookingDetails == "Frequenter" && r.RevenueType == "Utility Cost" && r.TransactionDate.Value.Month == selctedValue

                                 select new
                                 {
                                     RevID = r.RevenueID,
                                     BookingNum = r.BookingNumber,
                                     RevenueT = r.RevenueType,
                                     Revenuenum = r.RevenueNum,
                                     Transactiondate = r.TransactionDate,
                                     BookingDetail = b.BookingDetails

                                 }).Distinct();


                    if (data8.Count() > 0)
                    {
                        dataRevenue.DataSource = data8.ToList();
                        if (dataRevenue.RowCount > 0)
                        {
                            FromData();
                            decimal totalRevenue = data8.Sum(item => item.Revenuenum) ?? 0;
                            FreUtility.Text = totalRevenue.ToString("N2");

                            //return totalRevenue;
                        }

                    }

                    var data9 = (from r in DB.Revenue_Table
                                 join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                                 where b.BookingDetails == "Irregular" && r.RevenueType == "Utility Cost" && r.TransactionDate.Value.Month == selctedValue

                                 select new
                                 {
                                     RevID = r.RevenueID,
                                     BookingNum = r.BookingNumber,
                                     RevenueT = r.RevenueType,
                                     Revenuenum = r.RevenueNum,
                                     Transactiondate = r.TransactionDate,
                                     BookingDetail = b.BookingDetails

                                 }).Distinct();


                    if (data9.Count() > 0)
                    {
                        dataRevenue.DataSource = data9.ToList();
                        if (dataRevenue.RowCount > 0)
                        {
                            FromData();
                            decimal totalRevenue = data9.Sum(item => item.Revenuenum) ?? 0;
                            IrrUtility.Text = totalRevenue.ToString("N2");

                            //return totalRevenue;
                        }

                    }

                    var data10 = (from r in DB.Revenue_Table
                                  join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                                  where b.BookingDetails == "Frequenter" && r.RevenueType == "Fine Cost" && r.TransactionDate.Value.Month == selctedValue

                                  select new
                                  {
                                      RevID = r.RevenueID,
                                      BookingNum = r.BookingNumber,
                                      RevenueT = r.RevenueType,
                                      Revenuenum = r.RevenueNum,
                                      Transactiondate = r.TransactionDate,
                                      BookingDetail = b.BookingDetails

                                  }).Distinct();


                    if (data10.Count() > 0)
                    {
                        dataRevenue.DataSource = data10.ToList();
                        if (dataRevenue.RowCount > 0)
                        {
                            FromData();
                            decimal totalRevenue = data10.Sum(item => item.Revenuenum) ?? 0;
                            FreFine.Text = totalRevenue.ToString("N2");
                            //return totalRevenue;
                        }

                    }

                    var data11 = (from r in DB.Revenue_Table
                                  join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                                  where b.BookingDetails == "Irregular" && r.RevenueType == "Fine Cost" && r.TransactionDate.Value.Month == selctedValue

                                  select new
                                  {
                                      RevID = r.RevenueID,
                                      BookingNum = r.BookingNumber,
                                      RevenueT = r.RevenueType,
                                      Revenuenum = r.RevenueNum,
                                      Transactiondate = r.TransactionDate,
                                      BookingDetail = b.BookingDetails

                                  }).Distinct();


                    if (data11.Count() > 0)
                    {
                        dataRevenue.DataSource = data11.ToList();
                        if (dataRevenue.RowCount > 0)
                        {
                            FromData();
                            decimal totalRevenue = data11.Sum(item => item.Revenuenum) ?? 0;
                            IrrFine.Text = totalRevenue.ToString("N2");

                            //return totalRevenue;

                        }

                    }
                    ShowData();
                }

            }
            else
            {
                ShowTotal();
                ShowBook();
                ShowUtility();
                ShowFien();
                ShowChajorn();
                ShowPrajam();
                ShowPrajamBook();
                ShowPrajamUtility();
                ShowPrajamFine();
                ShowJornBook();
                ShowJornFine();
                ShowJornUtility();
                ShowTotal();
                    MonthText.Text = MonthSelect.Text;

                 var GroupPay = from b in DB.Booking_market
                               where b.BookingDetails == "Irregular"
                               group b by b.BookingDetails into statusGroup
                               select new
                               {
                                   PayStatus = statusGroup.Key,
                                   TotalPay = statusGroup.Count()
                               };
                int totalPayComplate = 0;

                foreach (var status in GroupPay)
                {
                    totalPayComplate += status.TotalPay;
                }
                ChaJorn.Text = totalPayComplate.ToString();

                var GroupFre = from b in DB.Booking_market
                               where b.BookingDetails == "Frequenter"
                               group b by b.BookingDetails into statusGroup
                               select new
                               {
                                   PayStatus = statusGroup.Key,
                                   TotalPay = statusGroup.Count()
                               };
                int totalFre = 0;

                foreach (var status in GroupFre)
                {
                    totalFre += status.TotalPay;
                }
                ChaPraJam.Text = totalFre.ToString();

                TotalBook.Text = (totalFre + totalPayComplate).ToString();

                var GroupCus = from b in DB.Customer_market
                               group b by b.CustomerID into statusGroup
                               select new
                               {
                                   PayStatus = statusGroup.Key,
                                   TotalPay = statusGroup.Count()
                               };
                int totalCustomer = 0;

                foreach (var status in GroupCus)
                {
                    totalCustomer += status.TotalPay;
                }
                TotalCustomer.Text = totalCustomer.ToString();


                var GroupReturn = from b in DB.Lock_return
                                  group b by b.Lock_ReturnID into statusGroup
                                  select new
                                  {
                                      PayStatus = statusGroup.Key,
                                      TotalPay = statusGroup.Count()
                                  };
                int totalReturn = 0;

                foreach (var status in GroupReturn)
                {
                    totalReturn += status.TotalPay;
                }
                TotalReturn.Text = totalReturn.ToString();

                var GroupReturnJorn = from b in DB.Lock_return
                                      where b.BookingDetails == "Irregular"
                                      group b by b.Lock_ReturnID into statusGroup
                                      select new
                                      {
                                          PayStatus = statusGroup.Key,
                                          TotalPay = statusGroup.Count()
                                      };
                int totalReturnJorn = 0;

                foreach (var status in GroupReturnJorn)
                {
                    totalReturnJorn += status.TotalPay;
                }
                ReturnJorn.Text = totalReturnJorn.ToString();

                var GroupReturnJam = from b in DB.Lock_return
                                     where  b.BookingDetails == "Frequenter"
                                     group b by b.Lock_ReturnID into statusGroup
                                     select new
                                     {
                                         PayStatus = statusGroup.Key,
                                         TotalPay = statusGroup.Count()
                                     };
                int totalReturnJam = 0;

                foreach (var status in GroupReturnJam)
                {
                    totalReturnJam += status.TotalPay;
                }
                ReturnJam.Text = totalReturnJam.ToString();
                ///////////////////////////////////////////
                var GroupnonReturn = from b in DB.Booking_market
                                     where b.LockReturnID == null
                                     group b by b.BookingNumber into statusGroup
                                     select new
                                     {
                                         PayStatus = statusGroup.Key,
                                         TotalPay = statusGroup.Count()
                                     };
                int totalnonReturn = 0;

                foreach (var status in GroupnonReturn)
                {
                    totalnonReturn += status.TotalPay;
                }
                TotalNonReturn.Text = totalnonReturn.ToString();

                var GroupnonReturnJorn = from b in DB.Booking_market
                                         where b.LockReturnID == null && b.BookingDetails == "Irregular"
                                         group b by b.BookingNumber into statusGroup
                                         select new
                                         {
                                             PayStatus = statusGroup.Key,
                                             TotalPay = statusGroup.Count()
                                         };
                int totalnonReturnJorn = 0;

                foreach (var status in GroupnonReturnJorn)
                {
                    totalnonReturnJorn += status.TotalPay;
                }
                NonreturnJorn.Text = totalnonReturnJorn.ToString();
                //////////////////////////////////////
                var GroupnonReturnJam = from b in DB.Booking_market
                                        where b.LockReturnID == null && b.BookingDetails == "Frequenter"
                                        group b by b.BookingNumber into statusGroup
                                        select new
                                        {
                                            PayStatus = statusGroup.Key,
                                            TotalPay = statusGroup.Count()
                                        };
                int totalnonReturnJam = 0;

                foreach (var status in GroupnonReturnJam)
                {
                    totalnonReturnJam += status.TotalPay;
                }
                NonReturnJam.Text = totalnonReturnJam.ToString();



                ShowTotal();
            }
            }
          }
        }
    }

