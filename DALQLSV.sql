USE master;
GO
ALTER DATABASE QuanLySinhVien SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
DROP DATABASE QuanLySinhVien;
GO
CREATE DATABASE QuanLySinhVien;
GO
USE QuanLySinhVien;
GO


-- Bảng tài khoản
CREATE TABLE TaiKhoan (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(50) UNIQUE NOT NULL,
    MatKhau NVARCHAR(50) NOT NULL,
    LoaiNguoiDung NVARCHAR(20) CHECK (LoaiNguoiDung IN ('SinhVien', 'GiangVien', 'Admin')) NOT NULL,
    MaNguoiDung NVARCHAR(20) NOT NULL UNIQUE
);
go 
-- Bảng tỉnh thành
CREATE TABLE TinhThanh
(
    MaTinhThanh	INT NOT NULL PRIMARY KEY,
    TenTinhThanh NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE QuanHuyen
(
    MaQuanHuyen INT NOT NULL PRIMARY KEY,
    MaTinhThanh INT NOT NULL,
    TenQuanHuyen NVARCHAR(100) NOT NULL, 
    CONSTRAINT FK_QuanHuyen_TinhThanh
        FOREIGN KEY (MaTinhThanh)
        REFERENCES TinhThanh (MaTinhThanh)
);
GO

-- Bảng Khoa
CREATE TABLE dbo.Khoa
(
    MaKhoa     NVARCHAR(10) NOT NULL,
    TenKhoa    NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_Khoa PRIMARY KEY (MaKhoa)
);
GO

-- Bảng Lớp
CREATE TABLE dbo.Lop
(
    MaLop       NVARCHAR(10) NOT NULL,
    TenLop      NVARCHAR(50) NOT NULL,
    MaKhoa      NVARCHAR(10) NULL, 
    CONSTRAINT PK_Lop PRIMARY KEY (MaLop),
    CONSTRAINT FK_Lop_Khoa
        FOREIGN KEY (MaKhoa)
        REFERENCES dbo.Khoa(MaKhoa)
        ON DELETE NO ACTION
        ON UPDATE CASCADE
);
GO

-- Bảng Môn Học
CREATE TABLE dbo.MonHoc
(
    MaMonHoc   NVARCHAR(10) NOT NULL PRIMARY KEY,
    TenMonHoc  NVARCHAR(50) NOT NULL,
    SoTinChi   INT		 NOT NULL,
	MaKhoa NVARCHAR(10)     NOT NULL,
	SoTiet INT NOT NULL,
    LoaiMon NVARCHAR(50) NOT NULL,
	CONSTRAINT FK_MonHoc_MaKhoa FOREIGN KEY (MaKhoa) REFERENCES dbo.Khoa(MaKhoa)
);
Go

-- Bảng Thong_Tin_Sinh_Vien
CREATE TABLE Thong_Tin_Sinh_Vien (
    MaSV NVARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(20) NOT NULL,
    NgaySinh DATE NOT NULL,
    NoiSinh NVARCHAR(20) NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL,
    CCCD NVARCHAR(20) NOT NULL,
    DanToc NVARCHAR(10) NOT NULL,
    LopSV NVARCHAR(10) NOT NULL,
	Photo IMAGE NULL,
	CONSTRAINT FK_ThongTinSinhVien_TaiKhoan FOREIGN KEY (MaSV) REFERENCES dbo.TaiKhoan(MaNguoiDung)
);
GO

-- Bảng Thong_Tin_Lien_Lac
CREATE TABLE Thong_Tin_Lien_Lac (
    MaSV NVARCHAR(20) PRIMARY KEY,
    QuocGia NVARCHAR(20) NULL,
    MaTinhThanh INT NULL,
    MaQuanHuyen INT NULL,
    Phuong NVARCHAR(20) NULL,
    SoNha NVARCHAR(20) NULL,
    DiaChi NVARCHAR(200) NULL,
    DiDong NVARCHAR(20) NULL,
    Email NVARCHAR(30) NULL,
    FOREIGN KEY (MaSV) REFERENCES Thong_Tin_Sinh_Vien(MaSV),
    FOREIGN KEY (MaTinhThanh) REFERENCES TinhThanh(MaTinhThanh),
    FOREIGN KEY (MaQuanHuyen) REFERENCES QuanHuyen(MaQuanHuyen)
);
GO

ALTER TABLE Thong_Tin_Lien_Lac
    ADD CONSTRAINT FK_TTL_TinhThanh
    FOREIGN KEY (MaTinhThanh)
    REFERENCES TinhThanh (MaTinhThanh);
GO

ALTER TABLE Thong_Tin_Lien_Lac
    ADD CONSTRAINT FK_TTL_QuanHuyen
    FOREIGN KEY (MaQuanHuyen)
    REFERENCES QuanHuyen (MaQuanHuyen);
GO
-- Bảng Thong_Tin_Khoa_Hoc
CREATE TABLE Thong_Tin_Khoa_Hoc (
    MaSV NVARCHAR(20) PRIMARY KEY,
    KhoaHoc NVARCHAR(20) NOT NULL,
    NgayNhapHoc DATE NOT NULL,
    LoaiHinhDaoTao NVARCHAR(20) NOT NULL,
    ChuongTrinhDaoTao NVARCHAR(20) NOT NULL,
    Khoa NVARCHAR(10) NOT NULL,
    Nganh NVARCHAR(20) NOT NULL,
    NienKhoa NVARCHAR(20) NOT NULL,
    FOREIGN KEY (MaSV) REFERENCES Thong_Tin_Sinh_Vien(MaSV)
);
GO

ALTER TABLE Thong_Tin_Khoa_Hoc
ADD CONSTRAINT FK_ThongTinKhoaHoc_Khoa
FOREIGN KEY (Khoa) REFERENCES dbo.Khoa(MaKhoa);
GO

-- Bảng Thong_Tin_Nguoi_LH
CREATE TABLE Thong_Tin_Nguoi_LH (
    Id INT PRIMARY KEY IDENTITY(1,1),
    MaSV NVARCHAR(20) NOT NULL,
    HoTenLienHe NVARCHAR(30) NULL,
    DiaChiLienHe NVARCHAR(30) NULL,
    DienThoaiLienHe NVARCHAR(10) NULL,
    HoTenCha NVARCHAR(30) NULL,
    DienThoaiCha NVARCHAR(30) NULL,
    HoTenMe NVARCHAR(30) NULL,
    DienThoaiMe NVARCHAR(30) NULL,
    FOREIGN KEY (MaSV) REFERENCES Thong_Tin_Sinh_Vien(MaSV)
);
GO


-- Bảng Giảng Viên
CREATE TABLE dbo.GiangVien
(
    MaGV		  NVARCHAR(20) PRIMARY KEY,  
    HoTen         NVARCHAR(50) NULL,
    GioiTinh      NVARCHAR(10) NULL,
    NgaySinh      DATE NOT NULL,
	MaKhoa		  NVARCHAR(10) NOT NULL,
    DienThoai     NVARCHAR(20)  NULL,
    Email         NVARCHAR(150) NULL,
	SoDienThoai	  NVARCHAR(10) NULL,
    CCCD		  NVARCHAR(20) NULL,
    DanToc		  NVARCHAR(20) NULL,
    NoiSinh		  NVARCHAR(50) NULL,
	FOREIGN KEY (MaKhoa) REFERENCES dbo.Khoa(MaKhoa),
	CONSTRAINT FK_GiangVien_TaiKhoan FOREIGN KEY (MaGV) REFERENCES dbo.TaiKhoan(MaNguoiDung)
);
GO


-- Bảng Phòng học
CREATE TABLE dbo.PhongHoc
(
    MaPhong            NVARCHAR(10)  NOT NULL,
    LoaiPhong          NVARCHAR(50)  NOT NULL,
    SucChua            INT           NOT NULL,
    GiangVienPhuTrach  NVARCHAR(20)  NOT NULL,
    TietBatDau         INT           NOT NULL, 
    TietKetThuc        INT           NOT NULL,
    CONSTRAINT PK_PhongHoc PRIMARY KEY (MaPhong, TietBatDau, TietKetThuc),
    CONSTRAINT FK_PhongHoc_GiangVien FOREIGN KEY (GiangVienPhuTrach)
        REFERENCES dbo.GiangVien(MaGV)
        ON UPDATE CASCADE
        ON DELETE NO ACTION
);
GO

-- Thông tin liên lạc giảng viên
CREATE TABLE Thong_Tin_Lien_Lac_GV (
    MaGV	NVARCHAR(20) PRIMARY KEY,
    QuocGia NVARCHAR(20) NULL,
    TinhThanh NVARCHAR(20) NULL,
    QuanHuyen NVARCHAR(20) NULL,
    Phuong NVARCHAR(20) NULL,
    DiaChi NVARCHAR(100) NULL,
    DiDong NVARCHAR(20) NULL,
    Email NVARCHAR(20) NULL,
    FOREIGN KEY (MaGV) REFERENCES GiangVien(MaGV)
);
GO

-- Bảng Thong_Tin_Nguoi_LH_GV
CREATE TABLE Thong_Tin_Nguoi_LH_GV (
    MaGV NVARCHAR(20) PRIMARY KEY,
    HoTenLienHe NVARCHAR(10) NULL,
    DiaChiLienHe NVARCHAR(10) NULL,
    DienThoaiLienHe NVARCHAR(10) NULL,
    FOREIGN KEY (MaGV) REFERENCES GiangVien(MaGV)
);
GO

-- Thiết lập mối quan hệ giữa bảng Sinh Viên và bảng Lớp
ALTER TABLE dbo.Thong_Tin_Sinh_Vien
ADD CONSTRAINT FK_Thong_Tin_Sinh_Vien_Lop
FOREIGN KEY (LopSV)
REFERENCES dbo.Lop(MaLop)
ON DELETE NO ACTION
ON UPDATE CASCADE;
GO

-- Bảng điểm
CREATE TABLE dbo.Diem
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MaSV NVARCHAR(20) NOT NULL,
    MaMonHoc NVARCHAR(10) NOT NULL,
    PhanTramTrenLop INT DEFAULT 0,
    PhanTramThi INT DEFAULT 0,
    DiemTrenLop FLOAT DEFAULT 0,
    DiemThi FLOAT DEFAULT 0,
    DiemTB AS ((PhanTramTrenLop * DiemTrenLop + PhanTramThi * DiemThi) / (PhanTramTrenLop + PhanTramThi)),
    Loai AS (
         CASE 
             WHEN ((PhanTramTrenLop * DiemTrenLop + PhanTramThi * DiemThi) / (PhanTramTrenLop + PhanTramThi)) >= 8.5 THEN N'A'
			 WHEN ((PhanTramTrenLop * DiemTrenLop + PhanTramThi * DiemThi) / (PhanTramTrenLop + PhanTramThi)) >= 8.0 THEN N'B+'
             WHEN ((PhanTramTrenLop * DiemTrenLop + PhanTramThi * DiemThi) / (PhanTramTrenLop + PhanTramThi)) >= 7.0 THEN N'B'
			 WHEN ((PhanTramTrenLop * DiemTrenLop + PhanTramThi * DiemThi) / (PhanTramTrenLop + PhanTramThi)) >= 6.5 THEN N'C+'
             WHEN ((PhanTramTrenLop * DiemTrenLop + PhanTramThi * DiemThi) / (PhanTramTrenLop + PhanTramThi)) >= 5.5 THEN N'C'
             WHEN ((PhanTramTrenLop * DiemTrenLop + PhanTramThi * DiemThi) / (PhanTramTrenLop + PhanTramThi)) >= 4.0 THEN N'Trung Bình'
             ELSE N'F'
         END
    ),
    FOREIGN KEY (MaSV) REFERENCES dbo.Thong_Tin_Sinh_Vien(MaSV),
    FOREIGN KEY (MaMonHoc) REFERENCES dbo.MonHoc(MaMonHoc)
);
GO

-- Bảng HocPhan
CREATE TABLE dbo.HocPhan
(
    MaHocPhan     NVARCHAR(15)   NOT NULL PRIMARY KEY,
    MaMonHoc      NVARCHAR(10)   NOT NULL,
    MaGV          NVARCHAR(20)   NOT NULL,
    MaPhong       NVARCHAR(10)   NOT NULL,
    SiSoToiDa     INT            NOT NULL,
    TietBatDau    INT            NOT NULL,
    TietKetThuc   INT            NOT NULL,
    CONSTRAINT FK_HocPhan_MonHoc   FOREIGN KEY (MaMonHoc) REFERENCES dbo.MonHoc(MaMonHoc),
    CONSTRAINT FK_HocPhan_GiangVien FOREIGN KEY (MaGV)     REFERENCES dbo.GiangVien(MaGV),
    CONSTRAINT FK_HocPhan_PhongHoc  FOREIGN KEY (MaPhong, TietBatDau, TietKetThuc)
        REFERENCES dbo.PhongHoc(MaPhong, TietBatDau, TietKetThuc)
        ON UPDATE CASCADE
        ON DELETE NO ACTION
);
GO
-- Đăng ký học
CREATE TABLE dbo.DangKyHoc
(
    MaSV         NVARCHAR(20)   NOT NULL,
    MaHocPhan    NVARCHAR(15)   NOT NULL,
    NgayDK       DATETIME       NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_DangKyHoc PRIMARY KEY (MaSV, MaHocPhan),
    CONSTRAINT FK_DangKyHoc_SV       FOREIGN KEY (MaSV)      REFERENCES dbo.Thong_Tin_Sinh_Vien(MaSV),
    CONSTRAINT FK_DangKyHoc_HocPhan  FOREIGN KEY (MaHocPhan) REFERENCES dbo.HocPhan(MaHocPhan)
        ON UPDATE CASCADE
        ON DELETE CASCADE
);
GO

-- Thêm tài khoản admin
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiNguoiDung, MaNguoiDung)
VALUES ('admin', 'admin', 'Admin', 'admin');
go

-- Tạo Trigger cho sinh viên
CREATE TRIGGER trg_InsertTaiKhoanSinhVien
ON Thong_Tin_Sinh_Vien
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiNguoiDung, MaNguoiDung)
    SELECT i.MaSV + '@hcmute.sv', i.MaSV, 'SinhVien', i.MaSV
    FROM inserted i
    WHERE NOT EXISTS (SELECT 1 FROM TaiKhoan t WHERE t.MaNguoiDung = i.MaSV);
    INSERT INTO Thong_Tin_Sinh_Vien (MaSV, HoTen, NgaySinh, NoiSinh, GioiTinh, CCCD, DanToc, LopSV, Photo)
    SELECT i.MaSV, i.HoTen, i.NgaySinh, i.NoiSinh, i.GioiTinh, i.CCCD, i.DanToc, i.LopSV, i.Photo
    FROM inserted i;
END;
GO

-- Tạo Trigger cho giảng viên
CREATE TRIGGER trg_InsertTaiKhoanGiangVien
ON GiangVien
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiNguoiDung, MaNguoiDung)
    SELECT i.MaGV + '@hcmute.gv', i.MaGV, 'GiangVien', i.MaGV
    FROM inserted i
    WHERE NOT EXISTS (SELECT 1 FROM TaiKhoan t WHERE t.MaNguoiDung = i.MaGV);
    INSERT INTO GiangVien (MaGV, HoTen, GioiTinh, NgaySinh, MaKhoa, DienThoai, Email, SoDienThoai, CCCD, DanToc, NoiSinh)
    SELECT i.MaGV, i.HoTen, i.GioiTinh, i.NgaySinh, i.MaKhoa, i.DienThoai, i.Email, i.SoDienThoai, i.CCCD, i.DanToc, i.NoiSinh
    FROM inserted i;
END;
GO

