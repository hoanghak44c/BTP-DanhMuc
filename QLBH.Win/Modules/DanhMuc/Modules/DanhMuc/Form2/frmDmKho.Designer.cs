namespace QLBanHang.Modules.DanhMuc.Views
{
    partial class frmDmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmKho));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.grcDmKho = new DevExpress.XtraGrid.GridControl();
            this.grvDmKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colMaVung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtherTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhoOracle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDemo = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDmKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDmKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.btnSearch,
            this.btnCapNhat,
            this.btnExport,
            this.btnDelete,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(827, 25);
            this.toolStrip1.TabIndex = 0;
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
            this.btnSearch.Size = new System.Drawing.Size(66, 22);
            this.btnSearch.Text = "Lọc(F9)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(97, 22);
            this.btnCapNhat.Text = "Cập Nhật(F2)";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
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
            this.btnDelete.Size = new System.Drawing.Size(67, 22);
            this.btnDelete.Text = "Xóa(F8)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 22);
            this.btnExit.Text = "Thoát(ESC)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.textEdit2);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(827, 100);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(245, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên Kho";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã Kho";
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit2.Location = new System.Drawing.Point(290, 45);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(232, 20);
            this.textEdit2.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(64, 45);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(123, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // grcDmKho
            // 
            this.grcDmKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDmKho.Location = new System.Drawing.Point(0, 125);
            this.grcDmKho.MainView = this.grvDmKho;
            this.grcDmKho.Name = "grcDmKho";
            this.grcDmKho.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDemo,
            this.repSuDung});
            this.grcDmKho.Size = new System.Drawing.Size(827, 316);
            this.grcDmKho.TabIndex = 2;
            this.grcDmKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDmKho});
            this.grcDmKho.DoubleClick += new System.EventHandler(this.grcDmKho_DoubleClick);
            // 
            // grvDmKho
            // 
            this.grvDmKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKho,
            this.colTenKho,
            this.colDiaChi,
            this.colDienThoai,
            this.colFax,
            this.colEmail,
            this.colSuDung,
            this.colMaVung,
            this.colOtherTrungTam,
            this.colMaKhoOracle,
            this.colDemo});
            this.grvDmKho.GridControl = this.grcDmKho;
            this.grvDmKho.Name = "grvDmKho";
            this.grvDmKho.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMaKho
            // 
            this.colMaKho.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaKho.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaKho.Caption = "Mã Kho";
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.OptionsColumn.AllowEdit = false;
            this.colMaKho.OptionsColumn.FixedWidth = true;
            this.colMaKho.Visible = true;
            this.colMaKho.VisibleIndex = 0;
            // 
            // colTenKho
            // 
            this.colTenKho.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenKho.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenKho.Caption = "Tên Kho";
            this.colTenKho.FieldName = "TenKho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.OptionsColumn.AllowEdit = false;
            this.colTenKho.Visible = true;
            this.colTenKho.VisibleIndex = 1;
            this.colTenKho.Width = 68;
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
            this.colDiaChi.Width = 68;
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
            this.colSuDung.VisibleIndex = 6;
            // 
            // repSuDung
            // 
            this.repSuDung.AutoHeight = false;
            this.repSuDung.Name = "repSuDung";
            this.repSuDung.ValueChecked = 1;
            this.repSuDung.ValueUnchecked = 0;
            // 
            // colMaVung
            // 
            this.colMaVung.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaVung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaVung.Caption = "Mã Vùng";
            this.colMaVung.FieldName = "MaVung";
            this.colMaVung.Name = "colMaVung";
            this.colMaVung.OptionsColumn.AllowEdit = false;
            this.colMaVung.OptionsColumn.FixedWidth = true;
            this.colMaVung.Visible = true;
            this.colMaVung.VisibleIndex = 7;
            // 
            // colOtherTrungTam
            // 
            this.colOtherTrungTam.AppearanceHeader.Options.UseTextOptions = true;
            this.colOtherTrungTam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOtherTrungTam.Caption = "Trung Tâm Khác";
            this.colOtherTrungTam.FieldName = "OtherTrungTam";
            this.colOtherTrungTam.Name = "colOtherTrungTam";
            this.colOtherTrungTam.OptionsColumn.AllowEdit = false;
            this.colOtherTrungTam.Visible = true;
            this.colOtherTrungTam.VisibleIndex = 8;
            this.colOtherTrungTam.Width = 148;
            // 
            // colMaKhoOracle
            // 
            this.colMaKhoOracle.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaKhoOracle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaKhoOracle.Caption = "Mã Kho Oracle";
            this.colMaKhoOracle.FieldName = "MaKhoOracle";
            this.colMaKhoOracle.Name = "colMaKhoOracle";
            this.colMaKhoOracle.OptionsColumn.AllowEdit = false;
            this.colMaKhoOracle.OptionsColumn.FixedWidth = true;
            this.colMaKhoOracle.Visible = true;
            this.colMaKhoOracle.VisibleIndex = 9;
            // 
            // colDemo
            // 
            this.colDemo.AppearanceHeader.Options.UseTextOptions = true;
            this.colDemo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDemo.Caption = "Kho Demo";
            this.colDemo.ColumnEdit = this.repDemo;
            this.colDemo.FieldName = "Type";
            this.colDemo.Name = "colDemo";
            this.colDemo.OptionsColumn.AllowEdit = false;
            this.colDemo.OptionsColumn.FixedWidth = true;
            this.colDemo.Visible = true;
            this.colDemo.VisibleIndex = 10;
            // 
            // repDemo
            // 
            this.repDemo.AutoHeight = false;
            this.repDemo.Name = "repDemo";
            this.repDemo.ValueChecked = 1;
            this.repDemo.ValueUnchecked = 0;
            // 
            // frmDmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 441);
            this.Controls.Add(this.grcDmKho);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDmKho";
            this.Text = "Danh mục kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDmKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDmKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnExport;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl grcDmKho;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDmKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraGrid.Columns.GridColumn colMaVung;
        private DevExpress.XtraGrid.Columns.GridColumn colOtherTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoOracle;
        private DevExpress.XtraGrid.Columns.GridColumn colDemo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSuDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repDemo;
        private System.Windows.Forms.ToolStripButton btnExit;
    }
}