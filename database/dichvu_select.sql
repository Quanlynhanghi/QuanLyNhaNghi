ALTER proc [dbo].[PSP_DichVu_Select]
as
select  ROW_NUMBER() over (order by (select 1)) as STT, madichvu, tendichvu, gia, donvitinh,0 as Xoa
from DichVu