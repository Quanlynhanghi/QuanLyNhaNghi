ALTER proc [dbo].[sp_KhachHang_Select]
as
select ROW_NUMBER() over (order by (select 1)) as STT,makhachhang, tenkhachhang,gioitinh,cmnd_passport,diachi, sodienthoai,email,loaikhach,0 as Xoa
from KhachHang