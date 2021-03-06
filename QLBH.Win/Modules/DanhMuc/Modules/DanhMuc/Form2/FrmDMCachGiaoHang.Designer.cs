namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class FrmDMCachGiaoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDMCachGiaoHang));
            this.toolCachGiaoHang = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.panelDMGiaoHang = new DevExpress.XtraEditors.PanelControl();
            this.lblTen = new DevExpress.XtraEditors.LabelControl();
            this.lblMa = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.grdCachGiaoHang = new DevExpress.XtraGrid.GridControl();
            this.grvCachGiaoHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.toolCachGiaoHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDMGiaoHang)).BeginInit();
            this.panelDMGiaoHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCachGiaoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCachGiaoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).BeginInit();
            this.SuspendLayout();
            // 
            // toolCachGiaoHang
            // 
            this.toolCachGiaoHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.btnTimKiem,
            this.btnThem,
            this.btnCapNhat,
            this.btnDelete,
            this.btnExport,
            this.btnThoat});
            this.toolCachGiaoHang.Location = new System.Drawing.Point(0, 0);
            this.toolCachGiaoHang.Name = "toolCachGiaoHang";
            this.toolCachGiaoHang.Size = new System.Drawing.Size(848, 25);
            this.toolCachGiaoHang.TabIndex = 0;
            this.toolCachGiaoHang.Text = "toolStrip1";
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
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 22);
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            // panelDMGiaoHang
            // 
            this.panelDMGiaoHang.Controls.Add(this.lblTen);
            this.panelDMGiaoHang.Controls.Add(this.lblMa);
            this.panelDMGiaoHang.Controls.Add(this.txtTen);
            this.panelDMGiaoHang.Controls.Add(this.txtMa);
            this.panelDMGiaoHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDMGiaoHang.Location = new System.Drawing.Point(0, 25);
            this.panelDMGiaoHang.Name = "panelDMGiaoHang";
            this.panelDMGiaoHang.Size = new System.Drawing.Size(848, 100);
            this.panelDMGiaoHang.TabIndex = 1;
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(360, 42);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(93, 13);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Tên cách giao hàng";
            // 
            // lblMa
            // 
            this.lblMa.Location = new System.Drawing.Point(13, 42);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(89, 13);
            this.lblMa.TabIndex = 2;
            this.lblMa.Text = "Mã cách giao hàng";
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(459, 39);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(304, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(108, 39);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(217, 20);
            this.txtMa.TabIndex = 0;
            // 
            // grdCachGiaoHang
            // 
            this.grdCachGiaoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCachGiaoHang.Location = new System.Drawing.Point(0, 125);
            this.grdCachGiaoHang.MainView = this.grvCachGiaoHang;
            this.grdCachGiaoHang.Name = "grdCachGiaoHang";
            this.grdCachGiaoHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSuDung});
            this.grdCachGiaoHang.Size = new System.Drawing.Size(848, 287);
            this.grdCachGiaoHang.TabIndex = 2;
            this.grdCachGiaoHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCachGiaoHang});
            this.grdCachGiaoHang.DoubleClick += new System.EventHandler(this.grdCachGiaoHang_DoubleClick);
            // 
            // grvCachGiaoHang
            // 
            this.grvCachGiaoHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colTen,
            this.colGhiChu,
            this.colSuDung});
            this.grvCachGiaoHang.GridControl = this.grdCachGiaoHang;
            this.grvCachGiaoHang.Name = "grvCachGiaoHang";
            // 
            // colMa
            // 
            this.colMa.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa.Caption = "Mã";
            this.colMa.FieldName = "Ma";
            this.colMa.Name = "colMa";
            this.colMa.OptionsColumn.AllowEdit = false;
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 0;
            // 
            // colTen
            // 
            this.colTen.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
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
            // FrmDMCachGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 412);
            this.Controls.Add(this.grdCachGiaoHang);
            this.Controls.Add(this.panelDMGiaoHang);
            this.Controls.Add(this.toolCachGiaoHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDMCachGiaoHang";
            this.Text = "Danh mục cách giao hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolCachGiaoHang.ResumeLayout(false);
            this.toolCachGiaoHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDMGiaoHang)).EndInit();
            this.panelDMGiaoHang.ResumeLayout(false);
            this.panelDMGiaoHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCachGiaoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCachGiaoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolCachGiaoHang;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private DevExpress.XtraEditors.PanelControl panelDMGiaoHang;
        private DevExpress.XtraEditors.LabelControl lblTen;
        private DevExpress.XtraEditors.LabelControl lblMa;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraGrid.GridControl grdCachGiaoHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCachGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSuDung;
    }
}