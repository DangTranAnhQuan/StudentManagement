using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    public class BLL_TaiKhoan
    {
        private string connectionString = @"Data Source=.;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True";

        private static BLL_TaiKhoan instance; // ctr + r + e

        public static BLL_TaiKhoan Instance
        {
            get { if (instance == null) instance = new BLL_TaiKhoan(); return instance; }
            private set => instance = value;
        }

        private BLL_TaiKhoan() { }
        public DataTable DanhSach()
        {
            return DAL_TaiKhoan.Instance.DanhSach();
        }

        public bool Them (string tendangnhap, string matkhau, string loai)
        {
            matkhau = HeThong.Hash(matkhau);
            return DAL_TaiKhoan.Instance.Them(tendangnhap, matkhau, loai);
        }
    }
}
