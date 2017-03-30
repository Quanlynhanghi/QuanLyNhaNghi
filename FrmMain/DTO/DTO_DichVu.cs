using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrmMain.DTO
{
    class DTO_DichVu
    {
        string madichvu, tendichvu, donvitinh;

        public string Donvitinh
        {
            get { return donvitinh; }
            set { donvitinh = value; }
        }

        public string Tendichvu
        {
            get { return tendichvu; }
            set { tendichvu = value; }
        }

        public string Madichvu
        {
            get { return madichvu; }
            set { madichvu = value; }
        }
        double gia;

        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }
    }
}
