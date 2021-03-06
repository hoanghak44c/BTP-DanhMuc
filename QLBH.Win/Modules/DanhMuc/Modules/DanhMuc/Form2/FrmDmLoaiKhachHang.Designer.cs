namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class FrmDmLoaiKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDmLoaiKhachHang));
            this.tollDMLoaiDT = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.panelDMLoaiDT = new DevExpress.XtraEditors.PanelControl();
            this.lblTenDT = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDT = new DevExpress.XtraEditors.TextEdit();
            this.grdLoaiDT = new DevExpress.XtraGrid.GridControl();
            this.grvLoaiDT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoaiDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhomCha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tollDMLoaiDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDMLoaiDT)).BeginInit();
            this.panelDMLoaiDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoaiDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLoaiDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).BeginInit();
            this.SuspendLayout();
            // 
            // tollDMLoaiDT
            // 
            this.tollDMLoaiDT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.btnSearch,
            this.toolStripButton3,
            this.btnDelete,
            this.btnExport,
            this.btnThoat});
            this.tollDMLoaiDT.Location = new System.Drawing.Point(0, 0);
            this.tollDMLoaiDT.Name = "tollDMLoaiDT";
            this.tollDMLoaiDT.Size = new System.Drawing.Size(867, 25);
            this.tollDMLoaiDT.TabIndex = 0;
            this.tollDMLoaiDT.Text = "toolStrip1";
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
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(77, 22);
            this.toolStripButton3.Text = "Cập Nhật";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 22);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(63, 22);
            this.btnExport.Text = "Export ";
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
            // panelDMLoaiDT
            // 
            this.panelDMLoaiDT.Controls.Add(this.lblTenDT);
            this.panelDMLoaiDT.Controls.Add(this.txtTenDT);
            this.panelDMLoaiDT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDMLoaiDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDMLoaiDT.Location = new System.Drawing.Point(0, 25);
            this.panelDMLoaiDT.Name = "panelDMLoaiDT";
            this.panelDMLoaiDT.Size = new System.Drawing.Size(867, 94);
            this.panelDMLoaiDT.TabIndex = 1;
            // 
            // lblTenDT
            // 
            this.lblTenDT.Location = new System.Drawing.Point(99, 44);
            this.lblTenDT.Name = "lblTenDT";
            this.lblTenDT.Size = new System.Drawing.Size(93, 13);
            this.lblTenDT.TabIndex = 3;
            this.lblTenDT.Text = "Tên Loại Đối Tượng";
            // 
            // txtTenDT
            // 
            this.txtTenDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDT.Location = new System.Drawing.Point(198, 41);
            this.txtTenDT.Name = "txtTenDT";
            this.txtTenDT.Size = new System.Drawing.Size(521, 20);
            this.txtTenDT.TabIndex = 1;
            // 
            // grdLoaiDT
            // 
            this.grdLoaiDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLoaiDT.Location = new System.Drawing.Point(0, 119);
            this.grdLoaiDT.MainView = this.grvLoaiDT;
            this.grdLoaiDT.Name = "grdLoaiDT";
            this.grdLoaiDT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSuDung});
            this.grdLoaiDT.Size = new System.Drawing.Size(867, 312);
            this.grdLoaiDT.TabIndex = 2;
            this.grdLoaiDT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLoaiDT});
            this.grdLoaiDT.DoubleClick += new System.EventHandler(this.grdLoaiDT_DoubleClick);
            // 
            // grvLoaiDT
            // 
            this.grvLoaiDT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoaiDT,
            this.colTenLoaiDT,
            this.colGhiChu,
            this.colNhomCha,
            this.colSuDung});
            this.grvLoaiDT.GridControl = this.grdLoaiDT;
            this.grvLoaiDT.Name = "grvLoaiDT";
            this.grvLoaiDT.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMaLoaiDT
            // 
            this.colMaLoaiDT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaLoaiDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaLoaiDT.Caption = "Mã Loại Đối Tượng";
            this.colMaLoaiDT.FieldName = "MaLoaiDT";
            this.colMaLoaiDT.Name = "colMaLoaiDT";
            this.colMaLoaiDT.OptionsColumn.AllowEdit = false;
            this.colMaLoaiDT.Visible = true;
            this.colMaLoaiDT.VisibleIndex = 0;
            // 
            // colTenLoaiDT
            // 
            this.colTenLoaiDT.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenLoaiDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenLoaiDT.Caption = "Tên Loại Đối Tượng";
            this.colTenLoaiDT.FieldName = "TenLoaiDT";
            this.colTenLoaiDT.Name = "colTenLoaiDT";
            this.colTenLoaiDT.OptionsColumn.AllowEdit = false;
            this.colTenLoaiDT.Visible = true;
            this.colTenLoaiDT.VisibleIndex = 1;
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
            // colNhomCha
            // 
            this.colNhomCha.AppearanceHeader.Options.UseTextOptions = true;
            this.colNhomCha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNhomCha.Caption = "Nhóm Cha";
            this.colNhomCha.FieldName = "NhomCha";
            this.colNhomCha.Name = "colNhomCha";
            this.colNhomCha.OptionsColumn.AllowEdit = false;
            this.colNhomCha.Visible = true;
            this.colNhomCha.VisibleIndex = 3;
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
            // FrmDmLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 431);
            this.Controls.Add(this.grdLoaiDT);
            this.Controls.Add(this.panelDMLoaiDT);
            this.Controls.Add(this.tollDMLoaiDT);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDmLoaiKhachHang";
            this.Text = "Danh mục loại khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tollDMLoaiDT.ResumeLayout(false);
            this.tollDMLoaiDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDMLoaiDT)).EndInit();
            this.panelDMLoaiDT.ResumeLayout(false);
            this.panelDMLoaiDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoaiDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLoaiDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tollDMLoaiDT;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraEditors.PanelControl panelDMLoaiDT;
        private DevExpress.XtraEditors.TextEdit txtTenDT;
        private DevExpress.XtraGrid.GridControl grdLoaiDT;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLoaiDT;
        private DevExpress.XtraEditors.LabelControl lblTenDT;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiDT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiDT;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colNhomCha;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSuDung;
    }
}