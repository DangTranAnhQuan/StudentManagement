using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SinhVien.GUI.Quan_Tri_Vien;

namespace SinhVien.GUI
{
    public partial class fQuanTriVien : Form
    {
        private Form activeForm = null;
        public fQuanTriVien()
        {
            InitializeComponent();
        }

        private void moveImageBox(object sender)
        {
            Guna2Button btn = (Guna2Button)sender;
            imgSlide.Location = new Point(imgSlide.Location.X, btn.Location.Y - 103);
            imgSlide.SendToBack();
        }
        private void fQuanTriVien_Load(object sender, EventArgs e)
        {
            OpenThongTinChung(new fThongTinChung(this));
        }

        private void OpenQuanLySinhVien(fQuanLySV fQuanLySV)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = fQuanLySV;
            fQuanLySV.TopLevel = false;
            fQuanLySV.FormBorderStyle = FormBorderStyle.None;
            fQuanLySV.Dock = DockStyle.Fill;
            panel_main.Controls.Add(fQuanLySV);
            panel_main.Tag = fQuanLySV;
            fQuanLySV.BringToFront();
            fQuanLySV.Show();
        }

        private void OpenQuanLyLopHoc(fQuanLyPhongHoc fQuanLyLopHoc)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = fQuanLyLopHoc;
            fQuanLyLopHoc.TopLevel = false;
            fQuanLyLopHoc.FormBorderStyle = FormBorderStyle.None;
            fQuanLyLopHoc.Dock = DockStyle.Fill;
            panel_main.Controls.Add(fQuanLyLopHoc);
            panel_main.Tag = fQuanLyLopHoc;
            fQuanLyLopHoc.BringToFront();
            fQuanLyLopHoc.Show();
        }

        private void OpenQuanLyMonHoc(fQuanLyMonHoc fQuanLyMonHoc)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = fQuanLyMonHoc;
            fQuanLyMonHoc.TopLevel = false;
            fQuanLyMonHoc.FormBorderStyle = FormBorderStyle.None;
            fQuanLyMonHoc.Dock = DockStyle.Fill;
            panel_main.Controls.Add(fQuanLyMonHoc);
            panel_main.Tag = fQuanLyMonHoc;
            fQuanLyMonHoc.BringToFront();
            fQuanLyMonHoc.Show();
        }

        private void OpenQuanLyGiangVien(fQuanLyGiangVien fQuanLyGiangVien)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = fQuanLyGiangVien;
            fQuanLyGiangVien.TopLevel = false;
            fQuanLyGiangVien.FormBorderStyle = FormBorderStyle.None;
            fQuanLyGiangVien.Dock = DockStyle.Fill;
            panel_main.Controls.Add(fQuanLyGiangVien);
            panel_main.Tag = fQuanLyGiangVien;
            fQuanLyGiangVien.BringToFront();
            fQuanLyGiangVien.Show();
        }

        private void OpenThongTinChung(fThongTinChung fThongTinChung)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = fThongTinChung;
            fThongTinChung.TopLevel = false;
            fThongTinChung.FormBorderStyle = FormBorderStyle.None;
            fThongTinChung.Dock = DockStyle.Fill;
            panel_main.Controls.Add(fThongTinChung);
            panel_main.Tag = fThongTinChung;
            fThongTinChung.BringToFront();
            fThongTinChung.Show();
        }

        private void btnQuanLySinhVien_Click(object sender, EventArgs e)
        {
            OpenQuanLySinhVien(new fQuanLySV(this));
            moveImageBox(btnQuanLySinhVien);
        }

        private void btnThongTinChung_Click_1(object sender, EventArgs e)
        {
            OpenThongTinChung(new fThongTinChung(this));
            moveImageBox(btnThongTinChung);
        }

        private void btnQuanLyGiangVien_Click(object sender, EventArgs e)
        {
            OpenQuanLyGiangVien(new fQuanLyGiangVien(this));
            moveImageBox(btnQuanLyGiangVien);
        }

        private void btnQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            OpenQuanLyMonHoc(new fQuanLyMonHoc(this));
            moveImageBox(btnQuanLyMonHoc);
        }

        private void btnQuanLyLopHoc_Click(object sender, EventArgs e)
        {
            OpenQuanLyLopHoc(new fQuanLyPhongHoc(this));
            moveImageBox(btnQuanLyLopHoc);
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
