using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien
{
    public partial class fCapNhatThongTinSinhVien : Form
    {
        public event EventHandler DataUpdated;
        private Form activeForm = null;
        private Thong_Tin_Sinh_Vien _sv;
        private Thong_Tin_Khoa_Hoc _kh;
        private Thong_Tin_Nguoi_LH _lhsv;
        private Thong_Tin_Lien_Lac _ll;
        private TinhThanh _th;
        private QuanHuyen _qh;
        private fCapNhatThongTinSinhVien fCapNhatThingTinSinhVien;

        public fCapNhatThongTinSinhVien(fSinhVien parentForm) : this(parentForm.SinhVien, parentForm.LienLacSV, parentForm.KhoaHocSV, parentForm.LienHeSinhVien,parentForm.TinhThanh, parentForm.QuanHuyen)
        {
        }

        public fCapNhatThongTinSinhVien(Thong_Tin_Sinh_Vien sv, Thong_Tin_Lien_Lac ll, Thong_Tin_Khoa_Hoc kh , Thong_Tin_Nguoi_LH lhsv,TinhThanh th, QuanHuyen qh)
        {
            InitializeComponent();
            _sv = sv;
            _ll = ll;
            _kh = kh;
            _lhsv = lhsv;
            _th = th;
            _qh = qh;
            LoadDataToControls();
        }

        public fThongTinSinhVien FThongTinSinhVien { get; }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fCapNhatThongTinSinhVien_Load(object sender, EventArgs e)
        {
            if (_sv == null)
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtLopSinhVien.Text = _sv.LopSV ?? "";
            txtMaSV.Text = _sv.MaSV ?? "";
            txtHoTen.Text = _sv.HoTen ?? "";
            txtNgaySinh.Text = _sv.NgaySinh.ToString("dd/MM/yyyy") ?? "";
            txtNoiSinh.Text = _sv.NoiSinh ?? "";
            txtCCCD.Text = _sv.CCCD ?? "";
            txtDanToc.Text = _sv.DanToc ?? "";
            if (_ll != null)
            {
                cbbLocQuocGia.SelectedValue = _ll.QuocGia ?? "";
                txtPhuongXa.Text = _ll.Phuong ?? "";
                txtSoNha.Text = _ll.SoNha ?? "";
                txtSoDT.Text = _ll.DiDong ?? "";
                txtEmail.Text = _ll.Email ?? "";
                txtDiaChiLienLac.Text = _ll.DiaChi ?? "";
            }
            if (_lhsv != null)
            {
                txtHoTenLH.Text = _lhsv.HoTenLienHe ?? "";
                txtDiaChiLH.Text = _lhsv.DiaChiLienHe ?? "";
                txtSoDTLH.Text = _lhsv.DienThoaiLienHe ?? "";
                txtHoTenCha.Text = _lhsv.HoTenCha ?? "";
                txtSoDTCha.Text = _lhsv.DienThoaiCha ?? "";
                txtHoTenMe.Text = _lhsv.HoTenMe ?? "";
                txtSoDTMe.Text = _lhsv.DienThoaiMe ?? "";
            }

            LoadTinhThanh();
            // Nếu có thông tin về Tỉnh/Quan từ _ll, set lại giá trị cho ComboBox
            if (_ll != null)
            {
                if (_ll.MaTinhThanh != null)
                {
                    cbbTinhThanh.SelectedValue = _ll.MaTinhThanh;
                    LoadQuanHuyen(Convert.ToInt32(_ll.MaTinhThanh));
                }
            }

            // Xử lý sự kiện SelectedIndexChanged của cbbTinhThanh để load Quận Huyện tương ứng
            cbbTinhThanh.SelectedIndexChanged += (s, evt) =>
            {
                if (cbbTinhThanh.SelectedValue != null)
                {
                    int maTinhThanh;
                    if (int.TryParse(cbbTinhThanh.SelectedValue.ToString(), out maTinhThanh))
                    {
                        LoadQuanHuyen(maTinhThanh);
                    }
                }
            };
        }
        private void LoadTinhThanh()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var provinces = db.TinhThanhs.ToList();
                cbbTinhThanh.DataSource = provinces;
                cbbTinhThanh.DisplayMember = "TenTinhThanh";
                cbbTinhThanh.ValueMember = "MaTinhThanh";
                cbbTinhThanh.SelectedIndex = -1;
            }
        }
        private void LoadQuanHuyen(int maTinhThanh)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var districts = db.QuanHuyens.Where(q => q.MaTinhThanh == maTinhThanh).ToList();
                cbbQuanHuyen.DataSource = districts;
                cbbQuanHuyen.DisplayMember = "TenQuanHuyen";
                cbbQuanHuyen.ValueMember = "MaQuanHuyen";
                cbbQuanHuyen.SelectedIndex = -1;
                // Nếu có dữ liệu của _ll, set lại giá trị cho cbbQuanHuyen
                if (_ll != null && _ll.MaQuanHuyen != null)
                {
                    cbbQuanHuyen.SelectedValue = _ll.MaQuanHuyen;
                }
            }
        }

        private void LoadDataToControls()
        {
            txtMaSV.Text = _sv.MaSV ?? "";
            txtHoTen.Text = _sv.HoTen ?? "";
            txtNgaySinh.Text = _sv.NgaySinh.ToString("dd/MM/yyyy") ?? "";
            txtNoiSinh.Text = _sv.NoiSinh ?? "";
            txtCCCD.Text = _sv.CCCD ?? "";
            txtDanToc.Text = _sv.DanToc ?? "";

            if (_ll != null)
            {
                cbbLocQuocGia.SelectedValue = _ll.QuocGia ?? "";
                txtPhuongXa.Text = _ll.Phuong ?? "";
                txtSoNha.Text = _ll.SoNha ?? "";
                txtSoDT.Text = _ll.DiDong ?? "";
                txtEmail.Text = _ll.Email ?? "";
                txtDiaChiLienLac.Text = _ll.DiaChi ?? "";
            }

            if (_lhsv != null)
            {
                txtHoTenLH.Text = _lhsv.HoTenLienHe ?? "";
                txtDiaChiLH.Text = _lhsv.DiaChiLienHe ?? "";
                txtSoDTLH.Text = _lhsv.DienThoaiLienHe ?? "";
                txtHoTenCha.Text = _lhsv.HoTenCha ?? "";
                txtSoDTCha.Text = _lhsv.DienThoaiCha ?? "";
                txtHoTenMe.Text = _lhsv.HoTenMe ?? "";
                txtSoDTMe.Text = _lhsv.DienThoaiMe ?? "";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseDataContext db = new DatabaseDataContext())
                {
                    if (_ll != null)
                    {
                        var svUpdateLienLac = db.Thong_Tin_Lien_Lacs.FirstOrDefault(sv => sv.MaSV == _sv.MaSV);
                        if (svUpdateLienLac != null)
                        {
                            svUpdateLienLac.Email = txtEmail.Text;
                            svUpdateLienLac.DiDong = txtSoDT.Text;
                            svUpdateLienLac.Phuong = txtPhuongXa.Text;
                            svUpdateLienLac.SoNha = txtSoNha.Text;
                            svUpdateLienLac.DiaChi = txtDiaChiLienLac.Text;
                            if (cbbTinhThanh.SelectedValue != null)
                                svUpdateLienLac.MaTinhThanh = Convert.ToInt32(cbbTinhThanh.SelectedValue);
                            if (cbbQuanHuyen.SelectedValue != null)
                                svUpdateLienLac.MaQuanHuyen = Convert.ToInt32(cbbQuanHuyen.SelectedValue);
                        }
                    }
                    if (_lhsv != null)
                    {
                        var nlhsvUpdate = db.Thong_Tin_Nguoi_LHs.FirstOrDefault(lh => lh.MaSV == _sv.MaSV);
                        if (nlhsvUpdate != null)
                        {
                            nlhsvUpdate.HoTenLienHe = txtHoTenLH.Text;
                            nlhsvUpdate.DiaChiLienHe = txtDiaChiLH.Text;
                            nlhsvUpdate.DienThoaiLienHe = txtSoDTLH.Text;
                            nlhsvUpdate.HoTenCha = txtHoTenCha.Text;
                            nlhsvUpdate.DienThoaiCha = txtSoDTCha.Text;
                            nlhsvUpdate.HoTenMe = txtHoTenMe.Text;
                            nlhsvUpdate.DienThoaiMe = txtSoDTMe.Text;
                        }
                    }
                    db.SubmitChanges();
                }

                // Load lại dữ liệu nếu cần (tạo DataContext mới)
                using (DatabaseDataContext db = new DatabaseDataContext())
                {
                    _sv = db.Thong_Tin_Sinh_Viens.FirstOrDefault(sv => sv.MaSV == _sv.MaSV);
                    _ll = db.Thong_Tin_Lien_Lacs.FirstOrDefault(ll => ll.MaSV == _sv.MaSV);
                    _lhsv = db.Thong_Tin_Nguoi_LHs.FirstOrDefault(lh => lh.MaSV == _sv.MaSV);
                }
                LoadDataToControls();
                // Gọi event để thông báo dữ liệu đã cập nhật
                DataUpdated?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Lưu thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
