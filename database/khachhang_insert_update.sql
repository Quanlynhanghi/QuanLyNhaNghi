ALTER proc [dbo].[sp_KhachHang_Inser_Update]
@MaKhachHang char(9), 
@TenKhachHang nvarchar(15), 
@GioiTinh bit, 
@CMND nvarchar(20), 
@DiaChi nvarchar(200),
@SoDienThoai varchar(20),
@Email nvarchar(50), 
@LoaiKhach nvarchar(50)
as
if exists (select 1 from KhachHang where makhachhang=@MaKhachHang)
begin
	update KhachHang
	set 
	 tenkhachhang=@TenKhachHang, 
	 gioitinh=@GioiTinh, 
	 cmnd_passport=@CMND, 
	 diachi=@DiaChi, 
	 sodienthoai=@SoDienThoai,
	 email=@Email,
	 loaikhach=@LoaiKhach
	 where makhachhang=@MaKhachHang
		
end
else
begin
	insert into KhachHang(makhachhang, tenkhachhang, gioitinh, cmnd_passport, diachi, sodienthoai, email, loaikhach)
	values(@MaKhachHang,@TenKhachHang,@GioiTinh,@CMND,@DiaChi,@SoDienThoai,@Email,@LoaiKhach)
end