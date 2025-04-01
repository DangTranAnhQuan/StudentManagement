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
    TinhThanh NVARCHAR(20) NULL,
    QuanHuyen NVARCHAR(20) NULL,
    Phuong NVARCHAR(20) NULL,
    DiaChi NVARCHAR(50) NULL,
    DiDong NVARCHAR(20) NULL,
    Email NVARCHAR(20) NULL,
    FOREIGN KEY (MaSV) REFERENCES Thong_Tin_Sinh_Vien(MaSV)
);
GO

-- Bảng Thong_Tin_Khoa_Hoc
CREATE TABLE Thong_Tin_Khoa_Hoc (
    MaSV NVARCHAR(20) PRIMARY KEY,
    KhoaHoc NVARCHAR(10) NOT NULL,
    NgayNhapHoc DATE NOT NULL,
    LoaiHinhDaoTao NVARCHAR(20) NOT NULL,
    ChuongTrinhDaoTao NVARCHAR(20) NOT NULL,
    Khoa NVARCHAR(10) NOT NULL,
    Nganh NVARCHAR(10) NOT NULL,
    NienKhoa NVARCHAR(10) NOT NULL,
    FOREIGN KEY (MaSV) REFERENCES Thong_Tin_Sinh_Vien(MaSV)
);
GO

-- Bảng Thong_Tin_Nguoi_LH
CREATE TABLE Thong_Tin_Nguoi_LH (
    Id INT PRIMARY KEY IDENTITY(1,1),
    MaSV NVARCHAR(20) NOT NULL,
    HoTenLienHe NVARCHAR(10) NULL,
    DiaChiLienHe NVARCHAR(10) NULL,
    DienThoaiLienHe NVARCHAR(10) NULL,
    HoTenCha NVARCHAR(10) NULL,
    DienThoaiCha NVARCHAR(20) NULL,
    HoTenMe NVARCHAR(10) NULL,
    DienThoaiMe NVARCHAR(20) NULL,
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
    MaPhong NVARCHAR(10) NOT NULL,
	SucChua INT NOT NULL,
	LoaiPhong NVARCHAR(50) NOT NULL,
    GiangVienPhuTrach NVARCHAR(20) NOT NULL,
	TietBatDau INT NOT NULL, 
    TietKetThuc INT NOT NULL

	PRIMARY KEY (MaPhong, TietBatDau, TietKetThuc)
	FOREIGN KEY (GiangVienPhuTrach) REFERENCES GiangVien(MaGV)
);
GO

-- Thông tin liên lạc giảng viên
CREATE TABLE Thong_Tin_Lien_Lac_GV (
    MaGV	NVARCHAR(20) PRIMARY KEY,
    QuocGia NVARCHAR(20) NULL,
    TinhThanh NVARCHAR(20) NULL,
    QuanHuyen NVARCHAR(20) NULL,
    Phuong NVARCHAR(20) NULL,
    DiaChi NVARCHAR(50) NULL,
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

-- Bảng Môn Học
CREATE TABLE dbo.MonHoc
(
    MaMonHoc   NVARCHAR(10) NOT NULL PRIMARY KEY,
    TenMonHoc  NVARCHAR(50) NOT NULL,
    SoTinChi   INT		 NOT NULL,
	MaKhoa NVARCHAR(10)     NOT NULL,
	SoTiet INT NOT NULL,
    LoaiMon NVARCHAR(50) NOT NULL
	CONSTRAINT FK_MonHoc_MaKhoa FOREIGN KEY (MaKhoa) REFERENCES dbo.Khoa(MaKhoa)
);
GO

-- Bảng Điểm
create table dbo.Diem
(
    Id int identity(1,1) primary key,
    MaSV NVARCHAR(20) not null,
    MaMonHoc NVARCHAR(10) not null,
    PhanTramTrenLop int default 0,
    PhanTramThi int default 0,
    DiemTrenLop float default 0,
    DiemThi float default 0,
    DiemTB float default 0,
    Loai char(1) default 'F',
    foreign key (MaSV) references Thong_Tin_Sinh_Vien(MaSV),
    foreign key (MaMonHoc) references MonHoc(MaMonHoc)
)
go

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



INSERT INTO dbo.Khoa (MaKhoa, TenKhoa)
VALUES 
    ('231101', N'Công nghệ thông tin'),   
    ('231141', N'Cơ khí Chế Tạo Máy'),      
    ('231422', N'Điện - Điện tử'),         
    ('231300', N'Khoa học ứng dụng'),       
    ('231261', N'Thương mại điện tử')      
go

INSERT INTO dbo.Lop (MaLop, TenLop, MaKhoa)
VALUES 
    ('231101A', N'IT1', '231101'),
    ('231101B', N'IT2', '231101'),
    ('231101C', N'IT3', '231101'),
    ('231141A', N'Cơ khí 2', '231141'),
    ('231141B', N'Cơ khí 2', '231141'),
    ('231141C', N'Cơ khí 3', '231141'),
    ('231422A', N'Điện 1', '231422'),
    ('231422B', N'Điện 2', '231422'),
    ('231422C', N'Điện 3', '231422'),
    ('231300A', N'Khoa học 1', '231300'),
    ('231300B', N'Khoa học 2', '231300'),
    ('231300C', N'Khoa học 3', '231300'),
    ('231261A', N'Thương mại 1', '231261'),
    ('231261B', N'Thương mại 2', '231261'),
    ('231261C', N'Thương mại 3', '231261')
go

INSERT INTO GiangVien (MaGV, HoTen, GioiTinh,MaKhoa ,NgaySinh, DienThoai, Email, SoDienThoai, CCCD, DanToc, NoiSinh)
VALUES 
('GV001', N'Trần Văn Hùng', N'Nam', '231101', '1985-03-15', '0987654321', 'vanhung@gmail.com', '0911111111', '123456789000', N'Kinh', N'Hà Nội'),
('GV002', N'Lê Thị Hoa', N'Nữ', '231300', '1990-07-20', '0912345678', 'thihoa90@gmail.com', '0922222222', '223456789001', N'Kinh', N'Hải Phòng'),
('GV003', N'Phạm Minh Đức', N'Nam', '231261', '1982-11-10', '0933456789', 'minhduc82@gmail.com', '0933333333', '323456789002', N'Tày', N'Lạng Sơn'),
('GV004', N'Hoàng Thị Lan', N'Nữ', '231422', '1988-05-25', '0978567890', 'thilan88@gmail.com', '0944444444', '423456789003', N'Kinh', N'Đà Nẵng'),
('GV005', N'Vũ Quang Trung', N'Nam', '231300', '1979-09-30', '0945678901', 'quangtrung@gmail.com', '0955555555', '523456789004', N'Kinh', N'Quảng Nam'),
('GV006', N'Đỗ Thị Hương', N'Nữ', '231422', '1992-12-12', '0967891234', 'thihuong92@gmail.com', '0966666666', '623456789005', N'Tày', N'Cao Bằng'),
('GV007', N'Bùi Văn Tâm', N'Nam', '231141', '1983-04-18', '0923456789', 'vantam83@gmail.com', '0977777777', '723456789006', N'Kinh', N'Hồ Chí Minh'),
('GV008', N'Ngô Thị Yến', N'Nữ', '231261', '1986-08-08', '0956789012', 'thiyen86@gmail.com', '0988888888', '823456789007', N'Kinh', N'Bình Dương'),
('GV009', N'Đặng Minh Phong', N'Nam', '231422', '1991-02-14', '0901234567', 'minhphong91@gmail.com', '0999999999', '923456789008', N'Kinh', N'Đồng Nai'),
('GV010', N'Mai Thị Thảo', N'Nữ', '231101', '1989-06-22', '0998765432', 'thithao89@gmail.com', '0900000000', '103456789009', N'Thái', N'Sơn La');
go

INSERT INTO dbo.PhongHoc (MaPhong, SucChua, LoaiPhong, GiangVienPhuTrach, TietBatDau, TietKetThuc) 
VALUES
(N'A101', 50, N'Phòng lý thuyết', N'GV005', 1, 3),  
(N'A102', 40, N'Phòng thực hành', N'GV002', 4, 6), 
(N'A103', 60, N'Phòng thực hành', N'GV008', 7, 9),
(N'B201', 45, N'Phòng lý thuyết', N'GV001', 2, 4), 
(N'B202', 30, N'Phòng thực hành', N'GV007', 5, 7), 
(N'B203', 55, N'Phòng lý thuyết', N'GV003', 1, 2), 
(N'C301', 35, N'Phòng thực hành', N'GV009', 6, 8), 
(N'C302', 50, N'Phòng lý thuyết', N'GV004', 3, 5),
(N'C303', 25, N'Phòng thực hành', N'GV006', 8, 10), 
(N'D101', 60, N'Phòng lý thuyết', N'GV009', 1, 3), 
(N'D102', 40, N'Phòng thực hành', N'GV001', 4, 6),
(N'D103', 45, N'Phòng lý thuyết', N'GV007', 7, 9),
(N'E201', 50, N'Phòng thực hành', N'GV002', 2, 4),
(N'E202', 30, N'Phòng lý thuyết', N'GV009', 5, 7),
(N'E203', 35, N'Phòng thực hành', N'GV004', 1, 2),
(N'F301', 60, N'Phòng lý thuyết', N'GV008', 6, 8),
(N'F302', 55, N'Phòng thực hành', N'GV005', 3, 5),
(N'F303', 40, N'Phòng lý thuyết', N'GV006', 8, 10),
(N'G401', 45, N'Phòng thực hành', N'GV003', 1, 3),
(N'G402', 50, N'Phòng lý thuyết', N'GV010', 4, 6);
GO


INSERT INTO dbo.MonHoc (MaMonHoc, TenMonHoc, SoTinChi, MaKhoa, SoTiet, LoaiMon)
VALUES 
    ('MH011', N'Lập trình Java', 3, '231101', 45, N'Chuyên ngành'),
    ('MH012', N'Cơ sở dữ liệu', 4, '231101', 60, N'Chuyên ngành'),
    ('MH013', N'Mạng máy tính', 3, '231101', 45, N'Chuyên ngành'),
    ('MH014', N'Trí tuệ nhân tạo', 4, '231101', 60, N'Tự chọn'),
    ('MH015', N'Phân tích thiết kế hệ thống', 3, '231101', 45, N'Chuyên ngành'),
	('MH016', N'Cơ học ứng dụng', 3, '231141', 45, N'Cơ sở ngành'),
    ('MH017', N'Thiết kế máy', 4, '231141', 60, N'Chuyên ngành'),
    ('MH018', N'Vật liệu cơ khí', 3, '231141', 45, N'Cơ sở ngành'),
    ('MH019', N'Công nghệ chế tạo', 4, '231141', 60, N'Chuyên ngành'),
    ('MH020', N'Điều khiển tự động', 3, '231141', 45, N'Tự chọn'),
	('MH021', N'Điện tử công suất', 3, '231422', 45, N'Chuyên ngành'),
    ('MH022', N'Vi điều khiển', 4, '231422', 60, N'Chuyên ngành'),
    ('MH023', N'Kỹ thuật số', 3, '231422', 45, N'Cơ sở ngành'),
    ('MH024', N'Truyền động điện', 4, '231422', 60, N'Chuyên ngành'),
    ('MH025', N'Điện tử tương tự', 3, '231422', 45, N'Cơ sở ngành'),
	('MH026', N'Toán ứng dụng', 3, '231300', 45, N'Đại cương'),
    ('MH027', N'Vật lý ứng dụng', 4, '231300', 60, N'Đại cương'),
    ('MH028', N'Hóa học ứng dụng', 3, '231300', 45, N'Đại cương'),
    ('MH029', N'Sinh học ứng dụng', 4, '231300', 60, N'Đại cương'),
    ('MH030', N'Khoa học môi trường', 3, '231300', 45, N'Tự chọn'),
	('MH031', N'Marketing điện tử', 3, '231261', 45, N'Chuyên ngành'),
    ('MH032', N'Thương mại quốc tế', 4, '231261', 60, N'Chuyên ngành'),
    ('MH033', N'Quản lý chuỗi cung ứng', 3, '231261', 45, N'Chuyên ngành'),
    ('MH034', N'Tài chính điện tử', 4, '231261', 60, N'Tự chọn'),
    ('MH035', N'Luật thương mại điện tử', 3, '231261', 45, N'Chuyên ngành')
go

INSERT INTO Thong_Tin_Sinh_Vien (MaSV, HoTen, NgaySinh, GioiTinh, CCCD, DanToc, LopSV, NoiSinh)
VALUES 
('23110101', N'Nguyễn Văn An', '2003-05-12', N'Nam', '012345678901', N'Kinh', '231101A', N'Hà Nội'),
('23110102', N'Trần Thị Bình', '2002-08-20', N'Nữ', '023456789012', N'Kinh', '231101B', N'Hồ Chí Minh'),
('23110103', N'Lê Minh Châu', '2004-01-15', N'Nữ', '034567890123', N'Tày', '231101C', N'Lạng Sơn'),
('23114101', N'Phạm Quốc Dũng', '2003-11-30', N'Nam', '045678901234', N'Kinh', '231141A', N'Đà Nẵng'),
('23114102', N'Hoàng Thị Ngọc', '2001-07-25', N'Nữ', '056789012345', N'Kinh', '231141B', N'Quảng Nam'),
('23114103', N'Vũ Văn Hùng', '2004-03-10', N'Nam', '067890123456', N'Thái', '231141C', N'Điện Biên'),
('23126101', N'Đỗ Thị Lan', '2002-09-05', N'Nữ', '078901234567', N'Kinh', '231261A', N'Hải Phòng'),
('23126102', N'Bùi Minh Khang', '2003-02-18', N'Nam', '089012345678', N'Kinh', '231261B', N'Bắc Giang'),
('23126103', N'Ngô Thị Mai', '2004-06-22', N'Nữ', '090123456789', N'Tày', '231261C', N'Cao Bằng'),
('23130001', N'Đặng Văn Nam', '2001-12-01', N'Nam', '101234567890', N'Kinh', '231300A', N'Nghệ An'),
('23130002', N'Mai Thị Hồng', '2003-04-15', N'Nữ', '112345678901', N'Kinh', '231300B', N'Thanh Hóa'),
('23130003', N'Trần Quốc Phong', '2002-10-10', N'Nam', '123456789012', N'Thái', '231300C', N'Sơn La'),
('23142201', N'Lê Thị Thanh', '2004-07-07', N'Nữ', '134567890123', N'Kinh', '231422A', N'Bình Dương'),
('23142202', N'Phạm Văn Tùng', '2003-03-25', N'Nam', '145678901234', N'Kinh', '231422B', N'Đồng Nai'),
('23142203', N'Hoàng Thị Yến', '2002-11-11', N'Nữ', '156789012345', N'Tày', '231422C', N'Bắc Kạn')
go
