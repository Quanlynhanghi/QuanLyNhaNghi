create proc [dbo].[sp_KhachHang_SelectIDMax]
as
select isnull(max(Convert(int,substring(makhachhang,3,9))),0)+1 as MaKH 
from KhachHang