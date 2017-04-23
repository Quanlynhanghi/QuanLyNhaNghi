namespace FrmMain.DanhMuc
{
    partial class Frm_PhieuNhanPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dtNgayTraDuKien = new System.Windows.Forms.DateTimePicker();
            this.dtNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbMaPHong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtMaPhieuThue = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnThemPhieuNhan = new DevComponents.DotNetBar.ButtonX();
            this.cmbMaKH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbMaPhieuDK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.grdDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmanhaphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaphieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenkhach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaynhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaytra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.groupPanel2);
            this.panel1.Controls.Add(this.groupPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 259);
            this.panel1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(515, 230);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(418, 230);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dtNgayTraDuKien);
            this.groupPanel2.Controls.Add(this.dtNgayNhan);
            this.groupPanel2.Controls.Add(this.labelX8);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.cmbMaPHong);
            this.groupPanel2.Location = new System.Drawing.Point(403, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(401, 218);
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
            this.groupPanel2.TabIndex = 3;
            this.groupPanel2.Text = "Chi tiết phiếu nhận";
            // 
            // dtNgayTraDuKien
            // 
            this.dtNgayTraDuKien.CustomFormat = "hh:mm:ss tt dd/MM/yyyy";
            this.dtNgayTraDuKien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTraDuKien.Location = new System.Drawing.Point(128, 130);
            this.dtNgayTraDuKien.Name = "dtNgayTraDuKien";
            this.dtNgayTraDuKien.Size = new System.Drawing.Size(200, 20);
            this.dtNgayTraDuKien.TabIndex = 3;
            // 
            // dtNgayNhan
            // 
            this.dtNgayNhan.CustomFormat = "hh:mm:ss tt dd/MM/yyyy";
            this.dtNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayNhan.Location = new System.Drawing.Point(128, 83);
            this.dtNgayNhan.Name = "dtNgayNhan";
            this.dtNgayNhan.Size = new System.Drawing.Size(200, 20);
            this.dtNgayNhan.TabIndex = 3;
            // 
            // labelX8
            // 
            this.labelX8.Location = new System.Drawing.Point(12, 127);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(106, 23);
            this.labelX8.TabIndex = 2;
            this.labelX8.Text = "Ngày trả dự kiến";
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(12, 83);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 2;
            this.labelX7.Text = "Ngày nhận";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(12, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Mã phòng";
            // 
            // cmbMaPHong
            // 
            this.cmbMaPHong.DisplayMember = "Text";
            this.cmbMaPHong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaPHong.FormattingEnabled = true;
            this.cmbMaPHong.ItemHeight = 16;
            this.cmbMaPHong.Location = new System.Drawing.Point(128, 23);
            this.cmbMaPHong.Name = "cmbMaPHong";
            this.cmbMaPHong.Size = new System.Drawing.Size(121, 22);
            this.cmbMaPHong.TabIndex = 1;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtMaPhieuThue);
            this.groupPanel1.Controls.Add(this.btnThemPhieuNhan);
            this.groupPanel1.Controls.Add(this.cmbMaKH);
            this.groupPanel1.Controls.Add(this.cmbMaPhieuDK);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(397, 218);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Phiếu nhận phòng";
            // 
            // txtMaPhieuThue
            // 
            // 
            // 
            // 
            this.txtMaPhieuThue.Border.Class = "TextBoxBorder";
            this.txtMaPhieuThue.Location = new System.Drawing.Point(123, 53);
            this.txtMaPhieuThue.Name = "txtMaPhieuThue";
            this.txtMaPhieuThue.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhieuThue.TabIndex = 31;
            // 
            // btnThemPhieuNhan
            // 
            this.btnThemPhieuNhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemPhieuNhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemPhieuNhan.Location = new System.Drawing.Point(249, 53);
            this.btnThemPhieuNhan.Name = "btnThemPhieuNhan";
            this.btnThemPhieuNhan.Size = new System.Drawing.Size(60, 23);
            this.btnThemPhieuNhan.TabIndex = 29;
            this.btnThemPhieuNhan.Text = "Tạo mới";
            this.btnThemPhieuNhan.Click += new System.EventHandler(this.btnThemPhieuNhan_Click);
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.DisplayMember = "Text";
            this.cmbMaKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.ItemHeight = 16;
            this.cmbMaKH.Location = new System.Drawing.Point(123, 113);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(186, 22);
            this.cmbMaKH.TabIndex = 25;
            // 
            // cmbMaPhieuDK
            // 
            this.cmbMaPhieuDK.DisplayMember = "Text";
            this.cmbMaPhieuDK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaPhieuDK.FormattingEnabled = true;
            this.cmbMaPhieuDK.ItemHeight = 16;
            this.cmbMaPhieuDK.Location = new System.Drawing.Point(123, 84);
            this.cmbMaPhieuDK.Name = "cmbMaPhieuDK";
            this.cmbMaPhieuDK.Size = new System.Drawing.Size(131, 22);
            this.cmbMaPhieuDK.TabIndex = 24;
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Navy;
            this.labelX4.Location = new System.Drawing.Point(9, 113);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(107, 23);
            this.labelX4.TabIndex = 16;
            this.labelX4.Text = "Tên khách hàng";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Navy;
            this.labelX3.Location = new System.Drawing.Point(9, 84);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(86, 23);
            this.labelX3.TabIndex = 15;
            this.labelX3.Text = "Phiếu đăng ký";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Navy;
            this.labelX2.Location = new System.Drawing.Point(9, 54);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(107, 23);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "Mã Phiếu Thuê";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 259);
            this.gridControl1.MainView = this.grdDanhSach;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(798, 239);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdDanhSach});
            // 
            // grdDanhSach
            // 
            this.grdDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmanhaphong,
            this.colmaphieu,
            this.coltenkhach,
            this.colmaphong,
            this.colngaynhan,
            this.colNgaytra});
            this.grdDanhSach.GridControl = this.gridControl1;
            this.grdDanhSach.Name = "grdDanhSach";
            this.grdDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // colmanhaphong
            // 
            this.colmanhaphong.Caption = "Mã Phiếu Thuê";
            this.colmanhaphong.FieldName = "maphieuthue";
            this.colmanhaphong.Name = "colmanhaphong";
            this.colmanhaphong.Visible = true;
            this.colmanhaphong.VisibleIndex = 0;
            // 
            // colmaphieu
            // 
            this.colmaphieu.Caption = "Mã Phiếu";
            this.colmaphieu.FieldName = "maphieudat";
            this.colmaphieu.Name = "colmaphieu";
            this.colmaphieu.Visible = true;
            this.colmaphieu.VisibleIndex = 1;
            // 
            // coltenkhach
            // 
            this.coltenkhach.Caption = "Tên Khách Hàng";
            this.coltenkhach.FieldName = "tenkhachhang";
            this.coltenkhach.Name = "coltenkhach";
            this.coltenkhach.Visible = true;
            this.coltenkhach.VisibleIndex = 2;
            // 
            // colmaphong
            // 
            this.colmaphong.Caption = "Mã Phòng";
            this.colmaphong.FieldName = "maphong";
            this.colmaphong.Name = "colmaphong";
            this.colmaphong.Visible = true;
            this.colmaphong.VisibleIndex = 3;
            // 
            // colngaynhan
            // 
            this.colngaynhan.Caption = "Ngày Nhận";
            this.colngaynhan.FieldName = "ngayden";
            this.colngaynhan.Name = "colngaynhan";
            this.colngaynhan.Visible = true;
            this.colngaynhan.VisibleIndex = 4;
            // 
            // colNgaytra
            // 
            this.colNgaytra.Caption = "Ngày Trả";
            this.colNgaytra.Name = "colNgaytra";
            this.colNgaytra.Visible = true;
            this.colNgaytra.VisibleIndex = 5;
            // 
            // Frm_PhieuNhanPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 498);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_PhieuNhanPhong";
            this.Text = "Frm_PhieuNhanPhong";
            this.Load += new System.EventHandler(this.Frm_PhieuNhanPhong_Load);
            this.panel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPhieuThue;
        private DevComponents.DotNetBar.ButtonX btnThemPhieuNhan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaKH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaPhieuDK;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grdDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.DateTimePicker dtNgayTraDuKien;
        private System.Windows.Forms.DateTimePicker dtNgayNhan;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaPHong;
        private DevExpress.XtraGrid.Columns.GridColumn colmanhaphong;
        private DevExpress.XtraGrid.Columns.GridColumn colmaphieu;
        private DevExpress.XtraGrid.Columns.GridColumn coltenkhach;
        private DevExpress.XtraGrid.Columns.GridColumn colmaphong;
        private DevExpress.XtraGrid.Columns.GridColumn colngaynhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaytra;
    }
}