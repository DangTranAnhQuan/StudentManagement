namespace QuanLySinhVien.GUI
{
    partial class fQuanLyTaiKhoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_LoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.lbl_LoaiTaiKhoan = new System.Windows.Forms.Label();
            this.btn_Tailai = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txb_MatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgv_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbb_LoaiTaiKhoan);
            this.panel1.Controls.Add(this.lbl_LoaiTaiKhoan);
            this.panel1.Controls.Add(this.btn_Tailai);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.txb_MatKhau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txb_TenDangNhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txb_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 147);
            this.panel1.TabIndex = 0;
            // 
            // cbb_LoaiTaiKhoan
            // 
            this.cbb_LoaiTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LoaiTaiKhoan.FormattingEnabled = true;
            this.cbb_LoaiTaiKhoan.Items.AddRange(new object[] {
            "Cố vấn học tập",
            "Quản trị"});
            this.cbb_LoaiTaiKhoan.Location = new System.Drawing.Point(251, 56);
            this.cbb_LoaiTaiKhoan.Name = "cbb_LoaiTaiKhoan";
            this.cbb_LoaiTaiKhoan.Size = new System.Drawing.Size(167, 30);
            this.cbb_LoaiTaiKhoan.TabIndex = 3;
            // 
            // lbl_LoaiTaiKhoan
            // 
            this.lbl_LoaiTaiKhoan.AutoSize = true;
            this.lbl_LoaiTaiKhoan.Location = new System.Drawing.Point(115, 60);
            this.lbl_LoaiTaiKhoan.Name = "lbl_LoaiTaiKhoan";
            this.lbl_LoaiTaiKhoan.Size = new System.Drawing.Size(128, 22);
            this.lbl_LoaiTaiKhoan.TabIndex = 8;
            this.lbl_LoaiTaiKhoan.Text = "Loại tài khoản:";
            // 
            // btn_Tailai
            // 
            this.btn_Tailai.Location = new System.Drawing.Point(447, 100);
            this.btn_Tailai.Name = "btn_Tailai";
            this.btn_Tailai.Size = new System.Drawing.Size(98, 32);
            this.btn_Tailai.TabIndex = 6;
            this.btn_Tailai.TabStop = false;
            this.btn_Tailai.Text = "Làm mới";
            this.btn_Tailai.UseVisualStyleBackColor = true;
            this.btn_Tailai.Click += new System.EventHandler(this.btn_Tailai_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(332, 100);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(98, 32);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.TabStop = false;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(216, 100);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(98, 32);
            this.btn_Sua.TabIndex = 4;
            this.btn_Sua.TabStop = false;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(103, 100);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 32);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.TabStop = false;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txb_MatKhau
            // 
            this.txb_MatKhau.Location = new System.Drawing.Point(518, 12);
            this.txb_MatKhau.MaxLength = 255;
            this.txb_MatKhau.Name = "txb_MatKhau";
            this.txb_MatKhau.Size = new System.Drawing.Size(167, 30);
            this.txb_MatKhau.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu:";
            // 
            // txb_TenDangNhap
            // 
            this.txb_TenDangNhap.Location = new System.Drawing.Point(251, 12);
            this.txb_TenDangNhap.MaxLength = 255;
            this.txb_TenDangNhap.Name = "txb_TenDangNhap";
            this.txb_TenDangNhap.Size = new System.Drawing.Size(167, 30);
            this.txb_TenDangNhap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // txb_ID
            // 
            this.txb_ID.Enabled = false;
            this.txb_ID.Location = new System.Drawing.Point(48, 12);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(52, 30);
            this.txb_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgv_TaiKhoan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 359);
            this.panel2.TabIndex = 1;
            // 
            // dtgv_TaiKhoan
            // 
            this.dtgv_TaiKhoan.AllowUserToAddRows = false;
            this.dtgv_TaiKhoan.AllowUserToDeleteRows = false;
            this.dtgv_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_TaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgv_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_TaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.dtgv_TaiKhoan.MultiSelect = false;
            this.dtgv_TaiKhoan.Name = "dtgv_TaiKhoan";
            this.dtgv_TaiKhoan.ReadOnly = true;
            this.dtgv_TaiKhoan.RowHeadersVisible = false;
            this.dtgv_TaiKhoan.RowHeadersWidth = 51;
            this.dtgv_TaiKhoan.RowTemplate.Height = 30;
            this.dtgv_TaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_TaiKhoan.Size = new System.Drawing.Size(696, 359);
            this.dtgv_TaiKhoan.TabIndex = 1;
            this.dtgv_TaiKhoan.TabStop = false;
            this.dtgv_TaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_TaiKhoan_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDangNhap";
            this.Column2.HeaderText = "TÊN ĐĂNG NHẬP";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MatKhau";
            this.Column3.HeaderText = "MẬT KHẨU";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 145;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LoaiTaiKhoan";
            this.Column4.HeaderText = "LOẠI TÀI KHOẢN";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 195;
            // 
            // fQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.fQuanLyTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgv_TaiKhoan;
        private System.Windows.Forms.TextBox txb_MatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_TenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Tailai;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lbl_LoaiTaiKhoan;
        private System.Windows.Forms.ComboBox cbb_LoaiTaiKhoan;
    }
}