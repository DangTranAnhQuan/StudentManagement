using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SinhVien.GUI;
using SinhVien.GUI.sinhvien;

namespace SinhVien
{
    public partial class fSinhVien : Form
    {
        private Thong_Tin_Sinh_Vien _sv;

        private Form activeForm = null;
        public Thong_Tin_Sinh_Vien SinhVien { get; set; }
        public Thong_Tin_Nguoi_LH LienHeSinhVien { get; set; }
        public Thong_Tin_Lien_Lac LienLacSV { get; set; }
        public Thong_Tin_Khoa_Hoc KhoaHocSV { get; set; }
        public TinhThanh TinhThanh { get; set; }
        public QuanHuyen QuanHuyen { get; set; }
        public HocPhan HocPhan { get; set; }
        public DangKyHoc KyHoc { get; set; }
        public fSinhVien(Thong_Tin_Sinh_Vien sv)
        {
            InitializeComponent();
            _sv = sv;
        }
        private void fSinhVien_Load(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                _sv = db.Thong_Tin_Sinh_Viens.FirstOrDefault(sv => sv.MaSV == _sv.MaSV);
            }
            this.SinhVien = _sv;
            txtAvatar.Text = _sv.HoTen+"\n"+ _sv.MaSV;
            if (SinhVien != null && SinhVien.Photo != null && SinhVien.Photo.Length > 0)
            {
                Image originalImage = ByteArrayToImage(_sv.Photo.ToArray());
                Image resizedImage = ResizeImage(originalImage, 64, 64);
                pbAnhDaiDien2.Image = resizedImage;
            }
            OpenChildForm(new fThongTinSinhVien(this));
        }
        private void moveImageBox(object sender)
        {
            Guna2Button btn = (Guna2Button)sender;
            pctieude.Location = new Point(pctieude.Location.X, btn.Location.Y - 68);
            pctieude.SendToBack();
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Clear();
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedBitmap = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedBitmap))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedBitmap;
        }
        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fThongTinSinhVien(this));
            moveImageBox(btnThongTinCaNhan);
        }
        public void UpdateAvatar()
        {
            if (SinhVien != null && SinhVien.Photo != null && SinhVien.Photo.Length > 0)
            {
                Image originalImage = ByteArrayToImage(SinhVien.Photo.ToArray());
                Image resizedImage = ResizeImage(originalImage, 64, 64);
                pbAnhDaiDien2.Image = resizedImage;
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
        private void btnDanhSachMonHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fDanhSachMonHoc(this));
            moveImageBox(btnDanhSachMonHoc);
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fXemDiem(SinhVien));
            moveImageBox(btnXemDiem);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTaiKhoanSV(SinhVien,KhoaHocSV));
            moveImageBox(btnTaiKhoan);
        }
    }
}
