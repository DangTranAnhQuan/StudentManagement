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
    public partial class fQuanLySinhVien : Form
    {
        public fQuanLySinhVien(fGiangVien fGiangVien)
        {
            InitializeComponent();
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {

        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbLopHoc.Items.Clear();

            if (cbbMonHoc.SelectedItem.ToString() == "Lập trình C#")
            {
                cbbLopHoc.Items.Add("19TCLC_DT1");
                cbbLopHoc.Items.Add("19TCLC_DT2");
                cbbLopHoc.Items.Add("19TCLC_DT3");
            }
            else if (cbbMonHoc.SelectedItem.ToString() == "Lập trình C++")
            {
                cbbLopHoc.Items.Add("19TCLC_DT4");
                cbbLopHoc.Items.Add("19TCLC_DT5");
                cbbLopHoc.Items.Add("19TCLC_DT6");
            }
            else if (cbbMonHoc.SelectedItem.ToString() == "Lập trình Java")
            {
                cbbLopHoc.Items.Add("19TCLC_DT7");
                cbbLopHoc.Items.Add("19TCLC_DT8");
                cbbLopHoc.Items.Add("19TCLC_DT9");
            }
        }
    }
}
