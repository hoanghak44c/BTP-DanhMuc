namespace QLBanHang.Modules.DanhMuc
{
    partial class frmChiTiet_MaLoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTiet_MaLoi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new QLBH.Core.Form.GtidButton();
            this.btnSave = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMaLoi = new System.Windows.Forms.Label();
            this.txtMaLoi = new System.Windows.Forms.TextBox();
            this.lblSuDung = new System.Windows.Forms.Label();
            this.cbSuDung = new System.Windows.Forms.CheckBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblTenLoi = new System.Windows.Forms.Label();
            this.txtTenLoi = new System.Windows.Forms.TextBox();
            this.lblLoaiTB = new System.Windows.Forms.Label();
            this.txtLoaiSanPham = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(8, 234);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(773, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDong, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 39);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(313, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDelete.Size = new System.Drawing.Size(107, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "&Xóa ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(199, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnSave.Size = new System.Drawing.Size(108, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "    &Cập nhật";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(426, 4);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(108, 31);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(334, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "CHI TIẾT MÃ LỖI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLoaiSanPham);
            this.groupBox2.Controls.Add(this.lblMaLoi);
            this.groupBox2.Controls.Add(this.txtMaLoi);
            this.groupBox2.Controls.Add(this.lblSuDung);
            this.groupBox2.Controls.Add(this.cbSuDung);
            this.groupBox2.Controls.Add(this.lblGhiChu);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.lblTenLoi);
            this.groupBox2.Controls.Add(this.txtTenLoi);
            this.groupBox2.Controls.Add(this.lblLoaiTB);
            this.groupBox2.Location = new System.Drawing.Point(8, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(773, 188);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // lblMaLoi
            // 
            this.lblMaLoi.Location = new System.Drawing.Point(467, 54);
            this.lblMaLoi.Name = "lblMaLoi";
            this.lblMaLoi.Size = new System.Drawing.Size(47, 25);
            this.lblMaLoi.TabIndex = 7;
            this.lblMaLoi.Text = "Mã lỗi";
            // 
            // txtMaLoi
            // 
            this.txtMaLoi.Location = new System.Drawing.Point(530, 50);
            this.txtMaLoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLoi.Name = "txtMaLoi";
            this.txtMaLoi.Size = new System.Drawing.Size(237, 22);
            this.txtMaLoi.TabIndex = 2;
            // 
            // lblSuDung
            // 
            this.lblSuDung.Location = new System.Drawing.Point(7, 156);
            this.lblSuDung.Name = "lblSuDung";
            this.lblSuDung.Size = new System.Drawing.Size(70, 25);
            this.lblSuDung.TabIndex = 9;
            this.lblSuDung.Text = "Sử dụng";
            // 
            // cbSuDung
            // 
            this.cbSuDung.AutoSize = true;
            this.cbSuDung.Location = new System.Drawing.Point(103, 159);
            this.cbSuDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSuDung.Name = "cbSuDung";
            this.cbSuDung.Size = new System.Drawing.Size(15, 14);
            this.cbSuDung.TabIndex = 4;
            this.cbSuDung.UseVisualStyleBackColor = true;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Location = new System.Drawing.Point(6, 86);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(70, 25);
            this.lblGhiChu.TabIndex = 8;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(103, 82);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(664, 66);
            this.txtGhiChu.TabIndex = 3;
            // 
            // lblTenLoi
            // 
            this.lblTenLoi.Location = new System.Drawing.Point(6, 54);
            this.lblTenLoi.Name = "lblTenLoi";
            this.lblTenLoi.Size = new System.Drawing.Size(70, 25);
            this.lblTenLoi.TabIndex = 6;
            this.lblTenLoi.Text = "Tên lỗi";
            // 
            // txtTenLoi
            // 
            this.txtTenLoi.Location = new System.Drawing.Point(103, 50);
            this.txtTenLoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLoi.Name = "txtTenLoi";
            this.txtTenLoi.Size = new System.Drawing.Size(354, 22);
            this.txtTenLoi.TabIndex = 1;
            // 
            // lblLoaiTB
            // 
            this.lblLoaiTB.Location = new System.Drawing.Point(6, 20);
            this.lblLoaiTB.Name = "lblLoaiTB";
            this.lblLoaiTB.Size = new System.Drawing.Size(82, 25);
            this.lblLoaiTB.TabIndex = 5;
            this.lblLoaiTB.Text = "Loại thiết bị";
            // 
            // txtLoaiSanPham
            // 
            this.txtLoaiSanPham.Location = new System.Drawing.Point(103, 17);
            this.txtLoaiSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoaiSanPham.Name = "txtLoaiSanPham";
            this.txtLoaiSanPham.Size = new System.Drawing.Size(664, 22);
            this.txtLoaiSanPham.TabIndex = 10;
            this.txtLoaiSanPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoaiSanPham_KeyDown);
            // 
            // frmChiTiet_MaLoi
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChiTiet_MaLoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmChiTiet_MaLoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal QLBH.Core.Form.GtidButton btnDelete;
        internal QLBH.Core.Form.GtidButton btnSave;
        internal QLBH.Core.Form.GtidButton btnDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaLoi;
        private System.Windows.Forms.TextBox txtMaLoi;
        private System.Windows.Forms.Label lblSuDung;
        private System.Windows.Forms.CheckBox cbSuDung;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblTenLoi;
        private System.Windows.Forms.TextBox txtTenLoi;
        private System.Windows.Forms.Label lblLoaiTB;
        private System.Windows.Forms.TextBox txtLoaiSanPham;

    }
}