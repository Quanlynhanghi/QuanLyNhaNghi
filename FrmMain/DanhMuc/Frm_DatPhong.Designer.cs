namespace FrmMain.DanhMuc
{
    partial class Frm_DatPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DatPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLưu = new DevExpress.XtraEditors.SimpleButton();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtSoNguoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTienCoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimeNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.dateNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cmbMaPHong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaPhieuThue = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbMaKH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gdvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaphieudat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngayden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaydi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsonguoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltiendatcoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLưu);
            this.panel1.Controls.Add(this.groupPanel2);
            this.panel1.Controls.Add(this.groupPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 249);
            this.panel1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(600, 220);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            // 
            // btnLưu
            // 
            this.btnLưu.Location = new System.Drawing.Point(519, 220);
            this.btnLưu.Name = "btnLưu";
            this.btnLưu.Size = new System.Drawing.Size(75, 23);
            this.btnLưu.TabIndex = 2;
            this.btnLưu.Text = "Lưu ";
            this.btnLưu.Click += new System.EventHandler(this.btnLưu_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtSoNguoi);
            this.groupPanel2.Controls.Add(this.txtTienCoc);
            this.groupPanel2.Controls.Add(this.dateTimeNgayNhan);
            this.groupPanel2.Controls.Add(this.dateNgayDangKy);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.cmbMaPHong);
            this.groupPanel2.Location = new System.Drawing.Point(327, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(476, 213);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "Chi Tiết Phiếu Đạt Phòng";
            // 
            // txtSoNguoi
            // 
            // 
            // 
            // 
            this.txtSoNguoi.Border.Class = "TextBoxBorder";
            this.txtSoNguoi.Location = new System.Drawing.Point(130, 75);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(173, 20);
            this.txtSoNguoi.TabIndex = 9;
            // 
            // txtTienCoc
            // 
            // 
            // 
            // 
            this.txtTienCoc.Border.Class = "TextBoxBorder";
            this.txtTienCoc.Location = new System.Drawing.Point(130, 34);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(173, 20);
            this.txtTienCoc.TabIndex = 9;
            // 
            // dateTimeNgayNhan
            // 
            this.dateTimeNgayNhan.CustomFormat = "hh:mm:ss tt dd/MM/yyyy";
            this.dateTimeNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayNhan.Location = new System.Drawing.Point(127, 159);
            this.dateTimeNgayNhan.Name = "dateTimeNgayNhan";
            this.dateTimeNgayNhan.Size = new System.Drawing.Size(200, 20);
            this.dateTimeNgayNhan.TabIndex = 19;
            // 
            // dateNgayDangKy
            // 
            this.dateNgayDangKy.CustomFormat = "hh:mm:ss tt dd/MM/yyyy";
            this.dateNgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayDangKy.Location = new System.Drawing.Point(130, 120);
            this.dateNgayDangKy.Name = "dateNgayDangKy";
            this.dateNgayDangKy.Size = new System.Drawing.Size(200, 20);
            this.dateNgayDangKy.TabIndex = 18;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(3, 158);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(117, 23);
            this.labelX5.TabIndex = 17;
            this.labelX5.Text = "Ngày nhận dự kiến";
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(3, 72);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(93, 23);
            this.labelX7.TabIndex = 6;
            this.labelX7.Text = "Số Người:";
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(3, 31);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(93, 23);
            this.labelX6.TabIndex = 6;
            this.labelX6.Text = "Tiền Đặt Cọc:";
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(3, 118);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(86, 23);
            this.labelX4.TabIndex = 16;
            this.labelX4.Text = "Ngày đăng ký";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(3, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 14;
            this.labelX3.Text = "Mã phòng";
            // 
            // cmbMaPHong
            // 
            this.cmbMaPHong.DisplayMember = "Text";
            this.cmbMaPHong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaPHong.FormattingEnabled = true;
            this.cmbMaPHong.ItemHeight = 16;
            this.cmbMaPHong.Location = new System.Drawing.Point(130, 4);
            this.cmbMaPHong.Name = "cmbMaPHong";
            this.cmbMaPHong.Size = new System.Drawing.Size(173, 22);
            this.cmbMaPHong.TabIndex = 15;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnThem);
            this.groupPanel1.Controls.Add(this.txtMaPhieuThue);
            this.groupPanel1.Controls.Add(this.cmbMaKH);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(327, 213);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Phiếu Đặt Phòng";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(252, 75);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(45, 33);
            this.btnThem.TabIndex = 10;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaPhieuThue
            // 
            // 
            // 
            // 
            this.txtMaPhieuThue.Border.Class = "TextBoxBorder";
            this.txtMaPhieuThue.Enabled = false;
            this.txtMaPhieuThue.Location = new System.Drawing.Point(140, 37);
            this.txtMaPhieuThue.Name = "txtMaPhieuThue";
            this.txtMaPhieuThue.Size = new System.Drawing.Size(128, 20);
            this.txtMaPhieuThue.TabIndex = 9;
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.DisplayMember = "Text";
            this.cmbMaKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.ItemHeight = 16;
            this.cmbMaKH.Location = new System.Drawing.Point(140, 81);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(106, 22);
            this.cmbMaKH.TabIndex = 8;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(9, 80);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Tên khách hàng";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(9, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(93, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Mã phiếu thuê";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 249);
            this.gridControl1.MainView = this.gdvDanhSach;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(803, 255);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvDanhSach});
            // 
            // gdvDanhSach
            // 
            this.gdvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colmaphieudat,
            this.colMaPhong,
            this.colngayden,
            this.colngaydi,
            this.colsonguoi,
            this.coltiendatcoc});
            this.gdvDanhSach.GridControl = this.gridControl1;
            this.gdvDanhSach.Name = "gdvDanhSach";
            this.gdvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            // 
            // colmaphieudat
            // 
            this.colmaphieudat.Caption = "Mã Phiếu Đặt";
            this.colmaphieudat.FieldName = "maphieudat";
            this.colmaphieudat.Name = "colmaphieudat";
            this.colmaphieudat.Visible = true;
            this.colmaphieudat.VisibleIndex = 1;
            // 
            // colMaPhong
            // 
            this.colMaPhong.Caption = "Mã Phòng";
            this.colMaPhong.FieldName = "maphong";
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.Visible = true;
            this.colMaPhong.VisibleIndex = 2;
            // 
            // colngayden
            // 
            this.colngayden.Caption = "Ngày Đăng Kí";
            this.colngayden.FieldName = "ngayden";
            this.colngayden.Name = "colngayden";
            this.colngayden.Visible = true;
            this.colngayden.VisibleIndex = 3;
            // 
            // colngaydi
            // 
            this.colngaydi.Caption = "Ngày Đến";
            this.colngaydi.FieldName = "ngaydi";
            this.colngaydi.Name = "colngaydi";
            this.colngaydi.Visible = true;
            this.colngaydi.VisibleIndex = 4;
            // 
            // colsonguoi
            // 
            this.colsonguoi.Caption = "Số Người";
            this.colsonguoi.FieldName = "songuoi";
            this.colsonguoi.Name = "colsonguoi";
            this.colsonguoi.Visible = true;
            this.colsonguoi.VisibleIndex = 5;
            // 
            // coltiendatcoc
            // 
            this.coltiendatcoc.Caption = "Tiền Đặt Cọc";
            this.coltiendatcoc.FieldName = "tiendatcoc";
            this.coltiendatcoc.Name = "coltiendatcoc";
            this.coltiendatcoc.Visible = true;
            this.coltiendatcoc.VisibleIndex = 6;
            // 
            // Frm_DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 504);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_DatPhong";
            this.Text = "Frm_DatPhong";
            this.Load += new System.EventHandler(this.Frm_DatPhong_Load);
            this.panel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLưu;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoNguoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTienCoc;
        private System.Windows.Forms.DateTimePicker dateTimeNgayNhan;
        private System.Windows.Forms.DateTimePicker dateNgayDangKy;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaPHong;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPhieuThue;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaKH;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colmaphieudat;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colngayden;
        private DevExpress.XtraGrid.Columns.GridColumn colngaydi;
        private DevExpress.XtraGrid.Columns.GridColumn colsonguoi;
        private DevExpress.XtraGrid.Columns.GridColumn coltiendatcoc;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}