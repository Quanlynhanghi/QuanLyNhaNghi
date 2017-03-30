using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using FrmMain.DTO;

namespace FrmMain.Bussiness
{
    class BLL_KhachHang
    {
        cls_DataLayer data;
        public BLL_KhachHang(string path)
        {
            data = new cls_DataLayer(path);
        }
        public object GetValue(ref string err)
        {
            return data.GetValue(ref err, "sp_KhachHang_SelectIDMax", CommandType.StoredProcedure, null);
        }
        public DataTable LayDanhSachKhachHang(ref string err)
        {
            return data.GetDataTable(ref err, "sp_KhachHang_Select", CommandType.StoredProcedure, null);
        }
        public bool LuuThongTinKhachHang(ref string err, DTO_KhachHang _khachHang)
        {
            return data.MyExcuteNonQuery(ref err, "sp_KhachHang_Inser_Update", CommandType.StoredProcedure
                , new SqlParameter("@MaKhachHang", _khachHang.Makhachhang)
                , new SqlParameter("@TenKhachHang", _khachHang.Tenkhachhang)
                , new SqlParameter("@GioiTinh", _khachHang.Gioitinh)
                , new SqlParameter("@CMND", _khachHang.Cmnd)
                , new SqlParameter("@DiaChi", _khachHang.DiaChi)
                , new SqlParameter("@SoDienThoai", _khachHang.Sodienthoai)
                , new SqlParameter("@Email", _khachHang.Email)
                , new SqlParameter("@LoaiKhach", _khachHang.Loaikhach));
        }
        public bool DeleteKhachHang(ref string err, string makhachhang, ref int sodong)
        {
            return data.MyExcuteNonQuery(ref err, ref sodong, "sp_KhachHang_Delete", CommandType.StoredProcedure
                , new SqlParameter("@makhachhang", makhachhang));
        }
    }
}
