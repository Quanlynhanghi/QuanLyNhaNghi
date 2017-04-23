using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrmMain.DTO
{
    public class DTO_Dungdichvu
    {
        String masudung, madichvu, maphieuthue;

        public String Maphieuthue
        {
            get { return maphieuthue; }
            set { maphieuthue = value; }
        }

        public String Madichvu
        {
            get { return madichvu; }
            set { madichvu = value; }
        }

        public String Masudung
        {
            get { return masudung; }
            set { masudung = value; }
        }
        int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
    }
}
