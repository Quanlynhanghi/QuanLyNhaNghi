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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
        }

        BLL_NhanVien bd;
        DataTable dtDanhSachNhanVien;
        string err = "";
        DTO_NhanVien _nhanvien;
        private void HienThiDanhSachNhanVien()
        {
            dtDanhSachNhanVien = new DataTable();
            dtDanhSachNhanVien = bd.LayDanhSachNhanVien(ref err);
            dgvNhanVien.DataSource = dtDanhSachNhanVien;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_NhanVien_Modifies _nhanvien = new Frm_NhanVien_Modifies();
            _nhanvien.them = true;
            _nhanvien.ShowDialog();
            HienThiDanhSachNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_nhanvien != null)
            {
                Frm_NhanVien_Modifies _frmnhanvien_modifies = new Frm_NhanVien_Modifies();
                _frmnhanvien_modifies._nhanvien = _nhanvien;
                _frmnhanvien_modifies.them = false;
                _frmnhanvien_modifies.ShowDialog();
                HienThiDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetToDTOKhachHang(DataGridViewRow dr)
        {
            _nhanvien = new DTO.DTO_NhanVien();
            _nhanvien.Manhanvien = dr.Cells["colmanhanvien"].Value.ToString();
            _nhanvien.Tennhanvien = dr.Cells["coltennhanvien"].Value.ToString();
            _nhanvien.Ngaysinh = dr.Cells["colngaysinh"].Value.ToString();
            _nhanvien.Phai = Convert.ToBoolean(dr.Cells["colgioitinh"].Value.ToString());
            _nhanvien.Diachi = dr.Cells["coldiachi"].Value.ToString();
            _nhanvien.Phone = dr.Cells["colsdt"].Value.ToString();
            _nhanvien.Chucvu = dr.Cells["colchucvu"].Value.ToString();
        }

        int sodong;
        private void btnxoa_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = dgvNhanVien.RowCount - 1; i >= 0; i--)
            {
                if (dgvNhanVien.Rows[i].Cells["colxoa"].Value.ToString() == "1")
                {
                    if (bd.DeleteNhanVien(ref err, dgvNhanVien.Rows[i].Cells["colmanhanvien"].Value.ToString(), ref sodong))
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
            HienThiDanhSachNhanVien();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhanVien(cls_Main.duongdanfileketnoi);
            HienThiDanhSachNhanVien();
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count > 0)
            {
                SetToDTOKhachHang(dgvNhanVien.CurrentRow);
                if (dgvNhanVien.CurrentRow.Cells["colxoa"].Value.ToString() == "1")
                {
                    dgvNhanVien.CurrentRow.Cells["colxoa"].Value = 0;
                }
                else
                {
                    dgvNhanVien.CurrentRow.Cells["colxoa"].Value = 1;
                }
            }
        }
    }
}
