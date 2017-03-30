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
    public partial class Frm_Phong_Modifies : Form
    {
        public Frm_Phong_Modifies()
        {
            InitializeComponent();
        }

        public bool them = false;
        BLL_Phong bd = new BLL_Phong(cls_Main.duongdanfileketnoi);
        private string Maphong = "";
        private string err = "";
        internal DTO_Phong _phong = new DTO_Phong();
        private void TangMaSoPhong()
        {
            object _obj = null;
            _obj = bd.GetValue(ref err);
            if (_obj != null)
            {
                Maphong = string.Format("PH{0:0000000}", Convert.ToInt32(_obj));
            }
        }
        private void LayGiaTriTuCacControl()
        {
            _phong = new DTO_Phong();
            _phong.Maphong = txtmaphong.Text;
            _phong.Maloai = txtmaloai.Text;
            _phong.Trangthai = txttrangthai.Text;
            _phong.Giaphong =Convert.ToDouble(txtgiaphong.Text);
        }
        private void GanGiaTriVaoCacControl(DTO_Phong _phong)
        {
            txtmaphong.Text = _phong.Maphong;
            txtmaloai.Text = _phong.Maloai;
            txttrangthai.Text = _phong.Trangthai;
            txtgiaphong.Text = _phong.Giaphong.ToString();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_phong != null)
            {
                LayGiaTriTuCacControl();
                if (bd.InsertUpdateSanPham(ref err, _phong) == true)
                {
                    MessageBox.Show("Phòng có mã số " + _phong.Maphong + " đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Phong_Modifies_Load(object sender, EventArgs e)
        {
            if (them == true)
            {
                TangMaSoPhong();
                txtmaphong.Text = Maphong;
                lbltieude.Text = "Thêm phòng";
            }
            else
            {
                GanGiaTriVaoCacControl(_phong);
                lbltieude.Text = "Chỉnh sửa phòng";
            }
        }
    }
}
