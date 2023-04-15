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
    public partial class F_QLDanhMuc : Form
    {
        public F_QLDanhMuc()
        {
            InitializeComponent();
            loadDS();
        }
        private void loadDS()
        {
            dgvDanhMuc.Rows.Clear();
            int stt = 0;
            List<DanhMuc> l = DanhMucDAO.Instance.loadDS();
            foreach (DanhMuc i in l)
            {
                DataGridViewRow row = (DataGridViewRow)dgvDanhMuc.Rows[0].Clone();
                stt++;
                row.Cells[0].Value = stt + "";
                row.Cells[1].Value = i.MaDM;
                row.Cells[2].Value = i.TenDM;
                dgvDanhMuc.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenDM.Text))
            {
                MessageBox.Show("Tên danh mục không được để trống !", "Nhắc nhở");
                return;
            }
            if (DanhMucDAO.Instance.getByTen(tbTenDM.Text) != null)
            {
                MessageBox.Show("Danh mục '" + tbTenDM.Text + "' đã tồn tại !", "Nhắc nhở");
                return;
            }
            DanhMucDAO.Instance.them(tbTenDM.Text);
            loadDS();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaDM.Text))
            {
                MessageBox.Show("Hãy chọn danh mục cần xóa trước !", "Nhắc nhở");
                return;
            }
            DanhMuc dm = DanhMucDAO.Instance.getByMa(tbMaDM.Text);
            if (MessageBox.Show("Xác nhận xóa danh mục "+dm.TenDM+" ?\nMọi dữ liệu liên quan sẽ bị mất !", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DanhMucDAO.Instance.xoa(tbMaDM.Text);
                loadDS();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaDM.Text))
            {
                MessageBox.Show("Hãy chọn danh mục cần xóa trước !", "Nhắc nhở");
                return;
            }
            if (string.IsNullOrEmpty(tbTenDM.Text))
            {
                MessageBox.Show("Tên danh mục không được để trống !", "Nhắc nhở");
                return;
            }
            DanhMuc dm = DanhMucDAO.Instance.getByTen(tbTenDM.Text);
            if (dm != null&&dm.MaDM!=tbMaDM.Text)
            {
                MessageBox.Show("Danh mục '" + tbTenDM.Text + "' đã tồn tại !", "Nhắc nhở");
                return;
            }
            DanhMucDAO.Instance.sua(tbMaDM.Text,tbTenDM.Text);
            loadDS();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhMuc.Rows[e.RowIndex];
                tbMaDM.Text = Convert.ToString(row.Cells[1].Value);
                if (string.IsNullOrEmpty(tbMaDM.Text))
                {
                    return;
                }
                tbTenDM.Text = Convert.ToString(row.Cells[2].Value);
            }
            catch (Exception)
            { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
