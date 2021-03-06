namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class FrmDMChiPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDMChiPhi));
            this.toolChiPhi = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.panelDM = new DevExpress.XtraEditors.PanelControl();
            this.lblMa = new DevExpress.XtraEditors.LabelControl();
            this.lblTen = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.grdChiPhi = new DevExpress.XtraGrid.GridControl();
            this.grvChiPhi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolChiPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDM)).BeginInit();
            this.panelDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdChiPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolChiPhi
            // 
            this.toolChiPhi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.btnSearch,
            this.btnAdd,
            this.btnEdit,
            this.btnExport,
            this.btnDelete,
            this.btnThoat});
            this.toolChiPhi.Location = new System.Drawing.Point(0, 0);
            this.toolChiPhi.Name = "toolChiPhi";
            this.toolChiPhi.Size = new System.Drawing.Size(867, 25);
            this.toolChiPhi.TabIndex = 0;
            this.toolChiPhi.Text = "toolStrip1";
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
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 22);
            this.btnAdd.Text = "Thêm Mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 22);
            this.btnEdit.Text = "Chi Tiết";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(58, 22);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelDM
            // 
            this.panelDM.Controls.Add(this.lblMa);
            this.panelDM.Controls.Add(this.lblTen);
            this.panelDM.Controls.Add(this.txtTen);
            this.panelDM.Controls.Add(this.txtMa);
            this.panelDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDM.Location = new System.Drawing.Point(0, 25);
            this.panelDM.Name = "panelDM";
            this.panelDM.Size = new System.Drawing.Size(867, 81);
            this.panelDM.TabIndex = 1;
            // 
            // lblMa
            // 
            this.lblMa.Location = new System.Drawing.Point(69, 32);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(49, 13);
            this.lblMa.TabIndex = 3;
            this.lblMa.Text = "Mã Chi Phí";
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(412, 32);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(53, 13);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên Chi Phí";
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(493, 29);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(278, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(138, 29);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(189, 20);
            this.txtMa.TabIndex = 0;
            // 
            // grdChiPhi
            // 
            this.grdChiPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdChiPhi.Location = new System.Drawing.Point(0, 106);
            this.grdChiPhi.MainView = this.grvChiPhi;
            this.grdChiPhi.Name = "grdChiPhi";
            this.grdChiPhi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSuDung});
            this.grdChiPhi.Size = new System.Drawing.Size(867, 325);
            this.grdChiPhi.TabIndex = 2;
            this.grdChiPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvChiPhi,
            this.gridView2});
            this.grdChiPhi.DoubleClick += new System.EventHandler(this.grdChiPhi_DoubleClick);
            // 
            // grvChiPhi
            // 
            this.grvChiPhi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colTen,
            this.colGhiChu,
            this.colSuDung});
            this.grvChiPhi.GridControl = this.grdChiPhi;
            this.grvChiPhi.Name = "grvChiPhi";
            this.grvChiPhi.OptionsView.ShowAutoFilterRow = true;
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
            // gridView2
            // 
            this.gridView2.GridControl = this.grdChiPhi;
            this.gridView2.Name = "gridView2";
            // 
            // FrmDMChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 431);
            this.Controls.Add(this.grdChiPhi);
            this.Controls.Add(this.panelDM);
            this.Controls.Add(this.toolChiPhi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDMChiPhi";
            this.Text = "Danh mục chi phí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolChiPhi.ResumeLayout(false);
            this.toolChiPhi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDM)).EndInit();
            this.panelDM.ResumeLayout(false);
            this.panelDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdChiPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolChiPhi;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraEditors.PanelControl panelDM;
        private DevExpress.XtraEditors.LabelControl lblMa;
        private DevExpress.XtraEditors.LabelControl lblTen;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraGrid.GridControl grdChiPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView grvChiPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSuDung;
    }
}