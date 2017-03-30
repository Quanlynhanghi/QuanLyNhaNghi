ALTER proc [dbo].[sp_NhanVien_Delete]
@manhanvien char(9)
as
delete nhanvien
where manhanvien=@manhanvien