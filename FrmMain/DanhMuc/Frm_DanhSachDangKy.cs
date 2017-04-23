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
    public partial class Frm_DanhSachDangKy : Form
    {
        public Frm_DanhSachDangKy()
        {
            InitializeComponent();
        }


        private void HienThiDanhSach()
        {
            dtDanhsach = new DataTable();
            dtDanhsach = bd.LayDanhSach(ref err);
            gridControl1.DataSource = dtDanhsach.DefaultView;
        }
        BLL_DangKiPhong bd;
        DataTable dtDanhsach;
        string err = "";
        private void Frm_DanhSachDangKy_Load(object sender, EventArgs e)
        {
            bd = new BLL_DangKiPhong(cls_Main.duongdanfileketnoi);
            HienThiDanhSach();
        }
        DTO_PhieuDangKy _phieudangky;
        private void SetToDTO()
        {
            _phieudangky = new DTO_PhieuDangKy();
            _phieudangky.Makhachhang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "makhachhang").ToString();
            _phieudangky.Maphieudat = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "maphieudat").ToString();
            _phieudangky.Maphong = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "maphong").ToString();
            _phieudangky.Tenkhachhang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "tenkhachhang").ToString();

        }
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            Frm_DatPhong _datphong = new Frm_DatPhong();
            _datphong.ShowDialog();
            HienThiDanhSach();
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            SetToDTO();
            if (_phieudangky != null)
            {
                Frm_DatPhong _frmdichvu_modifies = new Frm_DatPhong();
                _frmdichvu_modifies._phieudangky = _phieudangky;
                _frmdichvu_modifies.them = false;
                _frmdichvu_modifies.ShowDialog();
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Chưa chọn dịch vụ muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            SetToDTO();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SetToDTO();
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa" + _phieudangky.Maphieudat + "không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (bd.delete(ref err, _phieudangky) == true)
                {
                    MessageBox.Show("Phòng có mã số " + _phieudangky.Maphieudat + " đã được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            HienThiDanhSach();
        }
    }
}
