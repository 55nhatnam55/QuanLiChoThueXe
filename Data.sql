USE [master]
GO
/****** Object:  Database [QL_Thuexeoto]    Script Date: 11/16/2018 7:44:27 AM ******/
CREATE DATABASE [QL_Thuexeoto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_Thuexeoto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QL_Thuexeoto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_Thuexeoto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QL_Thuexeoto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_Thuexeoto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_Thuexeoto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_Thuexeoto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_Thuexeoto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_Thuexeoto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_Thuexeoto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_Thuexeoto] SET  MULTI_USER 
GO
ALTER DATABASE [QL_Thuexeoto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_Thuexeoto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_Thuexeoto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_Thuexeoto] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QL_Thuexeoto]
GO
/****** Object:  UserDefinedFunction [dbo].[thanhtoan]    Script Date: 11/16/2018 7:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[thanhtoan](@makh char(4))
RETURNS @trave table(
makhachhang CHAR(4),
CMND nchar(12),
phibaoduong money,
tongtien money
)
AS
BEGIN
DECLARE @a MONEY
DECLARE @b MONEY
DECLARE @c INT
DECLARE @d INT
DECLARE @e MONEY
DECLARE @F MONEY
SET @a=(SELECT tt.DonGiaNgay FROM dbo.tbl_THONGTINXE tt,dbo.tbl_PHIEUTHUE pt WHERE tt.SoXe=pt.SoXe AND pt.MaKH=@makh )
SET @b=@a*5/100
SET @c=(SELECT SoNgayMuon FROM dbo.tbl_PHIEUTHUE WHERE dbo.tbl_PHIEUTHUE.MaKH=@makh)
SET @d=(SELECT COUNT(pt.MaKH) FROM dbo.tbl_PHIEUTHUE pt WHERE pt.MaKH=@makh)
SET @e=(@a+@b)*@c
SET @F=@a*@c
--IF(@d>1)
  INSERT INTO @trave
  SELECT kh.MaKH,kh.CMND,@b AS tienbaoduong,@e AS tongtien
  FROM dbo.tbl_THONGTINXE tt,dbo.tbl_PHIEUTHUE pt,dbo.tbl_KHACHHANG kh
  WHERE  kh.MaKH=@makh AND kh.MaKH=pt.MaKH AND tt.SoXe=pt.SoXe
--ELSE
--  INSERT INTO @trave
--  SELECT kh.MaKH,kh.CMND,@b AS tienbaoduong,@e AS tongtien
--  FROM dbo.tbl_THONGTINXE tt,dbo.tbl_PHIEUTHUE pt,dbo.tbl_KHACHHANG kh
--  WHERE  kh.MaKH=@makh AND kh.MaKH=pt.MaKH AND tt.SoXe=pt.SoXe
  RETURN
  END
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 11/16/2018 7:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[IDchucvu] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_BANGLAI]    Script Date: 11/16/2018 7:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_BANGLAI](
	[LoaiXe] [nvarchar](50) NOT NULL,
	[YeuCauBangLai] [varchar](2) NULL,
 CONSTRAINT [PK_BANGLAI] PRIMARY KEY CLUSTERED 
(
	[LoaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_KHACHHANG]    Script Date: 11/16/2018 7:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_KHACHHANG](
	[MaKH] [char](4) NOT NULL,
	[TenKH] [nchar](20) NOT NULL,
	[CMND] [nchar](12) NOT NULL,
	[SDT] [nchar](12) NOT NULL,
	[BangLai] [char](2) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_LOAIXE]    Script Date: 11/16/2018 7:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_LOAIXE](
	[MaLoai] [nvarchar](50) NOT NULL,
	[HangXe] [nvarchar](50) NOT NULL,
	[Soluong] [int] NULL,
 CONSTRAINT [PK_tbl_LOAIXE] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PHIEUTHUE]    Script Date: 11/16/2018 7:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PHIEUTHUE](
	[MaPhieu] [char](4) NOT NULL,
	[SoXe] [char](4) NOT NULL,
	[MaKH] [char](4) NOT NULL,
	[NgayLapPhieu] [date] NULL,
	[SoNgayMuon] [int] NULL,
 CONSTRAINT [PK_PHIEUTHUE] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_THONGTINXE]    Script Date: 11/16/2018 7:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_THONGTINXE](
	[SoXe] [char](4) NOT NULL,
	[MaLoai] [nvarchar](50) NOT NULL,
	[TenXe] [nvarchar](50) NULL,
	[DonGiaNgay] [int] NULL,
	[ChuXe] [nvarchar](50) NULL,
	[NamSX] [int] NULL,
 CONSTRAINT [PK_tbl_THONGTINXE] PRIMARY KEY CLUSTERED 
(
	[SoXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Login]    Script Date: 11/16/2018 7:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenDn] [varchar](50) NOT NULL,
	[Matkhau] [varchar](50) NULL,
	[TenNhanVien] [nvarchar](100) NULL,
	[SDT] [bigint] NULL,
	[DiaChi] [nvarchar](max) NULL,
	[Email] [nvarchar](100) NULL,
	[Luong] [bigint] NULL,
	[ChucVu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[tbl_BANGLAI] ([LoaiXe], [YeuCauBangLai]) VALUES (N'xe 5 chổ', N'B1')
INSERT [dbo].[tbl_BANGLAI] ([LoaiXe], [YeuCauBangLai]) VALUES (N'xe 7 chổ', N'B1')
INSERT [dbo].[tbl_BANGLAI] ([LoaiXe], [YeuCauBangLai]) VALUES (N'xe khách', N'D')
INSERT [dbo].[tbl_BANGLAI] ([LoaiXe], [YeuCauBangLai]) VALUES (N'xe máy', N'A1')
INSERT [dbo].[tbl_BANGLAI] ([LoaiXe], [YeuCauBangLai]) VALUES (N'xe tải', N'C1')
INSERT [dbo].[tbl_KHACHHANG] ([MaKH], [TenKH], [CMND], [SDT], [BangLai]) VALUES (N'KH01', N'Tạ Thành            ', N'281112655   ', N'0123456798  ', N'A1')
INSERT [dbo].[tbl_KHACHHANG] ([MaKH], [TenKH], [CMND], [SDT], [BangLai]) VALUES (N'KH02', N'Nguyễn Thanh Tâm    ', N'2811126561  ', N'0125462868  ', N'B1')
INSERT [dbo].[tbl_KHACHHANG] ([MaKH], [TenKH], [CMND], [SDT], [BangLai]) VALUES (N'KH03', N'Trần Thị Dung       ', N'28115454    ', N'0124562548  ', N'C1')
INSERT [dbo].[tbl_KHACHHANG] ([MaKH], [TenKH], [CMND], [SDT], [BangLai]) VALUES (N'KH04', N'Đặng Trung Tiến     ', N'285645241   ', N'0231562548  ', N'D ')
INSERT [dbo].[tbl_KHACHHANG] ([MaKH], [TenKH], [CMND], [SDT], [BangLai]) VALUES (N'KH05', N'Nguyễn Trung Ty     ', N'281115456   ', N'0169696969  ', N'A1')
INSERT [dbo].[tbl_KHACHHANG] ([MaKH], [TenKH], [CMND], [SDT], [BangLai]) VALUES (N'KH06', N'Chau Duy Cảnh       ', N'258645452   ', N'0123696969  ', N'B1')
INSERT [dbo].[tbl_KHACHHANG] ([MaKH], [TenKH], [CMND], [SDT], [BangLai]) VALUES (N'KH07', N'Nguyễn Minh Cảnh    ', N'215969696   ', N'0163695874  ', N'D ')
INSERT [dbo].[tbl_KHACHHANG] ([MaKH], [TenKH], [CMND], [SDT], [BangLai]) VALUES (N'KH08', N'Hồ Minh Hiếu        ', N'281115403   ', N'0169885969  ', N'B1')
INSERT [dbo].[tbl_KHACHHANG] ([MaKH], [TenKH], [CMND], [SDT], [BangLai]) VALUES (N'KH09', N'Võ Phương Thủy      ', N'285654231   ', N'0145632852  ', N'B1')
INSERT [dbo].[tbl_LOAIXE] ([MaLoai], [HangXe], [Soluong]) VALUES (N'xe 5 chổ', N'huynhdai', 2)
INSERT [dbo].[tbl_LOAIXE] ([MaLoai], [HangXe], [Soluong]) VALUES (N'xe 7 chổ', N'BMW', 3)
INSERT [dbo].[tbl_LOAIXE] ([MaLoai], [HangXe], [Soluong]) VALUES (N'xe khách', N'toyota', 3)
INSERT [dbo].[tbl_LOAIXE] ([MaLoai], [HangXe], [Soluong]) VALUES (N'xe máy', N'yamaha', 2)
INSERT [dbo].[tbl_LOAIXE] ([MaLoai], [HangXe], [Soluong]) VALUES (N'xe tải', N'huynhdai', 5)
INSERT [dbo].[tbl_PHIEUTHUE] ([MaPhieu], [SoXe], [MaKH], [NgayLapPhieu], [SoNgayMuon]) VALUES (N'P01 ', N'XE01', N'KH01', CAST(N'2017-10-10' AS Date), 2)
INSERT [dbo].[tbl_PHIEUTHUE] ([MaPhieu], [SoXe], [MaKH], [NgayLapPhieu], [SoNgayMuon]) VALUES (N'P02 ', N'XE08', N'KH06', CAST(N'2017-10-11' AS Date), 2)
INSERT [dbo].[tbl_PHIEUTHUE] ([MaPhieu], [SoXe], [MaKH], [NgayLapPhieu], [SoNgayMuon]) VALUES (N'P03 ', N'XE12', N'KH07', CAST(N'2017-10-12' AS Date), 2)
INSERT [dbo].[tbl_PHIEUTHUE] ([MaPhieu], [SoXe], [MaKH], [NgayLapPhieu], [SoNgayMuon]) VALUES (N'P04 ', N'XE06', N'KH02', CAST(N'2017-10-13' AS Date), 1)
INSERT [dbo].[tbl_PHIEUTHUE] ([MaPhieu], [SoXe], [MaKH], [NgayLapPhieu], [SoNgayMuon]) VALUES (N'P05 ', N'XE13', N'KH04', CAST(N'2017-10-14' AS Date), 5)
INSERT [dbo].[tbl_PHIEUTHUE] ([MaPhieu], [SoXe], [MaKH], [NgayLapPhieu], [SoNgayMuon]) VALUES (N'P06 ', N'XE02', N'KH05', CAST(N'2017-10-15' AS Date), 2)
INSERT [dbo].[tbl_PHIEUTHUE] ([MaPhieu], [SoXe], [MaKH], [NgayLapPhieu], [SoNgayMuon]) VALUES (N'P07 ', N'XE10', N'KH06', CAST(N'2017-02-14' AS Date), 4)
INSERT [dbo].[tbl_PHIEUTHUE] ([MaPhieu], [SoXe], [MaKH], [NgayLapPhieu], [SoNgayMuon]) VALUES (N'P09 ', N'XE05', N'KH03', CAST(N'2017-10-12' AS Date), 5)
INSERT [dbo].[tbl_PHIEUTHUE] ([MaPhieu], [SoXe], [MaKH], [NgayLapPhieu], [SoNgayMuon]) VALUES (N'P10 ', N'XE02', N'KH01', CAST(N'2017-04-30' AS Date), 1)
INSERT [dbo].[tbl_PHIEUTHUE] ([MaPhieu], [SoXe], [MaKH], [NgayLapPhieu], [SoNgayMuon]) VALUES (N'P11 ', N'XE02', N'KH01', CAST(N'2018-11-25' AS Date), 3)
INSERT [dbo].[tbl_PHIEUTHUE] ([MaPhieu], [SoXe], [MaKH], [NgayLapPhieu], [SoNgayMuon]) VALUES (N'P12 ', N'XE10', N'KH06', CAST(N'2017-02-14' AS Date), 4)
INSERT [dbo].[tbl_PHIEUTHUE] ([MaPhieu], [SoXe], [MaKH], [NgayLapPhieu], [SoNgayMuon]) VALUES (N'P13 ', N'XE08', N'KH06', CAST(N'2017-10-11' AS Date), 1)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE  ', N'xe máy', N'sirus', 100000, N'An', 2011)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE01', N'xe máy', N'sirus', 100000, N'An', 2011)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE02', N'xe máy', N'exciter', 120000, N'Bình', 2012)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE04', N'xe tải', N'TBR', 1000000, N'Thịnh', 2011)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE05', N'xe tải2', N'RSX', 1200000, N'Tâm', 2009)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE06', N'xe 4 chổ', N'Kia-morning', 500000, N'Nhân', 2008)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE07', N'xe 5 chổ', N'Grande', 600000, N'Lực', 2012)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE08', N'xe 7 chổ', N'BMW-I9', 800000, N'Hiếu', 2015)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE09', N'xe 7 chổ', N'BMW-X1', 900000, N'Quốc', 2016)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE10', N'xe 7 chổ', N'BMW-X6', 1000000, N'Tín', 2017)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE11', N'xe khách', N'Mai Linh', 1500000, N'Bất', 2009)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE12', N'xe khách', N'universe', 1500000, N'Lực', 2014)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE13', N'xe khách', N'limousine', 1600000, N'MIT', 2017)
INSERT [dbo].[tbl_THONGTINXE] ([SoXe], [MaLoai], [TenXe], [DonGiaNgay], [ChuXe], [NamSX]) VALUES (N'XE14', N'xe tai', N'SRD', 120000, N'Bien', 2004)
SET IDENTITY_INSERT [dbo].[User_Login] ON 

INSERT [dbo].[User_Login] ([id], [TenDn], [Matkhau], [TenNhanVien], [SDT], [DiaChi], [Email], [Luong], [ChucVu]) VALUES (1, N'55nhatnam55', N'zxczxc11', N'Nguyễn Minh Thành', 395864625, N'BD', N'thanh@gmail.com', 500000, 1)
INSERT [dbo].[User_Login] ([id], [TenDn], [Matkhau], [TenNhanVien], [SDT], [DiaChi], [Email], [Luong], [ChucVu]) VALUES (2, N'canh', N'123', N'Minh Cảnh', 65895636, N'Campuchia', N'Canh@gmail.com', 400000, 2)
INSERT [dbo].[User_Login] ([id], [TenDn], [Matkhau], [TenNhanVien], [SDT], [DiaChi], [Email], [Luong], [ChucVu]) VALUES (4, N'money', N'123', N'Minh ', 65895636, N'Campuchia', N'money@gmail.com', 400000, 2)
INSERT [dbo].[User_Login] ([id], [TenDn], [Matkhau], [TenNhanVien], [SDT], [DiaChi], [Email], [Luong], [ChucVu]) VALUES (5, N'money', N'123', N'Minh 11', 65895636, N'Campuchia', N'money@gmail.com', 400000, 2)
INSERT [dbo].[User_Login] ([id], [TenDn], [Matkhau], [TenNhanVien], [SDT], [DiaChi], [Email], [Luong], [ChucVu]) VALUES (7, N'55nhatnam55', N'zxczxc11', N'Nguyễn Minh ', 395864625, N'BD', N'thanh@gmail.com', 500000, 1)
SET IDENTITY_INSERT [dbo].[User_Login] OFF
ALTER TABLE [dbo].[ChucVu]  WITH CHECK ADD  CONSTRAINT [FK_ChucVu_User_Login] FOREIGN KEY([IDchucvu])
REFERENCES [dbo].[User_Login] ([id])
GO
ALTER TABLE [dbo].[ChucVu] CHECK CONSTRAINT [FK_ChucVu_User_Login]
GO
ALTER TABLE [dbo].[tbl_LOAIXE]  WITH CHECK ADD  CONSTRAINT [FK_LOAIXE_BANGLAI] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[tbl_BANGLAI] ([LoaiXe])
GO
ALTER TABLE [dbo].[tbl_LOAIXE] CHECK CONSTRAINT [FK_LOAIXE_BANGLAI]
GO
ALTER TABLE [dbo].[tbl_PHIEUTHUE]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUE_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tbl_KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[tbl_PHIEUTHUE] CHECK CONSTRAINT [FK_PHIEUTHUE_KHACHHANG]
GO
ALTER TABLE [dbo].[tbl_PHIEUTHUE]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PHIEUTHUE_tbl_THONGTINXE] FOREIGN KEY([SoXe])
REFERENCES [dbo].[tbl_THONGTINXE] ([SoXe])
GO
ALTER TABLE [dbo].[tbl_PHIEUTHUE] CHECK CONSTRAINT [FK_tbl_PHIEUTHUE_tbl_THONGTINXE]
GO
USE [master]
GO
ALTER DATABASE [QL_Thuexeoto] SET  READ_WRITE 
GO
