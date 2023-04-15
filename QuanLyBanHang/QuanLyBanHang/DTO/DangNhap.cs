using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.DTO
{
    public  class DangNhap
    {
        private string taiKhoan;
        private string matKhau;
        private string maNV;
        public DangNhap() { }   
        public DangNhap(DataRow d)
        {
            TaiKhoan =d["TaiKhoan"].ToString().Trim();
            MatKhau = d["MatKhau"].ToString().Trim();
            MaNV = d["MaNV"].ToString().Trim();
        }

        public string MaNV { get; internal set; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
