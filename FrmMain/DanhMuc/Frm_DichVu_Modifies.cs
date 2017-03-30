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
    public partial class Frm_DichVu_Modifies : Form
    {
        public Frm_DichVu_Modifies()
        {
            InitializeComponent();
        }
        public bool them = false;
        BLL_DichVu bd = new BLL_DichVu(cls_Main.duongdanfileketnoi);
        private string Madichvu = "";
        private string err = "";

        internal DTO_DichVu _dichvu = new DTO_DichVu();
        private void TangMaSoDichVu()
        {
            object _obj = null;
            _obj = bd.GetValue(ref err);
            if (_obj != null)
            {
                Madichvu = string.Format("DV{0:0000000}", Convert.ToInt32(_obj));
            }
        }
        private void LayGiaTriTuCacControl()
        {
            _dichvu = new DTO_DichVu();
            _dichvu.Madichvu = txtmadichvu.Text;
            _dichvu.Tendichvu = txttendichvu.Text;
            _dichvu.Gia = Convert.ToDouble(txtgia.Text);
            _dichvu.Donvitinh = txtdonvitinh.Text;
        }
        private void GanGiaTriVaoCacControl(DTO_DichVu _dichvu)
        {
            txtmadichvu.Text = _dichvu.Madichvu;
            txttendichvu.Text = _dichvu.Tendichvu;
            txtgia.Text =_dichvu.Gia.ToString();
            txtdonvitinh.Text = _dichvu.Donvitinh;
        }

        private void Frm_DichVu_Modifies_Load(object sender, EventArgs e)
        {
            if (them == true)
            {
                TangMaSoDichVu();
                txtmadichvu.Text = Madichvu;
                lbltieude.Text = "Thêm dịch vụ";
            }
            else
            {
                GanGiaTriVaoCacControl(_dichvu);
                lbltieude.Text = "Chỉnh sửa dịch vụ";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_dichvu != null)
            {
                LayGiaTriTuCacControl();
                if (bd.InsertUpdateSanPham(ref err, _dichvu) == true)
                {
                    MessageBox.Show("Dịch vụ có mã số " + _dichvu.Madichvu + " đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
