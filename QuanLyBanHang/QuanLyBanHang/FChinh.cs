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
    public partial class FChinh : Form
    {
        private DangNhap dn;
        private Form formCon;
        public FChinh()
        {
            InitializeComponent();
            setLogOut();
        }

        private void OpenChildForm(Form childForm)
        {
            if (formCon != null)
            {
                formCon.Close();
            }
            formCon = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void FChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình ?", "Xác nhận", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setLogOut()
        {
            accountToolStripMenuItem1.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Text = "Đăng nhập"; 
            TrangChuToolStripMenuItem1.Enabled = false;
            qLThongTinToolStripMenuItem.Enabled = false;
            dn = null;
        }    
        private void setNhanVien()
        {
            accountToolStripMenuItem1.Enabled = true;
            logoutToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Text = "Tài khoản";
            TrangChuToolStripMenuItem1.Enabled = true;
            qLThongTinToolStripMenuItem.Enabled = false;
        }
        private void setAdmin()
        {
            accountToolStripMenuItem1.Enabled = true;
            logoutToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Text = "Tài khoản";
            TrangChuToolStripMenuItem1.Enabled = true;
            qLThongTinToolStripMenuItem.Enabled = true;

        }
        private void checkLoaiDn()
        {
            if (string.IsNullOrEmpty(dn.MaNV))
                setAdmin();
            else setNhanVien();
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginToolStripMenuItem.Text == "Đăng nhập")
            {
                FDangNhap f = new FDangNhap();
                f.ShowDialog();
                dn = f.Dn;
                if (dn != null)
                {
                    dn = DangNhapDAO.Instance.getByTaiKhoan(dn.TaiKhoan);
                    checkLoaiDn();
                    pnBody.Show();
                    runTrangChu();
                }
            }
        }
        private void runTrangChu()
        {
             OpenChildForm(new F_BanHang(dn));
            
        }
        private void TrangChuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            runTrangChu();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất tài khoản ?","Xác nhận", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                setLogOut();
            }
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FThongTinDangNhap f = new FThongTinDangNhap(dn);
            f.ShowDialog();
            dn = f.Dn;
        }
        private void qLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_QLNhanVien());
        }

        private void qLyDanhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_QLDanhMuc());
        }

        private void qLySanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_QLSanPham());
        }

        private void qLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_QLKhachHang());
        }

        private void qLyDonHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_QLDonHang());
        }

        private void qLyTraLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_QL_HangTraLai());
        }

        private void qLThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýHạngThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_QL_HangTraLai());
        }
    }
}
