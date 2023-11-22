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
    public partial class NewPassword : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        //login l = new login();
        public NewPassword()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String NewPassword;

            /*if (username.Text == "admin" || username.Text == "owner")
            {
                String SetnewADPass = newPass.Text; //รหัสใหม่

                login lg = new login();
                lg.Show();
            }*/ //เขียนเงื่อนไขการเปลี่ยนรหัสใหม่ เมื่อเลือก user เสร็จ ให้ทำการใส่รหัสผ่านใหม่ จากนั้นกด ยื่นยันรหัสใหม่ ทำการตรวจสอบ โดย check ที่ database สร้างโดยสร้างตัวแปรเก็บค่า Username แล้วนำค่าใน username ในตัวแปรไปตรวจสอบกับค่าในคอลัมน์ LoginUsername ว่าถ้าตรงกันก็ทำการใส่ค่ารหัสผ่านใหม่ในช่องรหัสผ่าน
            if(Adminradio.Checked)
            {
                NewPassword = "admin";
                var NewPassUser = (from l in DB.Login_Account 
                                   where l.LoginUsername == NewPassword
                                   select l).FirstOrDefault();
                if (NewPassUser != null)
                {
                    NewPassUser.LoginPassword = newPasstxt.Text;

                    DB.SaveChanges();
                    MessageBox.Show("บันทึกรหัสใหม่สำเร็จ");

                    this.Hide();
                    login lg = new login();
                    lg.ShowDialog(); 
                }
                else
                {
                    MessageBox.Show("ไม่พบเจอ Username ที่ท่านต้องการ");
                }
            }
            else if (Ownerradio.Checked)
            {
                NewPassword = "owner";
                var NewPassUser = (from l in DB.Login_Account
                                   where l.LoginUsername == NewPassword
                                   select l).FirstOrDefault();
                if (NewPassUser != null)
                {
                    NewPassUser.LoginPassword = newPasstxt.Text;
                    DB.SaveChanges();
                    MessageBox.Show("บันทึกรหัสใหม่สำเร็จ");

                    this.Hide();
                    login lg = new login();
                    lg.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ไม่พบเจอ Username ที่ท่านต้องการ");
                    return;
                }
            }
            else
            {
                MessageBox.Show("จงเลือกตำแหน่งงานของท่าน");
                return;
            }

            if (newPasstxt.Text == "")
            {
                MessageBox.Show("จงกรอกรหัสผ่านใหม่ของท่าน");
                return;
            }
            else if (newPasstxt.Text == "" && (Adminradio.Checked == default || Ownerradio.Checked == default))
            {
                MessageBox.Show("จงกรอกให้ครบถ้วน");
                return;
            }

        }

        private void NewPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
