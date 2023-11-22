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
    public partial class CustomerList_ : Form
    {
        public CustomerList_()
        {
            InitializeComponent();
        }
        //สร้าง obj ฐานข้อมูล DB_FleamarketEntities
        DB_FleamarketEntities DB = new DB_FleamarketEntities();

        private void CustomerList_Load(object sender, EventArgs e)
        {
            //c == ตัวแทนดึงข้อมูล ,DB.Customer_market ชื่อตาราง
            //var cs = from c in DB.Customer_market select c; //ดึงมาทั้งหมด

            FormatData();

        }
        private void FormatData ()
        { //แก้ไขรูปแบบตาราง
            var cs = from c in DB.Customer_market
                     where c.CustomerStatus == "Approve" && c.CustomerLog_ID == null
                     orderby c.CustomerID descending
                     select new
                     {
                         CusId = c.CustomerID,
                         CusName = c.CustomerName,
                         CusLast = c.CustomerLastname,
                         CusPhone = c.CustomerPhone,
                         CusEmail = c.CustomerEmail,
                         CusStatus = c.CustomerStatus
                     }; //แสดงคอลัมน์บางส่วน

            if (cs.Count() > 0)
            {
                //แสดงรายการผ่านหน้าจอ
                dataGridCustomer.DataSource = cs.ToList();
                if (dataGridCustomer.RowCount > 0)
                {
                    dataGridCustomer.Columns[0].HeaderText = "รหัสผู้จอง";
                    dataGridCustomer.Columns[1].HeaderText = "ชื่อผู้จอง";
                    dataGridCustomer.Columns[2].HeaderText = "นามผู้จอง";
                    dataGridCustomer.Columns[3].HeaderText = "เบอร์โทรศัพท์";
                    dataGridCustomer.Columns[4].HeaderText = "Email";
                    dataGridCustomer.Columns[5].HeaderText = "สถานะ";

                    dataGridCustomer.Columns[0].Width = 80;
                    dataGridCustomer.Columns[1].Width = 100;
                    dataGridCustomer.Columns[2].Width = 100;
                    dataGridCustomer.Columns[3].Width = 90;
                    dataGridCustomer.Columns[4].Width = 100;
                    dataGridCustomer.Columns[4].Width = 100;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void Sherchbtn_Click(object sender, EventArgs e)
        {
            Customer_market cu = new Customer_market();
            int searchID;
            if (ApproveSearch.Text == "")
            {
                FormatData();
            }
            if (int.TryParse(ApproveSearch.Text, out searchID))
            {
                var result = from c in DB.Customer_market
                             where c.CustomerStatus == "Approve" && c.CustomerLog_ID == null && c.CustomerID == searchID
                             orderby c.CustomerID descending
                             select new
                             {
                                 CusId = c.CustomerID,
                                 CusName = c.CustomerName,
                                 CusLast = c.CustomerLastname,
                                 CusPhone = c.CustomerPhone,
                                 CusEmail = c.CustomerEmail,
                                 CusStatus = c.CustomerStatus
                             }; //แสดงคอลัมน์บางส่วน

                if (result.Count() > 0)
                {
                    //แสดงรายการผ่านหน้าจอ
                    dataGridCustomer.DataSource = result.ToList();
                    if (dataGridCustomer.RowCount > 0)
                    {
                        dataGridCustomer.Columns[0].HeaderText = "รหัสผู้จอง";
                        dataGridCustomer.Columns[1].HeaderText = "ชื่อผู้จอง";
                        dataGridCustomer.Columns[2].HeaderText = "นามผู้จอง";
                        dataGridCustomer.Columns[3].HeaderText = "เบอร์โทรศัพท์";
                        dataGridCustomer.Columns[4].HeaderText = "Email";
                        dataGridCustomer.Columns[5].HeaderText = "สถานะ";

                        dataGridCustomer.Columns[0].Width = 80;
                        dataGridCustomer.Columns[1].Width = 100;
                        dataGridCustomer.Columns[2].Width = 100;
                        dataGridCustomer.Columns[3].Width = 90;
                        dataGridCustomer.Columns[4].Width = 100;
                        dataGridCustomer.Columns[4].Width = 100;
                    }
                }

                   

            }
            
        }

        private void dataGridCustomer_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dataGridCustomer.Rows[e.RowIndex].cells["CusId"].Value;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        { //ทำปุ่มลบ
            if (MessageBox.Show("คุณต้องการลบรายการใช่หรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dataGridCustomer.SelectedRows.Count > 0)
                {
                    // ดึงรหัสลูกค้าที่ถูกเลือกใน DataGridView
                    string selectedCustomer = dataGridCustomer.Rows[0].Cells["CusName"].Value.ToString();

                    // ค้นหาลูกค้าโดยใช้รหัสลูกค้า
                    var cs = (from c in DB.Customer_market
                              where c.CustomerName == selectedCustomer
                              select c).FirstOrDefault();
                    //var customer = DB.Customer_market.FirstOrDefault(c => c.CustomerName == selectedCustomer);

                    if (cs != null)
                    {
                        // ลบลูกค้าจากฐานข้อมูล
                        DB.Customer_market.Remove(cs);
                        DB.SaveChanges();

                        // ลบแถวที่ถูกเลือกใน DataGridView
                        //dataGridCustomer.Rows.RemoveAt(0);
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลลูกค้า");
                    }
                }
                else
                {
                    MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบ", "คำแนะนำ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
}
