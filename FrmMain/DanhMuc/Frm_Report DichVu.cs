using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrmMain.DanhMuc
{
    public partial class Frm_Report_DichVu : Form
    {
        public Frm_Report_DichVu()
        {
            InitializeComponent();
        }

        private void Frm_Report_DichVu_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
