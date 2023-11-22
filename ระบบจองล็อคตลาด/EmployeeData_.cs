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
    public partial class EmployeeData_ : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();
        public EmployeeData_()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeeData_Load(object sender, EventArgs e)
        {

            FormatData();
        }

        private void FormatData()
        { //แก้ไขรูปแบบตาราง
            var emp = from em in DB.Employee_market
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
            }
        }

        private void Sherchbtn_Click(object sender, EventArgs e)
        {
            Employee_market eep = new Employee_market();

            if ((EnShearh.Text == ""))
            {
                FormatData();
                
            }
            else { 
            var emp = from em in DB.Employee_market
                      where em.EmployeeID == EnShearh.Text.Trim()
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
            }

        }

        }

    



        private void button1_Click(object sender, EventArgs e)
        {
            FormatData();
            EnShearh.Text = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataEmployee_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeEdit ee = new EmployeeEdit();
            ee.EmpID.Text = this.dataEmployee.CurrentRow.Cells["EmpID"].Value.ToString();
            ee.EmpIDcard.Text = this.dataEmployee.CurrentRow.Cells["EmpIDcard"].Value.ToString();
            ee.EmpName.Text = this.dataEmployee.CurrentRow.Cells["EmpFname"].Value.ToString();
            ee.EmpLastname.Text = this.dataEmployee.CurrentRow.Cells["EmpLname"].Value.ToString();
            ee.EmpSexx.Text = this.dataEmployee.CurrentRow.Cells["EmpSex"].Value.ToString();
            ee.BirthDay.Text = this.dataEmployee.CurrentRow.Cells["EmpBirthday"].Value.ToString();
            ee.Address.Text = this.dataEmployee.CurrentRow.Cells["EmpAddress"].Value.ToString();
            ee.Emptel.Text = this.dataEmployee.CurrentRow.Cells["EmpPhone"].Value.ToString();
            ee.EmpEmail.Text = this.dataEmployee.CurrentRow.Cells["EmpEmail"].Value.ToString();
            ee.ShowDialog();
        }
    }
}
