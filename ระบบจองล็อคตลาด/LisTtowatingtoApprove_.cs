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
    public partial class LisTtowatingtoApprove_ : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();//ฐานข้อมูล
        public LisTtowatingtoApprove_()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            var cs = from c in DB.Customer_market
                     where c.CustomerStatus == "Waiting for approval"
                     select new
                     {
                         CustomerId = c.CustomerID,
                         CustomerName = c.CustomerName,
                         CustomerLast = c.CustomerLastname,
                         CustomerPhone = c.CustomerPhone,
                         CustomerSEX = c.CustomerSex,
                         CustomerEmail = c.CustomerEmail
                     }; //แสดงคอลัมน์บางส่วน

            if (cs.Count() > 0)
            {
                //แสดงรายการผ่านหน้าจอ
                dataListOfcustomer.DataSource = cs.ToList();
                //FormatData();*/   
            }
        }
        private void LisTtowatingtoApprove__Load(object sender, EventArgs e)
        {

        }

        private void Sherchbtn_Click(object sender, EventArgs e)
        {
            int InputID;
            if (int.TryParse(SherchBox.Text,out InputID)) { 
            var cs = from c in DB.Customer_market
                     where c.CustomerStatus == "Waiting for approval" && c.CustomerID == InputID
                     select new
                     {
                         CustomerId = c.CustomerID,
                         CustomerName = c.CustomerName,
                         CustomerLast = c.CustomerLastname,
                         CustomerPhone = c.CustomerPhone,
                         CustomerSEX = c.CustomerSex,
                         CustomerEmail = c.CustomerEmail
                     }; //แสดงคอลัมน์บางส่วน

              if (cs.Count() > 0)
              {
                //แสดงรายการผ่านหน้าจอ
                dataListOfcustomer.DataSource = cs.ToList();
                //FormatData();*/   
               }

          }
        }

        private void refrestbtn_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
