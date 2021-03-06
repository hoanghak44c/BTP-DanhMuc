namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class FrmDmDonViTinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDmDonViTinh));
            this.tSDonViTinh = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.grdDonViTinh = new DevExpress.XtraGrid.GridControl();
            this.grvDonViTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tSDonViTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).BeginInit();
            this.SuspendLayout();
            // 
            // tSDonViTinh
            // 
            this.tSDonViTinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.btnSearch,
            this.btnCapNhat,
            this.btnDelete,
            this.btnExport,
            this.btnExit});
            this.tSDonViTinh.Location = new System.Drawing.Point(0, 0);
            this.tSDonViTinh.Name = "tSDonViTinh";
            this.tSDonViTinh.Size = new System.Drawing.Size(817, 25);
            this.tSDonViTinh.TabIndex = 0;
            this.tSDonViTinh.Text = "toolStrip1";
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
            this.btnDelete.Size = new System.Drawing.Size(47, 22);
            this.btnDelete.Text = "Xóa";
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
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtTenDonViTinh);
            this.panelControl1.Controls.Add(this.txtMaDonViTinh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(817, 83);
            this.panelControl1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(362, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên Đơn Vị Tính";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã Đơn Vị Tính";
            // 
            // txtTenDonViTinh
            // 
            this.txtTenDonViTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDonViTinh.Location = new System.Drawing.Point(443, 36);
            this.txtTenDonViTinh.Name = "txtTenDonViTinh";
            this.txtTenDonViTinh.Size = new System.Drawing.Size(301, 20);
            this.txtTenDonViTinh.TabIndex = 1;
            // 
            // txtMaDonViTinh
            // 
            this.txtMaDonViTinh.Location = new System.Drawing.Point(90, 36);
            this.txtMaDonViTinh.Name = "txtMaDonViTinh";
            this.txtMaDonViTinh.Size = new System.Drawing.Size(220, 20);
            this.txtMaDonViTinh.TabIndex = 0;
            // 
            // grdDonViTinh
            // 
            this.grdDonViTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDonViTinh.Location = new System.Drawing.Point(0, 108);
            this.grdDonViTinh.MainView = this.grvDonViTinh;
            this.grdDonViTinh.Name = "grdDonViTinh";
            this.grdDonViTinh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSuDung});
            this.grdDonViTinh.Size = new System.Drawing.Size(817, 323);
            this.grdDonViTinh.TabIndex = 3;
            this.grdDonViTinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDonViTinh});
            // 
            // grvDonViTinh
            // 
            this.grvDonViTinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKyHieu,
            this.colTenDVT,
            this.colGhiChu,
            this.colSuDung});
            this.grvDonViTinh.GridControl = this.grdDonViTinh;
            this.grvDonViTinh.Name = "grvDonViTinh";
            this.grvDonViTinh.OptionsView.ShowAutoFilterRow = true;
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
            // colTenDVT
            // 
            this.colTenDVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDVT.Caption = "Tên Đơn Vị Tính";
            this.colTenDVT.FieldName = "TenDonViTinh";
            this.colTenDVT.Name = "colTenDVT";
            this.colTenDVT.OptionsColumn.AllowEdit = false;
            this.colTenDVT.Visible = true;
            this.colTenDVT.VisibleIndex = 1;
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
            // FrmDmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 431);
            this.Controls.Add(this.grdDonViTinh);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.tSDonViTinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDmDonViTinh";
            this.Text = "Danh mục đơn vị tính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tSDonViTinh.ResumeLayout(false);
            this.tSDonViTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSDonViTinh;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnExit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenDonViTinh;
        private DevExpress.XtraEditors.TextEdit txtMaDonViTinh;
        private DevExpress.XtraGrid.GridControl grdDonViTinh;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colKyHieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSuDung;
    }
}