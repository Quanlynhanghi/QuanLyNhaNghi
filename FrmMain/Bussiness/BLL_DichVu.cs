using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using FrmMain.DTO;

namespace FrmMain.Bussiness
{
    class BLL_DichVu
    {
        cls_DataLayer data;
       public BLL_DichVu(string path)
       {
           data = new cls_DataLayer(path);
       }
       public object GetValue(ref string err)
       {
           return data.GetValue(ref err, "sp_DichVu_SelectIDMax", CommandType.StoredProcedure, null);
       }
       public DataTable GetDanhSachSanPham(ref string err)
       {
           return data.GetDataTable(ref err, "PSP_DichVu_Select", CommandType.StoredProcedure, null);
       }
       public bool InsertUpdateSanPham(ref string err, DTO.DTO_DichVu _dichvu)
       {
           return data.MyExcuteNonQuery(ref err, "PSP_DichVu_Insert_Update", CommandType.StoredProcedure,
               new SqlParameter("@madichvu", _dichvu.Madichvu),
                 new SqlParameter("@tendichvu", _dichvu.Tendichvu),
                   new SqlParameter("@gia", _dichvu.Gia),
                     new SqlParameter("@donvitinh", _dichvu.Donvitinh));
       }
       public bool DeleteDichVu(ref string err, string madichvu,ref int sodong)
       {
           return data.MyExcuteNonQuery(ref err, ref sodong, "sp_DichVu_Delete", CommandType.StoredProcedure
               , new SqlParameter("@madichvu", madichvu));
       }
    }
}
