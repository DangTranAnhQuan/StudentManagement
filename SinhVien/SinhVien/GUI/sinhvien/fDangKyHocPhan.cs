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
    public partial class fDangKyHocPhan : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        private Thong_Tin_Sinh_Vien _sv;
        public event EventHandler DataUpdated;
        public fDangKyHocPhan(Thong_Tin_Sinh_Vien sv)
        {
            InitializeComponent();
            _sv = sv;
        }

        private void fDangKyHocPhan_Load(object sender, EventArgs e)
        {

            dtgvDanhSachCacHocPhan.Columns.Clear();

            dtgvDanhSachCacHocPhan.ColumnHeadersVisible = true;
            dtgvDanhSachCacHocPhan.ColumnHeadersHeight = 30;
            dtgvDanhSachCacHocPhan.EnableHeadersVisualStyles = false;

            dtgvDanhSachCacHocPhan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var dsHocPhan = from hp in db.HocPhans
                            join mh in db.MonHocs on hp.MaMonHoc equals mh.MaMonHoc
                            where !db.DangKyHocs.Any(dk => dk.MaSV == _sv.MaSV && dk.MaHocPhan == hp.MaHocPhan)
                            select new
                            {
                                hp.MaHocPhan,
                                mh.TenMonHoc,
                                hp.MaGV,
                                hp.MaPhong,
                                hp.TietBatDau,
                                hp.TietKetThuc,
                                hp.SiSoToiDa
                            };

            dtgvDanhSachCacHocPhan.DataSource = dsHocPhan.ToList();


            if (!dtgvDanhSachCacHocPhan.Columns.Contains("colSelect"))
            {
                DataGridViewCheckBoxColumn colSelect = new DataGridViewCheckBoxColumn
                {
                    HeaderText = "Chọn",
                    Name = "colSelect",
                    ReadOnly = false  
                };
                dtgvDanhSachCacHocPhan.Columns.Insert(0, colSelect);
            }

            dtgvDanhSachCacHocPhan.ReadOnly = false;
            dtgvDanhSachCacHocPhan.EditMode = DataGridViewEditMode.EditOnEnter;
            dtgvDanhSachCacHocPhan.AllowUserToAddRows = false;

            dtgvDanhSachCacHocPhan.ColumnHeadersVisible = true;
            dtgvDanhSachCacHocPhan.AllowUserToResizeColumns = false;
            dtgvDanhSachCacHocPhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvDanhSachCacHocPhan.EnableHeadersVisualStyles = false;
            dtgvDanhSachCacHocPhan.GridColor = System.Drawing.Color.Black;
            dtgvDanhSachCacHocPhan.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            dtgvDanhSachCacHocPhan.CellContentClick += dtgvDanhSachCacHocPhan_CellContentClick;

            foreach (DataGridViewColumn column in dtgvDanhSachCacHocPhan.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            RenameColumn(dtgvDanhSachCacHocPhan);
        }
        private void RenameColumn(DataGridView dtgvDanhSachPhongHoc)
        {
            dtgvDanhSachPhongHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvDanhSachPhongHoc.Columns["MaHocPhan"].HeaderText = "Mã Học Phần";
            dtgvDanhSachPhongHoc.Columns["TenMonHoc"].HeaderText = "Tên Môn Học";
            dtgvDanhSachPhongHoc.Columns["MaGV"].HeaderText = "Mã Giảng Viên";
            dtgvDanhSachPhongHoc.Columns["MaPhong"].HeaderText = "Mã Phòng";
            dtgvDanhSachPhongHoc.Columns["TietBatDau"].HeaderText = "Tiết Bắt Đầu";
            dtgvDanhSachPhongHoc.Columns["TietKetThuc"].HeaderText = "Tiết Kết Thúc";
            dtgvDanhSachPhongHoc.Columns["SiSoToiDa"].HeaderText = "Sĩ Số Tối Đa";
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            bool hasSelected = false;
            foreach (DataGridViewRow row in dtgvDanhSachCacHocPhan.Rows)
            {
                bool isSelected = false;
                if (row.Cells["colSelect"].Value != null)
                    bool.TryParse(row.Cells["colSelect"].Value.ToString(), out isSelected);

                if (isSelected)
                {
                    hasSelected = true;
                    string maHocPhan = row.Cells["MaHocPhan"].Value.ToString();
                    var exist = db.DangKyHocs.FirstOrDefault(dk => dk.MaSV == _sv.MaSV && dk.MaHocPhan == maHocPhan);
                    if (exist == null)
                    {
                        DangKyHoc newDK = new DangKyHoc
                        {
                            MaSV = _sv.MaSV,
                            MaHocPhan = maHocPhan,
                            NgayDK = DateTime.Now
                        };
                        db.DangKyHocs.InsertOnSubmit(newDK);
                    }
                }
            }
            if (!hasSelected)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một môn học để đăng ký.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                db.SubmitChanges();
                MessageBox.Show("Đăng ký môn học thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataUpdated?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký môn học: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvDanhSachCacHocPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDanhSachCacHocPhan.Columns[e.ColumnIndex].Name == "colSelect")
            {
                dtgvDanhSachCacHocPhan.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
