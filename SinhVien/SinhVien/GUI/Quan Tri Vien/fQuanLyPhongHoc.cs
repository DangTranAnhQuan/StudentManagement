using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SinhVien.GUI.Quan_Tri_Vien.fQuanLyPhongHoc;

namespace SinhVien.GUI.Quan_Tri_Vien
{
    public partial class fQuanLyPhongHoc : Form
    {
        public fQuanLyPhongHoc(fQuanTriVien fQuanTriVien)
        {
            InitializeComponent();

            dtgvDanhSachPhongHoc.DefaultCellStyle.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            dtgvDanhSachPhongHoc.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dtgvDanhSachPhongHoc.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        }

        public class Phong
        {
            public string MaPhong { get; set; }
            public int SucChua { get; set; }
            public string HoTen { get; set; }
            public string LoaiPhong { get; set; }
            public int TietBatDau { get; set; }
            public int TietKetThuc { get; set; }
        }

        DatabaseDataContext db = new DatabaseDataContext();
        private List<Phong> DanhSachHienTai = new List<Phong>();
        private void fQuanLyPhongHoc_Load(object sender, EventArgs e)
        {
            LoadGiangVien();
            LoadDanhSachPhongHoc();
            EnabledButton();
        }

        private void LoadDanhSachPhongHoc()
        {
            List<Phong> dsph = (from ph in db.PhongHocs
                       join gv in db.GiangViens on ph.GiangVienPhuTrach equals gv.MaGV
                       select new Phong
                       {
                           MaPhong = ph.MaPhong,
                           SucChua = ph.SucChua,
                           HoTen = gv.HoTen,
                           LoaiPhong = ph.LoaiPhong,
                           TietBatDau = ph.TietBatDau,
                           TietKetThuc = ph.TietKetThuc
                       }).ToList();
            dtgvDanhSachPhongHoc.DataSource = dsph;
            DanhSachHienTai = dsph;
            RenameColumn(dtgvDanhSachPhongHoc);
        }

        private void LoadGiangVien()
        {
            var dsgv = db.GiangViens.Select(gv => new { gv.MaGV, gv.HoTen }).ToList();
            dsgv.Insert(0, new { MaGV = 0, HoTen = "Giảng viên phụ trách"});
            cbbGiangVien.DataSource = dsgv;
            cbbLocGiangVien.DataSource = new BindingSource(dsgv, null);
            cbbGiangVien.DisplayMember = cbbLocGiangVien.DisplayMember = "HoTen";
            cbbGiangVien.ValueMember = cbbLocGiangVien.ValueMember = "MaGV";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Phong> dsph = DanhSachHienTai.Where(ph => ph.MaPhong.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
            if (dsph.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phòng học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dtgvDanhSachPhongHoc.DataSource = dsph;
            DanhSachHienTai = dsph;
            RenameColumn(dtgvDanhSachPhongHoc);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (txtLocSucChua.Text == "" && cbbLocGiangVien.SelectedIndex == 0 && cbbLocLoaiPhong.SelectedIndex == 0 && cbbLocTietDau.SelectedIndex == 0 && cbbLocTietKet.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn điều kiện lọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Phong> query = DanhSachHienTai;
            if (txtLocSucChua.Text != "")
            {
                query = query.Where(ph => ph.SucChua == Convert.ToInt32(txtLocSucChua.Text)).ToList();
            }
            if (cbbLocGiangVien.SelectedIndex != 0)
            {
                query = query.Where(ph => ph.HoTen == cbbLocGiangVien.Text).ToList();
            }
            if (cbbLocLoaiPhong.SelectedIndex != 0)
            {
                query = query.Where(ph => ph.LoaiPhong == cbbLocLoaiPhong.Text).ToList();
            }
            if (cbbLocTietDau.SelectedIndex != 0)
            {
                query = query.Where(ph => ph.TietBatDau == cbbLocTietDau.SelectedIndex).ToList();
            }
            if (cbbLocTietKet.SelectedIndex != 0)
            {
                query = query.Where(ph => ph.TietKetThuc == cbbLocTietKet.SelectedIndex).ToList();
            }

            if (query.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy phòng học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dtgvDanhSachPhongHoc.DataSource = query;
            DanhSachHienTai = query;
            RenameColumn(dtgvDanhSachPhongHoc);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtLocSucChua.Text = "";
            cbbLocGiangVien.SelectedIndex = 0;
            cbbLocLoaiPhong.SelectedIndex = 0;
            cbbLocTietDau.SelectedIndex = 0;
            cbbLocTietKet.SelectedIndex = 0;
            txtTimKiem.Text = "";
            ClearTextBox();

            LoadDanhSachPhongHoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DisableButton();
            ClearTextBox();

            txtMaPhongHoc.Focus();
            txtMaPhongHoc.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachPhongHoc.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng học cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng học này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int rowIndex = dtgvDanhSachPhongHoc.SelectedCells[0].RowIndex;

                string maPhong = txtMaPhongHoc.Text;
                int TietBatDau = Convert.ToInt32(dtgvDanhSachPhongHoc.Rows[rowIndex].Cells["TietBatDau"].Value);
                int TietKetThuc = Convert.ToInt32(dtgvDanhSachPhongHoc.Rows[rowIndex].Cells["TietKetThuc"].Value);
                PhongHoc ph = db.PhongHocs.FirstOrDefault(p => p.MaPhong == maPhong && p.TietBatDau == TietBatDau && p.TietKetThuc == TietKetThuc);
                db.PhongHocs.DeleteOnSubmit(ph);
                db.SubmitChanges();
                MessageBox.Show("Xóa phòng học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachPhongHoc();
                ClearTextBox();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPhongHoc.Text == "" || txtSucChua.Text == "" || cbbGiangVien.SelectedIndex == 0 || cbbLoaiPhong.SelectedIndex == 0 || cbbTietBatDau.SelectedIndex == 0 || cbbTietKetThuc.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckPhongHoc(txtMaPhongHoc.Text, cbbTietBatDau.SelectedIndex) || CheckPhongHoc(txtMaPhongHoc.Text, cbbTietKetThuc.SelectedIndex))
            {
                MessageBox.Show("Phòng học đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbbTietBatDau.SelectedIndex > cbbTietKetThuc.SelectedIndex)
            {
                MessageBox.Show("Tiết bắt đầu phải nhỏ hơn tiết kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PhongHoc ph = new PhongHoc();
            ph.MaPhong = txtMaPhongHoc.Text;
            ph.SucChua = Convert.ToInt32(txtSucChua.Text);
            ph.GiangVienPhuTrach = Convert.ToInt32(cbbGiangVien.SelectedValue);
            ph.LoaiPhong = cbbLoaiPhong.Text;
            ph.TietBatDau = cbbTietBatDau.SelectedIndex;
            ph.TietKetThuc = cbbTietKetThuc.SelectedIndex;

            db.PhongHocs.InsertOnSubmit(ph);
            db.SubmitChanges();
            MessageBox.Show("Thêm phòng học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaPhongHoc.ReadOnly = true;
            ClearTextBox();
            LoadDanhSachPhongHoc();
            EnabledButton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaPhongHoc.ReadOnly = true;
            ClearTextBox();
            EnabledButton();
        }

        private void RenameColumn(DataGridView dtgvDanhSachPhongHoc)
        {
            dtgvDanhSachPhongHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvDanhSachPhongHoc.Columns["MaPhong"].HeaderText = "Mã Phòng";
            dtgvDanhSachPhongHoc.Columns["SucChua"].HeaderText = "Sức Chứa";
            dtgvDanhSachPhongHoc.Columns["HoTen"].HeaderText = "Giảng Viên Phụ Trách";
            dtgvDanhSachPhongHoc.Columns["LoaiPhong"].HeaderText = "Loại Phòng";
            dtgvDanhSachPhongHoc.Columns["TietBatDau"].HeaderText = "Tiết Bắt Đầu";
            dtgvDanhSachPhongHoc.Columns["TietKetThuc"].HeaderText = "Tiết Kết Thúc";
        }

        private void ClearTextBox()
        {
            txtMaPhongHoc.Text = "";
            txtSucChua.Text = "";
            cbbGiangVien.SelectedIndex = 0;
            cbbLoaiPhong.SelectedIndex = 0;
            cbbTietBatDau.SelectedIndex = 0;
            cbbTietKetThuc.SelectedIndex = 0;

            dtgvDanhSachPhongHoc.ClearSelection();
        }

        private void DisableButton()
        {
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void EnabledButton()
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dtgvDanhSachPhongHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDanhSachPhongHoc.SelectedCells.Count > 0)
            {
                txtMaPhongHoc.Text = dtgvDanhSachPhongHoc.SelectedRows[0].Cells["MaPhong"].Value.ToString();
                txtSucChua.Text = dtgvDanhSachPhongHoc.SelectedRows[0].Cells["SucChua"].Value.ToString();
                cbbGiangVien.Text = dtgvDanhSachPhongHoc.SelectedRows[0].Cells["HoTen"].Value.ToString();
                cbbLoaiPhong.Text = dtgvDanhSachPhongHoc.SelectedRows[0].Cells["LoaiPhong"].Value.ToString();
                cbbTietBatDau.SelectedIndex = Convert.ToInt32(dtgvDanhSachPhongHoc.SelectedRows[0].Cells["TietBatDau"].Value);
                cbbTietKetThuc.SelectedIndex = Convert.ToInt32(dtgvDanhSachPhongHoc.SelectedRows[0].Cells["TietKetThuc"].Value);
            }
        }

        private bool CheckPhongHoc(string text, int x)
        {
            List<PhongHoc> ph = db.PhongHocs.Where(p => p.MaPhong == text).ToList();
            foreach(PhongHoc phong in ph)
{
                if (x >= phong.TietBatDau && x <= phong.TietKetThuc)
                    return true;
            }
            return false;
        }

        private void dtgvDanhSachPhongHoc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgvDanhSachPhongHoc.ClearSelection();
        }

        private void txtLocSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
