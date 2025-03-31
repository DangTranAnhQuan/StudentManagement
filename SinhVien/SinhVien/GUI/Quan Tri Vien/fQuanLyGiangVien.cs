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
    public partial class fQuanLyGiangVien : Form
    {
        public fQuanLyGiangVien(fQuanTriVien fQuanTriVien)
        {
            InitializeComponent();

            dtgvDanhSachGiangVien.DefaultCellStyle.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            dtgvDanhSachGiangVien.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dtgvDanhSachGiangVien.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        }

        public class GV
        {
            public int MaGV { get; set; }
            public string HoTen { get; set; }
            public string GioiTinh { get; set; }
            public DateTime NgaySinh { get; set; }
            public string TenKhoa { get; set; }
            public string DienThoai { get; set; }
            public string Email { get; set; }
            public string MatKhau { get; set; }
            public string CCCD { get; set; }
            public string DanToc { get; set; }
            public string NoiSinh { get; set; }
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void fQuanLyGiangVien_Load(object sender, EventArgs e)
        {
            LoadKhoa();
            LoadDanhSachGiangVien();
            EnabledButton();
        }

        private void LoadKhoa()
        {
            var dsKhoa = db.Khoas.Select(k => new { k.MaKhoa, k.TenKhoa }).ToList();

            cbbKhoa.DataSource = dsKhoa;
            dsKhoa.Insert(0, new { MaKhoa = "", TenKhoa = "Chọn khoa" });
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa"; 
            cbbKhoa.SelectedIndex = 0;
        }

        private void LoadDanhSachGiangVien()
        {
            List<GV> dsgv = (from gv in db.GiangViens
                        join khoa in db.Khoas on gv.MaKhoa equals khoa.MaKhoa
                        select new GV
                        { 
                            MaGV = gv.MaGV, 
                            HoTen = gv.HoTen, 
                            GioiTinh = gv.GioiTinh, 
                            NgaySinh = gv.NgaySinh, 
                            TenKhoa = khoa.TenKhoa, 
                            DienThoai = gv.DienThoai, 
                            Email = gv.Email, 
                            MatKhau = gv.MatKhau,
                            CCCD = gv.CCCD,
                            DanToc = gv.DanToc,
                            NoiSinh = gv.NoiSinh
                        }).ToList();

            dtgvDanhSachGiangVien.DataSource = dsgv;
            RenameColumn(dtgvDanhSachGiangVien);
        }

        private void dtgvDanhSachGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaGV.Text = Convert.ToString(dtgvDanhSachGiangVien.CurrentRow.Cells["MaGV"].Value);
                txtHoTen.Text = Convert.ToString(dtgvDanhSachGiangVien.CurrentRow.Cells["HoTen"].Value);
                dtpNgaySinh.Text = Convert.ToString(dtgvDanhSachGiangVien.CurrentRow.Cells["NgaySinh"].Value);

                if (Convert.ToString(dtgvDanhSachGiangVien.CurrentRow.Cells["GioiTinh"].Value) == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }

                txtEmail.Text = Convert.ToString(dtgvDanhSachGiangVien.CurrentRow.Cells["Email"].Value); 
                txtSdt.Text = Convert.ToString(dtgvDanhSachGiangVien.CurrentRow.Cells["DienThoai"].Value); 
                cbbKhoa.Text = Convert.ToString(dtgvDanhSachGiangVien.CurrentRow.Cells["TenKhoa"].Value); 
                txtMatKhau.Text = Convert.ToString(dtgvDanhSachGiangVien.CurrentRow.Cells["MatKhau"].Value);
                txtCCCD.Text = Convert.ToString(dtgvDanhSachGiangVien.CurrentRow.Cells["CCCD"].Value);
                cbbDanToc.Text = Convert.ToString(dtgvDanhSachGiangVien.CurrentRow.Cells["DanToc"].Value);
                txtNoiSinh.Text = Convert.ToString(dtgvDanhSachGiangVien.CurrentRow.Cells["NoiSinh"].Value);
            }
        }

        private void dtgvDanhSachGiangVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgvDanhSachGiangVien.ClearSelection();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string Ma = txtTimKiem.Text;

            if (Ma == "")
            {
                MessageBox.Show("Vui lòng nhập mã giảng viên cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<GV> dsgv = (from gv in db.GiangViens
                        join khoa in db.Khoas on gv.MaKhoa equals khoa.MaKhoa
                        where gv.MaGV.ToString().ToLower().Contains(Ma.ToLower())
                        select new GV
                        { 
                            MaGV = gv.MaGV, 
                            HoTen = gv.HoTen, 
                            GioiTinh = gv.GioiTinh, 
                            NgaySinh = gv.NgaySinh, 
                            TenKhoa = khoa.TenKhoa, 
                            DienThoai = gv.DienThoai, 
                            Email = gv.Email, 
                            MatKhau = gv.MatKhau,
                            CCCD = gv.CCCD,
                            DanToc = gv.DanToc,
                            NoiSinh = gv.NoiSinh
                        }).ToList();

            if (dsgv.Count == 0)
            {
                MessageBox.Show("Không tìm thấy giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dtgvDanhSachGiangVien.DataSource = dsgv;
            RenameColumn(dtgvDanhSachGiangVien);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDanhSachGiangVien();
            ClearTextBox();
            txtTimKiem.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DisableButton();
            ClearTextBox();

            txtMaGV.ReadOnly = false;
            txtMaGV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachGiangVien.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int MaGV = Convert.ToInt32(txtMaGV.Text);
                GiangVien gv = db.GiangViens.FirstOrDefault(g => g.MaGV == MaGV);
                db.GiangViens.DeleteOnSubmit(gv);
                db.SubmitChanges();
                MessageBox.Show("Xóa giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachGiangVien();
                ClearTextBox();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachGiangVien.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin giảng viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtMaGV.Text == "" || txtHoTen.Text == "" || txtEmail.Text == "" || txtSdt.Text == "" || txtMatKhau.Text == "" || cbbKhoa.SelectedIndex == 0 || txtCCCD.Text == "" || cbbDanToc.SelectedIndex == 0 || txtNoiSinh.Text == "" || (!rdbNam.Checked && !rdbNu.Checked))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GiangVien gv = db.GiangViens.FirstOrDefault(g => g.MaGV == Convert.ToInt32(txtMaGV.Text));
                gv.HoTen = txtHoTen.Text;
                gv.Email = txtEmail.Text;
                gv.DienThoai = txtSdt.Text;
                gv.MatKhau = txtMatKhau.Text;
                gv.MaKhoa = cbbKhoa.SelectedValue.ToString();
                gv.CCCD = txtCCCD.Text;
                gv.DanToc = cbbDanToc.Text;
                gv.NoiSinh = txtNoiSinh.Text;
                gv.NgaySinh = dtpNgaySinh.Value;
                if (rdbNam.Checked)
                {
                    gv.GioiTinh = "Nam";
                }
                else
                {
                    gv.GioiTinh = "Nữ";
                }
                db.SubmitChanges();
                MessageBox.Show("Sửa thông tin giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachGiangVien();
                ClearTextBox();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "" || txtHoTen.Text == "" || txtEmail.Text == "" || txtSdt.Text == "" || txtMatKhau.Text == "" || cbbKhoa.SelectedIndex == 0 || txtCCCD.Text == "" || cbbDanToc.SelectedIndex == 0 || txtNoiSinh.Text == "" || (!rdbNam.Checked && !rdbNu.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckMaGV(Convert.ToInt32(txtMaGV.Text)))
            {
                MessageBox.Show("Mã giảng viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GiangVien gv = new GiangVien();
            gv.MaGV = Convert.ToInt32(txtMaGV.Text);
            gv.HoTen = txtHoTen.Text;
            gv.Email = txtEmail.Text;
            gv.DienThoai = txtSdt.Text;
            gv.MatKhau = txtMatKhau.Text;
            gv.MaKhoa = cbbKhoa.SelectedValue.ToString();
            gv.CCCD = txtCCCD.Text;
            gv.DanToc = cbbDanToc.Text;
            gv.NoiSinh = txtNoiSinh.Text;
            gv.NgaySinh = dtpNgaySinh.Value;
            if (rdbNam.Checked)
            {
                gv.GioiTinh = "Nam";
            }
            else
            {
                gv.GioiTinh = "Nữ";
            }

            db.GiangViens.InsertOnSubmit(gv);
            db.SubmitChanges();
            MessageBox.Show("Thêm giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaGV.ReadOnly = true;
            LoadDanhSachGiangVien();
            ClearTextBox();
            EnabledButton();

        }

        private bool CheckMaGV(int v)
        {
            GiangVien check = db.GiangViens.FirstOrDefault(g => g.MaGV == v);
            if (check != null)
            {
                return true;
            }
            return false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaGV.ReadOnly = true;
            EnabledButton();
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            txtMaGV.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSdt.Text = "";
            txtMatKhau.Text = "";
            cbbKhoa.SelectedIndex = 0;
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            txtCCCD.Text = "";
            cbbDanToc.SelectedIndex = 0;
            txtNoiSinh.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            dtgvDanhSachGiangVien.ClearSelection();
        }

        private void DisableButton()
        {
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void EnabledButton()
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void RenameColumn(DataGridView dtgvDanhSachGiangVien)
        {
            dtgvDanhSachGiangVien.Columns["MaGV"].HeaderText = "Mã GV";
            dtgvDanhSachGiangVien.Columns["HoTen"].HeaderText = "Họ tên";
            dtgvDanhSachGiangVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dtgvDanhSachGiangVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtgvDanhSachGiangVien.Columns["TenKhoa"].HeaderText = "Khoa";
            dtgvDanhSachGiangVien.Columns["DienThoai"].HeaderText = "Điện thoại";
            dtgvDanhSachGiangVien.Columns["Email"].HeaderText = "Email";
            dtgvDanhSachGiangVien.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dtgvDanhSachGiangVien.Columns["CCCD"].HeaderText = "CCCD";
            dtgvDanhSachGiangVien.Columns["DanToc"].HeaderText = "Dân tộc";
            dtgvDanhSachGiangVien.Columns["NoiSinh"].HeaderText = "Nơi sinh";
        }
    }
}
