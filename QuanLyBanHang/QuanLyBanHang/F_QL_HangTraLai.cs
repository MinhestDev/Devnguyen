using QuanLyBanHang.DAO;
using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class F_QL_HangTraLai : Form
    {
        private int so;
        public F_QL_HangTraLai()
        {
            InitializeComponent();
            so = 0;
            load();
        }
        private void load()
        {
            loadCbKhachHang();
            loadCbSanPham();
            loadCbTime1();
            loadDS();
        }
        private void loadCbKhachHang()
        {
            List<KhachHang> l = KhachHangDAO.Instance.loadDS();
            cbKhachHang.Items.Clear();
            cbKhachHang.Items.Add("Tất cả");
            cbKhachHang.Items.Add("Khách vãn lai");
            foreach (KhachHang i in l)
            {
                cbKhachHang.Items.Add(i.TenKH + " - " + i.Sdt);
            }
            cbKhachHang.Text = "Tất cả";
        }
        private void loadCbSanPham()
        {
            List<SanPham> l = SanPhamDAO.Instance.loadDS();
            cbSanPham.Items.Clear();
            cbSanPham.Items.Add("Tất cả");
            foreach(SanPham i in l) 
            {
                cbSanPham.Items.Add(i.TenSP);
            }
            cbSanPham.Text = "Tất cả";
        }
        private void loadCbTime1()
        {
            cbTime.Items.Clear();
            cbTime.Items.Add("Tất cả");
            cbTime.Items.Add("Từ " + dateDuoi.Text + " đến " + dateTren.Text);
            cbTime.Text = "Tất cả";
        }
        private void loadCbTime()
        {
            cbTime.Items.Clear();
            cbTime.Items.Add("Tất cả");
            cbTime.Items.Add("Từ "+ dateDuoi.Text + " đến "+ dateTren.Text);
            cbTime.Text = "Từ " + dateDuoi.Text + " đến " + dateTren.Text;
        }
        private void loadDS()
        {
            so++;
            if (so < 4)
                return;
            string s = "";
            if (cbKhachHang.Text != "Tất cả")
            {
                if (cbKhachHang.Text != "Khách vãn lai")
                {
                    string kh = cbKhachHang.Text;
                    string sdt = "";
                    for (int i = kh.Length - 1; i >= 0; i--)
                    {
                        if (kh[i] == ' ')
                            break;
                        sdt = kh[i] + sdt;
                    }
                    s += " AND DonHang.SDTKH=N'" + sdt + "'";
                }
                else s += " AND DonHang.SDTKH IS NULL";
            }
            if (cbSanPham.Text != "Tất cả")
            {
                SanPham sp = SanPhamDAO.Instance.getByTen(cbSanPham.Text);
                s += " AND ChiTietDonHang.MaSP=N'" + sp.MaSP + "'";
            }
            if (cbTime.Text != "Tất cả")
            {
                s += " AND DonHang.ThoiGian>='" + DataProvider.Instance.getDateSql((DateTime)dateDuoi.Value) + "'" +
                    " AND DonHang.ThoiGian<='" + DataProvider.Instance.getDateSql((DateTime)dateTren.Value) + "'";
            }
            List<ChiTietDonHang> l1 = ChiTietDonHangDAO.Instance.loadDSTraLai(s);
            List<string> lMaDH = new List<string>();
            List<ChiTietDonHang> l = new List<ChiTietDonHang>();
            foreach (ChiTietDonHang i in l1)
            {
                if (lMaDH.IndexOf(i.MaDH) < 0)
                {
                    lMaDH.Add(i.MaDH);
                }
                int j = 0;
                for (j = 0; j < l.Count; j++)
                    if (l[j].MaSP == i.MaSP && l[j].DonGia == i.DonGia)
                        break;
                if (j < l.Count)
                {
                    l[j].SoLuong = i.SoLuong + l[j].SoLuong;
                }
                else l.Add(i);
            }
            int tong = 0, demDH = 0,demSP=0;
            foreach (string i in lMaDH)
            {
                demDH++;
                DonHang d = DonHangDAO.Instance.getByMa(i);
                tong += d.TongTien;
            }
            dgvSanPham.Rows.Clear();
            int stt = 0;
            foreach (ChiTietDonHang i in l)
            {
                demSP += i.SoLuong;
                DataGridViewRow row = (DataGridViewRow)dgvSanPham.Rows[0].Clone();
                stt++;
                row.Cells[0].Value = stt + "";
                SanPham sp = SanPhamDAO.Instance.getByMa(i.MaSP);
                row.Cells[1].Value = sp.MaSP;
                row.Cells[2].Value = sp.TenSP;
                DanhMuc dm = DanhMucDAO.Instance.getByMa(sp.MaDM);
                row.Cells[3].Value = dm.TenDM;
                row.Cells[4].Value = sp.DonViTinh;
                row.Cells[5].Value = DataProvider.Instance.getDinhDanhHangNghin(i.SoLuong);
                row.Cells[6].Value = DataProvider.Instance.getDinhDanhHangNghin(i.DonGia);
                row.Cells[7].Value = DataProvider.Instance.getDinhDanhHangNghin(i.DonGia * i.SoLuong) + " VNĐ";
                dgvSanPham.Rows.Add(row);
            }
            tbTongTien.Text = DataProvider.Instance.getDinhDanhHangNghin(tong) + " VNĐ";
            tbSoDon.Text = DataProvider.Instance.getDinhDanhHangNghin(demDH);
            tbSoLuongSP.Text = DataProvider.Instance.getDinhDanhHangNghin(demSP);
        }
        private void F_QL_HangTraLai_Load(object sender, EventArgs e)
        {

        }

        private void dateDuoi_ValueChanged(object sender, EventArgs e)
        {
            loadCbTime();
            loadDS();
        }

        private void dateTren_ValueChanged(object sender, EventArgs e)
        {
            loadCbTime();
            loadDS();
        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDS();
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDS();
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDS();
        }
    }
}
