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

        private void fGiangVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_QuanLyDiem_Click(object sender, EventArgs e)
        {
            if (btn_QuanLyDiem.Enabled == true)
            {
                fQuanLyDiem f = new fQuanLyDiem();
                f.ShowDialog();
                
            }
        }
    }
}
