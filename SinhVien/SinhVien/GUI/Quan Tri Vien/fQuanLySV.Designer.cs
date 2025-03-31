namespace SinhVien.GUI.Quan_Tri_Vien
{
    partial class fQuanLySV
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
            Guna.UI2.WinForms.Guna2GroupBox grpDanhSachSinhVien;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLySV));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvDanhSachSinhVien = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLopSinhVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpGoiTinh = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdbNam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbNu = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cbbDanToc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNoiSinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMSSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbAnhSinhVien = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbThongTinSinhVien = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            grpDanhSachSinhVien = new Guna.UI2.WinForms.Guna2GroupBox();
            grpDanhSachSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSinhVien)).BeginInit();
            this.grpGoiTinh.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSinhVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDanhSachSinhVien
            // 
            grpDanhSachSinhVien.BorderColor = System.Drawing.Color.Gray;
            grpDanhSachSinhVien.BorderRadius = 40;
            grpDanhSachSinhVien.Controls.Add(this.dtgvDanhSachSinhVien);
            grpDanhSachSinhVien.CustomBorderColor = System.Drawing.Color.LightGray;
            grpDanhSachSinhVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            grpDanhSachSinhVien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grpDanhSachSinhVien.ForeColor = System.Drawing.Color.Gray;
            grpDanhSachSinhVien.Location = new System.Drawing.Point(28, 163);
            grpDanhSachSinhVien.Name = "grpDanhSachSinhVien";
            grpDanhSachSinhVien.Size = new System.Drawing.Size(679, 524);
            grpDanhSachSinhVien.TabIndex = 45;
            grpDanhSachSinhVien.Text = "Danh sách sinh viên";
            grpDanhSachSinhVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgvDanhSachSinhVien
            // 
            this.dtgvDanhSachSinhVien.AllowUserToResizeColumns = false;
            this.dtgvDanhSachSinhVien.AllowUserToResizeRows = false;
            this.dtgvDanhSachSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvDanhSachSinhVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dtgvDanhSachSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachSinhVien.Location = new System.Drawing.Point(3, 43);
            this.dtgvDanhSachSinhVien.Name = "dtgvDanhSachSinhVien";
            this.dtgvDanhSachSinhVien.ReadOnly = true;
            this.dtgvDanhSachSinhVien.RowHeadersVisible = false;
            this.dtgvDanhSachSinhVien.RowHeadersWidth = 35;
            this.dtgvDanhSachSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachSinhVien.Size = new System.Drawing.Size(673, 442);
            this.dtgvDanhSachSinhVien.TabIndex = 6;
            this.dtgvDanhSachSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachSinhVien_CellClick);
            this.dtgvDanhSachSinhVien.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgvDanhSachSinhVien_DataBindingComplete);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin chi tiết";
            // 
            // txtLopSinhVien
            // 
            this.txtLopSinhVien.Animated = true;
            this.txtLopSinhVien.AutoRoundedCorners = true;
            this.txtLopSinhVien.BackColor = System.Drawing.Color.PowderBlue;
            this.txtLopSinhVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtLopSinhVien.BorderRadius = 17;
            this.txtLopSinhVien.BorderThickness = 2;
            this.txtLopSinhVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLopSinhVien.DefaultText = "";
            this.txtLopSinhVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLopSinhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLopSinhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLopSinhVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLopSinhVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLopSinhVien.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtLopSinhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtLopSinhVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLopSinhVien.Location = new System.Drawing.Point(14, 560);
            this.txtLopSinhVien.Name = "txtLopSinhVien";
            this.txtLopSinhVien.PlaceholderText = "Lớp sinh viên";
            this.txtLopSinhVien.SelectedText = "";
            this.txtLopSinhVien.Size = new System.Drawing.Size(147, 36);
            this.txtLopSinhVien.TabIndex = 36;
            this.txtLopSinhVien.TextChanged += new System.EventHandler(this.txtLopSinhVien_TextChanged);
            // 
            // grpGoiTinh
            // 
            this.grpGoiTinh.BackColor = System.Drawing.Color.Transparent;
            this.grpGoiTinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grpGoiTinh.BorderRadius = 20;
            this.grpGoiTinh.BorderThickness = 2;
            this.grpGoiTinh.Controls.Add(this.rdbNam);
            this.grpGoiTinh.Controls.Add(this.rdbNu);
            this.grpGoiTinh.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpGoiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGoiTinh.ForeColor = System.Drawing.Color.Teal;
            this.grpGoiTinh.Location = new System.Drawing.Point(166, 509);
            this.grpGoiTinh.Name = "grpGoiTinh";
            this.grpGoiTinh.Size = new System.Drawing.Size(199, 87);
            this.grpGoiTinh.TabIndex = 35;
            this.grpGoiTinh.Text = "Giới tính";
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNam.CheckedState.BorderThickness = 2;
            this.rdbNam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbNam.CheckedState.InnerOffset = -4;
            this.rdbNam.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.rdbNam.Location = new System.Drawing.Point(33, 51);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(52, 20);
            this.rdbNam.TabIndex = 17;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbNam.UncheckedState.BorderThickness = 2;
            this.rdbNam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbNam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Checked = true;
            this.rdbNu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNu.CheckedState.BorderThickness = 2;
            this.rdbNu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbNu.CheckedState.InnerOffset = -4;
            this.rdbNu.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.rdbNu.Location = new System.Drawing.Point(122, 51);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(43, 20);
            this.rdbNu.TabIndex = 18;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbNu.UncheckedState.BorderThickness = 2;
            this.rdbNu.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbNu.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cbbDanToc
            // 
            this.cbbDanToc.AutoRoundedCorners = true;
            this.cbbDanToc.BackColor = System.Drawing.Color.Transparent;
            this.cbbDanToc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbbDanToc.BorderRadius = 17;
            this.cbbDanToc.BorderThickness = 2;
            this.cbbDanToc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDanToc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDanToc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbDanToc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbDanToc.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbbDanToc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbDanToc.ItemHeight = 30;
            this.cbbDanToc.Items.AddRange(new object[] {
            "Dân tộc",
            "Kinh",
            "Tày",
            "Thái",
            "Nùng",
            "Sán Chay",
            "Lào",
            "Lự",
            "Lô Lô",
            "Kháng",
            "Xinh Mun",
            "La Ha",
            "Cống",
            "Mông",
            "Dao",
            "Pà Thẻn",
            "Cờ Lao",
            "Pu Péo",
            "Bố Y",
            "H\'Mông",
            "Gia Rai",
            "Ê Đê",
            "Ba Na",
            "Xơ Đăng",
            "Cơ Ho",
            "H\'rê",
            "Ra Glai",
            "M\'Nông",
            "Bru - Vân Kiều",
            "Co",
            "Gié-Triêng",
            "Chu Ru",
            "Chứt",
            "Mạ",
            "Thổ",
            "Khơ Mú",
            "Tà Ôi",
            "Cơ Tu",
            "Mảng",
            "Lào",
            "La Chí",
            "La Hủ",
            "Lự",
            "Lô Lô",
            "Ngái",
            "Si La",
            "Ơ Đu",
            "Giáy",
            "Hà Nhì",
            "Cống",
            "Brau",
            "Rơ Măm",
            "Chăm",
            "Hoa",
            "Khmer"});
            this.cbbDanToc.Location = new System.Drawing.Point(14, 509);
            this.cbbDanToc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDanToc.Name = "cbbDanToc";
            this.cbbDanToc.Size = new System.Drawing.Size(147, 36);
            this.cbbDanToc.StartIndex = 0;
            this.cbbDanToc.TabIndex = 34;
            this.cbbDanToc.SelectedIndexChanged += new System.EventHandler(this.cbbDanToc_SelectedIndexChanged);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Animated = true;
            this.dtpNgaySinh.AutoRoundedCorners = true;
            this.dtpNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgaySinh.BorderRadius = 17;
            this.dtpNgaySinh.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.dtpNgaySinh.ForeColor = System.Drawing.SystemColors.Control;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgaySinh.Location = new System.Drawing.Point(139, 325);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(233, 36);
            this.dtpNgaySinh.TabIndex = 33;
            this.dtpNgaySinh.Value = new System.DateTime(2025, 3, 28, 18, 19, 55, 371);
            // 
            // btnSua
            // 
            this.btnSua.Animated = true;
            this.btnSua.AutoRoundedCorners = true;
            this.btnSua.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSua.BorderColor = System.Drawing.Color.MistyRose;
            this.btnSua.BorderRadius = 19;
            this.btnSua.BorderThickness = 2;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(5, 380);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 41);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Animated = true;
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BackColor = System.Drawing.Color.PowderBlue;
            this.btnXoa.BorderColor = System.Drawing.Color.MistyRose;
            this.btnXoa.BorderRadius = 19;
            this.btnXoa.BorderThickness = 2;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(5, 320);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 41);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Animated = true;
            this.btnThem.AutoRoundedCorners = true;
            this.btnThem.BackColor = System.Drawing.Color.PowderBlue;
            this.btnThem.BorderColor = System.Drawing.Color.MistyRose;
            this.btnThem.BorderRadius = 19;
            this.btnThem.BorderThickness = 2;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(5, 263);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 41);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Animated = true;
            this.txtMatKhau.AutoRoundedCorners = true;
            this.txtMatKhau.BackColor = System.Drawing.Color.PowderBlue;
            this.txtMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtMatKhau.BorderRadius = 17;
            this.txtMatKhau.BorderThickness = 2;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Location = new System.Drawing.Point(139, 385);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PlaceholderText = "Mật khẩu tài khoản";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(233, 36);
            this.txtMatKhau.TabIndex = 29;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Animated = true;
            this.txtCCCD.AutoRoundedCorners = true;
            this.txtCCCD.BackColor = System.Drawing.Color.PowderBlue;
            this.txtCCCD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCCCD.BorderRadius = 17;
            this.txtCCCD.BorderThickness = 2;
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtCCCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Location = new System.Drawing.Point(139, 266);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PlaceholderText = "CCCD";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.Size = new System.Drawing.Size(233, 36);
            this.txtCCCD.TabIndex = 28;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Animated = true;
            this.txtNoiSinh.AutoRoundedCorners = true;
            this.txtNoiSinh.BackColor = System.Drawing.Color.PowderBlue;
            this.txtNoiSinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtNoiSinh.BorderRadius = 17;
            this.txtNoiSinh.BorderThickness = 2;
            this.txtNoiSinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiSinh.DefaultText = "";
            this.txtNoiSinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoiSinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoiSinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiSinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiSinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiSinh.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtNoiSinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtNoiSinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiSinh.Location = new System.Drawing.Point(14, 451);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.PlaceholderText = "Nơi sinh";
            this.txtNoiSinh.SelectedText = "";
            this.txtNoiSinh.Size = new System.Drawing.Size(343, 36);
            this.txtNoiSinh.TabIndex = 27;
            this.txtNoiSinh.TextChanged += new System.EventHandler(this.txtNoiSinh_TextChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Animated = true;
            this.btnHuy.AutoRoundedCorners = true;
            this.btnHuy.BackColor = System.Drawing.Color.PowderBlue;
            this.btnHuy.BorderColor = System.Drawing.Color.MistyRose;
            this.btnHuy.BorderRadius = 19;
            this.btnHuy.BorderThickness = 2;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(224, 635);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(122, 41);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Animated = true;
            this.btnLuu.AutoRoundedCorners = true;
            this.btnLuu.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLuu.BorderColor = System.Drawing.Color.MistyRose;
            this.btnLuu.BorderRadius = 19;
            this.btnLuu.BorderThickness = 2;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(69, 635);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(122, 41);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sinh viên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Animated = true;
            this.txtHoTen.AutoRoundedCorners = true;
            this.txtHoTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtHoTen.BorderRadius = 16;
            this.txtHoTen.BorderThickness = 2;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(155, 96);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "Họ và tên";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(191, 35);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Animated = true;
            this.txtMSSV.AutoRoundedCorners = true;
            this.txtMSSV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMSSV.BorderRadius = 16;
            this.txtMSSV.BorderThickness = 2;
            this.txtMSSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMSSV.DefaultText = "";
            this.txtMSSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMSSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMSSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSSV.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtMSSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMSSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSSV.Location = new System.Drawing.Point(155, 40);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.PlaceholderText = "Mã số sinh viên";
            this.txtMSSV.ReadOnly = true;
            this.txtMSSV.SelectedText = "";
            this.txtMSSV.Size = new System.Drawing.Size(191, 35);
            this.txtMSSV.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.txtMSSV);
            this.panel2.Controls.Add(this.ptbAnhSinhVien);
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 163);
            this.panel2.TabIndex = 24;
            // 
            // ptbAnhSinhVien
            // 
            this.ptbAnhSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.ptbAnhSinhVien.ImageRotate = 0F;
            this.ptbAnhSinhVien.Location = new System.Drawing.Point(15, 22);
            this.ptbAnhSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.ptbAnhSinhVien.Name = "ptbAnhSinhVien";
            this.ptbAnhSinhVien.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbAnhSinhVien.Size = new System.Drawing.Size(116, 118);
            this.ptbAnhSinhVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAnhSinhVien.TabIndex = 0;
            this.ptbAnhSinhVien.TabStop = false;
            this.ptbAnhSinhVien.UseTransparentBackground = true;
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
            this.txtTimKiem.PlaceholderText = "Mã số sinh viên";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(382, 38);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lbThongTinSinhVien
            // 
            this.lbThongTinSinhVien.AutoSize = true;
            this.lbThongTinSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            this.lbThongTinSinhVien.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinSinhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(112)))), ((int)(((byte)(110)))));
            this.lbThongTinSinhVien.Location = new System.Drawing.Point(85, 9);
            this.lbThongTinSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThongTinSinhVien.Name = "lbThongTinSinhVien";
            this.lbThongTinSinhVien.Size = new System.Drawing.Size(240, 31);
            this.lbThongTinSinhVien.TabIndex = 0;
            this.lbThongTinSinhVien.Text = "Thông tin sinh viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(grpDanhSachSinhVien);
            this.panel1.Controls.Add(this.guna2CustomGradientPanel1);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.guna2DataGridView1);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 687);
            this.panel1.TabIndex = 23;
            // 
            // btnReset
            // 
            this.btnReset.Animated = true;
            this.btnReset.AutoRoundedCorners = true;
            this.btnReset.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.BorderRadius = 17;
            this.btnReset.BorderThickness = 2;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.MintCream;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReset.Location = new System.Drawing.Point(626, 103);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 37);
            this.btnReset.TabIndex = 46;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.lbThongTinSinhVien);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(176, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(395, 51);
            this.guna2CustomGradientPanel1.TabIndex = 43;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
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
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 40;
            this.guna2CustomGradientPanel2.Controls.Add(this.txtLopSinhVien);
            this.guna2CustomGradientPanel2.Controls.Add(this.label2);
            this.guna2CustomGradientPanel2.Controls.Add(this.panel5);
            this.guna2CustomGradientPanel2.Controls.Add(this.panel2);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnThem);
            this.guna2CustomGradientPanel2.Controls.Add(this.grpGoiTinh);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnLuu);
            this.guna2CustomGradientPanel2.Controls.Add(this.cbbDanToc);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnHuy);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtNoiSinh);
            this.guna2CustomGradientPanel2.Controls.Add(this.dtpNgaySinh);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtCCCD);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnSua);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtMatKhau);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnXoa);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.PowderBlue;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.PowderBlue;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.PowderBlue;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.PowderBlue;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(739, 0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(382, 687);
            this.guna2CustomGradientPanel2.TabIndex = 44;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(0, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(382, 54);
            this.panel5.TabIndex = 37;
            // 
            // fQuanLySV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1121, 687);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fQuanLySV";
            this.Text = "fQuanLySinhVien";
            this.Load += new System.EventHandler(this.fQuanLySinhVien_Load);
            grpDanhSachSinhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSinhVien)).EndInit();
            this.grpGoiTinh.ResumeLayout(false);
            this.grpGoiTinh.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSinhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtLopSinhVien;
        private Guna.UI2.WinForms.Guna2GroupBox grpGoiTinh;
        private Guna.UI2.WinForms.Guna2RadioButton rdbNam;
        private Guna.UI2.WinForms.Guna2RadioButton rdbNu;
        private Guna.UI2.WinForms.Guna2ComboBox cbbDanToc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtCCCD;
        private Guna.UI2.WinForms.Guna2TextBox txtNoiSinh;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtMSSV;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptbAnhSinhVien;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label lbThongTinSinhVien;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridView dtgvDanhSachSinhVien;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnReset;
    }
}