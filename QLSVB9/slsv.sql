use master
CREATE DATABASE QuanLySinhVien
use QuanLySinhVien
/*Table SinhVien*/
CREATE TABLE SinhVien
(
	[MaSV] NCHAR(10) NOT NULL PRIMARY KEY, 
    [HoTen] NVARCHAR(200) NOT NULL, 
	[DiemTB] FLOAT NOT NULL,
    [MaKhoa] INTEGER NOT NULL
)
Go
/*Table Khoa*/
CREATE TABLE Khoa
(
	[MaKhoa] INTEGER NOT NULL PRIMARY KEY, 
    [TenKhoa] NVARCHAR(200) NOT NULL,
	[GhiChu] NVARCHAR(200) NULL
)
Go
/*Table ThanhVien*/
CREATE TABLE ThanhVien
(
	[TenDangNhap] NCHAR(100) NOT NULL PRIMARY KEY, 
    [MatKhau] NVARCHAR(100) NOT NULL
)
Go
/*--------------*/
ALTER TABLE SinhVien ADD CONSTRAINT FK_SinhVien_Khoa FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa) 
/*alter table Khoa add primary key (MaKhoa);
//alter table SinhVien add primary key (MaSV);
*/
INSERT INTO Khoa VALUES(1,N'Công nghệ thông tin',null)
INSERT INTO Khoa VALUES(2,N'Kế toán tài chính',null)
INSERT INTO Khoa VALUES(3,N'Quản trị kinh doanh',null)
INSERT INTO KHOA VALUES(4,N'Kế Toán',null)
INSERT INTO Khoa VALUES(5,N'Quản trị khách sạn',null)
INSERT INTO Khoa VALUES(6,N'Quan hệ quốc tế',null)
GO
/*Thêm dữ liệu mẫu*/
INSERT INTO SinhVien VALUES('2119110001',N'Nguyễn Văn Anh',9.8,1)
INSERT INTO SinhVien VALUES('2119110002',N'Trần Hoàng Nam',8.2,1)
INSERT INTO SinhVien VALUES('2119110003',N'Nguyễn Thị Thùy Trang',8.4,1)
INSERT INTO SinhVien VALUES('2119110004',N'Dương Anh Tú',7.6,1)
INSERT INTO SinhVien VALUES('2119110005',N'Nguyễn Lan Anh',8.9,1)
INSERT INTO SinhVien VALUES('2119110006',N'Trần Thị Chính',9.0,2)
INSERT INTO SinhVien VALUES('2119110007',N'Nguyễn Văn An',7.4,1)
INSERT INTO SinhVien VALUES('2119110008',N'Nguyễn Thanh Tâm',3.9,3)
INSERT INTO SinhVien VALUES('2119110009',N'Lê Bích Trâm',4.9,3)
Insert into SinhVien VALUES('2119110010',N'Nguyễn Ngọc Phong',5.0,1)
Insert into SinhVien VALUES('2119110011',N'Lê Nam Trung',6.2,1)
Insert into SinhVien VALUES('2119110012',N'Trần Thanh Thiên',5.1,2)
Insert into SinhVien VALUES('2119110013',N'Vũ Thị Huế',9.2,5)
Insert into SinhVien VALUES('2119110014',N'Hoàng Ngọc Bích',8.6,4)
insert into SinhVien VALUES('2119110015',N'Nguyễn Văn Anh', 7.8, 1);
insert into SinhVien VALUES('2119110016',N'Nguyễn Thái Sơn', 6.8, 1);
Go
select * from SinhVien
