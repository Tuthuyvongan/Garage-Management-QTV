USE [master]
GO
CREATE DATABASE [QuanLyGaRa]
 CONTAINMENT = NONE
GO
ALTER DATABASE [QuanLyGaRa] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyGaRa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyGaRa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyGaRa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyGaRa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyGaRa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyGaRa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyGaRa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyGaRa] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyGaRa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyGaRa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyGaRa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyGaRa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyGaRa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyGaRa] SET QUERY_STORE = OFF
GO
USE [QuanLyGaRa]
GO
/****** Object:  Table [dbo].[BaoCaoDoanhSo]    Script Date: 7/5/2019 3:43:03 PM ******/
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
/****** Object:  Table [dbo].[BaoCaoTon]    Script Date: 7/5/2019 3:43:03 PM ******/
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
/****** Object:  Table [dbo].[HieuXe]    Script Date: 7/5/2019 3:43:04 PM ******/
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
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 7/5/2019 3:43:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[TenDangNhap] [nvarchar](100) NOT NULL,
	[TenHienThi] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuSuaChua]    Script Date: 7/5/2019 3:43:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuSuaChua](
	[bienso] [nvarchar](100) NULL,
	[ngaysuachua] [date] NOT NULL,
	[tenphutung] [nvarchar](1000) NOT NULL,
	[dongia] [int] NOT NULL,
	[soluong] [int] NOT NULL,
	[tendichvu] [nvarchar](1000) NOT NULL,
	[tiencong] [decimal](18, 0) NOT NULL,
	[thanhtien] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThuTien]    Script Date: 7/5/2019 3:43:04 PM ******/
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
/****** Object:  Table [dbo].[PhieuTiepNhan]    Script Date: 7/5/2019 3:43:04 PM ******/
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
/****** Object:  Table [dbo].[PhuTung]    Script Date: 7/5/2019 3:43:04 PM ******/
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
/****** Object:  Table [dbo].[TienCong]    Script Date: 7/5/2019 3:43:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TienCong](
	[matiencong] [int] NOT NULL,
	[tendichvu] [nvarchar](100) NOT NULL,
	[tiencong] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_TienCong] PRIMARY KEY CLUSTERED 
(
	[matiencong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
Insert [dbo].[NguoiDung] (TenDangNhap,TenHienThi,PassWord) values ('admin','QTV','1')
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
INSERT [dbo].[PhieuSuaChua] ([bienso], [ngaysuachua], [tenphutung], [dongia], [soluong], [tendichvu], [tiencong], [thanhtien]) VALUES (N'123KJ-M', CAST(N'2019-07-05' AS Date), N'Phuộc trước audi', 1200000, 2, N'Công thay dầu máy', CAST(50000 AS Decimal(18, 0)), CAST(2 AS Decimal(18, 0)))
INSERT [dbo].[PhieuSuaChua] ([bienso], [ngaysuachua], [tenphutung], [dongia], [soluong], [tendichvu], [tiencong], [thanhtien]) VALUES (N'1234AC', CAST(N'2019-07-05' AS Date), N'Phuộc trước audi', 1200000, 2, N'Công thay dầu máy', CAST(50000 AS Decimal(18, 0)), CAST(3 AS Decimal(18, 0)))
INSERT [dbo].[PhieuSuaChua] ([bienso], [ngaysuachua], [tenphutung], [dongia], [soluong], [tendichvu], [tiencong], [thanhtien]) VALUES (N'123KJ-M', CAST(N'2019-07-05' AS Date), N'Phuộc trước audi', 1200000, 1, N'Công thay dầu máy', CAST(50000 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[PhieuSuaChua] ([bienso], [ngaysuachua], [tenphutung], [dongia], [soluong], [tendichvu], [tiencong], [thanhtien]) VALUES (N'1234AC', CAST(N'2019-07-05' AS Date), N'Phuộc trước audi', 1200000, 1, N'Công thay dầu máy', CAST(50000 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)))
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
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (1, N'Công thay dầu máy', CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (2, N'Công thay lọc dầu', CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (3, N'Công thay dầu máy, lọc dầu', CAST(80000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (4, N'Thay lọc xăng', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (5, N'Thay lọc xăng thả thùng', CAST(200000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (6, N'Thay lọc nhiên liệu', CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (7, N'Thay hộp dầu số MT ', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (8, N'Thay hộp dầu số AT ', CAST(200000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (9, N'Thay chế hòa khí, chỉnh máy', CAST(350000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (10, N'Thay lọc gió', CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (11, N'Thay bugi', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (12, N'Công bảo dưỡng mỗi 10.000đkm xe Sedan ( không bao gồm vật tư )', CAST(200000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (13, N'Công bảo dưỡng mỗi 10.000đkm xe SUV ( không bao gồm vật tư )', CAST(250000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (14, N'Công bảo dưỡng mỗi 20.000đkm xe Sedan ( không bao gồm vật tư )', CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (15, N'Công bảo dưỡng mỗi 20.000đkm xe SUV ( không bao gồm vật tư )', CAST(450000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (16, N'Bảo dưỡng chế hòa khí, chỉnh máy ( bao gồm vật liệu bảo dưỡng )', CAST(350000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (17, N'Bảo dưỡng cụm bướm ga, chỉnh máy ( bao gồm vật liệu bảo dưỡng )', CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (18, N'Bảo dưỡng cụm bướm ga, thay súc tu bô, chỉnh máy ( bao gồm vật liệu bảo dưỡng )', CAST(500000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (19, N'Kiểm tra, vệ sinh bugi ( trường hợp tháo bugi phức tạp thêm 100% tiền công )', CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (20, N'Bảo dưỡng Denco', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (21, N'Bảo dưỡng máy phát', CAST(200000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (22, N'Bảo dưỡng máy đề', CAST(200000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (23, N'Thay nước mát', CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (24, N'Thông súc két nước ( không tháo ) ( bao gồm dung dịch làm sạch )', CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (25, N'Thông súc két nước ( tháo két nước ra ngoài )', CAST(350000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (26, N'Tháo hàn két nước, thông súc', CAST(450000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (27, N'Tháo lắp kiểm tra kim phun, bơm cao áp ( loại bơm không cân ) ', CAST(400000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (28, N'Tháo lắp cân kim phun', CAST(600000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (29, N'Cân bơm cao áp', CAST(500000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (30, N'Thông súc bình xăng hoặc thùng dầu', CAST(350000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (31, N'Tăng chỉnh dây Curoa ngoài / 1 dây', CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (32, N'Tăng chỉnh dây Curoa ngoài / 3 dây', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (33, N'Thay phớt chân bugi ( bộ ) bao gồm keo gioăng - xe 4 máy chạy chế hòa khí', CAST(200000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (34, N'Thay phớt chân bugi ( bộ ) bao gồm keo gioăng - xe 4 máy phun xăng', CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (35, N'Thay gioăng nắp supap bao gồm keo gioăng ( 4 máy )', CAST(200000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (36, N'Thay gioăng nắp supap bao gồm keo gioăng ( máy V ), thay cả 2 bên tăng thêm 80%', CAST(250000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (37, N'Kiểm tra dây cao áp', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (38, N'Thay két nước ', CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (39, N'Thay bơm nước ( trường hợp khó, công tăng thêm 50% ) ', CAST(250000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (40, N'Thay cánh quạt két nước ', CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (41, N'Thay lồng quạt két nước', CAST(80000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (42, N'Thay dây curoa đơn/ sợi ( 80.000đ / bộ ) ', CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (43, N'Thay dây curoa tổng', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (44, N'Thây gioăng quy lát, mài mặt máy, vệ sinh ( 4 máy )', CAST(800000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (45, N'Thay gioăng quy lát, mài mặt máy, vệ sinh ( 6 máy thẳng hàng ) ', CAST(900000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (46, N'Thay gioăng mặt máy, mài mặt máy ( máy V ), nếu thay cả 2 bên công tăng thêm 75%', CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (47, N'Thay mặt máy ( mài rà supap, thay nhớt git ... )', CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (48, N'Căn chỉnh supap ( supap cơ khí ) ', CAST(250000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (49, N'Thay con đội supap', CAST(500000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (50, N'Kiểm tra thay cảm biến trục cơ hoặc cảm biến trục cam, chỉnh máy', CAST(250000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (51, N'Thay cảm biến nhiệt độ nước, dầu', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (52, N'Kiểm tra thay cụm bướm ga, cài đặt bằng máy chuyên dùng', CAST(350000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (53, N'Kiểm tra thay cảm biến đo gió', CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (54, N'Kiểm tra thay kim phun', CAST(400000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (55, N'Kiểm tra thay kim phun ( 1 bộ ) ', CAST(800000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (56, N'Thay cụm tu bô', CAST(400000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (57, N'Thay dây curoa cam, bi tăng, tỳ cam, đặt cam ( 4 máy )', CAST(400000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (58, N'Thay dây curoa cam, bi tăng, tỳ cam, đặt cam ( 6 máy )', CAST(550000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (59, N'Thay bơm dầu máy ( trường hợp khó tháo lắp, công tăng thêm 30% )', CAST(450000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (60, N'Thay phớt đầu trục cơ', CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (61, N'Thay gioăng cổ xả ( loại phức tạp công tăng thêm 50% )', CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (62, N'Thay ống xả đoạn giữa', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (63, N'Thay ống xả đoạn cuối ( loại 2 bầu công tăng thêm 50% )', CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[TienCong] ([matiencong], [tendichvu], [tiencong]) VALUES (64, N'Thay toàn bộ ống xả ', CAST(250000 AS Decimal(18, 0)))
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
ALTER TABLE [dbo].[NguoiDung] ADD  DEFAULT (N'User') FOR [TenHienThi]
GO
ALTER TABLE [dbo].[NguoiDung] ADD  DEFAULT ((0)) FOR [PassWord]
GO
ALTER TABLE [dbo].[NguoiDung] ADD  DEFAULT ((0)) FOR [Type]
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
ALTER TABLE [dbo].[PhuTung] ADD  DEFAULT (N'Trống') FOR [tenphutung]
GO
ALTER TABLE [dbo].[PhuTung] ADD  DEFAULT ((0)) FOR [dongia]
GO
ALTER TABLE [dbo].[PhuTung] ADD  DEFAULT ((0)) FOR [tondau]
GO
ALTER TABLE [dbo].[PhuTung] ADD  DEFAULT ((0)) FOR [toncuoi]
GO
ALTER TABLE [dbo].[PhieuTiepNhan]  WITH CHECK ADD  CONSTRAINT [fk_PhieuTiepNhan_HieuXe] FOREIGN KEY([hieuxe])
REFERENCES [dbo].[HieuXe] ([hieuxe])
GO
ALTER TABLE [dbo].[PhieuTiepNhan] CHECK CONSTRAINT [fk_PhieuTiepNhan_HieuXe]
GO
USE [master]
GO
ALTER DATABASE [QuanLyGaRa] SET  READ_WRITE 
GO
