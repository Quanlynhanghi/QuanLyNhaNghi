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
using FrmMain.HeThong;
using System.Data.SqlClient;

namespace FrmMain.DanhMuc
{
    public partial class Frm_HoaDon : Form
    {
        public Frm_HoaDon()
        {
            InitializeComponent();
        }
        private string err = "";
        private string MaHoadon = "";
        BLL_HoaDon bd;
        DTO_HoaDon _hoadon;
        string username = Frm_DangNhap.tentaikhoan;
        private void HienThiComBox()
        {
            BLL_KhachHang bd = new BLL_KhachHang(cls_Main.duongdanfileketnoi);
            DataTable dtDanhSachKhachHang;
            BLL_Phong bdphong = new BLL_Phong(cls_Main.duongdanfileketnoi);
            DataTable dtDanhSachPhong;
            BLL_PhieuNhan bdphieu = new BLL_PhieuNhan(cls_Main.duongdanfileketnoi);
            DataTable dtDanhPhieuThue;
            dtDanhSachKhachHang = new DataTable();
            dtDanhSachKhachHang = bd.LayDanhSachKhachHang(ref err);
            cmbTenKhachHang.DataSource = dtDanhSachKhachHang;
            cmbTenKhachHang.ValueMember = "makhachhang";
            cmbTenKhachHang.DisplayMember = "tenkhachhang";
            dtDanhSachPhong = new DataTable();
            dtDanhSachPhong = bdphong.GetDanhSachPhong(ref err);
            cmbMaPhong.DataSource = dtDanhSachPhong;
            cmbMaPhong.DisplayMember = "maphong";
            cmbMaPhong.Text = Frm_DangKiThuePhong.maphong;
            dtDanhPhieuThue = bdphieu.LayDanhSach(ref err);
            cmbMaNhanPhong.DataSource = dtDanhPhieuThue;
            cmbMaNhanPhong.DisplayMember = "maphieuthue";
        }
        private void TangMaHoaDon()
        {
            object _obj = null;
            _obj = bd.GetValue(ref err);
            if (_obj != null)
            {
                MaHoadon = string.Format("HD{0:0000}", Convert.ToInt32(_obj));
            }
        }
        private void giaphong()
        {
            object _obj = null;
            _obj = bd.giaphong(ref err,cmbMaPhong.Text);
            if (_obj != null)
            {
                txtTienPhong.Text = _obj.ToString();
            }
        }
        DataTable dtDanhsach;
        private void HienThiDanhSach()
        {
            dtDanhsach = new DataTable();
            dtDanhsach = bd.LayDanhSach(ref err);
            gridControl1.DataSource = dtDanhsach.DefaultView;
        }
        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            bd = new BLL_HoaDon(cls_Main.duongdanfileketnoi);
            HienThiComBox();
            TangMaHoaDon();
            LayThongTinDatPhong();
            txtMaHoaDon.Text = MaHoadon;
            HienThiDanhSach();
        }
        
        private string madat;
        private void LayThongTinDatPhong()
        {

            SqlDataReader _reader = bd.LaythongtinPhieuDat(ref err, Frm_DangKiThuePhong.maphong);
            if (_reader.Read() == true)
            {

                 madat= _reader.GetString(0);
            }
        }
        private void LayThongTinPhieuNhan()
        {
            
            SqlDataReader _reader = bd.LaythongtinPhieuNhan(ref err, madat);
            if (_reader.Read() == true)
            {
                cmbMaNhanPhong.Text = _reader.GetString(0);
                cmbTenKhachHang.Text = _reader.GetString(6);
            }
        }
        private void tiendichvu()
        {
            object _obj = null;
            _obj = bd.Tiendichvu(ref err, cmbMaNhanPhong.Text);
            if (_obj != null)
            {
                txtTienDVu.Text = _obj.ToString();
            }
            else
            {
                txtTienDVu.Text = "0";
            }
        }
        private void cmbMaPhong_TextChanged(object sender, EventArgs e)
        {
            giaphong();
        }

        private void cmbMaNhanPhong_TextChanged(object sender, EventArgs e)
        {
            tiendichvu();
        }

        
          
        private void LayGiaTriTuCacControl()
        {
            double tong = Convert.ToDouble(txtTienDVu.Text) + Convert.ToDouble(txtTien.Text);
            _hoadon = new DTO_HoaDon();
            _hoadon.Maphieuthue = cmbMaNhanPhong.Text;
            _hoadon.Mahoadon = txtMaHoaDon.Text;
            _hoadon.Ngaythanhtoan = dateNgaylap.Value;
            _hoadon.Tiendichvu = Convert.ToDouble( txtTienDVu.Text);
            _hoadon.Tienphong = Convert.ToDouble(txtTien.Text);
            _hoadon.Tongtien = Convert.ToDouble( txtTongTien.Text);
            _hoadon.Username = username;
            _hoadon.Maphong = cmbMaPhong.Text;
            _hoadon.Makhachhang = cmbTenKhachHang.SelectedValue.ToString();
        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
          
            double tienphong = Convert.ToDouble(txtTienPhong.Text) * Convert.ToDouble(numSoNgay.Value);
            txtTien.Text = tienphong.ToString();
            double tong = Convert.ToDouble(txtTienDVu.Text) + Convert.ToDouble(txtTien.Text);
            txtThanhTien.Text = tong.ToString();
            txtTongTien.Text = txtThanhTien.Text;
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            LayGiaTriTuCacControl();
            if (_hoadon != null)
            {
                if (bd.LuuThongTin(ref err, _hoadon) == true)
                {
                    MessageBox.Show("Phòng có mã số " + _hoadon.Mahoadon + " đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            HienThiDanhSach();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            _hoadon = new DTO_HoaDon();
            _hoadon.Mahoadon = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mahoadon").ToString();
            _hoadon.Maphieuthue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "maphieuthue").ToString();
            _hoadon.Makhachhang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "makhachhang").ToString();
            setto();
        }
        private void setto()
        {
            txtMaHoaDon.Text = _hoadon.Mahoadon;
            cmbMaNhanPhong.Text = _hoadon.Maphieuthue;
        }
        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa" + txtMaHoaDon.Text + "không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (bd.delete(ref err, _hoadon) == true)
                {
                    MessageBox.Show("Phòng có mã số " + _hoadon.Mahoadon + " đã được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Xóa không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            HienThiDanhSach();
        }

        private void toolStripTrangIn_Click(object sender, EventArgs e)
        {
            Frm_ReportHoaDon report = new Frm_ReportHoaDon();
            report.mahoadon = txtMaHoaDon.Text;
            report.ShowDialog();

        }
    }
}
