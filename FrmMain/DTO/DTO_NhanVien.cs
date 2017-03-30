using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrmMain.DTO
{
    class DTO_NhanVien
    {
        string manhanvien, tennhanvien, ngaysinh, diachi, phone, chucvu;

        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        public string Tennhanvien
        {
            get { return tennhanvien; }
            set { tennhanvien = value; }
        }

        public string Manhanvien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }
        bool phai;

        public bool Phai
        {
            get { return phai; }
            set { phai = value; }
        }
    }
}
