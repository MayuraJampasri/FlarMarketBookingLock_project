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
    public partial class EmployeeEdit : Form
    {
        private static EmployeeData_ employeeData;

        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        
        //DataGridView dataEmployee = employeeData.dataEmployee;
        public EmployeeEdit()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            
        }
        private void LoadCustomer()
        {
            /*var emp = from em in DB.Employee_market
                      select new
                      {
                          EmpID = em.EmployeeID,
                          EmpIDcard = em.EmployeeID_card_number,
                          EmpFname = em.EmployeeName,
                          EmpLname = em.EmployeeLastname,
                          EmpSex = em.EmployeeSex,
                          EmpBirthday = em.Employeebirthday.Value,
                          EmpAddress = em.Employeeaddress,
                          EmpPhone = em.EmployeePhone,
                          EmpEmail = em.EmployeeEmail
                      }; //แสดงคอลัมน์บางส่วน

            if (emp.Count() > 0)
            {
                //แสดงรายการผ่านหน้าจอ
                dataEmployee.DataSource = emp.ToList();
                if (dataEmployee.RowCount > 0)
                {
                    dataEmployee.Columns[0].HeaderText = "รหัสพนักงาน";
                    dataEmployee.Columns[1].HeaderText = "เลขบัตรประชาชน";
                    dataEmployee.Columns[2].HeaderText = "ชื่อพนักงาน";
                    dataEmployee.Columns[3].HeaderText = "นามสกุลพนักงาน";
                    dataEmployee.Columns[4].HeaderText = "เพศ";
                    dataEmployee.Columns[5].HeaderText = "วันเดือนปีเกิด";
                    dataEmployee.Columns[6].HeaderText = "ที่อยู่พนักงาน";
                    dataEmployee.Columns[7].HeaderText = "เบอร์โทรศัพท์";
                    dataEmployee.Columns[8].HeaderText = "อีเมลล์";

                    dataEmployee.Columns[1].Width = 100;
                    dataEmployee.Columns[3].Width = 100;

                }
            }*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการแก้ไขรายการนี้ใช่หรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (EmpID.Text != " ")
                {
                    var emp = (from em in DB.Employee_market
                              where em.EmployeeID == EmpID.Text.Trim()
                              select em).FirstOrDefault();

                    if (emp != null)
                    {
                        emp.EmployeeID_card_number = EmpIDcard.Text.Trim();
                        emp.EmployeeName = EmpName.Text.Trim();
                        emp.EmployeeLastname = EmpLastname.Text.Trim();
                        emp.Employeeaddress = Address.Text.Trim();
                        emp.EmployeePhone = Emptel.Text.Trim();
                        emp.EmployeeEmail = EmpEmail.Text.Trim();

                        using (var tr = DB.Database.BeginTransaction())
                        {
                            DB.SaveChanges();
                            tr.Commit();
                            MessageBox.Show("แก้ไขเรียบร้อยจร้า");
                            LoadCustomer();
                            //ResetAll();
                        }
                    }
                }

                }
            }

        private void EmployeeEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
