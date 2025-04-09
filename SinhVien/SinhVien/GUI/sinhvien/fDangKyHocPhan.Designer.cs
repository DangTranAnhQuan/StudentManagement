namespace SinhVien.GUI.sinhvien
{
    partial class fDangKyHocPhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_DanhSachCacMonHoc = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnQuayLai = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.grbDanhSachCacMonHoc = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgvDanhSachCacHocPhan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_dkhp = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel_dangkyhocphan = new Guna.UI2.WinForms.Guna2Panel();
            this.panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbDanhSachCacMonHoc = new System.Windows.Forms.Label();
            this.panel_DanhSachCacMonHoc.SuspendLayout();
            this.grbDanhSachCacMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachCacHocPhan)).BeginInit();
            this.panel_dkhp.SuspendLayout();
            this.panel_dangkyhocphan.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_DanhSachCacMonHoc
            // 
            this.panel_DanhSachCacMonHoc.Controls.Add(this.btnQuayLai);
            this.panel_DanhSachCacMonHoc.Controls.Add(this.btnDangKy);
            this.panel_DanhSachCacMonHoc.Controls.Add(this.grbDanhSachCacMonHoc);
            this.panel_DanhSachCacMonHoc.Location = new System.Drawing.Point(0, 60);
            this.panel_DanhSachCacMonHoc.Name = "panel_DanhSachCacMonHoc";
            this.panel_DanhSachCacMonHoc.Size = new System.Drawing.Size(1136, 743);
            this.panel_DanhSachCacMonHoc.TabIndex = 65;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BorderRadius = 10;
            this.btnQuayLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuayLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuayLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuayLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuayLai.FillColor = System.Drawing.Color.DarkRed;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Location = new System.Drawing.Point(740, 645);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(110, 35);
            this.btnQuayLai.TabIndex = 20;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BorderRadius = 10;
            this.btnDangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKy.FillColor = System.Drawing.Color.Purple;
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(870, 645);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(136, 35);
            this.btnDangKy.TabIndex = 19;
            this.btnDangKy.Text = "Đăng ký ";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // grbDanhSachCacMonHoc
            // 
            this.grbDanhSachCacMonHoc.BackColor = System.Drawing.Color.White;
            this.grbDanhSachCacMonHoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(45)))), ((int)(((byte)(74)))));
            this.grbDanhSachCacMonHoc.BorderRadius = 30;
            this.grbDanhSachCacMonHoc.Controls.Add(this.dtgvDanhSachCacHocPhan);
            this.grbDanhSachCacMonHoc.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.grbDanhSachCacMonHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.grbDanhSachCacMonHoc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachCacMonHoc.ForeColor = System.Drawing.Color.Teal;
            this.grbDanhSachCacMonHoc.Location = new System.Drawing.Point(119, 72);
            this.grbDanhSachCacMonHoc.Name = "grbDanhSachCacMonHoc";
            this.grbDanhSachCacMonHoc.Size = new System.Drawing.Size(888, 552);
            this.grbDanhSachCacMonHoc.TabIndex = 2;
            this.grbDanhSachCacMonHoc.Text = "Danh sách các học phần";
            this.grbDanhSachCacMonHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgvDanhSachCacHocPhan
            // 
            this.dtgvDanhSachCacHocPhan.AllowUserToResizeColumns = false;
            this.dtgvDanhSachCacHocPhan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtgvDanhSachCacHocPhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDanhSachCacHocPhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachCacHocPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDanhSachCacHocPhan.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDanhSachCacHocPhan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDanhSachCacHocPhan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDanhSachCacHocPhan.Location = new System.Drawing.Point(1, 43);
            this.dtgvDanhSachCacHocPhan.Name = "dtgvDanhSachCacHocPhan";
            this.dtgvDanhSachCacHocPhan.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachCacHocPhan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvDanhSachCacHocPhan.RowHeadersVisible = false;
            this.dtgvDanhSachCacHocPhan.Size = new System.Drawing.Size(886, 484);
            this.dtgvDanhSachCacHocPhan.TabIndex = 1;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(230)))));
            this.dtgvDanhSachCacHocPhan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDanhSachCacHocPhan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvDanhSachCacHocPhan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDanhSachCacHocPhan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.ReadOnly = true;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDanhSachCacHocPhan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvDanhSachCacHocPhan.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvDanhSachCacHocPhan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDanhSachCacHocPhan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvDanhSachCacHocPhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachCacHocPhan_CellContentClick);
            // 
            // panel_dkhp
            // 
            this.panel_dkhp.Controls.Add(this.panel_DanhSachCacMonHoc);
            this.panel_dkhp.Controls.Add(this.panel_dangkyhocphan);
            this.panel_dkhp.Location = new System.Drawing.Point(0, 0);
            this.panel_dkhp.Name = "panel_dkhp";
            this.panel_dkhp.Size = new System.Drawing.Size(1136, 743);
            this.panel_dkhp.TabIndex = 1;
            // 
            // panel_dangkyhocphan
            // 
            this.panel_dangkyhocphan.BackColor = System.Drawing.Color.White;
            this.panel_dangkyhocphan.Controls.Add(this.panel);
            this.panel_dangkyhocphan.Location = new System.Drawing.Point(0, 0);
            this.panel_dangkyhocphan.Name = "panel_dangkyhocphan";
            this.panel_dangkyhocphan.Size = new System.Drawing.Size(1136, 60);
            this.panel_dangkyhocphan.TabIndex = 64;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderRadius = 20;
            this.panel.Controls.Add(this.lbDanhSachCacMonHoc);
            this.panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(38)))), ((int)(((byte)(171)))));
            this.panel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(38)))), ((int)(((byte)(171)))));
            this.panel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(38)))), ((int)(((byte)(171)))));
            this.panel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(38)))), ((int)(((byte)(171)))));
            this.panel.Location = new System.Drawing.Point(335, 6);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(466, 51);
            this.panel.TabIndex = 50;
            // 
            // lbDanhSachCacMonHoc
            // 
            this.lbDanhSachCacMonHoc.AutoSize = true;
            this.lbDanhSachCacMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(38)))), ((int)(((byte)(171)))));
            this.lbDanhSachCacMonHoc.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachCacMonHoc.ForeColor = System.Drawing.Color.White;
            this.lbDanhSachCacMonHoc.Location = new System.Drawing.Point(125, 9);
            this.lbDanhSachCacMonHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDanhSachCacMonHoc.Name = "lbDanhSachCacMonHoc";
            this.lbDanhSachCacMonHoc.Size = new System.Drawing.Size(225, 31);
            this.lbDanhSachCacMonHoc.TabIndex = 0;
            this.lbDanhSachCacMonHoc.Text = "Đăng ký học phần";
            // 
            // fDangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 743);
            this.Controls.Add(this.panel_dkhp);
            this.Name = "fDangKyHocPhan";
            this.Text = "fDangKyHocPhan";
            this.Load += new System.EventHandler(this.fDangKyHocPhan_Load);
            this.panel_DanhSachCacMonHoc.ResumeLayout(false);
            this.grbDanhSachCacMonHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachCacHocPhan)).EndInit();
            this.panel_dkhp.ResumeLayout(false);
            this.panel_dangkyhocphan.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_DanhSachCacMonHoc;
        private Guna.UI2.WinForms.Guna2Button btnDangKy;
        private Guna.UI2.WinForms.Guna2GroupBox grbDanhSachCacMonHoc;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvDanhSachCacHocPhan;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_dkhp;
        private Guna.UI2.WinForms.Guna2Panel panel_dangkyhocphan;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel;
        private System.Windows.Forms.Label lbDanhSachCacMonHoc;
        private Guna.UI2.WinForms.Guna2Button btnQuayLai;
    }
}