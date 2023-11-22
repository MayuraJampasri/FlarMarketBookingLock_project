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
    public partial class FineListForPay : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        public FineListForPay()
        {
            InitializeComponent();
            NowTime.Text = DateTime.Now.ToString();
        }

        private void FineListForPay_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            var lr = from l in DB.Lock_return
                     where l.FinePayStatus != "ชำระแล้ว" 
                     select new
                     {
                         BookingID =l.BookingID,
                         CusID = l.CustomerID,
                         Cusname = l.CustomerName,
                         CusLname = l.CustomerLastname,
                         FineAmount = l.FineSum,
                         FineStatus = l.FinePayStatus,
                         LastDate = l.LockReturnDate
                     };
            if (lr.Count()>0)
            {
                FineData.DataSource = lr.ToList();
                if (FineData.RowCount > 0)
                {
                    FromData();

                }
            }
        }

        private void FromData()
        {
            FineData.Columns[0].HeaderText = "เลขใบจอง";
            FineData.Columns[1].HeaderText = "รหัสผู้จอง";
            FineData.Columns[2].HeaderText = "ชื่อผู้จอง";
            FineData.Columns[3].HeaderText = "นามสกุลผู้จอง";
            FineData.Columns[4].HeaderText = "ค่าปรับ";
            FineData.Columns[5].HeaderText =  "สถานะการชำระ";
            FineData.Columns[6].HeaderText = "วันสุดท้ายที่จอง";

            FineData.Columns[0].Width = 70;
            FineData.Columns[1].Width = 70;
            FineData.Columns[2].Width = 100;
            FineData.Columns[3].Width = 100;
            FineData.Columns[4].Width = 100;
            FineData.Columns[5].Width = 100;
            FineData.Columns[6].Width = 100;
        }

        private void Sherchbtn_Click(object sender, EventArgs e)
        {
            int CusIDinput;
            if (SearchBox.Text == "")
            {
                ShowData();
            }
            else {
                    var lr = from l in DB.Lock_return
                             where l.BookingID == SearchBox.Text || l.CustomerName == SearchBox.Text
                             select new
                             {
                                 BookingID = l.BookingID,
                                 CusID = l.CustomerID,
                                 Cusname = l.CustomerName,
                                 CusLname = l.CustomerLastname,
                                 FineAmount = l.FineSum,
                                 FineStatus = l.FinePayStatus,
                                 LastDate = l.LockReturnDate
                             };
                    if (lr.Count() > 0)
                    {
                        FineData.DataSource = lr.ToList();
                        if (FineData.RowCount > 0)
                        {
                            FromData();

                        }
                    }
                
            }
        }

        private void FineData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //ระบบแจ้งเตือน
            //string dateString = FineData.Columns["LastDate"].ToString();
            DateTime? d = FineData.Rows[e.RowIndex].Cells["LastDate"].Value as DateTime?; //เป็นประเภทเวลา
            string FineStatus = e.Value.ToString();

            DateTime currentDate = DateTime.Now;

            if (e.ColumnIndex == FineData.Columns["FineStatus"].Index && e.Value != null)
            {
                if(currentDate > d && FineStatus == "ยังไม่ได้ชำระ")
                {
                    e.CellStyle.ForeColor = Color.Salmon;
                }
                else 
                {
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
