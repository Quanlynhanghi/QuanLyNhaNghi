USE [QUANLYNHANGHI]
GO
/****** Object:  Table [dbo].[phong]    Script Date: 03/22/2017 10:44:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phong](
	[maphong] [varchar](10) NOT NULL,
	[maloai] [nvarchar](50) NOT NULL,
	[dadat] [bit] NULL,
	[danhan] [bit] NULL,
	[trangthai] [nvarchar](20) NULL,
	[dichvu] [nvarchar](50) NULL,
 CONSTRAINT [PK_phong] PRIMARY KEY CLUSTERED 
(
	[maphong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 03/22/2017 10:44:32 ******/
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
/****** Object:  Table [dbo].[khachhang]    Script Date: 03/22/2017 10:44:32 ******/
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
/****** Object:  Table [dbo].[dichvu]    Script Date: 03/22/2017 10:44:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dichvu](
	[madichvu] [nvarchar](10) NOT NULL,
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
/****** Object:  Table [dbo].[hethong]    Script Date: 03/22/2017 10:44:32 ******/
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
/****** Object:  Table [dbo].[chitietdatphong]    Script Date: 03/22/2017 10:44:32 ******/
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
 CONSTRAINT [PK_chitietdondatphong] PRIMARY KEY CLUSTERED 
(
	[maphieudat] ASC,
	[maphong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[phieudatphong]    Script Date: 03/22/2017 10:44:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phieudatphong](
	[maphieudat] [varchar](10) NOT NULL,
	[makhachhang] [varchar](10) NOT NULL,
	[ngayden] [datetime] NULL,
	[ngaydi] [datetime] NULL,
	[sotiendatcoc] [money] NULL,
	[username] [varchar](10) NULL,
	[tinhtrang] [varchar](10) NULL,
	[songuoi] [int] NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[maphieudat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[phieuthuephong]    Script Date: 03/22/2017 10:44:32 ******/
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
 CONSTRAINT [PK_phieuthuephong] PRIMARY KEY CLUSTERED 
(
	[maphieuthue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 03/22/2017 10:44:32 ******/
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
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[chitietthuephong]    Script Date: 03/22/2017 10:44:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chitietthuephong](
	[maphieuthue] [varchar](10) NOT NULL,
	[maphong] [varchar](10) NOT NULL,
	[ngay] [datetime] NOT NULL,
	[madichvu] [nvarchar](10) NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_chitietthuephong] PRIMARY KEY CLUSTERED 
(
	[maphieuthue] ASC,
	[maphong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_chitietdatphong_phong]    Script Date: 03/22/2017 10:44:32 ******/
ALTER TABLE [dbo].[chitietdatphong]  WITH CHECK ADD  CONSTRAINT [FK_chitietdatphong_phong] FOREIGN KEY([maphong])
REFERENCES [dbo].[phong] ([maphong])
GO
ALTER TABLE [dbo].[chitietdatphong] CHECK CONSTRAINT [FK_chitietdatphong_phong]
GO
/****** Object:  ForeignKey [FK_chitietthuephong_dichvu]    Script Date: 03/22/2017 10:44:32 ******/
ALTER TABLE [dbo].[chitietthuephong]  WITH CHECK ADD  CONSTRAINT [FK_chitietthuephong_dichvu] FOREIGN KEY([madichvu])
REFERENCES [dbo].[dichvu] ([madichvu])
GO
ALTER TABLE [dbo].[chitietthuephong] CHECK CONSTRAINT [FK_chitietthuephong_dichvu]
GO
/****** Object:  ForeignKey [FK_chitietthuephong_phieuthuephong]    Script Date: 03/22/2017 10:44:32 ******/
ALTER TABLE [dbo].[chitietthuephong]  WITH CHECK ADD  CONSTRAINT [FK_chitietthuephong_phieuthuephong] FOREIGN KEY([maphieuthue])
REFERENCES [dbo].[phieuthuephong] ([maphieuthue])
GO
ALTER TABLE [dbo].[chitietthuephong] CHECK CONSTRAINT [FK_chitietthuephong_phieuthuephong]
GO
/****** Object:  ForeignKey [FK_chitietthuephong_phong]    Script Date: 03/22/2017 10:44:32 ******/
ALTER TABLE [dbo].[chitietthuephong]  WITH CHECK ADD  CONSTRAINT [FK_chitietthuephong_phong] FOREIGN KEY([maphieuthue])
REFERENCES [dbo].[phong] ([maphong])
GO
ALTER TABLE [dbo].[chitietthuephong] CHECK CONSTRAINT [FK_chitietthuephong_phong]
GO
/****** Object:  ForeignKey [FK_hethong_nhanvien]    Script Date: 03/22/2017 10:44:32 ******/
ALTER TABLE [dbo].[hethong]  WITH CHECK ADD  CONSTRAINT [FK_hethong_nhanvien] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([manhanvien])
GO
ALTER TABLE [dbo].[hethong] CHECK CONSTRAINT [FK_hethong_nhanvien]
GO
/****** Object:  ForeignKey [FK_hoadon_khachhang]    Script Date: 03/22/2017 10:44:32 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_khachhang] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[khachhang] ([makhachhang])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_khachhang]
GO
/****** Object:  ForeignKey [FK_hoadon_phieuthuephong]    Script Date: 03/22/2017 10:44:32 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_phieuthuephong] FOREIGN KEY([maphieuthue])
REFERENCES [dbo].[phieuthuephong] ([maphieuthue])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_phieuthuephong]
GO
/****** Object:  ForeignKey [FK_phieudatphong_khachhang]    Script Date: 03/22/2017 10:44:32 ******/
ALTER TABLE [dbo].[phieudatphong]  WITH CHECK ADD  CONSTRAINT [FK_phieudatphong_khachhang] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[khachhang] ([makhachhang])
GO
ALTER TABLE [dbo].[phieudatphong] CHECK CONSTRAINT [FK_phieudatphong_khachhang]
GO
/****** Object:  ForeignKey [FK_phieuthuephong_hethong]    Script Date: 03/22/2017 10:44:32 ******/
ALTER TABLE [dbo].[phieuthuephong]  WITH CHECK ADD  CONSTRAINT [FK_phieuthuephong_hethong] FOREIGN KEY([maphieudat])
REFERENCES [dbo].[hethong] ([username])
GO
ALTER TABLE [dbo].[phieuthuephong] CHECK CONSTRAINT [FK_phieuthuephong_hethong]
GO
/****** Object:  ForeignKey [FK_phieuthuephong_phieudatphong]    Script Date: 03/22/2017 10:44:32 ******/
ALTER TABLE [dbo].[phieuthuephong]  WITH CHECK ADD  CONSTRAINT [FK_phieuthuephong_phieudatphong] FOREIGN KEY([maphieudat])
REFERENCES [dbo].[phieudatphong] ([maphieudat])
GO
ALTER TABLE [dbo].[phieuthuephong] CHECK CONSTRAINT [FK_phieuthuephong_phieudatphong]
GO
