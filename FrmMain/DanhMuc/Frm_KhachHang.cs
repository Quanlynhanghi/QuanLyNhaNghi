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
    public partial class Frm_KhachHang : Form
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }
        BLL_KhachHang bd;
        DataTable dtDanhSachKhachHang;
        string err = "";
        DTO_KhachHang _khachhang;
        private void HienThiDanhSachKhachHang()
        {
            dtDanhSachKhachHang = new DataTable();
            dtDanhSachKhachHang = bd.LayDanhSachKhachHang(ref err);
            dgvDSKhachHang.DataSource = dtDanhSachKhachHang;
        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            bd = new BLL_KhachHang(cls_Main.duongdanfileketnoi);
            HienThiDanhSachKhachHang();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_KhachHang_Modifies _khachhang = new Frm_KhachHang_Modifies();
            _khachhang.them = true;
            _khachhang.ShowDialog();
            HienThiDanhSachKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_khachhang != null)
            {
                Frm_KhachHang_Modifies _frmkhachhang_modifies = new Frm_KhachHang_Modifies();
                _frmkhachhang_modifies._khachhang = _khachhang;
                _frmkhachhang_modifies.them = false;
                _frmkhachhang_modifies.ShowDialog();
                HienThiDanhSachKhachHang();
            }
            else
            {
                MessageBox.Show("Chưa chọn khách hàng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void SetToDTOKhachHang(DataGridViewRow dr)
        {
            _khachhang = new DTO.DTO_KhachHang();
            _khachhang.Makhachhang = dr.Cells["colmakhachhang"].Value.ToString();
            _khachhang.Tenkhachhang= dr.Cells["coltenkhachhang"].Value.ToString();
            _khachhang.Gioitinh = Convert.ToBoolean(dr.Cells["colgioitinh"].Value.ToString());
            _khachhang.Cmnd = dr.Cells["colsocmnd"].Value.ToString();
            _khachhang.Sodienthoai = dr.Cells["colsodienthoai"].Value.ToString();
            _khachhang.DiaChi = dr.Cells["coldiachi"].Value.ToString();
            _khachhang.Email = dr.Cells["colemail"].Value.ToString();
            _khachhang.Loaikhach = dr.Cells["colloaikhach"].Value.ToString();
        }
        private void dgvDSKhachHang_Click(object sender, EventArgs e)
        {
            if (dgvDSKhachHang.Rows.Count > 0)
            {
                SetToDTOKhachHang(dgvDSKhachHang.CurrentRow);
                if (dgvDSKhachHang.CurrentRow.Cells["coldelete"].Value.ToString() == "1")
                {
                    dgvDSKhachHang.CurrentRow.Cells["coldelete"].Value = 0;
                }
                else
                {
                    dgvDSKhachHang.CurrentRow.Cells["coldelete"].Value = 1;
                }
            }
            #region
            //if (dgvDSKhachHang.Rows.Count > 0)
            //{
            //    _khachhang = new DTO_KhachHang();
            //    _khachhang.Makhachhang = dgvDSKhachHang.CurrentRow.Cells["colmakhachhang"].Value.ToString();
            //    _khachhang.Tenkhachhang = dgvDSKhachHang.CurrentRow.Cells["coltenkhachhang"].Value.ToString();
            //    _khachhang.Gioitinh =Convert.ToBoolean(dgvDSKhachHang.CurrentRow.Cells["colgioitinh"].Value.ToString());
            //    _khachhang.Cmnd = dgvDSKhachHang.CurrentRow.Cells["colsocmnd"].Value.ToString();
            //    _khachhang.DiaChi = dgvDSKhachHang.CurrentRow.Cells["coldiachi"].Value.ToString();
            //    _khachhang.Sodienthoai = dgvDSKhachHang.CurrentRow.Cells["colsodienthoai"].Value.ToString();
            //    _khachhang.Email = dgvDSKhachHang.CurrentRow.Cells["colemail"].Value.ToString();
            //    _khachhang.Loaikhach = dgvDSKhachHang.CurrentRow.Cells["colloaikhach"].Value.ToString();

            //}
            #endregion
        }
        int sodong;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = dgvDSKhachHang.RowCount - 1; i >= 0; i--)
            {
                if (dgvDSKhachHang.Rows[i].Cells["coldelete"].Value.ToString() == "1")
                {
                    if (bd.DeleteKhachHang(ref err, dgvDSKhachHang.Rows[i].Cells["colmakhachhang"].Value.ToString(), ref sodong))
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
            HienThiDanhSachKhachHang();
        }
    }
}
