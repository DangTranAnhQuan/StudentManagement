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
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (cbb_LoaiTaiKhoan.SelectedItem.ToString() == "Sinh viên")
            {
                fThongTinSV f = new fThongTinSV();
                this.Hide();
                f.ShowDialog();
                this.Show();
                //this.Close();
            }
            else
            {
                fGiangVien f = new fGiangVien();
                this.Hide();
                f.ShowDialog();
                this.Show();

            }
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {
           
        }

        private void cbb_LoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
