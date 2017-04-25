using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrmMain.Bussiness;

namespace FrmMain.HeThong
{
    public partial class Frm_NguoiDung : Form
    {
        public Frm_NguoiDung()
        {
            InitializeComponent();
        }
        private string err="";
        private void HienThiDanhSach()
        {
            dtDanhSach= new DataTable();
            dtDanhSach = bd.GetDanhSach(ref err);
            gridControl1.DataSource = dtDanhSach;
        }
        DataTable dtDanhSach;
        BLL_HeThong bd;
        private void hiencombox()
        {
            cmbLoaiNDung.Items.Add("1");
            cmbLoaiNDung.Items.Add("2");
            cmbLoaiNDung.Text = "Chọn loại";
            DataTable dt = new DataTable();
            dt = bd.GetNhaVien(ref err);
            cmbnhanvien.DataSource = dt;
            cmbnhanvien.ValueMember = "manhanvien";
            cmbnhanvien.DisplayMember = "tennhanvien";
            
        }
        private void Frm_NguoiDung_Load(object sender, EventArgs e)
        {
            bd = new BLL_HeThong(cls_Main.duongdanfileketnoi);
            HienThiDanhSach();
            hiencombox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtTenDangnhap.Text))
            {
                if (bd.Insert(ref err, txtTenDangnhap.Text,cmbnhanvien.SelectedValue.ToString(),Convert.ToInt32(cmbLoaiNDung.Text)) == true)
                {
                    MessageBox.Show("Người dùng có tên " + txtTenDangnhap.Text+ " đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            HienThiDanhSach();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            txtTenDangnhap.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "username").ToString();
            cmbnhanvien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "tennhanvien").ToString();
           cmbLoaiNDung.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "loaitaikhoan").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn cấp lại mật khẩu tài khoản " + txtTenDangnhap.Text + "không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (bd.Update(ref err, txtTenDangnhap.Text) == true)
                {
                    MessageBox.Show("Tài khoản có tên " + txtTenDangnhap.Text + " đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            HienThiDanhSach();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa" + txtTenDangnhap.Text + "không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (bd.Delete(ref err, txtTenDangnhap.Text) == true)
                {
                    MessageBox.Show("Tài khoản có tên " + txtTenDangnhap.Text + " đã được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
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
