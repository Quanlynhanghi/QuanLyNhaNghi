using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrmMain.Bussiness;
using System.Data.SqlClient;
using System.IO;

namespace FrmMain.HeThong
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }
        BLL_DangNhap bd;
        string err = "";
        public static string tentaikhoan="";
        private bool kiemtradangnhap(string tentaikhoan, string matkhau)
        {
            bool kq = false;
            SqlDataReader _reader = bd.KiemTraDangNhap(ref err, tentaikhoan, matkhau);
            while (_reader.Read() == true)
            {
                if (_reader.GetInt32(0) == 1)
                {
                    kq = true;
                }
            }
            return kq;
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttendangnhap.Text))
            {
                if (!string.IsNullOrEmpty(txtmatkhau.Text))
                {
                    if (kiemtradangnhap(txttendangnhap.Text, txtmatkhau.Text) == true)
                    {
                        tentaikhoan = txttendangnhap.Text;
                        this.Close();
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(err))
                        {
                            MessageBox.Show("Đăng nhập không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập không thành công\n Hãy kiểm tra lại thông tin kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            if (File.Exists(cls_Main.duongdanfileketnoi))
            {
                bd = new BLL_DangNhap(cls_Main.duongdanfileketnoi);
                if (bd.kiemtraketnoi(ref err) == false)
                {
                    Frm_ThietLapChuoiKetNoi _thietlap = new Frm_ThietLapChuoiKetNoi();
                    _thietlap.ShowDialog();
                    bd = new BLL_DangNhap(cls_Main.duongdanfileketnoi);
                }
            }
            else 
            {
                Frm_ThietLapChuoiKetNoi _thietlap = new Frm_ThietLapChuoiKetNoi();
                _thietlap.ShowDialog();
                bd = new BLL_DangNhap(cls_Main.duongdanfileketnoi);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnketnoi_Click(object sender, EventArgs e)
        {
            Frm_ThietLapChuoiKetNoi _thietlap = new Frm_ThietLapChuoiKetNoi();
            _thietlap.ShowDialog();
            bd = new BLL_DangNhap(cls_Main.duongdanfileketnoi);
        }


    }
}
