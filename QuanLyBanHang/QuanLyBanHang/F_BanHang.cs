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
    public partial class F_BanHang : Form
    {
        private DangNhap dn;
        public F_BanHang(DangNhap dn)
        {
            InitializeComponent();
            this.dn = dn;
            load();
        }
        private void load()
        {
            loadDonChuaHT();
            loadCbDanhMuc();
            loadCbSanPham();
            loadCbKhachHang();
            tbMaDH.Hide();
        }
        private void loadCbDanhMuc()
        {
            List<DanhMuc> l = DanhMucDAO.Instance.loadDS();
            cbDanhMuc.DataSource = l;
            cbDanhMuc.DisplayMember = "TenDM";
            if (l.Count > 0)
                cbDanhMuc.Text = l[0].TenDM;
        }
        private void loadCbKhachHang()
        {
            List<KhachHang> l = KhachHangDAO.Instance.loadDS();
            cbKhachHang.Items.Clear();
            cbKhachHang.Items.Add("Khách vãn lai");
            foreach(KhachHang i in l)
            {
                cbKhachHang.Items.Add(i.TenKH+" - "+i.Sdt);
            }
            cbKhachHang.Text = "Khách vãn lai";
        }
        private void loadCbSanPham()
        {
            List<SanPham> l = SanPhamDAO.Instance.loadDSByTenDM(cbDanhMuc.Text);
            cbSanPham.DataSource = l;
            cbSanPham.DisplayMember = "TenSP";
            if (l.Count > 0)
                cbSanPham.Text = l[0].TenSP;
        }
        void loadDonChuaHT()
        {
            dgvDonHang.Rows.Clear();
            int stt = 0;
            List<DonHang> l = DonHangDAO.Instance.loadDSChuaHT();
            foreach (DonHang i in l)
            {
                DataGridViewRow row = (DataGridViewRow)dgvDonHang.Rows[0].Clone();
                stt++;
                row.Cells[0].Value = stt + "";
                row.Cells[1].Value = i.MaDH;
                string maNV = i.MaNV;
                if (string.IsNullOrEmpty(maNV))
                    maNV = "admin";
                row.Cells[2].Value = maNV;
                KhachHang kh = KhachHangDAO.Instance.getBySDT(i.SdtKH);
                if(kh==null)
                {
                    row.Cells[3].Value = "Trống";
                    row.Cells[4].Value = "Khách vãn lai";
                }
                else
                {
                    row.Cells[3].Value = kh.Sdt;
                    row.Cells[4].Value = kh.TenKH;
                }
                row.Cells[5].Value = i.ThoiGian.ToShortDateString();
                row.Cells[6].Value = DataProvider.Instance.getDinhDanhHangNghin(i.TongTien)+ " VNĐ";
                dgvDonHang.Rows.Add(row);
            }
        }

        private void showHoaDon()
        {
            dgvCTHD.Rows.Clear();
            int stt = 0;
            List<ChiTietDonHang> l = ChiTietDonHangDAO.Instance.loadDSByMaDH(tbMaDH.Text);
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
                row.Cells[5].Value = DataProvider.Instance.getDinhDanhHangNghin(i.DonGia*i.SoLuong)+" VNĐ";
                dgvCTHD.Rows.Add(row);
            }
            DonHang dh = DonHangDAO.Instance.getByMa(tbMaDH.Text);
            if (dh != null)
                tbTong.Text = DataProvider.Instance.getDinhDanhHangNghin(dh.TongTien) + " VNĐ";
            else tbTong.Text = "0 VNĐ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_ThemKhachHang f = new F_ThemKhachHang();
            f.ShowDialog();
            if(f.Kh!=null)
            {
                loadCbKhachHang();
                cbKhachHang.Text = f.Kh.TenKH + " - " + f.Kh.Sdt;
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DonHang dh = DonHangDAO.Instance.getByMa(tbMaDH.Text);
            if (dh == null)
            {
                MessageBox.Show("Hãy chọn đơn hàng trước !", "Nhắc nhở");
                return;
            }
            if (MessageBox.Show("Xác nhận thanh toán đơn hàng "+dh.MaDH+" ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DonHangDAO.Instance.thanhToan(dh.MaDH);
                tbMaDH.Text = "";
                loadDonChuaHT();
                showHoaDon();
            }
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
                        cbKhachHang.Text = "Khách vãn lai";
                    }
                    else
                    {
                        cbKhachHang.Text = kh.TenKH + " - " + kh.Sdt;
                    }
                }
            }
            catch (Exception)
            { }
            showHoaDon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DonHang dh = DonHangDAO.Instance.getByMa(tbMaDH.Text);
            if (dh==null)
            {
                MessageBox.Show("Hãy chọn đơn hàng trước !", "Thông báo");
                return;
            }
            SanPham sp = SanPhamDAO.Instance.getByTen(cbSanPham.Text);
            if (sp == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước !", "Thông báo");
                return;
            }
            ChiTietDonHangDAO.Instance.them(dh.MaDH, sp.MaSP, (int)nudSoLuong.Value, sp.DonGia);
            showHoaDon();
            loadDonChuaHT();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DonHang dh = DonHangDAO.Instance.getByMa(tbMaDH.Text);
            if (dh == null)
            {
                MessageBox.Show("Hãy chọn đơn hàng trước !", "Nhắc nhở");
                return;
            }
            if (MessageBox.Show("Xác nhận hủy đơn hàng " + dh.MaDH + " ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DonHangDAO.Instance.huy(dh.MaDH);
                tbMaDH.Text = "";
                loadDonChuaHT();
                showHoaDon();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sdt = "";
            if(cbKhachHang.Text!="Khách vãn lai")
            {
                string kh = cbKhachHang.Text;
                for(int i=kh.Length-1;i>=0;i--)
                {
                    if (kh[i] == ' ')
                        break;
                    sdt = kh[i]+sdt;
                }    
            }
            if(string.IsNullOrEmpty(sdt)==false)
            {
                if(DonHangDAO.Instance.getDonChuaHTBySDT(sdt)!=null)
                {
                    MessageBox.Show("Khách hàng này đang có 1 đơn chưa hoàn thành !", "Nhắc nhở");
                    return;
                } 
            }    
            DonHangDAO.Instance.them(sdt,dn.MaNV);
            DonHang dh = DonHangDAO.Instance.getMaxNow();
            tbMaDH.Text = dh.MaDH;
            loadDonChuaHT();
            showHoaDon();
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCbSanPham();
        }

        private void F_BanHang_Load(object sender, EventArgs e)
        {

        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
