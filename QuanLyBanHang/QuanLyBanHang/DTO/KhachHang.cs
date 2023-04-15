using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DTO
{
    public class KhachHang
    {
        private string sdt;
        private string tenKH;
        private string diaChi;
        public KhachHang()
        {

        }
        public KhachHang(DataRow d)
        {
            tenKH = d["TenKH"].ToString().Trim();
            sdt = d["SDT"].ToString();
            diaChi = d["DiaChi"].ToString().Trim();
        }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
