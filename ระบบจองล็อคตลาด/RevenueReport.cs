using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ระบบจองล็อคตลาด
{
    public partial class RevenueReport : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        public RevenueReport()
        {
            InitializeComponent();

           /* Dictionary<string, string> monthName = new Dictionary<int, string>();
            monthName.Add(1, "January");
            monthName.Add(2, "February");
            monthName.Add(3, "March");
            monthName.Add("Apr", "April");
            monthName.Add("May", "May");
            monthName.Add("Jun", "June");
            monthName.Add("Jul", "July");
            monthName.Add("Aug", "August");
            monthName.Add("Sep", "September");
            monthName.Add("Oct", "October");
            monthName.Add("Nov", "November");
            monthName.Add("Dec", "December");

            TransactionMonth.DisplayMember = "Value";
            TransactionMonth.ValueMember = "Key";
            TransactionMonth.DataSource = new BindingSource(monthName, null);*/

        }

        private void RevenueReport_Load(object sender, EventArgs e)
        {
            Data();
        }

        private void Data()
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
                            Bookdetail = b.BookingDetails
                        }).Distinct();

            if (data.Count() > 0)
            {
                dataRevenue.DataSource = data.ToList();
                if (dataRevenue.RowCount > 0)
                {
                    FromData();

                    decimal? totalRevenue = data.Sum(d => d.Revenuenum);
                    Total.Text = (totalRevenue ?? 0).ToString("N2");
                }
            }
            //decimal totalRevenue = data.Where(d => d.RevenueT).Sum(d => d.Revenuenum);

        }
        private void FromData()
            {
            dataRevenue.Columns[0].HeaderText = "รหัสการชำระเงิน";
            dataRevenue.Columns[1].HeaderText = "เลขใบจอง";
            dataRevenue.Columns[2].HeaderText = "รายการชำระเงิน";
            dataRevenue.Columns[3].HeaderText = "จำนวนเงิน";
            dataRevenue.Columns[4].HeaderText = "วันที่ชำระเงิน";
            dataRevenue.Columns[5].HeaderText = "รูปแบบการจอง";



            dataRevenue.Columns[0].Width = 60;
            dataRevenue.Columns[1].Width = 80;
            dataRevenue.Columns[2].Width = 100;
            dataRevenue.Columns[3].Width = 100;
            dataRevenue.Columns[4].Width = 100;
            dataRevenue.Columns[5].Width = 100;
        }

        private void SelectType(string selectedType)
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where r.RevenueType == selectedType
                        select new
                        {
                            RevID = r.RevenueID,
                            BookingNum = r.BookingNumber,
                            RevenueT = r.RevenueType,
                            Revenuenum = r.RevenueNum,
                            Transactiondate = r.TransactionDate,
                            Bookdetail = b.BookingDetails
                        }).Distinct();

            if (data.Count() > 0)
            {
                dataRevenue.DataSource = data.ToList();
                if (dataRevenue.RowCount > 0)
                {
                    FromData();

                    decimal? totalRevenue = data.Where(d => d.RevenueT == selectedType).Sum(d => d.Revenuenum);
                    Total.Text = (totalRevenue ?? 0).ToString("N2");
                }
            }
            //decimal totalRevenue = data.Where(d => d.RevenueT).Sum(d => d.Revenuenum);

        }
        /*private void UpdateDataGrid(string selectedMonth,string selectedType)
        {
            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        where //r.TransactionDate.HasValue && r.TransactionDate.Value.Month.ToString() == selectedMonth &&
                              r.RevenueType == selectedType

                        select new
                        {
                            RevID = r.RevenueID,
                            BookingNum = r.BookingNumber,
                            RevenueT = r.RevenueType,
                            Revenuenum = r.RevenueNum,
                            Transactiondate = r.TransactionDate,
                            Bookdetail = b.BookingDetails

                        }).Distinct();

            if (data.Any())
            {
                dataRevenue.DataSource = data.ToList();
                if (dataRevenue.RowCount > 0)
                {
                    FromData();

                    decimal? totalRevenue = data.Where(d => d.RevenueT == selectedType).Sum(d => d.Revenuenum);
                    Total.Text = (totalRevenue ?? 0).ToString("N2");
                }


                // คำนวณผลรวมของ Revenuenum สำหรับแต่ละประเภท
               // decimal totalRegular = data.Where(d => d.RevenueT == "ประจำ").Sum(d => d.Revenuenum);
               // decimal totalIrregular = data.Where(d => d.RevenueT == "ขาจร").Sum(d => d.Revenuenum);

                // แสดงผลลัพท์ใน Label
               // Total.Text = "ประจำ: " + totalRegular.ToString("N2");
                
            }
        }*/

        private void Totalbtn_Click(object sender, EventArgs e)
        {
            //ทั้งหมด
            Data();
        }

        private void Bookingbtn_Click(object sender, EventArgs e)
        {
            string selectedMonth = TransactionMonth.SelectedValue.ToString();
            string selectedType = "Booking";

           /* if (!string.IsNullOrEmpty(TransactionMonth.SelectedItem as string))
            {
                UpdateDataGrid(selectedMonth, selectedType);
            }
            else
            {
                SelectType(selectedType);
            }*/
            SelectType(selectedType);
        }

        private void Utilitybtn_Click(object sender, EventArgs e)
        {
            /* if (TransactionMonth.SelectedItem != null && !string.IsNullOrEmpty(TransactionMonth.SelectedItem.ToString()))
            {
                string selectedMonth = TransactionMonth.SelectedValue.ToString();
                string selectedType = "Fine Cost";
                UpdateDataGrid(selectedMonth, selectedType);
            }*/
            //if
           // {
                string selectedType = "Utility Cost";
                SelectType(selectedType);
            //}
        }

        private void Finebtn_Click(object sender, EventArgs e)
        {
           /* if (TransactionMonth.SelectedItem != null && !string.IsNullOrEmpty(TransactionMonth.SelectedItem.ToString()))
            {
                string selectedMonth = TransactionMonth.SelectedValue.ToString();
                string selectedType = "Fine Cost";
                UpdateDataGrid(selectedMonth, selectedType);
            }*/
           // if
           //{
                string selectedType = "Fine Cost";
                SelectType(selectedType);
            //}
        }

        private void TransactionMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* string selectedMonth = TransactionMonth.SelectedValue.ToString();

            var data = (from r in DB.Revenue_Table
                        join b in DB.Booking_market on r.BookingNumber equals b.BookingNumber
                        //where r.TransactionDate.Value.ToString("MMMM", CultureInfo.InvariantCulture).ToLower() == selectedMonth.ToLower()

                        select new
                        {
                            RevID = r.RevenueID,
                            BookingNum = r.BookingNumber,
                            RevenueT = r.RevenueType,
                            Revenuenum = r.RevenueNum,
                            Transactiondate = r.TransactionDate,
                            Bookdetail = b.BookingDetails

                        }).Distinct();

            if (data.Any())
            {
                dataRevenue.DataSource = data.ToList();
                if (dataRevenue.RowCount > 0)
                {
                    FromData();

                    //decimal? totalRevenue = data.Where(d => d.RevenueT == selectedType).Sum(d => d.Revenuenum);
                    //Total.Text = (totalRevenue ?? 0).ToString("N2");
                }


                

            }*/
        }
    }
}
