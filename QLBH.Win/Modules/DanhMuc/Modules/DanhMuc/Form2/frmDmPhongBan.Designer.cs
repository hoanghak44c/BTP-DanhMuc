namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class frmDmPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmPhongBan));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grcPhongBan = new DevExpress.XtraGrid.GridControl();
            this.grvPhongBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenPhongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtTenPhongBan = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPhongBan = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grcPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhongBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhongBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(319, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên phòng ban";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã phòng ban";
            // 
            // grcPhongBan
            // 
            this.grcPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcPhongBan.Location = new System.Drawing.Point(2, 2);
            this.grcPhongBan.MainView = this.grvPhongBan;
            this.grcPhongBan.Name = "grcPhongBan";
            this.grcPhongBan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSuDung});
            this.grcPhongBan.Size = new System.Drawing.Size(812, 294);
            this.grcPhongBan.TabIndex = 1;
            this.grcPhongBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPhongBan,
            this.gridView2});
            this.grcPhongBan.DoubleClick += new System.EventHandler(this.grcPhongBan_DoubleClick);
            // 
            // grvPhongBan
            // 
            this.grvPhongBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhongBan,
            this.colTenPhongBan,
            this.colGhiChu,
            this.colSuDung});
            this.grvPhongBan.GridControl = this.grcPhongBan;
            this.grvPhongBan.Name = "grvPhongBan";
            this.grvPhongBan.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMaPhongBan
            // 
            this.colMaPhongBan.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaPhongBan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaPhongBan.Caption = "Mã Phòng Ban";
            this.colMaPhongBan.FieldName = "MaPhongBan";
            this.colMaPhongBan.Name = "colMaPhongBan";
            this.colMaPhongBan.OptionsColumn.AllowEdit = false;
            this.colMaPhongBan.OptionsColumn.FixedWidth = true;
            this.colMaPhongBan.Visible = true;
            this.colMaPhongBan.VisibleIndex = 0;
            this.colMaPhongBan.Width = 112;
            // 
            // colTenPhongBan
            // 
            this.colTenPhongBan.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenPhongBan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenPhongBan.Caption = "Tên Phòng Ban";
            this.colTenPhongBan.FieldName = "TenPhongBan";
            this.colTenPhongBan.Name = "colTenPhongBan";
            this.colTenPhongBan.OptionsColumn.AllowEdit = false;
            this.colTenPhongBan.Visible = true;
            this.colTenPhongBan.VisibleIndex = 1;
            this.colTenPhongBan.Width = 297;
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
            this.colGhiChu.Width = 300;
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
            this.colSuDung.OptionsColumn.FixedWidth = true;
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
            this.gridView2.GridControl = this.grcPhongBan;
            this.gridView2.Name = "gridView2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.btnSearch,
            this.btnCapNhat,
            this.btnDelete,
            this.btnExport,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(816, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtTenPhongBan);
            this.panelControl1.Controls.Add(this.txtMaPhongBan);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(816, 87);
            this.panelControl1.TabIndex = 4;
            // 
            // txtTenPhongBan
            // 
            this.txtTenPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenPhongBan.Location = new System.Drawing.Point(397, 40);
            this.txtTenPhongBan.Name = "txtTenPhongBan";
            this.txtTenPhongBan.Size = new System.Drawing.Size(257, 20);
            this.txtTenPhongBan.TabIndex = 5;
            // 
            // txtMaPhongBan
            // 
            this.txtMaPhongBan.Location = new System.Drawing.Point(114, 40);
            this.txtMaPhongBan.Name = "txtMaPhongBan";
            this.txtMaPhongBan.Size = new System.Drawing.Size(172, 20);
            this.txtMaPhongBan.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grcPhongBan);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 112);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(816, 298);
            this.panelControl2.TabIndex = 5;
            // 
            // frmDmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 410);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDmPhongBan";
            this.Text = "Danh mục phòng ban";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grcPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhongBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhongBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcPhongBan;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPhongBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSuDung;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenPhongBan;
        private DevExpress.XtraEditors.TextEdit txtMaPhongBan;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}