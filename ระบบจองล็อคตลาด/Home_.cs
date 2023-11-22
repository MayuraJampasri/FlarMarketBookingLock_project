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
    public partial class Home_ : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        public Home_()
        {
            InitializeComponent();
        }

        private void Home__Load(object sender, EventArgs e)
        {
            var cs = from lm in DB.Marketlocks
                     where lm.MarketZonename == "Homeappliances"
                     select new
                     {
                         LockID = lm.Marketlock_ID,
                         LockZone = lm.MarketZonename,
                         LockSize = lm.Marketlock_Size,
                         LockStatus = lm.Marketlock_Status,
                         LockFrequn = lm.PriceforFrequenters,
                         LockIrrec = lm.PriceforIrregulars,


                     }; //แสดงคอลัมน์บางส่วน
            if (cs.Count() > 0)
            {
                HomeDataTable.DataSource = cs.ToList();

                ShowData();
            }
        }

        public void ShowData()
        {

            if (HomeDataTable.RowCount > 0)
            {
                HomeDataTable.Columns[1].HeaderText = "รหัสล็อค";
                HomeDataTable.Columns[2].HeaderText = "ชื่อโซน";
                HomeDataTable.Columns[3].HeaderText = "ขนาดของล็อค";
                HomeDataTable.Columns[4].HeaderText = "สถานะล็อค";
                HomeDataTable.Columns[5].HeaderText = "ราคาขาประจำ";
                HomeDataTable.Columns[6].HeaderText = "ราคาขาจร";



                HomeDataTable.Columns[0].Width = 40;
                HomeDataTable.Columns[1].Width = 80;
                HomeDataTable.Columns[2].Width = 120;
                HomeDataTable.Columns[3].Width = 100;
                HomeDataTable.Columns[4].Width = 100;
                HomeDataTable.Columns[5].Width = 90;
                HomeDataTable.Columns[6].Width = 90;
            }
        }

        private void HomeDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LockData_ ld = new LockData_();
            ld.ShowLockID.Text = this.HomeDataTable.CurrentRow.Cells[1].Value.ToString();
            ld.ShowLockZone.Text = this.HomeDataTable.CurrentRow.Cells[2].Value.ToString();
            ld.ShowLockSize.Text = this.HomeDataTable.CurrentRow.Cells[3].Value.ToString();
            ld.ShowLockStatus.Text = this.HomeDataTable.CurrentRow.Cells[4].Value.ToString();
            ld.ShowChajornPrice.Text = this.HomeDataTable.CurrentRow.Cells[6].Value.ToString();
            ld.ShowChaprajamPrice.Text = this.HomeDataTable.CurrentRow.Cells[5].Value.ToString();
            ld.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sherchbtn_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                var cs = from lm in DB.Marketlocks
                         where lm.MarketZonename == "Homeappliances"
                         select new
                         {
                             LockID = lm.Marketlock_ID,
                             LockZone = lm.MarketZonename,
                             LockSize = lm.Marketlock_Size,
                             LockStatus = lm.Marketlock_Status,
                             LockFrequn = lm.PriceforFrequenters,
                             LockIrrec = lm.PriceforIrregulars,


                         }; //แสดงคอลัมน์บางส่วน
                if (cs.Count() > 0)
                {
                    HomeDataTable.DataSource = cs.ToList();

                    ShowData();
                }
            }
            else
            {
                var cs = from lm in DB.Marketlocks
                         where lm.MarketZonename == "Homeappliances" && lm.Marketlock_ID == SearchBox.Text
                         select new
                         {
                             LockID = lm.Marketlock_ID,
                             LockZone = lm.MarketZonename,
                             LockSize = lm.Marketlock_Size,
                             LockStatus = lm.Marketlock_Status,
                             LockFrequn = lm.PriceforFrequenters,
                             LockIrrec = lm.PriceforIrregulars,


                         }; //แสดงคอลัมน์บางส่วน
                if (cs.Count() > 0)
                {
                    HomeDataTable.DataSource = cs.ToList();

                    ShowData();
                }
            }
        }

        private void HomeDataTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == HomeDataTable.Columns["LockStatus"].Index && e.Value != null)
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
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
