using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrmMain.DTO;
using System.Data.SqlClient;

namespace FrmMain.Bussiness
{
    public class BLL_HoaDon
    {
        cls_DataLayer data;
        public BLL_HoaDon(string path)
        {
            data = new cls_DataLayer(path);
        }
        public DataTable LayDanhSach(ref string err)
        {
            return data.GetDataTable(ref err, "sp_selectHoaDon", CommandType.StoredProcedure, null);
        }
        public object GetValue(ref string err)
        {
            return data.GetValue(ref err, "sp_Hoadon_SelectIDMax", CommandType.StoredProcedure, null);
        }
        public bool delete(ref string err, DTO_HoaDon _Hoadon)
        {
            return data.MyExcuteNonQuery(ref err, "sp_deleteHoaDon", CommandType.StoredProcedure,
                new SqlParameter("@mahoadon", _Hoadon.Mahoadon));
        }
        public object Tiendichvu(ref string err,string maphieuthue)
        {
            return data.GetValue(ref err, "sp_tiendichvu", CommandType.StoredProcedure, new SqlParameter("@maphieuthue", maphieuthue));
        }
        public object giaphong(ref string err,string maphong)
        {
            return data.GetValue(ref err, "sp_giaphong", CommandType.StoredProcedure, new SqlParameter("@maphong", maphong));
        }
        public bool LuuThongTin(ref string err, DTO_HoaDon _Hoadon)
        {
            return data.MyExcuteNonQuery(ref err, "sp_themhoadon", CommandType.StoredProcedure,
                new SqlParameter("@mahoadon", _Hoadon.Mahoadon),
                new SqlParameter("@ngaythanhtoan", _Hoadon.Ngaythanhtoan),
                new SqlParameter("@tongtien", _Hoadon.Tongtien),
                new SqlParameter("@maphieuthue", _Hoadon.Maphieuthue),
                new SqlParameter("@makhachhang", _Hoadon.Makhachhang),
                new SqlParameter("@username", _Hoadon.Username),
                new SqlParameter("@tienphong", _Hoadon.Tienphong),
                new SqlParameter("@tiendichvu", _Hoadon.Tiendichvu),
                new SqlParameter("@maphong", _Hoadon.Maphong));
        }
        public SqlDataReader LaythongtinPhieuDat(ref string err, string maphong)
        {
            return data.MyExcuteReader(ref err, "sp_layThongtinDatphong", CommandType.StoredProcedure,
                new SqlParameter("@maphong", maphong));
        }
        public SqlDataReader LaythongtinPhieuNhan(ref string err, string maphieudat)
        {
            return data.MyExcuteReader(ref err, "sp_selectTTPhieuThue", CommandType.StoredProcedure,
                new SqlParameter("@maphong", maphieudat));
        }
        public DataTable INhoadon(ref string err, string mahoadon)
        {
            return data.GetDataTable(ref err, "sp_InHoaDon", CommandType.StoredProcedure, new SqlParameter("@mahoadon", mahoadon));
        }
    }
}
