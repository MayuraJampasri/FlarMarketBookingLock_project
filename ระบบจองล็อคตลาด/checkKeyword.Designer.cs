
namespace ระบบจองล็อคตลาด
{
    partial class checkKeyword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ans1 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ans2 = new System.Windows.Forms.TextBox();
            this.clesebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "ตั้งรหัสผ่านใหม่";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "รหัสลับของบริษัทคืออะไร :";
            // 
            // Ans1
            // 
            this.Ans1.Location = new System.Drawing.Point(426, 209);
            this.Ans1.Name = "Ans1";
            this.Ans1.Size = new System.Drawing.Size(187, 26);
            this.Ans1.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Location = new System.Drawing.Point(404, 322);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(181, 49);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "เข้าสู่การตรวจสอบ";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ระบบจองล็อคตลาด.Properties.Resources.u1f914_u1f435;
            this.pictureBox1.Location = new System.Drawing.Point(342, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "สมาชิกกลุ่มนี้นิยามตนว่าอะไร :";
            // 
            // Ans2
            // 
            this.Ans2.Location = new System.Drawing.Point(457, 251);
            this.Ans2.Name = "Ans2";
            this.Ans2.Size = new System.Drawing.Size(187, 26);
            this.Ans2.TabIndex = 9;
            this.Ans2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ans2_KeyDown);
            // 
            // clesebtn
            // 
            this.clesebtn.Location = new System.Drawing.Point(260, 322);
            this.clesebtn.Name = "clesebtn";
            this.clesebtn.Size = new System.Drawing.Size(127, 49);
            this.clesebtn.TabIndex = 12;
            this.clesebtn.Text = "ปิด";
            this.clesebtn.UseVisualStyleBackColor = true;
            this.clesebtn.Click += new System.EventHandler(this.clesebtn_Click);
            // 
            // checkKeyword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.clesebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ans2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ans1);
            this.Controls.Add(this.label1);
            this.Name = "checkKeyword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkKeyword";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.checkKeyword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ans1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ans2;
        private System.Windows.Forms.Button clesebtn;
    }
}