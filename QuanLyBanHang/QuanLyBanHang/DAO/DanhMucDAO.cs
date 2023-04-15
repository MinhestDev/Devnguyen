using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang.DAO
{
    public class DanhMucDAO
    {
        private static DanhMucDAO instance;
        public static DanhMucDAO Instance
        {
            get { if (instance == null) instance = new DanhMucDAO(); return instance; }
            private set { instance = value; }
        }
        private DanhMucDAO() { }
        public List<DanhMuc> loadDS()
        {
            List<DanhMuc> l = new List<DanhMuc>();
            DataTable data = DataProvider.Instance.RunQuery("SELECT*FROM DanhMuc");
            foreach (DataRow item in data.Rows)
            {
                DanhMuc i = new DanhMuc(item);
                l.Add(i);
            }
            return l;
        }
        public DanhMuc getByMa(string maDM)
        {
            DataTable data = DataProvider.Instance.RunQuery("SELECT*FROM DanhMuc WHERE MaDM=N'" + maDM+"'");
            foreach (DataRow item in data.Rows)
            {
                DanhMuc l = new DanhMuc(item);
                return l;
            }
            return null;
        }
        public DanhMuc getByTen(string tenDM)
        {
            DataTable data = DataProvider.Instance.RunQuery("SELECT*FROM DanhMuc WHERE TenDM=N'" + tenDM + "'");
            foreach (DataRow item in data.Rows)
            {
                DanhMuc l = new DanhMuc(item);
                return l;
            }
            return null;
        }
        public void them(string tenDM)
        {
            DataProvider.Instance.RunQuery("INSERT DanhMuc(TenDM) VALUES(N'" + tenDM + "')");
        }
        public void sua(string maDM,string tenDM)
        {
            DataProvider.Instance.RunQuery("UPDATE DanhMuc SET TenDM=N'" + tenDM + "' WHERE MaDM=N'"+maDM+"'");
        }
        public void xoa(string maDM)
        {
            List<SanPham> l = SanPhamDAO.Instance.loadDSByMaDanhMuc(maDM);
            foreach (SanPham i in l)
            {
                SanPhamDAO.Instance.xoa(i.MaSP);
            }
            DataProvider.Instance.RunQuery("DELETE FROM DanhMuc WHERE MaDM = N'" + maDM + "'");
        }
    }
}
