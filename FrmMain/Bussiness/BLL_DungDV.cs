using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrmMain.DTO;
using System.Data.SqlClient;
namespace FrmMain.Bussiness
{
    public class BLL_DungDV
    {
        cls_DataLayer data;
        public BLL_DungDV(string path)
        {
            data = new cls_DataLayer(path);
        }
        public DataTable LayDanhSach(ref string err)
        {
            return data.GetDataTable(ref err, "sp_SelectDungDV", CommandType.StoredProcedure, null);
        }
        public object GetValue(ref string err)
        {
            return data.GetValue(ref err, "sp_DungDV_SelectIDMax", CommandType.StoredProcedure, null);
        }
        public bool Insert(ref string err, DTO.DTO_Dungdichvu _dichvu)
        {
            return data.MyExcuteNonQuery(ref err, "sp_ThemDungDV", CommandType.StoredProcedure,
                new SqlParameter("@masudung", _dichvu.Masudung),
                new SqlParameter("@madichvu", _dichvu.Madichvu),
                    new SqlParameter("@soluong", _dichvu.Soluong),
                      new SqlParameter("@maphieuthue", _dichvu.Maphieuthue));
        }
        public bool Updata(ref string err, DTO.DTO_Dungdichvu _dichvu)
        {
            return data.MyExcuteNonQuery(ref err, "sp_UpdateDungDV", CommandType.StoredProcedure,
                new SqlParameter("@masudung", _dichvu.Masudung),
                new SqlParameter("@madichvu", _dichvu.Madichvu),
                    new SqlParameter("@soluong", _dichvu.Soluong),
                      new SqlParameter("@maphieuthue", _dichvu.Maphieuthue));
        }
        public bool delete(ref string err, DTO.DTO_Dungdichvu _dichvu)
        {
            return data.MyExcuteNonQuery(ref err, "sp_deleteDungDV", CommandType.StoredProcedure,
                new SqlParameter("@masudung", _dichvu.Masudung));
        }
        public DataTable Thongke(ref string err)
        {
            return data.GetDataTable(ref err, "sp_ThongKeDV", CommandType.StoredProcedure, null);
        }
    }
}
