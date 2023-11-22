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
    public partial class LockMarket_ : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        Marketlock mk = new Marketlock();
        
        public LockMarket_()
        {
            InitializeComponent();

            if(textSher.Text == "")
            {
                var ma = from m in DB.Marketlocks

                         select new
                         {
                             Lock_ID = m.Marketlock_ID,
                             Lock_zone = m.MarketZonename,
                             Lock_size = m.Marketlock_Size,
                             Lock_status = m.Marketlock_Status
                         };
                if (ma.Count() > 0)
                {
                    LockDataTable.DataSource = ma.ToList();
                    FormatData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lockStatus_ ls = new lockStatus_();
            ls.ShowDialog();
        }

        private void resturanbtn_Click(object sender, EventArgs e)
        { //โซนร้านอาหาร
            Restaurant_ re = new Restaurant_();
            re.ShowDialog();
        }

        private void Fasionbtn_Click(object sender, EventArgs e)
        {  //โซนเสื้อผ้า
            Fasion_ fa = new Fasion_();
            fa.ShowDialog();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        { //โซนของใช้
            Home_ h = new Home_();
            h.ShowDialog();
        }

        private void beautybtn_Click(object sender, EventArgs e)
        { //โซนความสวยงาม
            Beauty be = new Beauty();
            be.ShowDialog();
        }

        private void fruitbtn_Click(object sender, EventArgs e)
        { //โซนผักผลไม้
            Fruit_ fr = new Fruit_();
            fr.ShowDialog();
        }

        private void LockMarket__Load(object sender, EventArgs e)
        {
            var ma = from m in DB.Marketlocks
                     select new
                     {
                         Lock_ID = m.Marketlock_ID,
                         Lock_zone = m.MarketZonename,
                         Lock_size = m.Marketlock_Size,
                         Lock_status = m.Marketlock_Status
                     };
            if (ma.Count() > 0)
            {
                LockDataTable.DataSource = ma.ToList();
                FormatData();
            }
        }

        private void FormatData()
        { //แก้ไขรูปแบบตาราง
            if (LockDataTable.RowCount > 0)
            {
                LockDataTable.Columns[0].HeaderText = "รหัสล็อค";
                LockDataTable.Columns[1].HeaderText = "ชื่อโซน";
                LockDataTable.Columns[2].HeaderText = "ขนาดล็อค";
                LockDataTable.Columns[3].HeaderText = "สถานะล็อค";

                LockDataTable.Columns[0].Width = 80;
                LockDataTable.Columns[1].Width = 150;
                LockDataTable.Columns[2].Width = 80;
                LockDataTable.Columns[3].Width = 120;


            }
        }

        private void Sherchbtn_Click(object sender, EventArgs e)
        {
            if (textSher.Text == "") {

                var ma = from m in DB.Marketlocks

                         select new
                         {
                             Lock_ID = m.Marketlock_ID,
                             Lock_zone = m.MarketZonename,
                             Lock_size = m.Marketlock_Size,
                             Lock_status = m.Marketlock_Status
                         };
                if (ma.Count() > 0)
                {
                    LockDataTable.DataSource = ma.ToList();
                    FormatData();
                }
                //return;
            }
            else { 
            var ma = from m in DB.Marketlocks
                     where m.Marketlock_ID == textSher.Text || m.MarketZonename == textSher.Text
                     select new
                     {
                         Lock_ID = m.Marketlock_ID,
                         Lock_zone = m.MarketZonename,
                         Lock_size = m.Marketlock_Size,
                         Lock_status = m.Marketlock_Status
                     };
            if (ma.Count() > 0)
            {
                LockDataTable.DataSource = ma.ToList();
                FormatData();
            }
        }


        }

        private void LockDataTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == LockDataTable.Columns["Lock_status"].Index && e.Value != null)
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
            if(e.ColumnIndex == LockDataTable.Columns["Lock_zone"].Index && e.Value != null)
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
