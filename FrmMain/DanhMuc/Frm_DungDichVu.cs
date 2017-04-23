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
    public partial class Frm_DungDichVu : Form
    {
        public Frm_DungDichVu()
        {
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            TangMa();
            txtMaSuDung.Text = MaDungDV;
            LayGiaTriTuCacControl();
            if(_dichvu!=null)
            {
                 if (bd.Insert(ref err, _dichvu) == true)
                {
                    MessageBox.Show("Phòng có mã số " + _dichvu.Masudung + " đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            HienThiDanhSach();
        }
        private void TangMa()
        {
            object _obj = null;
            _obj = bd.GetValue(ref err);
            if (_obj != null)
            {
                MaDungDV = string.Format("DDV{0:00000}", Convert.ToInt32(_obj));
            }
        }

        BLL_DungDV bd;
        string MaDungDV = "";
        string err = "";
        DataTable dtDanhsach;
        DTO_Dungdichvu _dichvu;
        private void HienThiDanhSach()
        {
            dtDanhsach = new DataTable();
            dtDanhsach = bd.LayDanhSach(ref err);
            gridControl1.DataSource = dtDanhsach.DefaultView;
        }
        private void LayGiaTriTuCacControl()
        {
            _dichvu = new DTO_Dungdichvu();
            _dichvu.Maphieuthue = cmbMaCTNhanPhong.Text;
            _dichvu.Madichvu = cmbMadichvu.SelectedValue.ToString();
            _dichvu.Soluong = Convert.ToInt16(numSoLuong.Value);
            _dichvu.Masudung = txtMaSuDung.Text;
        }
        private void HienThiComBox()
        {
            BLL_DichVu bd = new BLL_DichVu(cls_Main.duongdanfileketnoi);
            DataTable dtDanhSachDichVu;
            BLL_PhieuNhan bdphieu = new BLL_PhieuNhan(cls_Main.duongdanfileketnoi);
            DataTable dtDanhSachPhieu;
            dtDanhSachDichVu = new DataTable();
            dtDanhSachDichVu = bd.GetDanhSachSanPham(ref err);
            cmbMadichvu.DataSource = dtDanhSachDichVu;
            cmbMadichvu.ValueMember = "madichvu";
            cmbMadichvu.DisplayMember = "tendichvu";
            dtDanhSachPhieu = new DataTable();
            dtDanhSachPhieu = bdphieu.LayDanhSach(ref err);
            cmbMaCTNhanPhong.DataSource = dtDanhSachPhieu;
            cmbMaCTNhanPhong.DisplayMember = "maphieuthue";
            //cmbMaPHong.Text = Frm_DangKiThuePhong.maphong;
        }
        private void DungDichVu_Load(object sender, EventArgs e)
        {
            bd = new BLL_DungDV(cls_Main.duongdanfileketnoi);
            HienThiComBox();
            HienThiDanhSach();
        }
        private void SetToDTODichVu()
        {
            _dichvu = new DTO_Dungdichvu();
            _dichvu.Masudung = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "masudung").ToString();
            _dichvu.Madichvu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "madichvu").ToString();
            _dichvu.Maphieuthue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "maphieuthue").ToString();
            _dichvu.Soluong =Convert.ToInt32 (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "soluong"));
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            
            if (_dichvu != null)
            {
                LayGiaTriTuCacControl();
                if (bd.Updata(ref err, _dichvu) == true)
                {
                    MessageBox.Show("Phòng có mã số " + _dichvu.Masudung + " đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            HienThiDanhSach();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            SetToDTODichVu();
            txtMaSuDung.Text = _dichvu.Masudung;
            cmbMadichvu.Text = _dichvu.Madichvu;
            cmbMaCTNhanPhong.Text = _dichvu.Maphieuthue;
            numSoLuong.Value = _dichvu.Soluong;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            SetToDTODichVu();
            txtMaSuDung.Text = _dichvu.Masudung;
            cmbMadichvu.Text = _dichvu.Madichvu;
            cmbMaCTNhanPhong.Text = _dichvu.Maphieuthue;
            numSoLuong.Value = _dichvu.Soluong;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa" + txtMaSuDung.Text + "không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (bd.delete(ref err, _dichvu) == true)
                {
                    MessageBox.Show("Phòng có mã số " + _dichvu.Masudung + " đã được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
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
