USE [QuanLyGaRa]
GO
/****** Object:  Table [dbo].[HieuXe]    Script Date: 7/4/2019 3:56:21 PM ******/
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
/****** Object:  Table [dbo].[PhieuThuTien]    Script Date: 7/4/2019 3:56:21 PM ******/
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
/****** Object:  Table [dbo].[PhieuTiepNhan]    Script Date: 7/4/2019 3:56:21 PM ******/
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
/****** Object:  Table [dbo].[PhuTung]    Script Date: 7/4/2019 3:56:21 PM ******/
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
INSERT [dbo].[PhieuTiepNhan] ([matiepnhan], [ngaytiepnhan], [bienso], [ht], [sdt], [diachi], [hieuxe]) VALUES (1, CAST(N'2001-01-01' AS Date), N'123', N'Bùi Á ', 123123123, N'123', N'Hyundai')
INSERT [dbo].[PhieuTiepNhan] ([matiepnhan], [ngaytiepnhan], [bienso], [ht], [sdt], [diachi], [hieuxe]) VALUES (2, CAST(N'1999-02-02' AS Date), N'1234AC', N'Bùi Hoàng ', 123123123, N'12 Ngô Quyền', N'Ford')
INSERT [dbo].[PhieuTiepNhan] ([matiepnhan], [ngaytiepnhan], [bienso], [ht], [sdt], [diachi], [hieuxe]) VALUES (3, CAST(N'2001-03-03' AS Date), N'1234', N'Bùi Á Nam', 123123123, N'1234', N'Ford')
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (1, N'Phuộc trước', 1200000, 1000, 1000)
INSERT [dbo].[PhuTung] ([maphutung], [tenphutung], [dongia], [tondau], [toncuoi]) VALUES (2, N'Máy phát điện', 7200000, 1000, 1000)
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
