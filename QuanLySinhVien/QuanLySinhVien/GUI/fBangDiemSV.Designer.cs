namespace QuanLySinhVien.GUI
{
    partial class fBangDiemSV
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
            this.numPhanTramThi = new System.Windows.Forms.NumericUpDown();
            this.numPhanTramLop = new System.Windows.Forms.NumericUpDown();
            this.lbl_PhanTramThi = new System.Windows.Forms.Label();
            this.lbl_PhanTramLop = new System.Windows.Forms.Label();
            this.dtgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_DiemLop = new System.Windows.Forms.Label();
            this.txb_MaMonHoc = new System.Windows.Forms.TextBox();
            this.lbl_MaMonHoc = new System.Windows.Forms.Label();
            this.txb_MaSV = new System.Windows.Forms.TextBox();
            this.lbl_MaSV = new System.Windows.Forms.Label();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_DiemLop = new System.Windows.Forms.TextBox();
            this.txb_DiemThi = new System.Windows.Forms.TextBox();
            this.lbl_DiemThi = new System.Windows.Forms.Label();
            this.txb_DiemTB = new System.Windows.Forms.TextBox();
            this.lbl_DiemTB = new System.Windows.Forms.Label();
            this.txb_XepLoai = new System.Windows.Forms.TextBox();
            this.lbl_XepLoai = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MonHoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numPhanTramThi
            // 
            this.numPhanTramThi.Location = new System.Drawing.Point(141, 68);
            this.numPhanTramThi.Name = "numPhanTramThi";
            this.numPhanTramThi.Size = new System.Drawing.Size(59, 30);
            this.numPhanTramThi.TabIndex = 4;
            // 
            // numPhanTramLop
            // 
            this.numPhanTramLop.Location = new System.Drawing.Point(786, 12);
            this.numPhanTramLop.Name = "numPhanTramLop";
            this.numPhanTramLop.Size = new System.Drawing.Size(59, 30);
            this.numPhanTramLop.TabIndex = 3;
            // 
            // lbl_PhanTramThi
            // 
            this.lbl_PhanTramThi.AutoSize = true;
            this.lbl_PhanTramThi.Location = new System.Drawing.Point(8, 72);
            this.lbl_PhanTramThi.Name = "lbl_PhanTramThi";
            this.lbl_PhanTramThi.Size = new System.Drawing.Size(119, 22);
            this.lbl_PhanTramThi.TabIndex = 12;
            this.lbl_PhanTramThi.Text = "Phần trăm thi:";
            // 
            // lbl_PhanTramLop
            // 
            this.lbl_PhanTramLop.AutoSize = true;
            this.lbl_PhanTramLop.Location = new System.Drawing.Point(643, 16);
            this.lbl_PhanTramLop.Name = "lbl_PhanTramLop";
            this.lbl_PhanTramLop.Size = new System.Drawing.Size(126, 22);
            this.lbl_PhanTramLop.TabIndex = 10;
            this.lbl_PhanTramLop.Text = "Phần trăm lớp:";
            // 
            // dtgv_MonHoc
            // 
            this.dtgv_MonHoc.AllowUserToAddRows = false;
            this.dtgv_MonHoc.AllowUserToDeleteRows = false;
            this.dtgv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_MonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dtgv_MonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_MonHoc.Location = new System.Drawing.Point(0, 0);
            this.dtgv_MonHoc.MultiSelect = false;
            this.dtgv_MonHoc.Name = "dtgv_MonHoc";
            this.dtgv_MonHoc.ReadOnly = true;
            this.dtgv_MonHoc.RowHeadersVisible = false;
            this.dtgv_MonHoc.RowHeadersWidth = 51;
            this.dtgv_MonHoc.RowTemplate.Height = 30;
            this.dtgv_MonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_MonHoc.Size = new System.Drawing.Size(902, 376);
            this.dtgv_MonHoc.TabIndex = 1;
            this.dtgv_MonHoc.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgv_MonHoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 376);
            this.panel2.TabIndex = 9;
            // 
            // lbl_DiemLop
            // 
            this.lbl_DiemLop.AutoSize = true;
            this.lbl_DiemLop.Location = new System.Drawing.Point(223, 72);
            this.lbl_DiemLop.Name = "lbl_DiemLop";
            this.lbl_DiemLop.Size = new System.Drawing.Size(91, 22);
            this.lbl_DiemLop.TabIndex = 7;
            this.lbl_DiemLop.Text = "Điểm lớp:";
            // 
            // txb_MaMonHoc
            // 
            this.txb_MaMonHoc.Location = new System.Drawing.Point(496, 12);
            this.txb_MaMonHoc.MaxLength = 255;
            this.txb_MaMonHoc.Name = "txb_MaMonHoc";
            this.txb_MaMonHoc.Size = new System.Drawing.Size(129, 30);
            this.txb_MaMonHoc.TabIndex = 2;
            // 
            // lbl_MaMonHoc
            // 
            this.lbl_MaMonHoc.AutoSize = true;
            this.lbl_MaMonHoc.Location = new System.Drawing.Point(373, 16);
            this.lbl_MaMonHoc.Name = "lbl_MaMonHoc";
            this.lbl_MaMonHoc.Size = new System.Drawing.Size(113, 22);
            this.lbl_MaMonHoc.TabIndex = 4;
            this.lbl_MaMonHoc.Text = "Mã môn học:";
            // 
            // txb_MaSV
            // 
            this.txb_MaSV.Location = new System.Drawing.Point(228, 12);
            this.txb_MaSV.MaxLength = 255;
            this.txb_MaSV.Name = "txb_MaSV";
            this.txb_MaSV.Size = new System.Drawing.Size(128, 30);
            this.txb_MaSV.TabIndex = 1;
            // 
            // lbl_MaSV
            // 
            this.lbl_MaSV.AutoSize = true;
            this.lbl_MaSV.Location = new System.Drawing.Point(109, 16);
            this.lbl_MaSV.Name = "lbl_MaSV";
            this.lbl_MaSV.Size = new System.Drawing.Size(118, 22);
            this.lbl_MaSV.TabIndex = 2;
            this.lbl_MaSV.Text = "Mã sinh viên:";
            // 
            // txb_ID
            // 
            this.txb_ID.Enabled = false;
            this.txb_ID.Location = new System.Drawing.Point(50, 12);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(52, 30);
            this.txb_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txb_XepLoai);
            this.panel1.Controls.Add(this.lbl_XepLoai);
            this.panel1.Controls.Add(this.txb_DiemTB);
            this.panel1.Controls.Add(this.lbl_DiemTB);
            this.panel1.Controls.Add(this.txb_DiemThi);
            this.panel1.Controls.Add(this.lbl_DiemThi);
            this.panel1.Controls.Add(this.txb_DiemLop);
            this.panel1.Controls.Add(this.numPhanTramThi);
            this.panel1.Controls.Add(this.numPhanTramLop);
            this.panel1.Controls.Add(this.lbl_PhanTramThi);
            this.panel1.Controls.Add(this.lbl_PhanTramLop);
            this.panel1.Controls.Add(this.lbl_DiemLop);
            this.panel1.Controls.Add(this.txb_MaMonHoc);
            this.panel1.Controls.Add(this.lbl_MaMonHoc);
            this.panel1.Controls.Add(this.txb_MaSV);
            this.panel1.Controls.Add(this.lbl_MaSV);
            this.panel1.Controls.Add(this.txb_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 126);
            this.panel1.TabIndex = 8;
            // 
            // txb_DiemLop
            // 
            this.txb_DiemLop.Location = new System.Drawing.Point(320, 68);
            this.txb_DiemLop.MaxLength = 255;
            this.txb_DiemLop.Name = "txb_DiemLop";
            this.txb_DiemLop.Size = new System.Drawing.Size(53, 30);
            this.txb_DiemLop.TabIndex = 5;
            // 
            // txb_DiemThi
            // 
            this.txb_DiemThi.Location = new System.Drawing.Point(485, 68);
            this.txb_DiemThi.MaxLength = 255;
            this.txb_DiemThi.Name = "txb_DiemThi";
            this.txb_DiemThi.Size = new System.Drawing.Size(53, 30);
            this.txb_DiemThi.TabIndex = 6;
            // 
            // lbl_DiemThi
            // 
            this.lbl_DiemThi.AutoSize = true;
            this.lbl_DiemThi.Location = new System.Drawing.Point(388, 72);
            this.lbl_DiemThi.Name = "lbl_DiemThi";
            this.lbl_DiemThi.Size = new System.Drawing.Size(84, 22);
            this.lbl_DiemThi.TabIndex = 14;
            this.lbl_DiemThi.Text = "Điểm thi:";
            // 
            // txb_DiemTB
            // 
            this.txb_DiemTB.Location = new System.Drawing.Point(665, 68);
            this.txb_DiemTB.MaxLength = 255;
            this.txb_DiemTB.Name = "txb_DiemTB";
            this.txb_DiemTB.Size = new System.Drawing.Size(53, 30);
            this.txb_DiemTB.TabIndex = 7;
            // 
            // lbl_DiemTB
            // 
            this.lbl_DiemTB.AutoSize = true;
            this.lbl_DiemTB.Location = new System.Drawing.Point(568, 72);
            this.lbl_DiemTB.Name = "lbl_DiemTB";
            this.lbl_DiemTB.Size = new System.Drawing.Size(89, 22);
            this.lbl_DiemTB.TabIndex = 16;
            this.lbl_DiemTB.Text = "Điểm TB:";
            // 
            // txb_XepLoai
            // 
            this.txb_XepLoai.Location = new System.Drawing.Point(837, 68);
            this.txb_XepLoai.MaxLength = 255;
            this.txb_XepLoai.Name = "txb_XepLoai";
            this.txb_XepLoai.Size = new System.Drawing.Size(53, 30);
            this.txb_XepLoai.TabIndex = 8;
            // 
            // lbl_XepLoai
            // 
            this.lbl_XepLoai.AutoSize = true;
            this.lbl_XepLoai.Location = new System.Drawing.Point(740, 72);
            this.lbl_XepLoai.Name = "lbl_XepLoai";
            this.lbl_XepLoai.Size = new System.Drawing.Size(85, 22);
            this.lbl_XepLoai.TabIndex = 18;
            this.lbl_XepLoai.Text = "Xếp loại:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MÃ SINH VIÊN";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 190;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MÃ MÔN HỌC";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 190;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PHẦN TRĂM LỚP";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "PHẦN TRĂM THI";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ĐIỂM LỚP";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 180;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ĐIỂM THI";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "XẾP LOẠI";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // fBangDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fBangDiemSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng điểm sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MonHoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPhanTramThi;
        private System.Windows.Forms.NumericUpDown numPhanTramLop;
        private System.Windows.Forms.Label lbl_PhanTramThi;
        private System.Windows.Forms.Label lbl_PhanTramLop;
        private System.Windows.Forms.DataGridView dtgv_MonHoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_DiemLop;
        private System.Windows.Forms.TextBox txb_MaMonHoc;
        private System.Windows.Forms.Label lbl_MaMonHoc;
        private System.Windows.Forms.TextBox txb_MaSV;
        private System.Windows.Forms.Label lbl_MaSV;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_XepLoai;
        private System.Windows.Forms.Label lbl_XepLoai;
        private System.Windows.Forms.TextBox txb_DiemTB;
        private System.Windows.Forms.Label lbl_DiemTB;
        private System.Windows.Forms.TextBox txb_DiemThi;
        private System.Windows.Forms.Label lbl_DiemThi;
        private System.Windows.Forms.TextBox txb_DiemLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}