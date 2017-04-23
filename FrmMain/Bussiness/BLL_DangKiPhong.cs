using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrmMain.DTO;
using System.Data.SqlClient;
namespace FrmMain.Bussiness
{
    public class BLL_DangKiPhong
    {
        cls_DataLayer data;
        public BLL_DangKiPhong(string path)
        {
            data = new cls_DataLayer(path);
        }
        public DataTable LayDanhSach(ref string err)
        {
            return data.GetDataTable(ref err, "sp_selectPhieuDangKy", CommandType.StoredProcedure, null);
        }
        public object GetValue(ref string err)
        {
            return data.GetValue(ref err, "sp_PhieuDangKy_SelectIDMax", CommandType.StoredProcedure, null);
        }
        public bool LuuThongTin(ref string err, DTO_PhieuDangKy _phieudangky)
        {
            return data.MyExcuteNonQuery(ref err, "sp_PhieuDangKy_Inser_Update", CommandType.StoredProcedure
                , new SqlParameter("@maphieudat", _phieudangky.Maphieudat)
                , new SqlParameter("@makhachhang", _phieudangky.Makhachhang)
                , new SqlParameter("@username", _phieudangky.Username)
                , new SqlParameter("@maphong", _phieudangky.Maphong)
                , new SqlParameter("@ngayden", _phieudangky.Ngayden)
                , new SqlParameter("@ngaydi", _phieudangky.Ngaydi)
                , new SqlParameter("@tiendatcoc", _phieudangky.Money)
                , new SqlParameter("@songuoi", _phieudangky.Songuoi));
        }
        public bool delete(ref string err, DTO_PhieuDangKy _phieudangky)
        {
            return data.MyExcuteNonQuery(ref err, "sp_deleteDatPhong", CommandType.StoredProcedure,
                new SqlParameter("@maphieudat", _phieudangky.Maphieudat));
        }
    }
}
