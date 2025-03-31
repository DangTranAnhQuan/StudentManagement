namespace SinhVien.GUI.Quan_Tri_Vien
{
    partial class fQuanLyPhongHoc
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
            Guna.UI2.WinForms.Guna2GroupBox grpDanhSachPhongHoc;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvDanhSachPhongHoc = new System.Windows.Forms.DataGridView();
            this.txtSucChua = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.cbbLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaPhongHoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.grpThongTinChiTiet = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbbTietKetThuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbTietBatDau = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbGiangVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.grpTimKiem = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbbLocLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbLocTietKet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbLocTietDau = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbLocGiangVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLocSucChua = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbThongTinLopHoc = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            grpDanhSachPhongHoc = new Guna.UI2.WinForms.Guna2GroupBox();
            grpDanhSachPhongHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhongHoc)).BeginInit();
            this.grpThongTinChiTiet.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDanhSachPhongHoc
            // 
            grpDanhSachPhongHoc.BorderColor = System.Drawing.Color.Gray;
            grpDanhSachPhongHoc.BorderRadius = 40;
            grpDanhSachPhongHoc.Controls.Add(this.dtgvDanhSachPhongHoc);
            grpDanhSachPhongHoc.CustomBorderColor = System.Drawing.Color.LightGray;
            grpDanhSachPhongHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            grpDanhSachPhongHoc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grpDanhSachPhongHoc.ForeColor = System.Drawing.Color.Gray;
            grpDanhSachPhongHoc.Location = new System.Drawing.Point(30, 162);
            grpDanhSachPhongHoc.Name = "grpDanhSachPhongHoc";
            grpDanhSachPhongHoc.Size = new System.Drawing.Size(679, 525);
            grpDanhSachPhongHoc.TabIndex = 45;
            grpDanhSachPhongHoc.Text = "Danh sách phòng học";
            grpDanhSachPhongHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgvDanhSachPhongHoc
            // 
            this.dtgvDanhSachPhongHoc.AllowUserToResizeColumns = false;
            this.dtgvDanhSachPhongHoc.AllowUserToResizeRows = false;
            this.dtgvDanhSachPhongHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dtgvDanhSachPhongHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDanhSachPhongHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachPhongHoc.Location = new System.Drawing.Point(3, 43);
            this.dtgvDanhSachPhongHoc.Name = "dtgvDanhSachPhongHoc";
            this.dtgvDanhSachPhongHoc.ReadOnly = true;
            this.dtgvDanhSachPhongHoc.RowHeadersVisible = false;
            this.dtgvDanhSachPhongHoc.RowHeadersWidth = 100;
            this.dtgvDanhSachPhongHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachPhongHoc.Size = new System.Drawing.Size(673, 454);
            this.dtgvDanhSachPhongHoc.TabIndex = 6;
            this.dtgvDanhSachPhongHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachPhongHoc_CellClick);
            this.dtgvDanhSachPhongHoc.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgvDanhSachPhongHoc_DataBindingComplete);
            // 
            // txtSucChua
            // 
            this.txtSucChua.Animated = true;
            this.txtSucChua.AutoRoundedCorners = true;
            this.txtSucChua.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSucChua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSucChua.BorderRadius = 17;
            this.txtSucChua.BorderThickness = 2;
            this.txtSucChua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSucChua.DefaultText = "";
            this.txtSucChua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSucChua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSucChua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSucChua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSucChua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSucChua.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtSucChua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSucChua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSucChua.Location = new System.Drawing.Point(138, 124);
            this.txtSucChua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.PlaceholderText = "Sức chứa";
            this.txtSucChua.SelectedText = "";
            this.txtSucChua.Size = new System.Drawing.Size(232, 36);
            this.txtSucChua.TabIndex = 47;
            this.txtSucChua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSucChua_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.Animated = true;
            this.btnThem.AutoRoundedCorners = true;
            this.btnThem.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnThem.BorderColor = System.Drawing.Color.MistyRose;
            this.btnThem.BorderRadius = 19;
            this.btnThem.BorderThickness = 2;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(4, 62);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 41);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Animated = true;
            this.btnLuu.AutoRoundedCorners = true;
            this.btnLuu.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLuu.BorderColor = System.Drawing.Color.MistyRose;
            this.btnLuu.BorderRadius = 19;
            this.btnLuu.BorderThickness = 2;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(68, 349);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(122, 41);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.AutoRoundedCorners = true;
            this.cbbLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbbLoaiPhong.BorderRadius = 17;
            this.cbbLoaiPhong.BorderThickness = 2;
            this.cbbLoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbbLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbLoaiPhong.ItemHeight = 30;
            this.cbbLoaiPhong.Items.AddRange(new object[] {
            "Loại phòng",
            "Phòng lý thuyết",
            "Phòng thực hành"});
            this.cbbLoaiPhong.Location = new System.Drawing.Point(4, 235);
            this.cbbLoaiPhong.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(365, 36);
            this.cbbLoaiPhong.StartIndex = 0;
            this.cbbLoaiPhong.TabIndex = 45;
            // 
            // btnHuy
            // 
            this.btnHuy.Animated = true;
            this.btnHuy.AutoRoundedCorners = true;
            this.btnHuy.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnHuy.BorderColor = System.Drawing.Color.MistyRose;
            this.btnHuy.BorderRadius = 19;
            this.btnHuy.BorderThickness = 2;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(223, 349);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(122, 41);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMaPhongHoc
            // 
            this.txtMaPhongHoc.Animated = true;
            this.txtMaPhongHoc.AutoRoundedCorners = true;
            this.txtMaPhongHoc.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtMaPhongHoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtMaPhongHoc.BorderRadius = 17;
            this.txtMaPhongHoc.BorderThickness = 2;
            this.txtMaPhongHoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhongHoc.DefaultText = "";
            this.txtMaPhongHoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPhongHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPhongHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhongHoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhongHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhongHoc.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtMaPhongHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMaPhongHoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhongHoc.Location = new System.Drawing.Point(138, 65);
            this.txtMaPhongHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhongHoc.Name = "txtMaPhongHoc";
            this.txtMaPhongHoc.PlaceholderText = "Mã phòng học";
            this.txtMaPhongHoc.ReadOnly = true;
            this.txtMaPhongHoc.SelectedText = "";
            this.txtMaPhongHoc.Size = new System.Drawing.Size(233, 36);
            this.txtMaPhongHoc.TabIndex = 39;
            // 
            // btnXoa
            // 
            this.btnXoa.Animated = true;
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnXoa.BorderColor = System.Drawing.Color.MistyRose;
            this.btnXoa.BorderRadius = 19;
            this.btnXoa.BorderThickness = 2;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(4, 119);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 41);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grpThongTinChiTiet
            // 
            this.grpThongTinChiTiet.BorderColor = System.Drawing.Color.BlueViolet;
            this.grpThongTinChiTiet.BorderRadius = 40;
            this.grpThongTinChiTiet.Controls.Add(this.cbbTietKetThuc);
            this.grpThongTinChiTiet.Controls.Add(this.cbbTietBatDau);
            this.grpThongTinChiTiet.Controls.Add(this.cbbGiangVien);
            this.grpThongTinChiTiet.Controls.Add(this.txtSucChua);
            this.grpThongTinChiTiet.Controls.Add(this.btnThem);
            this.grpThongTinChiTiet.Controls.Add(this.btnLuu);
            this.grpThongTinChiTiet.Controls.Add(this.cbbLoaiPhong);
            this.grpThongTinChiTiet.Controls.Add(this.btnHuy);
            this.grpThongTinChiTiet.Controls.Add(this.txtMaPhongHoc);
            this.grpThongTinChiTiet.Controls.Add(this.btnXoa);
            this.grpThongTinChiTiet.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.grpThongTinChiTiet.FillColor = System.Drawing.Color.LavenderBlush;
            this.grpThongTinChiTiet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(243)))), ((int)(((byte)(187)))));
            this.grpThongTinChiTiet.Location = new System.Drawing.Point(739, 269);
            this.grpThongTinChiTiet.Name = "grpThongTinChiTiet";
            this.grpThongTinChiTiet.Size = new System.Drawing.Size(382, 406);
            this.grpThongTinChiTiet.TabIndex = 51;
            this.grpThongTinChiTiet.Text = "Thông tin chi tiết";
            this.grpThongTinChiTiet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbTietKetThuc
            // 
            this.cbbTietKetThuc.AutoRoundedCorners = true;
            this.cbbTietKetThuc.BackColor = System.Drawing.Color.Transparent;
            this.cbbTietKetThuc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbbTietKetThuc.BorderRadius = 17;
            this.cbbTietKetThuc.BorderThickness = 2;
            this.cbbTietKetThuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTietKetThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTietKetThuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTietKetThuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTietKetThuc.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbbTietKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbTietKetThuc.ItemHeight = 30;
            this.cbbTietKetThuc.Items.AddRange(new object[] {
            "Tiết kết thúc",
            "Tiết 1",
            "Tiết 2",
            "Tiết 3",
            "Tiết 4",
            "Tiết 5",
            "Tiết 6",
            "Tiết 7",
            "Tiết 8",
            "Tiết 9",
            "Tiết 10",
            "Tiết 11",
            "Tiết 12",
            "Tiết 13",
            "Tiết 14",
            "Tiết 15"});
            this.cbbTietKetThuc.Location = new System.Drawing.Point(193, 293);
            this.cbbTietKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTietKetThuc.Name = "cbbTietKetThuc";
            this.cbbTietKetThuc.Size = new System.Drawing.Size(177, 36);
            this.cbbTietKetThuc.StartIndex = 0;
            this.cbbTietKetThuc.TabIndex = 52;
            // 
            // cbbTietBatDau
            // 
            this.cbbTietBatDau.AutoRoundedCorners = true;
            this.cbbTietBatDau.BackColor = System.Drawing.Color.Transparent;
            this.cbbTietBatDau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbbTietBatDau.BorderRadius = 17;
            this.cbbTietBatDau.BorderThickness = 2;
            this.cbbTietBatDau.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTietBatDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTietBatDau.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTietBatDau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTietBatDau.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbbTietBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbTietBatDau.ItemHeight = 30;
            this.cbbTietBatDau.Items.AddRange(new object[] {
            "Tiết bắt đầu",
            "Tiết 1",
            "Tiết 2",
            "Tiết 3",
            "Tiết 4",
            "Tiết 5",
            "Tiết 6",
            "Tiết 7",
            "Tiết 8",
            "Tiết 9",
            "Tiết 10",
            "Tiết 11",
            "Tiết 12",
            "Tiết 13",
            "Tiết 14",
            "Tiết 15"});
            this.cbbTietBatDau.Location = new System.Drawing.Point(4, 293);
            this.cbbTietBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTietBatDau.Name = "cbbTietBatDau";
            this.cbbTietBatDau.Size = new System.Drawing.Size(175, 36);
            this.cbbTietBatDau.StartIndex = 0;
            this.cbbTietBatDau.TabIndex = 51;
            // 
            // cbbGiangVien
            // 
            this.cbbGiangVien.AutoRoundedCorners = true;
            this.cbbGiangVien.BackColor = System.Drawing.Color.Transparent;
            this.cbbGiangVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbbGiangVien.BorderRadius = 17;
            this.cbbGiangVien.BorderThickness = 2;
            this.cbbGiangVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiangVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGiangVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGiangVien.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbbGiangVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbGiangVien.ItemHeight = 30;
            this.cbbGiangVien.Location = new System.Drawing.Point(4, 183);
            this.cbbGiangVien.Margin = new System.Windows.Forms.Padding(2);
            this.cbbGiangVien.Name = "cbbGiangVien";
            this.cbbGiangVien.Size = new System.Drawing.Size(365, 36);
            this.cbbGiangVien.StartIndex = 0;
            this.cbbGiangVien.TabIndex = 50;
            // 
            // btnLoc
            // 
            this.btnLoc.Animated = true;
            this.btnLoc.AutoRoundedCorners = true;
            this.btnLoc.BackColor = System.Drawing.Color.Linen;
            this.btnLoc.BorderColor = System.Drawing.Color.MintCream;
            this.btnLoc.BorderRadius = 19;
            this.btnLoc.BorderThickness = 2;
            this.btnLoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(78, 161);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(122, 41);
            this.btnLoc.TabIndex = 47;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Animated = true;
            this.btnLamMoi.AutoRoundedCorners = true;
            this.btnLamMoi.BackColor = System.Drawing.Color.Linen;
            this.btnLamMoi.BorderColor = System.Drawing.Color.MintCream;
            this.btnLamMoi.BorderRadius = 19;
            this.btnLamMoi.BorderThickness = 2;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(204, 161);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(122, 41);
            this.btnLamMoi.TabIndex = 43;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.BorderColor = System.Drawing.Color.Coral;
            this.grpTimKiem.BorderRadius = 40;
            this.grpTimKiem.Controls.Add(this.cbbLocLoaiPhong);
            this.grpTimKiem.Controls.Add(this.cbbLocTietKet);
            this.grpTimKiem.Controls.Add(this.cbbLocTietDau);
            this.grpTimKiem.Controls.Add(this.cbbLocGiangVien);
            this.grpTimKiem.Controls.Add(this.txtLocSucChua);
            this.grpTimKiem.Controls.Add(this.btnLoc);
            this.grpTimKiem.Controls.Add(this.btnLamMoi);
            this.grpTimKiem.CustomBorderColor = System.Drawing.Color.LightSalmon;
            this.grpTimKiem.FillColor = System.Drawing.Color.Linen;
            this.grpTimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTimKiem.ForeColor = System.Drawing.Color.LightYellow;
            this.grpTimKiem.Location = new System.Drawing.Point(739, 21);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(382, 216);
            this.grpTimKiem.TabIndex = 50;
            this.grpTimKiem.Text = "Tìm kiếm nâng cao";
            this.grpTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbLocLoaiPhong
            // 
            this.cbbLocLoaiPhong.AutoRoundedCorners = true;
            this.cbbLocLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbbLocLoaiPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbbLocLoaiPhong.BorderRadius = 17;
            this.cbbLocLoaiPhong.BorderThickness = 2;
            this.cbbLocLoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLocLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocLoaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocLoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbbLocLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbLocLoaiPhong.ItemHeight = 30;
            this.cbbLocLoaiPhong.Items.AddRange(new object[] {
            "Loại phòng",
            "Phòng lý thuyết",
            "Phòng thực hành"});
            this.cbbLocLoaiPhong.Location = new System.Drawing.Point(204, 108);
            this.cbbLocLoaiPhong.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLocLoaiPhong.Name = "cbbLocLoaiPhong";
            this.cbbLocLoaiPhong.Size = new System.Drawing.Size(165, 36);
            this.cbbLocLoaiPhong.StartIndex = 0;
            this.cbbLocLoaiPhong.TabIndex = 56;
            // 
            // cbbLocTietKet
            // 
            this.cbbLocTietKet.AutoRoundedCorners = true;
            this.cbbLocTietKet.BackColor = System.Drawing.Color.Transparent;
            this.cbbLocTietKet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbbLocTietKet.BorderRadius = 17;
            this.cbbLocTietKet.BorderThickness = 2;
            this.cbbLocTietKet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLocTietKet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocTietKet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocTietKet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocTietKet.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbbLocTietKet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbLocTietKet.ItemHeight = 30;
            this.cbbLocTietKet.Items.AddRange(new object[] {
            "Tiết kết thúc",
            "Tiết 1",
            "Tiết 2",
            "Tiết 3",
            "Tiết 4",
            "Tiết 5",
            "Tiết 6",
            "Tiết 7",
            "Tiết 8",
            "Tiết 9",
            "Tiết 10",
            "Tiết 11",
            "Tiết 12",
            "Tiết 13",
            "Tiết 14",
            "Tiết 15"});
            this.cbbLocTietKet.Location = new System.Drawing.Point(130, 57);
            this.cbbLocTietKet.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLocTietKet.Name = "cbbLocTietKet";
            this.cbbLocTietKet.Size = new System.Drawing.Size(115, 36);
            this.cbbLocTietKet.StartIndex = 0;
            this.cbbLocTietKet.TabIndex = 55;
            // 
            // cbbLocTietDau
            // 
            this.cbbLocTietDau.AutoRoundedCorners = true;
            this.cbbLocTietDau.BackColor = System.Drawing.Color.Transparent;
            this.cbbLocTietDau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbbLocTietDau.BorderRadius = 17;
            this.cbbLocTietDau.BorderThickness = 2;
            this.cbbLocTietDau.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLocTietDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocTietDau.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocTietDau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocTietDau.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbbLocTietDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbLocTietDau.ItemHeight = 30;
            this.cbbLocTietDau.Items.AddRange(new object[] {
            "Tiết bắt đầu",
            "Tiết 1",
            "Tiết 2",
            "Tiết 3",
            "Tiết 4",
            "Tiết 5",
            "Tiết 6",
            "Tiết 7",
            "Tiết 8",
            "Tiết 9",
            "Tiết 10",
            "Tiết 11",
            "Tiết 12",
            "Tiết 13",
            "Tiết 14",
            "Tiết 15"});
            this.cbbLocTietDau.Location = new System.Drawing.Point(10, 57);
            this.cbbLocTietDau.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLocTietDau.Name = "cbbLocTietDau";
            this.cbbLocTietDau.Size = new System.Drawing.Size(116, 36);
            this.cbbLocTietDau.StartIndex = 0;
            this.cbbLocTietDau.TabIndex = 54;
            // 
            // cbbLocGiangVien
            // 
            this.cbbLocGiangVien.AutoRoundedCorners = true;
            this.cbbLocGiangVien.BackColor = System.Drawing.Color.Transparent;
            this.cbbLocGiangVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbbLocGiangVien.BorderRadius = 17;
            this.cbbLocGiangVien.BorderThickness = 2;
            this.cbbLocGiangVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLocGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocGiangVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocGiangVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocGiangVien.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbbLocGiangVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbLocGiangVien.ItemHeight = 30;
            this.cbbLocGiangVien.Location = new System.Drawing.Point(10, 108);
            this.cbbLocGiangVien.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLocGiangVien.Name = "cbbLocGiangVien";
            this.cbbLocGiangVien.Size = new System.Drawing.Size(175, 36);
            this.cbbLocGiangVien.StartIndex = 0;
            this.cbbLocGiangVien.TabIndex = 53;
            // 
            // txtLocSucChua
            // 
            this.txtLocSucChua.Animated = true;
            this.txtLocSucChua.AutoRoundedCorners = true;
            this.txtLocSucChua.BackColor = System.Drawing.Color.Linen;
            this.txtLocSucChua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtLocSucChua.BorderRadius = 17;
            this.txtLocSucChua.BorderThickness = 2;
            this.txtLocSucChua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocSucChua.DefaultText = "";
            this.txtLocSucChua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocSucChua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocSucChua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocSucChua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocSucChua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocSucChua.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtLocSucChua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtLocSucChua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocSucChua.Location = new System.Drawing.Point(266, 57);
            this.txtLocSucChua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocSucChua.Name = "txtLocSucChua";
            this.txtLocSucChua.PlaceholderText = "Sức chứa";
            this.txtLocSucChua.SelectedText = "";
            this.txtLocSucChua.Size = new System.Drawing.Size(103, 36);
            this.txtLocSucChua.TabIndex = 51;
            this.txtLocSucChua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocSucChua_KeyPress);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Animated = true;
            this.btnTimKiem.AutoRoundedCorners = true;
            this.btnTimKiem.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.BorderRadius = 17;
            this.btnTimKiem.BorderThickness = 2;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.LightGreen;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(496, 103);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(126, 37);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Animated = true;
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtTimKiem.BorderRadius = 18;
            this.txtTimKiem.BorderThickness = 2;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(79, 102);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Mã phòng học";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(382, 38);
            this.txtTimKiem.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(grpDanhSachPhongHoc);
            this.panel1.Controls.Add(this.guna2CustomGradientPanel1);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.guna2DataGridView1);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 687);
            this.panel1.TabIndex = 49;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.lbThongTinLopHoc);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Thistle;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Thistle;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Thistle;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Thistle;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(176, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(395, 51);
            this.guna2CustomGradientPanel1.TabIndex = 43;
            // 
            // lbThongTinLopHoc
            // 
            this.lbThongTinLopHoc.AutoSize = true;
            this.lbThongTinLopHoc.BackColor = System.Drawing.Color.Thistle;
            this.lbThongTinLopHoc.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinLopHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(66)))), ((int)(((byte)(94)))));
            this.lbThongTinLopHoc.Location = new System.Drawing.Point(85, 9);
            this.lbThongTinLopHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThongTinLopHoc.Name = "lbThongTinLopHoc";
            this.lbThongTinLopHoc.Size = new System.Drawing.Size(255, 31);
            this.lbThongTinLopHoc.TabIndex = 0;
            this.lbThongTinLopHoc.Text = "Thông tin phòng học";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 159);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(739, 526);
            this.guna2DataGridView1.TabIndex = 2;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // fQuanLyPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1121, 687);
            this.Controls.Add(this.grpThongTinChiTiet);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.panel1);
            this.Name = "fQuanLyPhongHoc";
            this.Text = "fQuanLyLopHoc";
            this.Load += new System.EventHandler(this.fQuanLyPhongHoc_Load);
            grpDanhSachPhongHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhongHoc)).EndInit();
            this.grpThongTinChiTiet.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtSucChua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoaiPhong;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhongHoc;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2GroupBox grpThongTinChiTiet;
        private Guna.UI2.WinForms.Guna2Button btnLoc;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2GroupBox grpTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvDanhSachPhongHoc;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label lbThongTinLopHoc;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbGiangVien;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLocGiangVien;
        private Guna.UI2.WinForms.Guna2TextBox txtLocSucChua;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTietKetThuc;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTietBatDau;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLocTietKet;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLocTietDau;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLocLoaiPhong;
    }
}