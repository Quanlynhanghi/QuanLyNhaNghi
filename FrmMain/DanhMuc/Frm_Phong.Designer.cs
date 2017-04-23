namespace FrmMain.DanhMuc
{
    partial class Frm_Phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Phong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerr = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.colstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmaloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgiaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colxoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.dgvPhong);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 310);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 288);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(699, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblerr
            // 
            this.lblerr.Name = "lblerr";
            this.lblerr.Size = new System.Drawing.Size(10, 17);
            this.lblerr.Text = ".";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colstt,
            this.colmaphong,
            this.colmaloai,
            this.coltrangthai,
            this.colgiaphong,
            this.colxoa});
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(0, 25);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(699, 285);
            this.dgvPhong.TabIndex = 1;
            this.dgvPhong.Click += new System.EventHandler(this.dgvPhong_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(699, 25);
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
            // colstt
            // 
            this.colstt.DataPropertyName = "STT";
            this.colstt.HeaderText = "STT";
            this.colstt.Name = "colstt";
            this.colstt.ReadOnly = true;
            this.colstt.Width = 50;
            // 
            // colmaphong
            // 
            this.colmaphong.DataPropertyName = "maphong";
            this.colmaphong.HeaderText = "Mã phòng";
            this.colmaphong.Name = "colmaphong";
            this.colmaphong.ReadOnly = true;
            this.colmaphong.Width = 150;
            // 
            // colmaloai
            // 
            this.colmaloai.DataPropertyName = "loaiphong";
            this.colmaloai.HeaderText = "Loại phòng";
            this.colmaloai.Name = "colmaloai";
            this.colmaloai.ReadOnly = true;
            this.colmaloai.Width = 150;
            // 
            // coltrangthai
            // 
            this.coltrangthai.DataPropertyName = "trangthai";
            this.coltrangthai.HeaderText = "Trạng thái";
            this.coltrangthai.Name = "coltrangthai";
            this.coltrangthai.ReadOnly = true;
            this.coltrangthai.Width = 150;
            // 
            // colgiaphong
            // 
            this.colgiaphong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colgiaphong.DataPropertyName = "giaphong";
            this.colgiaphong.HeaderText = "Giá phòng";
            this.colgiaphong.Name = "colgiaphong";
            this.colgiaphong.ReadOnly = true;
            // 
            // colxoa
            // 
            this.colxoa.DataPropertyName = "xoa";
            this.colxoa.FalseValue = "0";
            this.colxoa.HeaderText = "Xóa";
            this.colxoa.Name = "colxoa";
            this.colxoa.ReadOnly = true;
            this.colxoa.TrueValue = "1";
            this.colxoa.Width = 50;
            // 
            // Frm_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 310);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Phong";
            this.Text = "Frm_Phong";
            this.Load += new System.EventHandler(this.Frm_Phong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblerr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmaphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmaloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgiaphong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colxoa;
    }
}