using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DTO
{
    public class SanPham
    {
        private string maSP;
        private string tenSP;
        private string donViTinh;
        private string maDM;
        private int donGia;
        public SanPham() { }
        public SanPham(DataRow d)
        {
            MaSP = d["MaSP"].ToString().Trim();
            TenSP = d["TenSP"].ToString().Trim();
            DonViTinh= d["DonViTinh"].ToString().Trim();
            MaDM = d["MaDM"].ToString().Trim();
            DonGia = (int)d["DonGia"];
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public string MaDM { get => maDM; set => maDM = value; }
    }
}
