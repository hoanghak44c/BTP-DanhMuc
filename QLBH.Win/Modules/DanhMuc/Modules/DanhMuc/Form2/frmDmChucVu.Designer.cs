namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class frmDmChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmChucVu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.panelChucVu = new DevExpress.XtraEditors.PanelControl();
            this.lblTenChucVu = new DevExpress.XtraEditors.LabelControl();
            this.lblMaChucVu = new DevExpress.XtraEditors.LabelControl();
            this.txtTenChucVu = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCV = new DevExpress.XtraEditors.TextEdit();
            this.grcChucVu = new DevExpress.XtraGrid.GridControl();
            this.grvChucVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelChucVu)).BeginInit();
            this.panelChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTimKiem,
            this.btnAdd,
            this.btnCapNhat,
            this.btnDelete,
            this.btnExport,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(858, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 22);
            this.btnAdd.Text = "Thêm Mới (F3)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 22);
            this.btnCapNhat.Text = "Cập Nhật (F2)";
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
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 22);
            this.btnThoat.Text = "Thoát (Esc)";
            // 
            // panelChucVu
            // 
            this.panelChucVu.Controls.Add(this.lblTenChucVu);
            this.panelChucVu.Controls.Add(this.lblMaChucVu);
            this.panelChucVu.Controls.Add(this.txtTenChucVu);
            this.panelChucVu.Controls.Add(this.txtMaCV);
            this.panelChucVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChucVu.Location = new System.Drawing.Point(0, 25);
            this.panelChucVu.Name = "panelChucVu";
            this.panelChucVu.Size = new System.Drawing.Size(858, 85);
            this.panelChucVu.TabIndex = 1;
            // 
            // lblTenChucVu
            // 
            this.lblTenChucVu.Location = new System.Drawing.Point(379, 37);
            this.lblTenChucVu.Name = "lblTenChucVu";
            this.lblTenChucVu.Size = new System.Drawing.Size(61, 13);
            this.lblTenChucVu.TabIndex = 3;
            this.lblTenChucVu.Text = "Tên Chức Vụ";
            // 
            // lblMaChucVu
            // 
            this.lblMaChucVu.Location = new System.Drawing.Point(33, 37);
            this.lblMaChucVu.Name = "lblMaChucVu";
            this.lblMaChucVu.Size = new System.Drawing.Size(57, 13);
            this.lblMaChucVu.TabIndex = 2;
            this.lblMaChucVu.Text = "Mã Chức Vụ";
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenChucVu.Location = new System.Drawing.Point(448, 34);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(327, 20);
            this.txtTenChucVu.TabIndex = 1;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(102, 34);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(242, 20);
            this.txtMaCV.TabIndex = 0;
            // 
            // grcChucVu
            // 
            this.grcChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcChucVu.Location = new System.Drawing.Point(0, 110);
            this.grcChucVu.MainView = this.grvChucVu;
            this.grcChucVu.Name = "grcChucVu";
            this.grcChucVu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grcChucVu.Size = new System.Drawing.Size(858, 312);
            this.grcChucVu.TabIndex = 2;
            this.grcChucVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvChucVu});
            this.grcChucVu.DoubleClick += new System.EventHandler(this.grcChucVu_DoubleClick);
            // 
            // grvChucVu
            // 
            this.grvChucVu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaChucVu,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grvChucVu.GridControl = this.grcChucVu;
            this.grvChucVu.Name = "grvChucVu";
            this.grvChucVu.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMaChucVu
            // 
            this.colMaChucVu.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaChucVu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaChucVu.Caption = "Mã Chức Vụ";
            this.colMaChucVu.FieldName = "MaChucVu";
            this.colMaChucVu.Name = "colMaChucVu";
            this.colMaChucVu.Visible = true;
            this.colMaChucVu.VisibleIndex = 0;
            this.colMaChucVu.Width = 209;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Tên Chức Vụ";
            this.gridColumn1.FieldName = "TenChucVu";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 209;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Mô Tả";
            this.gridColumn2.FieldName = "MoTa";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 284;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Sử Dụng";
            this.gridColumn3.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn3.FieldName = "SuDung";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 135;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // frmDmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 422);
            this.Controls.Add(this.grcChucVu);
            this.Controls.Add(this.panelChucVu);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDmChucVu";
            this.Text = "Danh mục chức vụ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelChucVu)).EndInit();
            this.panelChucVu.ResumeLayout(false);
            this.panelChucVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripButton btnExport;
        private DevExpress.XtraEditors.PanelControl panelChucVu;
        private DevExpress.XtraEditors.LabelControl lblTenChucVu;
        private DevExpress.XtraEditors.LabelControl lblMaChucVu;
        private DevExpress.XtraEditors.TextEdit txtTenChucVu;
        private DevExpress.XtraEditors.TextEdit txtMaCV;
        private DevExpress.XtraGrid.GridControl grcChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView grvChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
    }
}