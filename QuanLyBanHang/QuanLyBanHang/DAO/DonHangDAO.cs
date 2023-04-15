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
    public class DonHangDAO
    {
        private static DonHangDAO instance;
        public static DonHangDAO Instance
        {
            get
            {
                if (instance == null) DonHangDAO.instance = new DonHangDAO();
                return DonHangDAO.instance;
            }
            private set
            {
                DonHangDAO.instance = value;
            }
        }
        public DonHang getByMa(string maDH)
        {
            DataTable data = DataProvider.Instance.RunQuery("SELECT* FROM DonHang WHERE MaDH = N'" + maDH+"'");
            foreach (DataRow item in data.Rows)
            {
                DonHang i = new DonHang(item);
                return i;
            }
            return null;
        }
        public DonHang getDonChuaHTBySDT(string sdt)
        {
            DataTable data = DataProvider.Instance.RunQuery("SELECT* FROM DonHang WHERE SDTKH = N'" + sdt + "' AND TrangThai=N'Chưa hoàn thành'");
            foreach (DataRow item in data.Rows)
            {
                DonHang i = new DonHang(item);
                return i;
            }
            return null;
        }
        public DonHang getMaxNow()
        {
            DataTable data = DataProvider.Instance.RunQuery("SELECT *FROM DonHang WHERE MaDH=(Select max(MaDH) FROM DONHANG)");
            foreach (DataRow item in data.Rows)
            {
                DonHang i = new DonHang(item);
                return i;
            }
            return null;
        }
        public List<DonHang> loadDS()
        {
            List<DonHang> dsHD = new List<DonHang>();
            DataTable data = DataProvider.Instance.RunQuery("SELECT*FROM DONHANG");
            foreach (DataRow item in data.Rows)
            {
                DonHang b = new DonHang(item);
                dsHD.Add(b);
            }
            return dsHD;
        }
        public List<DonHang> loadBySDTKH(string sdt)
        {
            List<DonHang> l = new List<DonHang>();
            DataTable data = DataProvider.Instance.RunQuery("SELECT*FROM DonHang WHERE SDTKH=N'"+sdt+"'");
            foreach (DataRow item in data.Rows)
            {
                DonHang i = new DonHang(item);
                l.Add(i);
            }
            return l;
        }
        public List<DonHang> loadDSByMaNV(string maNV)
        {
            List<DonHang> dsHD = new List<DonHang>();
            DataTable data = DataProvider.Instance.RunQuery("SELECT*FROM DonHang WHERE MaNV=N'" + maNV + "'");
            foreach (DataRow item in data.Rows)
            {
                DonHang b = new DonHang(item);
                dsHD.Add(b);
            }
            return dsHD;
        }
        public void them(string sdt, string maNV)
        {
            string q = "INSERT INTO DonHang(SDTKH,MaNV) VALUES (";
            if (string.IsNullOrEmpty(sdt))
                q += "NULL,";
                else q+="N'"+sdt+"',";
            if (string.IsNullOrEmpty(maNV))
                q += "NULL)";
            else q += "N'" + maNV + "')";
            DataProvider.Instance.RunQuery(q);
        }
        public void huy(string maDH)
        {
            DataProvider.Instance.RunQuery("UPDATE DonHang SET TrangThai=N'Đã hủy' WHERE MaDH=N'" + maDH + "'");
        }
        public void xoa(string maDH)
        {
            List<ChiTietDonHang> dsCTHD = ChiTietDonHangDAO.Instance.loadDSByMaDH(maDH);
            foreach (ChiTietDonHang item in dsCTHD)
            {
                ChiTietDonHangDAO.Instance.xoa(item.MaCT);
            }
            DataProvider.Instance.RunQuery("DELETE FROM DonHang  WHERE MaDH=N'" + maDH + "'");
        }
        public void capNhatTongTien(string maDH)
        {
            List<ChiTietDonHang> l = ChiTietDonHangDAO.Instance.loadDSByMaDH(maDH);
            int tong = 0;
            foreach(ChiTietDonHang i in l)
            {
                tong += i.SoLuong*i.DonGia;
            }
            DataProvider.Instance.RunQuery("UPDATE DonHang SET TongTien="+tong+" WHERE MaDH=N'" + maDH+"'");
        }
        public void thanhToan(string maDH)
        {
            DataProvider.Instance.RunQuery("UPDATE DonHang SET TrangThai=N'Đã hoàn thành' WHERE MaDH=N'" + maDH + "'");
        }
        public List<DonHang> loadDSChuaHT()
        {
            List<DonHang> l = new List<DonHang>();
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM DonHang WHERE TrangThai=N'Chưa hoàn thành'");
            foreach (DataRow item in d.Rows)
            {
                DonHang nv = new DonHang(item);
                l.Add(nv);
            }
            return l;
        }
    }

}
