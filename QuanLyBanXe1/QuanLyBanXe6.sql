
use [master]

go
create database QuanLyBanXe6
go
use QuanLyBanXe6
go
create table LOAIXE(
Maloaixe varchar(10) primary key,
Tenloaixe nvarchar(20),
Dacdiem nvarchar(100)
)
go
create table NHASANXUAT(
Mansanxuat varchar(10) primary key,
Tennsanxuat nvarchar(30),
Quocgia nvarchar(20),
Dienthoai varchar(20),
Email varchar(30)
)
go

create table NHACUNGCAP(
Mancungcap varchar(10) primary key,
Tenncungcap nvarchar(30),
Diachi nvarchar(100),
Dienthoai varchar(20),
Email varchar(30)
)
go

create table XE(
Maxe varchar(10) primary key,
Tenxe varchar(10),
Soluongton int,
Maloaixe varchar(10) references LOAIXE(Maloaixe),
Mansx varchar(10) references NHASANXUAT(Mansanxuat),
Mancc varchar(10) references NHACUNGCAP(Mancungcap),
Dongia int
)


go
create table HOADONNHAP( 
Mahdnhap varchar(10) primary key,
Mancc varchar(10) references NHACUNGCAP(Mancungcap),
Manv varchar(10),
Ngaynhap date
)
go

create table CT_HDNHAP(
Mahdnhap varchar(10) references HOADONNHAP(Mahdnhap),
Maxe varchar(10) references XE(Maxe),
Soluong bigint,
Dongia bigint,
Thanhtien bigint
)



go
create table DONGIA(
Ngayapdung datetime primary key,
Masp varchar(10) references XE(Maxe) ,
Dongianhap bigint,
Dongiaban bigint
)
go
create table KHACHHANG(
Makh varchar(10) primary key,
Tenkh nvarchar(50),
Dienthoai varchar(20),
Diachi nvarchar(100)
)
go


create table NHANVIEN(
Manv varchar(10) primary key,
Tennv nvarchar(20),
Ngaysinh date,
Diachi nvarchar(100),
Dienthoai varchar(20),
Gioitinh varchar(5),
Pass varchar(20),
Chucvu varchar(20)
)


go
create table HOADONBAN(
Mahdban varchar(10) primary key,
Makh varchar(10) references KHACHHANG(Makh),
Manv varchar(10) references NHANVIEN(Manv),
Ngayban date,
Ghichu nvarchar(100),
)
go

create table CTHDBAN(
Mahdban varchar(10) references HOADONBAN(Mahdban),
Maxe varchar(10) references XE(Maxe),
Soluong bigint,
Dongia bigint,
Tientra bigint,
Tienthua bigint,
Thanhtoan bigint
)



select * from CTHDBAN
select * from CT_HDNHAP
select * from DONGIA
select * from HOADONBAN
select * from HOADONNHAP
select * from KHACHHANG
select * from LOAIXE
select * from NHACUNGCAP
select * from NHANVIEN
select * from NHASANXUAT
select * from XE



CREATE VIEW BanHang
as
	select a.Mahdban,a.Makh,a.Manv,a.Ngayban,b.Maxe,b.Soluong,b.Dongia,b.Tientra,b.Tienthua,b.Thanhtoan,a.Ghichu
	from (HOADONBAN a inner join CTHDBAN b
	on a.Mahdban = b.Mahdban)

create view NhapHang
as
	select a.Mahdnhap,a.Mancc,a.Manv,a.Ngaynhap,b.Dongia,b.Maxe,b.Soluong,b.Thanhtien
	from (HOADONNHAP a inner join CT_HDNHAP b
	on a.Mahdnhap = b.Mahdnhap)



go
insert into NHASANXUAT values('HCA',N'Hùng Châu',N'Việt Nam','0838151408','thuhien@yahoo.com.vn')
insert into NHASANXUAT values('KKC',N'Kim Cương',N'Việt Nam','06502217838','kimcuong@yahoo.com.vn')
insert into NHASANXUAT values('PM',N'Phương Mai',N'Việt Nam','08365451408','phuongmai@yahoo.com.vn')
go
insert into NHACUNGCAP values('HDVN',N'Honda Việt Nam',N'Việt Nam','01265490853','hondavn@gmail.com.vn')
insert into NHACUNGCAP values('YMH',N'Yamaha',N'Việt Nam','01266590853','yamahavn@gmail.com.vn')
insert into NHACUNGCAP values('SZK',N'Suzuky Việt Nam',N'Việt Nam','01355490853','suzuky@gmail.com.vn')
go
insert into LOAIXE values ('XESO',N'Xe số',N'chạy phải chuyển số')
insert into LOAIXE values ('TAYGA',N'Tay ga',N'không phải chuyển số')
insert into LOAIXE values ('FI',N'Phun xăng điện tử',N'tiết kiệm xăng')
go
insert into XE values ('SR',N'Sirius','100','XESO','HCA','YMH','20000000')
insert into XE values ('YP',N'Yupiter','120','XESO','HCA','YMH','23000000')
insert into XE values ('NZ',N'Nozza','50','TAYGA','HCA','YMH','30000000')
insert into XE values ('SH',N'SH','60','TAYGA','KKC','HDVN','95000000')
insert into XE values ('VS',N'Vision','40','TAYGA','PM','HDVN','40000000')
insert into XE values ('L',N'Lead','70','TAYGA','PM','HDVN','42000000')
insert into XE values ('ad',N'asasdf','10','TAYGA','PM','HDVN','35000000')
go
insert into KHACHHANG values ('KH01',N'Nguyễn Đẹp Chai','01265490853',N'Lê Trọng Tấn,F.Sơn Kỳ,Q.Tân Phú,Tp.hcm')
insert into KHACHHANG values ('KH02',N'Nguyễn Thị Thúy','01267790853',N'CMT8,F.13,Q.Tân Bình,Tp.hcm')
insert into KHACHHANG values ('KH03',N'Lê Thị Đẹp Gái','01265497748',N'Trường Chinh,F.8,Q.Gò Vấp,Tp.hcm')
insert into KHACHHANG values ('KH04',N'Nguyễn Bé Hai','01655490853',N'Thành Thái,F.10,Q.10,Tp.hcm')
go
insert into NHANVIEN values ('admin', 'Vuong Ngoc Quyen', '1957-10-22',N'450 Trung Vuong, Ha Noi','222135465',N'Nam','admin','admin')
insert into NHANVIEN values ('nv01', 'Nguyen Thanh Tung', '1955-01-09', N'731 Tran Hung Dao, Q1, TpHCM','123456789',N'Nu','nv01','kinhdoanh')
insert into NHANVIEN values ('nv02', 'Le Thi Nhan', '1960-12-18', N'291 Ho Van Hue, QPN, TpHCM','987456321',N'Nu','nv02','thukho')
insert into NHANVIEN values ('nv03', 'Dinh Ba Tien', '1968-01-09', N'638 Nguyen Van Cu, Q5, TpHCM', '147852369',N'Nam','nv03','banhang')
insert into NHANVIEN values ('nv04', 'Nguyen Van A', '1968-01-09', N'638 Nguyen Van Cu, Q5, TpHCM', '147852369',N'Nam','nv04','nhaphang')
go
insert into DONGIA values ('2015-10-03','SR','20000000','21500000')
insert into DONGIA values ('2013-9-03','SH','75000000','80000000')
insert into DONGIA values ('2014-4-03','L','3900000','41000000')
insert into DONGIA values ('2014-11-03','YP','18000000','19000000')
go
insert into HOADONNHAP values('hdn01','HDVN','001','2015-10-03')
insert into HOADONNHAP values('hdn02','HDVN','003','2015-6-13')
insert into HOADONNHAP values('hdn03','YMH','002','2014-1-20')
insert into HOADONNHAP values('hdn04','SZK','004','2015-10-03')
go
insert into HOADONBAN values('hdb01','KH01','nv03','10-03-2015','')
insert into HOADONBAN values('hdb02','KH02','nv03','10-03-2015','')
insert into HOADONBAN values('hdb03','KH04','nv03','04-20-2016','')
insert into HOADONBAN values('hdb04','KH01','nv03','04-20-2016','')
insert into HOADONBAN values('hdb06','KH04','nv04','03-20-2016','')
insert into HOADONBAN values('hdb07','KH01','nv04','01-20-2016','')
go
insert into CT_HDNHAP values ('hdn01','SR','100','20000000','2000000000')
insert into CT_HDNHAP values ('hdn02','VS','50','50000000','50000000')
insert into CT_HDNHAP values ('hdn03','SH','50','80000000','80000000')
insert into CT_HDNHAP values ('hdn04','L','50','50000000','50000000')
go
insert into CTHDBAN values('hdb01','SR','5','21500000','100000000','45000000','55000000')
insert into CTHDBAN values('hdb02','VS','15','19000000','100000000','45000000','55000000')
insert into CTHDBAN values('hdb03','SH','20','80000000','100000000','45000000','55000000')
insert into CTHDBAN values('hdb04','L','10','41000000','100000000','45000000','55000000')


select * from HOADONBAN where Ngayban='4/20/2016'