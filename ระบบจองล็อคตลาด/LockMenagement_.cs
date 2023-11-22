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
    public partial class LockMenagement_ : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
       
        public LockMenagement_()
        {
            InitializeComponent();
            // combZone.SelectedValue = null;
            loadData();

            var lg = from lS in DB.Marketlocks
                     group lS by lS.MarketZonename into ZoneGroup
                     select new
                     {
                         LockZone = ZoneGroup.Key,
                         TotalZone = ZoneGroup.Count()
                     };
            combZone.BeginUpdate();
            combZone.DisplayMember = "LockZone";
            combZone.ValueMember = "LockZone";
            combZone.DataSource = lg.ToList();
            combZone.EndUpdate();

            /*if (combZone.SelectedItem != null)
            {
                string selectedZone = combZone.SelectedItem.ToString();

                // สร้าง LINQ query เพื่อค้นหาชื่อโซนที่เลือกในตาราง
                var matchingZones = from l in DB.Marketlocks
                                    where l.MarketZonename == selectedZone
                                    select l;
            }*/

            ChajornNum.Maximum = 1000;
            ChajornNum.Minimum = 100;

            ChaprajumNum.Maximum = 9000;
            ChaprajumNum.Minimum = 1000;


            var si = from rs in DB.Marketlocks
                     group rs by rs.Marketlock_Size into SizeGroup
                     orderby SizeGroup.Key
                     select new
                     {
                         LockSize = SizeGroup.Key,
                         TotalSize = SizeGroup.Count()
                     };
            if (si.Count() > 0) { 
            SizeSelect.BeginUpdate();
            SizeSelect.DisplayMember = "LockSize";
            SizeSelect.ValueMember = "LockSize";
            SizeSelect.DataSource = si.ToList();
            SizeSelect.EndUpdate();
            }
            //SizeSelect.Items.Add("2*2");
            //SizeSelect.Items.Add("3*4");
            



        }

        private bool IsDataComplete()
        {
            // ตรวจสอบข้อมูลที่ถูกกรอกในช่องข้อมูลที่คุณต้องการให้ครบ
            if (string.IsNullOrEmpty(Locktxt.Text) && (combZone.SelectedValue != null))
            {
                MessageBox.Show("คุณกรอกข้อมูลไม่ครบ");
                return false; // ข้อมูลไม่ครบ
            }

            // ถ้ามีเงื่อนไขอื่น ๆ ในการตรวจสอบข้อมูล ให้เพิ่มเงื่อนไขนั้นที่นี่

            return true; // ข้อมูลครบ
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lockStatus_ ls = new lockStatus_();
            ls.ShowDialog();
        }

        private void LockMenagement__Load(object sender, EventArgs e)
        {

        }
        private void loadData()
        {
            var cs = from lm in DB.Marketlocks
                     orderby lm.Marketlock_ID ascending
                     select new
                     {
                         LockID = lm.Marketlock_ID,
                         LockZone = lm.MarketZonename,
                         LockSize = lm.Marketlock_Size,
                         LockFrequn = lm.PriceforFrequenters,
                         LockIrrec = lm.PriceforIrregulars,
                         LockStatus = lm.Marketlock_Status

                     };
            if (cs.Count() > 0)
            {
                dataOfLock.DataSource = cs.ToList();

                if (dataOfLock.RowCount > 0)
                {
                    dataOfLock.Columns[0].HeaderText = "รหัสโซน";
                    dataOfLock.Columns[1].HeaderText = "ชื่อโซน";
                    dataOfLock.Columns[2].HeaderText = "ขนาดของล็อค";
                    dataOfLock.Columns[3].HeaderText = "ราคาขาประจำ";
                    dataOfLock.Columns[4].HeaderText = "ราคาขาจร";
                    dataOfLock.Columns[5].HeaderText = "สถานะล็อค";


                    dataOfLock.Columns[0].Width = 80;
                    dataOfLock.Columns[1].Width = 100;
                    dataOfLock.Columns[2].Width = 100;
                    dataOfLock.Columns[3].Width = 100;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal Chajorn, Chaprajam;
            bool hasLetter = Locktxt.Text.Any(char.IsLetter);
            bool hasDigit = Locktxt.Text.Any(char.IsDigit);
            String UpperMarketID;

            //ปุ่มแก้ไขข้อมูล
            if (MessageBox.Show("คุณต้องการแก้ไขรายการนี้ใช่หรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //if (decimal.TryParse(ChajoenPTxt.Text.Trim(), out Chajorn) && decimal.TryParse(ChaPrajamPtxt.Text.Trim(), out Chaprajam))
                //{
                if (Locktxt.Text != " ")
                {
                    var cs = (from lm in DB.Marketlocks
                              where lm.Marketlock_ID == Locktxt.Text
                              select lm).FirstOrDefault();
                    //ดึงข้อมูลขึ้นมา
                    if (cs != null)
                    {
                        if (hasLetter && hasDigit)
                        {
                            if (cs.Marketlock_Status != "Unavailable")
                            {
                                UpperMarketID = Locktxt.Text.Trim();
                                cs.Marketlock_ID = UpperMarketID.ToUpper();
                                //cs.Marketlock_ID = Locktxt.Text.Trim();
                                cs.MarketZonename = combZone.SelectedValue.ToString();
                                cs.Marketlock_Size = SizeSelect.SelectedValue.ToString();
                                //cs.Marketlock_Size = LockSizetxt.Text.Trim();
                                cs.PriceforIrregulars = (decimal)ChajornNum.Value;
                                cs.PriceforFrequenters = (decimal)ChaprajumNum.Value;
                                // cs.PriceforIrregulars = Chajorn;
                                //cs.PriceforFrequenters = Chaprajam;
                                cs.Marketlock_Status = "Free";

                                using (var tr = DB.Database.BeginTransaction())
                                {
                                    DB.SaveChanges();
                                    tr.Commit();
                                    MessageBox.Show("แก้ไขเรียบร้อยจร้า");
                                    loadData();
                                }
                                ResetAll();
                            }
                            else
                            {
                                MessageBox.Show("ไม่สามารถแก้ไขข้อมูลได้ เนื่องจากล็อคนี้กำลังจองอยู่");
                                return;
                            }
                        }
                        else { MessageBox.Show("ไม่พบข้อมูล"); return; }


                    }


                    //}
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //ปุ่มล้างข้อมูล
           Locktxt.Text = "";
            combZone.SelectedIndex = -1;
            ChajornNum.Value = ChajornNum.Minimum;
            ChaprajumNum.Value = ChaprajumNum.Minimum;
            SizeSelect.SelectedIndex = -1;
            //combZone.SelectedValue = ;
            //LockSizetxt.Text = "";

        }

        private void ResetAll()
        {
            //รีเซตค่าทั้งหมด
            Locktxt.Text = "";
            combZone.SelectedIndex = -1;
            ChajornNum.Value = ChajornNum.Minimum;
            ChaprajumNum.Value = ChaprajumNum.Minimum;
            SizeSelect.SelectedIndex = -1;
            //combZone.SelectedValue.ToString() = 
            //LockSizetxt.Text = "";

        }
        private void dataOfLock_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
                 Locktxt.Text = dataOfLock.Rows[e.RowIndex].Cells["LockID"].Value.ToString();
                combZone.SelectedValue = dataOfLock.Rows[e.RowIndex].Cells["LockZone"].Value.ToString();
                //LockSizetxt.Text = dataOfLock.Rows[e.RowIndex].Cells["LockSize"].Value.ToString();
                //ChajornNum.Value = int.Parse(dataOfLock.Rows[e.RowIndex].Cells["LockIrrec"].Value);
                //ChaprajumNum.Value = int.Parse(dataOfLock.Rows[e.RowIndex].Cells["LockFrequn"].Value);
                combZone.SelectedValue = dataOfLock.Rows[e.RowIndex].Cells["LockZone"].Value.ToString();
                SizeSelect.SelectedValue = dataOfLock.Rows[e.RowIndex].Cells["LockSize"].Value.ToString();
            //ChajoenPTxt.Text = dataOfLock.Rows[e.RowIndex].Cells["LockIrrec"].Value.ToString();
            //ChaPrajamPtxt.Text = dataOfLock.Rows[e.RowIndex].Cells["LockFrequn"].Value.ToString();
            /*if (e.RowIndex >= 0)
            {
                object LockZoneValue = dataOfLock.Rows[e.RowIndex].Cells["LockSize"].Value.ToString();
                if(LockZoneValue != null)
                {
                    combZone.SelectedValue = LockZoneValue;
                }
            }*/

            Decimal? lockIrre = dataOfLock.Rows[e.RowIndex].Cells["LockIrrec"].Value as Decimal?;
            ChajornNum.Value = lockIrre.Value;
            Decimal? lockFrequn = dataOfLock.Rows[e.RowIndex].Cells["LockFrequn"].Value as Decimal?;
            ChaprajumNum.Value = lockFrequn.Value;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ปุ่มลบ
            if (MessageBox.Show("คุณต้องการลบรายการใช่หรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                var l = (from lm in DB.Marketlocks
                          where lm.Marketlock_ID == Locktxt.Text.Trim()
                          select lm).FirstOrDefault();
                
                    if (l != null)
                    {
                      if (l.Marketlock_Status != "Unavailable")
                       {
                        DB.Marketlocks.Remove(l);
                        DB.SaveChanges();

                        MessageBox.Show("ทำการลบรายการเรียบร้อย", "ผลการทำงาน");
                        loadData();
                        ResetAll();
                       }
                       else
                       {
                          MessageBox.Show("ไม่สามารถลบล็อคนี้ได้ เนื่องจากมีการจองอยู่");
                        }
                    }
                
               
            }
        }

        private void dataOfLock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataOfLock.Columns["LockZone"].Index && e.Value != null)
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

            if (e.ColumnIndex == dataOfLock.Columns["LockStatus"].Index && e.Value != null)
            {
                string lockStatus = e.Value.ToString();

                if(lockStatus == "Free")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (lockStatus == "Unavailable")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }

            if (e.ColumnIndex == dataOfLock.Columns["LockID"].Index && e.Value != null)
            {
                //string lockID = e.Value.ToString();
                object cellValue = dataOfLock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue.ToString().StartsWith("A"))
                {
                    e.CellStyle.ForeColor = Color.Salmon;
                }
                else if (cellValue.ToString().StartsWith("B"))
                {
                    e.CellStyle.ForeColor = Color.DeepPink;
                }
                else if (cellValue.ToString().StartsWith("C"))
                {
                    e.CellStyle.ForeColor = Color.Teal;
                }
                else if (cellValue.ToString().StartsWith("D"))
                {
                    e.CellStyle.ForeColor = Color.OrangeRed;
                }
                else if (cellValue.ToString().StartsWith("E"))
                {
                    e.CellStyle.ForeColor = Color.OliveDrab;
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Marketlock mk = new Marketlock();
            //ปุ่มเพิ่มข้อมูล
            //ตรวจว่าภายใน id ประกอบด้วยตัวอักษรและตัวเลขหรือเปล่า
            bool hasLetter = Locktxt.Text.Any(char.IsLetter);
            bool hasDigit = Locktxt.Text.Any(char.IsDigit);
            String UpperMarketID;

            if (IsDataComplete())
            {
                if (hasLetter && hasDigit)
                {
                    if (Locktxt.Text.Trim() != mk.Marketlock_ID)
                    { 

                    if ((int)ChajornNum.Value >= 1000 || (int)ChaprajumNum.Value >= 9000)
                    {
                        MessageBox.Show("จำนวนเงินเกินขีดจำกัด");
                        return;
                    }
                    else if ((int)ChajornNum.Value <= 100 || (int)ChaprajumNum.Value <= 1000)
                    {
                        MessageBox.Show("จำนวนเงินน้อยเกินไป");
                        return;
                    }
                    else if ((int)ChajornNum.Value >= 1000 && (int)ChaprajumNum.Value >= 9000)
                    {
                        MessageBox.Show("จำนวนเงินเกินขีดจำกัด");
                        return;
                    }
                    else if ((int)ChajornNum.Value <= 100 && (int)ChaprajumNum.Value <= 1000)
                    {
                        MessageBox.Show("จำนวนเงินน้อยเกินไป");
                        return;
                    }
                    else
                    {
                        if (combZone.SelectedIndex != -1 || SizeSelect.SelectedIndex != -1 || (combZone.SelectedIndex != -1 && SizeSelect.SelectedIndex != -1))
                        {
                                UpperMarketID = Locktxt.Text.Trim();
                                mk.Marketlock_ID = UpperMarketID.ToUpper();
                                //mk.Marketlock_ID = Locktxt.Text.Trim();
                                mk.MarketZonename = combZone.SelectedValue.ToString();

                                mk.Marketlock_Size = SizeSelect.SelectedValue.ToString();
                                //mk.Marketlock_Size = LockSizetxt.Text.Trim();
                                mk.PriceforIrregulars = (decimal)ChajornNum.Value;
                                mk.PriceforFrequenters = (decimal)ChaprajumNum.Value;
                                //mk.PriceforIrregulars = int.Parse(ChajoenPTxt.Text.Trim());
                                //mk.PriceforFrequenters = int.Parse(ChaPrajamPtxt.Text.Trim());
                                mk.Marketlock_Status = "Free";

                                /*bool LockHaving = DB.Marketlocks.Any(l => l.Marketlock_ID == Locktxt.Text.Trim());
                                //if (mk.Marketlock_ID.Equals(Locktxt.Text.Trim())) { MessageBox.Show("รหัสล็อคนี้มีอยู่แล้ว"); }
                                if (LockHaving) { MessageBox.Show("รหัสล็อคนี้มีอยู่แล้ว"); return; }
                                else
                                {
                                    DB.Marketlocks.Add(mk);
                                    DB.SaveChanges();
                                    loadData();
                                    MessageBox.Show("บันทึกข้อมูลสำเร็จ", "ผลการทำงาน");
                                    ResetAll();
                                }*/
                                DB.Marketlocks.Add(mk);
                                DB.SaveChanges();
                                loadData();
                                MessageBox.Show("บันทึกข้อมูลสำเร็จ", "ผลการทำงาน");
                                ResetAll();
                            }
                            else
                            {
                                MessageBox.Show("กรุณาเลือกโซนด้วย");
                                return;
                            }
                        }

                  }
                    else
                    {
                        MessageBox.Show("รหัสล็อคนี้มีอยู่แล้ว");
                    }

                }
                else
                {
                    MessageBox.Show("รหัสล็อคของคุณไม่มีรูปแบบไม่ถูกต้อง");
                }
            }
        }
    }
}
