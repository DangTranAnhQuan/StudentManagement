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
    public partial class fXemDiem : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        private Thong_Tin_Sinh_Vien _sv;
        public fXemDiem(Thong_Tin_Sinh_Vien sv)
        {
            InitializeComponent();
            _sv = sv;
        }

        private void fXemDiem_Load(object sender, EventArgs e)
        {
            dtgvDiemMonHoc.ColumnHeadersVisible = true;
            dtgvDiemMonHoc.ColumnHeadersHeight = 30;
            dtgvDiemMonHoc.EnableHeadersVisualStyles = false;

            dtgvDiemMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dtgvDiemMonHoc.ScrollBars = ScrollBars.Both;

            dtgvDiemMonHoc.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dtgvDiemMonHoc.GridColor = Color.Black;
            dtgvDiemMonHoc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvDiemMonHoc.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvDiemMonHoc.EnableHeadersVisualStyles = false;

            var DiemMonHoc = from diem in db.Diems
                                 join mh in db.MonHocs on diem.MaMonHoc equals mh.MaMonHoc 
                                 where diem.MaSV == _sv.MaSV
                                 select new
                                 {
                                     diem.MaMonHoc,
                                     mh.TenMonHoc,
                                     diem.PhanTramTrenLop,
                                     diem.PhanTramThi,
                                     diem.DiemTrenLop,
                                     diem.DiemThi,
                                     diem.DiemTB,
                                     diem.Loai
                                 };

            dtgvDiemMonHoc.DataSource = DiemMonHoc.ToList();

            dtgvDiemMonHoc.AllowUserToResizeColumns = false;
            dtgvDiemMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvDiemMonHoc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dtgvDiemMonHoc.Columns["MaMonHoc"].HeaderText = "Mã môn học";
            dtgvDiemMonHoc.Columns["TenMonHoc"].HeaderText = "Tên môn học";
            dtgvDiemMonHoc.Columns["PhanTramTrenLop"].HeaderText = "Phần trăm trên lớp";
            dtgvDiemMonHoc.Columns["PhanTramThi"].HeaderText = "Phần trăm thi";
            dtgvDiemMonHoc.Columns["DiemTrenLop"].HeaderText = "Điểm trên lớp";
            dtgvDiemMonHoc.Columns["DiemThi"].HeaderText = "Điểm thi";
            dtgvDiemMonHoc.Columns["DiemTB"].HeaderText = "Điểm trung bình";
            dtgvDiemMonHoc.Columns["Loai"].HeaderText = "Xếp loại";

            dtgvDiemMonHoc.Columns[0].Width = 100;
            dtgvDiemMonHoc.Columns[1].Width = 200;
            dtgvDiemMonHoc.Columns[2].Width = 150;
            dtgvDiemMonHoc.Columns[3].Width = 150;
            dtgvDiemMonHoc.Columns[4].Width = 150;
            dtgvDiemMonHoc.Columns[5].Width = 100;
            dtgvDiemMonHoc.Columns[6].Width = 150;
            dtgvDiemMonHoc.Columns[7].Width = 100;
        }
    }
}
