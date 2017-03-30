namespace FrmMain.DanhMuc
{
    partial class Frm_KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerr = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvDSKhachHang = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmakhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsocmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colloaikhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.dgvDSKhachHang);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 367);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(988, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblerr
            // 
            this.lblerr.Name = "lblerr";
            this.lblerr.Size = new System.Drawing.Size(10, 17);
            this.lblerr.Text = ".";
            // 
            // dgvDSKhachHang
            // 
            this.dgvDSKhachHang.AllowUserToAddRows = false;
            this.dgvDSKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvDSKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colmakhachhang,
            this.coltenkhachhang,
            this.colgioitinh,
            this.colsocmnd,
            this.coldiachi,
            this.colsodienthoai,
            this.colemail,
            this.colloaikhach,
            this.coldelete});
            this.dgvDSKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSKhachHang.Location = new System.Drawing.Point(0, 25);
            this.dgvDSKhachHang.Name = "dgvDSKhachHang";
            this.dgvDSKhachHang.ReadOnly = true;
            this.dgvDSKhachHang.RowHeadersVisible = false;
            this.dgvDSKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKhachHang.Size = new System.Drawing.Size(988, 342);
            this.dgvDSKhachHang.TabIndex = 1;
            this.dgvDSKhachHang.Click += new System.EventHandler(this.dgvDSKhachHang_Click);
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 50;
            // 
            // colmakhachhang
            // 
            this.colmakhachhang.DataPropertyName = "makhachhang";
            this.colmakhachhang.HeaderText = "Mã khách hàng";
            this.colmakhachhang.Name = "colmakhachhang";
            this.colmakhachhang.ReadOnly = true;
            this.colmakhachhang.Width = 110;
            // 
            // coltenkhachhang
            // 
            this.coltenkhachhang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coltenkhachhang.DataPropertyName = "tenkhachhang";
            this.coltenkhachhang.HeaderText = "Tên khách hàng";
            this.coltenkhachhang.Name = "coltenkhachhang";
            this.coltenkhachhang.ReadOnly = true;
            // 
            // colgioitinh
            // 
            this.colgioitinh.DataPropertyName = "gioitinh";
            this.colgioitinh.HeaderText = "Giới tính";
            this.colgioitinh.Name = "colgioitinh";
            this.colgioitinh.ReadOnly = true;
            this.colgioitinh.Width = 80;
            // 
            // colsocmnd
            // 
            this.colsocmnd.DataPropertyName = "cmnd_passport";
            this.colsocmnd.HeaderText = "Số chứng minh";
            this.colsocmnd.Name = "colsocmnd";
            this.colsocmnd.ReadOnly = true;
            this.colsocmnd.Width = 130;
            // 
            // coldiachi
            // 
            this.coldiachi.DataPropertyName = "diachi";
            this.coldiachi.HeaderText = "Địa chỉ";
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.ReadOnly = true;
            this.coldiachi.Width = 120;
            // 
            // colsodienthoai
            // 
            this.colsodienthoai.DataPropertyName = "sodienthoai";
            this.colsodienthoai.HeaderText = "Số điện thoại";
            this.colsodienthoai.Name = "colsodienthoai";
            this.colsodienthoai.ReadOnly = true;
            // 
            // colemail
            // 
            this.colemail.DataPropertyName = "email";
            this.colemail.HeaderText = "Email";
            this.colemail.Name = "colemail";
            this.colemail.ReadOnly = true;
            this.colemail.Width = 120;
            // 
            // colloaikhach
            // 
            this.colloaikhach.DataPropertyName = "loaikhach";
            this.colloaikhach.HeaderText = "Loại Khách";
            this.colloaikhach.Name = "colloaikhach";
            this.colloaikhach.ReadOnly = true;
            // 
            // coldelete
            // 
            this.coldelete.DataPropertyName = "Xoa";
            this.coldelete.FalseValue = "0";
            this.coldelete.HeaderText = "Xóa";
            this.coldelete.Name = "coldelete";
            this.coldelete.ReadOnly = true;
            this.coldelete.TrueValue = "1";
            this.coldelete.Width = 50;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(988, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(58, 22);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(58, 22);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 367);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_KhachHang";
            this.Text = "Frm_KhachHang";
            this.Load += new System.EventHandler(this.Frm_KhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.DataGridView dgvDSKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmakhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsocmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colloaikhach;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coldelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblerr;
    }
}