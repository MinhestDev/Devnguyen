namespace QuanLyBanHang
{
    partial class F_QLDonHang
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
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tbNgayLenDon = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tbMaDH = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tbTrangThaiDH = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tbMaNVDH = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tbMaKHDH = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToDeleteRows = false;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvDonHang.Location = new System.Drawing.Point(12, 303);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.Size = new System.Drawing.Size(1499, 381);
            this.dgvDonHang.TabIndex = 69;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã đơn hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SĐT khách hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên KH";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã nhân viên";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngày tạo";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tổng tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Trạng thái";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1521, 60);
            this.panel1.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý Thông tin Đơn hàng";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongTien.Location = new System.Drawing.Point(361, 179);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(304, 30);
            this.tbTongTien.TabIndex = 88;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(793, 89);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(94, 24);
            this.label30.TabIndex = 87;
            this.label30.Text = "Ngày tạo";
            // 
            // tbNgayLenDon
            // 
            this.tbNgayLenDon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgayLenDon.Location = new System.Drawing.Point(990, 86);
            this.tbNgayLenDon.Name = "tbNgayLenDon";
            this.tbNgayLenDon.ReadOnly = true;
            this.tbNgayLenDon.Size = new System.Drawing.Size(304, 30);
            this.tbNgayLenDon.TabIndex = 86;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(217, 86);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 24);
            this.label31.TabIndex = 85;
            this.label31.Text = "Mã DH";
            // 
            // tbMaDH
            // 
            this.tbMaDH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaDH.Location = new System.Drawing.Point(361, 86);
            this.tbMaDH.Name = "tbMaDH";
            this.tbMaDH.ReadOnly = true;
            this.tbMaDH.Size = new System.Drawing.Size(304, 30);
            this.tbMaDH.TabIndex = 84;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(217, 179);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(100, 24);
            this.label32.TabIndex = 83;
            this.label32.Text = "Tổng tiền";
            // 
            // tbTrangThaiDH
            // 
            this.tbTrangThaiDH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTrangThaiDH.Location = new System.Drawing.Point(990, 183);
            this.tbTrangThaiDH.Name = "tbTrangThaiDH";
            this.tbTrangThaiDH.ReadOnly = true;
            this.tbTrangThaiDH.Size = new System.Drawing.Size(304, 30);
            this.tbTrangThaiDH.TabIndex = 82;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(793, 189);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(106, 24);
            this.label33.TabIndex = 81;
            this.label33.Text = "Trạng thái";
            // 
            // tbMaNVDH
            // 
            this.tbMaNVDH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNVDH.Location = new System.Drawing.Point(990, 132);
            this.tbMaNVDH.Name = "tbMaNVDH";
            this.tbMaNVDH.ReadOnly = true;
            this.tbMaNVDH.Size = new System.Drawing.Size(304, 30);
            this.tbMaNVDH.TabIndex = 80;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(217, 132);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(84, 24);
            this.label34.TabIndex = 79;
            this.label34.Text = "SĐT KH";
            // 
            // tbMaKHDH
            // 
            this.tbMaKHDH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaKHDH.Location = new System.Drawing.Point(361, 131);
            this.tbMaKHDH.Name = "tbMaKHDH";
            this.tbMaKHDH.ReadOnly = true;
            this.tbMaKHDH.Size = new System.Drawing.Size(304, 30);
            this.tbMaKHDH.TabIndex = 78;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(793, 138);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 24);
            this.label35.TabIndex = 77;
            this.label35.Text = "Mã NV";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(923, 239);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(127, 35);
            this.button10.TabIndex = 90;
            this.button10.Text = "Chi tiết";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(487, 244);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 35);
            this.button11.TabIndex = 89;
            this.button11.Text = "Hủy";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // F_QLDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 693);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.tbNgayLenDon);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.tbMaDH);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.tbTrangThaiDH);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.tbMaNVDH);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.tbMaKHDH);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.panel1);
            this.Name = "F_QLDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_QLDonHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbNgayLenDon;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbMaDH;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbTrangThaiDH;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbMaNVDH;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbMaKHDH;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}