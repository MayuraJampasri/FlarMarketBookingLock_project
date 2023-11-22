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
    public partial class LockData_ : Form
    {
        DB_FleamarketEntities DB = new DB_FleamarketEntities();//ฐานข้อมูล
        public LockData_()
        {
            InitializeComponent();
            
        }

        private void LockData__Load(object sender, EventArgs e)
        {
            var Lock = DB.Marketlocks.FirstOrDefault(cl => cl.Marketlock_ID == ShowLockID.Text);
            if (Lock != null)
            {
                if (Lock.Marketlock_Status == "Free")
                {
                    ShowLockStatus.ForeColor = Color.OliveDrab;
                }
                else if (Lock.Marketlock_Status == "Unavailable")
                {
                    ShowLockStatus.ForeColor = Color.OrangeRed;
                }

            }

        }
    }
}
