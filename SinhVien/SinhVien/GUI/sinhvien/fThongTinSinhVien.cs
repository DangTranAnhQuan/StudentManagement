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
using System.Windows.Forms.DataVisualization.Charting;

namespace SinhVien
{
    public partial class fThongTinSinhVien : Form
    {

        private Form activeForm = null;
        private Thong_Tin_Sinh_Vien _sv;
        private Thong_Tin_Nguoi_LH _lhsv;
        private Thong_Tin_Lien_Lac _ll;
        private Thong_Tin_Khoa_Hoc _kh;
        private TinhThanh _th;
        private QuanHuyen _qh;
        private fSinhVien parentSinhVien;
        public fThongTinSinhVien(Thong_Tin_Sinh_Vien sv, Thong_Tin_Lien_Lac ll, Thong_Tin_Khoa_Hoc kh,Thong_Tin_Nguoi_LH lhsv,TinhThanh th, QuanHuyen qh)
        {
            InitializeComponent();
            _sv = sv;
            _ll = ll;
            _kh = kh;
            _lhsv = lhsv;
            _th = th;
            _qh = qh;
        }
        public fThongTinSinhVien(fSinhVien parentForm) : this(parentForm.SinhVien, parentForm.LienLacSV, parentForm.KhoaHocSV, parentForm.LienHeSinhVien, parentForm.TinhThanh, parentForm.QuanHuyen)
        {
            this.parentSinhVien = parentForm;
        }
        public void RefreshData()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                _sv = db.Thong_Tin_Sinh_Viens.FirstOrDefault(sv => sv.MaSV == _sv.MaSV);
                _ll = db.Thong_Tin_Lien_Lacs.FirstOrDefault(ll => ll.MaSV == _sv.MaSV);
                _kh = db.Thong_Tin_Khoa_Hocs.FirstOrDefault(kh => kh.MaSV == _sv.MaSV);
                _lhsv = db.Thong_Tin_Nguoi_LHs.FirstOrDefault(lh => lh.MaSV == _sv.MaSV);

                if (_ll != null)
                {
                    _th = db.TinhThanhs.FirstOrDefault(t => t.MaTinhThanh == _ll.MaTinhThanh);
                    _qh = db.QuanHuyens.FirstOrDefault(q => q.MaQuanHuyen == _ll.MaQuanHuyen && q.MaTinhThanh == _ll.MaTinhThanh);
                }
            }

            txtMaSinhVien.Text = _sv.MaSV ?? "";
            txtHoTen.Text = _sv.HoTen ?? "";
            txtNgaySinh.Text = _sv.NgaySinh.ToString("dd/MM/yyyy");
            txtNoiSinh.Text = _sv.NoiSinh ?? "";
            txtGioiTinh.Text = _sv.GioiTinh ?? "";
            txtCCCD.Text = _sv.CCCD ?? "";
            txtDanToc.Text = _sv.DanToc ?? "";
            txtLopSinhVien.Text = _sv.LopSV ?? "";

            if (_ll != null)
            {
                txtQuocGia.Text = _ll.QuocGia ?? "";
                txtPhuongXa.Text = _ll.Phuong ?? "";
                txtDiaChi.Text = _ll.DiaChi ?? "";
                txtDiDong.Text = _ll.DiDong ?? "";
                txtEmail.Text = _ll.Email ?? "";
            }

            if (_kh != null)
            {
                txtKhoaHoc.Text = _kh.KhoaHoc ?? "";
                txtKhoa.Text = _kh.Khoa ?? "";
                txtNgayNhapHoc.Text = _kh.NgayNhapHoc.ToString("dd/MM/yyyy");
                txtLoaiHinhDaoTao.Text = _kh.LoaiHinhDaoTao ?? "";
                txtChuongTrinhDaoTao.Text = _kh.ChuongTrinhDaoTao ?? "";
                txtNganh.Text = _kh.Nganh ?? "";
                txtNienKhoa.Text = _kh.NienKhoa ?? "";
            }
            txtTinhThanh.Text = _th != null ? _th.TenTinhThanh ?? "" : "";
            txtQuanHuyen.Text = _qh != null ? _qh.TenQuanHuyen ?? "" : "";
        }
        private void fThongTinSinhVien_Load(object sender, EventArgs e)
        {
            pbAnhDaiDien.Size = new Size(160, 160);
            pbAnhDaiDien.SizeMode = PictureBoxSizeMode.StretchImage;
            if (_sv == null)
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMaSinhVien.Text = _sv.MaSV ?? "";
            txtHoTen.Text = _sv.HoTen ?? "";
            txtNgaySinh.Text = _sv.NgaySinh.ToString("dd/MM/yyyy")??"";
            txtNoiSinh.Text = _sv.NoiSinh ?? "";
            txtGioiTinh.Text = _sv.GioiTinh ?? "";
            txtCCCD.Text = _sv.CCCD ?? "";
            txtDanToc.Text = _sv.DanToc ?? "";
            txtLopSinhVien.Text = _sv.LopSV ?? "";
            if (_sv.Photo != null && _sv.Photo.Length > 0)
            {
                try
                {
                    Image originalImage = ByteArrayToImage(_sv.Photo.ToArray());
                    Image resizedImage = ResizeImage(originalImage, 160, 160);
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
            if (_ll != null)
            {
                txtQuocGia.Text = _ll.QuocGia ?? "";
                txtPhuongXa.Text = _ll.Phuong ?? "";
                txtDiaChi.Text = _ll.DiaChi ?? "";
                txtDiDong.Text = _ll.DiDong ?? "";
                txtEmail.Text = _ll.Email ?? "";
            }

            if (_ll != null)
            {
                using (DatabaseDataContext db = new DatabaseDataContext())
                {
                    _th = db.TinhThanhs.FirstOrDefault(t => t.MaTinhThanh == _ll.MaTinhThanh);
                    _qh = db.QuanHuyens.FirstOrDefault(q => q.MaQuanHuyen == _ll.MaQuanHuyen && q.MaTinhThanh == _ll.MaTinhThanh);
                }
            }
            txtTinhThanh.Text = _th != null ? _th.TenTinhThanh ?? "" : "";
            txtQuanHuyen.Text = _qh != null ? _qh.TenQuanHuyen ?? "" : "";

            if (_th != null)
            {
                txtTinhThanh.Text = _th.TenTinhThanh ?? "";
            }
            if (_qh != null)
            {
                txtQuanHuyen.Text = _qh.TenQuanHuyen ?? "";
            }
            if (_kh != null)
            {
                txtKhoaHoc.Text = _kh.KhoaHoc ?? "";
                txtKhoa.Text = _kh.Khoa ?? "";
                txtNgayNhapHoc.Text = _kh.NgayNhapHoc.ToString("dd/MM/yyyy")??"";
                txtLoaiHinhDaoTao.Text = _kh.LoaiHinhDaoTao ?? "";
                txtChuongTrinhDaoTao.Text = _kh.ChuongTrinhDaoTao ?? "";
                txtNganh.Text = _kh.Nganh ?? "";
                txtNienKhoa.Text = _kh.NienKhoa ?? "";
            }
            Chart chart = new Chart();

            chart.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);
            Series series = new Series("Điểm trung bình");
            series.ChartType = SeriesChartType.Column; 
            chart.Series.Add(series);

            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var diemData = from diem in db.Diems
                               join mh in db.MonHocs on diem.MaMonHoc equals mh.MaMonHoc
                               where diem.MaSV == _sv.MaSV
                               select new
                               {
                                   mh.TenMonHoc,
                                   diem.DiemTB
                               };

                foreach (var item in diemData)
                {
                    series.Points.AddXY(item.TenMonHoc, item.DiemTB);
                }
            }
            Title title = new Title("Biểu đồ điểm trung bình các môn học", Docking.Top, new Font("Verdana", 12), Color.Black);
            chart.Titles.Add(title);

            panel_kqht.Controls.Add(chart);
            chart.BringToFront();
        }

        public void OpenCapNhatThongTinSV(Form CapNhatThongTinSVForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = CapNhatThongTinSVForm;
            CapNhatThongTinSVForm.TopLevel = false;
            CapNhatThongTinSVForm.FormBorderStyle = FormBorderStyle.None;
            CapNhatThongTinSVForm.Dock = DockStyle.Fill;
            panelmain.Controls.Add(CapNhatThongTinSVForm);
            panelmain.Tag = CapNhatThongTinSVForm;
            CapNhatThongTinSVForm.BringToFront();
            CapNhatThongTinSVForm.Show();
        }
        private void btnCapNhatThongTinSV_Click(object sender, EventArgs e)
        {
            var capNhatForm = new fCapNhatThongTinSinhVien(_sv, _ll, _kh, _lhsv,_th,_qh);
            capNhatForm.DataUpdated += (s, evt) =>
            {
                RefreshData();
            };
            OpenCapNhatThongTinSV(capNhatForm);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbAnhDaiDien.Image = Image.FromFile(openFileDialog.FileName);
                pbAnhDaiDien.Tag = openFileDialog.FileName; 
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat); 
                return ms.ToArray();
            }
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
        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var sinhVien = db.Thong_Tin_Sinh_Viens.FirstOrDefault(sv => sv.MaSV == _sv.MaSV);
                if (sinhVien != null)
                {
                    if (pbAnhDaiDien.Image != null)
                    {
                        byte[] imageBytes = ImageToByteArray(pbAnhDaiDien.Image);
                        sinhVien.Photo = new System.Data.Linq.Binary(imageBytes);
                    }
                    else
                    {
                        sinhVien.Photo = null;
                    }
                    db.SubmitChanges();
                    MessageBox.Show("Lưu ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _sv.Photo = sinhVien.Photo;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (parentSinhVien != null)
                {
                    parentSinhVien.SinhVien.Photo = _sv.Photo;
                    parentSinhVien.UpdateAvatar();
                }
            }
        }
    }
}
