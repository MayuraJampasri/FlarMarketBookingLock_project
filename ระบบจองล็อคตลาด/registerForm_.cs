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
    public partial class registerForm_ : Form
    {
        
        //DB_FleamarketEntities DB = new DB_FleamarketEntities(); //ฐานข้อมูลต้องมีก้อนนี้

        //private Member_market m = new Member_market(); //ชื่อตารางที่่ต้องการอ้างอิง ในหน้านี้จะใช้ตาราง Member
        //private Employee_market em = new Employee_market(); //ตารางพนักงาน 
        public registerForm_()
        {
            InitializeComponent();
        }

       /* private bool IsDataComplete()
        {
            // ตรวจสอบข้อมูลที่ถูกกรอกในช่องข้อมูลที่คุณต้องการให้ครบ
            if (string.IsNullOrEmpty(memFname.Text) && string.IsNullOrEmpty(memLname.Text) && string.IsNullOrEmpty(memPhone.Text) && string.IsNullOrEmpty(memEmail.Text) && string.IsNullOrEmpty(userName.Text))
            {
                return false; // ข้อมูลไม่ครบ
            }

            // ถ้ามีเงื่อนไขอื่น ๆ ในการตรวจสอบข้อมูล ให้เพิ่มเงื่อนไขนั้นที่นี่
            return true; // ข้อมูลครบ
        }*/
        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void memberBTN_Click(object sender, EventArgs e)
        {
          /*  if (IsDataComplete())
            {

                MessageBox.Show("บันทึกข้อมูลสำเร็จ", "ผลการทำงาน");

                //สร้างออฟเจคเก็บฐานข้อมูล Member_market.cs


                //เพิ่มข้อมูลลงตาราง Member
                m.MemberID = memID.Text.Trim();
                m.MemberID_card_number = memIDcard.Text.Trim();
                m.MemberName = memFname.Text.Trim();
                m.MemberLast = memLname.Text.Trim();
                m.MemberBirthday = birthDay.Value;
                m.MemberPhone = memPhone.Text.Trim();
                m.MemberStatus = "Membership";
                m.MemberInformation = MemberInfomation.Text.Trim();
                m.MemberUsername = userName.Text.Trim();
                m.MemberEmail = memEmail.Text.Trim();

                DB.Member_market.Add(m);
                DB.SaveChanges();

                //ถ้า member ที่สมัครใหม่เป็น admin ให้ใส่ข้อมูลลงในตารางพนักงาน
                if (m.MemberUsername == "admin")
                {
                    em.EmployeeID = m.MemberID;
                    em.EmployeeID_card_number = m.MemberID_card_number;
                    em.EmployeeName = m.MemberName;
                    em.EmployeeLastname = m.MemberLast;
                    em.Employeebirthday = m.MemberBirthday;
                    em.EmployeeSex = m.MemberSex;
                    em.EmployeePhone = m.MemberPhone;
                    em.EmployeeEmail = m.MemberEmail;

                    //เพิ่มใส่ตารางพนักงาน
                    DB.Employee_market.Add(em);
                    DB.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("กรอกข้อมูลไม่ครบจร้า");
            }*/
        }

       /* private void LoadCustomer()
        {
            var ma = from m in DB.Member_market
                     where m.CustomerStatus == "Waiting for approval"
                     select m;


        }*/
        private void menCheck_CheckedChanged(object sender, EventArgs e)
        { /*
            if (menCheck.Checked)
            {
               m.MemberSex = "Man";
                DB.Member_market.Add(m);
                //DB.SaveChanges();
            }*/
        }

        private void womenCheck_CheckedChanged(object sender, EventArgs e)
        {
            /*if (womenCheck.Checked)
            {
                m.MemberSex = "Woman";
                 DB.Member_market.Add(m);
                //DB.SaveChanges();
            }*/
        }

        

        private void OrdinaryLv_CheckedChanged(object sender, EventArgs e)
        {
           /* if (OrdinaryLv.Checked)
            {
                m.MemberAccesslevel = "ธรรมดา";
                 DB.Member_market.Add(m);
            }*/
        }

        private void PremiumLV_CheckedChanged(object sender, EventArgs e)
        {
           /* if (PremiumLV.Checked)
            {
                m.MemberAccesslevel = "Premium";
                DB.Member_market.Add(m);       
            }*/
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        
    }
}
