using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinhVien.GUI.sinhvien;

namespace SinhVien
{
    public partial class fDanhSachMonHoc : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        private Form activeForm = null;
        private Thong_Tin_Sinh_Vien _sv;
        private HocPhan _hp;
        private DangKyHoc _dk;
        private fSinhVien parentSinhVien;
        public fDanhSachMonHoc(Thong_Tin_Sinh_Vien sv,HocPhan hp, DangKyHoc dk)
        {
            InitializeComponent();
            _sv = sv;
            _hp = hp;
            _dk = dk;
        }
        public fDanhSachMonHoc(fSinhVien parentForm) : this(parentForm.SinhVien, parentForm.HocPhan, parentForm.KyHoc)
        {
            this.parentSinhVien = parentForm;
        }
        private void fDanhSachMonHoc_Load(object sender, EventArgs e)
        {
            dtgvDanhSachCacMonHoc.ColumnHeadersVisible = true; 
            dtgvDanhSachCacMonHoc.ColumnHeadersHeight = 30;
            dtgvDanhSachCacMonHoc.EnableHeadersVisualStyles = false;

            dtgvDanhSachCacMonHoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvDanhSachCacMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dtgvDanhSachCacMonHoc.ScrollBars = ScrollBars.Both;

            dtgvDanhSachCacMonHoc.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dtgvDanhSachCacMonHoc.GridColor = Color.Black;
            dtgvDanhSachCacMonHoc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvDanhSachCacMonHoc.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvDanhSachCacMonHoc.EnableHeadersVisualStyles = false;

            var danhSachMonHoc = from dk in db.DangKyHocs
                                 join hp in db.HocPhans on dk.MaHocPhan equals hp.MaHocPhan
                                 where dk.MaSV == _sv.MaSV
                                 select new
                                 {
                                     hp.MaHocPhan,
                                     hp.MaMonHoc,
                                     hp.MaGV,
                                     hp.MaPhong,
                                     hp.TietBatDau,
                                     hp.TietKetThuc,
                                 };

            dtgvDanhSachCacMonHoc.DataSource = danhSachMonHoc.ToList();

            dtgvDanhSachCacMonHoc.AllowUserToResizeColumns = false;
            dtgvDanhSachCacMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvDanhSachCacMonHoc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dtgvDanhSachCacMonHoc.Columns["MaHocPhan"].HeaderText = "Mã học phần";
            dtgvDanhSachCacMonHoc.Columns["MaMonHoc"].HeaderText = "Mã môn học";
            dtgvDanhSachCacMonHoc.Columns["MaGV"].HeaderText = "Mã giảng viên";
            dtgvDanhSachCacMonHoc.Columns["MaPhong"].HeaderText = "Mã phòng";
            dtgvDanhSachCacMonHoc.Columns["TietBatDau"].HeaderText = "Tiết bắt đầu";
            dtgvDanhSachCacMonHoc.Columns["TietKetThuc"].HeaderText = "Tiết kết thúc";

            if (!dtgvDanhSachCacMonHoc.Columns.Contains("colCancel"))
            {
                var colCancel = new DataGridViewButtonColumn()
                {
                    Name = "colCancel",
                    HeaderText = "Hủy",
                    Text = "Hủy",
                    UseColumnTextForButtonValue = true,
                    Width = 35,
                    FlatStyle = FlatStyle.Flat
                };
                colCancel.DefaultCellStyle = new DataGridViewCellStyle()
                {
                    BackColor = Color.Red,
                    ForeColor = Color.White,
                    SelectionBackColor = Color.Red,
                    SelectionForeColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 12F),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                };
                dtgvDanhSachCacMonHoc.Columns.Add(colCancel);
            }

            

            dtgvDanhSachCacMonHoc.Columns[0].Width = 150;
            dtgvDanhSachCacMonHoc.Columns[1].Width = 150;
            dtgvDanhSachCacMonHoc.Columns[2].Width = 150;
            dtgvDanhSachCacMonHoc.Columns[3].Width = 150;
            dtgvDanhSachCacMonHoc.Columns[4].Width = 150;
            dtgvDanhSachCacMonHoc.Columns[5].Width = 150;
            dtgvDanhSachCacMonHoc.Columns[6].Width = 100;

            dtgvDanhSachCacMonHoc.CellPainting -= dtgvDanhSachCacMonHoc_CellPainting;
            dtgvDanhSachCacMonHoc.CellPainting += dtgvDanhSachCacMonHoc_CellPainting;

        }
        private void dtgvDanhSachCacMonHoc_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvDanhSachCacMonHoc.Columns[e.ColumnIndex].Name == "colCancel")
            {
                e.Handled = true;
                using (SolidBrush brush = new SolidBrush(Color.Red))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }
                using (Pen pen = new Pen(Color.Black))
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1));
                }
                TextRenderer.DrawText(
                    e.Graphics,
                    "Hủy",
                    e.CellStyle.Font,
                    e.CellBounds,
                    Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }
        public void OpenDangKyMonHoc(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pane_dscmh.Controls.Add(childForm);
            pane_dscmh.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        private void btnDangKyHocPhan_Click(object sender, EventArgs e)
        {
            var capNhatForm = new fDangKyHocPhan(_sv);
            capNhatForm.DataUpdated += (s, evt) =>
            {
                RefreshDanhSachMonHoc();
            };
            OpenDangKyMonHoc(capNhatForm);
        }
        private void RefreshDanhSachMonHoc()
        {
            var danhSachMonHoc = from dk in db.DangKyHocs
                                 join hp in db.HocPhans on dk.MaHocPhan equals hp.MaHocPhan
                                 where dk.MaSV == _sv.MaSV
                                 select new
                                 {
                                     hp.MaHocPhan,
                                     hp.MaMonHoc,
                                     hp.MaGV,
                                     hp.MaPhong,
                                     hp.TietBatDau,
                                     hp.TietKetThuc,
                                 };

            dtgvDanhSachCacMonHoc.DataSource = danhSachMonHoc.ToList();
        }

        private void dtgvDanhSachCacMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dtgvDanhSachCacMonHoc.Columns[e.ColumnIndex].Name != "colCancel")
                return;

            string maHP = dtgvDanhSachCacMonHoc.Rows[e.RowIndex].Cells["MaHocPhan"].Value.ToString();
            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn hủy học phần {maHP} không?",
                "Xác nhận hủy",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;
            var dk = db.DangKyHocs.FirstOrDefault(x => x.MaSV == _sv.MaSV && x.MaHocPhan == maHP);
            if (dk != null)
            {
                db.DangKyHocs.DeleteOnSubmit(dk);
                db.SubmitChanges();
            }

            RefreshDanhSachMonHoc();
        }
    }
}
