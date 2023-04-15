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
    public partial class FDangNhap : Form
    {
        private DangNhap dn;
        public FDangNhap()
        {
            InitializeComponent();
            Dn = null;
        }

        public DangNhap Dn { get => dn; set => dn = value; }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            dn = DangNhapDAO.Instance.getByTaiKhoanMatKhau(tbTaiKhoan.Text,tbMatKhau.Text);
            if (dn!=null)
            {
                MessageBox.Show("Đăng nhập thành công ", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !", "Nhắc nhở");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btShow_Click(object sender, EventArgs e)
        {
            if (btShow.Text == "Hiện")
            {
                tbMatKhau.UseSystemPasswordChar = false;
                btShow.Text = "Ẩn";
            }
            else
            {
                tbMatKhau.UseSystemPasswordChar = true;
                btShow.Text = "Hiện";
            }
        }
    }
}
