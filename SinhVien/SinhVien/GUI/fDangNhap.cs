    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using SinhVien;
    using SinhVien.GUI;

    namespace QuanLySinhVien
    {
    
        public partial class fDangNhap : Form
        {
            DatabaseDataContext db = new DatabaseDataContext();
            public fDangNhap()
            {
                InitializeComponent();
            }
       

            private void fDangNhap_Load(object sender, EventArgs e)
            {
                swHienThiMatKhau.Checked = false;
            }

            private void btnDangnhap_Click(object sender, EventArgs e)
            {
                string tenDangNhap = txb_TenDangNhap.Text.Trim();
                string matKhau = txb_MatKhau.Text.Trim();

                if (cbb_LoaiTaiKhoan.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn loại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearControls();
                    return;
                }

                string loaiTaiKhoanCombo = cbb_LoaiTaiKhoan.SelectedItem.ToString();
                string loaiTaiKhoanDB = MapLoaiTaiKhoan(loaiTaiKhoanCombo);
                if (string.IsNullOrEmpty(loaiTaiKhoanDB))
                {
                    MessageBox.Show("Loại tài khoản không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearControls();
                    return;
                }

                var taiKhoanCandidate = (from tk in db.TaiKhoans
                                         where tk.TenDangNhap == tenDangNhap &&
                                               tk.MatKhau == matKhau &&
                                               tk.LoaiNguoiDung == loaiTaiKhoanDB
                                         select tk).FirstOrDefault();

                if (taiKhoanCandidate != null)
                {
                    if (!string.Equals(taiKhoanCandidate.TenDangNhap, tenDangNhap, StringComparison.Ordinal) ||
                        !string.Equals(taiKhoanCandidate.MatKhau, matKhau, StringComparison.Ordinal))
                    {
                        taiKhoanCandidate = null;
                    }
                }

                if (taiKhoanCandidate == null)
                {
                    MessageBox.Show("Sai tên đăng nhập, mật khẩu hoặc loại tài khoản!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                    return;
                }

                Form formMoi = null;

                if (taiKhoanCandidate.LoaiNguoiDung == "SinhVien")
                {
                    ClearControls();
                    var thongTinSinhVien = db.Thong_Tin_Sinh_Viens.FirstOrDefault(x => x.MaSV == taiKhoanCandidate.MaNguoiDung);
                    var thongTinLienLacSV = db.Thong_Tin_Lien_Lacs.FirstOrDefault(x => x.MaSV == taiKhoanCandidate.MaNguoiDung);
                    var thongTinNguoiLH = db.Thong_Tin_Nguoi_LHs.FirstOrDefault(x => x.MaSV == taiKhoanCandidate.MaNguoiDung);
                    var thongTinKhoaHocSV = db.Thong_Tin_Khoa_Hocs.FirstOrDefault(x => x.MaSV == taiKhoanCandidate.MaNguoiDung);
                    if (thongTinSinhVien == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var fSV = new fSinhVien(thongTinSinhVien);
                    fSV.SinhVien = thongTinSinhVien;
                    fSV.LienLacSV = thongTinLienLacSV;
                    fSV.LienHeSinhVien = thongTinNguoiLH; 
                    fSV.KhoaHocSV = thongTinKhoaHocSV;
                    formMoi = fSV;
                }
                else if (taiKhoanCandidate.LoaiNguoiDung == "GiangVien")
                {
                    ClearControls();
                    var thongTinGiangVien = db.GiangViens.FirstOrDefault(x => x.MaGV == taiKhoanCandidate.MaNguoiDung);
                    var thongTinLienLacGV = db.Thong_Tin_Lien_Lac_GVs.FirstOrDefault(x => x.MaGV == taiKhoanCandidate.MaNguoiDung);
                    var thongTinLHGV = db.Thong_Tin_Lien_Lac_GVs.FirstOrDefault(x => x.MaGV == taiKhoanCandidate.MaNguoiDung);
                    if (thongTinGiangVien == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin giảng viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var fGV = new fGiangVien();
                    formMoi = fGV;
                }
                else if (taiKhoanCandidate.LoaiNguoiDung == "Admin")
                {
                    ClearControls();
                    formMoi = new fQuanTriVien();
                }
                else
                {
                    MessageBox.Show("Loại tài khoản không được hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                    return;
                }
                this.Hide();
                formMoi.ShowDialog();
                ClearControls();

            }
            private string MapLoaiTaiKhoan(string loaiTaiKhoanCombo)
            {
                if (loaiTaiKhoanCombo.Equals("Sinh viên", StringComparison.OrdinalIgnoreCase))
                    return "SinhVien";
                if (loaiTaiKhoanCombo.Equals("Giảng viên", StringComparison.OrdinalIgnoreCase))
                    return "GiangVien";
                if (loaiTaiKhoanCombo.Equals("Quản trị viên", StringComparison.OrdinalIgnoreCase))
                    return "Admin";
                return string.Empty;
            }
            private void ClearControls()
            {
                txb_TenDangNhap.Clear();
                txb_MatKhau.Clear();
                cbb_LoaiTaiKhoan.SelectedIndex = -1;
                swHienThiMatKhau.Checked = false;
            }

            private void swHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
            {
                if (swHienThiMatKhau.Checked == true)
                {
                    txb_MatKhau.UseSystemPasswordChar = false;
                }
                else
                {
                    txb_MatKhau.UseSystemPasswordChar= true;
                }
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
        
    }

