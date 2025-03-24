namespace QuanLySinhVien.GUI
{
    partial class fCoVanHocTap
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
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgv_CoVanHocTap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd_Nu = new System.Windows.Forms.RadioButton();
            this.rd_Nam = new System.Windows.Forms.RadioButton();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txb_MaKhoa = new System.Windows.Forms.TextBox();
            this.lbl_MaKhoa = new System.Windows.Forms.Label();
            this.txb_MaLop = new System.Windows.Forms.TextBox();
            this.lbl_MaLop = new System.Windows.Forms.Label();
            this.btn_Tailai = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txb_TenLop = new System.Windows.Forms.TextBox();
            this.lbl_TenCoVan = new System.Windows.Forms.Label();
            this.txb_MaCoVan = new System.Windows.Forms.TextBox();
            this.lbl_MaCoVan = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CoVanHocTap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(108, 72);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(87, 22);
            this.lbl_GioiTinh.TabIndex = 10;
            this.lbl_GioiTinh.Text = "Giới tính:";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(653, 16);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(94, 22);
            this.lbl_NgaySinh.TabIndex = 7;
            this.lbl_NgaySinh.Text = "Ngày sinh:";
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
            this.panel2.Controls.Add(this.dtgv_CoVanHocTap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 403);
            this.panel2.TabIndex = 7;
            // 
            // dtgv_CoVanHocTap
            // 
            this.dtgv_CoVanHocTap.AllowUserToAddRows = false;
            this.dtgv_CoVanHocTap.AllowUserToDeleteRows = false;
            this.dtgv_CoVanHocTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CoVanHocTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtgv_CoVanHocTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_CoVanHocTap.Location = new System.Drawing.Point(0, 0);
            this.dtgv_CoVanHocTap.MultiSelect = false;
            this.dtgv_CoVanHocTap.Name = "dtgv_CoVanHocTap";
            this.dtgv_CoVanHocTap.ReadOnly = true;
            this.dtgv_CoVanHocTap.RowHeadersVisible = false;
            this.dtgv_CoVanHocTap.RowHeadersWidth = 51;
            this.dtgv_CoVanHocTap.RowTemplate.Height = 30;
            this.dtgv_CoVanHocTap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_CoVanHocTap.Size = new System.Drawing.Size(938, 403);
            this.dtgv_CoVanHocTap.TabIndex = 1;
            this.dtgv_CoVanHocTap.TabStop = false;
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
            this.Column2.HeaderText = "MÃ CỐ VẤN";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 190;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TÊN CỐ VẤN";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NGÀY SINH";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 160;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "GIỚI TÍNH";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 140;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "MÃ LỚP";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "MÃ KHOA";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // txb_ID
            // 
            this.txb_ID.Enabled = false;
            this.txb_ID.Location = new System.Drawing.Point(50, 12);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(43, 30);
            this.txb_ID.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_Nu);
            this.panel1.Controls.Add(this.rd_Nam);
            this.panel1.Controls.Add(this.dtp_NgaySinh);
            this.panel1.Controls.Add(this.txb_MaKhoa);
            this.panel1.Controls.Add(this.lbl_MaKhoa);
            this.panel1.Controls.Add(this.txb_MaLop);
            this.panel1.Controls.Add(this.lbl_MaLop);
            this.panel1.Controls.Add(this.lbl_GioiTinh);
            this.panel1.Controls.Add(this.lbl_NgaySinh);
            this.panel1.Controls.Add(this.btn_Tailai);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.txb_TenLop);
            this.panel1.Controls.Add(this.lbl_TenCoVan);
            this.panel1.Controls.Add(this.txb_MaCoVan);
            this.panel1.Controls.Add(this.lbl_MaCoVan);
            this.panel1.Controls.Add(this.txb_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 155);
            this.panel1.TabIndex = 6;
            // 
            // rd_Nu
            // 
            this.rd_Nu.AutoSize = true;
            this.rd_Nu.Location = new System.Drawing.Point(289, 70);
            this.rd_Nu.Name = "rd_Nu";
            this.rd_Nu.Size = new System.Drawing.Size(56, 26);
            this.rd_Nu.TabIndex = 5;
            this.rd_Nu.Text = "Nữ";
            this.rd_Nu.UseVisualStyleBackColor = true;
            // 
            // rd_Nam
            // 
            this.rd_Nam.AutoSize = true;
            this.rd_Nam.Checked = true;
            this.rd_Nam.Location = new System.Drawing.Point(212, 70);
            this.rd_Nam.Name = "rd_Nam";
            this.rd_Nam.Size = new System.Drawing.Size(68, 26);
            this.rd_Nam.TabIndex = 4;
            this.rd_Nam.TabStop = true;
            this.rd_Nam.Text = "Nam";
            this.rd_Nam.UseVisualStyleBackColor = true;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(772, 12);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(146, 30);
            this.dtp_NgaySinh.TabIndex = 3;
            // 
            // txb_MaKhoa
            // 
            this.txb_MaKhoa.Location = new System.Drawing.Point(772, 68);
            this.txb_MaKhoa.MaxLength = 255;
            this.txb_MaKhoa.Name = "txb_MaKhoa";
            this.txb_MaKhoa.Size = new System.Drawing.Size(146, 30);
            this.txb_MaKhoa.TabIndex = 7;
            // 
            // lbl_MaKhoa
            // 
            this.lbl_MaKhoa.AutoSize = true;
            this.lbl_MaKhoa.Location = new System.Drawing.Point(653, 72);
            this.lbl_MaKhoa.Name = "lbl_MaKhoa";
            this.lbl_MaKhoa.Size = new System.Drawing.Size(84, 22);
            this.lbl_MaKhoa.TabIndex = 14;
            this.lbl_MaKhoa.Text = "Mã khoa:";
            // 
            // txb_MaLop
            // 
            this.txb_MaLop.Location = new System.Drawing.Point(474, 68);
            this.txb_MaLop.MaxLength = 255;
            this.txb_MaLop.Name = "txb_MaLop";
            this.txb_MaLop.Size = new System.Drawing.Size(154, 30);
            this.txb_MaLop.TabIndex = 6;
            // 
            // lbl_MaLop
            // 
            this.lbl_MaLop.AutoSize = true;
            this.lbl_MaLop.Location = new System.Drawing.Point(365, 72);
            this.lbl_MaLop.Name = "lbl_MaLop";
            this.lbl_MaLop.Size = new System.Drawing.Size(74, 22);
            this.lbl_MaLop.TabIndex = 12;
            this.lbl_MaLop.Text = "Mã lớp:";
            // 
            // btn_Tailai
            // 
            this.btn_Tailai.Location = new System.Drawing.Point(601, 117);
            this.btn_Tailai.Name = "btn_Tailai";
            this.btn_Tailai.Size = new System.Drawing.Size(98, 32);
            this.btn_Tailai.TabIndex = 6;
            this.btn_Tailai.TabStop = false;
            this.btn_Tailai.Text = "Làm mới";
            this.btn_Tailai.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(497, 117);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(98, 32);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.TabStop = false;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(393, 117);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(98, 32);
            this.btn_Sua.TabIndex = 4;
            this.btn_Sua.TabStop = false;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(289, 117);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 32);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.TabStop = false;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // txb_TenLop
            // 
            this.txb_TenLop.Location = new System.Drawing.Point(474, 12);
            this.txb_TenLop.MaxLength = 255;
            this.txb_TenLop.Name = "txb_TenLop";
            this.txb_TenLop.Size = new System.Drawing.Size(154, 30);
            this.txb_TenLop.TabIndex = 2;
            // 
            // lbl_TenCoVan
            // 
            this.lbl_TenCoVan.AutoSize = true;
            this.lbl_TenCoVan.Location = new System.Drawing.Point(365, 16);
            this.lbl_TenCoVan.Name = "lbl_TenCoVan";
            this.lbl_TenCoVan.Size = new System.Drawing.Size(103, 22);
            this.lbl_TenCoVan.TabIndex = 4;
            this.lbl_TenCoVan.Text = "Tên cố vấn:";
            // 
            // txb_MaCoVan
            // 
            this.txb_MaCoVan.Location = new System.Drawing.Point(212, 12);
            this.txb_MaCoVan.MaxLength = 255;
            this.txb_MaCoVan.Name = "txb_MaCoVan";
            this.txb_MaCoVan.Size = new System.Drawing.Size(147, 30);
            this.txb_MaCoVan.TabIndex = 1;
            // 
            // lbl_MaCoVan
            // 
            this.lbl_MaCoVan.AutoSize = true;
            this.lbl_MaCoVan.Location = new System.Drawing.Point(108, 16);
            this.lbl_MaCoVan.Name = "lbl_MaCoVan";
            this.lbl_MaCoVan.Size = new System.Drawing.Size(99, 22);
            this.lbl_MaCoVan.TabIndex = 2;
            this.lbl_MaCoVan.Text = "Mã cố vấn:";
            // 
            // fCoVanHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 558);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fCoVanHocTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cố vấn học tập";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CoVanHocTap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgv_CoVanHocTap;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Tailai;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txb_TenLop;
        private System.Windows.Forms.Label lbl_TenCoVan;
        private System.Windows.Forms.TextBox txb_MaCoVan;
        private System.Windows.Forms.Label lbl_MaCoVan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.RadioButton rd_Nu;
        private System.Windows.Forms.RadioButton rd_Nam;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.TextBox txb_MaKhoa;
        private System.Windows.Forms.Label lbl_MaKhoa;
        private System.Windows.Forms.TextBox txb_MaLop;
        private System.Windows.Forms.Label lbl_MaLop;
    }
}