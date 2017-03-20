using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FrmMain.Bussiness
{
    public class BLL_DangNhap
    {
        cls_DataLayer data;
        public BLL_DangNhap(string path)
        {
            data = new cls_DataLayer(path);
        }
        public bool kiemtraketnoi(ref string err)
        {
            return data.kiemtraketnoi(ref err);
        }
        public SqlDataReader KiemTraDangNhap(ref string err, string taikhoan, string matkhau)
        {
            return data.MyExcuteReader(ref err, "SP_KiemTraDangNhap", CommandType.StoredProcedure,
                new SqlParameter("@TaiKhoan", taikhoan),
                new SqlParameter("@MatKhau", matkhau));
        }
    }
}
