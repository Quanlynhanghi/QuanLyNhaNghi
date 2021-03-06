﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using FrmMain.Bussiness;

namespace FrmMain.DanhMuc
{
    public partial class Frm_Report_DichVu : Form
    {
        public Frm_Report_DichVu()
        {
            InitializeComponent();
        }
        BLL_DungDV bd = new BLL_DungDV(cls_Main.duongdanfileketnoi);
        string err = "";
        public string mahoadon = "";
        private void hienthireport()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = bd.Thongke(ref err);
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "FrmMain.DanhMuc." + "Rp_ThongKeDichVu.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource _datasource = new ReportDataSource("DichVu", dt);
            reportViewer1.LocalReport.DataSources.Add(_datasource);
            this.reportViewer1.RefreshReport();
        }
        private void Frm_Report_DichVu_Load(object sender, EventArgs e)
        {
            hienthireport();
            this.reportViewer1.RefreshReport();
        }
    }
}
