using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;
        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return instance; }
            private set { instance = value; }
        }
        private SanPhamDAO() { }
        public List<SanPham> loadDS()
        {
            List<SanPham> l = new List<SanPham>();
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM SanPham");
            foreach(DataRow item in d.Rows)
            {
                SanPham i = new SanPham(item);
                l.Add(i);
            }    
            return l; 
        }
        public List<SanPham> loadDSByMaDanhMuc(string maDM)
        {
            List<SanPham> l = new List<SanPham>();
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM SanPham WHERE MaDM=N'"+ maDM + "'");
            foreach (DataRow item in d.Rows)
            {
                SanPham i = new SanPham(item);
                l.Add(i);
            }
            return l;
        }
        public List<SanPham> loadDSByTenDM(string tenDM)
        {
            List<SanPham> l = new List<SanPham>();
            DanhMuc dm = DanhMucDAO.Instance.getByTen(tenDM);
            if (dm == null)
                return l;
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM SanPham WHERE MaDM=N'" + dm.MaDM + "'");
            foreach (DataRow item in d.Rows)
            {
                SanPham i = new SanPham(item);
                l.Add(i);
            }
            return l;
        }
        public SanPham getByMa(string ma)
        {
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM SanPham WHERE MaSP=N'" + ma + "'");
            foreach (DataRow item in d.Rows)
            {
                SanPham i = new SanPham(item);
                return i;
            }
            return null;
        }
        public SanPham getByTen(string ten)
        {
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM SANPHAM WHERE TenSP=N'"+ten+"'");
            foreach (DataRow item in d.Rows)
            {
                SanPham i = new SanPham(item);
                return i;
            }
            return null;
        }
        public void them(string ten, string maDM, string donViTinh,int donGia)
        {
            DataProvider.Instance.RunQuery("INSERT SanPham(TenSP,MaDM,DonViTinh,DonGia) VALUES(N'" + ten + "',N'" + maDM + "',N'" + donViTinh + "',"+donGia+")");
        }
        public void sua(string maSP, string ten, string maDM, string donViTinh, int donGia)
        {
            DataProvider.Instance.RunQuery("UPDATE SanPham SET TenSP=N'" + ten + "',MaDM=N'" + maDM + "',DonViTinh=N'" + donViTinh + "',DonGia=" + donGia 
                +" WHERE MaSP=N'"+maSP+"'");
        }
        public void xoa(string maSP)
        {
            List<ChiTietDonHang> l = ChiTietDonHangDAO.Instance.loadDSByMaSP(maSP);
            foreach (ChiTietDonHang i in l)
            {
                ChiTietDonHangDAO.Instance.xoa(i.MaCT);
            }
            DataProvider.Instance.RunQuery("DELETE FROM SanPham WHERE MaSP = N'" + maSP + "'");
        }
    }
}
