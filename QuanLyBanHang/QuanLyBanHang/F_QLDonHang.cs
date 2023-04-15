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
    public partial class F_QLDonHang : Form
    {
        public F_QLDonHang()
        {
            InitializeComponent();
            loadDS();
        }
        private void loadDS()
        {
            dgvDonHang.Rows.Clear();
            int stt = 0;
            List<DonHang> l = DonHangDAO.Instance.loadDS();
            foreach (DonHang i in l)
            {
                DataGridViewRow row = (DataGridViewRow)dgvDonHang.Rows[0].Clone();
                stt++;
                row.Cells[0].Value = stt + "";
                row.Cells[1].Value = i.MaDH;
                KhachHang kh = KhachHangDAO.Instance.getBySDT(i.SdtKH);
                if (kh == null)
                {
                    row.Cells[2].Value = "Trống";
                    row.Cells[3].Value = "Khách vãn lai";
                }
                else
                {
                    row.Cells[2].Value = kh.Sdt;
                    row.Cells[3].Value = kh.TenKH;
                }
                string maNV = i.MaNV;
                if (string.IsNullOrEmpty(maNV))
                    maNV = "admin";
                row.Cells[4].Value = maNV;
                row.Cells[5].Value = i.ThoiGian.ToShortDateString();
                row.Cells[6].Value = DataProvider.Instance.getDinhDanhHangNghin(i.TongTien) + " VNĐ";
                row.Cells[7].Value = i.TrangThai;
                dgvDonHang.Rows.Add(row);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            DonHang dh = DonHangDAO.Instance.getByMa(tbMaDH.Text);
            if (dh == null)
            {
                MessageBox.Show("Hãy chọn đơn hàng cần hủy trước !", "Nhắc nhở");
                return;
            }
            if (dh.TrangThai != "Chưa hoàn thành")
            {
                MessageBox.Show("Đơn hàng đã hoành thành hoặc đã hủy !", "Nhắc nhở");
                return;
            }
            if (MessageBox.Show("Xác nhận hủy đơn hàng " + dh.MaDH + " ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DonHangDAO.Instance.huy(dh.MaDH);
                loadDS();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            DonHang dh = DonHangDAO.Instance.getByMa(tbMaDH.Text);
            if (dh == null)
            {
                MessageBox.Show("Hãy chọn đơn hàng xem chi tiết trước !", "Nhắc nhở");
                return;
            }
            F_Bill f = new F_Bill(dh.MaDH);
            f.ShowDialog();
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvDonHang.Rows[e.RowIndex];
                tbMaDH.Text = Convert.ToString(row.Cells[1].Value);
                DonHang dh = DonHangDAO.Instance.getByMa(tbMaDH.Text);
                if (string.IsNullOrEmpty(tbMaDH.Text) == false)
                {
                    KhachHang kh = KhachHangDAO.Instance.getBySDT(dh.SdtKH);
                    if (kh == null)
                    {
                        tbMaKHDH.Text = "Trống";
                    }
                    else
                    {
                        tbMaKHDH.Text =kh.Sdt;
                    }
                }
                tbMaNVDH.Text= Convert.ToString(row.Cells[4].Value);
                tbNgayLenDon.Text = Convert.ToString(row.Cells[5].Value);
                tbTongTien.Text= Convert.ToString(row.Cells[6].Value);
                tbTrangThaiDH.Text = Convert.ToString(row.Cells[7].Value);
            }
            catch (Exception)
            { }
        }
    }
}
