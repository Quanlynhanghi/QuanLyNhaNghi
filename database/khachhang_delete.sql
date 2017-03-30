ALTER proc [dbo].[sp_KhachHang_Delete]
@makhachhang char(9)
as
delete khachhang
where makhachhang=@makhachhang