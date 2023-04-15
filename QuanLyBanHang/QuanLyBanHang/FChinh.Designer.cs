namespace QuanLyBanHang
{
    partial class FChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChinh));
            this.pnTong = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TrangChuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLThongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLyNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLyDanhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLySanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLyKhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLyDonHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLyTraLaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.quảnLýHạngThànhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTong.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTong
            // 
            this.pnTong.Controls.Add(this.pnBody);
            this.pnTong.Controls.Add(this.menuStrip1);
            this.pnTong.Location = new System.Drawing.Point(0, 0);
            this.pnTong.Name = "pnTong";
            this.pnTong.Size = new System.Drawing.Size(1561, 790);
            this.pnTong.TabIndex = 0;
            // 
            // pnBody
            // 
            this.pnBody.Location = new System.Drawing.Point(3, 35);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1550, 755);
            this.pnBody.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrangChuToolStripMenuItem1,
            this.thoátToolStripMenuItem,
            this.qLThongTinToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1561, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TrangChuToolStripMenuItem1
            // 
            this.TrangChuToolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.TrangChuToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TrangChuToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangChuToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("TrangChuToolStripMenuItem1.Image")));
            this.TrangChuToolStripMenuItem1.Name = "TrangChuToolStripMenuItem1";
            this.TrangChuToolStripMenuItem1.Size = new System.Drawing.Size(140, 28);
            this.TrangChuToolStripMenuItem1.Text = "Trang chủ";
            this.TrangChuToolStripMenuItem1.Click += new System.EventHandler(this.TrangChuToolStripMenuItem1_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.thoátToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(14, 28);
            // 
            // qLThongTinToolStripMenuItem
            // 
            this.qLThongTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLyNhanVienToolStripMenuItem,
            this.qLyDanhMucToolStripMenuItem,
            this.qLySanPhamToolStripMenuItem,
            this.qLyKhachHangToolStripMenuItem,
            this.qLyDonHangToolStripMenuItem,
            this.qLyTraLaiToolStripMenuItem,
            this.quảnLýHạngThànhViênToolStripMenuItem});
            this.qLThongTinToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qLThongTinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("qLThongTinToolStripMenuItem.Image")));
            this.qLThongTinToolStripMenuItem.Name = "qLThongTinToolStripMenuItem";
            this.qLThongTinToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.qLThongTinToolStripMenuItem.Text = "Quản lý Thông tin";
            this.qLThongTinToolStripMenuItem.Click += new System.EventHandler(this.qLThongTinToolStripMenuItem_Click);
            // 
            // qLyNhanVienToolStripMenuItem
            // 
            this.qLyNhanVienToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("qLyNhanVienToolStripMenuItem.Image")));
            this.qLyNhanVienToolStripMenuItem.Name = "qLyNhanVienToolStripMenuItem";
            this.qLyNhanVienToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.qLyNhanVienToolStripMenuItem.Text = "Quản lý Nhân viên";
            this.qLyNhanVienToolStripMenuItem.Click += new System.EventHandler(this.qLyNhanVienToolStripMenuItem_Click);
            // 
            // qLyDanhMucToolStripMenuItem
            // 
            this.qLyDanhMucToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.menu;
            this.qLyDanhMucToolStripMenuItem.Name = "qLyDanhMucToolStripMenuItem";
            this.qLyDanhMucToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.qLyDanhMucToolStripMenuItem.Text = "Quản lý Danh mục";
            this.qLyDanhMucToolStripMenuItem.Click += new System.EventHandler(this.qLyDanhMucToolStripMenuItem_Click);
            // 
            // qLySanPhamToolStripMenuItem
            // 
            this.qLySanPhamToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("qLySanPhamToolStripMenuItem.Image")));
            this.qLySanPhamToolStripMenuItem.Name = "qLySanPhamToolStripMenuItem";
            this.qLySanPhamToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.qLySanPhamToolStripMenuItem.Text = "Quản lý Sản Phẩm";
            this.qLySanPhamToolStripMenuItem.Click += new System.EventHandler(this.qLySanPhamToolStripMenuItem_Click);
            // 
            // qLyKhachHangToolStripMenuItem
            // 
            this.qLyKhachHangToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("qLyKhachHangToolStripMenuItem.Image")));
            this.qLyKhachHangToolStripMenuItem.Name = "qLyKhachHangToolStripMenuItem";
            this.qLyKhachHangToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.qLyKhachHangToolStripMenuItem.Text = "Quản lý Khách hàng";
            this.qLyKhachHangToolStripMenuItem.Click += new System.EventHandler(this.qLyKhachHangToolStripMenuItem_Click);
            // 
            // qLyDonHangToolStripMenuItem
            // 
            this.qLyDonHangToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.cart;
            this.qLyDonHangToolStripMenuItem.Name = "qLyDonHangToolStripMenuItem";
            this.qLyDonHangToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.qLyDonHangToolStripMenuItem.Text = "Quản lý Đơn hàng";
            this.qLyDonHangToolStripMenuItem.Click += new System.EventHandler(this.qLyDonHangToolStripMenuItem_Click);
            // 
            // qLyTraLaiToolStripMenuItem
            // 
            this.qLyTraLaiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("qLyTraLaiToolStripMenuItem.Image")));
            this.qLyTraLaiToolStripMenuItem.Name = "qLyTraLaiToolStripMenuItem";
            this.qLyTraLaiToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.qLyTraLaiToolStripMenuItem.Text = "Quản lý Hàng bị trả";
            this.qLyTraLaiToolStripMenuItem.Click += new System.EventHandler(this.qLyTraLaiToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem1,
            this.logoutToolStripMenuItem});
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.loginToolStripMenuItem.Text = "Đăng nhập";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem1
            // 
            this.accountToolStripMenuItem1.Image = global::QuanLyBanHang.Properties.Resources.th;
            this.accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            this.accountToolStripMenuItem1.Size = new System.Drawing.Size(278, 28);
            this.accountToolStripMenuItem1.Text = "Thông tin tài khoản";
            this.accountToolStripMenuItem1.Click += new System.EventHandler(this.accountToolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(278, 28);
            this.logoutToolStripMenuItem.Text = "Đăng xuất";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.thoátToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.thoátToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.thoátToolStripMenuItem1.Image = global::QuanLyBanHang.Properties.Resources.thoát;
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(99, 28);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // quảnLýHạngThànhViênToolStripMenuItem
            // 
            this.quảnLýHạngThànhViênToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.hạng;
            this.quảnLýHạngThànhViênToolStripMenuItem.Name = "quảnLýHạngThànhViênToolStripMenuItem";
            this.quảnLýHạngThànhViênToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.quảnLýHạngThànhViênToolStripMenuItem.Text = "Quản lý Hạng thành viên";
            this.quảnLýHạngThànhViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHạngThànhViênToolStripMenuItem_Click);
            // 
            // FChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 791);
            this.Controls.Add(this.pnTong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý Bán hàng Kinh Đô";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FChinh_FormClosing);
            this.pnTong.ResumeLayout(false);
            this.pnTong.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrangChuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem qLThongTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLyNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLyDanhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLySanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLyKhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLyDonHangToolStripMenuItem;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.ToolStripMenuItem qLyTraLaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHạngThànhViênToolStripMenuItem;
    }
}

