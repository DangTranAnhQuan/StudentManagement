using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien.GUI.Quan_Tri_Vien
{
    public partial class fQuanLyMonHoc : Form
    {
        public fQuanLyMonHoc(fQuanTriVien fQuanTriVien)
        {
            InitializeComponent();

            dtgvDanhSachMonHoc.DefaultCellStyle.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            dtgvDanhSachMonHoc.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dtgvDanhSachMonHoc.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        }
        
        class Mon
        {
            public string MaMonHoc { get; set; }
            public string TenMonHoc { get; set; }
            public int SoTinChi { get; set; }
            public string MaKhoa { get; set; }
            public string TenKhoa { get; set; }
            public int SoTiet { get; set; }
            public string LoaiMon { get; set; }
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private List<Mon> DanhSachHienTai = new List<Mon>();
        private void fQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            LoadKhoa();
            LoadDanhSachMonHoc();
            EnabledButton();
        }

        private void LoadKhoa()
        {
            var dsKhoa = db.Khoas.Select(k => new { k.MaKhoa, k.TenKhoa }).ToList();
            dsKhoa.Insert(0, new { MaKhoa = "", TenKhoa = "Chọn khoa" });
            cbbKhoa.DataSource = dsKhoa;
            cbbLocKhoa.DataSource = new BindingSource(dsKhoa, null);
            cbbKhoa.DisplayMember = cbbLocKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = cbbLocKhoa.ValueMember = "MaKhoa";
        }

        private void LoadDanhSachMonHoc()
        {
            List<Mon> dsmh = (from mh in db.MonHocs
                       join khoa in db.Khoas on mh.MaKhoa equals khoa.MaKhoa
                       select new Mon
                       {
                           MaMonHoc = mh.MaMonHoc,
                           TenMonHoc = mh.TenMonHoc,
                           SoTinChi = mh.SoTinChi,
                           MaKhoa = khoa.MaKhoa,
                           TenKhoa = khoa.TenKhoa,
                           SoTiet = mh.SoTiet,
                           LoaiMon = mh.LoaiMon
                        }).ToList();

            dtgvDanhSachMonHoc.DataSource = dsmh;
            RenameColumn(dtgvDanhSachMonHoc);

            DanhSachHienTai = dsmh;
        }

        private void dtgvDanhSachMonHoc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgvDanhSachMonHoc.ClearSelection();
        }

        private void dtgvDanhSachMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                txtMaMonHoc.Text = Convert.ToString(dtgvDanhSachMonHoc.CurrentRow.Cells["MaMonHoc"].Value);
                txtTenMonHoc.Text = Convert.ToString(dtgvDanhSachMonHoc.CurrentRow.Cells["TenMonHoc"].Value);
                txtSoTinChi.Text = Convert.ToString(dtgvDanhSachMonHoc.CurrentRow.Cells["SoTinChi"].Value);
                cbbKhoa.Text = Convert.ToString(dtgvDanhSachMonHoc.CurrentRow.Cells["TenKhoa"].Value);
                txtSoTiet.Text = Convert.ToString(dtgvDanhSachMonHoc.CurrentRow.Cells["SoTiet"].Value);
                cbbLoaiMon.Text = Convert.ToString(dtgvDanhSachMonHoc.CurrentRow.Cells["LoaiMon"].Value);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<Mon> dsmh = DanhSachHienTai
                            .Where(mh => mh.MaMonHoc.ToLower().Contains(txtTimKiem.Text.ToLower()) ||
                                         mh.TenMonHoc.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();

            if (dsmh.Count == 0)
            {
                MessageBox.Show("Không tìm thấy môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dtgvDanhSachMonHoc.DataSource = dsmh;
            DanhSachHienTai = dsmh;
            RenameColumn(dtgvDanhSachMonHoc);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (txtLocSoTiet.Text == "" && txtLocSoTinChi.Text == "" && cbbLocKhoa.SelectedIndex == 0 && cbbLocLoaiMon.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn điều kiện lọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Mon> query = DanhSachHienTai;
            if (txtLocSoTiet.Text != "")
            {
                query = query.Where(m => m.SoTiet == Convert.ToInt32(txtLocSoTiet.Text)).ToList();
            }
            if (txtLocSoTinChi.Text != "")
            {
                query = query.Where(m => m.SoTinChi == Convert.ToInt32(txtLocSoTinChi.Text)).ToList();
            }
            if (cbbLocKhoa.SelectedIndex != 0)
            {
                query = query.Where(m => m.MaKhoa == cbbLocKhoa.SelectedValue.ToString()).ToList();
            }
            if (cbbLocLoaiMon.SelectedIndex != 0)
            {
                query = query.Where(m => m.LoaiMon == cbbLocLoaiMon.Text).ToList();
            }

            if (query.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DanhSachHienTai = query;

            dtgvDanhSachMonHoc.DataSource = query;
            RenameColumn(dtgvDanhSachMonHoc);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtLocSoTiet.Text = "";
            txtLocSoTinChi.Text = "";
            cbbLocKhoa.SelectedIndex = 0;
            cbbLocLoaiMon.SelectedIndex = 0;
            txtTimKiem.Text = "";

            ClearTextBox();
            LoadDanhSachMonHoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DisableButton();
            ClearTextBox();

            txtMaMonHoc.Focus();
            txtMaMonHoc.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachMonHoc.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MonHoc mh = db.MonHocs.FirstOrDefault(m => m.MaMonHoc == txtMaMonHoc.Text);
                db.MonHocs.DeleteOnSubmit(mh);
                db.SubmitChanges();
                MessageBox.Show("Xóa môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachMonHoc();
                ClearTextBox();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachMonHoc.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa môn học này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                if (txtMaMonHoc.Text == "" || txtTenMonHoc.Text == "" || txtSoTinChi.Text == "" || cbbKhoa.SelectedIndex == 0 || txtSoTiet.Text == "" || cbbLoaiMon.SelectedIndex == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MonHoc mh = db.MonHocs.FirstOrDefault(m => m.MaMonHoc == txtMaMonHoc.Text);
                mh.TenMonHoc = txtTenMonHoc.Text;
                mh.SoTinChi = Convert.ToInt32(txtSoTinChi.Text);
                mh.MaKhoa = cbbKhoa.SelectedValue.ToString();
                mh.SoTiet = Convert.ToInt32(txtSoTiet.Text);
                mh.LoaiMon = cbbLoaiMon.Text;
                db.SubmitChanges();
                MessageBox.Show("Sửa môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachMonHoc();
                ClearTextBox();
                EnabledButton();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaMonHoc.Text == "" || txtTenMonHoc.Text == "" || txtSoTinChi.Text == "" || cbbKhoa.SelectedIndex == 0 || txtSoTiet.Text == "" || cbbLoaiMon.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckMaMH(txtMaMonHoc.Text))
            {
                MessageBox.Show("Mã môn học đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MonHoc mh = new MonHoc();
            mh.MaMonHoc = txtMaMonHoc.Text;
            mh.TenMonHoc = txtTenMonHoc.Text;
            mh.SoTinChi = Convert.ToInt32(txtSoTinChi.Text);
            mh.MaKhoa = cbbKhoa.SelectedValue.ToString();
            mh.SoTiet = Convert.ToInt32(txtSoTiet.Text);
            mh.LoaiMon = cbbLoaiMon.Text;
            db.MonHocs.InsertOnSubmit(mh);
            db.SubmitChanges();

            MessageBox.Show("Thêm môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaMonHoc.ReadOnly = true;
            LoadDanhSachMonHoc();
            ClearTextBox();
            EnabledButton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaMonHoc.ReadOnly = true;
            EnabledButton();
            ClearTextBox();
        }

        private bool CheckMaMH(string text)
        {
            var mh = db.MonHocs.FirstOrDefault(m => m.MaMonHoc == text);
            if (mh != null)
            {
                return true;
            }
            return false;
        }

        private void ClearTextBox()
        {
            txtMaMonHoc.Text = "";
            txtTenMonHoc.Text = "";
            txtSoTinChi.Text = "";
            cbbKhoa.SelectedIndex = 0;
            txtSoTiet.Text = "";
            cbbLoaiMon.SelectedIndex = 0;
            dtgvDanhSachMonHoc.ClearSelection();
        }

        private void DisableButton()
        {
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void EnabledButton()
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void RenameColumn(DataGridView dtgvDanhSachMonHoc)
        {
            dtgvDanhSachMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDanhSachMonHoc.Columns["MaMonHoc"].HeaderText = "Mã môn học";
            dtgvDanhSachMonHoc.Columns["TenMonHoc"].HeaderText = "Tên môn học";
            dtgvDanhSachMonHoc.Columns["SoTinChi"].HeaderText = "Số tín chỉ";
            dtgvDanhSachMonHoc.Columns["TenKhoa"].HeaderText = "Tên khoa";
            dtgvDanhSachMonHoc.Columns["SoTiet"].HeaderText = "Số tiết";
            dtgvDanhSachMonHoc.Columns["LoaiMon"].HeaderText = "Loại môn";

            dtgvDanhSachMonHoc.Columns["MaKhoa"].Visible = false;
        }

        private void txtLocSoTiet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtLocSoTinChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtSoTinChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtSoTiet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
