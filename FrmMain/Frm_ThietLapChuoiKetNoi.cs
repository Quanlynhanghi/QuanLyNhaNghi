using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FrmMain
{
    public partial class Frm_ThietLapChuoiKetNoi : Form
    {
        public Frm_ThietLapChuoiKetNoi()
        {
            InitializeComponent();
        }

        private void Frm_ThietLapChuoiKetNoi_Load(object sender, EventArgs e)
        {
             if (File.Exists(cls_Main.duongdanfileketnoi))
            {
                cls_DataLayer data = new cls_DataLayer(cls_Main.duongdanfileketnoi);
                if (data.Demsothuoctinh > 2)
                {
                    ckbketnoi.Checked = true;
                    txtservername.Text = data.Servername;
                    txtdatabasename.Text = data.Databasename;
                    txtuser.Text = data.Uid;
                    txtmk.Text = data.Pwd;
                }
                else
                {
                    ckbketnoi.Checked = false;
                    txtservername.Text = data.Servername;
                    txtdatabasename.Text = data.Databasename;
                }
            }
            else
            {
                txtservername.Focus();
            }
        
        }

        private void ckbketnoi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbketnoi.Checked == true)
            {
                txtuser.Enabled = true;
                txtmk.Enabled = true;
                ckbketnoi.Text = "Kết nối theo quyền SQL";
            }
            else
            {
                txtuser.Enabled = false;
                txtmk.Enabled = false;
                ckbketnoi.Text = "Kết nối theo quyền Windows";
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void luuchuoiketnoi(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                if (ckbketnoi.Checked == true)
                {
                    //theo quyen sql
                    sw.WriteLine("servername=" + txtservername.Text);
                    sw.WriteLine("database=" + txtdatabasename.Text);
                    sw.WriteLine("userid=" + txtuser.Text);
                    sw.Write("password=" + txtmk.Text);
                }
                else
                {
                    //theo quyen windows
                    sw.WriteLine("servername=" + txtservername.Text);
                    sw.Write("database=" + txtdatabasename.Text);
                }
            }
        }
        string err = "";
        private void btnkiemtraketnoi_Click(object sender, EventArgs e)
        {
            cls_DataLayer data = new cls_DataLayer(cls_Main.duongdanfileketnoi);
            if (data.kiemtraketnoi(ref err) == true)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

       
    }
}
