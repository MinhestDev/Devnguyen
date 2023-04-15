using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DTO
{
    public class DonHang
    {
        private string maDH;
        private string sdtKH;
        private string maNV;
        private DateTime thoiGian;
        private int tongTien;
        private string trangThai;
        public DonHang()
        {

        }
        public DonHang(DataRow d)
        {
            MaDH = d["MaDH"].ToString().Trim();
            SdtKH = "";
            try
            {
                SdtKH = d["SDTKH"].ToString().Trim();
            }catch (Exception ex) { }
            MaNV = "";
            try
            {
                MaNV = d["MaNV"].ToString().Trim();
            }
            catch (Exception ex) { }
            thoiGian = (DateTime)d["ThoiGian"];
            TongTien= (int)d["TongTien"];
            TrangThai= d["TrangThai"].ToString().Trim();
        }

        public string MaDH { get => maDH; set => maDH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string SdtKH { get => sdtKH; set => sdtKH = value; }
    }
}
