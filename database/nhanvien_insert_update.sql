ALTER proc [dbo].[sp_NhanVien_Inser_Update]
@manhanvien char(9), 
@tennhanvien nvarchar(15), 
@ngaysinh nvarchar(11), 
@phai bit, 
@diachi nvarchar(100),
@phone varchar(20),
@chucvu nvarchar(50)
as
if exists (select 1 from nhanvien where manhanvien=@manhanvien)
begin
	update nhanvien
	set 
	 tennhanvien=@tennhanvien, 
	 ngaysinh=@ngaysinh, 
	 phai=@phai, 
	 diachi=@diachi,
	 phone=@phone,
	 chucvu=@chucvu
	 where manhanvien=@manhanvien
		
end
else
begin
	insert into nhanvien(manhanvien, tennhanvien, ngaysinh, phai, diachi, phone, chucvu)
	values(@manhanvien, @tennhanvien, @ngaysinh, @phai, @diachi, @phone, @chucvu)
end