ALTER proc [dbo].[PSP_Phong_Select]
as
select  ROW_NUMBER() over (order by (select 1)) as STT,maphong, maloai, trangthai, giaphong,0 as Xoa
from phong