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
    public partial class login : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        
        
        int click = 0; //จำนวนครั้งที่กด

        //String Userpass = "a001";
        //String Owenerpass = "o001";
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            click++;
            var user = (from l in DB.Login_Account
                        where inputUser.Text == l.LoginUsername select l).FirstOrDefault();

            if (user != null && user.LoginPassword == inputPassword.Text)
            {
                if (user.LoginUsername == "admin")
                {
                    //รหัสพนักงานต้องต่อกับฐานข้อมูลพนักงาน
                    Admin a = new Admin();
                    a.ShowDialog();
                }
                else if (user.LoginUsername == "owner")
                {
                    Owner ow = new Owner();
                    ow.ShowDialog(); //ไปหน้าเจ้าของตลาด
                }
            }

            else if (inputUser.Text == "")
            {
                MessageBox.Show("กรุณากรอก Username");
            }
            else if (inputPassword.Text == "")
            {
                MessageBox.Show("กรุณากรอก Password");
            }
            else if (user == null || user.LoginPassword != inputPassword.Text || inputUser.Text != user.LoginUsername || (user.LoginPassword != inputPassword.Text && inputUser.Text != user.LoginUsername))
            {
                if (click < 4)
                {

                    MessageBox.Show("username หรือ Password ไม่ถูกต้อง \n" + "      กรอกใหม่อีกครั้ง"); //กรณีรหัสผ่านผิ
                }
                else
                {
                    DialogResult result = MessageBox.Show("คุณต้องการตั้งรหัสผ่านใหม่ไหม?", "ยืนยันการกระทำ", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    { // ผู้ใช้เลือก "ตกลง" ให้ทำอย่างที่คุณต้องการเมื่อคลิก "ตกลง" ที่นี่
                        this.Hide();
                        checkKeyword key = new checkKeyword();
                        key.ShowDialog();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("เสียใจด้วยค่ะ", "ยืนยันการกระทำ");
                        this.Hide();
                    }
                }
            }
        }
    

        private void regisBTN_Click(object sender, EventArgs e)
        {
            registerForm_ re = new registerForm_();
            re.ShowDialog();
        }

        private void inputPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                click++;

                var user = (from l in DB.Login_Account
                            where inputUser.Text == l.LoginUsername
                            select l).FirstOrDefault();

                if (user != null && user.LoginPassword == inputPassword.Text)
                {
                    if (user.LoginUsername == "admin")
                    {
                        //รหัสพนักงานต้องต่อกับฐานข้อมูลพนักงาน
                        Admin a = new Admin();
                        a.ShowDialog();
                    }
                    else if (user.LoginUsername == "owner")
                    {
                        Owner ow = new Owner();
                        ow.ShowDialog(); //ไปหน้าเจ้าของตลาด
                    }
                }

                else if (inputUser.Text == "")
                {
                    MessageBox.Show("กรุณากรอก Username");
                }
                else if (inputPassword.Text == "")
                {
                    MessageBox.Show("กรุณากรอก Password");
                }
                else if (user == null || user.LoginPassword != inputPassword.Text || inputUser.Text != user.LoginUsername || (user.LoginPassword != inputPassword.Text && inputUser.Text != user.LoginUsername))
                {
                    if (click < 4)
                    {

                        MessageBox.Show("username หรือ Password ไม่ถูกต้อง \n" + "      กรอกใหม่อีกครั้ง"); //กรณีรหัสผ่านผิด
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("คุณต้องการตั้งรหัสผ่านใหม่ไหม?", "ยืนยันการกระทำ", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        { // ผู้ใช้เลือก "ตกลง" ให้ทำอย่างที่คุณต้องการเมื่อคลิก "ตกลง" ที่นี่

                            this.Hide();
                            checkKeyword key = new checkKeyword();
                            key.ShowDialog();
                            //this.Close();
                        }
                        else
                        {
                            MessageBox.Show("เสียใจด้วยค่ะ", "ยืนยันการกระทำ");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            checkKeyword key = new checkKeyword();
            key.ShowDialog();
        }

        private void ClosePass_Click(object sender, EventArgs e)
        {
            if (inputPassword.PasswordChar == '\0')
            {
                OpenPass.BringToFront();
                inputPassword.PasswordChar = '*';
            }
        }
        
        private void openPass_Click(object sender, EventArgs e)
        {
            if (inputPassword.PasswordChar == '*')
            {
                ClosePass.BringToFront();
                inputPassword.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
                        
                    
                
            
    
    

