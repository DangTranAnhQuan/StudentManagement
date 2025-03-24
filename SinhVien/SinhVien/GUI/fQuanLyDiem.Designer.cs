namespace SinhVien.GUI
{
    partial class fQuanLyDiem
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
<<<<<<< HEAD
            this.dgv = new System.Windows.Forms.DataGridView();
            this.grb_ChamDiem = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnMark = new System.Windows.Forms.Button();
            this.txb_DiemQT = new System.Windows.Forms.TextBox();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_DiemQT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_DiemCK = new System.Windows.Forms.TextBox();
            this.lbl_DiemCK = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txb_DiemTB = new System.Windows.Forms.TextBox();
            this.lbl_DiemTB = new System.Windows.Forms.Label();
            this.btn_Xuat = new System.Windows.Forms.Button();
            this.lbl_MaSV = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbb_LopHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_DiemTBLop = new System.Windows.Forms.TextBox();
            this.lbl_DiemTBLop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grb_ChamDiem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(30, 306);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1502, 539);
            this.dgv.TabIndex = 0;
            // 
            // grb_ChamDiem
            // 
            this.grb_ChamDiem.BackColor = System.Drawing.Color.DarkGreen;
            this.grb_ChamDiem.Controls.Add(this.lbl_DiemTBLop);
            this.grb_ChamDiem.Controls.Add(this.txb_DiemTBLop);
            this.grb_ChamDiem.Controls.Add(this.cbb_LopHoc);
            this.grb_ChamDiem.Controls.Add(this.label3);
            this.grb_ChamDiem.Controls.Add(this.textBox2);
            this.grb_ChamDiem.Controls.Add(this.textBox1);
            this.grb_ChamDiem.Controls.Add(this.lbl_MaSV);
            this.grb_ChamDiem.Controls.Add(this.btn_Xuat);
            this.grb_ChamDiem.Controls.Add(this.txb_DiemTB);
            this.grb_ChamDiem.Controls.Add(this.lbl_DiemTB);
            this.grb_ChamDiem.Controls.Add(this.btn_Sua);
            this.grb_ChamDiem.Controls.Add(this.btn_TimKiem);
            this.grb_ChamDiem.Controls.Add(this.txb_DiemCK);
            this.grb_ChamDiem.Controls.Add(this.lbl_DiemCK);
            this.grb_ChamDiem.Controls.Add(this.dtpDate);
            this.grb_ChamDiem.Controls.Add(this.btnMark);
            this.grb_ChamDiem.Controls.Add(this.txb_DiemQT);
            this.grb_ChamDiem.Controls.Add(this.cboCourse);
            this.grb_ChamDiem.Controls.Add(this.label4);
            this.grb_ChamDiem.Controls.Add(this.lbl_DiemQT);
            this.grb_ChamDiem.Controls.Add(this.label2);
            this.grb_ChamDiem.Controls.Add(this.label1);
            this.grb_ChamDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_ChamDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ChamDiem.ForeColor = System.Drawing.Color.White;
            this.grb_ChamDiem.Location = new System.Drawing.Point(0, 0);
            this.grb_ChamDiem.Name = "grb_ChamDiem";
            this.grb_ChamDiem.Size = new System.Drawing.Size(1556, 300);
            this.grb_ChamDiem.TabIndex = 2;
            this.grb_ChamDiem.TabStop = false;
            this.grb_ChamDiem.Text = "Chấm điểm";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(1190, 51);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(137, 28);
            this.dtpDate.TabIndex = 4;
            // 
            // btnMark
            // 
            this.btnMark.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMark.ForeColor = System.Drawing.Color.Black;
            this.btnMark.Location = new System.Drawing.Point(896, 243);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(134, 39);
            this.btnMark.TabIndex = 3;
            this.btnMark.Text = "Chấm điểm";
            this.btnMark.UseVisualStyleBackColor = false;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // txb_DiemQT
            // 
            this.txb_DiemQT.Location = new System.Drawing.Point(662, 110);
            this.txb_DiemQT.Name = "txb_DiemQT";
            this.txb_DiemQT.Size = new System.Drawing.Size(59, 28);
            this.txb_DiemQT.TabIndex = 2;
            this.txb_DiemQT.TextChanged += new System.EventHandler(this.txb_DiemQT_TextChanged);
            this.txb_DiemQT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_DiemQT_KeyPress);
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(177, 50);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(304, 30);
            this.cboCourse.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1048, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày chấm:";
            // 
            // lbl_DiemQT
            // 
            this.lbl_DiemQT.AutoSize = true;
            this.lbl_DiemQT.Location = new System.Drawing.Point(562, 113);
            this.lbl_DiemQT.Name = "lbl_DiemQT";
            this.lbl_DiemQT.Size = new System.Drawing.Size(87, 22);
            this.lbl_DiemQT.TabIndex = 0;
            this.lbl_DiemQT.Text = "Điểm QT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sinh viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.panel1.Size = new System.Drawing.Size(1556, 857);
            this.panel1.TabIndex = 3;
            // 
            // txb_DiemCK
            // 
            this.txb_DiemCK.Location = new System.Drawing.Point(907, 110);
            this.txb_DiemCK.Name = "txb_DiemCK";
            this.txb_DiemCK.Size = new System.Drawing.Size(59, 28);
            this.txb_DiemCK.TabIndex = 6;
            this.txb_DiemCK.TextChanged += new System.EventHandler(this.txb_DiemCK_TextChanged);
            this.txb_DiemCK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_DiemCK_KeyPress);
            // 
            // lbl_DiemCK
            // 
            this.lbl_DiemCK.AutoSize = true;
            this.lbl_DiemCK.Location = new System.Drawing.Point(790, 113);
            this.lbl_DiemCK.Name = "lbl_DiemCK";
            this.lbl_DiemCK.Size = new System.Drawing.Size(86, 22);
            this.lbl_DiemCK.TabIndex = 5;
            this.lbl_DiemCK.Text = "Điểm CK:";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Location = new System.Drawing.Point(1067, 243);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(134, 39);
            this.btn_TimKiem.TabIndex = 7;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Location = new System.Drawing.Point(1241, 243);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(134, 39);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Chỉnh sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // txb_DiemTB
            // 
            this.txb_DiemTB.Location = new System.Drawing.Point(1190, 110);
            this.txb_DiemTB.Name = "txb_DiemTB";
            this.txb_DiemTB.ReadOnly = true;
            this.txb_DiemTB.Size = new System.Drawing.Size(59, 28);
            this.txb_DiemTB.TabIndex = 10;
            this.txb_DiemTB.TextChanged += new System.EventHandler(this.txb_DiemTB_TextChanged);
            // 
            // lbl_DiemTB
            // 
            this.lbl_DiemTB.AutoSize = true;
            this.lbl_DiemTB.Location = new System.Drawing.Point(1048, 113);
            this.lbl_DiemTB.Name = "lbl_DiemTB";
            this.lbl_DiemTB.Size = new System.Drawing.Size(85, 22);
            this.lbl_DiemTB.TabIndex = 9;
            this.lbl_DiemTB.Text = "Điểm TB:";
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Xuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xuat.ForeColor = System.Drawing.Color.Black;
            this.btn_Xuat.Location = new System.Drawing.Point(1410, 243);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(134, 39);
            this.btn_Xuat.TabIndex = 11;
            this.btn_Xuat.Text = "Xuất file excel";
            this.btn_Xuat.UseVisualStyleBackColor = false;
            // 
            // lbl_MaSV
            // 
            this.lbl_MaSV.AutoSize = true;
            this.lbl_MaSV.Location = new System.Drawing.Point(48, 175);
            this.lbl_MaSV.Name = "lbl_MaSV";
            this.lbl_MaSV.Size = new System.Drawing.Size(115, 22);
            this.lbl_MaSV.TabIndex = 12;
            this.lbl_MaSV.Text = "Mã sinh viên:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 28);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(304, 28);
            this.textBox2.TabIndex = 14;
            // 
            // cbb_LopHoc
            // 
            this.cbb_LopHoc.FormattingEnabled = true;
            this.cbb_LopHoc.Location = new System.Drawing.Point(662, 50);
            this.cbb_LopHoc.Name = "cbb_LopHoc";
            this.cbb_LopHoc.Size = new System.Drawing.Size(304, 30);
            this.cbb_LopHoc.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Lớp học:";
            // 
            // txb_DiemTBLop
            // 
            this.txb_DiemTBLop.Location = new System.Drawing.Point(1387, 88);
            this.txb_DiemTBLop.Multiline = true;
            this.txb_DiemTBLop.Name = "txb_DiemTBLop";
            this.txb_DiemTBLop.ReadOnly = true;
            this.txb_DiemTBLop.Size = new System.Drawing.Size(136, 70);
            this.txb_DiemTBLop.TabIndex = 17;
            // 
            // lbl_DiemTBLop
            // 
            this.lbl_DiemTBLop.AutoSize = true;
            this.lbl_DiemTBLop.Location = new System.Drawing.Point(1383, 54);
            this.lbl_DiemTBLop.Name = "lbl_DiemTBLop";
            this.lbl_DiemTBLop.Size = new System.Drawing.Size(149, 22);
            this.lbl_DiemTBLop.TabIndex = 18;
            this.lbl_DiemTBLop.Text = "Điểm TB của Lớp";
=======
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý điểm";
>>>>>>> AnThien
            // 
            // fQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1556, 857);
            this.Controls.Add(this.grb_ChamDiem);
            this.Controls.Add(this.panel1);
            this.Name = "fQuanLyDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grb_ChamDiem.ResumeLayout(false);
            this.grb_ChamDiem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
=======
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Name = "fQuanLyDiem";
            this.Text = "fQuanLyDiem";
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> AnThien

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox grb_ChamDiem;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.TextBox txb_DiemQT;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_DiemQT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_DiemCK;
        private System.Windows.Forms.Label lbl_DiemCK;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txb_DiemTB;
        private System.Windows.Forms.Label lbl_DiemTB;
        private System.Windows.Forms.Button btn_Xuat;
        private System.Windows.Forms.Label lbl_MaSV;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbb_LopHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_DiemTBLop;
        private System.Windows.Forms.TextBox txb_DiemTBLop;
=======
        private System.Windows.Forms.Label label1;
>>>>>>> AnThien
    }
}