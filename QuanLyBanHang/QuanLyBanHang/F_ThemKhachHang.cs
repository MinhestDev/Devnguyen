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
    public partial class F_ThemKhachHang : Form
    {
        private KhachHang kh;
        public F_ThemKhachHang()
        {
            InitializeComponent();
            Kh = null; ; ;
        }

        public KhachHang Kh { get => kh; set => kh = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DataProvider.Instance.checkSDT(tbSDT.Text)==false) 
            {
                MessageBox.Show("SĐT phải là chuỗi 9->12 ký tự số !", "Nhắc nhở");
                return;
            }
            if (KhachHangDAO.Instance.getBySDT(tbSDT.Text)!=null)
            {
                MessageBox.Show("SĐT đã được khách hàng khác sử dụng !", "Nhắc nhở");
                return;
            }
            if (string.IsNullOrEmpty(tbHoTen.Text))
            {
                MessageBox.Show("Họ tên khách hàng không được để trống !", "Nhắc nhở");
                return;
            }
            KhachHangDAO.Instance.them(tbSDT.Text,tbHoTen.Text,tbDiaChi.Text);
            MessageBox.Show("Thêm khách hàng mới thành công", "Thông báo");
            Kh = KhachHangDAO.Instance.getBySDT(tbSDT.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
