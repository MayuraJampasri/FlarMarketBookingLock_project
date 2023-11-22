
namespace ระบบจองล็อคตลาด
{
    partial class Owner2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomerWillCheck = new System.Windows.Forms.Button();
            this.MarketLock = new System.Windows.Forms.Button();
            this.EmployeeData = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerWillCheck
            // 
            this.CustomerWillCheck.Location = new System.Drawing.Point(169, 48);
            this.CustomerWillCheck.Name = "CustomerWillCheck";
            this.CustomerWillCheck.Size = new System.Drawing.Size(197, 79);
            this.CustomerWillCheck.TabIndex = 0;
            this.CustomerWillCheck.Text = "รายชื่อผู้รอการอนุมัติ";
            this.CustomerWillCheck.UseVisualStyleBackColor = true;
            this.CustomerWillCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // MarketLock
            // 
            this.MarketLock.Location = new System.Drawing.Point(417, 48);
            this.MarketLock.Name = "MarketLock";
            this.MarketLock.Size = new System.Drawing.Size(197, 79);
            this.MarketLock.TabIndex = 1;
            this.MarketLock.Text = "ล็อคตลาดนัด";
            this.MarketLock.UseVisualStyleBackColor = true;
            this.MarketLock.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmployeeData
            // 
            this.EmployeeData.Location = new System.Drawing.Point(169, 170);
            this.EmployeeData.Name = "EmployeeData";
            this.EmployeeData.Size = new System.Drawing.Size(197, 79);
            this.EmployeeData.TabIndex = 2;
            this.EmployeeData.Text = "ข้อมูลพนักงาน";
            this.EmployeeData.UseVisualStyleBackColor = true;
            this.EmployeeData.Click += new System.EventHandler(this.EmployeeData_Click);
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(417, 170);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(197, 79);
            this.Report.TabIndex = 3;
            this.Report.Text = "รายงานสถิติ";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(747, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 41);
            this.button5.TabIndex = 10;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_color_logo;
            this.logo.Location = new System.Drawing.Point(-98, -383);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1002, 482);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Report);
            this.panel1.Controls.Add(this.CustomerWillCheck);
            this.panel1.Controls.Add(this.MarketLock);
            this.panel1.Controls.Add(this.EmployeeData);
            this.panel1.Location = new System.Drawing.Point(42, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 282);
            this.panel1.TabIndex = 11;
            // 
            // Owner2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panel1);
            this.Name = "Owner2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner2";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Owner2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomerWillCheck;
        private System.Windows.Forms.Button MarketLock;
        private System.Windows.Forms.Button EmployeeData;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
    }
}