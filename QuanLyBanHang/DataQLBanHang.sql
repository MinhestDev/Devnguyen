﻿CREATE DATABASE DataBanHang
GO
USE DataBanHang
GO
CREATE FUNCTION dbo.AUTO_IDNV()
RETURNS NVARCHAR(20)
AS
BEGIN
	DECLARE @ID NVARCHAR(20)
	IF (SELECT COUNT(MaNV) FROM NHANVIEN) = 0
		SET @ID = N'0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaNV, 4)) FROM NHANVIEN
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN N'NV000' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN N'NV00' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99 THEN N'NV0' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999 THEN N'NV' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
CREATE TABLE NhanVien
(
     MaNV NVARCHAR(20) CONSTRAINT IDNV DEFAULT dbo.AUTO_IDNV() PRIMARY KEY,
	 HoTen NVARCHAR(100) NULL,
	 SDT NVARCHAR(20) NULL,
	 Luong INT NULL
)
GO
CREATE TABLE DangNhap
(
     TaiKhoan NVARCHAR(20)  NOT NULL PRIMARY KEY,
	 MatKhau NVARCHAR(20) NULL DEFAULT N'1234',
	 MaNV NVARCHAR(20) NULL
	 FOREIGN KEY (MaNV) REFERENCES NhanVien
)
GO
CREATE FUNCTION dbo.AUTO_IDDanhMuc()
RETURNS NVARCHAR(20)
AS
BEGIN
	DECLARE @ID NVARCHAR(20)
	IF (SELECT COUNT(MaDM) FROM DanhMuc) = 0
		SET @ID = N'0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaDM, 3)) FROM DanhMuc
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN N'DM00' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN N'DM0' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99 THEN N'DM' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
CREATE TABLE DanhMuc
(
     MaDM NVARCHAR(20)  CONSTRAINT IDDM DEFAULT dbo.AUTO_IDDanhMuc() PRIMARY KEY,
	 TenDM NVARCHAR(100) NULL
)
GO
CREATE FUNCTION dbo.AUTO_IDSP()
RETURNS NVARCHAR(20)
AS
BEGIN
	DECLARE @ID NVARCHAR(20)
	IF (SELECT COUNT(MaSP) FROM SanPham) = 0
		SET @ID = N'0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaSP, 4)) FROM SanPham
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN N'SP000' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN N'SP00' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99 THEN N'SP0' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999 THEN N'SP' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
CREATE TABLE SanPham
(
     MaSP NVARCHAR(20)  CONSTRAINT IDSP DEFAULT dbo.AUTO_IDSP() PRIMARY KEY,
	 TenSP NVARCHAR(100) NULL,
	 DonViTinh NVARCHAR(50) NULL,
	 MaDM NVARCHAR(20) NULL,
	 DonGia INT DEFAULT 0
	 FOREIGN KEY (MaDM) REFERENCES dbo.DanhMuc
)
GO
CREATE TABLE KhachHang
(
     SDT NVARCHAR(20) PRIMARY KEY,
	 TenKH NVARCHAR(100)  NULL,
	 DiaChi NVARCHAR(200) NULL
)
GO
CREATE FUNCTION dbo.AUTO_IDDH()
RETURNS NVARCHAR(20)
AS
BEGIN
	DECLARE @ID NVARCHAR(20)
	IF (SELECT COUNT(MaDH) FROM DonHang) = 0
		SET @ID = N'0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaDH, 4)) FROM DonHang
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN N'DH000' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN N'DH00' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99 THEN N'DH0' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999 THEN N'DH' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
CREATE TABLE DonHang
(
     MaDH NVARCHAR(20)  CONSTRAINT IDDH DEFAULT dbo.AUTO_IDDH() PRIMARY KEY,
	 SDTKH NVARCHAR(20) NULL,
	 MaNV NVARCHAR(20) NULL,
	 ThoiGian DATE DEFAULT GETDATE(),
	 TongTien INT DEFAULT 0,
	 TrangThai NVARCHAR(200) DEFAULT N'Chưa hoàn thành'
	 FOREIGN KEY (SDTKH) REFERENCES dbo.KhachHang(SDT),
	 FOREIGN KEY (MaNV) REFERENCES dbo.NhanVien(MaNV)
)
GO
CREATE FUNCTION dbo.AUTO_IDCTDH()
RETURNS NVARCHAR(20)
AS
BEGIN
	DECLARE @ID NVARCHAR(20)
	IF (SELECT COUNT(MaCT) FROM ChiTietDonHang) = 0
		SET @ID = N'0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCT, 4)) FROM ChiTietDonHang
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN N'CT000' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN N'CT00' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN N'CT0' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN N'CT' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
CREATE TABLE ChiTietDonHang
(
     MaCT NVARCHAR(20) CONSTRAINT IDCTDH DEFAULT dbo.AUTO_IDCTDH() PRIMARY KEY,
	 MaDH NVARCHAR(20) NULL,
	 MaSP NVARCHAR(20) NULL,
	 DonGia INT  NULL,
	 SoLuong INT NULL
	 FOREIGN KEY (MaDH) REFERENCES dbo.DonHang(MaDH),
	 FOREIGN KEY (MaSP) REFERENCES dbo.SanPham(MaSP)
)
GO
INSERT INTO DangNhap VALUES(N'admin',N'1234',NULL)
GO
CREATE FUNCTION dbo.AUTO_IDHang()
RETURNS NVARCHAR(20)
AS
BEGIN
	DECLARE @ID NVARCHAR(20)
	IF (SELECT COUNT(MaNV) FROM NHANVIEN) = 0
		SET @ID = N'0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaNV, 4)) FROM NHANVIEN
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN N'NV000' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN N'NV00' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99 THEN N'NV0' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999 THEN N'NV' + CONVERT(NVARCHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
CREATE TABLE HangThanhVien
(
	 MaHang NVARCHAR(20) CONSTRAINT IDHang DEFAULT dbo.AUTO_IDHang() PRIMARY KEY,
	 TenHang NVARCHAR(100) NULL,
	 DieuKien INT,
	 UuDai INT 
)
GO