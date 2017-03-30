ALTER proc [dbo].[PSP_DichVu_Insert_Update]
@madichvu nvarchar(10),
@tendichvu nvarchar(100),
@gia money,
@donvitinh char(10)
as
if exists (select 1 from dichvu where madichvu=@madichvu)
begin
	update dichvu
	set 
	 tendichvu=@tendichvu,
	 gia=@gia,
	 donvitinh=@donvitinh
	 where madichvu=@madichvu		
end
else
begin
	insert into dichvu(madichvu, tendichvu, gia, donvitinh)
	values(@madichvu, @tendichvu, @gia, @donvitinh)
end