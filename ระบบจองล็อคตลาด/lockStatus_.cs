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
    public partial class lockStatus_ : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();//ฐานข้อมูล
        Marketlock mk = new Marketlock();
        public lockStatus_()
        {
            InitializeComponent();
         
            //-----------------------------------------

            //ผลรวมล็อคว่าง
            var lockStatusSummary = from lS in DB.Marketlocks
                        where lS.Marketlock_Status == "Free"
                        group  lS by lS.Marketlock_Status into statusGroup
                        select new
                        {
                            LockStatus = statusGroup.Key,
                            TotalLocks = statusGroup.Count()
                        };

            int totalFreeLocks = 0;

            foreach (var status in lockStatusSummary)
            {
                totalFreeLocks += status.TotalLocks;
            }
            TotalIdleNum.Text = totalFreeLocks.ToString();

            //ผลรวมล็อคจองแล้ว
            var lockSummary = from lS in DB.Marketlocks
                                    where lS.Marketlock_Status == "Unavailable"
                                    group lS by lS.Marketlock_Status into statusGroup
                                    select new
                                    {
                                        LockStatus = statusGroup.Key,
                                        TotalLocks = statusGroup.Count()
                                    };

            int totalUnaLocks = 0;

            foreach (var status in lockSummary)
            {
                totalUnaLocks += status.TotalLocks;
            }
            TotalBookingNum.Text = totalUnaLocks.ToString();

            //ผลรวมล็อคทั้งหมด 
            TotalNum.Text = (totalUnaLocks + totalFreeLocks).ToString();

            //---------------------------------------------------------


            
        }


        private void lockStatus_Load(object sender, EventArgs e)
        {
            //แสดงตารางข้อมูลล็อค
            

            var cs = from lm in DB.Marketlocks
                     
                     select new
                     {
                         LockID = lm.Marketlock_ID,
                         LockZone = lm.MarketZonename,
                         LockSize = lm.Marketlock_Size,
                         LockFrequn = lm.PriceforFrequenters,
                         LockIrrec = lm.PriceforIrregulars,
                         LockStatus = lm.Marketlock_Status
                        
                     }; //แสดงคอลัมน์บางส่วน
            if (cs.Count() > 0)
            {
                LockData.DataSource = cs.ToList();

                ShowData();
                /*if (LockData.RowCount > 0)
                {
                    LockData.Columns[0].HeaderText = "รหัสโซน";
                    LockData.Columns[1].HeaderText = "ชื่อโซน";
                    LockData.Columns[2].HeaderText = "ขนาดของล็อค";
                    LockData.Columns[3].HeaderText = "ราคาขาประจำ";
                    LockData.Columns[4].HeaderText = "ราคาขาจร";
                    LockData.Columns[5].HeaderText = "สถานะล็อค";


                    LockData.Columns[0].Width = 80;
                    LockData.Columns[1].Width = 100;
                    LockData.Columns[2].Width = 100;
                    LockData.Columns[3].Width = 100;
                }*/
            }


        }

        public void ShowData()
        {

            if (LockData.RowCount > 0)
            {
                LockData.Columns[0].HeaderText = "รหัสโซน";
                LockData.Columns[1].HeaderText = "ชื่อโซน";
                LockData.Columns[2].HeaderText = "ขนาดของล็อค";
                LockData.Columns[3].HeaderText = "ราคาขาประจำ";
                LockData.Columns[4].HeaderText = "ราคาขาจร";
                LockData.Columns[5].HeaderText = "สถานะล็อค";


                LockData.Columns[0].Width = 80;
                LockData.Columns[1].Width = 100;
                LockData.Columns[2].Width = 100;
                LockData.Columns[3].Width = 100;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resturanBTN_Click(object sender, EventArgs e)
        {
            var lockStatusSummary = from lS in DB.Marketlocks
                                    where lS.Marketlock_Status == "Free" && lS.MarketZonename == "Restaurant"
                                    group lS by lS.Marketlock_Status into statusGroup
                                    select new
                                    {
                                        LockStatus = statusGroup.Key,
                                        TotalLocks = statusGroup.Count()
                                    };
            int totalFreeLocks = 0;

            foreach (var status in lockStatusSummary)
            {
                totalFreeLocks += status.TotalLocks;
            }
            ZoneIdleNum.Text = totalFreeLocks.ToString();

            var lockSummary = from lS in DB.Marketlocks
                              where lS.Marketlock_Status == "Unavailable" && lS.MarketZonename == "Restaurant"
                              group lS by lS.Marketlock_Status into statusGroup
                              select new
                              {
                                  LockStatus = statusGroup.Key,
                                  TotalLocks = statusGroup.Count()
                              };

            int totalUnaLocks = 0;

            foreach (var status in lockSummary)
            {
                totalUnaLocks += status.TotalLocks;
            }
            ZoneBookingNum.Text = totalUnaLocks.ToString();

            ZoneTotalNum.Text = (totalUnaLocks + totalFreeLocks).ToString();
      

            //------------------------------------

            var cs = from lm in DB.Marketlocks
                     where lm.MarketZonename == "Restaurant"
                     select new
                     {
                         LockID = lm.Marketlock_ID,
                         LockZone = lm.MarketZonename,
                         LockSize = lm.Marketlock_Size,
                         LockFrequn = lm.PriceforFrequenters,
                         LockIrrec = lm.PriceforIrregulars,
                         LockStatus = lm.Marketlock_Status

                     }; //แสดงคอลัมน์บางส่วน
            if (cs.Count() > 0)
            {
                LockData.DataSource = cs.ToList();

                ShowData();
            }

            /*if (Freebtn.Enabled = true)
            {
                var lockStatusSummaryFree = from lS in DB.Marketlocks
                                        where lS.Marketlock_Status == "Free" && lS.MarketZonename == "Restaurant"
                                        group lS by lS.Marketlock_Status into statusGroup
                                        select new
                                        {
                                            LockStatus = statusGroup.Key,
                                            TotalLocks = statusGroup.Count()
                                        };
                int totalFreeLockss = 0;

                foreach (var status in lockStatusSummary)
                {
                    totalFreeLocks += status.TotalLocks;
                }
                ZoneIdleNum.Text = totalFreeLockss.ToString();
                ZoneTotalNum.Text = "0";
                ZoneBookingNum.Text = "0";

                var rf = from lm in DB.Marketlocks
                         where lm.MarketZonename == "Restaurant"
                         select new
                         {
                             LockID = lm.Marketlock_ID,
                             LockZone = lm.MarketZonename,
                             LockSize = lm.Marketlock_Size,
                             LockFrequn = lm.PriceforFrequenters,
                             LockIrrec = lm.PriceforIrregulars,
                             LockStatus = lm.Marketlock_Status

                         }; //แสดงคอลัมน์บางส่วน
                if (rf.Count() > 0)
                {
                    LockData.DataSource = cs.ToList();

                    ShowData();
                }
            }*/
        }

        private void FasionBTN_Click(object sender, EventArgs e)
        {
            var lockStatusSummary = from lS in DB.Marketlocks
                                    where lS.Marketlock_Status == "Free" && lS.MarketZonename == "Fashion"
                                    group lS by lS.Marketlock_Status into statusGroup
                                    select new
                                    {
                                        LockStatus = statusGroup.Key,
                                        TotalLocks = statusGroup.Count()
                                    };
            int totalFreeLocks = 0;

            foreach (var status in lockStatusSummary)
            {
                totalFreeLocks += status.TotalLocks;
            }
            ZoneIdleNum.Text = totalFreeLocks.ToString();

            var lockSummary = from lS in DB.Marketlocks
                              where lS.Marketlock_Status == "Unavailable" && lS.MarketZonename == "Fashion"
                              group lS by lS.Marketlock_Status into statusGroup
                              select new
                              {
                                  LockStatus = statusGroup.Key,
                                  TotalLocks = statusGroup.Count()
                              };

            int totalUnaLocks = 0;

            foreach (var status in lockSummary)
            {
                totalUnaLocks += status.TotalLocks;
            }
            ZoneBookingNum.Text = totalUnaLocks.ToString();

            ZoneTotalNum.Text = (totalUnaLocks + totalFreeLocks).ToString();
            //------------------------------------------------
            var cs = from lm in DB.Marketlocks
                     where lm.MarketZonename == "Fashion"
                     select new
                     {
                         LockID = lm.Marketlock_ID,
                         LockZone = lm.MarketZonename,
                         LockSize = lm.Marketlock_Size,
                         LockFrequn = lm.PriceforFrequenters,
                         LockIrrec = lm.PriceforIrregulars,
                         LockStatus = lm.Marketlock_Status

                     }; //แสดงคอลัมน์บางส่วน
            if (cs.Count() > 0)
            {
                LockData.DataSource = cs.ToList();

                ShowData();
            }
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            var lockStatusSummary = from lS in DB.Marketlocks
                                    where lS.Marketlock_Status == "Free" && lS.MarketZonename == "Homeappliances"
                                    group lS by lS.Marketlock_Status into statusGroup
                                    select new
                                    {
                                        LockStatus = statusGroup.Key,
                                        TotalLocks = statusGroup.Count()
                                    };
            int totalFreeLocks = 0;

            foreach (var status in lockStatusSummary)
            {
                totalFreeLocks += status.TotalLocks;
            }
            ZoneIdleNum.Text = totalFreeLocks.ToString();

            var lockSummary = from lS in DB.Marketlocks
                              where lS.Marketlock_Status == "Unavailable" && lS.MarketZonename == "Homeappliances"
                              group lS by lS.Marketlock_Status into statusGroup
                              select new
                              {
                                  LockStatus = statusGroup.Key,
                                  TotalLocks = statusGroup.Count()
                              };

            int totalUnaLocks = 0;

            foreach (var status in lockSummary)
            {
                totalUnaLocks += status.TotalLocks;
            }
            ZoneBookingNum.Text = totalUnaLocks.ToString();

            ZoneTotalNum.Text = (totalUnaLocks + totalFreeLocks).ToString();

            //------------------------------------------------
            var cs = from lm in DB.Marketlocks
                     where lm.MarketZonename == "Homeappliances"
                     select new
                     {
                         LockID = lm.Marketlock_ID,
                         LockZone = lm.MarketZonename,
                         LockSize = lm.Marketlock_Size,
                         LockFrequn = lm.PriceforFrequenters,
                         LockIrrec = lm.PriceforIrregulars,
                         LockStatus = lm.Marketlock_Status

                     }; //แสดงคอลัมน์บางส่วน
            if (cs.Count() > 0)
            {
                LockData.DataSource = cs.ToList();

                ShowData();
            }
        }

        private void beautyBTN_Click(object sender, EventArgs e)
        {
            var lockStatusSummary = from lS in DB.Marketlocks
                                    where lS.Marketlock_Status == "Free" && lS.MarketZonename == "Health and beauty products"
                                    group lS by lS.Marketlock_Status into statusGroup
                                    select new
                                    {
                                        LockStatus = statusGroup.Key,
                                        TotalLocks = statusGroup.Count()
                                    };
            int totalFreeLocks = 0;

            foreach (var status in lockStatusSummary)
            {
                totalFreeLocks += status.TotalLocks;
            }
            ZoneIdleNum.Text = totalFreeLocks.ToString();

            var lockSummary = from lS in DB.Marketlocks
                              where lS.Marketlock_Status == "Unavailable" && lS.MarketZonename == "Health and beauty products"
                              group lS by lS.Marketlock_Status into statusGroup
                              select new
                              {
                                  LockStatus = statusGroup.Key,
                                  TotalLocks = statusGroup.Count()
                              };

            int totalUnaLocks = 0;

            foreach (var status in lockSummary)
            {
                totalUnaLocks += status.TotalLocks;
            }
            ZoneBookingNum.Text = totalUnaLocks.ToString();

            ZoneTotalNum.Text = (totalUnaLocks + totalFreeLocks).ToString();

            //------------------------------------------------
            var cs = from lm in DB.Marketlocks
                     where lm.MarketZonename == "Health and beauty products"
                     select new
                     {
                         LockID = lm.Marketlock_ID,
                         LockZone = lm.MarketZonename,
                         LockSize = lm.Marketlock_Size,
                         LockFrequn = lm.PriceforFrequenters,
                         LockIrrec = lm.PriceforIrregulars,
                         LockStatus = lm.Marketlock_Status

                     }; //แสดงคอลัมน์บางส่วน
            if (cs.Count() > 0)
            {
                LockData.DataSource = cs.ToList();

                ShowData();
            }
        }



        private void fruitBTN_Click(object sender, EventArgs e)
        {
            var lockStatusSummary = from lS in DB.Marketlocks
                                    where lS.Marketlock_Status == "Free" && lS.MarketZonename == "Fruit shop"
                                    group lS by lS.Marketlock_Status into statusGroup
                                    select new
                                    {
                                        LockStatus = statusGroup.Key,
                                        TotalLocks = statusGroup.Count()
                                    };
            int totalFreeLocks = 0;

            foreach (var status in lockStatusSummary)
            {
                totalFreeLocks += status.TotalLocks;
            }
            ZoneIdleNum.Text = totalFreeLocks.ToString();

            var lockSummary = from lS in DB.Marketlocks
                              where lS.Marketlock_Status == "Unavailable" && lS.MarketZonename == "Fruit shop"
                              group lS by lS.Marketlock_Status into statusGroup
                              select new
                              {
                                  LockStatus = statusGroup.Key,
                                  TotalLocks = statusGroup.Count()
                              };

            int totalUnaLocks = 0;

            foreach (var status in lockSummary)
            {
                totalUnaLocks += status.TotalLocks;
            }
            ZoneBookingNum.Text = totalUnaLocks.ToString();

            ZoneTotalNum.Text = (totalUnaLocks + totalFreeLocks).ToString();

            //------------------------------------------------
            var cs = from lm in DB.Marketlocks
                     where lm.MarketZonename == "Fruit shop"
                     select new
                     {
                         LockID = lm.Marketlock_ID,
                         LockZone = lm.MarketZonename,
                         LockSize = lm.Marketlock_Size,
                         LockFrequn = lm.PriceforFrequenters,
                         LockIrrec = lm.PriceforIrregulars,
                         LockStatus = lm.Marketlock_Status

                     }; //แสดงคอลัมน์บางส่วน
            if (cs.Count() > 0)
            {
                LockData.DataSource = cs.ToList();

                ShowData();
            }
        }

        private void Total_Click(object sender, EventArgs e)
        {
            var cs = from lm in DB.Marketlocks
                     select new
                     {
                         LockID = lm.Marketlock_ID,
                         LockZone = lm.MarketZonename,
                         LockSize = lm.Marketlock_Size,
                         LockFrequn = lm.PriceforFrequenters,
                         LockIrrec = lm.PriceforIrregulars,
                         LockStatus = lm.Marketlock_Status

                     }; //แสดงคอลัมน์บางส่วน
            if (cs.Count() > 0)
            {
                LockData.DataSource = cs.ToList();

                ShowData();
            }

            ZoneTotalNum.Text = "0";
            ZoneIdleNum.Text = "0";
            ZoneBookingNum.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cs = from lm in DB.Marketlocks
                     where lm.Marketlock_Status == "Free"
                     select new
                     {
                         LockID = lm.Marketlock_ID,
                         LockZone = lm.MarketZonename,
                         LockSize = lm.Marketlock_Size,
                         LockFrequn = lm.PriceforFrequenters,
                         LockIrrec = lm.PriceforIrregulars,
                         LockStatus = lm.Marketlock_Status

                     }; //แสดงคอลัมน์บางส่วน
            if (cs.Count() > 0)
            {
                LockData.DataSource = cs.ToList();

                ShowData();
            }

            ZoneTotalNum.Text = "0";
            ZoneIdleNum.Text = "0";
            ZoneBookingNum.Text = "0";

            /*if(resturanBTN.Enabled = true)
            {
                var lockStatusSummary = from lS in DB.Marketlocks
                                        where lS.Marketlock_Status == "Free" && lS.MarketZonename == "Restaurant"
                                        group lS by lS.Marketlock_Status into statusGroup
                                        select new
                                        {
                                            LockStatus = statusGroup.Key,
                                            TotalLocks = statusGroup.Count()
                                        };
                int totalFreeLocks = 0;

                foreach (var status in lockStatusSummary)
                {
                    totalFreeLocks += status.TotalLocks;
                }
                ZoneIdleNum.Text = totalFreeLocks.ToString();
                //------------------------------------

                var bs = from lm in DB.Marketlocks
                         where lm.MarketZonename == "Restaurant"
                         select new
                         {
                             LockID = lm.Marketlock_ID,
                             LockZone = lm.MarketZonename,
                             LockSize = lm.Marketlock_Size,
                             LockFrequn = lm.PriceforFrequenters,
                             LockIrrec = lm.PriceforIrregulars,
                             LockStatus = lm.Marketlock_Status

                         }; //แสดงคอลัมน์บางส่วน
                if (bs.Count() > 0)
                {
                    LockData.DataSource = cs.ToList();

                    ShowData();
                }
            }*/
        }

        private void BookedBtn_Click(object sender, EventArgs e)
        {
            var cs = from lm in DB.Marketlocks
                     where lm.Marketlock_Status == "Unavailable"
                     select new
                     {
                         LockID = lm.Marketlock_ID,
                         LockZone = lm.MarketZonename,
                         LockSize = lm.Marketlock_Size,
                         LockFrequn = lm.PriceforFrequenters,
                         LockIrrec = lm.PriceforIrregulars,
                         LockStatus = lm.Marketlock_Status

                     }; //แสดงคอลัมน์บางส่วน
            if (cs.Count() > 0)
            {
                LockData.DataSource = cs.ToList();

                ShowData();
            }

            ZoneTotalNum.Text = "0";
            ZoneIdleNum.Text = "0";
            ZoneBookingNum.Text = "0";

        }

        private void LockData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == LockData.Columns["LockStatus"].Index && e.Value != null)
            {
                string lockStatus = e.Value.ToString();

                if (lockStatus == "Free")
                {
                    e.CellStyle.ForeColor = Color.Green; // ล็อคว่างขึ้นสีเขียว
                }
                else if (lockStatus == "Unavailable")
                {
                    e.CellStyle.ForeColor = Color.Red; // ล็อคจองขึ้นเป็นสีแดง
                }
            }
            if (e.ColumnIndex == LockData.Columns["LockZone"].Index && e.Value != null)
            {
                string lockZone = e.Value.ToString();
                if (lockZone == "Restaurant")
                {
                    e.CellStyle.ForeColor = Color.Salmon;
                }
                else if (lockZone == "Fashion")
                {
                    e.CellStyle.ForeColor = Color.DeepPink;
                }
                else if (lockZone == "Homeappliances")
                {
                    e.CellStyle.ForeColor = Color.Teal;
                }
                else if (lockZone == "Health and beauty products")
                {
                    e.CellStyle.ForeColor = Color.OrangeRed;
                }
                else if (lockZone == "Fruit shop")
                {
                    e.CellStyle.ForeColor = Color.OliveDrab;
                }
            }
        }
    }
}
