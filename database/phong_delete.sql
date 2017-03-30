ALTER proc [dbo].[sp_Phong_Delete]
@maphong char(9)
as
delete phong
where maphong=@maphong