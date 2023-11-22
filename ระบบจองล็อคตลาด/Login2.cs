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
    public partial class Login2 : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        int click = 0; //จำนวนครั้งที่กด
        String Userpass = "a001";
        String Owenerpass = "o001";
        public Login2()
        {
            InitializeComponent();
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            click++;

            var user = (from l in DB.Login_Account
                        where inputUser2.Text == l.LoginUsername
                        select l).FirstOrDefault();

            if (user != null && user.LoginPassword == inputPassword2.Text)
            {
                if (user.LoginUsername == "admin")
                {
                    this.Hide();
                    //รหัสพนักงานต้องต่อกับฐานข้อมูลพนักงาน
                    Admin a = new Admin();
                    a.ShowDialog();
                    
                }
                else if (user.LoginUsername == "owner")
                {
                    this.Hide();
                    Owner ow = new Owner();
                    ow.ShowDialog(); //ไปหน้าเจ้าของตลาด
                    
                }
            }

            else if (inputUser2.Text == "")
            {
                MessageBox.Show("กรุณากรอก Username");
            }
            else if (inputPassword2.Text == "")
            {
                MessageBox.Show("กรุณากรอก Password");
            }
            else if (user == null || user.LoginPassword != inputPassword2.Text || inputUser2.Text != user.LoginUsername || (user.LoginPassword != inputPassword2.Text && inputUser2.Text != user.LoginUsername))
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
                    }
                    else
                    {
                        MessageBox.Show("เสียใจด้วยค่ะ", "ยืนยันการกระทำ");
                        this.Hide();
                    }
                }
            }
        }

        private void Login2_Load(object sender, EventArgs e)
        {

        }

        private void inputPassword2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                click++;

                var user = (from l in DB.Login_Account
                            where inputUser2.Text == l.LoginUsername
                            select l).FirstOrDefault();

                if (user != null && user.LoginPassword == inputPassword2.Text)
                {
                    if (user.LoginUsername == "admin")
                    {
                        this.Hide();
                        //รหัสพนักงานต้องต่อกับฐานข้อมูลพนักงาน
                        Admin a = new Admin();
                        a.ShowDialog();
                    }
                    else if (user.LoginUsername == "owner")
                    {
                        this.Hide();
                        Owner ow = new Owner();
                        ow.ShowDialog(); //ไปหน้าเจ้าของตลาด
                    }
                }

                else if (inputUser2.Text == "")
                {
                    MessageBox.Show("กรุณากรอก Username");
                }
                else if (inputPassword2.Text == "")
                {
                    MessageBox.Show("กรุณากรอก Password");
                }
                else if (user == null || user.LoginPassword != inputPassword2.Text || inputUser2.Text != user.LoginUsername || (user.LoginPassword != inputPassword2.Text && inputUser2.Text != user.LoginUsername))
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
                        }
                        else
                        {
                            MessageBox.Show("เสียใจด้วยค่ะ", "ยืนยันการกระทำ");
                            
                        }
                    }
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            checkKeyword key = new checkKeyword();
            key.ShowDialog();
        }

        private void ClosePass_Click(object sender, EventArgs e)
        {
            if (inputPassword2.PasswordChar == '\0')
            {
                OpenPass.BringToFront();
                inputPassword2.PasswordChar = '*';
            }
        }

        private void OpenPass_Click(object sender, EventArgs e)
        {
            if (inputPassword2.PasswordChar == '*')
            {
                ClosePass.BringToFront();
                inputPassword2.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
