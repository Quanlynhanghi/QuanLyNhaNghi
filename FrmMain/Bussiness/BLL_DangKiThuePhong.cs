using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FrmMain.Bussiness
{
    public class BLL_DangKiThuePhong
    {
        cls_DataLayer data;
        public BLL_DangKiThuePhong(string path)
        {
            data = new cls_DataLayer(path);
        }
        public DataTable LoaiPhong(ref string err)
        {
            return data.GetDataTable(ref err, "sp_loaiphong", CommandType.StoredProcedure, null);
        }
        public object trangthai(ref string err,string maphong)
        {
            return data.GetValue(ref err, "sp_kiemtratinhtrang", CommandType.StoredProcedure,new SqlParameter("@maphong",maphong));
        }
        public DataTable GetDanhSachPhongTheoLoại(ref string err,string LoaiPhong)
        {
            return data.GetDataTable(ref err, "psp_Phong_Select_TheoLoai", CommandType.StoredProcedure, new SqlParameter("@LoaiPhong", LoaiPhong));
        }
        public DataTable GetDanhSachPhongTheoTT(ref string err, string TrangThai)
        {
            return data.GetDataTable(ref err, "psp_Phong_Select_TT", CommandType.StoredProcedure, new SqlParameter("@trangthai", TrangThai));
        }

        public DataTable GetDanhSachPhongTheoTT(ref string err, string TrangThai,string LoaiPhong)
        {
            return data.GetDataTable(ref err, "psp_Phong_Select_TT_Loai", CommandType.StoredProcedure, new SqlParameter("@trangthai", TrangThai), new SqlParameter("@loaiphong", LoaiPhong));
        }
    }
}
