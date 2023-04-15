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
    public class ChiTietDonHangDAO
    {
        private static ChiTietDonHangDAO instance;
        public static ChiTietDonHangDAO Instance
        {
            get
            {
                if (instance == null) ChiTietDonHangDAO.instance = new ChiTietDonHangDAO();
                return ChiTietDonHangDAO.instance;
            }
            private set
            {
                ChiTietDonHangDAO.instance = value;
            }
        }
        public void xoa(string maCT)
        {
            ChiTietDonHang ct = getByMa(maCT);
            DataProvider.Instance.RunQuery("DELETE FROM ChiTietDonHang WHERE MaCT=N'" + maCT + "'");
            DonHangDAO.Instance.capNhatTongTien(ct.MaDH);
        }
        public ChiTietDonHang getByMaDH_MaSP_DonGia(string maDH,string maSP,int donGia)
        {
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM ChiTietDonHang WHERE MaDH=N'" + maDH + "' AND MaSP=N'" + maSP + "' AND DonGia=" + donGia);
            foreach (DataRow item in d.Rows)
            {
                ChiTietDonHang ct = new ChiTietDonHang(item);
                return ct;
            }
            return null;
        }    
        public void them(string maDH, string maSP, int soLuong,int donGia)
        {
            if (soLuong == 0)
                return;
            ChiTietDonHang ct = getByMaDH_MaSP_DonGia(maDH, maSP, donGia);
            if (ct!=null)
            {
                
                int soLuongNew =ct.SoLuong+soLuong;
                if (soLuongNew <= 0)
                {
                    xoa(ct.MaCT);
                }
                else
                {
                    DataProvider.Instance.RunQuery("UPDATE ChiTietDonHang SET SoLuong=" + soLuongNew + " WHERE MaCT=N'" + ct.MaCT+"'");
                }    
            }
            else
            {
                if (soLuong < 0)
                    return;
                DataProvider.Instance.RunQuery("INSERT INTO ChiTietDonHang(MaDH,MaSP,SoLuong,DonGia) VALUES (N'" + maDH + "',N'" + maSP + "'," + soLuong + "," + donGia + ")");
            }
            DonHangDAO.Instance.capNhatTongTien(maDH);
        }
        public List<ChiTietDonHang> loadDSByMaDH(string maDH)
        {
            List<ChiTietDonHang> l = new List<ChiTietDonHang>();
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM ChiTietDonHang WHERE MaDH=N'" + maDH + "'");
            foreach (DataRow item in d.Rows)
            {
                ChiTietDonHang i = new ChiTietDonHang(item);
                l.Add(i);
            }
            return l;
        }
        public List<ChiTietDonHang> loadDSTraLai(string q)
        {
            List<ChiTietDonHang> l = new List<ChiTietDonHang>();
            DataTable d = DataProvider.Instance.RunQuery("SELECT ChiTietDonHang.MaCT,ChiTietDonHang.MaDH,ChiTietDonHang.MaSP,"
                +"ChiTietDonHang.SoLuong,ChiTietDonHang.DonGia FROM ChiTietDonHang,DonHang WHERE ChiTietDonHang.MaDH=DonHang.MaDH "+
                "AND DonHang.TrangThai=N'Đã hủy'"+q);
            foreach (DataRow item in d.Rows)
            {
                ChiTietDonHang i = new ChiTietDonHang(item);
                l.Add(i);
            }
            return l;
        }
        public List<ChiTietDonHang> loadDSByMaSP(string maSP)
        {
            List<ChiTietDonHang> l = new List<ChiTietDonHang>();
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM ChiTietDonHang WHERE MaSP=N'" + maSP + "'");
            foreach (DataRow item in d.Rows)
            {
                ChiTietDonHang ct = new ChiTietDonHang(item);
                l.Add(ct);
            }
            return l;
        }
        public ChiTietDonHang getByMa(string maCT)
        {
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM ChiTietDonHang WHERE MaCT=N'" + maCT + "'");
            foreach (DataRow item in d.Rows)
            {
                ChiTietDonHang ct = new ChiTietDonHang(item);
                return ct;
            }
            return null;
        }
    }
}
