using QuanLyBanHang.DAO;
using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class F_Bill : Form
    {
        private DonHang dh;
        public F_Bill(string maDH)
        {
            InitializeComponent();
            dh = DonHangDAO.Instance.getByMa(maDH);
            showThongTin();
        }
        private void showThongTin()
        {
            KhachHang kh = KhachHangDAO.Instance.getBySDT(dh.SdtKH);
            if(kh==null)
            {
                lbSDTKH.Text = "Trống";
                lbTenKH.Text = "Khách vãn lai";
            }
            else
            {
                lbSDTKH.Text = kh.Sdt;
                lbTenKH.Text = kh.TenKH;
            }
            if(dh.MaNV=="")
            {
                lbMaNV.Text = "Admin";
            }   
            else lbMaNV.Text = dh.MaNV;
            lbTrangThai.Text = dh.TrangThai;
            lbMaDH.Text = dh.MaDH;
            lbNgayTao.Text = dh.ThoiGian.ToShortDateString();
            lbTongTien.Text = DataProvider.Instance.getDinhDanhHangNghin(dh.TongTien) + " VNĐ";
            dgvCTHD.Rows.Clear();
            int stt = 0;
            List<ChiTietDonHang> l = ChiTietDonHangDAO.Instance.loadDSByMaDH(dh.MaDH);
            foreach (ChiTietDonHang i in l)
            {
                DataGridViewRow row = (DataGridViewRow)dgvCTHD.Rows[0].Clone();
                stt++;
                row.Cells[0].Value = stt + "";
                SanPham sp = SanPhamDAO.Instance.getByMa(i.MaSP);
                row.Cells[1].Value = sp.TenSP;
                row.Cells[2].Value = sp.DonViTinh;
                row.Cells[3].Value = i.SoLuong;
                row.Cells[4].Value = i.DonGia;
                row.Cells[5].Value = DataProvider.Instance.getDinhDanhHangNghin(i.DonGia * i.SoLuong) + " VNĐ";
                dgvCTHD.Rows.Add(row);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void F_Bill_Load(object sender, EventArgs e)
        {

        }
    }
}
