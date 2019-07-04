use QuanLyGaRa
go


create table PhuTung
(
	maphutung int not null primary key,
	tenphutung nvarchar(100) not null default N'Trống',
	dongia float not null default 0,
	tondau int not null default 0,	
	toncuoi int not null default 0,	
)
create table HieuXe
(
	hieuxe nvarchar (100) primary key,
)

go
create table PhieuTiepNhan
(
	matiepnhan int primary key,
	ngaytiepnhan date not null default getdate(),
	bienso nvarchar (100),
    ht nvarchar(100) not null default N'Trống',
    sdt int not null default 0,
	diachi nvarchar(100) not null default N'Trống',
	hieuxe nvarchar (100),
)
go
create table Xe
(	
	BienSo nvarchar (100) not null primary key,
	hieuxe nvarchar(100) not null default N'Trống',
	matiepnhan int ,
	sdt int not null default N'Trống',
	ht nvarchar(100) not null default N'Trống',
	diachi nvarchar(1000) not null default N'Trống',
	email nvarchar(100) null ,
	foreign key (matiepnhan) references dbo.PhieuTiepNhan(matiepnhan),
)
go



create table PhieuThuTien
(
	id int primary key,
	ngaythutien date not null default getdate(),
	sotienthu float not null default 0,
    bienso nvarchar (100),
    ht nvarchar(100) not null default N'Trống',
    sdt int not null default 0,
    email nvarchar(100) not null default N'Trống',


	
)
go



