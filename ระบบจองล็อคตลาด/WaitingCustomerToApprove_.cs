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
    public partial class WaitingCustomerToApprove_ : Form
    { //public Form2(CustomerData c) <= ใส่ ชื่อ object เวลามีการเชื่อมต่อ class กัน
        DB_FleamarketEntities8 DB = new DB_FleamarketEntities8();
        Customer_market c = new Customer_market();
        public WaitingCustomerToApprove_()
        {
            InitializeComponent();
            //แสดงผลเอาค่าจา object ใน Customer_market.cs
            //เชื่อมเสร็จจะเอาข้อมูลจากฐานมาใส่
            
            ShowID.Text = c.CustomerID;
            showCardID.Text = c.CustomerID_card_number;
            showFname.Text = c.CustomerName;
            showLname.Text = c.CustomerLastname;
            showEmail.Text = c.CustomerEmail;
            showPhone.Text = c.CustomerPhone;
            showSEX.Text = c.CustomerSex;
        }

      
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void approve_Click(object sender, EventArgs e)
        {
            c.CustomerStatus = "Approve";
        }

        private void Not_approved_Click(object sender, EventArgs e)
        {

        }
    }
}
