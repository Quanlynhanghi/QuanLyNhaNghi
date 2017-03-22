using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrmMain.DTO
{
    public class DTO_HeThong
    {
        string userName, maNhanVien, passWord, passWordCu;

        public string PassWordCu
        {
            get { return passWordCu; }
            set { passWordCu = value; }
        }

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        
        
        int loaiMatKhau;

        public int LoaiMatKhau
        {
            get { return loaiMatKhau; }
            set { loaiMatKhau = value; }
        }
    }
}
