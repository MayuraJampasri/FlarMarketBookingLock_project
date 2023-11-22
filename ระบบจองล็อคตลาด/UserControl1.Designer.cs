
namespace ระบบจองล็อคตลาด
{
    partial class NewCutomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomerIDCard = new System.Windows.Forms.TextBox();
            this.womenCheck = new System.Windows.Forms.RadioButton();
            this.menCheck = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Maroon;
            this.labelStatus.Location = new System.Drawing.Point(682, 262);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(205, 25);
            this.labelStatus.TabIndex = 42;
            this.labelStatus.Text = "Waiting for approval";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(619, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "สถานะ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "รหัสผู้จอง :";
            // 
            // CustomerIDCard
            // 
            this.CustomerIDCard.Location = new System.Drawing.Point(769, 113);
            this.CustomerIDCard.Name = "CustomerIDCard";
            this.CustomerIDCard.Size = new System.Drawing.Size(187, 26);
            this.CustomerIDCard.TabIndex = 39;
            // 
            // womenCheck
            // 
            this.womenCheck.AutoSize = true;
            this.womenCheck.Location = new System.Drawing.Point(294, 224);
            this.womenCheck.Name = "womenCheck";
            this.womenCheck.Size = new System.Drawing.Size(62, 24);
            this.womenCheck.TabIndex = 30;
            this.womenCheck.TabStop = true;
            this.womenCheck.Text = "หญิง";
            this.womenCheck.UseVisualStyleBackColor = true;
            // 
            // menCheck
            // 
            this.menCheck.AutoSize = true;
            this.menCheck.Location = new System.Drawing.Point(211, 224);
            this.menCheck.Name = "menCheck";
            this.menCheck.Size = new System.Drawing.Size(58, 24);
            this.menCheck.TabIndex = 29;
            this.menCheck.TabStop = true;
            this.menCheck.Text = "ชาย";
            this.menCheck.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(992, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 40);
            this.button1.TabIndex = 38;
            this.button1.Text = "ตรวจสอบการอนุมัติ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Email :";
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.Location = new System.Drawing.Point(211, 335);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(187, 26);
            this.CustomerEmail.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "เบอร์โทรศัพท์ :";
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.Location = new System.Drawing.Point(211, 278);
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.Size = new System.Drawing.Size(187, 26);
            this.CustomerPhone.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "เพศ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "นามสกุล :";
            // 
            // CustomerLastname
            // 
            this.CustomerLastname.Location = new System.Drawing.Point(769, 166);
            this.CustomerLastname.Name = "CustomerLastname";
            this.CustomerLastname.Size = new System.Drawing.Size(187, 26);
            this.CustomerLastname.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "ชื่อ :";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(211, 174);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(187, 26);
            this.CustomerName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "เลขที่บัตรประชาชน :";
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(211, 118);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(187, 26);
            this.CustomerID.TabIndex = 24;
            this.CustomerID.TextChanged += new System.EventHandler(this.CustomerID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "ผู้เข้ามาจองใหม่";
            // 
            // CustomerTable
            // 
            this.CustomerTable.AllowUserToAddRows = false;
            this.CustomerTable.AllowUserToDeleteRows = false;
            this.CustomerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerTable.Location = new System.Drawing.Point(3, 504);
            this.CustomerTable.Name = "CustomerTable";
            this.CustomerTable.ReadOnly = true;
            this.CustomerTable.RowHeadersWidth = 62;
            this.CustomerTable.RowTemplate.Height = 28;
            this.CustomerTable.Size = new System.Drawing.Size(1174, 387);
            this.CustomerTable.TabIndex = 43;
            this.CustomerTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerTable_CellContentClick);
            // 
            // NewCutomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomerTable);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CustomerIDCard);
            this.Controls.Add(this.womenCheck);
            this.Controls.Add(this.menCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CustomerEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomerPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerLastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.label1);
            this.Name = "NewCutomer";
            this.Size = new System.Drawing.Size(1180, 806);
            this.Load += new System.EventHandler(this.NewCutomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CustomerIDCard;
        private System.Windows.Forms.RadioButton womenCheck;
        private System.Windows.Forms.RadioButton menCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustomerEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustomerPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CustomerTable;
    }
}
