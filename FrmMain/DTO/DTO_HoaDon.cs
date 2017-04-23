using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrmMain.DTO
{
   public class DTO_HoaDon
    {
        string mahoadon, maphong, maphieuthue, makhachhang, username;

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

        public string Makhachhang
        {
            get { return makhachhang; }
            set { makhachhang = value; }
        }

        public string Maphieuthue
        {
            get { return maphieuthue; }
            set { maphieuthue = value; }
        }

        public string Mahoadon
        {
            get { return mahoadon; }
            set { mahoadon = value; }
        }
        double tienphong, tiendichvu, tongtien;

        public double Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }

        public double Tiendichvu
        {
            get { return tiendichvu; }
            set { tiendichvu = value; }
        }

        public double Tienphong
        {
            get { return tienphong; }
            set { tienphong = value; }
        }
        DateTime ngaythanhtoan;

        public DateTime Ngaythanhtoan
        {
            get { return ngaythanhtoan; }
            set { ngaythanhtoan = value; }
        }
    }
}
