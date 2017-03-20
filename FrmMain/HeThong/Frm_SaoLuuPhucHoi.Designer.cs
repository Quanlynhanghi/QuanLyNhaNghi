namespace FrmMain.HeThong
{
    partial class Frm_SaoLuuPhucHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SaoLuuPhucHoi));
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.lbltieude = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsaoluu = new System.Windows.Forms.ToolStripButton();
            this.btnlayduongdanfile = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtduongdan = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(58, 22);
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // lbltieude
            // 
            this.lbltieude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltieude.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.ForeColor = System.Drawing.Color.White;
            this.lbltieude.Location = new System.Drawing.Point(0, 25);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(458, 29);
            this.lbltieude.TabIndex = 9;
            this.lbltieude.Text = "Chức năng sao lưu";
            this.lbltieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-154, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đường dần file";
            // 
            // btnsaoluu
            // 
            this.btnsaoluu.Image = ((System.Drawing.Image)(resources.GetObject("btnsaoluu.Image")));
            this.btnsaoluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsaoluu.Name = "btnsaoluu";
            this.btnsaoluu.Size = new System.Drawing.Size(69, 22);
            this.btnsaoluu.Text = "Sao Lưu";
            this.btnsaoluu.Click += new System.EventHandler(this.btnsaoluu_Click);
            // 
            // btnlayduongdanfile
            // 
            this.btnlayduongdanfile.Image = ((System.Drawing.Image)(resources.GetObject("btnlayduongdanfile.Image")));
            this.btnlayduongdanfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnlayduongdanfile.Name = "btnlayduongdanfile";
            this.btnlayduongdanfile.Size = new System.Drawing.Size(125, 22);
            this.btnlayduongdanfile.Text = "Lấy đường dẫn file";
            this.btnlayduongdanfile.Click += new System.EventHandler(this.btnlayduongdanfile_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 85);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(458, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnlayduongdanfile,
            this.btnsaoluu,
            this.btnthoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(458, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtduongdan
            // 
            this.txtduongdan.Location = new System.Drawing.Point(0, 57);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(458, 20);
            this.txtduongdan.TabIndex = 6;
            // 
            // Frm_SaoLuuPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 107);
            this.Controls.Add(this.lbltieude);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtduongdan);
            this.Name = "Frm_SaoLuuPhucHoi";
            this.Text = "Frm_SaoLuuPhucHoi";
            this.Load += new System.EventHandler(this.Frm_SaoLuuPhucHoi_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.Label lbltieude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnsaoluu;
        private System.Windows.Forms.ToolStripButton btnlayduongdanfile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtduongdan;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}