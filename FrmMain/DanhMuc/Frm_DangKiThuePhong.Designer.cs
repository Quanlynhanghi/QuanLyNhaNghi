namespace FrmMain.DanhMuc
{
    partial class Frm_DangKiThuePhong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DangKiThuePhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDangKy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNhanPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTraPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.dùngDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripThemPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 41);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(317, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "DANH SÁCH PHÒNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(317, 401);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Tìm kiếm :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbbTinhTrang, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbbLoaiPhong, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 1, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 357);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tình trạng phòng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Loại phòng:";
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Location = new System.Drawing.Point(138, 3);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(165, 24);
            this.cbbTinhTrang.TabIndex = 18;
            this.cbbTinhTrang.Tag = "";
            this.cbbTinhTrang.Text = "Tất Cả";
            this.cbbTinhTrang.TextChanged += new System.EventHandler(this.cbbTinhTrang_TextChanged);
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(138, 121);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(161, 24);
            this.cbbLoaiPhong.TabIndex = 19;
            this.cbbLoaiPhong.Tag = "";
            this.cbbLoaiPhong.Text = "Tất Cả";
            this.cbbLoaiPhong.TextChanged += new System.EventHandler(this.cbbLoaiPhong_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(138, 239);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(146, 72);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhSach.LargeImageList = this.imageList;
            this.lsvDanhSach.Location = new System.Drawing.Point(317, 41);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.ShowItemToolTips = true;
            this.lsvDanhSach.Size = new System.Drawing.Size(436, 401);
            this.lsvDanhSach.SmallImageList = this.imageList;
            this.lsvDanhSach.TabIndex = 3;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDangKy,
            this.ToolStripMenuItemNhanPhong,
            this.ToolStripMenuItemTraPhong,
            this.dùngDịchVụToolStripMenuItem,
            this.toolStripThemPhong,
            this.ToolStripCapNhat});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 158);
            // 
            // ToolStripMenuItemDangKy
            // 
            this.ToolStripMenuItemDangKy.Name = "ToolStripMenuItemDangKy";
            this.ToolStripMenuItemDangKy.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemDangKy.Text = "Đăng ký";
            this.ToolStripMenuItemDangKy.Click += new System.EventHandler(this.ToolStripMenuItemDangKy_Click);
            // 
            // ToolStripMenuItemNhanPhong
            // 
            this.ToolStripMenuItemNhanPhong.Name = "ToolStripMenuItemNhanPhong";
            this.ToolStripMenuItemNhanPhong.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemNhanPhong.Text = "Nhận phòng";
            this.ToolStripMenuItemNhanPhong.Click += new System.EventHandler(this.ToolStripMenuItemNhanPhong_Click);
            // 
            // ToolStripMenuItemTraPhong
            // 
            this.ToolStripMenuItemTraPhong.Name = "ToolStripMenuItemTraPhong";
            this.ToolStripMenuItemTraPhong.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemTraPhong.Text = "Trả phòng";
            this.ToolStripMenuItemTraPhong.Click += new System.EventHandler(this.ToolStripMenuItemTraPhong_Click);
            // 
            // dùngDịchVụToolStripMenuItem
            // 
            this.dùngDịchVụToolStripMenuItem.Name = "dùngDịchVụToolStripMenuItem";
            this.dùngDịchVụToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dùngDịchVụToolStripMenuItem.Text = "Dùng dịch vụ";
            this.dùngDịchVụToolStripMenuItem.Click += new System.EventHandler(this.dùngDịchVụToolStripMenuItem_Click);
            // 
            // toolStripThemPhong
            // 
            this.toolStripThemPhong.Name = "toolStripThemPhong";
            this.toolStripThemPhong.Size = new System.Drawing.Size(152, 22);
            this.toolStripThemPhong.Text = "Thêm phòng";
            this.toolStripThemPhong.Click += new System.EventHandler(this.toolStripThemPhong_Click);
            // 
            // ToolStripCapNhat
            // 
            this.ToolStripCapNhat.Name = "ToolStripCapNhat";
            this.ToolStripCapNhat.Size = new System.Drawing.Size(152, 22);
            this.ToolStripCapNhat.Text = "Cập nhật";
            this.ToolStripCapNhat.Click += new System.EventHandler(this.ToolStripCapNhat_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Home.png");
            this.imageList.Images.SetKeyName(1, "LaST (Cobalt) RTF File.png");
            this.imageList.Images.SetKeyName(2, "Login Manager.png");
            // 
            // Frm_DangKiThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 442);
            this.Controls.Add(this.lsvDanhSach);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_DangKiThuePhong";
            this.Text = "Frm_DangKiThuePhong";
            this.Load += new System.EventHandler(this.Frm_DangKiThuePhong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDangKy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNhanPhong;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTraPhong;
        private System.Windows.Forms.ToolStripMenuItem dùngDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripThemPhong;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCapNhat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.ComboBox cbbLoaiPhong;
    }
}