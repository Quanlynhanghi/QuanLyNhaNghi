ALTER proc [dbo].[sp_Phong_SelectIDMax]
as
select isnull(max(Convert(int,substring(maphong,3,9))),0)+1 as maphong 
from phong