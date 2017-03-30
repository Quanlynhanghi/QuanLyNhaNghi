ALTER proc [dbo].[sp_DichVu_Delete]
@madichvu char(9)
as
delete dichvu
where madichvu=@madichvu
