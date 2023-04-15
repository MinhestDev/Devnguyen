using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAO
{
    public class DangNhapDAO
    {
        private static DangNhapDAO instance;
        public static DangNhapDAO Instance
        {
            get { if (instance == null) instance = new DangNhapDAO(); return instance; }
            private set { instance = value; }
        }
        private DangNhapDAO() { }
        public DangNhap getByTaiKhoan(string taiKhoan)
        {
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM DangNhap  WHERE TaiKhoan=N'" + taiKhoan + "'");
            foreach (DataRow item in d.Rows)
            {
                DangNhap i = new DangNhap(item);
                return i;
            }
            return null;
        }
        public DangNhap getByTaiKhoanMatKhau(string taiKhoan, string matKhau)
        {
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM DangNhap  WHERE TaiKhoan=N'" + taiKhoan + "' AND MatKhau=N'" + matKhau + "'");
            foreach (DataRow item in d.Rows)
            {
                DangNhap i = new DangNhap(item);
                return i;
            }
            return null;
        }
        public DangNhap getByMaNV(string maNV)
        {
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM DangNhap  WHERE MaNV=N'" + maNV + "'");
            foreach (DataRow item in d.Rows)
            {
                DangNhap i = new DangNhap(item);
                return i;
            }
            return null;
        }
        public static string ConvertToUnSign(string text)
        {
            for (int i = 33; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 58; i < 65; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 91; i < 97; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }
            for (int i = 123; i < 127; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }
            text = text.Replace(" ", "-");
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        private string getTaiKhoan(string ten)
        {
            ten = ConvertToUnSign(ten);
            string tk = "";
            ten = ten.ToLower();
            for (int i = 0; i < ten.Length; i++)
                if (ten[i] >= 'a' && ten[i] <= 'z')
                {
                    tk += ten[i];
                }
            int j = 1;
            while (getByTaiKhoan(tk + j) != null)
                j++;
            tk += j;
            return tk;
        }
        public void them(NhanVien nv)
        {
            DataProvider.Instance.RunQuery("INSERT INTO DangNhap(TaiKhoan,MaNV) VALUES(N'" + getTaiKhoan(nv.HoTen) + "',N'" + nv.MaNV+ "')");
        }
        public void xoaByMaNV(string manv)
        {
            DataProvider.Instance.RunQuery("DELETE FROM DangNhap WHERE MaNV=N'" + manv + "'");
        }
        public void suaByTaiKhoan(string taiKhoan, string matKhau, string tkCu)
        {
            DataProvider.Instance.RunQuery("UPDATE DangNhap SET TaiKhoan=N'" + taiKhoan + "',MatKhau=N'" + matKhau + "' WHERE TaiKhoan=N'" + tkCu + "'");
        }
    }
}
