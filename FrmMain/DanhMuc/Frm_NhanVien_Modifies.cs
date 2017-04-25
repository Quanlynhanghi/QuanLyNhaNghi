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

namespace FrmMain.DanhMuc
{
    public partial class Frm_NhanVien_Modifies : Form
    {
        public Frm_NhanVien_Modifies()
        {
            InitializeComponent();
        }
        public bool them = false;
        private string err = "";
        private string manhanvien = "";
        BLL_NhanVien bd = new BLL_NhanVien(cls_Main.duongdanfileketnoi);
        internal DTO_NhanVien _nhanvien = new DTO_NhanVien();

        private void TangMaSoNhanVien()
        {
            object _obj = null;
            _obj = bd.GetValue(ref err);
            if (_obj != null)
            {
                manhanvien = string.Format("NV{0:00}", Convert.ToInt32(_obj));
            }
        }
        private void GanGiaTriVaoCacControl(DTO_NhanVien _nhanvien)
        {
            txtmanhanvien.Text = _nhanvien.Manhanvien;
            txttennhanvien.Text = _nhanvien.Tennhanvien;
            txtngaysinh.Text = _nhanvien.Ngaysinh;
            txtdiachi.Text = _nhanvien.Diachi;
            txtsdt.Text = _nhanvien.Phone;
            txtchucvu.Text = _nhanvien.Chucvu;

        }
        private void LayGiaTriTuCacControl()
        {
            _nhanvien = new DTO_NhanVien();
            _nhanvien.Manhanvien = txtmanhanvien.Text;
            _nhanvien.Tennhanvien = txttennhanvien.Text;
            _nhanvien.Ngaysinh = txtngaysinh.Text;
            _nhanvien.Diachi = txtdiachi.Text;
            _nhanvien.Phone = txtsdt.Text;
            _nhanvien.Chucvu = txtchucvu.Text;
            _nhanvien.Phai = (rdbNam.Checked == true) ? true : false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            LayGiaTriTuCacControl();
            if (!string.IsNullOrEmpty(txttennhanvien.Text))
            {
                if (bd.LuuThongTinNhanVien(ref err, _nhanvien) == true)
                {
                    MessageBox.Show("Nhân viên có mã số " + _nhanvien.Manhanvien + " đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtmanhanvien.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_NhanVien_Modifies_Load(object sender, EventArgs e)
        {
            if (them == true)
            {
                TangMaSoNhanVien();
                txtmanhanvien.Text = manhanvien;
                lbltieude.Text = "Thêm nhân viên";
            }
            else
            {
                GanGiaTriVaoCacControl(_nhanvien);
                lbltieude.Text = "Chỉnh sửa nhân viên";
            }
        }
    }
}
