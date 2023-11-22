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
    public partial class EmployeeMenagement : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        Employee_market em = new Employee_market();
        public EmployeeMenagement()
        {
            InitializeComponent();
            LoadCustomer();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            bool hasLetter = Emp_IDtxt.Text.Any(char.IsLetter);
            bool hasDigit = Emp_IDtxt.Text.Any(char.IsDigit);
            String UpperID;

            if (Emp_IDtxt.Text == "" && Emp_ID_cardtxt.Text == "" && EmpName.Text == "" && EmpLastnametxt.Text == "" && EmpAddresstxt.Text == "" && EmpEmailtxt.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            else
            {
                if (hasLetter && hasDigit)
                {
                    /*if (Emp_ID_cardtxt.Text.Length > 13 || Emp_ID_cardtxt.Text.Length < 13)
                    {
                        MessageBox.Show("ท่านกรอกเลขบัตรประชาชนไม่ครบ");
                        return;
                    }*/
                    if (DB.Employee_market.Any(em => em.EmployeeID == Emp_IDtxt.Text))
                    {
                        MessageBox.Show("มีพนักงานรหัสนี้ในระบบแล้ว");
                        return;
                    }
                    else
                    {
                        if ((Emp_ID_cardtxt.Text.Length > 13) || Emp_ID_cardtxt.Text.Length < 13)
                        {
                            MessageBox.Show("ท่านกรอกเลขบัตรประชาชนไม่สมบูรณ์");
                            return;
                        }
                        else if ((EmpPhonetxt.Text.Length > 10) || (EmpPhonetxt.Text.Length < 0))
                        {
                            MessageBox.Show("ท่านกรอกเบอร์โทรไม่สมบูรณ์");
                            return;
                        }
                        UpperID = Emp_IDtxt.Text.Trim();
                        em.EmployeeID = UpperID.ToUpper();
                        em.EmployeeID_card_number = Emp_ID_cardtxt.Text.Trim();
                        em.EmployeeName = EmpName.Text.Trim();
                        em.EmployeeLastname = EmpLastnametxt.Text.Trim();
                        if (menCheck.Checked)
                        {
                            em.EmployeeSex = "Man";

                            //DB.SaveChanges();
                        }
                        else if (womenCheck.Checked)
                        {
                            em.EmployeeSex = "Woman";

                            //DB.SaveChanges();
                        }
                        else if (LGBTcheck.Checked)
                        {
                            em.EmployeeSex = "LGBT";

                            //DB.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("คุณไม่ได้เลือกเพศ");
                            return;
                        }
                        em.Employeebirthday = BirthDate.Value;
                        em.Employeeaddress = EmpAddresstxt.Text.Trim();
                        em.EmployeeEmail = EmpEmailtxt.Text.Trim();
                        em.EmployeePhone = EmpPhonetxt.Text.Trim();


                        DB.Employee_market.Add(em);
                        DB.SaveChanges();
                        LoadCustomer();

                    }

                }
                else
                {
                    MessageBox.Show("รหัสล็อคของคุณไม่มีรูปแบบไม่ถูกต้อง");
                }
                ClearAll();
            }
        }

        private void BirthDate_ValueChanged(object sender, EventArgs e)
        {//ฟิคปี
            BirthDate.MinDate = new DateTime(1980, 1, 1);
            BirthDate.MaxDate = new DateTime(2003, 12, 31);

        }
        private void LoadCustomer()
        {
            var ep = from e in DB.Employee_market
                     select new
                     {
                         EmpID = e.EmployeeID,
                         EmpIDcard = e.EmployeeID_card_number,
                         EmpName = e.EmployeeName,
                         EmpLname = e.EmployeeLastname,
                         Empsex = e.EmployeeSex,
                         EmpBday = e.Employeebirthday,
                         EmAdress = e.Employeeaddress,
                         EmpEmail = e.EmployeeEmail,
                         EmpPhone = e.EmployeePhone

                     };
            if (ep.Count() > 0)
            {
                dataEmployee.DataSource = ep.ToList();

                if (dataEmployee.RowCount > 0)
                {
                    dataEmployee.Columns[0].HeaderText = "รหัสพนักงาน";
                    dataEmployee.Columns[1].HeaderText = "เลขบัตรประชาชน";
                    dataEmployee.Columns[2].HeaderText = "ชื่อพนักงาน";
                    dataEmployee.Columns[3].HeaderText = "นามสกุลผู้จอง";
                    dataEmployee.Columns[4].HeaderText = "เพศ";
                    dataEmployee.Columns[5].HeaderText = "วันเกิด";
                    dataEmployee.Columns[6].HeaderText = "ที่อยู่่";
                    dataEmployee.Columns[7].HeaderText = "อีเมลล์";
                    dataEmployee.Columns[8].HeaderText = "เบอร์โทร";


                    dataEmployee.Columns[0].Width = 80;
                    dataEmployee.Columns[1].Width = 100;
                    dataEmployee.Columns[2].Width = 100;
                    dataEmployee.Columns[3].Width = 100;
                    dataEmployee.Columns[4].Width = 80;
                    dataEmployee.Columns[5].Width = 100;
                    dataEmployee.Columns[6].Width = 100;
                    dataEmployee.Columns[7].Width = 100;
                    dataEmployee.Columns[8].Width = 100;
                }
            }
        }


        private void Resetbtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            Emp_IDtxt.Text = "";
            Emp_ID_cardtxt.Text = "";
            EmpName.Text = "";
            EmpLastnametxt.Text = "";
            EmpAddresstxt.Text = "";
            EmpEmailtxt.Text = "";
            menCheck.Checked = default;
            womenCheck.Checked = default;
            LGBTcheck.Checked = default;
            BirthDate.Value = BirthDate.MaxDate;
            EmpPhonetxt.Text = "";
        }

        private void deleatebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการลบรายการใช่หรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                var ep = (from ee in DB.Employee_market
                          where ee.EmployeeID == Emp_IDtxt.Text
                          select ee).FirstOrDefault();
                if (ep != null)
                {
                    DB.Employee_market.Remove(ep);
                    DB.SaveChanges();

                    MessageBox.Show("ทำการลบรายการเรียบร้อย", "ผลการทำงาน");
                    LoadCustomer();
                    ClearAll();
                }

            }
        }

        private void dataEmployee_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Emp_IDtxt.Text = dataEmployee.Rows[e.RowIndex].Cells["EmpID"].Value.ToString(); ;
            Emp_ID_cardtxt.Text = dataEmployee.Rows[e.RowIndex].Cells["EmpIDcard"].Value.ToString(); ;
            EmpName.Text = dataEmployee.Rows[e.RowIndex].Cells["EmpName"].Value.ToString();
            EmpLastnametxt.Text = dataEmployee.Rows[e.RowIndex].Cells["EmpLname"].Value.ToString();
            EmpAddresstxt.Text = dataEmployee.Rows[e.RowIndex].Cells["EmAdress"].Value.ToString(); ;
            EmpEmailtxt.Text = dataEmployee.Rows[e.RowIndex].Cells["EmpEmail"].Value.ToString();
            EmpPhonetxt.Text = dataEmployee.Rows[e.RowIndex].Cells["EmpPhone"].Value.ToString();

            String empsexValue = dataEmployee.Rows[e.RowIndex].Cells["Empsex"].Value.ToString();
            if (e.RowIndex >= 0)
            {
                if (empsexValue == "Woman")
                {
                    womenCheck.Checked = true;
                }
                else if (empsexValue == "Man")
                {
                    menCheck.Checked = true;
                }
                else if (empsexValue == "LGBT")
                {
                    LGBTcheck.Checked = true;
                }
            }
        }

        private void EmployeeMenagement_Load(object sender, EventArgs e)
        {

        }

      /* private void Editbtn_Click_1(object sender, EventArgs e)
        {
            bool hasLetter = Emp_IDtxt.Text.Any(char.IsLetter);
            bool hasDigit = Emp_IDtxt.Text.Any(char.IsDigit);

            if (MessageBox.Show("คุณต้องการแก้ไขรายการนี้ใช่หรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //if (Emp_IDtxt.Text != "")
                // {

                if (Emp_IDtxt.Text != "" && (hasLetter && hasDigit))
                {

                    var eemp = DB.Employee_market.FirstOrDefault(ee => ee.EmployeeID == Emp_IDtxt.Text);
                    /*var eemp = (from ee in DB.Employee_market
                                where ee.EmployeeID == Emp_IDtxt.Text
                                select ee).FirstOrDefault();

                    if (eemp != null)
                    {
                        eemp.EmployeeID = Emp_IDtxt.Text.Trim();
                        eemp.EmployeeID_card_number = Emp_ID_cardtxt.Text.Trim();
                        eemp.EmployeeName = EmpName.Text.Trim();
                        eemp.EmployeeLastname = EmpLastnametxt.Text.Trim();
                        if (menCheck.Checked)
                        {
                            eemp.EmployeeSex = "Man";


                        }
                        else if (womenCheck.Checked)
                        {
                            eemp.EmployeeSex = "Woman";


                        }
                        else if (LGBTcheck.Checked)
                        {
                            eemp.EmployeeSex = "LGBT";


                        }
                        else
                        {
                            MessageBox.Show("คุณไม่ได้เลือกเพศ");
                            return;
                        }
                        eemp.Employeebirthday = BirthDate.Value;
                        eemp.Employeeaddress = EmpAddresstxt.Text.Trim();
                        eemp.EmployeeEmail = EmpEmailtxt.Text.Trim();
                        eemp.EmployeePhone = EmpPhonetxt.Text.Trim();

                        using (var tr = DB.Database.BeginTransaction())
                        {
                            DB.SaveChanges();
                            tr.Commit();
                            MessageBox.Show("แก้ไขเรียบร้อยจร้า");
                            LoadCustomer();
                            ClearAll();
                       }
                    }
                }

               /* using (var tr = DB.Database.BeginTransaction())
                {
                    try
                    {
                        // ดึงข้อมูลพนักงานจากฐานข้อมูล
                        var eemp = (from ee in DB.Employee_market
                                    where ee.EmployeeID == Emp_IDtxt.Text
                                    select ee).FirstOrDefault();

                        if (eemp != null)
                        {
                            // กำหนดค่าใหม่ให้กับพนักงาน (Employee)
                            eemp.EmployeeID = Emp_IDtxt.Text.Trim();
                            eemp.EmployeeID_card_number = Emp_ID_cardtxt.Text.Trim();
                            eemp.EmployeeName = EmpName.Text.Trim();
                            eemp.EmployeeLastname = EmpLastnametxt.Text.Trim();

                            // ตรวจสอบและกำหนดค่าเพศ
                            if (menCheck.Checked)
                            {
                                eemp.EmployeeSex = "Man";
                            }
                            else if (womenCheck.Checked)
                            {
                                eemp.EmployeeSex = "Woman";
                            }
                            else if (LGBTcheck.Checked)
                            {
                                eemp.EmployeeSex = "LGBT";
                            }
                            else
                            {
                                MessageBox.Show("คุณไม่ได้เลือกเพศ");
                                return;
                            }

                            eemp.Employeebirthday = BirthDate.Value;
                            eemp.Employeeaddress = EmpAddresstxt.Text.Trim();
                            eemp.EmployeeEmail = EmpEmailtxt.Text.Trim();
                            eemp.EmployeePhone = EmpPhonetxt.Text.Trim();

                            // บันทึกการเปลี่ยนแปลง
                            DB.SaveChanges();
                            tr.Commit();

                            MessageBox.Show("แก้ไขเรียบร้อยแล้ว");
                            LoadCustomer(); // โหลดข้อมูลใหม่จากฐานข้อมูล
                            ClearAll(); // ล้างข้อมูลในฟอร์ม
                        }
                    }
                    catch (Exception ex)
                    {
                        tr.Rollback(); // ยกเลิกการทำงานทั้งหมดในกรณีเกิดข้อผิดพลาด
                        MessageBox.Show("เกิดข้อผิดพลาดในการแก้ไข: " + ex.Message);
                    }
                    //}
                }
                }
                else MessageBox.Show("ไม่พบข้อมูล");
                //}

            }
        }*/
    }
}

