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
    public partial class waitingCustomerData_ : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();

        Customer_market c = new Customer_market();
        public waitingCustomerData_(String data1, String data2, String data3, String data4, String data5, String data6, String data7, String data8, String data9)
        {
            InitializeComponent();
            //การนำเอาค่าจากตารางฟอร์มอื่นมาใส่ในฟอร์มนี้

            ShowCusID.Text = data1;
            ShowCusIDCard.Text = data2;
            ShowName.Text = data3;
            ShowLastname.Text = data4;
            ShowSEX.Text = data5;
            ShowEmail.Text = data6;
            ShowTel.Text = data7;
            ShowStatus.Text = data8;
            BookingTypetxt.Text = data9;
        }

        private void Approvebtn_Click(object sender, EventArgs e)
        {
            if (ShowStatus.Text == "Waiting for approval")
            {

                // ค้นหาลูกค้าโดยใช้รหัสลูกค้า
                int customerId = int.Parse(ShowCusID.Text); // แปลงรหัสลูกค้าเป็น int
                var customer = DB.Customer_market.FirstOrDefault(c => c.CustomerID == customerId);

                if (customer != null)
                {
                    // เปลี่ยนสถานะของลูกค้า
                    customer.CustomerStatus = "Approve";

                    // บันทึกการเปลี่ยนแปลงลงในฐานข้อมูล
                    DB.SaveChanges();

                    // อัพเดตสถานะที่แสดงในฟอร์ม
                    ShowStatus.Text = "Approve";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลลูกค้า");
                }
                //เมื่อกดทำการอนุมัติให้กดไปที่ปุ่มรายชื่อที่อนุมัติแล้ว
            }  
        }


     
    
       

        private void NotApprove_Click(object sender, EventArgs e)
        {
            if (ShowStatus.Text == "Waiting for approval")
            {

                // ค้นหาลูกค้าโดยใช้รหัสลูกค้า
                int customerId = int.Parse(ShowCusID.Text); // แปลงรหัสลูกค้าเป็น int
                var customer = DB.Customer_market.FirstOrDefault(c => c.CustomerID == customerId);

                if (customer != null)
                {
                    // เปลี่ยนสถานะของลูกค้า
                    customer.CustomerStatus = "Not Approve";

                    // บันทึกการเปลี่ยนแปลงลงในฐานข้อมูล
                    DB.SaveChanges();

                    // อัพเดตสถานะที่แสดงในฟอร์ม
                    ShowStatus.Text = "Not Approve";
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลลูกค้า");
                }
                //เมื่อกดทำการอนุมัติให้กดไปที่ปุ่มรายชื่อที่อนุมัติแล้ว
            }
        }

        private void waitingCustomerData__Load(object sender, EventArgs e)
        {

        }
    }
}
