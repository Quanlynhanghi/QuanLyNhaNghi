using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FrmMain.Bussiness
{
   public class BLL_HeThong
    {
       cls_DataLayer data;
       public BLL_HeThong(string path)
       {
           data = new cls_DataLayer(path);
       }
       public SqlDataReader GetQuyen(ref string err, string taikhoan)
       {
           return data.MyExcuteReader(ref err, "sp_quyen", CommandType.StoredProcedure,
               new SqlParameter("@username", taikhoan));
       }
       public DataTable GetDanhSach(ref string err)
       {
           return data.GetDataTable(ref err, "sp_selectnguoidung", CommandType.StoredProcedure, null);
       }
       public bool Delete(ref string err, string user)
       {
           return data.MyExcuteNonQuery(ref err, "sp_deleteht", CommandType.StoredProcedure
               , new SqlParameter("@username", user));
       }
       public bool Update(ref string err, string user)
       {
           return data.MyExcuteNonQuery(ref err, "sp_updateht", CommandType.StoredProcedure
               , new SqlParameter("@username", user));
       }
       public bool Insert(ref string err, string user,string manhanvien,int loaitaikhoan)
       {
           return data.MyExcuteNonQuery(ref err, "sp_insertht", CommandType.StoredProcedure
               , new SqlParameter("@username", user)
               , new SqlParameter("@manhavien", manhanvien)
               , new SqlParameter("@loaitaikhoan", loaitaikhoan));
       }
       public DataTable GetNhaVien(ref string err)
       {
           return data.GetDataTable(ref err, "sp_selectNVHT", CommandType.StoredProcedure, null);
       }
    }
}
