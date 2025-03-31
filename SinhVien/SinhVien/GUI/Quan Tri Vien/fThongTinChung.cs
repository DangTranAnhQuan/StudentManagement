using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SinhVien.GUI.Quan_Tri_Vien
{
    public partial class fThongTinChung : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public fThongTinChung(fQuanTriVien fQuanTriVien)
        {
            InitializeComponent();
        }

        private void fThongTinChung_Load(object sender, EventArgs e)
        {
            LoadTiLeSinhVien();
            LoadTiLeGiangVien();
            LoadSoLuong();
        }

        private void LoadSoLuong()
        {
            txtTongSV.Text = db.Thong_Tin_Sinh_Viens.Count().ToString();
            txtTongSoGiangVien.Text = db.GiangViens.Count().ToString();
            txtTongSoMonHoc.Text = db.MonHocs.Count().ToString();
            txtTongSoLopHoc.Text = db.PhongHocs.Count().ToString();
        }

        private void LoadTiLeGiangVien()
        {
            var data = from gv in db.GiangViens
                       join khoa in db.Khoas on gv.MaKhoa equals khoa.MaKhoa
                       group gv by khoa.TenKhoa into g
                       select new
                       {
                           TenKhoa = g.Key,
                           SoLuong = g.Count()
                       };

            var list = data.ToList();
            var series = chartTiLe.Series["Tỉ lệ giảng viên"];
            series.Points.Clear();

            foreach (var item in list)
            {
                series.Points.AddXY(item.TenKhoa, item.SoLuong);
            }
        }

        private void LoadTiLeSinhVien()
        {
            var data = from sv in db.Thong_Tin_Sinh_Viens
                       join lop in db.Lops on sv.LopSV equals lop.MaLop
                       join khoa in db.Khoas on lop.MaKhoa equals khoa.MaKhoa
                       group sv by khoa.TenKhoa into g
                       select new
                       {
                           TenKhoa = g.Key,
                           SoLuong = g.Count()
                       };

            var list = data.ToList();
            var series = chartTiLe.Series["Tỉ lệ sinh viên"];
            series.Points.Clear();

            foreach (var item in list)
            {
                series.Points.AddXY(item.TenKhoa, item.SoLuong);
            }
        }
    }
}
