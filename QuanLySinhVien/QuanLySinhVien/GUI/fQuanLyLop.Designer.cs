namespace QuanLySinhVien.GUI
{
    partial class fQuanLyLop
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
            this.btn_Tailai = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txb_TenLop = new System.Windows.Forms.TextBox();
            this.lbl_TenLop = new System.Windows.Forms.Label();
            this.txb_MaLop = new System.Windows.Forms.TextBox();
            this.lbl_MaLop = new System.Windows.Forms.Label();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.dtgv_Lop = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.num_Soluong = new System.Windows.Forms.NumericUpDown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_MaKhoa = new System.Windows.Forms.TextBox();
            this.lbl_MaKhoa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lop)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Tailai
            // 
            this.btn_Tailai.Location = new System.Drawing.Point(560, 63);
            this.btn_Tailai.Name = "btn_Tailai";
            this.btn_Tailai.Size = new System.Drawing.Size(98, 32);
            this.btn_Tailai.TabIndex = 6;
            this.btn_Tailai.TabStop = false;
            this.btn_Tailai.Text = "Làm mới";
            this.btn_Tailai.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(456, 63);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(98, 32);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.TabStop = false;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(352, 63);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(98, 32);
            this.btn_Sua.TabIndex = 4;
            this.btn_Sua.TabStop = false;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(248, 63);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 32);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.TabStop = false;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // txb_TenLop
            // 
            this.txb_TenLop.Location = new System.Drawing.Point(398, 12);
            this.txb_TenLop.MaxLength = 255;
            this.txb_TenLop.Name = "txb_TenLop";
            this.txb_TenLop.Size = new System.Drawing.Size(110, 30);
            this.txb_TenLop.TabIndex = 2;
            // 
            // lbl_TenLop
            // 
            this.lbl_TenLop.AutoSize = true;
            this.lbl_TenLop.Location = new System.Drawing.Point(314, 16);
            this.lbl_TenLop.Name = "lbl_TenLop";
            this.lbl_TenLop.Size = new System.Drawing.Size(78, 22);
            this.lbl_TenLop.TabIndex = 4;
            this.lbl_TenLop.Text = "Tên lớp:";
            // 
            // txb_MaLop
            // 
            this.txb_MaLop.Location = new System.Drawing.Point(189, 12);
            this.txb_MaLop.MaxLength = 255;
            this.txb_MaLop.Name = "txb_MaLop";
            this.txb_MaLop.Size = new System.Drawing.Size(119, 30);
            this.txb_MaLop.TabIndex = 1;
            // 
            // lbl_MaLop
            // 
            this.lbl_MaLop.AutoSize = true;
            this.lbl_MaLop.Location = new System.Drawing.Point(109, 16);
            this.lbl_MaLop.Name = "lbl_MaLop";
            this.lbl_MaLop.Size = new System.Drawing.Size(74, 22);
            this.lbl_MaLop.TabIndex = 2;
            this.lbl_MaLop.Text = "Mã lớp:";
            // 
            // txb_ID
            // 
            this.txb_ID.Enabled = false;
            this.txb_ID.Location = new System.Drawing.Point(50, 12);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(52, 30);
            this.txb_ID.TabIndex = 0;
            // 
            // dtgv_Lop
            // 
            this.dtgv_Lop.AllowUserToAddRows = false;
            this.dtgv_Lop.AllowUserToDeleteRows = false;
            this.dtgv_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgv_Lop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_Lop.Location = new System.Drawing.Point(0, 0);
            this.dtgv_Lop.MultiSelect = false;
            this.dtgv_Lop.Name = "dtgv_Lop";
            this.dtgv_Lop.ReadOnly = true;
            this.dtgv_Lop.RowHeadersVisible = false;
            this.dtgv_Lop.RowHeadersWidth = 51;
            this.dtgv_Lop.RowTemplate.Height = 30;
            this.dtgv_Lop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Lop.Size = new System.Drawing.Size(671, 466);
            this.dtgv_Lop.TabIndex = 1;
            this.dtgv_Lop.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgv_Lop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 466);
            this.panel2.TabIndex = 5;
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
            this.panel1.Controls.Add(this.txb_MaKhoa);
            this.panel1.Controls.Add(this.lbl_MaKhoa);
            this.panel1.Controls.Add(this.num_Soluong);
            this.panel1.Controls.Add(this.lbl_SoLuong);
            this.panel1.Controls.Add(this.btn_Tailai);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.txb_TenLop);
            this.panel1.Controls.Add(this.lbl_TenLop);
            this.panel1.Controls.Add(this.txb_MaLop);
            this.panel1.Controls.Add(this.lbl_MaLop);
            this.panel1.Controls.Add(this.txb_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 100);
            this.panel1.TabIndex = 4;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(514, 16);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(88, 22);
            this.lbl_SoLuong.TabIndex = 7;
            this.lbl_SoLuong.Text = "Số lượng:";
            // 
            // num_Soluong
            // 
            this.num_Soluong.Location = new System.Drawing.Point(600, 12);
            this.num_Soluong.Name = "num_Soluong";
            this.num_Soluong.Size = new System.Drawing.Size(59, 30);
            this.num_Soluong.TabIndex = 3;
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
            this.Column2.HeaderText = "MÃ LỚP";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TÊN LỚP";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SỐ LƯỢNG";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "MÃ KHOA";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 140;
            // 
            // txb_MaKhoa
            // 
            this.txb_MaKhoa.Location = new System.Drawing.Point(92, 64);
            this.txb_MaKhoa.MaxLength = 255;
            this.txb_MaKhoa.Name = "txb_MaKhoa";
            this.txb_MaKhoa.Size = new System.Drawing.Size(137, 30);
            this.txb_MaKhoa.TabIndex = 4;
            // 
            // lbl_MaKhoa
            // 
            this.lbl_MaKhoa.AutoSize = true;
            this.lbl_MaKhoa.Location = new System.Drawing.Point(8, 68);
            this.lbl_MaKhoa.Name = "lbl_MaKhoa";
            this.lbl_MaKhoa.Size = new System.Drawing.Size(84, 22);
            this.lbl_MaKhoa.TabIndex = 10;
            this.lbl_MaKhoa.Text = "Mã khoa:";
            // 
            // fQuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fQuanLyLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lớp";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lop)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Soluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Tailai;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txb_TenLop;
        private System.Windows.Forms.Label lbl_TenLop;
        private System.Windows.Forms.TextBox txb_MaLop;
        private System.Windows.Forms.Label lbl_MaLop;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.DataGridView dtgv_Lop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txb_MaKhoa;
        private System.Windows.Forms.Label lbl_MaKhoa;
        private System.Windows.Forms.NumericUpDown num_Soluong;
        private System.Windows.Forms.Label lbl_SoLuong;
    }
}