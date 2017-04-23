using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrmMain.Bussiness;

namespace FrmMain.DanhMuc
{
    public partial class Frm_DangKiThuePhong : Form
    {
        public Frm_DangKiThuePhong()
        {
            InitializeComponent();
        }
        BLL_DangKiThuePhong bd;
        BLL_Phong _bd = new BLL_Phong(cls_Main.duongdanfileketnoi);
        DataTable dtphong;
        private string err = "";
        private void initForm()
        {
            cbbLoaiPhong.Items.Add("Tất Cả");
            cbbLoaiPhong.Items.Add("Bình dân");
            cbbLoaiPhong.Items.Add("Sinh Viên");
            cbbLoaiPhong.Items.Add("Vip");
            cbbTinhTrang.Items.Add("Tất Cả");
            cbbTinhTrang.Items.Add("Trống");
            cbbTinhTrang.Items.Add("Đã Đặt");
            cbbTinhTrang.Items.Add("Đã Nhận");
        }
        private void hiendanhsachphong()
        {
            dtphong = new DataTable();
            dtphong=_bd.GetDanhSachPhong(ref err);
            lsvDanhSach.Clear();
            for (int i = 0; i < dtphong.Rows.Count; i++)
            {
                DataRow dr = dtphong.Rows[i];
                ListViewItem item = new ListViewItem(dr[1].ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dtphong.Rows[i][0].ToString());
                if (bd.trangthai(ref err, dr[1].ToString()).Equals("Trống")) item.ImageIndex = 0;
                if (bd.trangthai(ref err, dr[1].ToString()).Equals("Đã Đặt")) item.ImageIndex = 1;
                if (bd.trangthai(ref err, dr[1].ToString()).Equals("Đã Nhận")) item.ImageIndex = 2;
                item.ToolTipText =  "+ Phòng: " + dr[1].ToString()+ "\n+ Tình trang: " + dr[3].ToString()+"\n+ Giá: " + dr[4].ToString();
                lsvDanhSach.Items.Add(item);
            }
            
        }
        private void Frm_DangKiThuePhong_Load(object sender, EventArgs e)
        {
            bd = new BLL_DangKiThuePhong(cls_Main.duongdanfileketnoi);
            initForm();
            hiendanhsachphong();
        }
        private void DanhSachTimKiemLoại()
        {
            if (cbbLoaiPhong.Text == "Tất Cả")
            {
                hiendanhsachphong();
            }
            else
            {
                dtphong = new DataTable();
                dtphong = bd.GetDanhSachPhongTheoLoại(ref err, cbbLoaiPhong.Text);
                lsvDanhSach.Clear();
                for (int i = 0; i < dtphong.Rows.Count; i++)
                {
                    DataRow dr = dtphong.Rows[i];
                    ListViewItem item = new ListViewItem(dr[1].ToString());
                    ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dtphong.Rows[i][0].ToString());
                    if (bd.trangthai(ref err, dr[1].ToString()).Equals("Trống")) item.ImageIndex = 0;
                    if (bd.trangthai(ref err, dr[1].ToString()).Equals("Đã Đặt")) item.ImageIndex = 1;
                    if (bd.trangthai(ref err, dr[1].ToString()).Equals("Đã Nhận")) item.ImageIndex = 2;
                    item.ToolTipText = "+ Phòng: " + dr[1].ToString() + "\n+ Tình trang: " + dr[3].ToString() + "\n+ Giá: " + dr[4].ToString();
                    lsvDanhSach.Items.Add(item);
                }
            }
        }
        private void DanhSachTimKiemTT()
        {
            if (cbbTinhTrang.Text == "Tất Cả")
            {
                hiendanhsachphong();
            }
            else
            {
                dtphong = new DataTable();
                dtphong = bd.GetDanhSachPhongTheoTT(ref err, cbbTinhTrang.Text);
                lsvDanhSach.Clear();
                for (int i = 0; i < dtphong.Rows.Count; i++)
                {
                    DataRow dr = dtphong.Rows[i];
                    ListViewItem item = new ListViewItem(dr[1].ToString());
                    ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dtphong.Rows[i][0].ToString());
                    if (bd.trangthai(ref err, dr[1].ToString()).Equals("Trống")) item.ImageIndex = 0;
                    if (bd.trangthai(ref err, dr[1].ToString()).Equals("Đã Đặt")) item.ImageIndex = 1;
                    if (bd.trangthai(ref err, dr[1].ToString()).Equals("Đã Nhận")) item.ImageIndex = 2;
                    item.ToolTipText = "+ Phòng: " + dr[1].ToString() + "\n+ Tình trang: " + dr[3].ToString() + "\n+ Giá: " + dr[4].ToString();
                    lsvDanhSach.Items.Add(item);
                }
            }
        }
        private void DanhSachTheoLoai_TrangThai()
        {
            dtphong = new DataTable();
            dtphong = bd.GetDanhSachPhongTheoTT(ref err, cbbTinhTrang.Text,cbbLoaiPhong.Text);
            lsvDanhSach.Clear();
            for (int i = 0; i < dtphong.Rows.Count; i++)
            {
                DataRow dr = dtphong.Rows[i];
                ListViewItem item = new ListViewItem(dr[1].ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dtphong.Rows[i][0].ToString());
                if (bd.trangthai(ref err, dr[1].ToString()).Equals("Trống")) item.ImageIndex = 0;
                if (bd.trangthai(ref err, dr[1].ToString()).Equals("Đã Đặt")) item.ImageIndex = 1;
                if (bd.trangthai(ref err, dr[1].ToString()).Equals("Đã Nhận")) item.ImageIndex = 2;
                item.ToolTipText = "+ Phòng: " + dr[1].ToString() + "\n+ Tình trang: " + dr[3].ToString() + "\n+ Giá: " + dr[4].ToString();
                lsvDanhSach.Items.Add(item);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbLoaiPhong.SelectedText = "Tất Cả";
            cbbTinhTrang.SelectedText = "Tất Cả";
            hiendanhsachphong();
        }

        private void cbbTinhTrang_TextChanged(object sender, EventArgs e)
        {
            if (cbbLoaiPhong.Text != "Tất Cả" && cbbTinhTrang.Text != "Tất Cả")
            {
                DanhSachTheoLoai_TrangThai();
            }
            else
                if (cbbTinhTrang.Text == "Tất Cả") DanhSachTimKiemLoại();
                else DanhSachTimKiemTT();
        }

        private void cbbLoaiPhong_TextChanged(object sender, EventArgs e)
        {
            if (cbbLoaiPhong.Text != "Tất Cả" && cbbTinhTrang.Text != "Tất Cả")
            {
                DanhSachTheoLoai_TrangThai();
            }
            else
                if (cbbLoaiPhong.Text == "Tất Cả") DanhSachTimKiemTT();
                else DanhSachTimKiemLoại();
        }
        public  static string maphong = "";
        private void ToolStripMenuItemDangKy_Click(object sender, EventArgs e)
        {
            Frm_DatPhong _datphong = new Frm_DatPhong();
            maphong=lsvDanhSach.SelectedItems[0].Text;
            _datphong.ShowDialog();
            hiendanhsachphong();
        }

        private void ToolStripMenuItemNhanPhong_Click(object sender, EventArgs e)
        {
            Frm_PhieuNhanPhong _nhanphong = new Frm_PhieuNhanPhong();
            maphong = lsvDanhSach.SelectedItems[0].Text;
            _nhanphong.ShowDialog();
            hiendanhsachphong();
        }

        private void dùngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DungDichVu _dungdv = new Frm_DungDichVu();
            maphong = lsvDanhSach.SelectedItems[0].Text;
            _dungdv.ShowDialog();
            hiendanhsachphong();
        }

        private void ToolStripMenuItemTraPhong_Click(object sender, EventArgs e)
        {
            Frm_HoaDon _dungdv = new Frm_HoaDon();
            maphong = lsvDanhSach.SelectedItems[0].Text;
            _dungdv.ShowDialog();
            hiendanhsachphong();
        }

        private void toolStripThemPhong_Click(object sender, EventArgs e)
        {
            Frm_Phong_Modifies _frmphong = new Frm_Phong_Modifies();
            _frmphong.them = true;
            _frmphong.ShowDialog();
            hiendanhsachphong();
        }

        private void ToolStripCapNhat_Click(object sender, EventArgs e)
        {
            hiendanhsachphong();
        }

       
    }
}
