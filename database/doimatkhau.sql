create proc sp_DoiMatKhau
@TaiKhoan varchar(10),
@MatKhauCu varchar(200),
@MatKhauMoi varchar(200)
as
begin 
	update hethong set password=@MatKhauMoi where username=@TaiKhoan and password=@MatKhauCu
end
