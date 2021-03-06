namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class frmDmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmNhanVien));
            this.toolNhanVien = new System.Windows.Forms.ToolStrip();
            this.btnDongBo = new System.Windows.Forms.ToolStripButton();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblChucDanh = new DevExpress.XtraEditors.LabelControl();
            this.lblTenNV = new DevExpress.XtraEditors.LabelControl();
            this.lblPhongBan = new DevExpress.XtraEditors.LabelControl();
            this.lblMaNV = new DevExpress.XtraEditors.LabelControl();
            this.lueChucDanh = new DevExpress.XtraEditors.LookUpEdit();
            this.luePhongBan = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.grdNhanVien = new DevExpress.XtraGrid.GridControl();
            this.grvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueChucDanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePhongBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).BeginInit();
            this.SuspendLayout();
            // 
            // toolNhanVien
            // 
            this.toolNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDongBo,
            this.btnTimKiem,
            this.btnAdd,
            this.btnCapNhat,
            this.btnExport,
            this.btnXoa,
            this.btnThoat});
            this.toolNhanVien.Location = new System.Drawing.Point(0, 0);
            this.toolNhanVien.Name = "toolNhanVien";
            this.toolNhanVien.Size = new System.Drawing.Size(875, 25);
            this.toolNhanVien.TabIndex = 0;
            this.toolNhanVien.Text = "toolStrip1";
            // 
            // btnDongBo
            // 
            this.btnDongBo.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBo.Image")));
            this.btnDongBo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDongBo.Name = "btnDongBo";
            this.btnDongBo.Size = new System.Drawing.Size(73, 22);
            this.btnDongBo.Text = "Đồng Bộ";
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
            this.btnAdd.Size = new System.Drawing.Size(82, 22);
            this.btnAdd.Text = "Thêm Mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(60, 22);
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblChucDanh);
            this.panelControl1.Controls.Add(this.lblTenNV);
            this.panelControl1.Controls.Add(this.lblPhongBan);
            this.panelControl1.Controls.Add(this.lblMaNV);
            this.panelControl1.Controls.Add(this.lueChucDanh);
            this.panelControl1.Controls.Add(this.luePhongBan);
            this.panelControl1.Controls.Add(this.txtTenNV);
            this.panelControl1.Controls.Add(this.txtMaNV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(875, 100);
            this.panelControl1.TabIndex = 1;
            // 
            // lblChucDanh
            // 
            this.lblChucDanh.Location = new System.Drawing.Point(378, 55);
            this.lblChucDanh.Name = "lblChucDanh";
            this.lblChucDanh.Size = new System.Drawing.Size(53, 13);
            this.lblChucDanh.TabIndex = 7;
            this.lblChucDanh.Text = "Chức Danh";
            // 
            // lblTenNV
            // 
            this.lblTenNV.Location = new System.Drawing.Point(378, 28);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(18, 13);
            this.lblTenNV.TabIndex = 6;
            this.lblTenNV.Text = "Tên";
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.Location = new System.Drawing.Point(87, 55);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(51, 13);
            this.lblPhongBan.TabIndex = 5;
            this.lblPhongBan.Text = "Phòng Ban";
            // 
            // lblMaNV
            // 
            this.lblMaNV.Location = new System.Drawing.Point(87, 29);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(14, 13);
            this.lblMaNV.TabIndex = 4;
            this.lblMaNV.Text = "Mã";
            // 
            // lueChucDanh
            // 
            this.lueChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lueChucDanh.Location = new System.Drawing.Point(447, 51);
            this.lueChucDanh.Name = "lueChucDanh";
            this.lueChucDanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueChucDanh.Properties.DisplayMember = "TenChucVu";
            this.lueChucDanh.Properties.ValueMember = "IdChucVu";
            this.lueChucDanh.Size = new System.Drawing.Size(341, 20);
            this.lueChucDanh.TabIndex = 3;
            // 
            // luePhongBan
            // 
            this.luePhongBan.Location = new System.Drawing.Point(156, 52);
            this.luePhongBan.Name = "luePhongBan";
            this.luePhongBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePhongBan.Properties.DisplayMember = "TenPhongBan";
            this.luePhongBan.Properties.ValueMember = "IdPhongBan";
            this.luePhongBan.Size = new System.Drawing.Size(181, 20);
            this.luePhongBan.TabIndex = 2;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNV.Location = new System.Drawing.Point(447, 25);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(341, 20);
            this.txtTenNV.TabIndex = 1;
            this.txtTenNV.EditValueChanged += new System.EventHandler(this.txtTenNV_EditValueChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(156, 26);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(181, 20);
            this.txtMaNV.TabIndex = 0;
            // 
            // grdNhanVien
            // 
            this.grdNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhanVien.Location = new System.Drawing.Point(0, 125);
            this.grdNhanVien.MainView = this.grvNhanVien;
            this.grdNhanVien.Name = "grdNhanVien";
            this.grdNhanVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSuDung});
            this.grdNhanVien.Size = new System.Drawing.Size(875, 341);
            this.grdNhanVien.TabIndex = 2;
            this.grdNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNhanVien});
            this.grdNhanVien.DoubleClick += new System.EventHandler(this.grcNhanVien_DoubleClick);
            // 
            // grvNhanVien
            // 
            this.grvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colDiaChi,
            this.colDienThoai,
            this.colSuDung,
            this.colEmail,
            this.colGhiChu,
            this.colIdTrungTam,
            this.colPhongBan,
            this.colChucVu});
            this.grvNhanVien.GridControl = this.grdNhanVien;
            this.grvNhanVien.Name = "grvNhanVien";
            this.grvNhanVien.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMaNV
            // 
            this.colMaNV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaNV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaNV.Caption = "Mã Nhân Viên";
            this.colMaNV.FieldName = "MaNhanVien";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.OptionsColumn.AllowEdit = false;
            this.colMaNV.OptionsColumn.FixedWidth = true;
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            // 
            // colTenNV
            // 
            this.colTenNV.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenNV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenNV.Caption = "Tên Nhân Viên";
            this.colTenNV.FieldName = "HoTen";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.OptionsColumn.AllowEdit = false;
            this.colTenNV.Visible = true;
            this.colTenNV.VisibleIndex = 1;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgaySinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgaySinh.Caption = "Ngày Sinh";
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.OptionsColumn.AllowEdit = false;
            this.colNgaySinh.OptionsColumn.FixedWidth = true;
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colGioiTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioiTinh.Caption = "Giới Tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.OptionsColumn.AllowEdit = false;
            this.colGioiTinh.OptionsColumn.FixedWidth = true;
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 3;
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
            this.colDiaChi.VisibleIndex = 4;
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
            this.colDienThoai.VisibleIndex = 5;
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
            this.repSuDung.Appearance.Options.UseTextOptions = true;
            this.repSuDung.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repSuDung.AutoHeight = false;
            this.repSuDung.Name = "repSuDung";
            this.repSuDung.ValueChecked = 1;
            this.repSuDung.ValueUnchecked = 0;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 7;
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
            this.colGhiChu.VisibleIndex = 8;
            // 
            // colIdTrungTam
            // 
            this.colIdTrungTam.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdTrungTam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdTrungTam.Caption = "Id Trung Tâm Hạch Toán";
            this.colIdTrungTam.FieldName = "IdTrungTamHachToan";
            this.colIdTrungTam.Name = "colIdTrungTam";
            this.colIdTrungTam.OptionsColumn.AllowEdit = false;
            this.colIdTrungTam.OptionsColumn.FixedWidth = true;
            this.colIdTrungTam.Visible = true;
            this.colIdTrungTam.VisibleIndex = 9;
            // 
            // colPhongBan
            // 
            this.colPhongBan.AppearanceHeader.Options.UseTextOptions = true;
            this.colPhongBan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhongBan.Caption = "Phòng Ban";
            this.colPhongBan.FieldName = "TenPhongBan";
            this.colPhongBan.Name = "colPhongBan";
            this.colPhongBan.OptionsColumn.AllowEdit = false;
            this.colPhongBan.Visible = true;
            this.colPhongBan.VisibleIndex = 10;
            // 
            // colChucVu
            // 
            this.colChucVu.AppearanceHeader.Options.UseTextOptions = true;
            this.colChucVu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChucVu.Caption = "Chức Vụ";
            this.colChucVu.FieldName = "TenChucVu";
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.OptionsColumn.AllowEdit = false;
            this.colChucVu.OptionsColumn.FixedWidth = true;
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 11;
            // 
            // frmDmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 466);
            this.Controls.Add(this.grdNhanVien);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDmNhanVien";
            this.Text = "Danh mục nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolNhanVien.ResumeLayout(false);
            this.toolNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueChucDanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePhongBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSuDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolNhanVien;
        private System.Windows.Forms.ToolStripButton btnDongBo;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraGrid.GridControl grdNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView grvNhanVien;
        private DevExpress.XtraEditors.LabelControl lblChucDanh;
        private DevExpress.XtraEditors.LabelControl lblTenNV;
        private DevExpress.XtraEditors.LabelControl lblPhongBan;
        private DevExpress.XtraEditors.LabelControl lblMaNV;
        private DevExpress.XtraEditors.LookUpEdit lueChucDanh;
        private DevExpress.XtraEditors.LookUpEdit luePhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colPhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSuDung;
        private System.Windows.Forms.ToolStripButton btnAdd;
    }
}