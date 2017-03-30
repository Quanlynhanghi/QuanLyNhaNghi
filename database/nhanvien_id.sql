ALTER proc [dbo].[sp_NhanVien_SelectIDMax]
as
select isnull(max(Convert(int,substring(manhanvien,3,9))),0)+1 as manhanvien 
from nhanvien