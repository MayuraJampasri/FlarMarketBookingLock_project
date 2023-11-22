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
    public partial class CustomerWaitForApprove : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        public CustomerWaitForApprove()
        {
            InitializeComponent();
        }

        private void CustomerWaitForApprove_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        private void ShowData()
        {
            var cs = from c in DB.Customer_market
                     where c.CustomerStatus == "Waiting for approval"
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
                DataOfCustomer.DataSource = cs.ToList();

                if (DataOfCustomer.RowCount > 0)
                {
                    DataOfCustomer.Columns[0].HeaderText = "รหัสผู้จอง";
                    DataOfCustomer.Columns[1].HeaderText = "เลขบัตรประชาชน";
                    DataOfCustomer.Columns[2].HeaderText = "ชื่อผู้จอง";
                    DataOfCustomer.Columns[3].HeaderText = "นามสกุลผู้จอง";
                    DataOfCustomer.Columns[4].HeaderText = "เพศ";
                    DataOfCustomer.Columns[5].HeaderText = "เบอร์โทรศัพท์";
                    DataOfCustomer.Columns[6].HeaderText = "อีเมล์";
                    DataOfCustomer.Columns[7].HeaderText = "สถานะ";

                    DataOfCustomer.Columns[0].Width = 80;
                    DataOfCustomer.Columns[1].Width = 100;
                    DataOfCustomer.Columns[6].Width = 120;
                    DataOfCustomer.Columns[7].Width = 120;
                }
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sherchbtn_Click(object sender, EventArgs e)
        {
            int InputID;

            if(textSherch.Text == "")
            {
                ShowData();
            }
            if (int.TryParse(textSherch.Text,out InputID)) { 
            var cs = from c in DB.Customer_market
                     where c.CustomerStatus == "Waiting for approval" && c.CustomerID == InputID
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
                DataOfCustomer.DataSource = cs.ToList();

                if (DataOfCustomer.RowCount > 0)
                {
                    DataOfCustomer.Columns[0].HeaderText = "รหัสผู้จอง";
                    DataOfCustomer.Columns[1].HeaderText = "เลขบัตรประชาชน";
                    DataOfCustomer.Columns[2].HeaderText = "ชื่อผู้จอง";
                    DataOfCustomer.Columns[3].HeaderText = "นามสกุลผู้จอง";
                    DataOfCustomer.Columns[4].HeaderText = "เพศ";
                    DataOfCustomer.Columns[5].HeaderText = "เบอร์โทรศัพท์";
                    DataOfCustomer.Columns[6].HeaderText = "อีเมล์";
                    DataOfCustomer.Columns[7].HeaderText = "สถานะ";

                    DataOfCustomer.Columns[0].Width = 80;
                    DataOfCustomer.Columns[1].Width = 100;
                    DataOfCustomer.Columns[6].Width = 120;
                    DataOfCustomer.Columns[7].Width = 120;
                }
            }

          }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
