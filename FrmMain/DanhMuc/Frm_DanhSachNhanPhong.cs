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
    public partial class Frm_DanhSachNhanPhong : Form
    {
        public Frm_DanhSachNhanPhong()
        {
            InitializeComponent();
        }
        BLL_PhieuNhan bd;
        DTO_PhieuNhanPhong _nhanphong;
        string err = "";
        DataTable dtDanhsach;
        private void HienThiDanhSach()
        {
            dtDanhsach = new DataTable();
            dtDanhsach = bd.LayDanhSach(ref err);
            gridControl1.DataSource = dtDanhsach.DefaultView;
        }
        private void Frm_DanhSachNhanPhong_Load(object sender, EventArgs e)
        {
            bd = new BLL_PhieuNhan(cls_Main.duongdanfileketnoi);
            HienThiDanhSach();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Frm_PhieuNhanPhong _datphong = new Frm_PhieuNhanPhong();
            _datphong.ShowDialog();
            HienThiDanhSach();
        }
    }
}
