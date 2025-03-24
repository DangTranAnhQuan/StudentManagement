using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien.GUI
{
    public partial class fGiangVien : Form
    {
        public fGiangVien()
        {
            InitializeComponent();
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoiSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDanToc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbThongTinKhoaHoc_Enter(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private Form mainForm;
        private void btnQLSinhVien_Click(object sender, EventArgs e)
        {
            OpenQuanLySV(new fQuanLySinhVien(this));
            btnQLSinhVien.ForeColor = Color.Coral; btnQLSinhVien.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            btnThongTinCaNhan.ForeColor = Color.White; btnThongTinCaNhan.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            btnTaiKhoan.ForeColor = Color.White; btnTaiKhoan.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            btnQLDiem.ForeColor = Color.White; btnQLDiem.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White; btnDangXuat.Font = new Font("Times New Roman", 11, FontStyle.Bold);
        }

        private void OpenTaiKhoan(fTaiKhoan fTaiKhoan)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = fTaiKhoan;
            fTaiKhoan.TopLevel = false;
            fTaiKhoan.FormBorderStyle = FormBorderStyle.None;
            fTaiKhoan.Dock = DockStyle.Fill;
            panel_main.Controls.Add(fTaiKhoan);
            panel_main.Tag = fTaiKhoan;
            fTaiKhoan.BringToFront();
            fTaiKhoan.Show();
        }

        private void OpenQuanLyDiem(fQuanLyDiem fQuanLyDiem)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = fQuanLyDiem;
            fQuanLyDiem.TopLevel = false;
            fQuanLyDiem.FormBorderStyle = FormBorderStyle.None;
            fQuanLyDiem.Dock = DockStyle.Fill;
            panel_main.Controls.Add(fQuanLyDiem);
            panel_main.Tag = fQuanLyDiem;
            fQuanLyDiem.BringToFront();
            fQuanLyDiem.Show();
        }

        private void OpenThongTinCaNhan(fThongTinCaNhan fThongTinCaNhan)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = fThongTinCaNhan;
            fThongTinCaNhan.TopLevel = false;
            fThongTinCaNhan.FormBorderStyle = FormBorderStyle.None;
            fThongTinCaNhan.Dock = DockStyle.Fill;
            panel_main.Controls.Add(fThongTinCaNhan);
            panel_main.Tag = fThongTinCaNhan;
            fThongTinCaNhan.BringToFront();
            fThongTinCaNhan.Show();
        }

        private void OpenQuanLySV(fQuanLySinhVien quanLySinhVien)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = quanLySinhVien;
            quanLySinhVien.TopLevel = false;
            quanLySinhVien.FormBorderStyle = FormBorderStyle.None;
            quanLySinhVien.Dock = DockStyle.Fill;
            panel_main.Controls.Add(quanLySinhVien);
            panel_main.Tag = quanLySinhVien;
            quanLySinhVien.BringToFront();
            quanLySinhVien.Show();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            OpenQuanLySV(new fQuanLySinhVien(this));
            btnThongTinCaNhan.ForeColor = Color.Coral; btnThongTinCaNhan.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            btnQLSinhVien.ForeColor = Color.White; btnQLSinhVien.Font = new Font("Times New Roman",11, FontStyle.Bold);
            btnTaiKhoan.ForeColor = Color.White; btnTaiKhoan.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            btnQLDiem.ForeColor = Color.White; btnQLDiem.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White; btnDangXuat.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            OpenThongTinCaNhan(new fThongTinCaNhan(this));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbThongTinSV_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhatThongTinCaNhan_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }

        private void pbAnhDaiDien_Click(object sender, EventArgs e)
        {

        }

        private void grbThongTinLL_Enter(object sender, EventArgs e)
        {

        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void lbDiDong_Click(object sender, EventArgs e)
        {

        }

        private void lbDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void lbPhuong_Click(object sender, EventArgs e)
        {

        }

        private void lbQuanHuyen_Click(object sender, EventArgs e)
        {

        }

        private void lbTinhThanh_Click(object sender, EventArgs e)
        {

        }

        private void lbQuocGia_Click(object sender, EventArgs e)
        {

        }

        private void txtKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoaiHopDong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbKhoa_Click(object sender, EventArgs e)
        {

        }

        private void lbLoaiHopDong_Click(object sender, EventArgs e)
        {

        }

        private void grbThongTinCaNhan_Enter(object sender, EventArgs e)
        {

        }

        private void dtpkNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbDanToc_Click(object sender, EventArgs e)
        {

        }

        private void lbCCCD_Click(object sender, EventArgs e)
        {

        }

        private void lbGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void lbNoiSinh_Click(object sender, EventArgs e)
        {

        }

        private void lbNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void lbHoTen_Click(object sender, EventArgs e)
        {

        }

        private void lbMaSV_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                guna2CirclePictureBox1.Image = Image.FromFile(opf.FileName);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenQuanLySV(new fQuanLySinhVien(this));
            btnTaiKhoan.ForeColor = Color.Coral; btnTaiKhoan.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            btnThongTinCaNhan.ForeColor = Color.White; btnThongTinCaNhan.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            btnQLSinhVien.ForeColor = Color.White; btnQLSinhVien.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            btnQLDiem.ForeColor = Color.White; btnQLDiem.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White; btnDangXuat.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            OpenTaiKhoan(new fTaiKhoan(this));
        }

        private void btnQLDiem_Click(object sender, EventArgs e)
        {
            OpenQuanLySV(new fQuanLySinhVien(this));
            btnQLDiem.ForeColor = Color.Coral; btnQLDiem.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            btnThongTinCaNhan.ForeColor = Color.White; btnThongTinCaNhan.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            btnTaiKhoan.ForeColor = Color.White; btnTaiKhoan.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            btnQLSinhVien.ForeColor = Color.White; btnQLSinhVien.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White; btnDangXuat.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            OpenQuanLyDiem(new fQuanLyDiem(this));
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void fGiangVien_Load(object sender, EventArgs e)
        {
            OpenThongTinCaNhan(new fThongTinCaNhan(this));
        }
    }
}
