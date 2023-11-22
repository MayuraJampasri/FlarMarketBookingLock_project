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
    public partial class NewCustomer_ : Form
    {
        private Customer_market c = new Customer_market(); //ก้อนตารางที่่ต้องการอ้างอิง

        DB_FleamarketEntities DB = new DB_FleamarketEntities(); //ฐานข้อมูลต้องมีก้อนนี้
        private bool IsDataComplete()
        {
            // ตรวจสอบข้อมูลที่ถูกกรอกในช่องข้อมูลที่คุณต้องการให้ครบ
            if (string.IsNullOrEmpty(CustomerName.Text) && string.IsNullOrEmpty(CustomerLastname.Text) && string.IsNullOrEmpty(CustomerPhone.Text) && string.IsNullOrEmpty(CustomerEmail.Text) && string.IsNullOrEmpty(customer_ID.Text))
            {
                return false; // ข้อมูลไม่ครบ
            }

            // ถ้ามีเงื่อนไขอื่น ๆ ในการตรวจสอบข้อมูล ให้เพิ่มเงื่อนไขนั้นที่นี่

            return true; // ข้อมูลครบ
        }
        public NewCustomer_()
        {
            InitializeComponent();
            //กำหนดค่าให้ ComboBox เลือกรูปแบบการจอง
            SelectBookingDetail.Text = "เลือกรูปแบบการจอง";
            SelectBookingDetail.Items.Add("ขาจร");
            SelectBookingDetail.Items.Add("ขาประจำ");

            
            //CustomerTable.Hide();
            customer_ID.Focus();
            LoadCustomer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //bool hasLetter = customer_ID.Text.Any(char.IsLetter);
            int CusID;
            //โค้ดการใส่ข้อมูล
            int CheckID;
            if (IsDataComplete())
            {


                if (int.TryParse(customer_ID.Text, out CheckID))
                {

                    //สร้างออฟเจคเก็บฐานข้อมูล Customer_market.cs

                    //int CheckID = int.Parse(customer_ID.Text);

                  var existingCustomer = DB.Customer_market.SingleOrDefault(c => c.CustomerID == CheckID);
                  if (existingCustomer != null)
                  {
                        MessageBox.Show("มีรหัสผู้จองนี้ในระบบแล้ว");
                        return;
                    }
                  else { 


                    if ((CustomerIDCard.Text.Length > 13) || CustomerIDCard.Text.Length < 13)
                    {
                        MessageBox.Show("ท่านกรอกเลขบัตรประชาชนไม่สมบูรณ์");
                        return;

                    }
                    else if ((CustomerPhone.Text.Length > 10) || (CustomerPhone.Text.Length < 0))
                    {
                        MessageBox.Show("ท่านกรอกเบอร์โทรไม่สมบูรณ์");
                        return;

                    }
                    CusID = int.Parse(customer_ID.Text);
                    c.CustomerID = CusID;
                    c.CustomerID_card_number = CustomerIDCard.Text.Trim();
                    c.CustomerName = CustomerName.Text.Trim();
                    c.CustomerLastname = CustomerLastname.Text.Trim();
                    c.CustomerPhone = CustomerPhone.Text.Trim();
                    c.CustomerEmail = CustomerEmail.Text.Trim();
                    c.CustomerStatus = "Waiting for approval";
                    if (menCheck.Checked)
                    {
                        c.CustomerSex = "Man";

                        //DB.SaveChanges();
                    }
                    else if (womenCheck.Checked)
                    {
                        c.CustomerSex = "Woman";

                        //DB.SaveChanges();
                    }
                    else if (LGBT.Checked)
                    {
                        c.CustomerSex = "LGBT";

                        //DB.SaveChanges();
                    }
                    else if (menCheck.Checked == default && womenCheck.Checked == default && LGBT.Checked == default)
                    {
                        MessageBox.Show("คุณไม่ได้เลือกเพศ");
                        return;
                    }


                    if (SelectBookingDetail.SelectedItem == "ขาประจำ")
                    {
                        c.BookingDetails = "Frequenter";
                    }
                    else if (SelectBookingDetail.SelectedItem == "ขาจร")
                    {
                        c.BookingDetails = "Irregular";
                    }
                    else
                    {
                        MessageBox.Show("คุณไม่ได้เลือกรูปแบบการจอง");
                        return;
                    }



                    DB.Customer_market.Add(c);
                    DB.SaveChanges();
                    //Form ที่เข้าถึง object ได้
                    //ListCustomerCheck lc = new ListCustomerCheck();
                    //lc.ShowDialog();

                    // Form2 f2 = new Form2();
                    //f2.Show();
                    MessageBox.Show("บันทึกข้อมูลสำเร็จ", "ผลการทำงาน");

                    LoadCustomer(); //โหลดข้อมูล เห็นเป็นตาราง
                        ResetAll();
                }
                }
                MessageBox.Show("กรุณากรอกรหัสผู้จองด้วยตัวเลขเท่านั้น");
                return;

            }

            else
            {
                MessageBox.Show("กรอกข้อมูลไม่ครบ");
            } 
        }
        private void LoadCustomer()
        {
            //โค้ดการแสดงข้อมูล
            var cs = from c in DB.Customer_market
                     
                     orderby c.CustomerID descending //เรียงจากมากไปน้อย
                     select new
                     {
                         CusId = c.CustomerID,
                         CusCardID = c.CustomerID_card_number,
                         CusName = c.CustomerName,
                         CusLast = c.CustomerLastname,
                         CusSex = c.CustomerSex,
                         CusPhone = c.CustomerPhone,
                         CusEmail = c.CustomerEmail,
                         CusStatus = c.CustomerStatus
                     }; //แสดงคอลัมน์บางส่วน
            if (cs.Count() > 0)
            {
                CustomerTable.DataSource = cs.ToList();

                if (CustomerTable.RowCount > 0)
                {
                    CustomerTable.Columns[0].HeaderText = "รหัสผู้จอง";
                    CustomerTable.Columns[1].HeaderText = "เลขบัตรประชาชน";
                    CustomerTable.Columns[2].HeaderText = "ชื่อผู้จอง";
                    CustomerTable.Columns[3].HeaderText = "นามสกุลผู้จอง";
                    CustomerTable.Columns[4].HeaderText = "เพศ";
                    CustomerTable.Columns[5].HeaderText = "เบอร์โทรศัพท์";
                    CustomerTable.Columns[6].HeaderText = "อีเมล์";
                    CustomerTable.Columns[7].HeaderText = "สถานะ";

                    CustomerTable.Columns[0].Width = 80;
                    CustomerTable.Columns[1].Width = 100;
                    CustomerTable.Columns[6].Width = 120;
                    CustomerTable.Columns[7].Width = 120;
                }
            }
        }

        
       
        

        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void CustomerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void Resetbtn_Click(object sender, EventArgs e)
        { //การกดปุ่มรีเซต
            customer_ID.Text = null;
            CustomerIDCard.Text = "";
            CustomerName.Text = "";
            CustomerLastname.Text = "";
            CustomerPhone.Text = "";
            CustomerEmail.Text = "";
            womenCheck.Checked = default;
            menCheck.Checked = default;
            SelectBookingDetail.SelectedValue = null;

        }
        private void ResetAll()
        {
            //รีเซตค่าทั้งหมด
            customer_ID.Text = null;
            CustomerIDCard.Text = "";
            CustomerName.Text = "";
            CustomerLastname.Text = "";
            CustomerPhone.Text = "";
            CustomerEmail.Text = "";
            womenCheck.Checked = default;
            menCheck.Checked = default;
            SelectBookingDetail.SelectedIndex = -1;
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            int CustommID;
            if (MessageBox.Show("คุณต้องการแก้ไขรายการนี้ใช่หรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                if (customer_ID.Text != " ")
                {
                    if (int.TryParse(customer_ID.Text, out CustommID)) //แปลงจาก String => int
                    {
                        var cs = (from c in DB.Customer_market
                                  where c.CustomerID == CustommID
                                  orderby c.CustomerID descending //เรียงจากมากไปน้อย
                                  select c).FirstOrDefault();
                        //ดึงข้อมูลขึ้นมา
                        if (cs != null)
                        {

                            //c.CustomerID = int.Parse(customer_ID.Text); 
                            if ((CustomerIDCard.Text.Length > 13) || CustomerIDCard.Text.Length < 13)
                            {
                                MessageBox.Show("ท่านกรอกเลขบัตรประชาชนไม่สมบูรณ์");
                                return;

                            }
                            else if ((CustomerPhone.Text.Length > 10) || (CustomerPhone.Text.Length < 0))
                            {
                                MessageBox.Show("ท่านกรอกเบอร์โทรไม่สมบูรณ์");
                                return;

                            }
                            cs.CustomerID_card_number = CustomerIDCard.Text.Trim();
                            cs.CustomerName = CustomerName.Text.Trim();
                            cs.CustomerLastname = CustomerLastname.Text.Trim();
                            cs.CustomerPhone = CustomerPhone.Text.Trim();
                            cs.CustomerEmail = CustomerEmail.Text.Trim();
                            cs.CustomerStatus = "Waiting for approval";
                            //เลือกรูปแบบการจอง
                            if (SelectBookingDetail.SelectedItem == "ขาประจำ")
                            {
                                cs.BookingDetails = "Frequenter";
                            }
                            else if (SelectBookingDetail.SelectedItem == "ขาจร")
                            {
                                cs.BookingDetails = "Irregular";
                            }
                            else
                            {
                                MessageBox.Show("คุณไม่ได้เลือกรูปแบบการจอง");
                                return;

                            }
                            //เลือกเพศ
                            if (menCheck.Checked)
                            {
                                cs.CustomerSex = "Man";

                                //DB.SaveChanges();
                            }
                            else if (womenCheck.Checked)
                            {
                                cs.CustomerSex = "Woman";

                                //DB.SaveChanges();
                            }
                            else if (LGBT.Checked)
                            {
                                cs.CustomerSex = "LGBT";

                                //DB.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("คุณไม่ได้กรอกเพศ");
                                return;

                            }


                            using (var tr = DB.Database.BeginTransaction())
                            {
                                DB.SaveChanges();
                                tr.Commit();
                                MessageBox.Show("แก้ไขเรียบร้อยจร้า");
                                LoadCustomer();
                                ResetAll();
                            }

                        }
                        else MessageBox.Show("ไม่สามารถแก้ไขรหัสได้");
                    }

                }
            }
        }

        private void deleatebtn_Click(object sender, EventArgs e)
        {
            int CusID;
            if (MessageBox.Show("คุณต้องการลบรายการใช่หรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (int.TryParse(customer_ID.Text, out CusID))
                {
                    var cs = (from c in DB.Customer_market
                              where c.CustomerID == CusID
                              orderby c.CustomerID descending //เรียงจากมากไปน้อย
                              select c).FirstOrDefault();
                    if (cs != null)
                    {
                        DB.Customer_market.Remove(cs);
                        DB.SaveChanges();
                        
                        MessageBox.Show("ทำการลบรายการเรียบร้อย","ผลการทำงาน");
                        LoadCustomer();
                        ResetAll();
                       
                    }
                }
            }
        }

        private void CustomerTable_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

            customer_ID.Text = CustomerTable.Rows[e.RowIndex].Cells["CusId"].Value.ToString();
            CustomerIDCard.Text = CustomerTable.Rows[e.RowIndex].Cells["CusCardID"].Value.ToString();
            CustomerName.Text = CustomerTable.Rows[e.RowIndex].Cells["CusName"].Value.ToString();
            CustomerLastname.Text = CustomerTable.Rows[e.RowIndex].Cells["CusLast"].Value.ToString();
            CustomerPhone.Text = CustomerTable.Rows[e.RowIndex].Cells["CusPhone"].Value.ToString();
            CustomerEmail.Text = CustomerTable.Rows[e.RowIndex].Cells["CusEmail"].Value.ToString();

        }

        private void refreshDataBtn_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LGBT_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void customer_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectBookingDetail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
