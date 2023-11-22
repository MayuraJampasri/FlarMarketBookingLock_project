
namespace ระบบจองล็อคตลาด
{
    partial class CustomerList_
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
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sherchbtn = new System.Windows.Forms.Button();
            this.ApproveSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "รายชื่อผู้ที่ถูกอนุมัติแล้ว";
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.AllowUserToAddRows = false;
            this.dataGridCustomer.AllowUserToDeleteRows = false;
            this.dataGridCustomer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Location = new System.Drawing.Point(123, 240);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.ReadOnly = true;
            this.dataGridCustomer.RowHeadersWidth = 62;
            this.dataGridCustomer.RowTemplate.Height = 28;
            this.dataGridCustomer.Size = new System.Drawing.Size(957, 764);
            this.dataGridCustomer.TabIndex = 5;
            this.dataGridCustomer.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCustomer_CellMouseUp);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Sherchbtn);
            this.panel1.Controls.Add(this.ApproveSearch);
            this.panel1.Location = new System.Drawing.Point(744, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 62);
            this.panel1.TabIndex = 6;
            // 
            // Sherchbtn
            // 
            this.Sherchbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sherchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sherchbtn.Location = new System.Drawing.Point(278, 13);
            this.Sherchbtn.Name = "Sherchbtn";
            this.Sherchbtn.Size = new System.Drawing.Size(101, 34);
            this.Sherchbtn.TabIndex = 17;
            this.Sherchbtn.Text = "ค้นหา";
            this.Sherchbtn.UseVisualStyleBackColor = false;
            this.Sherchbtn.Click += new System.EventHandler(this.Sherchbtn_Click);
            // 
            // ApproveSearch
            // 
            this.ApproveSearch.Location = new System.Drawing.Point(22, 19);
            this.ApproveSearch.Name = "ApproveSearch";
            this.ApproveSearch.Size = new System.Drawing.Size(250, 26);
            this.ApproveSearch.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridCustomer);
            this.panel2.Location = new System.Drawing.Point(351, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1201, 1028);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ระบบจองล็อคตลาด.Properties.Resources.flea_market_low_resolution_color_logo;
            this.pictureBox2.Location = new System.Drawing.Point(98, -316);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1002, 394);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // CustomerList_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel2);
            this.Name = "CustomerList_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ApproveSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Sherchbtn;
    }
}