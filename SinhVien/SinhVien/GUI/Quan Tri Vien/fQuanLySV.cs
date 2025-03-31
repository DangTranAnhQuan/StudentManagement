using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien.GUI.Quan_Tri_Vien
{
    public partial class fQuanLySV : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public fQuanLySV(fQuanTriVien fQuanTriVien)
        {
            InitializeComponent();

            dtgvDanhSachSinhVien.DefaultCellStyle.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            dtgvDanhSachSinhVien.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dtgvDanhSachSinhVien.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        }

        class SV
        {
            public string MaSV { get; set; }
            public string HoTen { get; set; }
            public DateTime NgaySinh { get; set; }
            public string NoiSinh { get; set; }
            public string GioiTinh { get; set; }
            public string CCCD { get; set; }
            public string DanToc { get; set; }
            public string LopSV { get; set; }
            public string MatKhau { get; set; }
            //public Image Photo { get; set; }
        }
        private void fQuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachSinhVien();
            EnabledButton();
        }

        private void LoadDanhSachSinhVien()
        {
            List<SV> dssv = db.Thong_Tin_Sinh_Viens.Select(sv => new SV
            {   
                MaSV = sv.MaSV, 
                HoTen = sv.HoTen, 
                NgaySinh = sv.NgaySinh, 
                NoiSinh = sv.NoiSinh, 
                GioiTinh = sv.GioiTinh, 
                CCCD = sv.CCCD, 
                DanToc = sv.DanToc, 
                LopSV = sv.LopSV, 
                MatKhau = sv.MatKhau, 
                //Photo = sv.Photo
            }).ToList();
            dtgvDanhSachSinhVien.DataSource = dssv;
            RenameColumn(dtgvDanhSachSinhVien);
        }

        private void RenameColumn(DataGridView dtgvDanhSachSinhVien)
        {
            dtgvDanhSachSinhVien.Columns["MaSv"].HeaderText = "Mã Sinh viên";
            dtgvDanhSachSinhVien.Columns["HoTen"].HeaderText = "Họ tên";
            dtgvDanhSachSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtgvDanhSachSinhVien.Columns["NoiSinh"].HeaderText = "Nơi sinh";
            dtgvDanhSachSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dtgvDanhSachSinhVien.Columns["CCCD"].HeaderText = "CCCD";
            dtgvDanhSachSinhVien.Columns["DanToc"].HeaderText = "Dân tộc";
            dtgvDanhSachSinhVien.Columns["LopSV"].HeaderText = "Lớp";
            dtgvDanhSachSinhVien.Columns["MatKhau"].HeaderText = "Mật khẩu";
            //dtgvDanhSachSinhVien.Columns["Photo"].Visible = false;
        }

        private void dtgvDanhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMSSV.Text = Convert.ToString(dtgvDanhSachSinhVien.CurrentRow.Cells["MaSV"].Value);
                txtHoTen.Text = Convert.ToString(dtgvDanhSachSinhVien.CurrentRow.Cells["HoTen"].Value);
                dtpNgaySinh.Text = Convert.ToString(dtgvDanhSachSinhVien.CurrentRow.Cells["NgaySinh"].Value);
                txtNoiSinh.Text = Convert.ToString(dtgvDanhSachSinhVien.CurrentRow.Cells["NoiSinh"].Value);
                if (Convert.ToString(dtgvDanhSachSinhVien.CurrentRow.Cells["GioiTinh"].Value) == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
                txtCCCD.Text = Convert.ToString(dtgvDanhSachSinhVien.CurrentRow.Cells["CCCD"].Value);
                cbbDanToc.Text = Convert.ToString(dtgvDanhSachSinhVien.CurrentRow.Cells["DanToc"].Value).Trim();
                txtLopSinhVien.Text = Convert.ToString(dtgvDanhSachSinhVien.CurrentRow.Cells["LopSV"].Value);
                txtMatKhau.Text = Convert.ToString(dtgvDanhSachSinhVien.CurrentRow.Cells["MatKhau"].Value);
                //ptbAnhSinhVien.Image = Image.FromFile(dsnv[0].Photo);
            }
        }

        private void txtNoiSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLopSinhVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbDanToc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgvDanhSachSinhVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgvDanhSachSinhVien.ClearSelection();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string Ma = txtTimKiem.Text;

            if (Ma == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<SV> dssv = db.Thong_Tin_Sinh_Viens.Where(sv => sv.MaSV.ToLower().Contains(Ma.ToLower())).Select(sv => new SV
            {
                MaSV = sv.MaSV,
                HoTen = sv.HoTen,
                NgaySinh = sv.NgaySinh,
                NoiSinh = sv.NoiSinh,
                GioiTinh = sv.GioiTinh,
                CCCD = sv.CCCD,
                DanToc = sv.DanToc,
                LopSV = sv.LopSV,
                MatKhau = sv.MatKhau,
                //Photo = sv.Photo
            }).ToList();

            if (dssv.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dtgvDanhSachSinhVien.DataSource = dssv;
            RenameColumn(dtgvDanhSachSinhVien);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            DisableButton();

            txtMSSV.ReadOnly = false;
            txtMSSV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachSinhVien.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string Ma = txtMSSV.Text;
                Thong_Tin_Sinh_Vien sv = db.Thong_Tin_Sinh_Viens.FirstOrDefault(s => s.MaSV == Ma);
                db.Thong_Tin_Sinh_Viens.DeleteOnSubmit(sv);
                db.SubmitChanges();
                MessageBox.Show("Xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachSinhVien();
                ClearTextBox();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachSinhVien.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin sinh viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                if (txtMSSV.Text == "" || txtHoTen.Text == "" || dtpNgaySinh.Text == "" || txtNoiSinh.Text == "" || txtCCCD.Text == "" || cbbDanToc.SelectedIndex == 0 || txtLopSinhVien.Text == "" || txtMatKhau.Text == "" || (!rdbNam.Checked && !rdbNu.Checked))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string Ma = txtMSSV.Text;
                Thong_Tin_Sinh_Vien sv = db.Thong_Tin_Sinh_Viens.FirstOrDefault(s => s.MaSV == Ma);
                sv.HoTen = txtHoTen.Text;
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.NoiSinh = txtNoiSinh.Text;
                sv.CCCD = txtCCCD.Text;
                sv.DanToc = cbbDanToc.Text;
                sv.LopSV = txtLopSinhVien.Text;
                sv.MatKhau = txtMatKhau.Text;
                if (rdbNam.Checked)
                {
                    sv.GioiTinh = "Nam";
                }
                else
                {
                    sv.GioiTinh = "Nữ";
                }
                db.SubmitChanges();
                MessageBox.Show("Sửa thông tin sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachSinhVien();
                ClearTextBox();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text == "" || txtHoTen.Text == "" || dtpNgaySinh.Text == "" || txtNoiSinh.Text == "" || txtCCCD.Text == "" || cbbDanToc.SelectedIndex == 0 || txtLopSinhVien.Text == "" || txtMatKhau.Text == "" || (!rdbNam.Checked && !rdbNu.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckMaSV(txtMSSV.Text))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Thong_Tin_Sinh_Vien sv = new Thong_Tin_Sinh_Vien();
            sv.MaSV = txtMSSV.Text;
            sv.HoTen = txtHoTen.Text;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.NoiSinh = txtNoiSinh.Text;
            sv.CCCD = txtCCCD.Text;
            sv.DanToc = cbbDanToc.Text;
            sv.LopSV = txtLopSinhVien.Text;
            sv.MatKhau = txtMatKhau.Text;
            if (rdbNam.Checked)
            {
                sv.GioiTinh = "Nam";
            }
            else
            {
                sv.GioiTinh = "Nữ";
            }
            db.Thong_Tin_Sinh_Viens.InsertOnSubmit(sv);
            db.SubmitChanges();

            MessageBox.Show("Thêm sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMSSV.ReadOnly = true;
            LoadDanhSachSinhVien();
            EnabledButton();
            ClearTextBox();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMSSV.ReadOnly = true;
            EnabledButton();
            ClearTextBox();
        }

        private bool CheckMaSV(string text)
        {
            string Ma = text;

            Thong_Tin_Sinh_Vien check = db.Thong_Tin_Sinh_Viens.FirstOrDefault(sv => sv.MaSV == Ma);
            if (check != null)
            {
                return true;
            }
            return false;
        }

        private void ClearTextBox()
        {
            txtMSSV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Text = "";
            txtNoiSinh.Text = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            txtCCCD.Text = "";
            cbbDanToc.SelectedIndex = 0;
            txtLopSinhVien.Text = "";
            txtMatKhau.Text = "";
            dtgvDanhSachSinhVien.ClearSelection();
        }

        private void DisableButton()
        {
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void EnabledButton()
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDanhSachSinhVien();
            ClearTextBox();
            txtTimKiem.Text = "";
        }
    }
}
