using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.DAL;

namespace QuanLySinhVien.GUI
{
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
            dtgv_TaiKhoan.ReadOnly = true;
            dtgv_TaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_TaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_TaiKhoan_CellContentClick);
        }

        private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            btn_Tailai.PerformClick(); // load lại tk mới cho vô
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string tendangnhap = txb_TenDangNhap.Text.Trim();
            string matkhau = txb_MatKhau.Text.Trim();
            string loaitaikhoan = cbb_LoaiTaiKhoan.SelectedItem.ToString();
            if (tendangnhap.Length > 0 && matkhau.Length > 6 && loaitaikhoan.Length > 0)
            {
                try
                {
                    if (BLL_TaiKhoan.Instance.Them(tendangnhap, matkhau, loaitaikhoan) == true)
                    {
                        btn_Tailai.PerformClick(); // load lại tk mới cho vô
                    }
                }
                catch 
                {
                    MessageBox.Show("Tên đăng nhập không được trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không được dưới 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Tailai_Click(object sender, EventArgs e)
        {
            dtgv_TaiKhoan.DataSource = BLL_TaiKhoan.Instance.DanhSach();
        }

        private void dtgv_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_TaiKhoan.Rows[e.RowIndex];
                txb_TenDangNhap.Text = row.Cells[0].Value.ToString();
                txb_MatKhau.Text = row.Cells[1].Value.ToString();
                string loaitaikhoan = cbb_LoaiTaiKhoan.SelectedItem.ToString();
                loaitaikhoan = row.Cells[2].Value.ToString();
            }
        }
    }
}
