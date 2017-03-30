using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrmMain.DTO
{
    class DTO_KhachHang
    {
        string makhachhang, tenkhachhang, cmnd, diaChi, sodienthoai, email, loaikhach;
        bool gioitinh;

        public bool Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public string Loaikhach
        {
            get { return loaikhach; }
            set { loaikhach = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Sodienthoai
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public string Tenkhachhang
        {
            get { return tenkhachhang; }
            set { tenkhachhang = value; }
        }

        public string Makhachhang
        {
            get { return makhachhang; }
            set { makhachhang = value; }
        }
        
    }
}
