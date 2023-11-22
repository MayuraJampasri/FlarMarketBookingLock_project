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
    public partial class checkKeyword : Form
    {
        int clickCount = 0;
        
        public checkKeyword()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            clickCount++;

            if(Ans1.Text == "1234" && Ans2.Text == "ลิง" || Ans2.Text == "Monkey" || Ans2.Text == "monkey")
                {
                this.Hide();
                NewPassword NP = new NewPassword();
                NP.ShowDialog();

            }
            else if (Ans1.Text == "")
            {
                if(clickCount < 2) {
                    MessageBox.Show($"กรุณากรอกให้ครบ ไม่งั้นจะไม่สามารถเปลี่ยนรหัสใหม่ได้");
                    return;
                }
                else
                {
                    EndResult();
                }
                
            }
            else if (Ans2.Text == "")
            {
                if (clickCount < 2)
                {
                    MessageBox.Show($"กรุณากรอกให้ครบ ไม่งั้นจะไม่สามารถเปลี่ยนรหัสใหม่ได้");
                    return;
                }
                else
                {
                    EndResult();
                }
            }
            else if (((Ans1.Text == "" && Ans2.Text == "")))
            {
                if (clickCount < 2)
                {
                    MessageBox.Show($"กรุณากรอกให้ครบ ไม่งั้นจะไม่สามารถเปลี่ยนรหัสใหม่ได้");
                    return;
                }
                else
                {
                    EndResult();
                }
            }
            else if(Ans1.Text != "1234" && Ans2.Text != "ลิง" || Ans2.Text != "Monkey" || Ans2.Text != "monkey")
            {

                    MessageBox.Show($"รหัสลับไม่ถูกต้องจร้า โปรดกรอกใหม่");
                    return;
            }
        }
        private void EndResult()
        {
            MessageBox.Show("เสียใจด้วย");
            this.Hide();
            login lg = new login();
            lg.ShowDialog();
        }
        private void checkKeyword_Load(object sender, EventArgs e)
        {

        }

        private void Ans2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clickCount++;

                if (Ans1.Text == "1234" && Ans2.Text == "ลิง" || Ans2.Text == "Monkey" || Ans2.Text == "monkey")
                {
                    this.Hide();
                    NewPassword NP = new NewPassword();
                    NP.ShowDialog();

                }
                else if (Ans1.Text == "")
                {
                    if (clickCount < 2)
                    {
                        MessageBox.Show($"กรุณากรอกให้ครบ ไม่งั้นจะไม่สามารถเปลี่ยนรหัสใหม่ได้");
                        return;
                    }
                    else
                    {
                        EndResult();
                    }
                }
                else if (Ans2.Text == "")
                {
                    if (clickCount < 2)
                    {
                        MessageBox.Show($"กรุณากรอกให้ครบ ไม่งั้นจะไม่สามารถเปลี่ยนรหัสใหม่ได้");
                        return;
                    }
                    else
                    {
                        EndResult();
                    }
                }
                else if (((Ans1.Text == "" && Ans2.Text == "")))
                {
                    if (clickCount < 2)
                    {
                        MessageBox.Show($"กรุณากรอกให้ครบ ไม่งั้นจะไม่สามารถเปลี่ยนรหัสใหม่ได้");
                        return;
                    }
                    else
                    {
                        EndResult();
                    }
                }
                else 
                {
                    if (clickCount < 2)
                    {
                        MessageBox.Show($"รหัสลับไม่ถูกต้องจร้า โปรดกรอกใหม่");
                        return;
                    }
                    else
                    {
                        EndResult();
                    }

                }
            }
        }

        private void clesebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.ShowDialog();
        }
    }
}
