using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrmMain.DTO;
using System.Data.SqlClient;
using System.Data;

namespace FrmMain.Bussiness
{
    public class BLL_DoiMatKhau
    {
        cls_DataLayer data;
        public BLL_DoiMatKhau(string path)
        {
            data = new cls_DataLayer(path);
        }
        public bool DoiMatKhau(ref string err, DTO_HeThong _hethong)
        {
            return data.MyExcuteNonQuery(ref err, "sp_DoiMatKhau", CommandType.StoredProcedure
                , new SqlParameter("@TaiKhoan", _hethong.UserName), new SqlParameter("@MatKhauCu", _hethong.PassWordCu), new SqlParameter("@MatKhauMoi", _hethong.PassWord));
        }
    }
}
