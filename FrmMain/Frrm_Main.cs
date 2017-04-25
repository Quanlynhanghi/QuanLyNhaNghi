using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrmMain.HeThong;
using FrmMain.DanhMuc;
using System.Data.SqlClient;
using FrmMain.Bussiness;

namespace FrmMain
{
    public partial class Frrm_Main : Form
    {
        public Frrm_Main()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            Frm_DangNhap _dangnhap = new Frm_DangNhap();
            _dangnhap.ShowDialog();
            kiemtraquyen();
            if (quyen == 1) Admin();
            else Default();
        }
        string err = "";
        int quyen=0;
        private void kiemtraquyen()
        {
            BLL_HeThong bd = new BLL_HeThong(cls_Main.duongdanfileketnoi);
            SqlDataReader _reader = bd.GetQuyen(ref err,Frm_DangNhap.tentaikhoan);
            while (_reader.Read() == true)
            {
               quyen= _reader.GetInt32(1);
            }
        }

        public static string tennhanvien { get; set; }
        public void Default()
        {
            this.buttonDoiMatKhau.Enabled = false;
            ribonQL.Visible = false;
            ribonDanhMuc.Visible = false;
            ribbonThongke.Visible = false;
        }
        public void Admin()
        {

            this.btnThanhToan.Enabled = true;
            this.btnLoaiDichVu.Enabled = true;
            this.buttonItemLoaiDVu.Enabled = true;
            this.buttonDangNhap.Enabled = false;
            this.buttonDangKy.Enabled = true;
            this.buttonDangXuat.Enabled = true;
            this.buttonDichVu.Enabled = true;
            this.buttonDoiMatKhau.Enabled = true;
            this.buttonKHDangKy.Enabled = true;
            this.buttonKHNhanPhong.Enabled = true;
            this.buttonNguoiDung.Enabled = true;
            this.buttonPhong.Enabled = true;
            this.buttonThongTin.Enabled = true;
            ribonQL.Visible = true;
            ribonDanhMuc.Visible = true;
            ribbonThongke.Visible = true;
        }

        public void User()
        {
            this.ribbonBar9.Visible = false;
            this.buttonDichVu.Enabled = false;
            this.btnNhanVien.Enabled = false;
            this.buttonDangKy.Enabled = false;
            btnThanhToan.Enabled = false;
            ribbonThongke.Visible = false;
            this.buttonDangNhap.Enabled = false;
            this.buttonDoiMatKhau.Enabled = true;
            ribonQL.Visible = true;
            ribonDanhMuc.Visible = true;
            ribbonThongke.Visible = false;
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
            Frm_DangNhap _dangnhap = new Frm_DangNhap();
            _dangnhap.ShowDialog();
        }

        private void Frrm_Main_Load(object sender, EventArgs e)
        {
            Default();
            Frm_DangNhap _dangnhap = new Frm_DangNhap();
            _dangnhap.ShowDialog();
            kiemtraquyen();
            if (quyen == 1) Admin();
            if (quyen == 2) User();
        }

        private void buttonDoiMatKhau_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau _doimatkhau = new Frm_DoiMatKhau();
            _doimatkhau.MdiParent = this;
            _doimatkhau.Show();
        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            Frm_KhachHang _dichvu = new Frm_KhachHang();
            _dichvu.MdiParent = this;
            _dichvu.Show();
        }

        private void buttonDichVu_Click(object sender, EventArgs e)
        {
            Frm_DichVu _dichvu = new Frm_DichVu();
            _dichvu.MdiParent = this;
            _dichvu.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Frm_NhanVien _nhanvien = new Frm_NhanVien();
            _nhanvien.MdiParent = this;
            _nhanvien.Show();
        }

        private void buttonPhong_Click(object sender, EventArgs e)
        {
            Frm_Phong _phong = new Frm_Phong();
            _phong.MdiParent = this;
            _phong.Show();
        }


        private void buttonItem15_Click(object sender, EventArgs e)
        {
            Frm_DangKiThuePhong dangki = new Frm_DangKiThuePhong();
            dangki.MdiParent = this;
            dangki.Show();
            dangki.WindowState = FormWindowState.Maximized;
            
        }

        private void ribbonBarDangKy_ItemClick(object sender, EventArgs e)
        {
            Frm_DanhSachDangKy _nhanvien = new Frm_DanhSachDangKy();
            _nhanvien.MdiParent = this;
            _nhanvien.Show();
        }

        private void buttonKHNhanPhong_Click(object sender, EventArgs e)
        {
            Frm_DanhSachNhanPhong _nhanvien = new Frm_DanhSachNhanPhong();
            _nhanvien.MdiParent = this;
            _nhanvien.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Frm_HoaDon _nhanvien = new Frm_HoaDon();
            _nhanvien.MdiParent = this;
            _nhanvien.Show();
        }

        private void buttonItemLoaiDVu_Click(object sender, EventArgs e)
        {
            Frm_DungDichVu _nhanvien = new Frm_DungDichVu();
            _nhanvien.MdiParent = this;
            _nhanvien.Show();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            Frm_DangKiThuePhong dangki = new Frm_DangKiThuePhong();
            dangki.MdiParent = this;
            dangki.Show();
            dangki.WindowState = FormWindowState.Maximized;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            Frm_DoanhThu _hoadon= new Frm_DoanhThu();
            _hoadon.MdiParent = this;
            _hoadon.Show();
            _hoadon .WindowState = FormWindowState.Maximized;
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            Frm_Report_DichVu _hoadon = new Frm_Report_DichVu();
            _hoadon.MdiParent = this;
            _hoadon.Show();
            _hoadon.WindowState = FormWindowState.Maximized;
        }

        private void buttonNguoiDung_Click(object sender, EventArgs e)
        {
            Frm_NguoiDung _nguoidung = new Frm_NguoiDung();
            _nguoidung.ShowDialog();
        }

    }
}
