namespace QuanLySinhVien.GUI
{
    partial class fQuanLyMonHoc
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
            this.lbl_TietLyThuyet = new System.Windows.Forms.Label();
            this.lbl_SoTinChi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.num_SoTinChi = new System.Windows.Forms.NumericUpDown();
            this.btn_Tailai = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txb_TenLop = new System.Windows.Forms.TextBox();
            this.lbl_TenMonHoc = new System.Windows.Forms.Label();
            this.txb_MaMonHoc = new System.Windows.Forms.TextBox();
            this.lbl_MaMonHoc = new System.Windows.Forms.Label();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numTietThucHanh = new System.Windows.Forms.NumericUpDown();
            this.numTietLyThuyet = new System.Windows.Forms.NumericUpDown();
            this.lbl_TietThucHanh = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoTinChi)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTietThucHanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietLyThuyet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TietLyThuyet
            // 
            this.lbl_TietLyThuyet.AutoSize = true;
            this.lbl_TietLyThuyet.Location = new System.Drawing.Point(8, 68);
            this.lbl_TietLyThuyet.Name = "lbl_TietLyThuyet";
            this.lbl_TietLyThuyet.Size = new System.Drawing.Size(119, 22);
            this.lbl_TietLyThuyet.TabIndex = 10;
            this.lbl_TietLyThuyet.Text = "Tiết lý thuyết:";
            // 
            // lbl_SoTinChi
            // 
            this.lbl_SoTinChi.AutoSize = true;
            this.lbl_SoTinChi.Location = new System.Drawing.Point(438, 68);
            this.lbl_SoTinChi.Name = "lbl_SoTinChi";
            this.lbl_SoTinChi.Size = new System.Drawing.Size(91, 22);
            this.lbl_SoTinChi.TabIndex = 7;
            this.lbl_SoTinChi.Text = "Số tín chỉ:";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgv_MonHoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 446);
            this.panel2.TabIndex = 7;
            // 
            // dtgv_MonHoc
            // 
            this.dtgv_MonHoc.AllowUserToAddRows = false;
            this.dtgv_MonHoc.AllowUserToDeleteRows = false;
            this.dtgv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_MonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgv_MonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_MonHoc.Location = new System.Drawing.Point(0, 0);
            this.dtgv_MonHoc.MultiSelect = false;
            this.dtgv_MonHoc.Name = "dtgv_MonHoc";
            this.dtgv_MonHoc.ReadOnly = true;
            this.dtgv_MonHoc.RowHeadersVisible = false;
            this.dtgv_MonHoc.RowHeadersWidth = 51;
            this.dtgv_MonHoc.RowTemplate.Height = 30;
            this.dtgv_MonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_MonHoc.Size = new System.Drawing.Size(618, 446);
            this.dtgv_MonHoc.TabIndex = 1;
            this.dtgv_MonHoc.TabStop = false;
            // 
            // num_SoTinChi
            // 
            this.num_SoTinChi.Location = new System.Drawing.Point(541, 64);
            this.num_SoTinChi.Name = "num_SoTinChi";
            this.num_SoTinChi.Size = new System.Drawing.Size(59, 30);
            this.num_SoTinChi.TabIndex = 5;
            // 
            // btn_Tailai
            // 
            this.btn_Tailai.Location = new System.Drawing.Point(432, 109);
            this.btn_Tailai.Name = "btn_Tailai";
            this.btn_Tailai.Size = new System.Drawing.Size(98, 32);
            this.btn_Tailai.TabIndex = 6;
            this.btn_Tailai.TabStop = false;
            this.btn_Tailai.Text = "Làm mới";
            this.btn_Tailai.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(328, 109);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(98, 32);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.TabStop = false;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(224, 109);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(98, 32);
            this.btn_Sua.TabIndex = 4;
            this.btn_Sua.TabStop = false;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(120, 109);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 32);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.TabStop = false;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // txb_TenLop
            // 
            this.txb_TenLop.Location = new System.Drawing.Point(485, 12);
            this.txb_TenLop.MaxLength = 255;
            this.txb_TenLop.Name = "txb_TenLop";
            this.txb_TenLop.Size = new System.Drawing.Size(129, 30);
            this.txb_TenLop.TabIndex = 2;
            // 
            // lbl_TenMonHoc
            // 
            this.lbl_TenMonHoc.AutoSize = true;
            this.lbl_TenMonHoc.Location = new System.Drawing.Point(362, 16);
            this.lbl_TenMonHoc.Name = "lbl_TenMonHoc";
            this.lbl_TenMonHoc.Size = new System.Drawing.Size(117, 22);
            this.lbl_TenMonHoc.TabIndex = 4;
            this.lbl_TenMonHoc.Text = "Tên môn học:";
            // 
            // txb_MaMonHoc
            // 
            this.txb_MaMonHoc.Location = new System.Drawing.Point(228, 12);
            this.txb_MaMonHoc.MaxLength = 255;
            this.txb_MaMonHoc.Name = "txb_MaMonHoc";
            this.txb_MaMonHoc.Size = new System.Drawing.Size(128, 30);
            this.txb_MaMonHoc.TabIndex = 1;
            // 
            // lbl_MaMonHoc
            // 
            this.lbl_MaMonHoc.AutoSize = true;
            this.lbl_MaMonHoc.Location = new System.Drawing.Point(109, 16);
            this.lbl_MaMonHoc.Name = "lbl_MaMonHoc";
            this.lbl_MaMonHoc.Size = new System.Drawing.Size(113, 22);
            this.lbl_MaMonHoc.TabIndex = 2;
            this.lbl_MaMonHoc.Text = "Mã môn học:";
            // 
            // txb_ID
            // 
            this.txb_ID.Enabled = false;
            this.txb_ID.Location = new System.Drawing.Point(50, 12);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(52, 30);
            this.txb_ID.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numTietThucHanh);
            this.panel1.Controls.Add(this.numTietLyThuyet);
            this.panel1.Controls.Add(this.lbl_TietThucHanh);
            this.panel1.Controls.Add(this.lbl_TietLyThuyet);
            this.panel1.Controls.Add(this.num_SoTinChi);
            this.panel1.Controls.Add(this.lbl_SoTinChi);
            this.panel1.Controls.Add(this.btn_Tailai);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.txb_TenLop);
            this.panel1.Controls.Add(this.lbl_TenMonHoc);
            this.panel1.Controls.Add(this.txb_MaMonHoc);
            this.panel1.Controls.Add(this.lbl_MaMonHoc);
            this.panel1.Controls.Add(this.txb_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 156);
            this.panel1.TabIndex = 6;
            // 
            // numTietThucHanh
            // 
            this.numTietThucHanh.Location = new System.Drawing.Point(353, 64);
            this.numTietThucHanh.Name = "numTietThucHanh";
            this.numTietThucHanh.Size = new System.Drawing.Size(59, 30);
            this.numTietThucHanh.TabIndex = 4;
            // 
            // numTietLyThuyet
            // 
            this.numTietLyThuyet.Location = new System.Drawing.Point(133, 64);
            this.numTietLyThuyet.Name = "numTietLyThuyet";
            this.numTietLyThuyet.Size = new System.Drawing.Size(59, 30);
            this.numTietLyThuyet.TabIndex = 3;
            // 
            // lbl_TietThucHanh
            // 
            this.lbl_TietThucHanh.AutoSize = true;
            this.lbl_TietThucHanh.Location = new System.Drawing.Point(220, 68);
            this.lbl_TietThucHanh.Name = "lbl_TietThucHanh";
            this.lbl_TietThucHanh.Size = new System.Drawing.Size(127, 22);
            this.lbl_TietThucHanh.TabIndex = 12;
            this.lbl_TietThucHanh.Text = "Tiết thực hành:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MÃ MÔN HỌC";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 190;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TÊN MÔN HỌC";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 190;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SỐ TÍN CHỈ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TIẾT THỰC HÀNH";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "TIẾT LÝ THUYẾT";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 180;
            // 
            // fQuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQuanLyMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý môn học";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoTinChi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTietThucHanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietLyThuyet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_TietLyThuyet;
        private System.Windows.Forms.Label lbl_SoTinChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgv_MonHoc;
        private System.Windows.Forms.NumericUpDown num_SoTinChi;
        private System.Windows.Forms.Button btn_Tailai;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txb_TenLop;
        private System.Windows.Forms.Label lbl_TenMonHoc;
        private System.Windows.Forms.TextBox txb_MaMonHoc;
        private System.Windows.Forms.Label lbl_MaMonHoc;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TietThucHanh;
        private System.Windows.Forms.NumericUpDown numTietThucHanh;
        private System.Windows.Forms.NumericUpDown numTietLyThuyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}