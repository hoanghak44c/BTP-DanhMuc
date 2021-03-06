namespace QLBanHang.Modules.DanhMuc
{
    partial class frmChiTiet_QuyenHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTiet_QuyenHoaDon));
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblConLai = new System.Windows.Forms.Label();
            this.lblDaDung = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtConLai = new QLBH.Core.Form.GtidTextBox();
            this.txtDaDung = new QLBH.Core.Form.GtidTextBox();
            this.txtSoLuong = new QLBH.Core.Form.GtidTextBox();
            this.txtKyHieuDau = new QLBH.Core.Form.GtidTextBox();
            this.txtKyHieu = new QLBH.Core.Form.GtidTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.btnXoa = new QLBH.Core.Form.GtidButton();
            this.btnCapNhat = new QLBH.Core.Form.GtidButton();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(223, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(255, 22);
            this.label16.TabIndex = 2;
            this.label16.Text = "CHI TIẾT QUYỂN HÓA ĐƠN";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblConLai);
            this.groupBox4.Controls.Add(this.lblDaDung);
            this.groupBox4.Controls.Add(this.lblSoLuong);
            this.groupBox4.Controls.Add(this.lblName);
            this.groupBox4.Controls.Add(this.lblCode);
            this.groupBox4.Controls.Add(this.txtConLai);
            this.groupBox4.Controls.Add(this.txtDaDung);
            this.groupBox4.Controls.Add(this.txtSoLuong);
            this.groupBox4.Controls.Add(this.txtKyHieuDau);
            this.groupBox4.Controls.Add(this.txtKyHieu);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(10, 48);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(686, 130);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách quyển hóa đơn";
            // 
            // lblConLai
            // 
            this.lblConLai.ForeColor = System.Drawing.Color.Black;
            this.lblConLai.Location = new System.Drawing.Point(12, 94);
            this.lblConLai.Name = "lblConLai";
            this.lblConLai.Size = new System.Drawing.Size(70, 25);
            this.lblConLai.TabIndex = 9;
            this.lblConLai.Text = "Còn lại";
            // 
            // lblDaDung
            // 
            this.lblDaDung.ForeColor = System.Drawing.Color.Black;
            this.lblDaDung.Location = new System.Drawing.Point(324, 62);
            this.lblDaDung.Name = "lblDaDung";
            this.lblDaDung.Size = new System.Drawing.Size(70, 25);
            this.lblDaDung.TabIndex = 8;
            this.lblDaDung.Text = "Đã dùng";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuong.Location = new System.Drawing.Point(12, 62);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(70, 25);
            this.lblSoLuong.TabIndex = 7;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(324, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 25);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Ký tự đầu số HĐ";
            // 
            // lblCode
            // 
            this.lblCode.ForeColor = System.Drawing.Color.Black;
            this.lblCode.Location = new System.Drawing.Point(12, 30);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(82, 25);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Ký hiệu HĐ";
            // 
            // txtConLai
            // 
            this.txtConLai.BackColor = System.Drawing.Color.White;
            this.txtConLai.Enabled = false;
            this.txtConLai.Location = new System.Drawing.Point(98, 90);
            this.txtConLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.Size = new System.Drawing.Size(205, 22);
            this.txtConLai.TabIndex = 4;
            // 
            // txtDaDung
            // 
            this.txtDaDung.Location = new System.Drawing.Point(454, 57);
            this.txtDaDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDaDung.Name = "txtDaDung";
            this.txtDaDung.Size = new System.Drawing.Size(226, 22);
            this.txtDaDung.TabIndex = 3;
            this.txtDaDung.TextChanged += new System.EventHandler(this.txtDaDung_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(98, 57);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(205, 22);
            this.txtSoLuong.TabIndex = 2;
            // 
            // txtKyHieuDau
            // 
            this.txtKyHieuDau.Location = new System.Drawing.Point(454, 25);
            this.txtKyHieuDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKyHieuDau.Name = "txtKyHieuDau";
            this.txtKyHieuDau.Size = new System.Drawing.Size(226, 22);
            this.txtKyHieuDau.TabIndex = 1;
            // 
            // txtKyHieu
            // 
            this.txtKyHieu.Location = new System.Drawing.Point(98, 25);
            this.txtKyHieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKyHieu.MaxLength = 10;
            this.txtKyHieu.Name = "txtKyHieu";
            this.txtKyHieu.Size = new System.Drawing.Size(205, 22);
            this.txtKyHieu.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Location = new System.Drawing.Point(10, 186);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(686, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(406, 20);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(113, 29);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(290, 20);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 29);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(175, 20);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(113, 29);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "    &Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmChiTiet_QuyenHoaDon
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 247);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChiTiet_QuyenHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmChiTiet_QuyenHoaDon_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblConLai;
        private System.Windows.Forms.Label lblDaDung;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private QLBH.Core.Form.GtidTextBox txtConLai;
        private QLBH.Core.Form.GtidTextBox txtDaDung;
        private QLBH.Core.Form.GtidTextBox txtSoLuong;
        private QLBH.Core.Form.GtidTextBox txtKyHieuDau;
        private QLBH.Core.Form.GtidTextBox txtKyHieu;
        private System.Windows.Forms.GroupBox groupBox1;
        internal QLBH.Core.Form.GtidButton btnDong;
        internal QLBH.Core.Form.GtidButton btnXoa;
        internal QLBH.Core.Form.GtidButton btnCapNhat;

    }
}