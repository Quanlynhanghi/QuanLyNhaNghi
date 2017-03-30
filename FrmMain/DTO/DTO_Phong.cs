using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrmMain.DTO
{
    class DTO_Phong
    {
        string maphong, maloai, trangthai;
        double giaphong;

        public double Giaphong
        {
          get { return giaphong; }
          set { giaphong = value; }
        }

        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }

        public string Maloai
        {
            get { return maloai; }
            set { maloai = value; }
        }

        public string Maphong
        {
            get { return maphong; }
            set { maphong = value; }
        }
        }
    }
