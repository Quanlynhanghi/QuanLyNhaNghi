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

namespace FrmMain.HeThong
{
    public partial class Frm_DoiMatKhau : Form
    {
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        BLL_DoiMatKhau bd;
        DTO_HeThong _hethong;
        private string err="";
        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            bd = new BLL_DoiMatKhau(cls_Main.duongdanfileketnoi);
        }
        private void LayDulieuTuControl()
        {
            _hethong = new DTO_HeThong();
            _hethong.UserName = Frm_DangNhap.tentaikhoan;
            _hethong.PassWordCu = txtMkCu.Text;
            _hethong.PassWord = txtMKM.Text;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            LayDulieuTuControl();
            if (!string.IsNullOrEmpty(txtMkCu.Text) || !string.IsNullOrEmpty(txtMKM.Text) || !string.IsNullOrEmpty(txtMKM2.Text))
            {
                if (bd.DoiMatKhau(ref err, _hethong) == true)
                    {
                        MessageBox.Show("cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin \n Hãy kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }
    }
}
