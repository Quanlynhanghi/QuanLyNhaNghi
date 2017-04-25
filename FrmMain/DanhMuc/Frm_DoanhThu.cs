using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrmMain.Bussiness;
using Microsoft.Reporting.WinForms;

namespace FrmMain.DanhMuc
{
    public partial class Frm_DoanhThu : Form
    {
        public Frm_DoanhThu()
        {
            InitializeComponent();
        }
        BLL_HoaDon bd = new BLL_HoaDon(cls_Main.duongdanfileketnoi);
        string err = "";
        public string mahoadon = "";
        private void hienthireport()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = bd.LayDanhSach(ref err);
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "FrmMain.DanhMuc." + "Rp_DoanhThu.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource _datasource = new ReportDataSource("HoaDon", dt);
            reportViewer1.LocalReport.DataSources.Add(_datasource);
            this.reportViewer1.RefreshReport();
        }
        
        private void Frm_DoanhThu_Load(object sender, EventArgs e)
        {
            hienthireport();
            this.reportViewer1.RefreshReport();
        }
    }
}
