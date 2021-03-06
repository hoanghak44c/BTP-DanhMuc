namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class FrmDmDoiTuongKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDmDoiTuongKhachHang));
            this.toolDT = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.panelDoiTuong = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDoiTuong = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDoiTuong = new DevExpress.XtraEditors.TextEdit();
            this.grdDoiTuong = new DevExpress.XtraGrid.GridControl();
            this.grvDoiTuong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNLL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSoThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuDN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDoiTuong)).BeginInit();
            this.panelDoiTuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDoiTuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDoiTuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoiTuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDoiTuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).BeginInit();
            this.SuspendLayout();
            // 
            // toolDT
            // 
            this.toolDT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.btnTimKiem,
            this.btnCapNhat,
            this.btnDelete,
            this.btnExport,
            this.btnThoat});
            this.toolDT.Location = new System.Drawing.Point(0, 0);
            this.toolDT.Name = "toolDT";
            this.toolDT.Size = new System.Drawing.Size(867, 25);
            this.toolDT.TabIndex = 0;
            this.toolDT.Text = "toolStrip1";
            // 
            // btnDongBo
            // 
            this.btnDongBo.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBo.Image")));
            this.btnDongBo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDongBo.Name = "btnDongBo";
            this.btnDongBo.Size = new System.Drawing.Size(73, 22);
            this.btnDongBo.Text = "Đồng Bộ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(78, 22);
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(77, 22);
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(60, 22);
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            // panelDoiTuong
            // 
            this.panelDoiTuong.Controls.Add(this.labelControl2);
            this.panelDoiTuong.Controls.Add(this.labelControl1);
            this.panelDoiTuong.Controls.Add(this.txtTenDoiTuong);
            this.panelDoiTuong.Controls.Add(this.txtMaDoiTuong);
            this.panelDoiTuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDoiTuong.Location = new System.Drawing.Point(0, 25);
            this.panelDoiTuong.Name = "panelDoiTuong";
            this.panelDoiTuong.Size = new System.Drawing.Size(867, 100);
            this.panelDoiTuong.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(422, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên Khách Hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã Khách Hàng";
            // 
            // txtTenDoiTuong
            // 
            this.txtTenDoiTuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDoiTuong.Location = new System.Drawing.Point(506, 49);
            this.txtTenDoiTuong.Name = "txtTenDoiTuong";
            this.txtTenDoiTuong.Size = new System.Drawing.Size(253, 20);
            this.txtTenDoiTuong.TabIndex = 1;
            // 
            // txtMaDoiTuong
            // 
            this.txtMaDoiTuong.Location = new System.Drawing.Point(99, 49);
            this.txtMaDoiTuong.Name = "txtMaDoiTuong";
            this.txtMaDoiTuong.Size = new System.Drawing.Size(253, 20);
            this.txtMaDoiTuong.TabIndex = 0;
            // 
            // grdDoiTuong
            // 
            this.grdDoiTuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDoiTuong.Location = new System.Drawing.Point(0, 125);
            this.grdDoiTuong.MainView = this.grvDoiTuong;
            this.grdDoiTuong.Name = "grdDoiTuong";
            this.grdDoiTuong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSuDung});
            this.grdDoiTuong.Size = new System.Drawing.Size(867, 306);
            this.grdDoiTuong.TabIndex = 2;
            this.grdDoiTuong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDoiTuong});
            this.grdDoiTuong.DoubleClick += new System.EventHandler(this.grdDoiTuong_DoubleClick);
            // 
            // grvDoiTuong
            // 
            this.grvDoiTuong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDT,
            this.colTenDT,
            this.colNLL,
            this.colDiaChi,
            this.colDienThoai,
            this.colFax,
            this.colEmail,
            this.colMaSoThue,
            this.colSuDung,
            this.colGhiChu,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colCMT,
            this.colChuDN,
            this.colHuyen});
            this.grvDoiTuong.GridControl = this.grdDoiTuong;
            this.grvDoiTuong.Name = "grvDoiTuong";
            this.grvDoiTuong.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMaDT
            // 
            this.colMaDT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaDT.Caption = "Mã Đối Tượng";
            this.colMaDT.FieldName = "MaDoiTuong";
            this.colMaDT.Name = "colMaDT";
            this.colMaDT.OptionsColumn.AllowEdit = false;
            this.colMaDT.Visible = true;
            this.colMaDT.VisibleIndex = 0;
            // 
            // colTenDT
            // 
            this.colTenDT.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDT.Caption = "Tên Đối Tượng";
            this.colTenDT.FieldName = "TenDoiTuong";
            this.colTenDT.Name = "colTenDT";
            this.colTenDT.OptionsColumn.AllowEdit = false;
            this.colTenDT.Visible = true;
            this.colTenDT.VisibleIndex = 1;
            // 
            // colNLL
            // 
            this.colNLL.AppearanceHeader.Options.UseTextOptions = true;
            this.colNLL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNLL.Caption = "Người Liên Lạc";
            this.colNLL.FieldName = "NguoiLienLac";
            this.colNLL.Name = "colNLL";
            this.colNLL.OptionsColumn.AllowEdit = false;
            this.colNLL.Visible = true;
            this.colNLL.VisibleIndex = 2;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiaChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.AllowEdit = false;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 3;
            // 
            // colDienThoai
            // 
            this.colDienThoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colDienThoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDienThoai.Caption = "Điện Thoại";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.OptionsColumn.AllowEdit = false;
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 4;
            // 
            // colFax
            // 
            this.colFax.AppearanceHeader.Options.UseTextOptions = true;
            this.colFax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 5;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            // 
            // colMaSoThue
            // 
            this.colMaSoThue.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaSoThue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaSoThue.Caption = "Mã Số Thuế";
            this.colMaSoThue.FieldName = "MaSoThue";
            this.colMaSoThue.Name = "colMaSoThue";
            this.colMaSoThue.OptionsColumn.AllowEdit = false;
            this.colMaSoThue.Visible = true;
            this.colMaSoThue.VisibleIndex = 7;
            // 
            // colSuDung
            // 
            this.colSuDung.AppearanceHeader.Options.UseTextOptions = true;
            this.colSuDung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuDung.Caption = "Sử Dụng";
            this.colSuDung.ColumnEdit = this.repSuDung;
            this.colSuDung.FieldName = "SuDung";
            this.colSuDung.Name = "colSuDung";
            this.colSuDung.OptionsColumn.AllowEdit = false;
            this.colSuDung.Visible = true;
            this.colSuDung.VisibleIndex = 8;
            // 
            // repSuDung
            // 
            this.repSuDung.AutoHeight = false;
            this.repSuDung.Name = "repSuDung";
            this.repSuDung.ValueChecked = 1;
            this.repSuDung.ValueUnchecked = 0;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhiChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 9;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colGioiTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioiTinh.Caption = "Giới Tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.OptionsColumn.AllowEdit = false;
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 10;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgaySinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgaySinh.Caption = "Ngày Sinh";
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.OptionsColumn.AllowEdit = false;
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 11;
            // 
            // colCMT
            // 
            this.colCMT.AppearanceHeader.Options.UseTextOptions = true;
            this.colCMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCMT.Caption = "Số CMT";
            this.colCMT.FieldName = "SoCMND";
            this.colCMT.Name = "colCMT";
            this.colCMT.OptionsColumn.AllowEdit = false;
            this.colCMT.Visible = true;
            this.colCMT.VisibleIndex = 12;
            // 
            // colChuDN
            // 
            this.colChuDN.AppearanceHeader.Options.UseTextOptions = true;
            this.colChuDN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChuDN.Caption = "Chủ Doanh Nghiệp";
            this.colChuDN.FieldName = "ChuDoanhNghiep";
            this.colChuDN.Name = "colChuDN";
            this.colChuDN.OptionsColumn.AllowEdit = false;
            this.colChuDN.Visible = true;
            this.colChuDN.VisibleIndex = 13;
            // 
            // colHuyen
            // 
            this.colHuyen.AppearanceHeader.Options.UseTextOptions = true;
            this.colHuyen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHuyen.Caption = "Huyện";
            this.colHuyen.FieldName = "Huyen";
            this.colHuyen.Name = "colHuyen";
            this.colHuyen.OptionsColumn.AllowEdit = false;
            this.colHuyen.Visible = true;
            this.colHuyen.VisibleIndex = 14;
            // 
            // FrmDmDoiTuongKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 431);
            this.Controls.Add(this.grdDoiTuong);
            this.Controls.Add(this.panelDoiTuong);
            this.Controls.Add(this.toolDT);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDmDoiTuongKhachHang";
            this.Text = "Danh mục đối tượng khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolDT.ResumeLayout(false);
            this.toolDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDoiTuong)).EndInit();
            this.panelDoiTuong.ResumeLayout(false);
            this.panelDoiTuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDoiTuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDoiTuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoiTuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDoiTuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolDT;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraEditors.PanelControl panelDoiTuong;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenDoiTuong;
        private DevExpress.XtraEditors.TextEdit txtMaDoiTuong;
        private DevExpress.XtraGrid.GridControl grdDoiTuong;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDT;
        private DevExpress.XtraGrid.Columns.GridColumn colNLL;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoThue;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colCMT;
        private DevExpress.XtraGrid.Columns.GridColumn colChuDN;
        private DevExpress.XtraGrid.Columns.GridColumn colHuyen;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSuDung;
    }
}