create proc [dbo].[SP_KiemTraDangNhap] 
@TaiKhoan varchar(20),
@MatKhau varchar(20)
as
if exists (select 1 from hethong where username=@TaiKhoan and password=@MatKhau)
	select 1 as mathongbao,N'Đăng nhập thành công' as ndthongbao,hethong.manhanvien,tennhanvien as hoten from nhanvien,hethong where username=@TaiKhoan and password=@MatKhau
	else
	select 0 as mathongbao,N'Đăng nhập không thành công' as ndthongbao