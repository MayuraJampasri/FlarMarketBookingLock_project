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
    public partial class NewCutomer : UserControl
    {
        private Customer_market c = new Customer_market(); //ก้อนตารางที่่ต้องการอ้างอิง

        DB_FleamarketEntities3 DB = new DB_FleamarketEntities3(); //ฐานข้อมูลต้องมีก้อนนี้

        private bool IsDataComplete()
        {
            // ตรวจสอบข้อมูลที่ถูกกรอกในช่องข้อมูลที่คุณต้องการให้ครบ
            if (string.IsNullOrEmpty(CustomerID.Text) && string.IsNullOrEmpty(CustomerName.Text) && string.IsNullOrEmpty(CustomerLastname.Text) && string.IsNullOrEmpty(CustomerPhone.Text) && string.IsNullOrEmpty(CustomerEmail.Text))
            {
                return false; // ข้อมูลไม่ครบ
            }

            // ถ้ามีเงื่อนไขอื่น ๆ ในการตรวจสอบข้อมูล ให้เพิ่มเงื่อนไขนั้นที่นี่

            return true; // ข้อมูลครบ
        }
        public NewCutomer()
        {
            InitializeComponent();
        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewCutomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsDataComplete())
            {

                MessageBox.Show("บันทึกข้อมูลสำเร็จ", "ผลการทำงาน");

                //สร้างออฟเจคเก็บฐานข้อมูล Customer_market.cs


                //เพิ่มข้อมูลลงตาราง

                c.CustomerID = CustomerID.Text.Trim();
                c.CustomerID_card_number = CustomerIDCard.Text.Trim();
                c.CustomerName = CustomerName.Text.Trim();
                c.CustomerLastname = CustomerLastname.Text.Trim();
                c.CustomerPhone = CustomerPhone.Text.Trim();
                c.CustomerEmail = CustomerEmail.Text.Trim();
                c.CustomerStatus = labelStatus.Text.Trim();

                DB.Customer_market.Add(c);
                DB.SaveChanges();
                //Form ที่เข้าถึง object ได้
                //ListCustomerCheck lc = new ListCustomerCheck();
                //lc.ShowDialog();

                // Form2 f2 = new Form2();
                //f2.Show();

                LoadCustomer(); //โหลดข้อมูล เห็นเป็นตาราง
            }
            else
            {
                MessageBox.Show("กรอกข้อมูลไม่ครบ");
            }
        }
        private void LoadCustomer()
        {
            var cs = from c in DB.Customer_market
                     where c.CustomerStatus == "Waiting for approval"
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
            }
        }

        private void menCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (menCheck.Checked)
            {
                c.CustomerSex = "Man";
                DB.Customer_market.Add(c);
                //DB.SaveChanges();
            }

        }
        private void womenCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (womenCheck.Checked)
            {
                c.CustomerSex = "Woman";
                DB.Customer_market.Add(c);
                //DB.SaveChanges();
            }
        }

        private void CustomerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
