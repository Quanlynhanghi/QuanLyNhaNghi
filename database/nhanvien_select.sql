ALTER proc [dbo].[sp_NhanVien_Select]
as
select ROW_NUMBER() over (order by (select 1)) as STT,manhanvien, tennhanvien, ngaysinh, phai, diachi, phone, chucvu,0 as Xoa
from nhanvien