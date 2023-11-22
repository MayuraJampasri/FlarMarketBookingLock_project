
namespace ระบบจองล็อคตลาด
{
    partial class LisTtowatingtoApprove_
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refrestbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sherchbtn = new System.Windows.Forms.Button();
            this.SherchBox = new System.Windows.Forms.TextBox();
            this.dataListOfcustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListOfcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_color_logo;
            this.pictureBox1.Location = new System.Drawing.Point(189, -63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1001, 232);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.refrestbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataListOfcustomer);
            this.panel1.Location = new System.Drawing.Point(280, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 1068);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // refrestbtn
            // 
            this.refrestbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refrestbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refrestbtn.Location = new System.Drawing.Point(774, 221);
            this.refrestbtn.Name = "refrestbtn";
            this.refrestbtn.Size = new System.Drawing.Size(101, 34);
            this.refrestbtn.TabIndex = 36;
            this.refrestbtn.Text = "รีเฟรซ";
            this.refrestbtn.UseVisualStyleBackColor = false;
            this.refrestbtn.Click += new System.EventHandler(this.refrestbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "รายชื่อผู้รอการอนุมัติ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Sherchbtn);
            this.panel2.Controls.Add(this.SherchBox);
            this.panel2.Location = new System.Drawing.Point(891, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 62);
            this.panel2.TabIndex = 34;
            // 
            // Sherchbtn
            // 
            this.Sherchbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sherchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sherchbtn.Image = global::ระบบจองล็อคตลาด.Properties.Resources.search;
            this.Sherchbtn.Location = new System.Drawing.Point(274, 14);
            this.Sherchbtn.Name = "Sherchbtn";
            this.Sherchbtn.Size = new System.Drawing.Size(101, 34);
            this.Sherchbtn.TabIndex = 36;
            this.Sherchbtn.Text = "ค้นหา";
            this.Sherchbtn.UseVisualStyleBackColor = false;
            this.Sherchbtn.Click += new System.EventHandler(this.Sherchbtn_Click);
            // 
            // SherchBox
            // 
            this.SherchBox.Location = new System.Drawing.Point(13, 18);
            this.SherchBox.Name = "SherchBox";
            this.SherchBox.Size = new System.Drawing.Size(250, 26);
            this.SherchBox.TabIndex = 2;
            // 
            // dataListOfcustomer
            // 
            this.dataListOfcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListOfcustomer.Location = new System.Drawing.Point(189, 294);
            this.dataListOfcustomer.Name = "dataListOfcustomer";
            this.dataListOfcustomer.RowHeadersWidth = 62;
            this.dataListOfcustomer.RowTemplate.Height = 28;
            this.dataListOfcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListOfcustomer.Size = new System.Drawing.Size(959, 774);
            this.dataListOfcustomer.TabIndex = 11;
            // 
            // LisTtowatingtoApprove_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Name = "LisTtowatingtoApprove_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LisTtowatingtoApprove";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LisTtowatingtoApprove__Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListOfcustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataListOfcustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SherchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sherchbtn;
        private System.Windows.Forms.Button refrestbtn;
    }
}