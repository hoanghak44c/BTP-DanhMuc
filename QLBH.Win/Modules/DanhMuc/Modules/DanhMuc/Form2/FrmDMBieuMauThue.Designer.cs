namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class FrmDMBieuMauThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDMBieuMauThue));
            this.toolDMBieuMauThue = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.panelDMBieuMau1 = new DevExpress.XtraEditors.PanelControl();
            this.lblTenTaxCode = new DevExpress.XtraEditors.LabelControl();
            this.lblMaTaxCode = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTaxCode = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTaxCode = new DevExpress.XtraEditors.TextEdit();
            this.grdDMBieuMauThue = new DevExpress.XtraGrid.GridControl();
            this.grvDMBieuMauThue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolDMBieuMauThue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDMBieuMau1)).BeginInit();
            this.panelDMBieuMau1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaxCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTaxCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDMBieuMauThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDMBieuMauThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).BeginInit();
            this.SuspendLayout();
            // 
            // toolDMBieuMauThue
            // 
            this.toolDMBieuMauThue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.btnAdd,
            this.btnTimKiem,
            this.btnEdit,
            this.btnExport,
            this.btnDelete,
            this.btnThoat});
            this.toolDMBieuMauThue.Location = new System.Drawing.Point(0, 0);
            this.toolDMBieuMauThue.Name = "toolDMBieuMauThue";
            this.toolDMBieuMauThue.Size = new System.Drawing.Size(867, 25);
            this.toolDMBieuMauThue.TabIndex = 0;
            this.toolDMBieuMauThue.Text = "toolStrip1";
            // 
            // btnDongBo
            // 
            this.btnDongBo.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBo.Image")));
            this.btnDongBo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDongBo.Name = "btnDongBo";
            this.btnDongBo.Size = new System.Drawing.Size(73, 22);
            this.btnDongBo.Text = "Đồng Bộ";
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
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(78, 22);
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            // panelDMBieuMau1
            // 
            this.panelDMBieuMau1.Controls.Add(this.lblTenTaxCode);
            this.panelDMBieuMau1.Controls.Add(this.lblMaTaxCode);
            this.panelDMBieuMau1.Controls.Add(this.txtTenTaxCode);
            this.panelDMBieuMau1.Controls.Add(this.txtMaTaxCode);
            this.panelDMBieuMau1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDMBieuMau1.Location = new System.Drawing.Point(0, 25);
            this.panelDMBieuMau1.Name = "panelDMBieuMau1";
            this.panelDMBieuMau1.Size = new System.Drawing.Size(867, 79);
            this.panelDMBieuMau1.TabIndex = 1;
            // 
            // lblTenTaxCode
            // 
            this.lblTenTaxCode.Location = new System.Drawing.Point(456, 32);
            this.lblTenTaxCode.Name = "lblTenTaxCode";
            this.lblTenTaxCode.Size = new System.Drawing.Size(64, 13);
            this.lblTenTaxCode.TabIndex = 3;
            this.lblTenTaxCode.Text = "Tên TaxCode";
            // 
            // lblMaTaxCode
            // 
            this.lblMaTaxCode.Location = new System.Drawing.Point(98, 32);
            this.lblMaTaxCode.Name = "lblMaTaxCode";
            this.lblMaTaxCode.Size = new System.Drawing.Size(60, 13);
            this.lblMaTaxCode.TabIndex = 2;
            this.lblMaTaxCode.Text = "Mã TaxCode";
            // 
            // txtTenTaxCode
            // 
            this.txtTenTaxCode.Location = new System.Drawing.Point(525, 29);
            this.txtTenTaxCode.Name = "txtTenTaxCode";
            this.txtTenTaxCode.Size = new System.Drawing.Size(243, 20);
            this.txtTenTaxCode.TabIndex = 1;
            // 
            // txtMaTaxCode
            // 
            this.txtMaTaxCode.Location = new System.Drawing.Point(167, 29);
            this.txtMaTaxCode.Name = "txtMaTaxCode";
            this.txtMaTaxCode.Size = new System.Drawing.Size(232, 20);
            this.txtMaTaxCode.TabIndex = 0;
            // 
            // grdDMBieuMauThue
            // 
            this.grdDMBieuMauThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDMBieuMauThue.Location = new System.Drawing.Point(0, 104);
            this.grdDMBieuMauThue.MainView = this.grvDMBieuMauThue;
            this.grdDMBieuMauThue.Name = "grdDMBieuMauThue";
            this.grdDMBieuMauThue.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSuDung});
            this.grdDMBieuMauThue.Size = new System.Drawing.Size(867, 327);
            this.grdDMBieuMauThue.TabIndex = 2;
            this.grdDMBieuMauThue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDMBieuMauThue});
            this.grdDMBieuMauThue.DoubleClick += new System.EventHandler(this.grdDMBieuMauThue_DoubleClick);
            // 
            // grvDMBieuMauThue
            // 
            this.grvDMBieuMauThue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.grvDMBieuMauThue.GridControl = this.grdDMBieuMauThue;
            this.grvDMBieuMauThue.Name = "grvDMBieuMauThue";
            this.grvDMBieuMauThue.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Mã";
            this.gridColumn1.FieldName = "Code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Tên";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Ghi Chú";
            this.gridColumn3.FieldName = "GhiChu";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Sử Dụng";
            this.gridColumn4.ColumnEdit = this.repSuDung;
            this.gridColumn4.FieldName = "SuDung";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // repSuDung
            // 
            this.repSuDung.AutoHeight = false;
            this.repSuDung.Name = "repSuDung";
            this.repSuDung.ValueChecked = 1;
            this.repSuDung.ValueUnchecked = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Giá Trị";
            this.gridColumn5.FieldName = "GiaTri";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // FrmDMBieuMauThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 431);
            this.Controls.Add(this.grdDMBieuMauThue);
            this.Controls.Add(this.panelDMBieuMau1);
            this.Controls.Add(this.toolDMBieuMauThue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDMBieuMauThue";
            this.Text = "Danh mục biểu mẫu thuế";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolDMBieuMauThue.ResumeLayout(false);
            this.toolDMBieuMauThue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDMBieuMau1)).EndInit();
            this.panelDMBieuMau1.ResumeLayout(false);
            this.panelDMBieuMau1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaxCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTaxCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDMBieuMauThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDMBieuMauThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolDMBieuMauThue;
        private DevExpress.XtraEditors.PanelControl panelDMBieuMau1;
        private DevExpress.XtraGrid.GridControl grdDMBieuMauThue;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDMBieuMauThue;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraEditors.LabelControl lblTenTaxCode;
        private DevExpress.XtraEditors.LabelControl lblMaTaxCode;
        private DevExpress.XtraEditors.TextEdit txtTenTaxCode;
        private DevExpress.XtraEditors.TextEdit txtMaTaxCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSuDung;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}