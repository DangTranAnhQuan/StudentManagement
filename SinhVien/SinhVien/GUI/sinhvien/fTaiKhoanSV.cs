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
using QuanLySinhVien;
using SinhVien.GUI.sinhvien;

namespace SinhVien
{
    public partial class fTaiKhoanSV : Form
    {
        private Thong_Tin_Sinh_Vien _sv;
        private Thong_Tin_Khoa_Hoc _kh;
        public fTaiKhoanSV(Thong_Tin_Sinh_Vien sv, Thong_Tin_Khoa_Hoc kh)
        {
            InitializeComponent();
            _sv = sv;
            _kh = kh;
        }

        private void fTaiKhoanSV_Load(object sender, EventArgs e)
        {
            pbAnhDaiDien.Size = new Size(175, 175);
            pbAnhDaiDien.SizeMode = PictureBoxSizeMode.StretchImage;
            if (_sv.Photo != null && _sv.Photo.Length > 0)
            {
                try
                {
                    Image originalImage = ByteArrayToImage(_sv.Photo.ToArray());
                    Image resizedImage = ResizeImage(originalImage, 160, 175);
                    pbAnhDaiDien.Image = resizedImage;
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể tải ảnh đại diện. Ảnh có thể bị hỏng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pbAnhDaiDien.Image = null;
                }
            }
            else
            {
                pbAnhDaiDien.Image = null;
            }
            txtTen.Text = _sv.HoTen ?? "";
            txtNgaySinh.Text = _sv.NgaySinh.ToString("dd/MM/yyyy");
            txtChuyenNganh.Text = _kh.Nganh ?? "";
            txtNgayNhapHoc.Text = _kh.NgayNhapHoc.ToString("dd/MM/yyyy") ?? "";
        }  
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
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

        private bool UpdatePassword(Thong_Tin_Sinh_Vien sv, string newPassword)
        {
            try
            {
                using (DatabaseDataContext db = new DatabaseDataContext())
                {
                    var sinhVien = db.TaiKhoans.FirstOrDefault(s => s.MaNguoiDung == sv.MaSV);
                    if (sinhVien != null)
                    {
                        sinhVien.MatKhau = newPassword;
                        db.SubmitChanges();

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi cập nhật mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            fDoiMatKhau formDoiMatKhau = new fDoiMatKhau(_sv, UpdatePassword);
            formDoiMatKhau.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?","Xác nhận đăng xuất",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                fDangNhap loginForm = new fDangNhap();
                loginForm.Show();
                Form mainForm = Application.OpenForms.OfType<fSinhVien>().FirstOrDefault();
                if (mainForm != null)
                {
                    mainForm.Close();
                }
                else
                {
                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Close();
                    }
                }
            }
        }
    }
}
