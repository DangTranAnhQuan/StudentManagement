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
    public partial class fQuanLyDiem : Form
    {
        public fQuanLyDiem(fGiangVien fGiangVien)
        {
            InitializeComponent();
        }

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

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (btn_Luu.Enabled == true)
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

        private void txb_DiemQT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }

            if (e.KeyChar == '.' && txb_DiemQT.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txb_DiemTB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txb_DiemQT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_DiemQT.Text))
                   return;

            if (double.TryParse(txb_DiemQT.Text, out double d))
            {
                if (d < 0 || d > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txb_DiemQT.Clear(); 
                    txb_DiemQT.SelectionStart = txb_DiemQT.Text.Length;
                }
                else
                {
                    TinhDiemTrungBinh();
                }
            }
            else
            {
                txb_DiemQT.Clear(); 
                txb_DiemQT.SelectionStart = txb_DiemQT.Text.Length;
            }
        }

        private void txb_DiemCK_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (txb_DiemCK.Text)) return;
            if (double.TryParse(txb_DiemCK.Text, out double d))
            {
                if (d < 0 || d > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txb_DiemCK.Clear();
                    txb_DiemCK.SelectionStart = txb_DiemCK.Text.Length;
                }
                else
                {
                    TinhDiemTrungBinh();
                }
            }
            else
            {
                txb_DiemCK.Clear();
                txb_DiemCK.SelectionStart = txb_DiemCK.Text.Length;
            }
        }

        private void txb_DiemCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txb_DiemCK.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }
}
