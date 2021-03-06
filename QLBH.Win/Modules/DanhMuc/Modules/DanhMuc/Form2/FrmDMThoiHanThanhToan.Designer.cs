namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class FrmDMThoiHanThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDMThoiHanThanhToan));
            this.toolThoiHanThanhToan = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnChiTiet = new System.Windows.Forms.ToolStripButton();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblMa = new DevExpress.XtraEditors.LabelControl();
            this.lblTen = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.grdThoiHanThanhToan = new DevExpress.XtraGrid.GridControl();
            this.grvThoiHanThanhToan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.toolThoiHanThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThoiHanThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThoiHanThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).BeginInit();
            this.SuspendLayout();
            // 
            // toolThoiHanThanhToan
            // 
            this.toolThoiHanThanhToan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.btnThem,
            this.btnChiTiet,
            this.btnTimKiem,
            this.btnExport,
            this.btnDelete,
            this.btnExit});
            this.toolThoiHanThanhToan.Location = new System.Drawing.Point(0, 0);
            this.toolThoiHanThanhToan.Name = "toolThoiHanThanhToan";
            this.toolThoiHanThanhToan.Size = new System.Drawing.Size(867, 25);
            this.toolThoiHanThanhToan.TabIndex = 0;
            this.toolThoiHanThanhToan.Text = "toolStrip1";
            // 
            // btnDongBo
            // 
            this.btnDongBo.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBo.Image")));
            this.btnDongBo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDongBo.Name = "btnDongBo";
            this.btnDongBo.Size = new System.Drawing.Size(73, 22);
            this.btnDongBo.Text = "Đồng Bộ";
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
            // btnChiTiet
            // 
            this.btnChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Image")));
            this.btnChiTiet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(68, 22);
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
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
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(60, 22);
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 22);
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblMa);
            this.panelControl1.Controls.Add(this.lblTen);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtTen);
            this.panelControl1.Controls.Add(this.txtMa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(867, 70);
            this.panelControl1.TabIndex = 1;
            // 
            // lblMa
            // 
            this.lblMa.Location = new System.Drawing.Point(17, 34);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(75, 13);
            this.lblMa.TabIndex = 4;
            this.lblMa.Text = "Mã Loại Thu Chi";
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(414, 34);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(79, 13);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Tên Loại Thu Chi";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(499, 31);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(204, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(98, 31);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(204, 20);
            this.txtMa.TabIndex = 0;
            // 
            // grdThoiHanThanhToan
            // 
            this.grdThoiHanThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdThoiHanThanhToan.Location = new System.Drawing.Point(0, 95);
            this.grdThoiHanThanhToan.MainView = this.grvThoiHanThanhToan;
            this.grdThoiHanThanhToan.Name = "grdThoiHanThanhToan";
            this.grdThoiHanThanhToan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSuDung});
            this.grdThoiHanThanhToan.Size = new System.Drawing.Size(867, 336);
            this.grdThoiHanThanhToan.TabIndex = 2;
            this.grdThoiHanThanhToan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvThoiHanThanhToan});
            this.grdThoiHanThanhToan.DoubleClick += new System.EventHandler(this.grdThoiHanThanhToan_DoubleClick);
            // 
            // grvThoiHanThanhToan
            // 
            this.grvThoiHanThanhToan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKyHieu,
            this.colTen,
            this.colGhiChu,
            this.colType,
            this.colSuDung});
            this.grvThoiHanThanhToan.GridControl = this.grdThoiHanThanhToan;
            this.grvThoiHanThanhToan.Name = "grvThoiHanThanhToan";
            this.grvThoiHanThanhToan.OptionsView.ShowAutoFilterRow = true;
            // 
            // colKyHieu
            // 
            this.colKyHieu.AppearanceHeader.Options.UseTextOptions = true;
            this.colKyHieu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKyHieu.Caption = "Ký Hiệu";
            this.colKyHieu.FieldName = "KyHieu";
            this.colKyHieu.Name = "colKyHieu";
            this.colKyHieu.OptionsColumn.AllowEdit = false;
            this.colKyHieu.Visible = true;
            this.colKyHieu.VisibleIndex = 0;
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
            // colType
            // 
            this.colType.AppearanceHeader.Options.UseTextOptions = true;
            this.colType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colType.Caption = "Loại";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.AllowEdit = false;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 3;
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
            this.colSuDung.VisibleIndex = 4;
            // 
            // repSuDung
            // 
            this.repSuDung.AutoHeight = false;
            this.repSuDung.Name = "repSuDung";
            this.repSuDung.ValueChecked = 1;
            this.repSuDung.ValueUnchecked = 0;
            // 
            // FrmDMThoiHanThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 431);
            this.Controls.Add(this.grdThoiHanThanhToan);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolThoiHanThanhToan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDMThoiHanThanhToan";
            this.Text = "Danh mục thời hạn thanh toán";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolThoiHanThanhToan.ResumeLayout(false);
            this.toolThoiHanThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThoiHanThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThoiHanThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolThoiHanThanhToan;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grdThoiHanThanhToan;
        private DevExpress.XtraGrid.Views.Grid.GridView grvThoiHanThanhToan;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnChiTiet;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnExit;
        private DevExpress.XtraEditors.LabelControl lblTen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl lblMa;
        private DevExpress.XtraGrid.Columns.GridColumn colKyHieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSuDung;
    }
}