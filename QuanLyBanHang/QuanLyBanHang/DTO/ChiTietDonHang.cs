using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyBanHang.DTO
{
    public class ChiTietDonHang
    {
        private string maCT;
        private string maDH;
        private string maSP;
        private int donGia;
        private int soLuong;


        public ChiTietDonHang()
        {
        }
        public ChiTietDonHang(DataRow r)
        {
            MaCT = r["MaCT"].ToString().Trim() ;
            MaDH = r["MaDH"].ToString().Trim();
            MaSP = r["MaSP"].ToString().Trim();
            DonGia = (int)r["DonGia"];
            SoLuong = (int)r["SoLuong"];
        }

        public string MaDH { get => maDH; set => maDH = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaCT { get => maCT; set => maCT = value; }
    }
}
