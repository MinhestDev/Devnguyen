using QuanLyBanHang.DAO;
using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class F_QLNhanVien : Form
    {
        public F_QLNhanVien()
        {
            InitializeComponent();
            loadDS();
        }
        private void loadDS()
        {
            dgvNhanVien.Rows.Clear();
            int stt = 0;
            List<NhanVien> l = NhanVienDAO.Instance.loadDS();
            foreach (NhanVien i in l)
            {
                DataGridViewRow row = (DataGridViewRow)dgvNhanVien.Rows[0].Clone();
                stt++;
                row.Cells[0].Value = stt + "";
                DangNhap dn = DangNhapDAO.Instance.getByMaNV(i.MaNV);
                row.Cells[1].Value = i.MaNV;
                row.Cells[2].Value = i.HoTen;
                row.Cells[3].Value = i.Sdt;
                row.Cells[4].Value = i.Luong;
                row.Cells[5].Value = dn.TaiKhoan;
                row.Cells[6].Value = dn.MatKhau;
                dgvNhanVien.Rows.Add(row);
            }
        }

        private void btXoaNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nv = NhanVienDAO.Instance.getNhanVienByMa(tbMaNV.Text);
            if (nv == null)
            {
                MessageBox.Show("Nhân viên không tồn tại !", "Nhắc nhở");
                return;
            }
            if (MessageBox.Show("Xác nhận xóa nhân viên "+nv.HoTen+" ?\nMọi dữ liệu liên quan sẽ bị mất !", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                NhanVienDAO.Instance.xoa(tbMaNV.Text);
                loadDS();
            }
        }

        private void btCapNhatNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaNV.Text))
            {
                MessageBox.Show("Hãy chọn nhân viên cần cập nhật thông tin trước !", "Nhắc nhở");
                return;
            }
            if (string.IsNullOrEmpty(tbHoTenNV.Text))
            {
                MessageBox.Show("Họ tên không được để trống !", "Nhắc nhở");
                return;
            }
            if (DataProvider.Instance.checkSDT(tbSDTNV.Text) == false)
            {
                MessageBox.Show("SĐT phải là chuỗi 9->12 ký tự số !", "Nhắc nhở");
                return;
            }
            NhanVien nv = NhanVienDAO.Instance.getNhanVienBySDT(tbSDTNV.Text);
            if (nv != null&&nv.MaNV!=tbMaNV.Text)
            {
                MessageBox.Show("Số điện thoại '" + tbSDTNV.Text + "' đã được nhân viên khác sử dụng !", "Nhắc nhở");
                return;
            }
            NhanVienDAO.Instance.sua(tbMaNV.Text, tbHoTenNV.Text, tbSDTNV.Text, (int)nudLuongNV.Value);
            loadDS();
        }
        
        private void btThemNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbHoTenNV.Text))
            {
                MessageBox.Show("Họ tên không được để trống !", "Nhắc nhở");
                return ;
            }
            if (DataProvider.Instance.checkSDT(tbSDTNV.Text) == false)
            {
                MessageBox.Show("SĐT phải là chuỗi 9->12 ký tự số !", "Nhắc nhở");
                return;
            }
            NhanVien nv = NhanVienDAO.Instance.getNhanVienBySDT(tbSDTNV.Text);
            if (nv != null)
            {
                MessageBox.Show("Số điện thoại '" + tbSDTNV.Text + "' đã được nhân viên khác sử dụng !", "Nhắc nhở");
                return ;
            }
            NhanVienDAO.Instance.them(tbHoTenNV.Text, tbSDTNV.Text, (int)nudLuongNV.Value);
            loadDS();
        }

        private void tbTimNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvNhanVien.Rows[e.RowIndex];
                tbMaNV.Text = Convert.ToString(row.Cells[1].Value);
                if (string.IsNullOrEmpty(tbMaNV.Text))
                {
                    return;
                }
                tbHoTenNV.Text = Convert.ToString(row.Cells[2].Value);
                tbSDTNV.Text = Convert.ToString(row.Cells[3].Value);
                nudLuongNV.Value = Convert.ToInt32(row.Cells[4].Value);
                tbTaiKhoanNV.Text = Convert.ToString(row.Cells[5].Value);
                tbMatKhauNV.Text = Convert.ToString(row.Cells[6].Value);
            }
            catch (Exception)
            { }
        }
    }
}
