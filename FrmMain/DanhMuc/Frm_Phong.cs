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
    public partial class Frm_Phong : Form
    {
        public Frm_Phong()
        {
            InitializeComponent();
        }
        BLL_Phong bd;
        DataTable dtDanhSachPhong;
        string err = "";
        DTO_Phong _phong;
        private void HienThiDanhSachPhong()
        {
            dtDanhSachPhong = new DataTable();
            dtDanhSachPhong = bd.GetDanhSachPhong(ref err);
            dgvPhong.DataSource = dtDanhSachPhong.DefaultView;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_Phong_Modifies _frmphong = new Frm_Phong_Modifies();
            _frmphong.them = true;
            _frmphong.ShowDialog();
            HienThiDanhSachPhong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_phong != null)
            {
                Frm_Phong_Modifies _frmphong_modifies = new Frm_Phong_Modifies();
                _frmphong_modifies._phong = _phong;
                _frmphong_modifies.them = false;
                _frmphong_modifies.ShowDialog();
                HienThiDanhSachPhong();
            }
            else
            {
                MessageBox.Show("Chưa chọn dịch vụ muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int sodong;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = dgvPhong.RowCount - 1; i >= 0; i--)
            {
                if (dgvPhong.Rows[i].Cells["colXoa"].Value.ToString() == "1")
                {
                    if (bd.DeletePhong(ref err, dgvPhong.Rows[i].Cells["colmaphong"].Value.ToString(), ref sodong))
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
            HienThiDanhSachPhong();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetToDTODichVu(DataGridViewRow dr)
        {
            _phong = new DTO.DTO_Phong();
            _phong.Maphong = dr.Cells["colmaphong"].Value.ToString();
            _phong.Maloai = dr.Cells["colmaloai"].Value.ToString();
            _phong.Trangthai =dr.Cells["coltrangthai"].Value.ToString();
            _phong.Giaphong = Convert.ToDouble(dr.Cells["colgiaphong"].Value.ToString());
        }
        private void dgvPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.Rows.Count > 0)
            {
                SetToDTODichVu(dgvPhong.CurrentRow);
                if (dgvPhong.CurrentRow.Cells["colxoa"].Value.ToString() == "1")
                {
                    dgvPhong.CurrentRow.Cells["colxoa"].Value = 0;
                }
                else
                {
                    dgvPhong.CurrentRow.Cells["colxoa"].Value = 1;
                }
            }
        }

        private void Frm_Phong_Load(object sender, EventArgs e)
        {
            bd = new BLL_Phong(cls_Main.duongdanfileketnoi);
            HienThiDanhSachPhong();
        }
    }
}
