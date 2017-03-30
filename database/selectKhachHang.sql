create proc [dbo].[sp_KhachHang_Select]
as
select ROW_NUMBER() over (order by (select 1)) as STT,makhachhang, tenkhachhang,gioitinh,diachi, sodienthoai,loaikhach,0 as Xoa
from KhachHang
order by makhachhang asc