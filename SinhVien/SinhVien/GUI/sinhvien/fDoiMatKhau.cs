using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien.GUI.sinhvien
{
    public partial class fDoiMatKhau : Form
    {
        private Thong_Tin_Sinh_Vien _sv;
        private Func<Thong_Tin_Sinh_Vien, string, bool> _updatePasswordCallback;
        public fDoiMatKhau(Thong_Tin_Sinh_Vien sv, Func<Thong_Tin_Sinh_Vien, string, bool> updatePasswordCallback)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;

            _sv = sv;
            _updatePasswordCallback = updatePasswordCallback;
        }

        private void fDoiMatKhau_Load(object sender, EventArgs e)
        {
            swHienThiMatKhau.Checked = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string oldPassword = txbMatKhauCu.Text.Trim();
            string newPassword = txb_MatKhau.Text.Trim();
            string confirmPassword = txtXacNhanMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(oldPassword) ||
                string.IsNullOrEmpty(newPassword) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var dp = db.TaiKhoans.FirstOrDefault(s => s.MaNguoiDung == _sv.MaSV);
                if (oldPassword != dp.MatKhau)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(oldPassword == newPassword)
                {
                    MessageBox.Show("Mật khẩu mới và mật khẩu hiện tại không được trùng nhau.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool updateSuccess = _updatePasswordCallback(_sv, newPassword);
                if (updateSuccess)
                {
                    MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void swHienThiMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            if (swHienThiMatKhau.Checked == true)
            {
                txb_MatKhau.UseSystemPasswordChar = false;
                txtXacNhanMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txb_MatKhau.UseSystemPasswordChar = true;
                txtXacNhanMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
