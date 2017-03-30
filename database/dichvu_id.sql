ALTER proc [dbo].[sp_DichVu_SelectIDMax]
as
select isnull(max(Convert(int,substring(madichvu,3,9))),0)+1 as madichvu 
from dichvu