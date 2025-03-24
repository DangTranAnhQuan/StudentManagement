namespace SinhVien.GUI
{
    partial class fGiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGiangVien));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbThongTinSV = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnQLDiem = new System.Windows.Forms.Button();
            this.btnQLSinhVien = new System.Windows.Forms.Button();
            this.btnThongTinCaNhan = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.lbThongTinSV);
            this.panel3.Location = new System.Drawing.Point(294, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1561, 66);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbThongTinSV
            // 
            this.lbThongTinSV.AutoSize = true;
            this.lbThongTinSV.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinSV.ForeColor = System.Drawing.Color.White;
            this.lbThongTinSV.Location = new System.Drawing.Point(647, 10);
            this.lbThongTinSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThongTinSV.Name = "lbThongTinSV";
            this.lbThongTinSV.Size = new System.Drawing.Size(317, 38);
            this.lbThongTinSV.TabIndex = 2;
            this.lbThongTinSV.Text = "Thông tin giảng viên";
            this.lbThongTinSV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbThongTinSV.Click += new System.EventHandler(this.lbThongTinSV_Click);
            // 
            // panel_main
            // 
            this.panel_main.Location = new System.Drawing.Point(294, 65);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1546, 896);
            this.panel_main.TabIndex = 10;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 810);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(289, 62);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.btnTaiKhoan);
            this.panel1.Controls.Add(this.btnQLDiem);
            this.panel1.Controls.Add(this.btnQLSinhVien);
            this.panel1.Controls.Add(this.btnThongTinCaNhan);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 917);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ErrorImage = null;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(17, 342);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(76, 65);
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 615);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(289, 62);
            this.btnTaiKhoan.TabIndex = 4;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnQLDiem
            // 
            this.btnQLDiem.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnQLDiem.FlatAppearance.BorderSize = 0;
            this.btnQLDiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnQLDiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnQLDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDiem.ForeColor = System.Drawing.Color.White;
            this.btnQLDiem.Location = new System.Drawing.Point(3, 546);
            this.btnQLDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLDiem.Name = "btnQLDiem";
            this.btnQLDiem.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQLDiem.Size = new System.Drawing.Size(289, 62);
            this.btnQLDiem.TabIndex = 3;
            this.btnQLDiem.Text = "Quản lý điểm";
            this.btnQLDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDiem.UseVisualStyleBackColor = true;
            this.btnQLDiem.Click += new System.EventHandler(this.btnQLDiem_Click);
            // 
            // btnQLSinhVien
            // 
            this.btnQLSinhVien.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnQLSinhVien.FlatAppearance.BorderSize = 0;
            this.btnQLSinhVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnQLSinhVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnQLSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSinhVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnQLSinhVien.Location = new System.Drawing.Point(3, 478);
            this.btnQLSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLSinhVien.Name = "btnQLSinhVien";
            this.btnQLSinhVien.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQLSinhVien.Size = new System.Drawing.Size(289, 62);
            this.btnQLSinhVien.TabIndex = 2;
            this.btnQLSinhVien.Text = "Quản lý sinh viên";
            this.btnQLSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSinhVien.UseVisualStyleBackColor = true;
            this.btnQLSinhVien.Click += new System.EventHandler(this.btnQLSinhVien_Click);
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnThongTinCaNhan.FlatAppearance.BorderSize = 0;
            this.btnThongTinCaNhan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnThongTinCaNhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnThongTinCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinCaNhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinCaNhan.ForeColor = System.Drawing.Color.Coral;
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(4, 415);
            this.btnThongTinCaNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(289, 62);
            this.btnThongTinCaNhan.TabIndex = 1;
            this.btnThongTinCaNhan.Text = "Thông tin cá nhân";
            this.btnThongTinCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 39);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(293, 277);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // fGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 911);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel3);
            this.Name = "fGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fGiangVien";
            this.Load += new System.EventHandler(this.fGiangVien_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbThongTinSV;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnQLDiem;
        private System.Windows.Forms.Button btnQLSinhVien;
        private System.Windows.Forms.Button btnThongTinCaNhan;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}