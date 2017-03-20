using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrmMain.HeThong;

namespace FrmMain
{
    public partial class Frrm_Main : Form
    {
        public Frrm_Main()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            Frm_DangNhap _dangnhap = new Frm_DangNhap();
            _dangnhap.ShowDialog();
        }



        public static string tennhanvien { get; set; }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            Frm_DangNhap _dangnhap = new Frm_DangNhap();
            _dangnhap.ShowDialog();
        }
    }
}
