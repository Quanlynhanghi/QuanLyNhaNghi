using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrmMain.Bussiness;
using FrmMain.DTO;
using System.Data.SqlClient;
using FrmMain.HeThong;

namespace FrmMain.DanhMuc
{
    public partial class Frm_PhieuNhanPhong : Form
    {
        public Frm_PhieuNhanPhong()
        {
            InitializeComponent();
        }
        string username = Frm_DangNhap.tentaikhoan;
        string err = "";
        string MaPhieu="";
        string MaPhieuDK = "";
        BLL_PhieuNhan bd;
        DTO_PhieuNhanPhong _nhanphong;
        private void HienThiComBox()
        {
            BLL_KhachHang bd = new BLL_KhachHang(cls_Main.duongdanfileketnoi);
            DataTable dtDanhSachKhachHang;
            BLL_Phong bdphong = new BLL_Phong(cls_Main.duongdanfileketnoi);
            DataTable dtDanhSachPhong;
            dtDanhSachKhachHang = new DataTable();
            dtDanhSachKhachHang = bd.LayDanhSachKhachHang(ref err);
            cmbMaKH.DataSource = dtDanhSachKhachHang;
            cmbMaKH.ValueMember = "makhachhang";
            cmbMaKH.DisplayMember = "tenkhachhang";
            dtDanhSachPhong = new DataTable();
            dtDanhSachPhong = bdphong.GetDanhSachPhong(ref err);
            cmbMaPHong.DataSource = dtDanhSachPhong;
            cmbMaPHong.DisplayMember = "maphong";
            cmbMaPHong.Text = Frm_DangKiThuePhong.maphong;
        }
        public void TangMaPhieuDat()
        {
            BLL_DangKiPhong bdphieu = new BLL_DangKiPhong(cls_Main.duongdanfileketnoi);
            object _obj = null;
            _obj = bdphieu.GetValue(ref err);
            if (_obj != null)
            {
                MaPhieuDK = string.Format("PDP{0:000}", Convert.ToInt32(_obj));
            }
        }
        private void TangMaThue()
        {
            object _obj = null;
            _obj = bd.GetValue(ref err);
            if (_obj != null)
            {
                MaPhieu = string.Format("PT{0:0000}", Convert.ToInt32(_obj));
            }
        }
        private bool KTTinhTrang()
        {
            bool kq = false;
            SqlDataReader _reader = bd.Trangthai(ref err, Frm_DangKiThuePhong.maphong);
            while (_reader.Read() == true)
            {
                if (_reader.GetString(0) == "Trống")
                {
                    kq = true;
                }
            }
            return kq;
        }
        private void LayThongTinDatPhong()
        {
            _nhanphong = new DTO_PhieuNhanPhong();
            SqlDataReader _reader = bd.Laythongtin(ref err,Frm_DangKiThuePhong.maphong);
            while (_reader.Read() == true)
            {
               // txtMaPhieuThue.Text = _reader.GetString(0);
                cmbMaPhieuDK.Text = _reader.GetString(0);
                cmbMaKH.Text = _reader.GetString(1);
            }
        }
        private void Frm_PhieuNhanPhong_Load(object sender, EventArgs e)
        {
            
            bd = new BLL_PhieuNhan(cls_Main.duongdanfileketnoi);
            TangMaThue();
            txtMaPhieuThue .Text= MaPhieu;
            if (KTTinhTrang() == true)
            {
                TangMaPhieuDat();
                cmbMaPhieuDK.Text = MaPhieuDK;
                cmbMaPHong.Enabled = false;
                cmbMaPhieuDK.Enabled = false;
                HienThiComBox();
            }
            else
            {
                
                cmbMaPHong.Text = Frm_DangKiThuePhong.maphong;
                LayThongTinDatPhong();
                cmbMaKH.Enabled = false;
                cmbMaPHong.Enabled = false;
                cmbMaPhieuDK.Enabled = false;
            }
            HienThiDanhSach();
        }
        private void LayGiaTriTuCacControl()
        {
            _nhanphong = new DTO_PhieuNhanPhong();
            _nhanphong.Maphieuthue = txtMaPhieuThue.Text;
            _nhanphong.Maphieudat = cmbMaPhieuDK.Text;
            _nhanphong.Maphong = cmbMaPHong.Text;
            _nhanphong.Ngayden = dtNgayNhan.Value;
            _nhanphong.Username = username;
            _nhanphong.Makhachhang = cmbMaKH.SelectedValue.ToString();
        }
        DataTable dtDanhsach;
        private void HienThiDanhSach()
        {
            dtDanhsach = new DataTable();
            dtDanhsach = bd.LayDanhSach(ref err);
            gridControl1.DataSource = dtDanhsach.DefaultView;
        }
        private void btnThemPhieuNhan_Click(object sender, EventArgs e)
        {
            LayGiaTriTuCacControl();
            if (_nhanphong != null)
            {
                if (KTTinhTrang() == false)
                {
                    if (bd.LuuThongTin(ref err, _nhanphong) == true)
                    {
                        MessageBox.Show("Phòng có mã số " + _nhanphong.Maphieuthue + " đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (bd.InsertThongTin(ref err, _nhanphong) == true)
                    {
                        MessageBox.Show("Phòng có mã số " + _nhanphong.Maphieuthue + " đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            HienThiDanhSach();
        }
    }
}
