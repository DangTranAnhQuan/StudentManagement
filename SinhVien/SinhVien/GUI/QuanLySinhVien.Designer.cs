namespace SinhVien.GUI
{
    partial class QuanLySinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySinhVien));
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.grpMonHoc = new System.Windows.Forms.GroupBox();
            this.grpLopHoc = new System.Windows.Forms.GroupBox();
            this.cbbLopHoc = new System.Windows.Forms.ComboBox();
            this.dtgvDSSinhVien = new System.Windows.Forms.DataGridView();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpMonHoc.SuspendLayout();
            this.grpLopHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSinhVien)).BeginInit();
            this.grpTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Items.AddRange(new object[] {
            "Lập trình C#",
            "Lập trình C++",
            "Lập trình Java"});
            this.cbbMonHoc.Location = new System.Drawing.Point(21, 33);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(289, 30);
            this.cbbMonHoc.TabIndex = 0;
            this.cbbMonHoc.Text = "Chọn môn học";
            this.cbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMonHoc_SelectedIndexChanged);
            // 
            // grpMonHoc
            // 
            this.grpMonHoc.Controls.Add(this.cbbMonHoc);
            this.grpMonHoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMonHoc.Location = new System.Drawing.Point(30, 33);
            this.grpMonHoc.Name = "grpMonHoc";
            this.grpMonHoc.Size = new System.Drawing.Size(331, 88);
            this.grpMonHoc.TabIndex = 1;
            this.grpMonHoc.TabStop = false;
            this.grpMonHoc.Text = "Môn học";
            // 
            // grpLopHoc
            // 
            this.grpLopHoc.Controls.Add(this.cbbLopHoc);
            this.grpLopHoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLopHoc.Location = new System.Drawing.Point(553, 33);
            this.grpLopHoc.Name = "grpLopHoc";
            this.grpLopHoc.Size = new System.Drawing.Size(331, 88);
            this.grpLopHoc.TabIndex = 2;
            this.grpLopHoc.TabStop = false;
            this.grpLopHoc.Text = "Lớp học";
            // 
            // cbbLopHoc
            // 
            this.cbbLopHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLopHoc.FormattingEnabled = true;
            this.cbbLopHoc.Items.AddRange(new object[] {
            "Lập trình Winform",
            "Trí tuệ nhân tạo",
            "Vạn vật kết nối",
            "Hệ điều hành",
            "Cơ sở dữ liệu",
            "An toàn thông tin"});
            this.cbbLopHoc.Location = new System.Drawing.Point(21, 33);
            this.cbbLopHoc.Name = "cbbLopHoc";
            this.cbbLopHoc.Size = new System.Drawing.Size(289, 30);
            this.cbbLopHoc.TabIndex = 0;
            this.cbbLopHoc.Text = "Chọn lớp học";
            // 
            // dtgvDSSinhVien
            // 
            this.dtgvDSSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSSinhVien.Location = new System.Drawing.Point(30, 163);
            this.dtgvDSSinhVien.Name = "dtgvDSSinhVien";
            this.dtgvDSSinhVien.RowHeadersWidth = 51;
            this.dtgvDSSinhVien.RowTemplate.Height = 24;
            this.dtgvDSSinhVien.Size = new System.Drawing.Size(854, 502);
            this.dtgvDSSinhVien.TabIndex = 3;
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.button1);
            this.grpTimKiem.Controls.Add(this.txtMSSV);
            this.grpTimKiem.Controls.Add(this.lbMSSV);
            this.grpTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTimKiem.Location = new System.Drawing.Point(907, 163);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(297, 75);
            this.grpTimKiem.TabIndex = 4;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Location = new System.Drawing.Point(6, 37);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(60, 20);
            this.lbMSSV.TabIndex = 0;
            this.lbMSSV.Text = "MSSV:";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Location = new System.Drawing.Point(72, 32);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(161, 27);
            this.txtMSSV.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(239, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 38);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 699);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.dtgvDSSinhVien);
            this.Controls.Add(this.grpLopHoc);
            this.Controls.Add(this.grpMonHoc);
            this.Name = "QuanLySinhVien";
            this.Text = "QuanLySinhVien";
            this.Load += new System.EventHandler(this.QuanLySinhVien_Load);
            this.grpMonHoc.ResumeLayout(false);
            this.grpLopHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSinhVien)).EndInit();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.GroupBox grpMonHoc;
        private System.Windows.Forms.GroupBox grpLopHoc;
        private System.Windows.Forms.ComboBox cbbLopHoc;
        private System.Windows.Forms.DataGridView dtgvDSSinhVien;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Button button1;
    }
}