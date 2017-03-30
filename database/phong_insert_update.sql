ALTER proc [dbo].[PSP_Phong_Insert_Update]
@maphong nvarchar(10),
@maloai nvarchar(100),
@trangthai nvarchar(50),
@giaphong money
as
if exists (select 1 from phong where maphong=@maphong)
begin
	update phong
	set 
	 maloai=@maloai,
	 trangthai=@trangthai,
	 giaphong=@giaphong
	 where maphong=@maphong		
end
else
begin
	insert into phong(maphong, maloai, trangthai, giaphong)
	values(@maphong, @maloai, @trangthai, @giaphong)
end