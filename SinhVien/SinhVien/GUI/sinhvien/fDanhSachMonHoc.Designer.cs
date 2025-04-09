namespace SinhVien
{
    partial class fDanhSachMonHoc
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
                this.btnDangKyHocPhan.Click += new System.EventHandler(this.btnDangKyHocPhan_Click);
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
            this.pane_dscmh = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel_DanhSachCacMonHoc = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnDangKyHocPhan = new Guna.UI2.WinForms.Guna2Button();
            this.grbDanhSachCacMonHoc = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgvDanhSachCacMonHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_dscmh = new Guna.UI2.WinForms.Guna2Panel();
            this.panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbDanhSachCacMonHoc = new System.Windows.Forms.Label();
            this.pane_dscmh.SuspendLayout();
            this.panel_DanhSachCacMonHoc.SuspendLayout();
            this.grbDanhSachCacMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachCacMonHoc)).BeginInit();
            this.panel_dscmh.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pane_dscmh
            // 
            this.pane_dscmh.Controls.Add(this.panel_DanhSachCacMonHoc);
            this.pane_dscmh.Controls.Add(this.panel_dscmh);
            this.pane_dscmh.Location = new System.Drawing.Point(0, 0);
            this.pane_dscmh.Name = "pane_dscmh";
            this.pane_dscmh.Size = new System.Drawing.Size(1136, 743);
            this.pane_dscmh.TabIndex = 0;
            // 
            // panel_DanhSachCacMonHoc
            // 
            this.panel_DanhSachCacMonHoc.Controls.Add(this.btnDangKyHocPhan);
            this.panel_DanhSachCacMonHoc.Controls.Add(this.grbDanhSachCacMonHoc);
            this.panel_DanhSachCacMonHoc.Location = new System.Drawing.Point(0, 60);
            this.panel_DanhSachCacMonHoc.Name = "panel_DanhSachCacMonHoc";
            this.panel_DanhSachCacMonHoc.Size = new System.Drawing.Size(1136, 743);
            this.panel_DanhSachCacMonHoc.TabIndex = 65;
            // 
            // btnDangKyHocPhan
            // 
            this.btnDangKyHocPhan.BorderRadius = 10;
            this.btnDangKyHocPhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKyHocPhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKyHocPhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKyHocPhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKyHocPhan.FillColor = System.Drawing.Color.Green;
            this.btnDangKyHocPhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKyHocPhan.ForeColor = System.Drawing.Color.White;
            this.btnDangKyHocPhan.Location = new System.Drawing.Point(776, 645);
            this.btnDangKyHocPhan.Name = "btnDangKyHocPhan";
            this.btnDangKyHocPhan.Size = new System.Drawing.Size(230, 35);
            this.btnDangKyHocPhan.TabIndex = 19;
            this.btnDangKyHocPhan.Text = "Đăng ký học phần";
            this.btnDangKyHocPhan.Click += new System.EventHandler(this.btnDangKyHocPhan_Click);
            // 
            // grbDanhSachCacMonHoc
            // 
            this.grbDanhSachCacMonHoc.BackColor = System.Drawing.Color.White;
            this.grbDanhSachCacMonHoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(110)))), ((int)(((byte)(91)))));
            this.grbDanhSachCacMonHoc.BorderRadius = 30;
            this.grbDanhSachCacMonHoc.Controls.Add(this.dtgvDanhSachCacMonHoc);
            this.grbDanhSachCacMonHoc.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(110)))), ((int)(((byte)(91)))));
            this.grbDanhSachCacMonHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(119)))));
            this.grbDanhSachCacMonHoc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachCacMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            this.grbDanhSachCacMonHoc.Location = new System.Drawing.Point(119, 72);
            this.grbDanhSachCacMonHoc.Name = "grbDanhSachCacMonHoc";
            this.grbDanhSachCacMonHoc.Size = new System.Drawing.Size(888, 552);
            this.grbDanhSachCacMonHoc.TabIndex = 2;
            this.grbDanhSachCacMonHoc.Text = "Các môn học đã đăng ký";
            this.grbDanhSachCacMonHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgvDanhSachCacMonHoc
            // 
            this.dtgvDanhSachCacMonHoc.AllowUserToResizeColumns = false;
            this.dtgvDanhSachCacMonHoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvDanhSachCacMonHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDanhSachCacMonHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachCacMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDanhSachCacMonHoc.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDanhSachCacMonHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDanhSachCacMonHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDanhSachCacMonHoc.Location = new System.Drawing.Point(1, 33);
            this.dtgvDanhSachCacMonHoc.Name = "dtgvDanhSachCacMonHoc";
            this.dtgvDanhSachCacMonHoc.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachCacMonHoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvDanhSachCacMonHoc.RowHeadersVisible = false;
            this.dtgvDanhSachCacMonHoc.Size = new System.Drawing.Size(886, 494);
            this.dtgvDanhSachCacMonHoc.TabIndex = 1;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(119)))));
            this.dtgvDanhSachCacMonHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDanhSachCacMonHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvDanhSachCacMonHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDanhSachCacMonHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.ReadOnly = true;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDanhSachCacMonHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvDanhSachCacMonHoc.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvDanhSachCacMonHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDanhSachCacMonHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvDanhSachCacMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachCacMonHoc_CellContentClick);
            // 
            // panel_dscmh
            // 
            this.panel_dscmh.BackColor = System.Drawing.Color.White;
            this.panel_dscmh.Controls.Add(this.panel);
            this.panel_dscmh.Location = new System.Drawing.Point(0, 0);
            this.panel_dscmh.Name = "panel_dscmh";
            this.panel_dscmh.Size = new System.Drawing.Size(1136, 60);
            this.panel_dscmh.TabIndex = 64;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderRadius = 20;
            this.panel.Controls.Add(this.lbDanhSachCacMonHoc);
            this.panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.panel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.panel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.panel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.panel.Location = new System.Drawing.Point(335, 6);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(466, 51);
            this.panel.TabIndex = 50;
            // 
            // lbDanhSachCacMonHoc
            // 
            this.lbDanhSachCacMonHoc.AutoSize = true;
            this.lbDanhSachCacMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.lbDanhSachCacMonHoc.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachCacMonHoc.ForeColor = System.Drawing.Color.White;
            this.lbDanhSachCacMonHoc.Location = new System.Drawing.Point(100, 9);
            this.lbDanhSachCacMonHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDanhSachCacMonHoc.Name = "lbDanhSachCacMonHoc";
            this.lbDanhSachCacMonHoc.Size = new System.Drawing.Size(288, 31);
            this.lbDanhSachCacMonHoc.TabIndex = 0;
            this.lbDanhSachCacMonHoc.Text = "Danh sách các môn học";
            // 
            // fDanhSachMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 743);
            this.Controls.Add(this.pane_dscmh);
            this.Name = "fDanhSachMonHoc";
            this.Load += new System.EventHandler(this.fDanhSachMonHoc_Load);
            this.pane_dscmh.ResumeLayout(false);
            this.panel_DanhSachCacMonHoc.ResumeLayout(false);
            this.grbDanhSachCacMonHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachCacMonHoc)).EndInit();
            this.panel_dscmh.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pane_dscmh;
        private Guna.UI2.WinForms.Guna2Panel panel_dscmh;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel;
        private System.Windows.Forms.Label lbDanhSachCacMonHoc;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_DanhSachCacMonHoc;
        private Guna.UI2.WinForms.Guna2GroupBox grbDanhSachCacMonHoc;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvDanhSachCacMonHoc;
        private Guna.UI2.WinForms.Guna2Button btnDangKyHocPhan;
    }
}