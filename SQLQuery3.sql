create database [QuanLyGaRa]
GO

USE [QuanLyGaRa]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCaoDoanhSo](
	[MaBaoCaoDoanhSo] [int] NOT NULL,
	[NgayBaoCao] [date] NOT NULL,
	[SoLuotSuaChua] [int] NOT NULL,
	[TongDoanhThu] [float] NOT NULL,
	[MaPhieuSuaChua] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoDoanhSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaoCaoTon]    Script Date: 7/5/2019 12:26:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCaoTon](
	[MaBaoCaoTon] [int] NOT NULL,
	[NgayBaoCao] [date] NOT NULL,
	[MaPhuTung] [int] NOT NULL,
	[MaPhieuSuaChua] [int] NOT NULL,
	[TonDau] [float] NOT NULL,
	[TonCuoi] [float] NOT NULL,
	[PhatSinh] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoTon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuXe]    Script Date: 7/5/2019 12:26:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuXe](
	[MaChuXe] [int] NOT NULL,
	[SoDienThoai] [int] NOT NULL,
	[TenChuXe] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](1000) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChuXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HieuXe]    Script Date: 7/5/2019 12:26:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HieuXe](
	[hieuxe] [nvarchar](100) NOT NULL,
	
PRIMARY KEY CLUSTERED 
(
	[hieuxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 7/5/2019 12:26:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[TenDangNhap] [nvarchar](100) NOT NULL,
	[TenHienThi] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuSuaChua]    Script Date: 7/5/2019 12:26:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuSuaChua](
	[MaPhieuSuaChua] [int] NOT NULL,
	[MaXe] [int] NOT NULL,
	[BienSo] [nvarchar](100) NULL,
	[NgayLapPhieu] [date] NOT NULL,
	[NoiDungSuaChua] [nvarchar](1000) NOT NULL,
	[MaPhuTung] [int] NOT NULL,
	[SoLuongPhuTung] [int] NOT NULL,
	[TienCong] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuSuaChua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThuTien]    Script Date: 7/5/2019 12:26:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThuTien](
	[id] [int] NOT NULL,
	[ngaythutien] [date] NOT NULL,
	[sotienthu] [float] NOT NULL,
	[bienso] [nvarchar](100) NULL,
	[ht] [nvarchar](100) NOT NULL,
	[sdt] [int] NOT NULL,
	[email] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuTiepNhan]    Script Date: 7/5/2019 12:26:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTiepNhan](
	[matiepnhan] [int] NOT NULL,
	[ngaytiepnhan] [date] NOT NULL,
	[bienso] [nvarchar](100) NULL,
	[ht] [nvarchar](100) NOT NULL,
	[sdt] [int] NOT NULL,
	[diachi] [nvarchar](100) NOT NULL,
	[hieuxe] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[matiepnhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuTiepNhanBaoTri]    Script Date: 7/5/2019 12:26:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTiepNhanBaoTri](
	[MaPhieuTiepNhanBaoTri] [int] NOT NULL,
	[MaXe] [int] NOT NULL,
	[NgayLapPhieu] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuTiepNhanBaoTri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhuTung]    Script Date: 7/5/2019 12:26:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhuTung](
	[maphutung] [int] NOT NULL,
	[tenphutung] [nvarchar](100) NOT NULL,
	[dongia] [float] NOT NULL,
	[tondau] [int] NOT NULL,
	[toncuoi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maphutung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 7/5/2019 12:26:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[Maxe] [int] NOT NULL,
	[BienSo] [nvarchar](100) NOT NULL,
	[TenHieuXe] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Maxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HieuXe] ([hieuxe]) VALUES (N'Audi')
INSERT [dbo].[HieuXe] ([hieuxe]) VALUES (N'BMW')
INSERT [dbo].[HieuXe] ([hieuxe]) VALUES (N'Ferrari')
INSERT [dbo].[HieuXe] ([hieuxe]) VALUES (N'Ford')
INSERT [dbo].[HieuXe] ([hieuxe]) VALUES (N'Honda')
INSERT [dbo].[HieuXe] ([hieuxe]) VALUES (N'Hyundai')
INSERT [dbo].[HieuXe] ([hieuxe]) VALUES (N'Jeep')
INSERT [dbo].[HieuXe] ([hieuxe]) VALUES (N'Lamborghini')
INSERT [dbo].[HieuXe] ([hieuxe]) VALUES (N'Toyota')
INSERT [dbo].[HieuXe] ([hieuxe]) VALUES (N'VinFast')
INSERT [dbo].[HieuXe] ([hieuxe]) VALUES (N'Mercedes-Benz')
INSERT [dbo].[PhieuThuTien] ([id], [ngaythutien], [sotienthu], [bienso], [ht], [sdt], [email]) VALUES (1, CAST(N'1999-01-01' AS Date), 1200000, N'AVC123', N'Bùi A ', 123123123, N'ACB@gm.com')
INSERT [dbo].[PhieuTiepNhan] ([matiepnhan], [ngaytiepnhan], [bienso], [ht], [sdt], [diachi], [hieuxe]) VALUES (1, CAST(N'1999-01-01' AS Date), N'123KJ-M', N'Hoàng A', 123123123, N'123 Hà Nội', N'Mercedes-Benz')
INSERT [dbo].[PhieuTiepNhan] ([matiepnhan], [ngaytiepnhan], [bienso], [ht], [sdt], [diachi], [hieuxe]) VALUES (2, CAST(N'1999-02-02' AS Date), N'1234AC', N'Bùi Hoàng ', 123123123, N'12 Ngô Quyền', N'Ford')
INSERT [dbo].[PhieuTiepNhan] ([matiepnhan], [ngaytiepnhan], [bienso], [ht], [sdt], [diachi], [hieuxe]) VALUES (3, CAST(N'2001-03-03' AS Date), N'1234', N'Bùi Á Nam', 123123123, N'1234', N'Ford')
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (1, N'Phuộc trước audi', 1200000, 100, 1000)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (2, N'Máy phát điện toyota innova', 7200000, 100, 1000)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (3, N'Phuộc sau toyota innova', 750000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (4, N'Lốc lạnh toyota innova tháo xe', 4500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (5, N'Mâm ép toyota toyota ', 2000000, 90, 90)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (6, N'Bố thắng trước toyota ', 1300000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (7, N'Bố thắng sau innova chính hãng', 1000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (8, N'Cao su chân máy innova chính hãng', 7500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (9, N'Đuôi cá HONDA CIVIC', 2200000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (10, N'Sét gạt mưa HONDA CIVIC 2.0i size 26″X22″', 450000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (11, N'Lọc gió động cơ Honda Civic 1.8:', 450000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (12, N'Lọc nhiên liệu audi', 250000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (13, N'Lọc nhiên liệu bmw', 1200000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (14, N'Lọc nhiên liệu ferrari', 170000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (15, N'Láp dọc đồng bộ', 7100000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (16, N'Cao su chân máy trước', 900000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (17, N'Mâm ép audi', 6000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (18, N'Búp sen thắng sau', 700000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (19, N'Mâm 5 cánh Vinfast', 2000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (20, N'Lọc nước động cơ BMW', 5000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (21, N'Lọc nước động cơ Audi', 7000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (22, N'Lọc nước động cơ Vinfast', 2000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (23, N'Lọc nước động cơ toyota', 1000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (24, N'Lọc nước động cơ ford', 1000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (25, N'Lọc nước động cơ jeep', 1000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (26, N'Lọc nước động cơ hyumdai', 1000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (27, N'Lọc nước động cơ lamboghini', 1000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (28, N'Lọc nhiên liệu ford', 1000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (29, N'Kính chiếu hậu Audi', 3000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (30, N'Kính chiếu hậu bwm', 7000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (40, N'Kính chiếu hậu ferrari', 9000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (41, N'Kính chiếu hậu honda', 2000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (42, N'Kính chiếu hậu hyunhdai', 2600000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (43, N'Kính chiếu hậu jeep', 8000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (44, N'Turbo tăng áp xe Mercedes C200K', 20000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (45, N'Cần gạt nước BMW', 7000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (46, N'Cần gạt nước Audi', 6800000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (47, N'Cần gạt nước Honda', 9500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (48, N'Cần gạt nước HuynDai', 6000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (49, N'Cần gạt nước Jeep', 8500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (50, N'Cần gạt nước Lamborghini', 15000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (52, N'Cần gạt nước Toyota', 4300000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (53, N'Phuộc trước BMW', 50000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (54, N'Phuộc trước Ferari', 60000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (55, N'Phuộc trước ford', 30500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (56, N'Phuộc trước honda', 25500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (57, N'Phuộc trước hyundai', 20000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (58, N'Phuộc trước lamborghini', 75000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (59, N'Phuộc trước toyota', 25000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (60, N'Phuộc trước vinfast', 30000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (61, N'Phuộc trước mercedes', 65000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (62, N'Máy phát điện audi', 5500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (63, N'Máy phát điện bmw', 3000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (64, N'Máy phát điện ferrari', 6000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (65, N'Máy phát điện ford', 3600000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (66, N'Máy phát điện honda', 3000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (67, N'Máy phát điện lamborghini', 4000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (68, N'Máy phát điện toyota', 4500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (69, N'Máy phát điện vinfast', 4300000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (70, N'Máy phát điện mercedes', 7800000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (71, N'Phuộc sau toyota ', 30000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (72, N'Phuộc sau audi', 60000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (73, N'Phuộc sau bmw', 65000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (74, N'Phuộc sau ferrari', 55000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (75, N'Phuộc sau ford', 45000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (76, N'Phuộc sau honda', 43000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (77, N'Phuộc sau jeep', 58000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (78, N'Phuộc sau vinfast', 40000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (79, N'Phuộc sau mecedes', 63000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (80, N'Mâm ép audi', 30000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (81, N'Mâm ép bmw', 35000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (82, N'Mâm ép ford', 15000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (83, N'Mâm ép honda', 15400000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (84, N'Mâm ép hyndai', 16000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (85, N'Mâm ép jeep', 65000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (86, N'Mâm ép vinfast', 20000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (87, N'Mâm ép mecedess', 45000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (88, N'Bố thắng trước audi', 10000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (89, N'Bố thắng trước bmw', 15000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (90, N'Bố thắng trước ferrari', 15000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (91, N'Bố thắng trước ford', 8000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (92, N'Bố thắng trước honda', 6000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (93, N'Bố thắng trước hyndai', 4500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (94, N'Bố thắng trước jeep', 17000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (95, N'Bố thắng trước lamboghini', 16500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (96, N'Bố thắng trước vinfast', 9000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (97, N'Bố thắng trước mercedess', 8500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (98, N'Bố thắng sau audi', 20000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (99, N'Bố thắng sau bmw', 22000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (100, N'Bố thắng sau ferrari', 21000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (101, N'Bố thắng sau ford', 18000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (102, N'Bố thắng sau honda', 15000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (103, N'Bố thắng sau hyundai', 17500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (104, N'Bố thắng sau lamboghini', 25000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (105, N'Bố thắng sau jeep', 26000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (106, N'Bố thắng sau vinfast', 15000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (107, N'Bố thắng sau mercedes', 24500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (108, N'Đuôi cá audi', 11000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (109, N'Đuôi cá bwm', 15000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (110, N'Đuôi cá ferrari', 13000000, 100, 100)
GO
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (111, N'Đuôi cá ford', 6500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (112, N'Đuôi cá hyundai', 6000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (113, N'Đuôi cá jeep', 4200000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (114, N'Đuôi cá lamboghini', 3500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (115, N'Đuôi cá toyota', 9000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (116, N'Đuôi cá vinfast', 4500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (117, N'Đuôi cá mercedes', 9000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (118, N'Sét gạt mưa audi', 2000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (119, N'Sét gạt mưa bmw', 3500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (120, N'Sét gạt mưa ferrari', 4500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (121, N'Sét gạt mưa ford', 2200000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (122, N'Sét gạt mưa hyundai', 2000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (123, N'Sét gạt mưa jeep', 5000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (124, N'Sét gạt mưa lamboghini', 5600000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (125, N'Sét gạt mưa toyota', 5400000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (126, N'Sét gạt mưa vinfast', 2300000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (127, N'Sét gạt mưa mercedes', 5000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (128, N'Lọc gió động cơ audi', 7000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (129, N'Lọc gió động cơ bmw', 7800000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (130, N'Lọc gió động cơ ferrari', 9500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (131, N'Lọc gió động cơ ford', 6500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (132, N'Bộ cản trước Audi', 5400000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (134, N'Bộ cản trước bmw', 6500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (135, N'Bộ cản trước ferrari', 7000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (136, N'Bộ cản trước ford', 9500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (137, N'Bộ cản trước hyundai', 9800000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (138, N'Bộ cản trước honda', 7000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (139, N'Bộ cản trước jeep', 8600000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (140, N'Bộ cản trước lamnoghini', 6000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (141, N'Bộ cản trước toyota', 2000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (142, N'Bộ cản trước vinfast', 4500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (143, N'Bộ cản trước mercedes', 4000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (144, N'Lọc nhiên liệu honda', 6500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (145, N'Lọc nhiên liệu hyundai', 6800000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (146, N'Lọc nhiên liệu jeep', 7500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (147, N'Lọc nhiên liệu lamboghini', 3000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (148, N'Lọc nhiên liệutoyota', 1000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (149, N'Lọc nhiên liệu vinfast', 3600000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (150, N'Lọc nhiên liệu mercedess', 4500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (151, N'Mâm ép bmw', 90000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (152, N'Mâm ép ferrari', 85000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (153, N'Mâm ép ford', 50000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (154, N'Mâm ép honda', 60000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (155, N'Mâm ép hyundai', 75000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (156, N'Mâm ép jeep', 76000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (157, N'Mâm ép lamborghini', 80000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (158, N'Mâm ép toyota', 50000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (159, N'Mâm ép vinfast', 60000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (160, N'Mâm ép mercedess', 46000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (161, N'Mâm 5 cánh audi', 20000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (162, N'Mâm 5 cánh bmw', 22000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (163, N'Mâm 5 cánh ferrari', 25000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (164, N'Mâm 5 cánh ford', 21000000, 100, 0)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (165, N'Mâm 5 cánh honda', 24000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (166, N'Mâm 5 cánh hyundai', 26000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (167, N'Mâm 5 cánh jeep', 34000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (168, N'Mâm 5 cánh lamborghini', 62000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (169, N'Mâm 5 cánh Mâm 5 cánh toyota', 42000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (170, N'Turbo tăng áp xe vinfast', 50000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (171, N'Turbo tăng áp xe toyota', 40000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (172, N'Turbo tăng áp xe lamborghini', 60000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (173, N'Turbo tăng áp xe honda', 50000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (174, N'Turbo tăng áp xe hyundai', 30000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (175, N'Turbo tăng áp xe  jeep', 42000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (176, N'Turbo tăng áp xe ford', 35000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (177, N'Turbo tăng áp xe bmw', 45000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (178, N'Turbo tăng áp xe audi', 60000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (179, N'Camera hành trình', 4000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (180, N'BÓNG ĐÈN XENON PHILIPS H7', 500000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (181, N'BÓNG XENON PHILIPS D3S', 800000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (182, N'Cảm biến áp suất lốp Steel-mate TP05, TP06', 5000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (183, N'ỐP MÁ PHANH BREMBO', 15000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (184, N'VAN ỐNG XẢ ĐỘ PÔ HAI CHẾ ĐỘ', 1000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (185, N'Đèn pha Camry 2.4 2010 VN', 2400000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (186, N'Tay mở cửa ngoài trước Grand I10', 1000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (187, N'Mâm đúc Grand I10', 20000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (188, N'Chắn bùn bánh trước Grand I10', 250000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (189, N'ơm dầu hộp số tự động Lacetti CDX', 50000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (190, N'Cần đi số Lacetti', 3000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (191, N'Càng A trước Matiz 5 M400', 1000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (192, N'Phím còi Matiz', 2000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (193, N'Kính chán gió Audi', 15000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (194, N'Kính chán gió bmw', 18000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (195, N'Kính chán gió ferrari', 16000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (196, N'Kính chán gió ford', 10000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (197, N'Kính chán gió hyundai', 9000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (198, N'Kính chán gió jeep', 14000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (199, N'Kính chán gió toyota', 7000000, 100, 100)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (200, N'Kính chán gió vinfast', 6000000, 100, 100)
ALTER TABLE [dbo].[BaoCaoDoanhSo] ADD  DEFAULT (getdate()) FOR [NgayBaoCao]
GO
ALTER TABLE [dbo].[BaoCaoDoanhSo] ADD  DEFAULT ((0)) FOR [SoLuotSuaChua]
GO
ALTER TABLE [dbo].[BaoCaoDoanhSo] ADD  DEFAULT ((0)) FOR [TongDoanhThu]
GO
ALTER TABLE [dbo].[BaoCaoTon] ADD  DEFAULT (getdate()) FOR [NgayBaoCao]
GO
ALTER TABLE [dbo].[BaoCaoTon] ADD  DEFAULT ((0)) FOR [TonDau]
GO
ALTER TABLE [dbo].[BaoCaoTon] ADD  DEFAULT ((0)) FOR [TonCuoi]
GO
ALTER TABLE [dbo].[BaoCaoTon] ADD  DEFAULT ((0)) FOR [PhatSinh]
GO
ALTER TABLE [dbo].[ChuXe] ADD  DEFAULT ((0)) FOR [SoDienThoai]
GO
ALTER TABLE [dbo].[ChuXe] ADD  DEFAULT (N'Trống') FOR [TenChuXe]
GO
ALTER TABLE [dbo].[ChuXe] ADD  DEFAULT (N'Trống') FOR [DiaChi]
GO
ALTER TABLE [dbo].[ChuXe] ADD  DEFAULT (N'Trống') FOR [Email]
GO
ALTER TABLE [dbo].[NguoiDung] ADD  DEFAULT (N'User') FOR [TenHienThi]
GO
ALTER TABLE [dbo].[NguoiDung] ADD  DEFAULT ((0)) FOR [PassWord]
GO
ALTER TABLE [dbo].[NguoiDung] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[PhieuSuaChua] ADD  DEFAULT (getdate()) FOR [NgayLapPhieu]
GO
ALTER TABLE [dbo].[PhieuSuaChua] ADD  DEFAULT (N'Trống') FOR [NoiDungSuaChua]
GO
ALTER TABLE [dbo].[PhieuSuaChua] ADD  DEFAULT ((0)) FOR [SoLuongPhuTung]
GO
ALTER TABLE [dbo].[PhieuSuaChua] ADD  DEFAULT ((0)) FOR [TienCong]
GO
ALTER TABLE [dbo].[PhieuThuTien] ADD  DEFAULT (getdate()) FOR [ngaythutien]
GO
ALTER TABLE [dbo].[PhieuThuTien] ADD  DEFAULT ((0)) FOR [sotienthu]
GO
ALTER TABLE [dbo].[PhieuThuTien] ADD  DEFAULT (N'Trống') FOR [ht]
GO
ALTER TABLE [dbo].[PhieuThuTien] ADD  DEFAULT ((0)) FOR [sdt]
GO
ALTER TABLE [dbo].[PhieuThuTien] ADD  DEFAULT (N'Trống') FOR [email]
GO
ALTER TABLE [dbo].[PhieuTiepNhan] ADD  DEFAULT (getdate()) FOR [ngaytiepnhan]
GO
ALTER TABLE [dbo].[PhieuTiepNhan] ADD  DEFAULT (N'Trống') FOR [ht]
GO
ALTER TABLE [dbo].[PhieuTiepNhan] ADD  DEFAULT ((0)) FOR [sdt]
GO
ALTER TABLE [dbo].[PhieuTiepNhan] ADD  DEFAULT (N'Trống') FOR [diachi]
GO
ALTER TABLE [dbo].[PhieuTiepNhanBaoTri] ADD  DEFAULT (getdate()) FOR [NgayLapPhieu]
GO
ALTER TABLE [dbo].[PhuTung] ADD  DEFAULT (N'Trống') FOR [tenphutung]
GO
ALTER TABLE [dbo].[PhuTung] ADD  DEFAULT ((0)) FOR [dongia]
GO
ALTER TABLE [dbo].[PhuTung] ADD  DEFAULT ((0)) FOR [tondau]
GO
ALTER TABLE [dbo].[PhuTung] ADD  DEFAULT ((0)) FOR [toncuoi]
GO
ALTER TABLE [dbo].[Xe] ADD  DEFAULT (N'Trống') FOR [BienSo]
GO
ALTER TABLE [dbo].[Xe] ADD  DEFAULT (N'Trống') FOR [TenHieuXe]
GO
ALTER TABLE [dbo].[BaoCaoDoanhSo]  WITH CHECK ADD FOREIGN KEY([MaPhieuSuaChua])
REFERENCES [dbo].[PhieuSuaChua] ([MaPhieuSuaChua])
GO
ALTER TABLE [dbo].[BaoCaoTon]  WITH CHECK ADD FOREIGN KEY([MaPhieuSuaChua])
REFERENCES [dbo].[PhieuSuaChua] ([MaPhieuSuaChua])
GO
ALTER TABLE [dbo].[BaoCaoTon]  WITH CHECK ADD FOREIGN KEY([MaPhuTung])
REFERENCES [dbo].[PhuTung] ([maphutung])
GO
ALTER TABLE [dbo].[PhieuSuaChua]  WITH CHECK ADD FOREIGN KEY([MaPhuTung])
REFERENCES [dbo].[PhuTung] ([maphutung])
GO
ALTER TABLE [dbo].[PhieuSuaChua]  WITH CHECK ADD FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([Maxe])
GO
ALTER TABLE [dbo].[PhieuTiepNhanBaoTri]  WITH CHECK ADD FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([Maxe])
GO
