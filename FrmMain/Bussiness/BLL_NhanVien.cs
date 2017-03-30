using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrmMain.DTO;
using System.Data.SqlClient;

namespace FrmMain.Bussiness
{
    class BLL_NhanVien
    {
        cls_DataLayer data;
        public BLL_NhanVien(string path)
        {
            data = new cls_DataLayer(path);
        }
        public object GetValue(ref string err)
        {
            return data.GetValue(ref err, "sp_NhanVien_SelectIDMax", CommandType.StoredProcedure, null);
        }
        public DataTable LayDanhSachNhanVien(ref string err)
        {
            return data.GetDataTable(ref err, "sp_NhanVien_Select", CommandType.StoredProcedure, null);
        }
        public bool LuuThongTinNhanVien(ref string err, DTO_NhanVien _nhanvien)
        {
            return data.MyExcuteNonQuery(ref err, "sp_NhanVien_Inser_Update", CommandType.StoredProcedure
                , new SqlParameter("@manhanvien", _nhanvien.Manhanvien)
                , new SqlParameter("@tennhanvien", _nhanvien.Tennhanvien)
                , new SqlParameter("@ngaysinh", _nhanvien.Ngaysinh)
                , new SqlParameter("@phai", _nhanvien.Phai)
                , new SqlParameter("@diachi", _nhanvien.Diachi)
                , new SqlParameter("@phone", _nhanvien.Phone)
                , new SqlParameter("@chucvu", _nhanvien.Chucvu));
        }
        public bool DeleteNhanVien(ref string err, string manhanvien, ref int sodong)
        {
            return data.MyExcuteNonQuery(ref err, ref sodong, "sp_NhanVien_Delete", CommandType.StoredProcedure
                , new SqlParameter("@manhanvien", manhanvien));
        }
    }
}
