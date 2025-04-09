namespace SinhVien.GUI.sinhvien
{
    partial class fXemDiem
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
            this.panel_XemDiem = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.grbDiem = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgvDiemMonHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_XemDiemMain = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel_XemDiemTieuDe = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_xd = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbThongTinSinhVien = new System.Windows.Forms.Label();
            this.panel_XemDiem.SuspendLayout();
            this.grbDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiemMonHoc)).BeginInit();
            this.panel_XemDiemMain.SuspendLayout();
            this.panel_XemDiemTieuDe.SuspendLayout();
            this.panel_xd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_XemDiem
            // 
            this.panel_XemDiem.Controls.Add(this.grbDiem);
            this.panel_XemDiem.Location = new System.Drawing.Point(0, 60);
            this.panel_XemDiem.Name = "panel_XemDiem";
            this.panel_XemDiem.Size = new System.Drawing.Size(1136, 683);
            this.panel_XemDiem.TabIndex = 65;
            // 
            // grbDiem
            // 
            this.grbDiem.BackColor = System.Drawing.Color.White;
            this.grbDiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(110)))), ((int)(((byte)(91)))));
            this.grbDiem.BorderRadius = 30;
            this.grbDiem.Controls.Add(this.dtgvDiemMonHoc);
            this.grbDiem.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(110)))), ((int)(((byte)(91)))));
            this.grbDiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(119)))));
            this.grbDiem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            this.grbDiem.Location = new System.Drawing.Point(119, 72);
            this.grbDiem.Name = "grbDiem";
            this.grbDiem.Size = new System.Drawing.Size(888, 552);
            this.grbDiem.TabIndex = 3;
            this.grbDiem.Text = "Điểm môn học";
            this.grbDiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgvDiemMonHoc
            // 
            this.dtgvDiemMonHoc.AllowUserToResizeColumns = false;
            this.dtgvDiemMonHoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvDiemMonHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDiemMonHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDiemMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDiemMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDiemMonHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDiemMonHoc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgvDiemMonHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDiemMonHoc.Location = new System.Drawing.Point(1, 33);
            this.dtgvDiemMonHoc.Name = "dtgvDiemMonHoc";
            this.dtgvDiemMonHoc.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDiemMonHoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvDiemMonHoc.RowHeadersVisible = false;
            this.dtgvDiemMonHoc.Size = new System.Drawing.Size(886, 494);
            this.dtgvDiemMonHoc.TabIndex = 1;
            this.dtgvDiemMonHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDiemMonHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvDiemMonHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvDiemMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvDiemMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvDiemMonHoc.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(119)))));
            this.dtgvDiemMonHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDiemMonHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvDiemMonHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvDiemMonHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDiemMonHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvDiemMonHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiemMonHoc.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvDiemMonHoc.ThemeStyle.ReadOnly = true;
            this.dtgvDiemMonHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDiemMonHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDiemMonHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDiemMonHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvDiemMonHoc.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvDiemMonHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDiemMonHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel_XemDiemMain
            // 
            this.panel_XemDiemMain.Controls.Add(this.panel_XemDiem);
            this.panel_XemDiemMain.Controls.Add(this.panel_XemDiemTieuDe);
            this.panel_XemDiemMain.Location = new System.Drawing.Point(0, 0);
            this.panel_XemDiemMain.Name = "panel_XemDiemMain";
            this.panel_XemDiemMain.Size = new System.Drawing.Size(1136, 743);
            this.panel_XemDiemMain.TabIndex = 2;
            // 
            // panel_XemDiemTieuDe
            // 
            this.panel_XemDiemTieuDe.BackColor = System.Drawing.Color.White;
            this.panel_XemDiemTieuDe.Controls.Add(this.panel_xd);
            this.panel_XemDiemTieuDe.Location = new System.Drawing.Point(0, 0);
            this.panel_XemDiemTieuDe.Name = "panel_XemDiemTieuDe";
            this.panel_XemDiemTieuDe.Size = new System.Drawing.Size(1136, 60);
            this.panel_XemDiemTieuDe.TabIndex = 64;
            // 
            // panel_xd
            // 
            this.panel_xd.BackColor = System.Drawing.Color.White;
            this.panel_xd.BorderRadius = 20;
            this.panel_xd.Controls.Add(this.lbThongTinSinhVien);
            this.panel_xd.FillColor = System.Drawing.Color.Green;
            this.panel_xd.FillColor2 = System.Drawing.Color.Green;
            this.panel_xd.FillColor3 = System.Drawing.Color.Green;
            this.panel_xd.FillColor4 = System.Drawing.Color.Green;
            this.panel_xd.Location = new System.Drawing.Point(335, 6);
            this.panel_xd.Name = "panel_xd";
            this.panel_xd.Size = new System.Drawing.Size(466, 51);
            this.panel_xd.TabIndex = 50;
            // 
            // lbThongTinSinhVien
            // 
            this.lbThongTinSinhVien.AutoSize = true;
            this.lbThongTinSinhVien.BackColor = System.Drawing.Color.Green;
            this.lbThongTinSinhVien.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinSinhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(239)))));
            this.lbThongTinSinhVien.Location = new System.Drawing.Point(167, 9);
            this.lbThongTinSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThongTinSinhVien.Name = "lbThongTinSinhVien";
            this.lbThongTinSinhVien.Size = new System.Drawing.Size(131, 31);
            this.lbThongTinSinhVien.TabIndex = 0;
            this.lbThongTinSinhVien.Text = "Xem điểm";
            // 
            // fXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 744);
            this.Controls.Add(this.panel_XemDiemMain);
            this.Name = "fXemDiem";
            this.Text = "Xem điểm";
            this.Load += new System.EventHandler(this.fXemDiem_Load);
            this.panel_XemDiem.ResumeLayout(false);
            this.grbDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiemMonHoc)).EndInit();
            this.panel_XemDiemMain.ResumeLayout(false);
            this.panel_XemDiemTieuDe.ResumeLayout(false);
            this.panel_xd.ResumeLayout(false);
            this.panel_xd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_XemDiem;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_XemDiemMain;
        private Guna.UI2.WinForms.Guna2Panel panel_XemDiemTieuDe;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_xd;
        private System.Windows.Forms.Label lbThongTinSinhVien;
        private Guna.UI2.WinForms.Guna2GroupBox grbDiem;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvDiemMonHoc;
    }
}