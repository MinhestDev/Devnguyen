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
    public partial class F_QLSanPham : Form
    {
        public F_QLSanPham()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            loadDS();
            loadCbDanhMuc();
        }
        private void loadDS()
        {
            dgvSanPham.Rows.Clear();
            int stt = 0;
            List<SanPham> l = SanPhamDAO.Instance.loadDS();
            foreach (SanPham i in l)
            {
                DataGridViewRow row = (DataGridViewRow)dgvSanPham.Rows[0].Clone();
                stt++;
                row.Cells[0].Value = stt + "";
                row.Cells[1].Value = i.MaSP;
                row.Cells[2].Value = i.TenSP;
                DanhMuc dm = DanhMucDAO.Instance.getByMa(i.MaDM);
                row.Cells[3].Value = dm.TenDM;
                row.Cells[4].Value = i.DonViTinh;
                row.Cells[5].Value = i.DonGia;
                dgvSanPham.Rows.Add(row);
            }
        }
        private void loadCbDanhMuc()
        {
            List<DanhMuc> l = DanhMucDAO.Instance.loadDS();
            cbDanhMuc.DataSource = l;
            cbDanhMuc.DisplayMember = "TenDM";
            if (l.Count > 0)
                cbDanhMuc.Text = l[0].TenDM;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DanhMuc dm = DanhMucDAO.Instance.getByTen(cbDanhMuc.Text);
            if(dm==null)
            {
                MessageBox.Show("Hãy chọn danh mục trước !", "Nhắc nhở");
                return;
            }
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống !", "Nhắc nhở");
                return ;
            }
            SanPham sp = SanPhamDAO.Instance.getByTen(tbTen.Text);
            if (sp != null)
            {
                MessageBox.Show("Sản phẩm " + tbTen.Text + " đã tồn tại !", "Nhắc nhở");
                return;
            }
            SanPhamDAO.Instance.them(tbTen.Text, dm.MaDM, tbDonViTinh.Text, (int)nudDonGia.Value);
            loadDS();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SanPham sp = SanPhamDAO.Instance.getByMa(tbMa.Text);
            if (sp == null)
            {
                MessageBox.Show("Hãy chọn sản phẩm cần xóa trước !", "Nhắc nhở");
                return;
            }
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + sp.TenSP + " ?\nMọi dữ liệu liên quan sẽ bị mất !", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                SanPhamDAO.Instance.xoa(sp.MaSP);
                loadDS();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanPham sp = SanPhamDAO.Instance.getByMa(tbMa.Text);
            if (sp == null)
            {
                MessageBox.Show("Hãy chọn sản phẩm cần sửa trước !", "Nhắc nhở");
                return;
            }
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống !", "Nhắc nhở");
                return;
            }
            SanPham sp2 = SanPhamDAO.Instance.getByTen(tbTen.Text);
            if (sp2 != null&&sp2.MaSP!=sp.MaSP)
            {
                MessageBox.Show("Sản phẩm " + tbTen.Text + " đã tồn tại !", "Nhắc nhở");
                return;
            }
            DanhMuc dm = DanhMucDAO.Instance.getByTen(cbDanhMuc.Text);
            SanPhamDAO.Instance.sua(sp.MaSP,tbTen.Text, dm.MaDM, tbDonViTinh.Text, (int)nudDonGia.Value);
            loadDS();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvSanPham.Rows[e.RowIndex];
                tbMa.Text = Convert.ToString(row.Cells[1].Value);
                if (string.IsNullOrEmpty(tbMa.Text))
                {
                    return;
                }
                tbTen.Text = Convert.ToString(row.Cells[2].Value);
                cbDanhMuc.Text = Convert.ToString(row.Cells[3].Value);
                tbDonViTinh.Text = Convert.ToString(row.Cells[4].Value);
                nudDonGia.Value = Convert.ToInt32(row.Cells[5].Value);
            }
            catch (Exception)
            { }
        }
    }
}
