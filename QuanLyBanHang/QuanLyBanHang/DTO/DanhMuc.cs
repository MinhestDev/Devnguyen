using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DTO
{
    public class DanhMuc
    {
        private string maDM;
        private string tenDM;
        public DanhMuc()
        {

        }
        public DanhMuc(DataRow d)
        {
            MaDM = d["MaDM"].ToString().Trim();
            TenDM = d["TenDM"].ToString().Trim();
        }
        public string MaDM { get => maDM; set => maDM = value; }
        public string TenDM { get => tenDM; set => tenDM = value; }
    }
}
