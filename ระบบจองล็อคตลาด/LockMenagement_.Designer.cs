
namespace ระบบจองล็อคตลาด
{
    partial class LockMenagement_
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
            this.HeadText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataOfLock = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SizeSelect = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ChaprajumNum = new System.Windows.Forms.NumericUpDown();
            this.ChajornNum = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FreeStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combZone = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Locktxt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOfLock)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChaprajumNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChajornNum)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadText
            // 
            this.HeadText.AutoSize = true;
            this.HeadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadText.Location = new System.Drawing.Point(165, 59);
            this.HeadText.Name = "HeadText";
            this.HeadText.Size = new System.Drawing.Size(249, 40);
            this.HeadText.TabIndex = 29;
            this.HeadText.Text = "ระบบจัดการล็อค";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataOfLock);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.HeadText);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(123, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1679, 944);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_logo_black_on_transparent_background;
            this.pictureBox2.Location = new System.Drawing.Point(20, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1404, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "*ลบได้เฉพาะล็อคที่มีสถานะว่างเท่านั้น";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Image = global::ระบบจองล็อคตลาด.Properties.Resources.history2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1326, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 47);
            this.button1.TabIndex = 32;
            this.button1.Text = "สถานะล็อค";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataOfLock
            // 
            this.dataOfLock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOfLock.Location = new System.Drawing.Point(97, 364);
            this.dataOfLock.Name = "dataOfLock";
            this.dataOfLock.RowHeadersWidth = 62;
            this.dataOfLock.RowTemplate.Height = 28;
            this.dataOfLock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOfLock.Size = new System.Drawing.Size(987, 396);
            this.dataOfLock.TabIndex = 31;
            this.dataOfLock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataOfLock_CellFormatting);
            this.dataOfLock.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataOfLock_CellMouseUp);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SizeSelect);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.FreeStatus);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.combZone);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Locktxt);
            this.panel2.Location = new System.Drawing.Point(131, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1426, 216);
            this.panel2.TabIndex = 30;
            // 
            // SizeSelect
            // 
            this.SizeSelect.FormattingEnabled = true;
            this.SizeSelect.Location = new System.Drawing.Point(162, 137);
            this.SizeSelect.Name = "SizeSelect";
            this.SizeSelect.Size = new System.Drawing.Size(220, 28);
            this.SizeSelect.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(27, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(369, 46);
            this.label11.TabIndex = 38;
            this.label11.Text = "*รูปแบบการกรอกรหัสล็อค : รหัสโซน ตัวเลขตามลำดับ สามารถดูรหัสโซนตัวอย่างได้จาก \"สถ" +
    "านะล็อค\"";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ChaprajumNum);
            this.panel3.Controls.Add(this.ChajornNum);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(875, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 178);
            this.panel3.TabIndex = 36;
            // 
            // ChaprajumNum
            // 
            this.ChaprajumNum.Location = new System.Drawing.Point(229, 123);
            this.ChaprajumNum.Name = "ChaprajumNum";
            this.ChaprajumNum.Size = new System.Drawing.Size(176, 26);
            this.ChaprajumNum.TabIndex = 79;
            // 
            // ChajornNum
            // 
            this.ChajornNum.Location = new System.Drawing.Point(229, 65);
            this.ChajornNum.Name = "ChajornNum";
            this.ChajornNum.Size = new System.Drawing.Size(176, 26);
            this.ChajornNum.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(437, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 29);
            this.label10.TabIndex = 42;
            this.label10.Text = "บาท ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(107, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "ขาประจำ : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "ขาจร : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(437, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 29);
            this.label9.TabIndex = 41;
            this.label9.Text = "บาท ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 38;
            this.label6.Text = "ราคาล็อค : ";
            // 
            // FreeStatus
            // 
            this.FreeStatus.AutoSize = true;
            this.FreeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreeStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.FreeStatus.Location = new System.Drawing.Point(570, 141);
            this.FreeStatus.Name = "FreeStatus";
            this.FreeStatus.Size = new System.Drawing.Size(51, 29);
            this.FreeStatus.TabIndex = 35;
            this.FreeStatus.Text = "ว่าง ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "สถานะ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "ขนาดล็อค : ";
            // 
            // combZone
            // 
            this.combZone.FormattingEnabled = true;
            this.combZone.Location = new System.Drawing.Point(567, 38);
            this.combZone.Name = "combZone";
            this.combZone.Size = new System.Drawing.Size(237, 28);
            this.combZone.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "ชื่อโซน : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "รหัสล็อค : ";
            // 
            // Locktxt
            // 
            this.Locktxt.Location = new System.Drawing.Point(162, 34);
            this.Locktxt.Name = "Locktxt";
            this.Locktxt.Size = new System.Drawing.Size(209, 26);
            this.Locktxt.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(1101, 377);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(561, 120);
            this.panel4.TabIndex = 36;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = global::ระบบจองล็อคตลาด.Properties.Resources.recycle_bin;
            this.button4.Location = new System.Drawing.Point(296, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 93);
            this.button4.TabIndex = 35;
            this.button4.Text = "ลบ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Image = global::ระบบจองล็อคตลาด.Properties.Resources.broom__1_;
            this.button5.Location = new System.Drawing.Point(431, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 93);
            this.button5.TabIndex = 40;
            this.button5.Text = "ล้าง";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Image = global::ระบบจองล็อคตลาด.Properties.Resources.editing__1_;
            this.button3.Location = new System.Drawing.Point(157, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 93);
            this.button3.TabIndex = 34;
            this.button3.Text = "แก้ไข";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_color_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -428);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2058, 544);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.GreenYellow;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Image = global::ระบบจองล็อคตลาด.Properties.Resources.diskette;
            this.button6.Location = new System.Drawing.Point(17, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 93);
            this.button6.TabIndex = 41;
            this.button6.Text = "บันทึก";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // LockMenagement_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "LockMenagement_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LockMenagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LockMenagement__Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOfLock)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChaprajumNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChajornNum)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HeadText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataOfLock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Locktxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FreeStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combZone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown ChajornNum;
        private System.Windows.Forms.NumericUpDown ChaprajumNum;
        private System.Windows.Forms.ComboBox SizeSelect;
        private System.Windows.Forms.Button button6;
    }
}