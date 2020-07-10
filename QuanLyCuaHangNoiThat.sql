create table TheLoai(
MaLoai nvarchar(30) primary key not null,
TenLoai nvarchar(50) not null);

create table KieuDang(
MaKieu nvarchar(30) primary key not null,
TenKieu nvarchar(50) not null);

create table MauSac(
MaMau nvarchar(30) primary key not null,
TenMau nvarchar(50) not null);

create table ChatLieu(
MaChatLieu nvarchar(30) primary key not null,
TenChatLieu nvarchar(50) not null);

create table NuocSanXuat(
MaNuocSX nvarchar(30) primary key not null,
TenNuocSX nvarchar(50) not null);

create table CaLam(
MaCa nvarchar(30) primary key not null,
TenCa nvarchar(50) not null);

create table DMNoiThat(
MaNoiThat nvarchar(30) primary key not null,
TenNoiThat nvarchar(50) not null,
MaLoai nvarchar(30) not null,
MaKieu nvarchar(30) not null,
MaMau nvarchar(30) not null,
MaChatLieu nvarchar(30) not null,
MaNuocSX nvarchar(30) not null,
SoLuong int not null,
DonGiaNhap float not null,
DonGiaBan float not null,
Anh nvarchar(200),
ThoiGianBaohanh float not null,
Constraint fkNT_L foreign key(MaLoai) references TheLoai(MaLoai),
Constraint fkNT_K foreign key(MaKieu) references KieuDang(MaKieu),
Constraint fkNT_M foreign key(MaMau) references MauSac(MaMau),
Constraint fkNT_CL foreign key(MaChatLieu) references ChatLieu(MaChatLieu),
Constraint fkNT_NuocSX foreign key(MaNuocSX) references NuocSanXuat(MaNuocSX)
);

create table CongViec(
MaCV nvarchar(30) primary key not null,
TenCV nvarchar(50) not null);

create table NhanVien(
MaNV nvarchar(30) primary key not null,
TenNV nvarchar(50) not null,
GioiTinh nvarchar(10) not null,
NgaySinh datetime not null,
DienThoai nvarchar(15) not null,
DiaChi nvarchar(50) not null,
MaCa nvarchar(30) not null,
MaCV nvarchar(30) not null,
Constraint fkNV_CaLam foreign key(MaCa) references CaLam(MaCa),
Constraint fkNV_CV foreign key(MaCV) references CongViec(MaCV));

create table NhaCungCap(
MaNCC nvarchar(30) primary key not null,
TenNCC nvarchar(50) not null,
DiaChi nvarchar(50) not null,
DienThoai nvarchar(15) not null);

create table KhachHang(
MaKhach nvarchar(30) primary key not null,
TenKhach nvarchar(50) not null,
DiaChi nvarchar(50),
DienThoai nvarchar(15) not null);

create table DonDatHang(
SoDDH nvarchar(30) primary key not null,
MaNV nvarchar(30) not null,
MaKhach nvarchar(30) not null,
NgayDat datetime not null,
NgayGiao datetime not null,
DatCoc float,
Thue nvarchar(30),
TongTien float not null,
Constraint fkDDH_NV foreign key(MaNV) references NhanVien(MaNV),
Constraint fkDDH_KH foreign key(MaKhach) references KhachHang(MaKhach));

create table HoaDonNhap(
SoHDN nvarchar(30) primary key not null,
MaNV nvarchar(30) not null,
NgayNhap datetime not null,
MaNCC nvarchar(30) not null,
Tongtien float not null
Constraint fkHDN_NV foreign key(MaNV) references NhanVien(MaNV),
Constraint fkHDN_NCC foreign key(MaNCC) references NhaCungCap(MaNCC));

create table ChiTietDonDatHang(
MaNoiThat nvarchar(30) not null,
SoDDH nvarchar(30) not null,
constraint CTDDH_pk primary key(Manoithat,SoDDH),
SoLuong float not null,
GiamGia float not null,
ThanhTien float not null,
Constraint fkCTDDH_NT foreign key(MaNoiThat) references DMNoiThat(MaNoiThat),
Constraint fkCTDDH_DDH foreign key(SoDDH) references DonDatHang(SoDDH));

create table ChiTietHoaDonNhap(
MaNoiThat nvarchar(30)  not null,
SoHDN nvarchar(30) not null,
constraint CTHDN_pk primary key(Manoithat,SoHDN),
DonGia float not null,
SoLuong int not null,
GiamGia nvarchar(30) not null,
ThanhTien float not null
Constraint fkCTHDN_NT foreign key(MaNoiThat) references DMNoiThat(MaNoiThat),
Constraint fkCTHDN_HDN foreign key(SoHDN) references HoaDonNhap(SoHDN));

insert into TheLoai(MaLoai,TenLoai)
values (N'001', N'Gỗ Mun');
insert into TheLoai(MaLoai,TenLoai)
values (N'002', N'Gỗ Trắc');
insert into TheLoai(MaLoai,TenLoai)
values (N'003', N'Gỗ Xoan Đào');
insert into TheLoai(MaLoai,TenLoai)
values (N'004', N'Gỗ Hương');
insert into TheLoai(MaLoai,TenLoai)
values (N'005', N'Gỗ Sưa');

insert into KieuDang(MaKieu,TenKieu)
values (N'1001', N'Chữ U');
insert into KieuDang(MaKieu,TenKieu)
values (N'1002', N'Hình Chữ Nhật');
insert into KieuDang(MaKieu,TenKieu)
values (N'1003', N'Chữ L');
insert into KieuDang(MaKieu,TenKieu)
values (N'1004', N'Hình Tròn');
insert into KieuDang(MaKieu,TenKieu)
values (N'1005', N'Hình Vuông');

insert into MauSac(MaMau,TenMau)
values (N'2001', N'Nâu Đậm');
insert into MauSac(MaMau,TenMau)
values (N'2002', N'Nâu Nhạt');
insert into MauSac(MaMau,TenMau)
values (N'2003', N'Đỏ');
insert into MauSac(MaMau,TenMau)
values (N'2004', N'Trắng');
insert into MauSac(MaMau,TenMau)
values (N'2005', N'Vàng Nhạt');

insert into ChatLieu(MaChatLieu,TenChatLieu)
values (N'30001', N'Gỗ MDF');
insert into ChatLieu(MaChatLieu,TenChatLieu)
values (N'30002', N'Gỗ Veneer');
insert into ChatLieu(MaChatLieu,TenChatLieu)
values (N'30003', N'Gỗ Ghép');
insert into ChatLieu(MaChatLieu,TenChatLieu)
values (N'30004', N'Gỗ HDF');
insert into ChatLieu(MaChatLieu,TenChatLieu)
values (N'30005', N'Gỗ Tự Nhiên');

insert into NuocSanXuat(MaNuocSX,TenNuocSX)
values (N'40001', N'Việt Nam');
insert into NuocSanXuat(MaNuocSX,TenNuocSX)
values (N'40002', N'Ý');
insert into NuocSanXuat(MaNuocSX,TenNuocSX)
values (N'40003', N'Trung Quốc');
insert into NuocSanXuat(MaNuocSX,TenNuocSX)
values (N'40004', N'Ấn Độ');
insert into NuocSanXuat(MaNuocSX,TenNuocSX)
values (N'40005', N'Đức');

insert into CaLam(MaCa,TenCa)
values (N'500001', N'Ca Sáng');
insert into CaLam(MaCa,TenCa)
values (N'500002', N'Ca Tối');
insert into CaLam(MaCa,TenCa)
values (N'500003', N'Ca Chiều');
insert into CaLam(MaCa,TenCa)
values (N'500004', N'Ca Sáng');
insert into CaLam(MaCa,TenCa)
values (N'500005', N'Ca Tối');

insert into CongViec(MaCV,TenCV)
values ('CV01',N'Giám Đốc');
insert into CongViec(MaCV,TenCV)
values ('CV02',N'Nhân Viên');
insert into CongViec(MaCV,TenCV)
values ('CV03',N'Quản Lý');
insert into CongViec(MaCV,TenCV)
values ('CV04',N'Người Vận Chuyển');
insert into CongViec(MaCV,TenCV)
values ('CV05',N'Thu Ngân');

insert into NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai)
values ('NCC001',N'Hương Giang',N'Đà Nẵng','0705000011');
insert into NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai)
values ('NCC002',N'Thu Hà',N'Hà Nội','0705000012');
insert into NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai)
values ('NCC003',N'Mầu Hoa',N'Hà Giang','07050000113');
insert into NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai)
values ('NCC004',N'Đình Tuấn',N'Hà Nội','0705000014');
insert into NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai)
values ('NCC005',N'Ngọc Trinh',N'Huế','0705000015');

insert into KhachHang(MaKhach,TenKhach,DiaChi,DienThoai)
values ('KH01',N'Nguyễn Quỳnh',N'Hà Nội','0908555511');
insert into KhachHang(MaKhach,TenKhach,DiaChi,DienThoai)
values ('KH02',N'Nguyễn Nga',N'Bắc Giang','0908555512');
insert into KhachHang(MaKhach,TenKhach,DiaChi,DienThoai)
values ('KH03',N'Nguyễn An',N'Đà Lạt','0908555513');
insert into KhachHang(MaKhach,TenKhach,DiaChi,DienThoai)
values ('KH04',N'Nguyễn Linh',N'Hà Nội','0908555514');
insert into KhachHang(MaKhach,TenKhach,DiaChi,DienThoai)
values ('KH05',N'Nguyễn Minh',N'Sài Gòn','0908555515');

insert into DMNoiThat(MaNoiThat,TenNoiThat,MaLoai,MaKieu,MaMau,MaChatLieu,MaNuocSX,SoLuong,DonGiaNhap,DonGiaBan,Anh,ThoiGianBaohanh)
values ('NT1',N'Giường tầng',N'001',N'1001',N'2001',N'30001',N'40001',1000,5000000,7000000,'',3);
insert into DMNoiThat(MaNoiThat,TenNoiThat,MaLoai,MaKieu,MaMau,MaChatLieu,MaNuocSX,SoLuong,DonGiaNhap,DonGiaBan,Anh,ThoiGianBaohanh)
values ('NT2',N'SoFa',N'002',N'1002',N'2002',N'30002',N'40002',500,250000,400000,'',2);
insert into DMNoiThat(MaNoiThat,TenNoiThat,MaLoai,MaKieu,MaMau,MaChatLieu,MaNuocSX,SoLuong,DonGiaNhap,DonGiaBan,Anh,ThoiGianBaohanh)
values ('NT3',N'Bàn ăn',N'003',N'1003',N'2003',N'30003',N'40003',300,300000,400000,'',4);
insert into DMNoiThat(MaNoiThat,TenNoiThat,MaLoai,MaKieu,MaMau,MaChatLieu,MaNuocSX,SoLuong,DonGiaNhap,DonGiaBan,Anh,ThoiGianBaohanh)
values ('NT4',N'Ghế dựa',N'004',N'1004',N'2004',N'30004',N'40004',10000,500000,600000,'',1);
insert into DMNoiThat(MaNoiThat,TenNoiThat,MaLoai,MaKieu,MaMau,MaChatLieu,MaNuocSX,SoLuong,DonGiaNhap,DonGiaBan,Anh,ThoiGianBaohanh)
values ('NT5',N'Tủ',N'005',N'1005',N'2005',N'30005',N'40005',1500,500000,700000,'',1);

insert into NhanVien(MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,MaCa,MaCV)
values ('NV1',N'Nguyễn An', N'Nữ','1998/01/01',0982229999,N'TP HCM',N'500001','CV01');
insert into NhanVien(MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,MaCa,MaCV)
values ('NV2',N'Nguyễn Anh', N'Nữ','2000/11/01',0982228888,N'Hà Nội',N'500005','CV05');
insert into NhanVien(MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,MaCa,MaCV)
values ('NV3',N'Nguyễn Ngân', N'Nữ','2001/08/09',0982227777,N'Hà Nam',N'500003','CV03');
insert into NhanVien(MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,MaCa,MaCV)
values ('NV4',N'Nguyễn Toàn', N'Nam','1995/01/21',0982221111,N'Hà Tĩnh',N'500004','CV04');
insert into NhanVien(MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,MaCa,MaCV)
values ('NV5',N'Nguyễn Nhi', N'Nữ','1992/07/22',0982225555,N'Nghệ An',N'500002','CV02');

insert into DonDatHang(SoDDH,MaNV,MaKhach,NgayDat,NgayGiao,DatCoc,Thue,TongTien)
values ('DDH1','NV1','KH01','2020/01/01','2020/01/10',3000000,'5%',7140000);
insert into DonDatHang(SoDDH,MaNV,MaKhach,NgayDat,NgayGiao,DatCoc,Thue,TongTien)
values ('DDH2','NV2','KH02','2020/01/11','2020/01/25',1000000,'2%',4054500);
insert into DonDatHang(SoDDH,MaNV,MaKhach,NgayDat,NgayGiao,DatCoc,Thue,TongTien)
values ('DDH3','NV3','KH03','2020/02/01','2020/03/10',500000,'3%',1957000);
insert into DonDatHang(SoDDH,MaNV,MaKhach,NgayDat,NgayGiao,DatCoc,Thue,TongTien)
values ('DDH4','NV4','KH04','2019/12/01','2020/05/22',2000000,'1%',5555000);
insert into DonDatHang(SoDDH,MaNV,MaKhach,NgayDat,NgayGiao,Thue,TongTien)
values ('DDH5','NV5','KH05','2019/11/11','2020/02/14','2%',1428000);

insert into ChiTietDonDatHang(SoDDH,MaNoiThat,SoLuong,GiamGia,ThanhTien)
values ('DDH1','NT1',1,200000,6800000);
insert into ChiTietDonDatHang(SoDDH,MaNoiThat,SoLuong,GiamGia,ThanhTien)
values ('DDH2','NT2',10,25000,3975000);
insert into ChiTietDonDatHang(SoDDH,MaNoiThat,SoLuong,GiamGia,ThanhTien)
values ('DDH3','NT3',5,100000,1900000);
insert into ChiTietDonDatHang(SoDDH,MaNoiThat,SoLuong,GiamGia,ThanhTien)
values ('DDH4','NT4',10,500000,5500000);
insert into ChiTietDonDatHang(SoDDH,MaNoiThat,SoLuong,GiamGia,ThanhTien)
values ('DDH5','NT5',2,0,1400000);

insert into HoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC,TongTien)
values ('HDN1','NV1','2020/05/05','NCC001',49500000);
insert into HoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC,TongTien)
values ('HDN2','NV2','2020/05/07','NCC002',4990000);
insert into HoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC,TongTien)
values ('HDN3','NV3','2020/05/09','NCC003',1470000);
insert into HoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC,TongTien)
values ('HDN4','NV4','2020/05/11','NCC004',2470000);
insert into HoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC,TongTien)
values ('HDN5','NV5','2020/05/13','NCC005',9800000);

insert into ChiTietHoaDonNhap(SoHDN,MaNoiThat,SoLuong,DonGia,GiamGia,ThanhTien) 
values ('HDN1','NT1',10,5000000,500000,49500000);
insert into ChiTietHoaDonNhap(SoHDN,MaNoiThat,SoLuong,DonGia,GiamGia,ThanhTien)  
values ('HDN2','NT2',20,250000,10000,4990000);
insert into ChiTietHoaDonNhap(SoHDN,MaNoiThat,SoLuong,DonGia,GiamGia,ThanhTien)  
values ('HDN3','NT3',5,300000,30000,1470000);
insert into ChiTietHoaDonNhap(SoHDN,MaNoiThat,SoLuong,DonGia,GiamGia,ThanhTien) 
values ('HDN4','NT4',10,500000,30000,2470000);
insert into ChiTietHoaDonNhap(SoHDN,MaNoiThat,SoLuong,DonGia,GiamGia,ThanhTien)  
values ('HDN5','NT5',20,500000,200000,9800000);


