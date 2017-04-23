using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrmMain.DTO
{
   public class DTO_PhieuNhanPhong
    {
        string maphieuthue, maphieudat, username, maphong, makhachhang;

        public string Makhachhang
        {
            get { return makhachhang; }
            set { makhachhang = value; }
        }

        public string Maphong
        {
            get { return maphong; }
            set { maphong = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Maphieudat
        {
            get { return maphieudat; }
            set { maphieudat = value; }
        }

        public string Maphieuthue
        {
            get { return maphieuthue; }
            set { maphieuthue = value; }
        }
        DateTime ngayden, ngaydi;

        public DateTime Ngaydi
        {
            get { return ngaydi; }
            set { ngaydi = value; }
        }

        public DateTime Ngayden
        {
            get { return ngayden; }
            set { ngayden = value; }
        }
    }
}
