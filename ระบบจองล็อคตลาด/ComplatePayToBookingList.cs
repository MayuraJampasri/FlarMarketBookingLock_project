using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MoreLinq;




namespace ระบบจองล็อคตลาด
{
    public partial class ComplatePayToBookingList : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        public ComplatePayToBookingList()
        {
            InitializeComponent();
        }

        private void ComplatePayToBookingList_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        private void ShowData()
        {
            var data = (from r in DB.Revenue_Table
                        join c in DB.Customer_market on r.CustomerID equals c.CustomerID
                        select new {
                            RevID = r.RevenueID,
                            BookingNum = r.BookingNumber,
                            CusID = r.CustomerID,
                            CusName = c.CustomerName,
                            CusLastName = c.CustomerLastname,
                            RevenueT = r.RevenueType,
                            Revenuenum = r.RevenueNum,
                            Transactiondate =  r.TransactionDate
                            
                        }).Distinct();


            if (data.Count() > 0)
            {
                dataBoolingPay.DataSource = data.ToList();
                if(dataBoolingPay.RowCount > 0)
                {
                    FromData();

                }
            }

        }

        private void FromData()
        {
            dataBoolingPay.Columns[0].HeaderText = "รหัสการชำระเงิน";
            dataBoolingPay.Columns[1].HeaderText = "เลขใบจอง";
            dataBoolingPay.Columns[2].HeaderText = "รหัสผู้จอง";
            dataBoolingPay.Columns[3].HeaderText = "ชื่อผู้จอง";
            dataBoolingPay.Columns[4].HeaderText = "นามสกุลผู้จอง";
            dataBoolingPay.Columns[5].HeaderText = "รายการชำระเงิน";
            dataBoolingPay.Columns[6].HeaderText = "จำนวนเงิน";
            dataBoolingPay.Columns[7].HeaderText = "วันที่ชำระเงิน";



            dataBoolingPay.Columns[0].Width = 60;
            dataBoolingPay.Columns[1].Width = 80;
            dataBoolingPay.Columns[2].Width = 70;
            dataBoolingPay.Columns[3].Width = 100;
            dataBoolingPay.Columns[4].Width = 100;
            dataBoolingPay.Columns[5].Width = 100;
            dataBoolingPay.Columns[6].Width = 100;
            dataBoolingPay.Columns[7].Width = 100;
        }

        private void Sherchbtn_Click(object sender, EventArgs e)
        {
            if (BookingSearch.Text == "")
            {

                ShowData();
            }
            else
            {
                var data = (from r in DB.Revenue_Table
                            join c in DB.Customer_market on r.CustomerID equals c.CustomerID
                            where r.BookingNumber == BookingSearch.Text
                           orderby r.BookingNumber ascending
                           select new
                           {
                               RevID = r.RevenueID,
                               BookingNum = r.BookingNumber,
                               CusID = r.CustomerID,
                               CusName = c.CustomerName,
                               CusLastName = c.CustomerLastname,
                               RevenueT = r.RevenueType,
                               Revenuenum = r.RevenueNum,
                               Transactiondate = r.TransactionDate

                           }).Distinct(); 
                if (data.Count() > 0)
                {
                    dataBoolingPay.DataSource = data.ToList();
                    if (dataBoolingPay.RowCount > 0)
                    {
                        FromData();

                    }
                }
            }
        }

        private void dataBoolingPay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Receipt re = new Receipt();
            re.ShowBookingID.Text = this.dataBoolingPay.CurrentRow.Cells[1].Value.ToString();
            re.ShowCusID.Text = this.dataBoolingPay.CurrentRow.Cells[2].Value.ToString();
            re.ShowCusName.Text = this.dataBoolingPay.CurrentRow.Cells[3].Value.ToString();
            re.ShowCusLastname.Text = this.dataBoolingPay.CurrentRow.Cells[4].Value.ToString();
            re.ShowPaymentList.Text = this.dataBoolingPay.CurrentRow.Cells[8].Value.ToString();
            re.ShowPayment.Text = this.dataBoolingPay.CurrentRow.Cells[9].Value.ToString();
            re.ShowTotal.Text = this.dataBoolingPay.CurrentRow.Cells[9].Value.ToString();
            re.Show();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = (from  r in DB.Revenue_Table
                        join c in DB.Customer_market on r.CustomerID equals c.CustomerID
                        where r.RevenueType == "Booking"
                       select new
                       {
                           RevID = r.RevenueID,
                           BookingNum = r.BookingNumber,
                           CusID = r.CustomerID,
                           CusName = c.CustomerName,
                           CusLastName = c.CustomerLastname,
                           RevenueT = r.RevenueType,
                           Revenuenum = r.RevenueNum,
                           Transactiondate = r.TransactionDate

                       }).Distinct();
            if (data.Count() > 0)
            {
                dataBoolingPay.DataSource = data.ToList();
                if (dataBoolingPay.RowCount > 0)
                {
                    FromData();

                }
            }

        }
        private void Utility_Click(object sender, EventArgs e)
        {
            var data = (from  r in DB.Revenue_Table
                        join c in DB.Customer_market on r.CustomerID equals c.CustomerID
                        where r.RevenueType == "Utility Cost" 
                       select new
                       {
                           RevID = r.RevenueID,
                           BookingNum = r.BookingNumber,
                           CusID = r.CustomerID,
                           CusName = c.CustomerName,
                           CusLastName = c.CustomerLastname,
                           RevenueT = r.RevenueType,
                           Revenuenum = r.RevenueNum,
                           Transactiondate = r.TransactionDate


                       }).Distinct();
            if (data.Count() > 0)
            {
                dataBoolingPay.DataSource = data.ToList();
                if (dataBoolingPay.RowCount > 0)
                {
                    FromData(); 

                }
            }
        }

        private void Fine_Click(object sender, EventArgs e)
        {
            var data = (from r in DB.Revenue_Table
                        join c in DB.Customer_market on r.CustomerID equals c.CustomerID
                        where  r.RevenueType == "Fine Cost" 
                        select new
                        {
                            RevID = r.RevenueID,
                            BookingNum = r.BookingNumber,
                            CusID = r.CustomerID,
                            CusName = c.CustomerName,
                            CusLastName = c.CustomerLastname,
                            RevenueT = r.RevenueType,
                            Revenuenum = r.RevenueNum,
                            Transactiondate = r.TransactionDate

                        }).Distinct();
            if (data.Count() > 0)
            {
                dataBoolingPay.DataSource = data.ToList();
                if (dataBoolingPay.RowCount > 0)
                {

                    FromData();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
