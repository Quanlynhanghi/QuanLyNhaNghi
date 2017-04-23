using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrmMain.DTO;
using FrmMain.Bussiness;

namespace FrmMain.DanhMuc
{
    public partial class Frm_KhachHang_Modifies : Form
    {
        public Frm_KhachHang_Modifies()
        {
            InitializeComponent();
        }

        public bool them = false;
        private string err = "";
        private string makhachhang = "";
        public string tenkhachhang = "";
        BLL_KhachHang bd = new BLL_KhachHang(cls_Main.duongdanfileketnoi);
        internal DTO_KhachHang _khachhang = new DTO_KhachHang();
        private void TangMaSoKhachHang()
        {
            object _obj = null;
            _obj = bd.GetValue(ref err);
            if (_obj != null)
            {
                makhachhang = string.Format("KH{0:0000000}", Convert.ToInt32(_obj));
            }
        }
        private void GanGiaTriVaoCacControl(DTO_KhachHang _khachHang)
        {
            txtmakhachhang.Text = _khachHang.Makhachhang;
            txttenkhachhang.Text = _khachHang.Tenkhachhang;
            txtcmnd.Text = _khachHang.Cmnd;
            txtdiachi.Text = _khachHang.DiaChi;
            txtsdt.Text = _khachHang.Sodienthoai;
            txtloaikhach.Text = _khachHang.Loaikhach;
            txtemail.Text = _khachHang.Email;
            
        }
        private void LayGiaTriTuCacControl()
        {
            _khachhang = new DTO_KhachHang();
            _khachhang.Makhachhang=txtmakhachhang.Text;
            _khachhang.Tenkhachhang=txttenkhachhang.Text;
            _khachhang.Cmnd=  txtcmnd.Text ;
            _khachhang.DiaChi=txtdiachi.Text;
            _khachhang.Sodienthoai=txtsdt.Text;
            _khachhang.Loaikhach=txtloaikhach.Text;
            _khachhang.Email=txtemail.Text;
            _khachhang.Gioitinh=(rdbNam.Checked==true)?true:false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
                //cập nhật thông tin khách hàng
                LayGiaTriTuCacControl();
                tenkhachhang = txttenkhachhang.Text;
                if (!string.IsNullOrEmpty(txttenkhachhang.Text))
                {
                    if (bd.LuuThongTinKhachHang(ref err, _khachhang) == true)
                    {
                        MessageBox.Show("Khách hàng có mã số " + _khachhang.Makhachhang+ " đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập ký hiệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmakhachhang.Focus();
                }

            
        }

        private void Frm_KhachHang_Modifies_Load(object sender, EventArgs e)
        {
            if (them == true)
            {
                TangMaSoKhachHang();
                txtmakhachhang.Text = makhachhang;
                lbltieude.Text = "Thêm khách hàng";
            }
            else
            {
                GanGiaTriVaoCacControl(_khachhang);
                lbltieude.Text = "Chỉnh sửa khách hàng";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
