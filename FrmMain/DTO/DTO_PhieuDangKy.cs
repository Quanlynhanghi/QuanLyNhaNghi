using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrmMain.DTO
{
    public class DTO_PhieuDangKy
    {
        String maphieudat, maphong, makhachhang, tenkhachhang, username;

        public String Tenkhachhang
        {
            get { return tenkhachhang; }
            set { tenkhachhang = value; }
        }

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public String Makhachhang
        {
            get { return makhachhang; }
            set { makhachhang = value; }
        }

        public String Maphong
        {
            get { return maphong; }
            set { maphong = value; }
        }

        public String Maphieudat
        {
            get { return maphieudat; }
            set { maphieudat = value; }
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
        int songuoi;

        public int Songuoi
        {
            get { return songuoi; }
            set { songuoi = value; }
        }
        double money;

        public double Money
        {
            get { return money; }
            set { money = value; }
        }

    }
}
