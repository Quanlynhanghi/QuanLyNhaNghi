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
    public partial class Frm_DichVu : Form
    {
        public Frm_DichVu()
        {
            InitializeComponent();
        }
        BLL_DichVu bd;
        DataTable dtDanhSachDichVu;
        string err = "";
        DTO_DichVu _dichvu;
        private void HienThiDanhSachDichVu()
        {
            dtDanhSachDichVu = new DataTable();
            dtDanhSachDichVu = bd.GetDanhSachSanPham(ref err);
            dgvDichVu.DataSource =dtDanhSachDichVu;
        }

        private void Frm_DichVu_Load(object sender, EventArgs e)
        {
            bd = new BLL_DichVu(cls_Main.duongdanfileketnoi);
            HienThiDanhSachDichVu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_dichvu != null)
            {
                Frm_DichVu_Modifies _frmdichvu_modifies = new Frm_DichVu_Modifies();
                _frmdichvu_modifies._dichvu = _dichvu;
                _frmdichvu_modifies.them = false;
                _frmdichvu_modifies.ShowDialog();
                HienThiDanhSachDichVu();
            }
            else
            {
                MessageBox.Show("Chưa chọn dịch vụ muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SetToDTODichVu(DataGridViewRow dr)
        {
            _dichvu = new DTO.DTO_DichVu();
            _dichvu.Madichvu = dr.Cells["colMadichvu"].Value.ToString();
            _dichvu.Tendichvu = dr.Cells["colTenDichvu"].Value.ToString();
            _dichvu.Gia = Convert.ToDouble(dr.Cells["colGia"].Value.ToString());
            _dichvu.Donvitinh =dr.Cells["colDonvitinh"].Value.ToString();
        }
        private void dgvDichVu_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.Rows.Count > 0)
            {
            SetToDTODichVu(dgvDichVu.CurrentRow);
                if (dgvDichVu.CurrentRow.Cells["colXoa"].Value.ToString() == "1")
                {
                    dgvDichVu.CurrentRow.Cells["colXoa"].Value = 0;
                }
                else
                {
                    dgvDichVu.CurrentRow.Cells["colXoa"].Value = 1;
                }
            }
        }
            
        #region
            //if (dgvDichVu.Rows.Count > 0)
            //{
            //    _dichvu = new DTO_DichVu();
            //    _dichvu.Madichvu = dgvDichVu.CurrentRow.Cells["colMadichvu"].Value.ToString();
            //    _dichvu.Tendichvu = dgvDichVu.CurrentRow.Cells["colTenDichvu"].Value.ToString();
            //    _dichvu.Gia = Convert.ToDouble(dgvDichVu.CurrentRow.Cells["colGia"].Value.ToString());
            //    _dichvu.Donvitinh = dgvDichVu.CurrentRow.Cells["colDonvitinh"].Value.ToString();

            //}

            //private bool DeleteDichVu(DTO_DichVu _dichvu)
            //{
            //    return bd.DeleteDichVu(ref err, _dichvu,ref sodong);
            //}
        #endregion
        int sodong;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = dgvDichVu.RowCount - 1; i >= 0; i--)
            {
                if (dgvDichVu.Rows[i].Cells["colXoa"].Value.ToString() == "1")
                {
                    if (bd.DeleteDichVu(ref err, dgvDichVu.Rows[i].Cells["colMadichvu"].Value.ToString(), ref sodong))
                    {
                        dem += sodong;
                    }
                }
            }
            if (dem > 0)
            {
                MessageBox.Show("Đã xóa được " + dem + " dòng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("không xóa được ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblerr.Text = err;
            }
            HienThiDanhSachDichVu();
            #region
            //for (int i = dgvDichVu.Rows.Count - 1; i >= 0; i--)
            //{
            //    if (dgvDichVu.Rows[i].Cells["colXoa"].Value.ToString()=="1")
            //    {
            //        _dichvu = new DTO_DichVu();
            //        _dichvu.Madichvu = dgvDichVu.Rows[i].Cells["colMadichvu"].Value.ToString();
            //        if (_dichvu != null)
            //        {
            //            if (MessageBox.Show("Có chắc chắn muốn xóa dịch vụ này không.\n Nếu muốn chọn OK, Ngược lại chọn Cancel", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            //            {
            //                DeleteDichVu(_dichvu);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Chưa chọn dịch vụ muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //}
            //HienThiDanhSachDichVu();
            #endregion
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_DichVu_Modifies _frmDichvu = new Frm_DichVu_Modifies();
            _frmDichvu.them = true;
            _frmDichvu.ShowDialog();
            HienThiDanhSachDichVu();
        }
    }
}
