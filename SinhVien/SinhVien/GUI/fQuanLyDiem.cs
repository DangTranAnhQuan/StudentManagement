using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien.GUI
{
    public partial class fQuanLyDiem : Form
    {
        public fQuanLyDiem()
        {
            InitializeComponent();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            if (btnMark.Enabled == true)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn lưu?",
                    "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Người dùng chọn Cancel, không làm gì cả
                }
            }

        }

        // Quân có để cách tính điểm và 2 cách báo lỗi
        private void txb_DiemTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void TinhDiemTrungBinh()
        {
            float diemQT, diemCK, diemtb;
            if (float.TryParse(txb_DiemQT.Text, out diemQT) && float.TryParse(txb_DiemCK.Text, out diemCK))
            {
                diemtb = (diemQT + diemCK) / 2;
                txb_DiemTB.Text = diemtb.ToString("0.00");
            }
            else
            {
                txb_DiemTB.Text = "";
            }
        }

        private void txb_DiemQT_TextChanged(object sender, EventArgs e)
        {
            TinhDiemTrungBinh();
        }

        private void txb_DiemCK_TextChanged(object sender, EventArgs e)
        {
            TinhDiemTrungBinh();
        }

        private void txb_DiemQT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }

            // Chỉ cho phép một dấu chấm (.) duy nhất trong số thực
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txb_DiemCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled= true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }
}
