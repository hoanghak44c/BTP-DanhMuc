namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class FrmDmLoaiHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDmLoaiHangHoa));
            this.toolSP = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.panelSP = new DevExpress.XtraEditors.PanelControl();
            this.lblTenSP = new DevExpress.XtraEditors.LabelControl();
            this.lblMaSP = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSP = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSP = new DevExpress.XtraEditors.TextEdit();
            this.grdSanPham = new DevExpress.XtraGrid.GridControl();
            this.grvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colNhomCha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSP)).BeginInit();
            this.panelSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolSP
            // 
            this.toolSP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.btnSearch,
            this.btnCapNhat,
            this.btnDelete,
            this.btnExport,
            this.btnExit});
            this.toolSP.Location = new System.Drawing.Point(0, 0);
            this.toolSP.Name = "toolSP";
            this.toolSP.Size = new System.Drawing.Size(867, 25);
            this.toolSP.TabIndex = 0;
            this.toolSP.Text = "toolStrip1";
            // 
            // btnDongBo
            // 
            this.btnDongBo.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBo.Image")));
            this.btnDongBo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDongBo.Name = "btnDongBo";
            this.btnDongBo.Size = new System.Drawing.Size(73, 22);
            this.btnDongBo.Text = "Đồng Bộ";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 22);
            this.btnSearch.Text = "Tìm Kiếm";
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
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 22);
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelSP
            // 
            this.panelSP.Controls.Add(this.lblTenSP);
            this.panelSP.Controls.Add(this.lblMaSP);
            this.panelSP.Controls.Add(this.txtTenSP);
            this.panelSP.Controls.Add(this.txtMaSP);
            this.panelSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSP.Location = new System.Drawing.Point(0, 25);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(867, 100);
            this.panelSP.TabIndex = 1;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Location = new System.Drawing.Point(353, 50);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(90, 13);
            this.lblTenSP.TabIndex = 3;
            this.lblTenSP.Text = "Tên Loại Sản Phẩm";
            // 
            // lblMaSP
            // 
            this.lblMaSP.Location = new System.Drawing.Point(12, 50);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(86, 13);
            this.lblMaSP.TabIndex = 2;
            this.lblMaSP.Text = "Mã Loại Sản Phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenSP.Location = new System.Drawing.Point(450, 47);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(254, 20);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(104, 47);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(199, 20);
            this.txtMaSP.TabIndex = 0;
            // 
            // grdSanPham
            // 
            this.grdSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSanPham.Location = new System.Drawing.Point(0, 125);
            this.grdSanPham.MainView = this.grvSanPham;
            this.grdSanPham.Name = "grdSanPham";
            this.grdSanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSuDung});
            this.grdSanPham.Size = new System.Drawing.Size(867, 283);
            this.grdSanPham.TabIndex = 2;
            this.grdSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvSanPham,
            this.gridView2});
            this.grdSanPham.DoubleClick += new System.EventHandler(this.grdSanPham_DoubleClick);
            // 
            // grvSanPham
            // 
            this.grvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colTen,
            this.colGhiChu,
            this.colSuDung,
            this.colNhomCha,
            this.colLinhVuc,
            this.colNganh,
            this.colLoai,
            this.colChung,
            this.colNhom,
            this.colHang,
            this.colModel});
            this.grvSanPham.GridControl = this.grdSanPham;
            this.grvSanPham.Name = "grvSanPham";
            this.grvSanPham.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMa
            // 
            this.colMa.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa.Caption = "Mã Loại SP";
            this.colMa.FieldName = "MaLoaiSP";
            this.colMa.Name = "colMa";
            this.colMa.OptionsColumn.AllowEdit = false;
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 0;
            // 
            // colTen
            // 
            this.colTen.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen.Caption = "Tên Loại Sản Phẩm";
            this.colTen.FieldName = "TenLoaiSP";
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.AllowEdit = false;
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
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
            this.colGhiChu.VisibleIndex = 2;
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
            this.colSuDung.VisibleIndex = 3;
            // 
            // repSuDung
            // 
            this.repSuDung.AutoHeight = false;
            this.repSuDung.Name = "repSuDung";
            this.repSuDung.ValueChecked = 1;
            this.repSuDung.ValueUnchecked = 0;
            // 
            // colNhomCha
            // 
            this.colNhomCha.AppearanceHeader.Options.UseTextOptions = true;
            this.colNhomCha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNhomCha.Caption = "Nhóm Cha";
            this.colNhomCha.FieldName = "NhomCha";
            this.colNhomCha.Name = "colNhomCha";
            this.colNhomCha.OptionsColumn.AllowEdit = false;
            this.colNhomCha.Visible = true;
            this.colNhomCha.VisibleIndex = 4;
            // 
            // colLinhVuc
            // 
            this.colLinhVuc.AppearanceHeader.Options.UseTextOptions = true;
            this.colLinhVuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLinhVuc.Caption = "Lĩnh Vực";
            this.colLinhVuc.FieldName = "LinhVuc";
            this.colLinhVuc.Name = "colLinhVuc";
            this.colLinhVuc.OptionsColumn.AllowEdit = false;
            this.colLinhVuc.Visible = true;
            this.colLinhVuc.VisibleIndex = 5;
            // 
            // colNganh
            // 
            this.colNganh.AppearanceHeader.Options.UseTextOptions = true;
            this.colNganh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNganh.Caption = "Ngành";
            this.colNganh.FieldName = "Nganh";
            this.colNganh.Name = "colNganh";
            this.colNganh.OptionsColumn.AllowEdit = false;
            this.colNganh.Visible = true;
            this.colNganh.VisibleIndex = 6;
            // 
            // colLoai
            // 
            this.colLoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoai.Caption = "Loại";
            this.colLoai.FieldName = "Loai";
            this.colLoai.Name = "colLoai";
            this.colLoai.OptionsColumn.AllowEdit = false;
            this.colLoai.Visible = true;
            this.colLoai.VisibleIndex = 7;
            // 
            // colChung
            // 
            this.colChung.AppearanceHeader.Options.UseTextOptions = true;
            this.colChung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChung.Caption = "Chủng";
            this.colChung.FieldName = "Chung";
            this.colChung.Name = "colChung";
            this.colChung.OptionsColumn.AllowEdit = false;
            this.colChung.Visible = true;
            this.colChung.VisibleIndex = 8;
            // 
            // colNhom
            // 
            this.colNhom.AppearanceHeader.Options.UseTextOptions = true;
            this.colNhom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNhom.Caption = "Nhóm";
            this.colNhom.FieldName = "Nhom";
            this.colNhom.Name = "colNhom";
            this.colNhom.OptionsColumn.AllowEdit = false;
            this.colNhom.Visible = true;
            this.colNhom.VisibleIndex = 9;
            // 
            // colHang
            // 
            this.colHang.AppearanceHeader.Options.UseTextOptions = true;
            this.colHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHang.Caption = "Hãng";
            this.colHang.FieldName = "Hang";
            this.colHang.Name = "colHang";
            this.colHang.OptionsColumn.AllowEdit = false;
            this.colHang.Visible = true;
            this.colHang.VisibleIndex = 10;
            // 
            // colModel
            // 
            this.colModel.AppearanceHeader.Options.UseTextOptions = true;
            this.colModel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.OptionsColumn.AllowEdit = false;
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 11;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdSanPham;
            this.gridView2.Name = "gridView2";
            // 
            // FrmDmLoaiHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 408);
            this.Controls.Add(this.grdSanPham);
            this.Controls.Add(this.panelSP);
            this.Controls.Add(this.toolSP);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDmLoaiHangHoa";
            this.Text = "Danh mục loại hàng hóa ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolSP.ResumeLayout(false);
            this.toolSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSP)).EndInit();
            this.panelSP.ResumeLayout(false);
            this.panelSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolSP;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnExit;
        private DevExpress.XtraEditors.PanelControl panelSP;
        private DevExpress.XtraEditors.LabelControl lblTenSP;
        private DevExpress.XtraEditors.LabelControl lblMaSP;
        private DevExpress.XtraEditors.TextEdit txtTenSP;
        private DevExpress.XtraEditors.TextEdit txtMaSP;
        private DevExpress.XtraGrid.GridControl grdSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView grvSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraGrid.Columns.GridColumn colNhomCha;
        private DevExpress.XtraGrid.Columns.GridColumn colLinhVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colNganh;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colChung;
        private DevExpress.XtraGrid.Columns.GridColumn colNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colHang;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSuDung;
    }
}