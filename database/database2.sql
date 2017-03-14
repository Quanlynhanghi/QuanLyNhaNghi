USE [QUANLYNHANGHI]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 02/28/2017 19:22:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manhanvien] [varchar](10) NOT NULL,
	[tennhanvien] [nvarchar](50) NULL,
	[ngaysinh] [datetime] NULL,
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
/****** Object:  Table [dbo].[loaiphong]    Script Date: 02/28/2017 19:22:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaiphong](
	[maloai] [nvarchar](50) NOT NULL,
	[loaiphong] [nvarchar](50) NULL,
	[thietbi] [nvarchar](50) NULL,
	[songuoi] [int] NULL,
	[gia] [money] NULL,
 CONSTRAINT [PK_loaiphong] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 02/28/2017 19:22:37 ******/
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
 CONSTRAINT [PK_Custumer] PRIMARY KEY CLUSTERED 
(
	[makhachhang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dichvu]    Script Date: 02/28/2017 19:22:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dichvu](
	[madichvu] [varchar](10) NOT NULL,
	[tendichvu] [nvarchar](50) NULL,
	[gia] [money] NULL,
	[donvitinh] [nchar](10) NULL,
 CONSTRAINT [PK_service] PRIMARY KEY CLUSTERED 
(
	[madichvu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hethong]    Script Date: 02/28/2017 19:22:37 ******/
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
 CONSTRAINT [PK_system] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[phong]    Script Date: 02/28/2017 19:22:37 ******/
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
 CONSTRAINT [PK_phong] PRIMARY KEY CLUSTERED 
(
	[maphong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[phieudatphong]    Script Date: 02/28/2017 19:22:37 ******/
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
/****** Object:  Table [dbo].[trangthaiphong]    Script Date: 02/28/2017 19:22:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[trangthaiphong](
	[maphong] [varchar](10) NOT NULL,
	[trangthai] [varchar](10) NOT NULL,
 CONSTRAINT [PK_trangthaiphong] PRIMARY KEY CLUSTERED 
(
	[maphong] ASC,
	[trangthai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[chitietdatphong]    Script Date: 02/28/2017 19:22:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chitietdatphong](
	[maphieudat] [varchar](10) NOT NULL,
	[maphong] [varchar](10) NOT NULL,
 CONSTRAINT [PK_chitietdondatphong] PRIMARY KEY CLUSTERED 
(
	[maphieudat] ASC,
	[maphong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[phieuthuephong]    Script Date: 02/28/2017 19:22:37 ******/
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
/****** Object:  Table [dbo].[chitietthuephong]    Script Date: 02/28/2017 19:22:37 ******/
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
	[madichvu] [varchar](10) NOT NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_chitietthuephong_1] PRIMARY KEY CLUSTERED 
(
	[maphieuthue] ASC,
	[maphong] ASC,
	[ngay] ASC,
	[madichvu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 02/28/2017 19:22:37 ******/
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
/****** Object:  ForeignKey [FK_chitietdatphong_phieudatphong]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[chitietdatphong]  WITH CHECK ADD  CONSTRAINT [FK_chitietdatphong_phieudatphong] FOREIGN KEY([maphieudat])
REFERENCES [dbo].[phieudatphong] ([maphieudat])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[chitietdatphong] CHECK CONSTRAINT [FK_chitietdatphong_phieudatphong]
GO
/****** Object:  ForeignKey [FK_chitietdatphong_phong]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[chitietdatphong]  WITH CHECK ADD  CONSTRAINT [FK_chitietdatphong_phong] FOREIGN KEY([maphong])
REFERENCES [dbo].[phong] ([maphong])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[chitietdatphong] CHECK CONSTRAINT [FK_chitietdatphong_phong]
GO
/****** Object:  ForeignKey [FK_chitietthuephong_dichvu]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[chitietthuephong]  WITH CHECK ADD  CONSTRAINT [FK_chitietthuephong_dichvu] FOREIGN KEY([madichvu])
REFERENCES [dbo].[dichvu] ([madichvu])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[chitietthuephong] CHECK CONSTRAINT [FK_chitietthuephong_dichvu]
GO
/****** Object:  ForeignKey [FK_chitietthuephong_phieuthuephong]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[chitietthuephong]  WITH CHECK ADD  CONSTRAINT [FK_chitietthuephong_phieuthuephong] FOREIGN KEY([maphieuthue])
REFERENCES [dbo].[phieuthuephong] ([maphieuthue])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[chitietthuephong] CHECK CONSTRAINT [FK_chitietthuephong_phieuthuephong]
GO
/****** Object:  ForeignKey [FK_chitietthuephong_phong]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[chitietthuephong]  WITH CHECK ADD  CONSTRAINT [FK_chitietthuephong_phong] FOREIGN KEY([maphong])
REFERENCES [dbo].[phong] ([maphong])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[chitietthuephong] CHECK CONSTRAINT [FK_chitietthuephong_phong]
GO
/****** Object:  ForeignKey [FK_hethong_nhanvien]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[hethong]  WITH CHECK ADD  CONSTRAINT [FK_hethong_nhanvien] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([manhanvien])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[hethong] CHECK CONSTRAINT [FK_hethong_nhanvien]
GO
/****** Object:  ForeignKey [FK_hoadon_hethong]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_hethong] FOREIGN KEY([username])
REFERENCES [dbo].[hethong] ([username])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_hethong]
GO
/****** Object:  ForeignKey [FK_hoadon_khachhang]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_khachhang] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[khachhang] ([makhachhang])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_khachhang]
GO
/****** Object:  ForeignKey [FK_hoadon_phieuthuephong]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_phieuthuephong] FOREIGN KEY([maphieuthue])
REFERENCES [dbo].[phieuthuephong] ([maphieuthue])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_phieuthuephong]
GO
/****** Object:  ForeignKey [FK_phieudatphong_khachhang1]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[phieudatphong]  WITH CHECK ADD  CONSTRAINT [FK_phieudatphong_khachhang1] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[khachhang] ([makhachhang])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[phieudatphong] CHECK CONSTRAINT [FK_phieudatphong_khachhang1]
GO
/****** Object:  ForeignKey [FK_phieuthuephong_hethong]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[phieuthuephong]  WITH CHECK ADD  CONSTRAINT [FK_phieuthuephong_hethong] FOREIGN KEY([username])
REFERENCES [dbo].[hethong] ([username])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[phieuthuephong] CHECK CONSTRAINT [FK_phieuthuephong_hethong]
GO
/****** Object:  ForeignKey [FK_phieuthuephong_phieudatphong]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[phieuthuephong]  WITH CHECK ADD  CONSTRAINT [FK_phieuthuephong_phieudatphong] FOREIGN KEY([maphieudat])
REFERENCES [dbo].[phieudatphong] ([maphieudat])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[phieuthuephong] CHECK CONSTRAINT [FK_phieuthuephong_phieudatphong]
GO
/****** Object:  ForeignKey [FK_phong_loaiphong]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[phong]  WITH CHECK ADD  CONSTRAINT [FK_phong_loaiphong] FOREIGN KEY([maloai])
REFERENCES [dbo].[loaiphong] ([maloai])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[phong] CHECK CONSTRAINT [FK_phong_loaiphong]
GO
/****** Object:  ForeignKey [FK_trangthaiphong_phong]    Script Date: 02/28/2017 19:22:37 ******/
ALTER TABLE [dbo].[trangthaiphong]  WITH CHECK ADD  CONSTRAINT [FK_trangthaiphong_phong] FOREIGN KEY([maphong])
REFERENCES [dbo].[phong] ([maphong])
GO
ALTER TABLE [dbo].[trangthaiphong] CHECK CONSTRAINT [FK_trangthaiphong_phong]
GO
