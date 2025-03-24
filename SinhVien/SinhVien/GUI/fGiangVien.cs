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
        private Form mainForm;
        private void btnQLSinhVien_Click(object sender, EventArgs e)
        {
            OpenQuanLySV(new QuanLySinhVien(this));
            btnQLSinhVien.ForeColor = Color.Coral;
            btnThongTinCaNhan.ForeColor = Color.White;

        }

        private Form activeForm = null;
        private void OpenQuanLySV(QuanLySinhVien quanLySinhVien)
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
    }
}
