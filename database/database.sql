USE [master]
GO
/****** Object:  Database [QUANLYNHANGHI]    Script Date: 04/25/2017 18:48:40 ******/
CREATE DATABASE [QUANLYNHANGHI] ON  PRIMARY 
( NAME = N'QUANLYNHANGHI', FILENAME = N'E:\QuanLyNhaNghi\database\QUANLYNHANGHI.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QUANLYNHANGHI_log', FILENAME = N'E:\QuanLyNhaNghi\database\QUANLYNHANGHI_log.LDF' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUANLYNHANGHI] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYNHANGHI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYNHANGHI] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET ARITHABORT OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET AUTO_CLOSE ON
GO
ALTER DATABASE [QUANLYNHANGHI] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QUANLYNHANGHI] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QUANLYNHANGHI] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QUANLYNHANGHI] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET  DISABLE_BROKER
GO
ALTER DATABASE [QUANLYNHANGHI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QUANLYNHANGHI] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QUANLYNHANGHI] SET  READ_WRITE
GO
ALTER DATABASE [QUANLYNHANGHI] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QUANLYNHANGHI] SET  MULTI_USER
GO
ALTER DATABASE [QUANLYNHANGHI] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QUANLYNHANGHI] SET DB_CHAINING OFF
GO
USE [QUANLYNHANGHI]
GO
/****** Object:  Table [dbo].[dichvu]    Script Date: 04/25/2017 18:48:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dichvu](
	[madichvu] [varchar](10) NOT NULL,
	[tendichvu] [nvarchar](100) NULL,
	[gia] [money] NULL,
	[donvitinh] [char](10) NULL,
 CONSTRAINT [PK_dichvu] PRIMARY KEY CLUSTERED 
(
	[madichvu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[dichvu] ([madichvu], [tendichvu], [gia], [donvitinh]) VALUES (N'DV0000001', N'CoCa', 1.0000, N'lon       ')
INSERT [dbo].[dichvu] ([madichvu], [tendichvu], [gia], [donvitinh]) VALUES (N'DV0000002', N'nước suối', 10.0000, N'lon       ')
INSERT [dbo].[dichvu] ([madichvu], [tendichvu], [gia], [donvitinh]) VALUES (N'DV0000003', N'mỳ', 100.0000, N'tô        ')
/****** Object:  Table [dbo].[nhanvien]    Script Date: 04/25/2017 18:48:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manhanvien] [varchar](10) NOT NULL,
	[tennhanvien] [nvarchar](50) NULL,
	[ngaysinh] [varchar](11) NULL,
	[phai] [bit] NULL,
	[diachi] [nvarchar](100) NULL,
	[phone] [varchar](11) NULL,
	[chucvu] [nvarchar](50) NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [phai], [diachi], [phone], [chucvu]) VALUES (N'NV01', N'Thiệu', N'06/04/1996', 1, N'Biên Hòa', N'01645408063', N'admin')
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [phai], [diachi], [phone], [chucvu]) VALUES (N'NV02', N'Phương', N'01011996', 1, N'Biên hòa', NULL, N'nhân viên')
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [phai], [diachi], [phone], [chucvu]) VALUES (N'NV03', N'Thi', N'01121996', 1, N'bienhoa', N'11', N'nhân viên')
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [phai], [diachi], [phone], [chucvu]) VALUES (N'NV04     ', N'tien', N'01021996', 1, N'biên hòa', N'01234', N'nhân viên')
/****** Object:  Table [dbo].[khachhang]    Script Date: 04/25/2017 18:48:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[khachhang](
	[makhachhang] [varchar](10) NOT NULL,
	[tenkhachhang] [nvarchar](50) NULL,
	[gioitinh] [bit] NULL,
	[cmnd_passport] [varchar](10) NULL,
	[diachi] [nvarchar](100) NULL,
	[sodienthoai] [varchar](11) NULL,
	[email] [varchar](50) NULL,
	[loaikhach] [nchar](10) NULL,
 CONSTRAINT [PK_Custumer] PRIMARY KEY CLUSTERED 
(
	[makhachhang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [cmnd_passport], [diachi], [sodienthoai], [email], [loaikhach]) VALUES (N'KH0000001', N'phương', 0, N'1', N'biên hòa', N'1', N'1', N'1         ')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [cmnd_passport], [diachi], [sodienthoai], [email], [loaikhach]) VALUES (N'KH0000002', N'Thiệu', 1, N'123456789', N'biên Hòa', N'01645408063', N'', N'đơn       ')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [cmnd_passport], [diachi], [sodienthoai], [email], [loaikhach]) VALUES (N'KH0000003', N'thi', 0, N'01234574', N'biên hòa', N'0123471622', N'', N'đơn       ')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [cmnd_passport], [diachi], [sodienthoai], [email], [loaikhach]) VALUES (N'KH0000004', N'hieu', 1, N'012346', N'bien hoa', N'016', N'', N'          ')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [cmnd_passport], [diachi], [sodienthoai], [email], [loaikhach]) VALUES (N'KH0000005', N'nhu', 1, N'01234', N'bien hòa', N'0151515', N'', N'          ')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [cmnd_passport], [diachi], [sodienthoai], [email], [loaikhach]) VALUES (N'KH0000006', N'hung', 1, N'2603036', N'biên hòa', N'2223', N'', N'đơn       ')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [cmnd_passport], [diachi], [sodienthoai], [email], [loaikhach]) VALUES (N'KH0000007', N'hoai', 1, N'0123469', N'bien hoa', N'02121215', N'', N'đơn       ')
/****** Object:  Table [dbo].[phong]    Script Date: 04/25/2017 18:48:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phong](
	[maphong] [varchar](10) NOT NULL,
	[loaiphong] [nvarchar](50) NOT NULL,
	[giaphong] [money] NULL,
	[trangthai] [nvarchar](50) NULL,
 CONSTRAINT [PK_phong] PRIMARY KEY CLUSTERED 
(
	[maphong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH001', N'Bình Dân', 100.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH002', N'Sinh Viên', 200.0000, N'Đã Nhận')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH003', N'Vip', 500.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH004', N'Bình Dân', 100.0000, N'Đã Nhận')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH005', N'Sinh Viên', 200.0000, N'Đã Đặt')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH006', N'Bình Dân', 100.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH007', N'Vip', 500.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH008', N'Vip', 100.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH009', N'Bình Dân', 200.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH010', N'Vip', 100.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH011', N'Vip', 500.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH012', N'Bình Dân', 200.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH013', N'Vip', 1000.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH014', N'Vip', 1000.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH015', N'Bình Dân', 100.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH016', N'Vip', 500.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH017', N'Bình Dân', 100.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH018', N'Bình Dân', 100.0000, N'Đã Nhận')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH019', N'Vip', 500.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH020', N'Vip', 500.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH021', N'Vip', 500.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH022', N'Vip', 500.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH023', N'Sinh Viên', 100.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH024', N'Sinh Viên', 100.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH025', N'Sinh Viên', 200.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH026', N'Bình Dân', 300.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH027', N'Vip', 2000.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH028', N'Bình Dân', 400.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH029', N'Bình Dân', 300.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH030', N'Bình Dân', 500.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH031', N'Bình Dân', 200.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH032', N'Bình Dân', 100.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH033', N'Sinh Viên', 200.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH034', N'Vip', 500.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH035', N'Bình Dân', 500.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH036', N'Bình Dân', 300.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH037', N'Bình Dân', 200.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH038', N'Vip', 500.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH039', N'Vip', 200.0000, N'Trống')
INSERT [dbo].[phong] ([maphong], [loaiphong], [giaphong], [trangthai]) VALUES (N'PH040', N'Vip', 1000.0000, N'Trống')
/****** Object:  Table [dbo].[phieudatphong]    Script Date: 04/25/2017 18:48:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phieudatphong](
	[maphieudat] [varchar](10) NOT NULL,
	[makhachhang] [varchar](10) NOT NULL,
	[username] [varchar](10) NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[maphieudat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[phieudatphong] ([maphieudat], [makhachhang], [username]) VALUES (N'PDP001', N'KH0000001', N'admin')
INSERT [dbo].[phieudatphong] ([maphieudat], [makhachhang], [username]) VALUES (N'PDP002', N'KH0000002', N'admin')
INSERT [dbo].[phieudatphong] ([maphieudat], [makhachhang], [username]) VALUES (N'PDP003', N'KH0000001', N'admin')
INSERT [dbo].[phieudatphong] ([maphieudat], [makhachhang], [username]) VALUES (N'PDP004', N'KH0000003', N'admin')
INSERT [dbo].[phieudatphong] ([maphieudat], [makhachhang], [username]) VALUES (N'PDP005', N'KH0000006', N'admin')
INSERT [dbo].[phieudatphong] ([maphieudat], [makhachhang], [username]) VALUES (N'PDP006', N'KH0000005', N'admin')
INSERT [dbo].[phieudatphong] ([maphieudat], [makhachhang], [username]) VALUES (N'PDP007', N'KH0000007', N'admin')
/****** Object:  Table [dbo].[hethong]    Script Date: 04/25/2017 18:48:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hethong](
	[username] [varchar](10) NOT NULL,
	[manhanvien] [varchar](10) NULL,
	[password] [varchar](200) NULL,
	[loaitaikhoan] [int] NULL,
 CONSTRAINT [PK_system] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[hethong] ([username], [manhanvien], [password], [loaitaikhoan]) VALUES (N'admin', N'NV01', N'admin', 1)
INSERT [dbo].[hethong] ([username], [manhanvien], [password], [loaitaikhoan]) VALUES (N'phuong', N'NV02', N'12345678', 2)
INSERT [dbo].[hethong] ([username], [manhanvien], [password], [loaitaikhoan]) VALUES (N'Thi', N'NV03', N'12345678', 1)
/****** Object:  StoredProcedure [dbo].[sp_giaphong]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_giaphong]
@maphong varchar(10)
as
select giaphong
from phong
where maphong=@maphong
GO
/****** Object:  StoredProcedure [dbo].[sp_DichVu_SelectIDMax]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DichVu_SelectIDMax]
as
select isnull(max(Convert(int,substring(madichvu,3,9))),0)+1 as madichvu 
from dichvu
GO
/****** Object:  StoredProcedure [dbo].[sp_DichVu_Delete]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DichVu_Delete]
@madichvu char(9)
as
delete dichvu
where madichvu=@madichvu
GO
/****** Object:  StoredProcedure [dbo].[psp_Phong_Select_TT_Loai]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[psp_Phong_Select_TT_Loai] 
@trangthai nvarchar (50),
@loaiphong nvarchar (50)
as select ROW_NUMBER() over (order by (select 1))
 as STT,maphong,loaiphong, trangthai, giaphong 
 from phong where trangthai=@trangthai and loaiphong=@loaiphong
GO
/****** Object:  StoredProcedure [dbo].[psp_Phong_Select_TT]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[psp_Phong_Select_TT] 
@trangthai nvarchar (50)
as select ROW_NUMBER() over (order by (select 1))
 as STT,maphong,loaiphong, trangthai, giaphong 
 from phong where trangthai=@trangthai
GO
/****** Object:  StoredProcedure [dbo].[psp_Phong_Select_TheoLoai]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[psp_Phong_Select_TheoLoai]
@loaiphong nvarchar (50)
as select ROW_NUMBER() over (order by (select 1)) as STT,maphong,loaiphong, trangthai, giaphong from phong where loaiphong=@loaiphong
GO
/****** Object:  StoredProcedure [dbo].[PSP_Phong_Select]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PSP_Phong_Select]
as
select  ROW_NUMBER() over (order by (select 1)) as STT,maphong,loaiphong, trangthai, giaphong,0 as Xoa
from phong
GO
/****** Object:  StoredProcedure [dbo].[PSP_Phong_Insert_Update]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PSP_Phong_Insert_Update]
@maphong nvarchar(10),
@maloai nvarchar(100),
@trangthai nvarchar(50),
@giaphong money
as
if exists (select 1 from phong where maphong=@maphong)
begin
	update phong
	set 
	 loaiphong=@maloai,
	 trangthai=@trangthai,
	 giaphong=@giaphong
	 where maphong=@maphong		
end
else
begin
	insert into phong(maphong, loaiphong, trangthai, giaphong)
	values(@maphong, @maloai, @trangthai, @giaphong)
end
GO
/****** Object:  StoredProcedure [dbo].[PSP_DichVu_Select]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PSP_DichVu_Select]
as
select  ROW_NUMBER() over (order by (select 1)) as STT, madichvu, tendichvu, gia, donvitinh,0 as Xoa
from DichVu
GO
/****** Object:  StoredProcedure [dbo].[PSP_DichVu_Insert_Update]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PSP_DichVu_Insert_Update]
@madichvu nvarchar(10),
@tendichvu nvarchar(100),
@gia money,
@donvitinh char(10)
as
if exists (select 1 from dichvu where madichvu=@madichvu)
begin
	update dichvu
	set 
	 tendichvu=@tendichvu,
	 gia=@gia,
	 donvitinh=@donvitinh
	 where madichvu=@madichvu		
end
else
begin
	insert into dichvu(madichvu, tendichvu, gia, donvitinh)
	values(@madichvu, @tendichvu, @gia, @donvitinh)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_SelectIDMax]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_KhachHang_SelectIDMax]
as
select isnull(max(Convert(int,substring(makhachhang,3,9))),0)+1 as MaKH 
from KhachHang
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Select]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_KhachHang_Select]
as
select ROW_NUMBER() over (order by (select 1)) as STT,makhachhang, tenkhachhang,gioitinh,cmnd_passport,diachi, sodienthoai,email,loaikhach,0 as Xoa
from KhachHang
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Inser_Update]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_KhachHang_Inser_Update]
@MaKhachHang char(9), 
@TenKhachHang nvarchar(15), 
@GioiTinh bit, 
@CMND nvarchar(20), 
@DiaChi nvarchar(200),
@SoDienThoai varchar(20),
@Email nvarchar(50), 
@LoaiKhach nvarchar(50)
as
if exists (select 1 from KhachHang where makhachhang=@MaKhachHang)
begin
	update KhachHang
	set 
	 tenkhachhang=@TenKhachHang, 
	 gioitinh=@GioiTinh, 
	 cmnd_passport=@CMND, 
	 diachi=@DiaChi, 
	 sodienthoai=@SoDienThoai,
	 email=@Email,
	 loaikhach=@LoaiKhach
	 where makhachhang=@MaKhachHang
		
end
else
begin
	insert into KhachHang(makhachhang, tenkhachhang, gioitinh, cmnd_passport, diachi, sodienthoai, email, loaikhach)
	values(@MaKhachHang,@TenKhachHang,@GioiTinh,@CMND,@DiaChi,@SoDienThoai,@Email,@LoaiKhach)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Delete]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_KhachHang_Delete]
@makhachhang char(9)
as
delete khachhang
where makhachhang=@makhachhang
GO
/****** Object:  StoredProcedure [dbo].[sp_KTTrangthai]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_KTTrangthai]
@maphong varchar(10)
as
select trangthai from phong where maphong=@maphong
GO
/****** Object:  StoredProcedure [dbo].[sp_kiemtratinhtrang]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_kiemtratinhtrang]
@maphong varchar(10)
as
select trangthai from phong where maphong=@maphong
GO
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_SelectIDMax]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_NhanVien_SelectIDMax]
as
select isnull(max(Convert(int,substring(manhanvien,3,9))),0)+1 as manhanvien 
from nhanvien
GO
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_Select]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_NhanVien_Select]
as
select ROW_NUMBER() over (order by (select 1)) as STT,manhanvien, tennhanvien, ngaysinh, phai, diachi, phone, chucvu,0 as Xoa
from nhanvien
GO
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_Inser_Update]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_NhanVien_Inser_Update]
@manhanvien char(9), 
@tennhanvien nvarchar(15), 
@ngaysinh nvarchar(11), 
@phai bit, 
@diachi nvarchar(100),
@phone varchar(20),
@chucvu nvarchar(50)
as
if exists (select 1 from nhanvien where manhanvien=@manhanvien)
begin
	update nhanvien
	set 
	 tennhanvien=@tennhanvien, 
	 ngaysinh=@ngaysinh, 
	 phai=@phai, 
	 diachi=@diachi,
	 phone=@phone,
	 chucvu=@chucvu
	 where manhanvien=@manhanvien
		
end
else
begin
	insert into nhanvien(manhanvien, tennhanvien, ngaysinh, phai, diachi, phone, chucvu)
	values(@manhanvien, @tennhanvien, @ngaysinh, @phai, @diachi, @phone, @chucvu)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_Delete]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_NhanVien_Delete]
@manhanvien char(9)
as
delete nhanvien
where manhanvien=@manhanvien
GO
/****** Object:  StoredProcedure [dbo].[sp_loaiphong]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_loaiphong]
as
select distinct loaiphong from phong
GO
/****** Object:  StoredProcedure [dbo].[sp_Phong_SelectIDMax]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Phong_SelectIDMax]
as
select isnull(max(Convert(int,substring(maphong,3,9))),0)+1 as maphong 
from phong
GO
/****** Object:  StoredProcedure [dbo].[sp_Phong_Delete]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Phong_Delete]
@maphong char(9)
as
delete phong
where maphong=@maphong
GO
/****** Object:  Table [dbo].[sudungdichvu]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sudungdichvu](
	[masudung] [varchar](10) NOT NULL,
	[madichvu] [varchar](10) NULL,
	[soluong] [int] NULL,
	[maphieuthue] [varchar](10) NULL,
 CONSTRAINT [PK_sudungdichvu] PRIMARY KEY CLUSTERED 
(
	[masudung] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[sudungdichvu] ([masudung], [madichvu], [soluong], [maphieuthue]) VALUES (N'DDV00001', N'DV0000001', 10, N'PT0001')
INSERT [dbo].[sudungdichvu] ([masudung], [madichvu], [soluong], [maphieuthue]) VALUES (N'DDV00002', N'DV0000002', 10, N'PT0001')
/****** Object:  StoredProcedure [dbo].[sp_ThemDungDV]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemDungDV] 
@masudung varchar(10),
@madichvu varchar(10), 
@soluong int ,
@maphieuthue varchar(10)
as
insert into sudungdichvu(masudung, madichvu, soluong, maphieuthue) values (@masudung,@madichvu,@soluong,@maphieuthue)
GO
/****** Object:  StoredProcedure [dbo].[sp_updateht]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_updateht]
@username varchar(10)
as
update hethong set password='12345678' where username=@username
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDungDV]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdateDungDV] 
@masudung varchar(10),
@madichvu varchar(10), 
@soluong int ,
@maphieuthue varchar(10)
as
update sudungdichvu set madichvu=@madichvu,soluong=@soluong ,maphieuthue=@maphieuthue where masudung=@masudung
GO
/****** Object:  StoredProcedure [dbo].[sp_tiendichvu]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_tiendichvu] 
@maphieuthue varchar(10)
as
select sum(soluong*gia) as thanhtien
from dichvu inner join sudungdichvu
on dichvu.madichvu=sudungdichvu.madichvu
where maphieuthue=@maphieuthue
GO
/****** Object:  StoredProcedure [dbo].[sp_ThongKeDV]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThongKeDV]
as
select masudung,tendichvu,soluong,gia,(soluong*gia)as tong
from sudungdichvu inner join dichvu
on sudungdichvu.madichvu=dichvu.madichvu
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectDungDV]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SelectDungDV]
as
select * from sudungdichvu
GO
/****** Object:  StoredProcedure [dbo].[sp_quyen]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_quyen]
@username varchar(10)
as
select username,loaitaikhoan
from hethong
where username=@username
GO
/****** Object:  StoredProcedure [dbo].[sp_selectNVHT]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_selectNVHT]
as
select nhanvien.manhanvien,tennhanvien
from nhanvien
where manhanvien not in (select manhanvien from hethong)
GO
/****** Object:  StoredProcedure [dbo].[sp_selectnguoidung]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_selectnguoidung]
as
select username,tennhanvien,nhanvien.manhanvien,loaitaikhoan from hethong inner join nhanvien
on nhanvien.manhanvien=hethong.manhanvien
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuDangKy_SelectIDMax]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PhieuDangKy_SelectIDMax]
as
select isnull(max(Convert(int,substring(maphieudat,4,6))),0)+1 as maphieudat 
from phieudatphong
GO
/****** Object:  StoredProcedure [dbo].[sp_insertht]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertht]
@username varchar(10),
@manhavien varchar(10),
@loaitaikhoan int
as
insert into hethong (username, manhanvien, password, loaitaikhoan)
values (@username,@manhavien,'12345678',@loaitaikhoan)
GO
/****** Object:  StoredProcedure [dbo].[SP_KiemTraDangNhap]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_KiemTraDangNhap] 
@TaiKhoan varchar(20),
@MatKhau varchar(20)
as
if exists (select 1 from hethong where username=@TaiKhoan and password=@MatKhau)
	select 1 as mathongbao,N'Đăng nhập thành công' as ndthongbao,hethong.manhanvien,tennhanvien as hoten from nhanvien,hethong where username=@TaiKhoan and password=@MatKhau
	else
	select 0 as mathongbao,N'Đăng nhập không thành công' as ndthongbao
GO
/****** Object:  Table [dbo].[chitietdatphong]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chitietdatphong](
	[maphieudat] [varchar](10) NOT NULL,
	[maphong] [varchar](10) NOT NULL,
	[tinhtrang] [nvarchar](50) NULL,
	[ngayden] [datetime] NULL,
	[ngaydi] [datetime] NULL,
	[tiendatcoc] [money] NULL,
	[songuoi] [int] NULL,
 CONSTRAINT [PK_chitietdondatphong] PRIMARY KEY CLUSTERED 
(
	[maphieudat] ASC,
	[maphong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[chitietdatphong] ([maphieudat], [maphong], [tinhtrang], [ngayden], [ngaydi], [tiendatcoc], [songuoi]) VALUES (N'PDP001', N'PH003', NULL, CAST(0x0000A758016C342C AS DateTime), CAST(0x0000A75B016C338C AS DateTime), 100.0000, 2)
INSERT [dbo].[chitietdatphong] ([maphieudat], [maphong], [tinhtrang], [ngayden], [ngaydi], [tiendatcoc], [songuoi]) VALUES (N'PDP002', N'PH002', NULL, CAST(0x0000A75A0134EE12 AS DateTime), CAST(0x0000A75C0134ED28 AS DateTime), 100.0000, 1)
INSERT [dbo].[chitietdatphong] ([maphieudat], [maphong], [tinhtrang], [ngayden], [ngaydi], [tiendatcoc], [songuoi]) VALUES (N'PDP004', N'PH005', NULL, CAST(0x0000A75D00985144 AS DateTime), CAST(0x0000A765009850F8 AS DateTime), 100.0000, 1)
/****** Object:  StoredProcedure [dbo].[sp_deleteht]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_deleteht]
@username varchar(10)
as
delete hethong where username=@username
GO
/****** Object:  StoredProcedure [dbo].[sp_DungDV_SelectIDMax]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DungDV_SelectIDMax]
as
select isnull(max(Convert(int,substring(masudung,4,8))),0)+1 as masudungdv
from sudungdichvu
GO
/****** Object:  StoredProcedure [dbo].[sp_DoiMatKhau]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_DoiMatKhau]
@TaiKhoan varchar(10),
@MatKhauCu varchar(200),
@MatKhauMoi varchar(200)
as
begin 
	update hethong set password=@MatKhauMoi where username=@TaiKhoan and password=@MatKhauCu
end
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteDungDV]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_deleteDungDV] 
@masudung varchar(10)
as
delete sudungdichvu where masudung=@masudung
GO
/****** Object:  Table [dbo].[phieuthuephong]    Script Date: 04/25/2017 18:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phieuthuephong](
	[maphieuthue] [varchar](10) NOT NULL,
	[maphieudat] [varchar](10) NULL,
	[username] [varchar](10) NULL,
	[tinhtrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_phieuthuephong] PRIMARY KEY CLUSTERED 
(
	[maphieuthue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[phieuthuephong] ([maphieuthue], [maphieudat], [username], [tinhtrang]) VALUES (N'PT0001', N'PDP001', N'admin', N'Đã Thanh Toán')
INSERT [dbo].[phieuthuephong] ([maphieuthue], [maphieudat], [username], [tinhtrang]) VALUES (N'PT0002', N'PDP003', N'admin', N'Đã Thanh Toán')
INSERT [dbo].[phieuthuephong] ([maphieuthue], [maphieudat], [username], [tinhtrang]) VALUES (N'PT0003', N'PDP005', N'admin', N'Chưa Thanh Toán')
INSERT [dbo].[phieuthuephong] ([maphieuthue], [maphieudat], [username], [tinhtrang]) VALUES (N'PT0004', N'PDP006', N'admin', N'Chưa Thanh Toán')
INSERT [dbo].[phieuthuephong] ([maphieuthue], [maphieudat], [username], [tinhtrang]) VALUES (N'PT0005', N'PDP007', N'admin', N'Chưa Thanh Toán')
/****** Object:  UserDefinedFunction [dbo].[fn]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn] 
(@maphieuthue varchar(10))returns int
as
begin
	declare @kq int
	select @kq = sum(soluong*gia)
	from dichvu inner join sudungdichvu
	on dichvu.madichvu=sudungdichvu.madichvu
	where maphieuthue=@maphieuthue
	if(@kq = null)
		select @kq = 0;
	return @kq
end
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hoadon](
	[mahoadon] [varchar](10) NOT NULL,
	[ngaythanhtoan] [datetime] NOT NULL,
	[tongtien] [money] NULL,
	[maphieuthue] [varchar](10) NULL,
	[makhachhang] [varchar](10) NULL,
	[username] [varchar](10) NULL,
	[tienphong] [money] NULL,
	[tiendichvu] [money] NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[hoadon] ([mahoadon], [ngaythanhtoan], [tongtien], [maphieuthue], [makhachhang], [username], [tienphong], [tiendichvu]) VALUES (N'HD0001', CAST(0x0000A75700000000 AS DateTime), 1110.0000, N'PT0001', N'KH0000001', N'admin', 110.0000, 110.0000)
INSERT [dbo].[hoadon] ([mahoadon], [ngaythanhtoan], [tongtien], [maphieuthue], [makhachhang], [username], [tienphong], [tiendichvu]) VALUES (N'HD0002', CAST(0x0000A75F00000000 AS DateTime), 310.0000, N'PT0001', N'KH0000001', N'admin', 110.0000, 110.0000)
/****** Object:  Table [dbo].[chitietthuephong]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chitietthuephong](
	[maphieuthue] [varchar](10) NOT NULL,
	[maphong] [varchar](10) NOT NULL,
	[ngayden] [datetime] NULL,
	[ngaydi] [datetime] NULL,
 CONSTRAINT [PK_chitietthuephong] PRIMARY KEY CLUSTERED 
(
	[maphieuthue] ASC,
	[maphong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[chitietthuephong] ([maphieuthue], [maphong], [ngayden], [ngaydi]) VALUES (N'PT0001', N'PH003', CAST(0x0000A75A014C6F8D AS DateTime), NULL)
INSERT [dbo].[chitietthuephong] ([maphieuthue], [maphong], [ngayden], [ngaydi]) VALUES (N'PT0002', N'PH004', CAST(0x0000A75A016C2304 AS DateTime), NULL)
INSERT [dbo].[chitietthuephong] ([maphieuthue], [maphong], [ngayden], [ngaydi]) VALUES (N'PT0003', N'PH004', CAST(0x0000A76001098EFE AS DateTime), NULL)
INSERT [dbo].[chitietthuephong] ([maphieuthue], [maphong], [ngayden], [ngaydi]) VALUES (N'PT0004', N'PH002', CAST(0x0000A76001099EE7 AS DateTime), NULL)
INSERT [dbo].[chitietthuephong] ([maphieuthue], [maphong], [ngayden], [ngaydi]) VALUES (N'PT0005', N'PH018', CAST(0x0000A7600109A76E AS DateTime), NULL)
/****** Object:  StoredProcedure [dbo].[sp_deleteDatPhong]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_deleteDatPhong] 
@maphieudat varchar(10)
as
delete chitietdatphong where maphieudat=@maphieudat
delete phieudatphong where maphieudat=@maphieudat
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachhangTheoMa]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_KhachhangTheoMa]
@maphieuthue varchar(10)
as
select distinct tenkhachhang
from phieuthuephong inner join phieudatphong
on phieudatphong.maphieudat=phieuthuephong.maphieudat inner join khachhang
on khachhang.makhachhang=phieudatphong.makhachhang
where maphieuthue=@maphieuthue
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertPhieuDangKy]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertPhieuDangKy] 
@maphieudat varchar(10),
@makhachhang varchar(10),
@username varchar(10),
@maphong varchar(10), 
@ngayden datetime, 
@ngaydi datetime, 
@tiendatcoc money, 
@songuoi int
as
insert into phieudatphong values (@maphieudat,@makhachhang,@username)
insert into chitietdatphong(maphieudat, maphong,ngayden, ngaydi, tiendatcoc, songuoi) values (@maphieudat,@maphong,@ngayden,@ngaydi,@tiendatcoc,@songuoi)
GO
/****** Object:  StoredProcedure [dbo].[sp_layThongtinDatphong]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_layThongtinDatphong] 
@maphong varchar(10)
as
select phieudatphong.maphieudat,phieudatphong.makhachhang,maphong,ngayden
from phieudatphong inner join chitietdatphong 
on phieudatphong.maphieudat=chitietdatphong.maphieudat
where maphong=@maphong
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuThue_SelectIDMax]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PhieuThue_SelectIDMax]
as
select isnull(max(Convert(int,substring(maphieuthue,3,6))),0)+1 as maphieudat 
from phieuthuephong
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuDangKy_Inser_Update]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PhieuDangKy_Inser_Update]
@maphieudat varchar(10), 
@makhachhang varchar(10), 
@username varchar(10), 
@maphong varchar(10), 
@ngayden datetime,
@ngaydi datetime,
@tiendatcoc money,
@songuoi int
as
if exists (select 1 from phieudatphong where maphieudat=@maphieudat)
begin
	update phieudatphong
	set 
		makhachhang=@makhachhang,
		username=@username 
	 where maphieudat=@maphieudat
	update chitietdatphong
	set
	maphong=@maphong,
	ngayden=@ngayden,
	ngaydi=@ngaydi,
	tiendatcoc=@tiendatcoc,
	songuoi=@songuoi
	where maphieudat=@maphieudat	
end
else
begin
	insert into phieudatphong(maphieudat, makhachhang, username)
	values (@maphieudat,@makhachhang,@username)
	insert into chitietdatphong (maphieudat, maphong, ngayden, ngaydi, tiendatcoc, songuoi)
	values(@maphieudat,@maphong,@ngayden,@ngaydi,@tiendatcoc,@songuoi)
	update phong set trangthai=N'Đã Đặt' where maphong=@maphong
end
GO
/****** Object:  StoredProcedure [dbo].[sp_selectPhieuDangKy]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_selectPhieuDangKy] 
as
select ROW_NUMBER() over (order by (select 1)) as STT,phieudatphong.maphieudat,phieudatphong.makhachhang,maphong,ngayden,ngaydi,songuoi,tiendatcoc,tenkhachhang
from phieudatphong inner join chitietdatphong on phieudatphong.maphieudat=chitietdatphong.maphieudat inner join khachhang on khachhang.makhachhang=phieudatphong.makhachhang
GO
/****** Object:  StoredProcedure [dbo].[sp_maphieu]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_maphieu]
as
select maphieuthue
from phieuthuephong
where tinhtrang=N'Chưa Thanh Toán'
GO
/****** Object:  StoredProcedure [dbo].[sp_suahoadon]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suahoadon]
@mahoadon varchar(10),
 @ngaythanhtoan datetime,
 @tongtien money,
 @maphieuthue varchar(10),
 @makhachhang money,
  @username varchar(10) , 
  @tienphong money,
  @tiendichvu money,
 @maphong varchar(10)
as
update hoadon set ngaythanhtoan=@ngaythanhtoan,tongtien=@tongtien, makhachhang=@makhachhang,tiendichvu=@tiendichvu,tienphong=@tienphong
where mahoadon=@mahoadon
GO
/****** Object:  StoredProcedure [dbo].[sp_selectTTPhieuThue]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_selectTTPhieuThue] 
@maphong varchar(10)
as
select distinct phieuthuephong.maphieuthue,phieuthuephong.maphieudat,maphong,ngayden,phieudatphong.makhachhang,tenkhachhang
from phieuthuephong inner join chitietthuephong on phieuthuephong.maphieuthue=chitietthuephong.maphieuthue inner join phieudatphong 
on phieudatphong.maphieudat=phieuthuephong.maphieudat inner join khachhang on phieudatphong.makhachhang=khachhang.makhachhang
where phieudatphong.maphieudat=@maphong and tinhtrang=N'Chưa Thanh Toán'
GO
/****** Object:  StoredProcedure [dbo].[sp_selectPhieuThue]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_selectPhieuThue]
as
select distinct phieuthuephong.maphieuthue,phieuthuephong.maphieudat,maphong,ngayden,phieudatphong.makhachhang,tenkhachhang
from phieuthuephong inner join chitietthuephong on phieuthuephong.maphieuthue=chitietthuephong.maphieuthue inner join phieudatphong 
on phieudatphong.maphieudat=phieuthuephong.maphieudat inner join khachhang on phieudatphong.makhachhang=khachhang.makhachhang
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNhanPhong]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemNhanPhong]
@maphieuthue varchar(10), 
@maphieudat varchar(10), 
@username varchar(10),
@maphong varchar(10),
@ngayden datetime
as
insert into phieuthuephong(maphieuthue, maphieudat, username,tinhtrang)
values (@maphieuthue,@maphieudat,@username,N'Chưa Thanh Toán')
insert into chitietthuephong (maphieuthue, maphong, ngayden)
values (@maphieuthue,@maphong,@ngayden)
update phong set trangthai=N'Đã Nhận' where maphong=@maphong
GO
/****** Object:  StoredProcedure [dbo].[sp_themhoadon]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_themhoadon]
@mahoadon varchar(10),
 @ngaythanhtoan datetime,
 @tongtien money,
 @maphieuthue varchar(10),
 @makhachhang varchar(10),
  @username varchar(10) , 
  @tienphong money,
  @tiendichvu money,
 @maphong varchar(10)
as
insert into hoadon (mahoadon, ngaythanhtoan, tongtien, maphieuthue, makhachhang, username, tienphong, tiendichvu)
values (@mahoadon,@ngaythanhtoan,@tongtien,@maphieuthue,@makhachhang,@username,@tiendichvu,@tiendichvu)
update phong set trangthai=N'Trống' where maphong=@maphong
update phieuthuephong set tinhtrang=N'Đã Thanh Toán' where maphieuthue=@maphieuthue
GO
/****** Object:  StoredProcedure [dbo].[sp_selectHoaDon]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_selectHoaDon] 
as
select hoadon.*,tenkhachhang from hoadon inner join khachhang on hoadon.makhachhang=khachhang.makhachhang
GO
/****** Object:  StoredProcedure [dbo].[sp_PhongTheoMa]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PhongTheoMa] 
@maphieuthue varchar(10)
as
select maphong
from chitietthuephong
where maphieuthue=@maphieuthue
GO
/****** Object:  StoredProcedure [dbo].[sp_ngaythue]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ngaythue]
@maphieuthue varchar(10)
as
SELECT ngayden as ngay from chitietthuephong where maphieuthue=@maphieuthue
GO
/****** Object:  StoredProcedure [dbo].[sp_InHoaDon]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InHoaDon]
@mahoadon varchar(10)
as
select mahoadon,maphieuthue as maphieu,tenkhachhang,tienphong,tiendichvu,tongtien
from hoadon inner join khachhang 
on hoadon.makhachhang=khachhang.makhachhang
where mahoadon=@mahoadon
GO
/****** Object:  StoredProcedure [dbo].[sp_Hoadon_SelectIDMax]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Hoadon_SelectIDMax]
as
select isnull(max(Convert(int,substring(mahoadon,3,9))),0)+1 as mahoadon
from hoadon
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertNhanPhong]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertNhanPhong]
@maphieuthue varchar(10), 
@maphieudat varchar(10), 
@username varchar(10),
@maphong varchar(10),
@ngayden datetime,
@makhachhang varchar(10)
as
insert into phieudatphong(maphieudat, makhachhang, username)
values (@maphieudat,@makhachhang,@username)
insert into phieuthuephong(maphieuthue, maphieudat, username,tinhtrang)
values (@maphieuthue,@maphieudat,@username,N'Chưa Thanh Toán')
insert into chitietthuephong (maphieuthue, maphong, ngayden)
values (@maphieuthue,@maphong,@ngayden)
update phong set trangthai=N'Đã Nhận' where maphong=@maphong
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteHoaDon]    Script Date: 04/25/2017 18:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_deleteHoaDon]
@mahoadon varchar(10)
as
delete hoadon where mahoadon=@mahoadon
GO
/****** Object:  ForeignKey [FK_phieudatphong_khachhang]    Script Date: 04/25/2017 18:48:41 ******/
ALTER TABLE [dbo].[phieudatphong]  WITH CHECK ADD  CONSTRAINT [FK_phieudatphong_khachhang] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[khachhang] ([makhachhang])
GO
ALTER TABLE [dbo].[phieudatphong] CHECK CONSTRAINT [FK_phieudatphong_khachhang]
GO
/****** Object:  ForeignKey [FK_hethong_nhanvien]    Script Date: 04/25/2017 18:48:41 ******/
ALTER TABLE [dbo].[hethong]  WITH CHECK ADD  CONSTRAINT [FK_hethong_nhanvien] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([manhanvien])
GO
ALTER TABLE [dbo].[hethong] CHECK CONSTRAINT [FK_hethong_nhanvien]
GO
/****** Object:  ForeignKey [FK_sudungdichvu_dichvu]    Script Date: 04/25/2017 18:48:42 ******/
ALTER TABLE [dbo].[sudungdichvu]  WITH CHECK ADD  CONSTRAINT [FK_sudungdichvu_dichvu] FOREIGN KEY([madichvu])
REFERENCES [dbo].[dichvu] ([madichvu])
GO
ALTER TABLE [dbo].[sudungdichvu] CHECK CONSTRAINT [FK_sudungdichvu_dichvu]
GO
/****** Object:  ForeignKey [FK_chitietdatphong_phieudatphong]    Script Date: 04/25/2017 18:48:42 ******/
ALTER TABLE [dbo].[chitietdatphong]  WITH CHECK ADD  CONSTRAINT [FK_chitietdatphong_phieudatphong] FOREIGN KEY([maphieudat])
REFERENCES [dbo].[phieudatphong] ([maphieudat])
GO
ALTER TABLE [dbo].[chitietdatphong] CHECK CONSTRAINT [FK_chitietdatphong_phieudatphong]
GO
/****** Object:  ForeignKey [FK_chitietdatphong_phong]    Script Date: 04/25/2017 18:48:42 ******/
ALTER TABLE [dbo].[chitietdatphong]  WITH CHECK ADD  CONSTRAINT [FK_chitietdatphong_phong] FOREIGN KEY([maphong])
REFERENCES [dbo].[phong] ([maphong])
GO
ALTER TABLE [dbo].[chitietdatphong] CHECK CONSTRAINT [FK_chitietdatphong_phong]
GO
/****** Object:  ForeignKey [FK_phieuthuephong_hethong1]    Script Date: 04/25/2017 18:48:42 ******/
ALTER TABLE [dbo].[phieuthuephong]  WITH CHECK ADD  CONSTRAINT [FK_phieuthuephong_hethong1] FOREIGN KEY([username])
REFERENCES [dbo].[hethong] ([username])
GO
ALTER TABLE [dbo].[phieuthuephong] CHECK CONSTRAINT [FK_phieuthuephong_hethong1]
GO
/****** Object:  ForeignKey [FK_phieuthuephong_phieudatphong]    Script Date: 04/25/2017 18:48:42 ******/
ALTER TABLE [dbo].[phieuthuephong]  WITH CHECK ADD  CONSTRAINT [FK_phieuthuephong_phieudatphong] FOREIGN KEY([maphieudat])
REFERENCES [dbo].[phieudatphong] ([maphieudat])
GO
ALTER TABLE [dbo].[phieuthuephong] CHECK CONSTRAINT [FK_phieuthuephong_phieudatphong]
GO
/****** Object:  ForeignKey [FK_hoadon_khachhang]    Script Date: 04/25/2017 18:48:43 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_khachhang] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[khachhang] ([makhachhang])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_khachhang]
GO
/****** Object:  ForeignKey [FK_hoadon_phieuthuephong]    Script Date: 04/25/2017 18:48:43 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_phieuthuephong] FOREIGN KEY([maphieuthue])
REFERENCES [dbo].[phieuthuephong] ([maphieuthue])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_phieuthuephong]
GO
/****** Object:  ForeignKey [FK_chitietthuephong_phieuthuephong1]    Script Date: 04/25/2017 18:48:43 ******/
ALTER TABLE [dbo].[chitietthuephong]  WITH CHECK ADD  CONSTRAINT [FK_chitietthuephong_phieuthuephong1] FOREIGN KEY([maphieuthue])
REFERENCES [dbo].[phieuthuephong] ([maphieuthue])
GO
ALTER TABLE [dbo].[chitietthuephong] CHECK CONSTRAINT [FK_chitietthuephong_phieuthuephong1]
GO
/****** Object:  ForeignKey [FK_chitietthuephong_phong1]    Script Date: 04/25/2017 18:48:43 ******/
ALTER TABLE [dbo].[chitietthuephong]  WITH CHECK ADD  CONSTRAINT [FK_chitietthuephong_phong1] FOREIGN KEY([maphong])
REFERENCES [dbo].[phong] ([maphong])
GO
ALTER TABLE [dbo].[chitietthuephong] CHECK CONSTRAINT [FK_chitietthuephong_phong1]
GO
