using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrmMain.DTO;
using System.Data.SqlClient;
namespace FrmMain.Bussiness
{
    public class BLL_PhieuNhan
    {
        cls_DataLayer data;
        public BLL_PhieuNhan(string path)
        {
            data = new cls_DataLayer(path);
        }
        public DataTable LayDanhSach(ref string err)
        {
            return data.GetDataTable(ref err, "sp_selectPhieuThue", CommandType.StoredProcedure, null);
        }
        public object GetValue(ref string err)
        {
            return data.GetValue(ref err, "sp_PhieuThue_SelectIDMax", CommandType.StoredProcedure, null);
        }
        public SqlDataReader Laythongtin(ref string err, string maphong)
        {
            return data.MyExcuteReader(ref err, "sp_layThongtinDatphong", CommandType.StoredProcedure,
                new SqlParameter("@maphong", maphong));
        }
        public SqlDataReader Trangthai(ref string err, string maphong)
        {
            return data.MyExcuteReader(ref err, "sp_kiemtratinhtrang", CommandType.StoredProcedure,
                new SqlParameter("@maphong", maphong));
        }
        public bool LuuThongTin(ref string err, DTO_PhieuNhanPhong _nhanphong)
        {
            return data.MyExcuteNonQuery(ref err, "sp_ThemNhanPhong", CommandType.StoredProcedure
                , new SqlParameter("@maphieuthue", _nhanphong.Maphieuthue)
                , new SqlParameter("@maphieudat", _nhanphong.Maphieudat)
                , new SqlParameter("@username", _nhanphong.Username)
                , new SqlParameter("@maphong", _nhanphong.Maphong)
                , new SqlParameter("@ngayden", _nhanphong.Ngayden));
        }
        public bool InsertThongTin(ref string err, DTO_PhieuNhanPhong _nhanphong)
        {
            return data.MyExcuteNonQuery(ref err, "sp_InsertNhanPhong", CommandType.StoredProcedure
                , new SqlParameter("@maphieuthue", _nhanphong.Maphieuthue)
                , new SqlParameter("@maphieudat", _nhanphong.Maphieudat)
                , new SqlParameter("@username", _nhanphong.Username)
                , new SqlParameter("@maphong", _nhanphong.Maphong)
                , new SqlParameter("@ngayden", _nhanphong.Ngayden)
                , new SqlParameter("@makhachhang", _nhanphong.Makhachhang));
        }
    }
}
