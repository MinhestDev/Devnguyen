using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DTO
{
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private int luong;
        private string sdt;
        public NhanVien() { }
        public NhanVien(DataRow d)
        {
            MaNV = d["MaNV"].ToString().Trim();
            HoTen = d["HoTen"].ToString().Trim();
            Luong = (int)d["Luong"];
            Sdt = d["SDT"].ToString().Trim();
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int Luong { get => luong; set => luong = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
