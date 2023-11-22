
namespace ระบบจองล็อคตลาด
{
    partial class Restaurant_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RestDataTable = new System.Windows.Forms.DataGridView();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sherchbtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.returnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RestDataTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadText
            // 
            this.HeadText.AutoSize = true;
            this.HeadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadText.Location = new System.Drawing.Point(283, 234);
            this.HeadText.Name = "HeadText";
            this.HeadText.Size = new System.Drawing.Size(239, 40);
            this.HeadText.TabIndex = 15;
            this.HeadText.Text = "โซน ร้านอาหาร";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "แนวการวางล็อค";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1048, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "ตารางข้อมูล";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.Location = new System.Drawing.Point(-3, 925);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1927, 135);
            this.panel3.TabIndex = 21;
            // 
            // RestDataTable
            // 
            this.RestDataTable.BackgroundColor = System.Drawing.Color.White;
            this.RestDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail});
            this.RestDataTable.Location = new System.Drawing.Point(1038, 363);
            this.RestDataTable.Name = "RestDataTable";
            this.RestDataTable.RowHeadersWidth = 62;
            this.RestDataTable.RowTemplate.Height = 28;
            this.RestDataTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RestDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RestDataTable.Size = new System.Drawing.Size(753, 525);
            this.RestDataTable.TabIndex = 27;
            this.RestDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RestDataTable_CellContentClick);
            this.RestDataTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RestDataTable_CellFormatting);
            // 
            // detail
            // 
            this.detail.HeaderText = "เพิ่มเติม";
            this.detail.MinimumWidth = 8;
            this.detail.Name = "detail";
            this.detail.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(139, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 525);
            this.panel1.TabIndex = 26;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.PeachPuff;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Location = new System.Drawing.Point(111, 217);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(72, 104);
            this.panel16.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Zone A";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Salmon;
            this.panel4.Controls.Add(this.panel17);
            this.panel4.Controls.Add(this.panel15);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel14);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(111, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(622, 403);
            this.panel4.TabIndex = 58;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.MistyRose;
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.label4);
            this.panel17.Location = new System.Drawing.Point(114, 104);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(394, 191);
            this.panel17.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 29);
            this.label4.TabIndex = 58;
            this.label4.Text = "บริเวณที่นั่งรับประทานอาหาร";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.PeachPuff;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Location = new System.Drawing.Point(550, 153);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(72, 104);
            this.panel15.TabIndex = 13;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.PeachPuff;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(499, 331);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(104, 72);
            this.panel10.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.PeachPuff;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(499, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(104, 72);
            this.panel9.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.PeachPuff;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Location = new System.Drawing.Point(20, 331);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(104, 72);
            this.panel11.TabIndex = 5;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.PeachPuff;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Location = new System.Drawing.Point(380, 331);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(104, 72);
            this.panel12.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PeachPuff;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(20, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(104, 72);
            this.panel5.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.PeachPuff;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Location = new System.Drawing.Point(261, 331);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(104, 72);
            this.panel13.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PeachPuff;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(380, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(104, 72);
            this.panel8.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.PeachPuff;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Location = new System.Drawing.Point(141, 331);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(104, 72);
            this.panel14.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PeachPuff;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(261, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(104, 72);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PeachPuff;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(141, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(104, 72);
            this.panel6.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::ระบบจองล็อคตลาด.Properties.Resources.cutlery;
            this.pictureBox5.Location = new System.Drawing.Point(90, 136);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(162, 138);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 57;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ระบบจองล็อคตลาด.Properties.Resources.content;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1927, 162);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Sherchbtn);
            this.panel2.Controls.Add(this.SearchBox);
            this.panel2.Location = new System.Drawing.Point(1493, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 62);
            this.panel2.TabIndex = 58;
            // 
            // Sherchbtn
            // 
            this.Sherchbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sherchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sherchbtn.Location = new System.Drawing.Point(243, 12);
            this.Sherchbtn.Name = "Sherchbtn";
            this.Sherchbtn.Size = new System.Drawing.Size(101, 34);
            this.Sherchbtn.TabIndex = 16;
            this.Sherchbtn.Text = "ค้นหา";
            this.Sherchbtn.UseVisualStyleBackColor = false;
            this.Sherchbtn.Click += new System.EventHandler(this.Sherchbtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(14, 16);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(213, 26);
            this.SearchBox.TabIndex = 2;
            // 
            // returnBtn
            // 
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.Image = global::ระบบจองล็อคตลาด.Properties.Resources.close__1_2;
            this.returnBtn.Location = new System.Drawing.Point(1774, 53);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(122, 93);
            this.returnBtn.TabIndex = 62;
            this.returnBtn.Text = "ปิด";
            this.returnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // Restaurant_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.RestDataTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeadText);
            this.Name = "Restaurant_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "restaurant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Restaurant__Load);
            ((System.ComponentModel.ISupportInitialize)(this.RestDataTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HeadText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView RestDataTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Sherchbtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button returnBtn;
    }
}