namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class FrmDMDuAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDMDuAn));
            this.toolDuAn = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.panelDM1 = new DevExpress.XtraEditors.PanelControl();
            this.lblMa = new DevExpress.XtraEditors.LabelControl();
            this.lblTen = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.grdDuAn = new DevExpress.XtraGrid.GridControl();
            this.grvDuAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDuAn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDuAn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.toolDuAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDM1)).BeginInit();
            this.panelDM1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDuAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDuAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).BeginInit();
            this.SuspendLayout();
            // 
            // toolDuAn
            // 
            this.toolDuAn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.btnSearch,
            this.btnAdd,
            this.btnEdit,
            this.btnExport,
            this.btnDelete,
            this.btnExit});
            this.toolDuAn.Location = new System.Drawing.Point(0, 0);
            this.toolDuAn.Name = "toolDuAn";
            this.toolDuAn.Size = new System.Drawing.Size(841, 25);
            this.toolDuAn.TabIndex = 0;
            this.toolDuAn.Text = "toolStrip1";
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
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 22);
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelDM1
            // 
            this.panelDM1.Controls.Add(this.lblMa);
            this.panelDM1.Controls.Add(this.lblTen);
            this.panelDM1.Controls.Add(this.txtTen);
            this.panelDM1.Controls.Add(this.txtMa);
            this.panelDM1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDM1.Location = new System.Drawing.Point(0, 25);
            this.panelDM1.Name = "panelDM1";
            this.panelDM1.Size = new System.Drawing.Size(841, 97);
            this.panelDM1.TabIndex = 1;
            // 
            // lblMa
            // 
            this.lblMa.Location = new System.Drawing.Point(89, 41);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(47, 13);
            this.lblMa.TabIndex = 3;
            this.lblMa.Text = "Mã Dự Án";
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(479, 41);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(51, 13);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên Dự Án";
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(536, 38);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(215, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(142, 38);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(215, 20);
            this.txtMa.TabIndex = 0;
            // 
            // grdDuAn
            // 
            this.grdDuAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDuAn.Location = new System.Drawing.Point(0, 122);
            this.grdDuAn.MainView = this.grvDuAn;
            this.grdDuAn.Name = "grdDuAn";
            this.grdDuAn.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSuDung});
            this.grdDuAn.Size = new System.Drawing.Size(841, 309);
            this.grdDuAn.TabIndex = 2;
            this.grdDuAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDuAn});
            this.grdDuAn.DoubleClick += new System.EventHandler(this.grdDuAn_DoubleClick);
            // 
            // grvDuAn
            // 
            this.grvDuAn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDuAn,
            this.colTenDuAn,
            this.colGhiChu,
            this.colSuDung});
            this.grvDuAn.GridControl = this.grdDuAn;
            this.grvDuAn.Name = "grvDuAn";
            this.grvDuAn.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMaDuAn
            // 
            this.colMaDuAn.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaDuAn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaDuAn.Caption = "Mã Dự Án";
            this.colMaDuAn.FieldName = "MaDuAn";
            this.colMaDuAn.Name = "colMaDuAn";
            this.colMaDuAn.OptionsColumn.AllowEdit = false;
            this.colMaDuAn.Visible = true;
            this.colMaDuAn.VisibleIndex = 0;
            // 
            // colTenDuAn
            // 
            this.colTenDuAn.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDuAn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDuAn.Caption = "Tên Dự Án";
            this.colTenDuAn.FieldName = "TenDuAn";
            this.colTenDuAn.Name = "colTenDuAn";
            this.colTenDuAn.OptionsColumn.AllowEdit = false;
            this.colTenDuAn.Visible = true;
            this.colTenDuAn.VisibleIndex = 1;
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
            // FrmDMDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 431);
            this.Controls.Add(this.grdDuAn);
            this.Controls.Add(this.panelDM1);
            this.Controls.Add(this.toolDuAn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDMDuAn";
            this.Text = "Danh mục dự án";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolDuAn.ResumeLayout(false);
            this.toolDuAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDM1)).EndInit();
            this.panelDM1.ResumeLayout(false);
            this.panelDM1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDuAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDuAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolDuAn;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnExit;
        private DevExpress.XtraEditors.PanelControl panelDM1;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraGrid.GridControl grdDuAn;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDuAn;
        private DevExpress.XtraEditors.LabelControl lblMa;
        private DevExpress.XtraEditors.LabelControl lblTen;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDuAn;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDuAn;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSuDung;
    }
}