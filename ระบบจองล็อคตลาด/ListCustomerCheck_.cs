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
    public partial class ListCustomerCheck_ : Form
    {
        
        DB_FleamarketEntities DB = new DB_FleamarketEntities();//ฐานข้อมูล
        Customer_market c = new Customer_market();

        //public CustomerData c;
        public ListCustomerCheck_()
        { //public ListCustomerCheck(CustomerData c) <= ใส่ ชื่อ object เวลามีการเชื่อมต่อ class กัน
            InitializeComponent();
        }

        private void ListCustomerCheck_Load(object sender, EventArgs e)
        {
            //แสดงตารางข้อมูลรายชื่อคนที่กำลังอนุมัติ
            /* var cs = from c in DB.Customer_market
                      where c.CustomerStatus == "Waiting for approval"
                      orderby c.CustomerID descending //เรียงจากมากไปน้อย
                      select new
                      {
                          CusId = c.CustomerID,
                          CusName = c.CustomerName,
                          CusLast = c.CustomerLastname,
                          CusPhone = c.CustomerPhone,
                          CusIDcard = c.CustomerID_card_number,
                          CusSex = c.CustomerSex,
                          CusEmail= c.CustomerEmail,
                          CusStatus = c.CustomerStatus
                      }; //แสดงคอลัมน์บางส่วน*/

            /*if (cs.Count() > 0)
            {
                //แสดงรายการผ่านหน้าจอ
                dataGridCustomer.DataSource = cs.ToList();
                //FormatData();}*/

            LoadCustomer();
        }
        
        private void dataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ไปหน้าแสดงข้อมูลผู้จองเพิ่มเติม ส่วนนี้แหละที่เราติด

            Customer_market cs = new Customer_market();

            if (dataGridCustomer.Rows.Count == 0)
            {
                MessageBox.Show("ไม่มีรายการที่ต้องทำการอนุมัติ");
                return;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == cs.CustomerID)
                {
                    DataGridViewRow selectedRow = dataGridCustomer.Rows[e.RowIndex];
                    String data1 = selectedRow.Cells["CusId"].Value.ToString();
                    String data2 = selectedRow.Cells["CusIDcard"].Value.ToString();
                    String data3 = selectedRow.Cells["CusName"].Value.ToString();
                    String data4 = selectedRow.Cells["CusLast"].Value.ToString();
                    String data5 = selectedRow.Cells["CusSex"].Value.ToString();
                    String data6 = selectedRow.Cells["CusEmail"].Value.ToString();
                    String data7 = selectedRow.Cells["CusPhone"].Value.ToString();
                    String data8 = selectedRow.Cells["CusStatus"].Value.ToString();
                    String data9 = selectedRow.Cells["BookingT"].Value.ToString();

                    waitingCustomerData_ wc = new waitingCustomerData_(data1, data2, data3, data4, data5, data6, data7, data8, data9);
                    wc.Show();
                }
          
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReData_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadCustomer()
        {

            //โค้ดการแสดงข้อมูล
            var cs = from c in DB.Customer_market
                     where c.CustomerStatus == "Waiting for approval"
                     orderby c.CustomerID descending //เรียงจากมากไปน้อย
                     select new
                     {
                         CusId = c.CustomerID,
                         CusName = c.CustomerName,
                         CusLast = c.CustomerLastname,
                         CusPhone = c.CustomerPhone,
                         CusIDcard = c.CustomerID_card_number,
                         CusSex = c.CustomerSex,
                         CusEmail = c.CustomerEmail,
                         CusStatus = c.CustomerStatus,
                         BookingT = c.BookingDetails
                     }; //แสดงคอลัมน์บางส่วน*/
            if (cs.Count() > 0)
            {
                dataGridCustomer.DataSource = cs.ToList();

                if (dataGridCustomer.RowCount > 0)
                {
                    dataGridCustomer.Columns[0].HeaderText = "รายละเอียดเพิ่มเติม";
                    dataGridCustomer.Columns[1].HeaderText = "รหัสผู้จอง";
                    dataGridCustomer.Columns[2].HeaderText = "ชื่อผู้จอง";
                    dataGridCustomer.Columns[3].HeaderText = "นามสกุลผู้จอง";
                    dataGridCustomer.Columns[4].HeaderText = "เบอร์โทรศัพท์";
                    dataGridCustomer.Columns[5].HeaderText = "เลขบัตรประชาชน";
                    dataGridCustomer.Columns[6].HeaderText = "เพศ";
                    dataGridCustomer.Columns[7].HeaderText = "อีเมล์";
                    dataGridCustomer.Columns[8].HeaderText = "สถานะ";

                    dataGridCustomer.Columns[0].Width = 40;
                    dataGridCustomer.Columns[1].Width = 60;
                    dataGridCustomer.Columns[2].Width = 100;
                    dataGridCustomer.Columns[3].Width = 100;
                    dataGridCustomer.Columns[4].Width = 100;
                    dataGridCustomer.Columns[5].Width = 100;
                    dataGridCustomer.Columns[6].Width = 70;
                    dataGridCustomer.Columns[7].Width = 100;
                    dataGridCustomer.Columns[8].Width = 100;
                }
            }
        }

        private void Sherchbtn_Click(object sender, EventArgs e)
        {
            int SerchID;
            if (SearchBox.Text == "")
            {
                LoadCustomer();
            }
            else { 
            //โค้ดการใส่แค่รหัส ข้อมูลในตารางก็ปรากฎ


            if (int.TryParse(SearchBox.Text, out SerchID))
            {

                var result = from c in DB.Customer_market
                             where c.CustomerStatus == "Waiting for approval" && c.CustomerID == SerchID
                             select new
                             {
                                 CusId = c.CustomerID,
                                 CusName = c.CustomerName,
                                 CusLast = c.CustomerLastname,
                                 CusPhone = c.CustomerPhone,
                                 CusIDcard = c.CustomerID_card_number,
                                 CusSex = c.CustomerSex,
                                 CusEmail = c.CustomerEmail,
                                 CusStatus = c.CustomerStatus,
                                 BookingT = c.BookingDetails
                             };

                if (result.Count() > 0)
                {
                    dataGridCustomer.DataSource = result.ToList();

                    if (dataGridCustomer.RowCount > 0)
                    {
                        dataGridCustomer.Columns[0].HeaderText = "รายละเอียดเพิ่มเติม";
                        dataGridCustomer.Columns[1].HeaderText = "รหัสผู้จอง";
                        dataGridCustomer.Columns[2].HeaderText = "ชื่อผู้จอง";
                        dataGridCustomer.Columns[3].HeaderText = "นามสกุลผู้จอง";
                        dataGridCustomer.Columns[4].HeaderText = "เบอร์โทรศัพท์";
                        dataGridCustomer.Columns[5].HeaderText = "เลขบัตรประชาชน";
                        dataGridCustomer.Columns[6].HeaderText = "เพศ";
                        dataGridCustomer.Columns[7].HeaderText = "อีเมล์";
                        dataGridCustomer.Columns[8].HeaderText = "สถานะ";

                            dataGridCustomer.Columns[0].Width = 40;
                            dataGridCustomer.Columns[1].Width = 60;
                            dataGridCustomer.Columns[2].Width = 100;
                            dataGridCustomer.Columns[3].Width = 100;
                            dataGridCustomer.Columns[4].Width = 100;
                            dataGridCustomer.Columns[5].Width = 100;
                            dataGridCustomer.Columns[6].Width = 70;
                            dataGridCustomer.Columns[7].Width = 100;
                            dataGridCustomer.Columns[8].Width = 100;
                        }
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลจร้า", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            //if(SearchBox.Text == )

           }
        }
    }
}
