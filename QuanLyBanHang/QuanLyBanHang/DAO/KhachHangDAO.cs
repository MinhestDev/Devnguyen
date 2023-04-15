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
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }
        private KhachHangDAO() { }
        public List<KhachHang> loadDS()
        {
            List<KhachHang> dsKh = new List<KhachHang>();
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM KhachHang");
            foreach (DataRow item in d.Rows)
            {
                KhachHang kh = new KhachHang(item);
                dsKh.Add(kh);
            }
            return dsKh;
        }
        public KhachHang getBySDT(string sdt)
        {
            DataTable d = DataProvider.Instance.RunQuery("SELECT * FROM KhachHang WHERE SDT=N'" + sdt + "'");
            foreach (DataRow item in d.Rows)
            {
                KhachHang i = new KhachHang(item);
                return i;
            }
            return null;
        }

        public void them(string sdt, string hoTen, string diaChi)
        {
            DataProvider.Instance.RunQuery("INSERT KhachHang VALUES(N'" + sdt + "',N'" + hoTen + "',N'" + diaChi + "')");
        }
        public void xoa(string sdt)
        {
            List<DonHang> dsHd = DonHangDAO.Instance.loadBySDTKH(sdt);
            foreach(DonHang item in dsHd)
            {
                DonHangDAO.Instance.xoa(item.MaDH);
            }    
            DataProvider.Instance.RunQuery("DELETE FROM KhachHang WHERE SDT = N'" +sdt+"'");
        }
        public void sua(string sdt, string hoTen, string diaChi)
        {
            DataProvider.Instance.RunQuery("UPDATE KhachHang SET TenKH=N'" + hoTen + "',DiaChi=N'" + diaChi + "' WHERE SDT=N'" + sdt + "'");
        }
    }
}
