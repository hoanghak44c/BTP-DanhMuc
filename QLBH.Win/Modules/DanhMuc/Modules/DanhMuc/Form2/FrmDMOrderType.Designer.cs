namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class FrmDMOrderType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDMOrderType));
            this.toolOrderType = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.pannelOrderType = new DevExpress.XtraEditors.PanelControl();
            this.lblTenOrderType = new DevExpress.XtraEditors.LabelControl();
            this.lblMaOrderType = new DevExpress.XtraEditors.LabelControl();
            this.txtTenOrderType = new DevExpress.XtraEditors.TextEdit();
            this.txtMaOrderType = new DevExpress.XtraEditors.TextEdit();
            this.grdDMOrderType = new DevExpress.XtraGrid.GridControl();
            this.grvDMOrderType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colLineType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineKm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineCk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNganhHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolOrderType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pannelOrderType)).BeginInit();
            this.pannelOrderType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenOrderType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaOrderType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDMOrderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDMOrderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).BeginInit();
            this.SuspendLayout();
            // 
            // toolOrderType
            // 
            this.toolOrderType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.toolStripButton4,
            this.btnAdd,
            this.btnEdit,
            this.btnExport,
            this.btnDelete,
            this.btnThoat});
            this.toolOrderType.Location = new System.Drawing.Point(0, 0);
            this.toolOrderType.Name = "toolOrderType";
            this.toolOrderType.Size = new System.Drawing.Size(857, 25);
            this.toolOrderType.TabIndex = 0;
            this.toolOrderType.Text = "toolStrip1";
            // 
            // btnDongBo
            // 
            this.btnDongBo.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBo.Image")));
            this.btnDongBo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDongBo.Name = "btnDongBo";
            this.btnDongBo.Size = new System.Drawing.Size(73, 22);
            this.btnDongBo.Text = "Đồng Bộ";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton4.Text = "Tìm Kiếm";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
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
            // pannelOrderType
            // 
            this.pannelOrderType.Controls.Add(this.lblTenOrderType);
            this.pannelOrderType.Controls.Add(this.lblMaOrderType);
            this.pannelOrderType.Controls.Add(this.txtTenOrderType);
            this.pannelOrderType.Controls.Add(this.txtMaOrderType);
            this.pannelOrderType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelOrderType.Location = new System.Drawing.Point(0, 25);
            this.pannelOrderType.Name = "pannelOrderType";
            this.pannelOrderType.Size = new System.Drawing.Size(857, 79);
            this.pannelOrderType.TabIndex = 1;
            // 
            // lblTenOrderType
            // 
            this.lblTenOrderType.Location = new System.Drawing.Point(379, 36);
            this.lblTenOrderType.Name = "lblTenOrderType";
            this.lblTenOrderType.Size = new System.Drawing.Size(73, 13);
            this.lblTenOrderType.TabIndex = 3;
            this.lblTenOrderType.Text = "Tên OrderType";
            // 
            // lblMaOrderType
            // 
            this.lblMaOrderType.Location = new System.Drawing.Point(8, 36);
            this.lblMaOrderType.Name = "lblMaOrderType";
            this.lblMaOrderType.Size = new System.Drawing.Size(69, 13);
            this.lblMaOrderType.TabIndex = 2;
            this.lblMaOrderType.Text = "Mã OrderType";
            // 
            // txtTenOrderType
            // 
            this.txtTenOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenOrderType.Location = new System.Drawing.Point(458, 33);
            this.txtTenOrderType.Name = "txtTenOrderType";
            this.txtTenOrderType.Size = new System.Drawing.Size(232, 20);
            this.txtTenOrderType.TabIndex = 1;
            // 
            // txtMaOrderType
            // 
            this.txtMaOrderType.Location = new System.Drawing.Point(89, 33);
            this.txtMaOrderType.Name = "txtMaOrderType";
            this.txtMaOrderType.Size = new System.Drawing.Size(212, 20);
            this.txtMaOrderType.TabIndex = 0;
            // 
            // grdDMOrderType
            // 
            this.grdDMOrderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDMOrderType.Location = new System.Drawing.Point(0, 104);
            this.grdDMOrderType.MainView = this.grvDMOrderType;
            this.grdDMOrderType.Name = "grdDMOrderType";
            this.grdDMOrderType.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSuDung});
            this.grdDMOrderType.Size = new System.Drawing.Size(857, 281);
            this.grdDMOrderType.TabIndex = 2;
            this.grdDMOrderType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDMOrderType});
            this.grdDMOrderType.DoubleClick += new System.EventHandler(this.grdDMOrderType_DoubleClick);
            // 
            // grvDMOrderType
            // 
            this.grvDMOrderType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOrder,
            this.colOrderType,
            this.colName,
            this.colGhiChu,
            this.colSuDung,
            this.colLineType,
            this.colLineKm,
            this.colLineCk,
            this.colNganhHang});
            this.grvDMOrderType.GridControl = this.grdDMOrderType;
            this.grvDMOrderType.Name = "grvDMOrderType";
            // 
            // colIdOrder
            // 
            this.colIdOrder.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdOrder.Caption = "Id Order Type";
            this.colIdOrder.FieldName = "IdOrderType";
            this.colIdOrder.Name = "colIdOrder";
            this.colIdOrder.Visible = true;
            this.colIdOrder.VisibleIndex = 0;
            // 
            // colOrderType
            // 
            this.colOrderType.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderType.Caption = "Order Type";
            this.colOrderType.FieldName = "OrderType";
            this.colOrderType.Name = "colOrderType";
            this.colOrderType.Visible = true;
            this.colOrderType.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.Caption = "Tên";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhiChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 3;
            // 
            // colSuDung
            // 
            this.colSuDung.AppearanceHeader.Options.UseTextOptions = true;
            this.colSuDung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuDung.Caption = "Sử Dụng";
            this.colSuDung.ColumnEdit = this.repSuDung;
            this.colSuDung.FieldName = "SuDung";
            this.colSuDung.Name = "colSuDung";
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
            // colLineType
            // 
            this.colLineType.AppearanceHeader.Options.UseTextOptions = true;
            this.colLineType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLineType.Caption = "Line Type";
            this.colLineType.FieldName = "LineType";
            this.colLineType.Name = "colLineType";
            this.colLineType.Visible = true;
            this.colLineType.VisibleIndex = 5;
            // 
            // colLineKm
            // 
            this.colLineKm.AppearanceHeader.Options.UseTextOptions = true;
            this.colLineKm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLineKm.Caption = "Line Km";
            this.colLineKm.FieldName = "LineKm";
            this.colLineKm.Name = "colLineKm";
            this.colLineKm.Visible = true;
            this.colLineKm.VisibleIndex = 6;
            // 
            // colLineCk
            // 
            this.colLineCk.AppearanceHeader.Options.UseTextOptions = true;
            this.colLineCk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLineCk.Caption = "Line Ck";
            this.colLineCk.FieldName = "LineCk";
            this.colLineCk.Name = "colLineCk";
            this.colLineCk.Visible = true;
            this.colLineCk.VisibleIndex = 7;
            // 
            // colNganhHang
            // 
            this.colNganhHang.AppearanceHeader.Options.UseTextOptions = true;
            this.colNganhHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNganhHang.Caption = "Ngành Hàng";
            this.colNganhHang.FieldName = "NganhHang";
            this.colNganhHang.Name = "colNganhHang";
            this.colNganhHang.Visible = true;
            this.colNganhHang.VisibleIndex = 8;
            // 
            // FrmDMOrderType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 385);
            this.Controls.Add(this.grdDMOrderType);
            this.Controls.Add(this.pannelOrderType);
            this.Controls.Add(this.toolOrderType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDMOrderType";
            this.Text = "Danh mục Order Type";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolOrderType.ResumeLayout(false);
            this.toolOrderType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pannelOrderType)).EndInit();
            this.pannelOrderType.ResumeLayout(false);
            this.pannelOrderType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenOrderType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaOrderType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDMOrderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDMOrderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolOrderType;
        private DevExpress.XtraEditors.PanelControl pannelOrderType;
        private DevExpress.XtraGrid.GridControl grdDMOrderType;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDMOrderType;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraEditors.LabelControl lblTenOrderType;
        private DevExpress.XtraEditors.LabelControl lblMaOrderType;
        private DevExpress.XtraEditors.TextEdit txtTenOrderType;
        private DevExpress.XtraEditors.TextEdit txtMaOrderType;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderType;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSuDung;
        private DevExpress.XtraGrid.Columns.GridColumn colLineType;
        private DevExpress.XtraGrid.Columns.GridColumn colLineKm;
        private DevExpress.XtraGrid.Columns.GridColumn colLineCk;
        private DevExpress.XtraGrid.Columns.GridColumn colNganhHang;
    }
}