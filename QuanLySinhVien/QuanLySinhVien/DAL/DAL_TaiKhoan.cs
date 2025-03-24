using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien.DAL;

namespace QuanLySinhVien.DAL
{
    

    public class DAL_TaiKhoan
    {
        //private string connectionString = @"Data Source=.;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True";
        public class KetNoiDL
        {
            public SqlConnection conn;
            public SqlCommand cmd;
            public DataSet ds;
            public SqlDataAdapter da;
            private string connectionString = @"Data Source=.;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True";
            private void LoadData()
            {
                conn = new SqlConnection(connectionString);
                conn.ConnectionString = Properties.Settings.Default.QLSV;
                conn.Open();
                ds = new DataSet();
                string sql = "Select * From TaiKhoan";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
            }
        }

        private static DAL_TaiKhoan instance; // ctr + r + e

        public static DAL_TaiKhoan Instance
        {
            get { if (instance == null) instance = new DAL_TaiKhoan(); return instance; }
            private set => instance = value;
        }

        private DAL_TaiKhoan() { }
        public bool Them(string ten, string matkhau, string loai)
        {
            string sql = "insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTaiKhoan) values( @TenDangNhap , @MatKhau , @LoaiTaiKhoan )";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { ten, matkhau, loai});
        }

        public bool Sua(string ten, string matkhau, string loai, int id)
        {
            string sql = "update Taikhoan set TenDangNhap = @TenDangNhap , MatKhau = @MatKhau , LoaiTaiKhoan = @LoaiTaiKhoan where id = @id)";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { ten, matkhau, loai, id});
        }

        public bool Xoa(int id)
        {
            string sql = "delete from TaiKhoan where id = @id)";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select * from TaiKhoan");
        }
    }
}
