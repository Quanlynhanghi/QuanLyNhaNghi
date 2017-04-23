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

namespace FrmMain.DanhMuc
{
    public partial class Frm_DatPhong : Form
    {
        public Frm_DatPhong()
        {
            InitializeComponent();
        }
        
        string err = "";
        string username = Frm_DangNhap.tentaikhoan;
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
        BLL_DangKiPhong bd;
        DataTable dtDanhsach;
        private void HienThiDanhSach()
        {
            dtDanhsach = new DataTable();
            dtDanhsach = bd.LayDanhSach(ref err);
            gridControl1.DataSource = dtDanhsach.DefaultView;
        }
        public bool them = true;
        private void Frm_DatPhong_Load(object sender, EventArgs e)
        {
            if (them == true)
            {
                bd = new BLL_DangKiPhong(cls_Main.duongdanfileketnoi);
                HienThiComBox();
                HienThiDanhSach();
                TangMaPhieuDat();
                txtMaPhieuThue.Text = MaPhieu;
            }
            else
            {
                HienThiComBox();
                GanGiaTriVaoCacControl(_phieudangky);
            }
        }
        private void GanGiaTriVaoCacControl(DTO_PhieuDangKy _phieudangky)
        {
            txtMaPhieuThue.Text = _phieudangky.Maphieudat;
            cmbMaKH.Text = _phieudangky.Tenkhachhang;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_KhachHang_Modifies _khachhang = new Frm_KhachHang_Modifies();
            _khachhang.them = true;
            _khachhang.ShowDialog();
            HienThiComBox();
            cmbMaKH.Text =_khachhang.tenkhachhang;
        }
        private string MaPhieu = "";
        public void TangMaPhieuDat()
        {
            object _obj = null;
            _obj = bd.GetValue(ref err);
            if (_obj != null)
            {
                MaPhieu = string.Format("PDP{0:000}", Convert.ToInt32(_obj));
            }
        }
        internal DTO_PhieuDangKy _phieudangky;
        private void LayGiaTriTuCacControl()
        {
            _phieudangky = new DTO_PhieuDangKy();
            _phieudangky.Maphieudat = txtMaPhieuThue.Text;
            _phieudangky.Makhachhang = cmbMaKH.SelectedValue.ToString();
            _phieudangky.Maphong = cmbMaPHong.Text;
            _phieudangky.Ngayden = dateNgayDangKy.Value;
            _phieudangky.Ngaydi = dateTimeNgayNhan.Value;
            _phieudangky.Songuoi = Convert.ToInt16(txtSoNguoi.Text);
            _phieudangky.Money = Convert.ToDouble(txtTienCoc.Text);
            _phieudangky.Username = username;
        }
        private void btnLưu_Click(object sender, EventArgs e)
        {
            LayGiaTriTuCacControl();
            if (_phieudangky != null)
            {
                if (bd.LuuThongTin(ref err, _phieudangky) == true)
                {
                    MessageBox.Show("Phòng có mã số " + _phieudangky.Maphieudat + " đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            HienThiDanhSach();
        }

        
    }
}
