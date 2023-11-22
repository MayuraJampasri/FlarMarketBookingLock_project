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
    public partial class HistoryBooking : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        public HistoryBooking()
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


            var GroupPay = from b in DB.Lock_return
                           where b.LockReturnStatus == "คืนล็อคก่อนเวลา"
                           group b by b.LockReturnStatus into statusGroup
                           select new
                           {
                               ReturnStatus = statusGroup.Key,
                               TotalStatus = statusGroup.Count()
                           };
            int totalPayComplate = 0;

            foreach (var status in GroupPay)
            {
                totalPayComplate += status.TotalStatus;
            }
            PreReturn.Text = totalPayComplate.ToString();

            var GroupReturn = from b in DB.Lock_return
                              where b.LockReturnStatus == "คืนล็อคสำเร็จ"
                              group b by b.LockReturnStatus into statusGroup
                              select new
                              {
                                  ReturnStatus = statusGroup.Key,
                                  TotalStatus = statusGroup.Count()
                              };
            int totalReturnComplate = 0;

            foreach (var status in GroupReturn)
            {
                totalReturnComplate += status.TotalStatus;
            }
            Return.Text = totalReturnComplate.ToString();

            var GroupPostReturn = from b in DB.Lock_return
                                  where b.LockReturnStatus == "คืนล็อคล่าช้า"
                                  group b by b.LockReturnStatus into statusGroup
                                  select new
                                  {
                                      ReturnStatus = statusGroup.Key,
                                      TotalStatus = statusGroup.Count()
                                  };
            int totalReturnPost = 0;

            foreach (var status in GroupPostReturn)
            {
                totalReturnPost += status.TotalStatus;
            }
            PostReturn.Text = totalReturnPost.ToString();

            TotalReturn.Text = (totalPayComplate + totalReturnComplate + totalReturnPost).ToString(); //ผลรวมทั้งหมด
        }

        private void HistoryBooking_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            var lr = from l in DB.Lock_return
                     select new
                     {
                         LockReturnID = l.Lock_ReturnID,
                         BookinID = l.BookingID,
                         CusID = l.CustomerID,
                         CusName = l.CustomerName,
                         CusLname = l.CustomerLastname,
                         LockID = l.Marketlock_ID,
                         LockSize = l.LockSize,
                         BookingType = l.BookingDetails,
                         BookingEnddate = l.Bookingenddate,
                         LockReturndate = l.LockReturnDate,
                         LockReturnperiod = l.LateReturnPeriod,
                         LockReturnstatus = l.LockReturnStatus,
                     };
            if (lr.Count() > 0)
            {
                LeturnLockListData.DataSource = lr.ToList();

                if (LeturnLockListData.RowCount > 0)
                {
                    FromData();

                }
            }
        }
        private void FromData()
        {
            LeturnLockListData.Columns[0].HeaderText = "รหัสการคืนล็อค";
            LeturnLockListData.Columns[1].HeaderText = "เลขใบจอง";
            LeturnLockListData.Columns[2].HeaderText = "รหัสลูกค้า";
            LeturnLockListData.Columns[3].HeaderText = "ชื่อลูกค้า";
            LeturnLockListData.Columns[4].HeaderText = "นามสกุลลูกค้า";
            LeturnLockListData.Columns[5].HeaderText = "รหัสล็อค";
            LeturnLockListData.Columns[6].HeaderText = "ขนาดล็อค";
            LeturnLockListData.Columns[7].HeaderText = "ประเภทการจอง";
            LeturnLockListData.Columns[8].HeaderText = "วันสุดท้ายการจอง";
            LeturnLockListData.Columns[9].HeaderText = "วันที่ทำการคืนล็อค";
            LeturnLockListData.Columns[10].HeaderText = "จำนวนวันที่คืนล่าช้า";
            LeturnLockListData.Columns[11].HeaderText = "สถานะการคืนล็อค";

            LeturnLockListData.Columns[0].Width = 70;
            LeturnLockListData.Columns[1].Width = 70;
            LeturnLockListData.Columns[2].Width = 70;
            LeturnLockListData.Columns[3].Width = 90;
            LeturnLockListData.Columns[4].Width = 90;
            LeturnLockListData.Columns[5].Width = 70;
            LeturnLockListData.Columns[6].Width = 80;
            LeturnLockListData.Columns[7].Width = 100;
            LeturnLockListData.Columns[8].Width = 120;
            LeturnLockListData.Columns[9].Width = 120;
            LeturnLockListData.Columns[10].Width = 80;
            LeturnLockListData.Columns[11].Width = 100;
        }
        private void Sherchbtn_Click(object sender, EventArgs e)
        {
            int CusIDinput;
            if (SearchBox.Text == "")
            {
                ShowData();
            }
            else
            {
                if (int.TryParse(SearchBox.Text, out CusIDinput))
                {
                    var lr = from l in DB.Lock_return
                             where l.CustomerID == CusIDinput
                             select new
                             {
                                 LockReturnID = l.Lock_ReturnID,
                                 BookinID = l.BookingID,
                                 CusID = l.CustomerID,
                                 CusName = l.CustomerName,
                                 CusLname = l.CustomerLastname,
                                 LockID = l.Marketlock_ID,
                                 LockSize = l.LockSize,
                                 BookingType = l.BookingDetails,
                                 BookingEnddate = l.Bookingenddate,
                                 LockReturndate = l.LockReturnDate,
                                 LockReturnperiod = l.LateReturnPeriod,
                                 LockReturnstatus = l.LockReturnStatus,
                             };
                    if (lr.Count() > 0)
                    {
                        LeturnLockListData.DataSource = lr.ToList();

                        if (LeturnLockListData.RowCount > 0)
                        {
                            FromData();

                        }
                    }
                }
                else
                {
                    var lr = from l in DB.Lock_return
                             where l.BookingID == SearchBox.Text || l.CustomerName == SearchBox.Text || l.Marketlock_ID == SearchBox.Text
                             select new
                             {
                                 LockReturnID = l.Lock_ReturnID,
                                 BookinID = l.BookingID,
                                 CusID = l.CustomerID,
                                 CusName = l.CustomerName,
                                 CusLname = l.CustomerLastname,
                                 LockID = l.Marketlock_ID,
                                 LockSize = l.LockSize,
                                 BookingType = l.BookingDetails,
                                 BookingEnddate = l.Bookingenddate,
                                 LockReturndate = l.LockReturnDate,
                                 LockReturnperiod = l.LateReturnPeriod,
                                 LockReturnstatus = l.LockReturnStatus,
                             };
                    if (lr.Count() > 0)
                    {
                        LeturnLockListData.DataSource = lr.ToList();

                        if (LeturnLockListData.RowCount > 0)
                        {
                            FromData();
                        }
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MonthSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selctedValue = (int)((dynamic)MonthSelect.SelectedItem).Value;
            //int selctedValue = MonthSelect.SelectedIndex + 1;
            if (MonthSelect.Text != "")
            {
                if (MonthSelect.SelectedIndex != 0)
                {
                    var GroupPay = from b in DB.Lock_return
                                   where b.LockReturnStatus == "คืนล็อคก่อนเวลา" && b.LockReturnDate.Value.Month == selctedValue
                                   group b by b.LockReturnStatus into statusGroup 
                                   select new
                                   {
                                       ReturnStatus = statusGroup.Key,
                                       TotalStatus = statusGroup.Count()
                                   };
                    int totalPayComplate = 0;

                    foreach (var status in GroupPay)
                    {
                        totalPayComplate += status.TotalStatus;
                    }
                    PreReturn.Text = totalPayComplate.ToString();

                    var GroupReturn = from b in DB.Lock_return
                                      where b.LockReturnStatus == "คืนล็อคสำเร็จ" && b.LockReturnDate.Value.Month == selctedValue
                                      group b by b.LockReturnStatus into statusGroup
                                      select new
                                      {
                                          ReturnStatus = statusGroup.Key,
                                          TotalStatus = statusGroup.Count()
                                      };
                    int totalReturnComplate = 0;

                    foreach (var status in GroupReturn)
                    {
                        totalReturnComplate += status.TotalStatus;
                    }
                    Return.Text = totalReturnComplate.ToString();

                    var GroupPostReturn = from b in DB.Lock_return
                                          where b.LockReturnStatus == "คืนล็อคล่าช้า" && b.LockReturnDate.Value.Month == selctedValue
                                          group b by b.LockReturnStatus into statusGroup
                                          select new
                                          {
                                              ReturnStatus = statusGroup.Key,
                                              TotalStatus = statusGroup.Count()
                                          };
                    int totalReturnPost = 0;

                    foreach (var status in GroupPostReturn)
                    {
                        totalReturnPost += status.TotalStatus;
                    }
                    PostReturn.Text = totalReturnPost.ToString();

                    TotalReturn.Text = (totalPayComplate + totalReturnComplate + totalReturnPost).ToString(); //ผลรวมทั้งหมด


                    var lr = from l in DB.Lock_return
                             where l.LockReturnDate.Value.Month == selctedValue
                             select new
                             {
                                 LockReturnID = l.Lock_ReturnID,
                                 BookinID = l.BookingID,
                                 CusID = l.CustomerID,
                                 CusName = l.CustomerName,
                                 CusLname = l.CustomerLastname,
                                 LockID = l.Marketlock_ID,
                                 LockSize = l.LockSize,
                                 BookingType = l.BookingDetails,
                                 BookingEnddate = l.Bookingenddate,
                                 LockReturndate = l.LockReturnDate,
                                 LockReturnperiod = l.LateReturnPeriod,
                                 LockReturnstatus = l.LockReturnStatus,
                             };
                    if (lr.Count() > 0)
                    {
                        LeturnLockListData.DataSource = lr.ToList();

                        if (LeturnLockListData.RowCount > 0)
                        {
                            FromData();

                        }
                    }
                    else
                    {
                        if (selctedValue == 0 || MonthSelect.Text == "ทั้งหมด")
                        {

                        }
                        else
                        {
                            MessageBox.Show("ไม่พบข้อมูลสำหรับเดือนที่เลือก", "ข้อความแจ้งเตือน");
                        }

                    }
                }
                else
                {
                    var GroupPay = from b in DB.Lock_return
                                   where b.LockReturnStatus == "คืนล็อคก่อนเวลา"
                                   group b by b.LockReturnStatus into statusGroup
                                   select new
                                   {
                                       ReturnStatus = statusGroup.Key,
                                       TotalStatus = statusGroup.Count()
                                   };
                    int totalPayComplate = 0;

                    foreach (var status in GroupPay)
                    {
                        totalPayComplate += status.TotalStatus;
                    }
                    PreReturn.Text = totalPayComplate.ToString();

                    var GroupReturn = from b in DB.Lock_return
                                      where b.LockReturnStatus == "คืนล็อคสำเร็จ"
                                      group b by b.LockReturnStatus into statusGroup
                                      select new
                                      {
                                          ReturnStatus = statusGroup.Key,
                                          TotalStatus = statusGroup.Count()
                                      };
                    int totalReturnComplate = 0;

                    foreach (var status in GroupReturn)
                    {
                        totalReturnComplate += status.TotalStatus;
                    }
                    Return.Text = totalReturnComplate.ToString();

                    var GroupPostReturn = from b in DB.Lock_return
                                          where b.LockReturnStatus == "คืนล็อคล่าช้า"
                                          group b by b.LockReturnStatus into statusGroup
                                          select new
                                          {
                                              ReturnStatus = statusGroup.Key,
                                              TotalStatus = statusGroup.Count()
                                          };
                    int totalReturnPost = 0;

                    foreach (var status in GroupPostReturn)
                    {
                        totalReturnPost += status.TotalStatus;
                    }
                    PostReturn.Text = totalReturnPost.ToString();

                    TotalReturn.Text = (totalPayComplate + totalReturnComplate + totalReturnPost).ToString(); //ผลรวมทั้งหมด

                    ShowData();
                }
              }
            }
        }
    }

