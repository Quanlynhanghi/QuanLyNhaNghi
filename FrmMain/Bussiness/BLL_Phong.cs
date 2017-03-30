using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FrmMain.Bussiness
{
    class BLL_Phong
    {
       cls_DataLayer data;
       public BLL_Phong(string path)
       {
           data = new cls_DataLayer(path);
       }
       public object GetValue(ref string err)
       {
           return data.GetValue(ref err, "sp_Phong_SelectIDMax", CommandType.StoredProcedure, null);
       }
       public DataTable GetDanhSachSanPham(ref string err)
       {
           return data.GetDataTable(ref err, "PSP_Phong_Select", CommandType.StoredProcedure, null);
       }
       public bool InsertUpdateSanPham(ref string err, DTO.DTO_Phong _phong)
       {
           return data.MyExcuteNonQuery(ref err, "PSP_Phong_Insert_Update", CommandType.StoredProcedure,
               new SqlParameter("@maphong", _phong.Maphong),
                 new SqlParameter("@maloai", _phong.Maloai),
                   new SqlParameter("@trangthai", _phong.Trangthai),
                     new SqlParameter("@giaphong", _phong.Giaphong));
       }
       public bool DeleteDichVu(ref string err, string maphong, ref int sodong)
       {
           return data.MyExcuteNonQuery(ref err, ref sodong, "sp_Phong_Delete", CommandType.StoredProcedure
               , new SqlParameter("@maphong", maphong));
       }
    }
}
