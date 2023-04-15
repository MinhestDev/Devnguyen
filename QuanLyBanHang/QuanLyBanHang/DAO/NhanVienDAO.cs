using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QuanLyBanHang.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        private NhanVienDAO() { }
        public List<NhanVien> loadDS()
        {
            List<NhanVien> dsNv = new List<NhanVien>();
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM NHANVIEN");
            foreach (DataRow item in d.Rows)
            {
                NhanVien nv = new NhanVien(item);
                dsNv.Add(nv);
            }
            return dsNv;
        }
        public bool ktrDangNhap(string taiKhoan,string matKhau)
        {
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM NhanVien WHERE TaiKhoan=N'" + taiKhoan + "' AND MatKhau=N'"+matKhau+"'");
            foreach (DataRow item in d.Rows)
            {
                return true;
            }
            return false;
        }
        public NhanVien getNhanVienByTaiKhoan(string taiKhoan)
        {
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM NhanVien WHERE TaiKhoan=N'"+ taiKhoan + "'");
            foreach (DataRow item in d.Rows)
            {
                NhanVien nv = new NhanVien(item);
                return nv;
            }
            return null;
        }
        public NhanVien getNhanVienByMa(string ma)
        {
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM NhanVien WHERE MaNV=N'" + ma + "'");
            foreach (DataRow item in d.Rows)
            {
                NhanVien nv = new NhanVien(item);
                return nv;
            }
            return null;
        }
        public NhanVien getNhanVienBySDT(string sdt)
        {
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM NhanVien WHERE SDT=N'" + sdt + "'");
            foreach (DataRow item in d.Rows)
            {
                NhanVien nv = new NhanVien(item);
                return nv;
            }
            return null;
        }
        public void them(string hoTen,string sdt,int luong)
        {
            DataProvider.Instance.RunQuery("INSERT NhanVien(HoTen,SDT,Luong) VALUES(N'" + hoTen + "',N'" + sdt + "','" + luong + "')");
            NhanVien nv = getNhanVienBySDT(sdt);
            DangNhapDAO.Instance.them(nv);
        }
        public void xoa(string maNV)
        {
            List<DonHang> l = DonHangDAO.Instance.loadDSByMaNV(maNV);
            foreach (DonHang item in l)
            {
                DonHangDAO.Instance.xoa(item.MaDH);
            }
            DangNhapDAO.Instance.xoaByMaNV(maNV);
            DataProvider.Instance.RunQuery("DELETE FROM NhanVien WHERE MaNV = N'" + maNV + "'");
        }

        public void sua(string maNV,string hoTen, string sdt, int luong)
        {
            DataProvider.Instance.RunQuery("UPDATE NhanVien SET HoTen=N'" + hoTen + "',Luong=" + luong + ",SDT=N'" + sdt + "' WHERE MaNV=N'"+maNV+"'");
        }
    }
}
