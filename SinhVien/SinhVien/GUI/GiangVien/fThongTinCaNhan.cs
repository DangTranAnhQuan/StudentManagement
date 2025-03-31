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
    public partial class fThongTinCaNhan : Form
    {

        private Form activeForm = null;
        private Form mainForm;
        public fThongTinCaNhan(fGiangVien fGiangVien)
        {
            InitializeComponent();
        }

        private void btnCapNhatThongTinCaNhan_Click(object sender, EventArgs e)
        {
            OpenCapNhatThongTin(new fCapNhatThongTinGV(this));
        }

        private void OpenCapNhatThongTin(fCapNhatThongTinGV fCapNhatThongTinGV)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = fCapNhatThongTinGV;
            fCapNhatThongTinGV.TopLevel = false;
            fCapNhatThongTinGV.FormBorderStyle = FormBorderStyle.None;
            fCapNhatThongTinGV.Dock = DockStyle.Fill;
            main.Controls.Add(fCapNhatThongTinGV);
            main.Tag = fCapNhatThongTinGV;
            fCapNhatThongTinGV.BringToFront();
            fCapNhatThongTinGV.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pbAnhDaiDien.Image = Image.FromFile(opf.FileName);
        }
    }
}
