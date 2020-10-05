namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class frmDmTrungTam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmTrungTam));
            this.toolTrungTam = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.panelTrungTam = new DevExpress.XtraEditors.PanelControl();
            this.lblTenTrungTam = new DevExpress.XtraEditors.LabelControl();
            this.lblTrungTam = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTrungTam = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTrungTam = new DevExpress.XtraEditors.TextEdit();
            this.grcDMTrungTam = new DevExpress.XtraGrid.GridControl();
            this.grvDMTrungTam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colViTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuocGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChanelCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.toolTrungTam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTrungTam)).BeginInit();
            this.panelTrungTam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTrungTam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTrungTam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDMTrungTam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDMTrungTam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTrungTam
            // 
            this.toolTrungTam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.toolTrungTam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.btnSearch,
            this.btnCapNhat,
            this.btnXoa,
            this.btnExport,
            this.btnThoat});
            this.toolTrungTam.Location = new System.Drawing.Point(0, 0);
            this.toolTrungTam.Name = "toolTrungTam";
            this.toolTrungTam.Size = new System.Drawing.Size(827, 25);
            this.toolTrungTam.TabIndex = 0;
            this.toolTrungTam.Text = "toolStrip1";
            // 
            // btnDongBo
            // 
            this.btnDongBo.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBo.Image")));
            this.btnDongBo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDongBo.Name = "btnDongBo";
            this.btnDongBo.Size = new System.Drawing.Size(73, 22);
            this.btnDongBo.Text = "Đồng bộ";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 22);
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            // panelTrungTam
            // 
            this.panelTrungTam.Controls.Add(this.lblTenTrungTam);
            this.panelTrungTam.Controls.Add(this.lblTrungTam);
            this.panelTrungTam.Controls.Add(this.txtTenTrungTam);
            this.panelTrungTam.Controls.Add(this.txtMaTrungTam);
            this.panelTrungTam.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTrungTam.Location = new System.Drawing.Point(0, 25);
            this.panelTrungTam.Name = "panelTrungTam";
            this.panelTrungTam.Size = new System.Drawing.Size(827, 90);
            this.panelTrungTam.TabIndex = 1;
            // 
            // lblTenTrungTam
            // 
            this.lblTenTrungTam.Location = new System.Drawing.Point(293, 45);
            this.lblTenTrungTam.Name = "lblTenTrungTam";
            this.lblTenTrungTam.Size = new System.Drawing.Size(68, 13);
            this.lblTenTrungTam.TabIndex = 3;
            this.lblTenTrungTam.Text = "Tên trung tâm";
            // 
            // lblTrungTam
            // 
            this.lblTrungTam.Location = new System.Drawing.Point(26, 45);
            this.lblTrungTam.Name = "lblTrungTam";
            this.lblTrungTam.Size = new System.Drawing.Size(64, 13);
            this.lblTrungTam.TabIndex = 2;
            this.lblTrungTam.Text = "Mã trung tâm";
            // 
            // txtTenTrungTam
            // 
            this.txtTenTrungTam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTrungTam.Location = new System.Drawing.Point(367, 42);
            this.txtTenTrungTam.Name = "txtTenTrungTam";
            this.txtTenTrungTam.Size = new System.Drawing.Size(398, 20);
            this.txtTenTrungTam.TabIndex = 1;
            // 
            // txtMaTrungTam
            // 
            this.txtMaTrungTam.Location = new System.Drawing.Point(110, 42);
            this.txtMaTrungTam.Name = "txtMaTrungTam";
            this.txtMaTrungTam.Size = new System.Drawing.Size(168, 20);
            this.txtMaTrungTam.TabIndex = 0;
            // 
            // grcDMTrungTam
            // 
            this.grcDMTrungTam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDMTrungTam.Location = new System.Drawing.Point(2, 2);
            this.grcDMTrungTam.MainView = this.grvDMTrungTam;
            this.grcDMTrungTam.Name = "grcDMTrungTam";
            this.grcDMTrungTam.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grcDMTrungTam.Size = new System.Drawing.Size(823, 322);
            this.grcDMTrungTam.TabIndex = 2;
            this.grcDMTrungTam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDMTrungTam,
            this.gridView2});
            this.grcDMTrungTam.DoubleClick += new System.EventHandler(this.grcDMTrungTam_DoubleClick);
            // 
            // grvDMTrungTam
            // 
            this.grvDMTrungTam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTrungTam,
            this.colTenTrungTam,
            this.colDiaChi,
            this.colDienThoai,
            this.colFax,
            this.colEmail,
            this.colGhiChu,
            this.colSuDung,
            this.colViTri,
            this.colDuong,
            this.colTinh,
            this.colQuocGia,
            this.colChanelCode});
            this.grvDMTrungTam.GridControl = this.grcDMTrungTam;
            this.grvDMTrungTam.Name = "grvDMTrungTam";
            this.grvDMTrungTam.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMaTrungTam
            // 
            this.colMaTrungTam.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaTrungTam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTrungTam.Caption = "Mã Trung Tâm";
            this.colMaTrungTam.FieldName = "MaTrungTam";
            this.colMaTrungTam.Name = "colMaTrungTam";
            this.colMaTrungTam.OptionsColumn.AllowEdit = false;
            this.colMaTrungTam.OptionsColumn.FixedWidth = true;
            this.colMaTrungTam.Visible = true;
            this.colMaTrungTam.VisibleIndex = 0;
            // 
            // colTenTrungTam
            // 
            this.colTenTrungTam.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenTrungTam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenTrungTam.Caption = "Tên Trung Tâm";
            this.colTenTrungTam.FieldName = "TenTrungTam";
            this.colTenTrungTam.Name = "colTenTrungTam";
            this.colTenTrungTam.OptionsColumn.AllowEdit = false;
            this.colTenTrungTam.Visible = true;
            this.colTenTrungTam.VisibleIndex = 1;
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
            this.colDiaChi.VisibleIndex = 2;
            // 
            // colDienThoai
            // 
            this.colDienThoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colDienThoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDienThoai.Caption = "Điện Thoại";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.OptionsColumn.AllowEdit = false;
            this.colDienThoai.OptionsColumn.FixedWidth = true;
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 3;
            // 
            // colFax
            // 
            this.colFax.AppearanceHeader.Options.UseTextOptions = true;
            this.colFax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            this.colFax.OptionsColumn.FixedWidth = true;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.OptionsColumn.FixedWidth = true;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
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
            this.colGhiChu.VisibleIndex = 6;
            // 
            // colSuDung
            // 
            this.colSuDung.AppearanceHeader.Options.UseTextOptions = true;
            this.colSuDung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuDung.Caption = "Sử Dụng";
            this.colSuDung.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colSuDung.FieldName = "SuDung";
            this.colSuDung.Name = "colSuDung";
            this.colSuDung.OptionsColumn.AllowEdit = false;
            this.colSuDung.OptionsColumn.FixedWidth = true;
            this.colSuDung.Visible = true;
            this.colSuDung.VisibleIndex = 7;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // colViTri
            // 
            this.colViTri.AppearanceHeader.Options.UseTextOptions = true;
            this.colViTri.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colViTri.Caption = "Vị Trí";
            this.colViTri.FieldName = "ViTri";
            this.colViTri.Name = "colViTri";
            this.colViTri.OptionsColumn.AllowEdit = false;
            this.colViTri.Visible = true;
            this.colViTri.VisibleIndex = 8;
            // 
            // colDuong
            // 
            this.colDuong.AppearanceHeader.Options.UseTextOptions = true;
            this.colDuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDuong.Caption = "Đường";
            this.colDuong.FieldName = "Duong";
            this.colDuong.Name = "colDuong";
            this.colDuong.OptionsColumn.AllowEdit = false;
            this.colDuong.Visible = true;
            this.colDuong.VisibleIndex = 9;
            // 
            // colTinh
            // 
            this.colTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTinh.Caption = "Tỉnh";
            this.colTinh.FieldName = "Tinh";
            this.colTinh.Name = "colTinh";
            this.colTinh.OptionsColumn.AllowEdit = false;
            this.colTinh.OptionsColumn.FixedWidth = true;
            this.colTinh.Visible = true;
            this.colTinh.VisibleIndex = 10;
            // 
            // colQuocGia
            // 
            this.colQuocGia.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuocGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuocGia.Caption = "Quốc Gia";
            this.colQuocGia.FieldName = "QuocGia";
            this.colQuocGia.Name = "colQuocGia";
            this.colQuocGia.OptionsColumn.AllowEdit = false;
            this.colQuocGia.OptionsColumn.FixedWidth = true;
            this.colQuocGia.Visible = true;
            this.colQuocGia.VisibleIndex = 11;
            // 
            // colChanelCode
            // 
            this.colChanelCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colChanelCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChanelCode.Caption = "Chanel Code";
            this.colChanelCode.FieldName = "ChannelCode";
            this.colChanelCode.Name = "colChanelCode";
            this.colChanelCode.OptionsColumn.AllowEdit = false;
            this.colChanelCode.Visible = true;
            this.colChanelCode.VisibleIndex = 12;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grcDMTrungTam;
            this.gridView2.Name = "gridView2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grcDMTrungTam);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 115);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(827, 326);
            this.panelControl1.TabIndex = 2;
            // 
            // frmDmTrungTam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 441);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelTrungTam);
            this.Controls.Add(this.toolTrungTam);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDmTrungTam";
            this.Text = "Danh mục trung tâm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolTrungTam.ResumeLayout(false);
            this.toolTrungTam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTrungTam)).EndInit();
            this.panelTrungTam.ResumeLayout(false);
            this.panelTrungTam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTrungTam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTrungTam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDMTrungTam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDMTrungTam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolTrungTam;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraEditors.PanelControl panelTrungTam;
        private DevExpress.XtraEditors.LabelControl lblTenTrungTam;
        private DevExpress.XtraEditors.LabelControl lblTrungTam;
        private DevExpress.XtraEditors.TextEdit txtTenTrungTam;
        private DevExpress.XtraEditors.TextEdit txtMaTrungTam;
        private DevExpress.XtraGrid.GridControl grcDMTrungTam;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDMTrungTam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraGrid.Columns.GridColumn colViTri;
        private DevExpress.XtraGrid.Columns.GridColumn colDuong;
        private DevExpress.XtraGrid.Columns.GridColumn colTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colQuocGia;
        private DevExpress.XtraGrid.Columns.GridColumn colChanelCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}