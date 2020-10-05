namespace QLBanHang.Modules.DanhMuc
{
    partial class frm_DM_CauHinhSanPham
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
            this.grcDMCauHinhSanPham = new DevExpress.XtraGrid.GridControl();
            this.grvDMCauHinhSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bteSanPham = new DevExpress.XtraEditors.ButtonEdit();
            this.btnAddnew = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.bteNhaCC = new DevExpress.XtraEditors.ButtonEdit();
            this.btnLoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lueTon = new DevExpress.XtraEditors.LookUpEdit();
            this.rdoCoCauHinh = new System.Windows.Forms.RadioButton();
            this.rdoChuaCoCauHinh = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.grbListCauHinh = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grcDMCauHinhSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDMCauHinhSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteNhaCC.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueTon.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grbListCauHinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // grcDMCauHinhSanPham
            // 
            this.grcDMCauHinhSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grcDMCauHinhSanPham.Location = new System.Drawing.Point(9, 31);
            this.grcDMCauHinhSanPham.MainView = this.grvDMCauHinhSanPham;
            this.grcDMCauHinhSanPham.Name = "grcDMCauHinhSanPham";
            this.grcDMCauHinhSanPham.Size = new System.Drawing.Size(768, 290);
            this.grcDMCauHinhSanPham.TabIndex = 0;
            this.grcDMCauHinhSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDMCauHinhSanPham});
            this.grcDMCauHinhSanPham.DoubleClick += new System.EventHandler(this.grcDMCauHinhSanPham_DoubleClick);
            // 
            // grvDMCauHinhSanPham
            // 
            this.grvDMCauHinhSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colHang,
            this.colTrangThai});
            this.grvDMCauHinhSanPham.GridControl = this.grcDMCauHinhSanPham;
            this.grvDMCauHinhSanPham.Name = "grvDMCauHinhSanPham";
            this.grvDMCauHinhSanPham.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMaSP
            // 
            this.colMaSP.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaSP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaSP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMaSP.Caption = "Mã sản phẩm";
            this.colMaSP.FieldName = "MaSanPham";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.OptionsColumn.FixedWidth = true;
            this.colMaSP.OptionsColumn.ReadOnly = true;
            this.colMaSP.Visible = true;
            this.colMaSP.VisibleIndex = 0;
            this.colMaSP.Width = 100;
            // 
            // colTenSP
            // 
            this.colTenSP.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenSP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenSP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTenSP.Caption = "Tên sản phẩm";
            this.colTenSP.FieldName = "TenSanPham";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.OptionsColumn.FixedWidth = true;
            this.colTenSP.OptionsColumn.ReadOnly = true;
            this.colTenSP.Visible = true;
            this.colTenSP.VisibleIndex = 1;
            this.colTenSP.Width = 250;
            // 
            // colHang
            // 
            this.colHang.AppearanceHeader.Options.UseTextOptions = true;
            this.colHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHang.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colHang.Caption = "Hãng";
            this.colHang.FieldName = "Hang";
            this.colHang.Name = "colHang";
            this.colHang.OptionsColumn.FixedWidth = true;
            this.colHang.OptionsColumn.ReadOnly = true;
            this.colHang.Visible = true;
            this.colHang.VisibleIndex = 2;
            this.colHang.Width = 100;
            // 
            // colTrangThai
            // 
            this.colTrangThai.AppearanceHeader.Options.UseTextOptions = true;
            this.colTrangThai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrangThai.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTrangThai.Caption = "Trạng thái";
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.OptionsColumn.FixedWidth = true;
            this.colTrangThai.OptionsColumn.ReadOnly = true;
            this.colTrangThai.Width = 100;
            // 
            // bteSanPham
            // 
            this.bteSanPham.Location = new System.Drawing.Point(607, 20);
            this.bteSanPham.Name = "bteSanPham";
            this.bteSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteSanPham.Size = new System.Drawing.Size(169, 20);
            this.bteSanPham.TabIndex = 1;
            this.bteSanPham.Visible = false;
            this.bteSanPham.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteSanPham_ButtonClick);
            this.bteSanPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteSanPham_KeyDown);
            this.bteSanPham.TextChanged += new System.EventHandler(this.bteSanPham_TextChanged);
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(295, 15);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(87, 23);
            this.btnAddnew.TabIndex = 2;
            this.btnAddnew.Text = "Thêm mới";
            this.btnAddnew.Visible = false;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(7, 15);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(87, 23);
            this.btnChiTiet.TabIndex = 3;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(100, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bteNhaCC
            // 
            this.bteNhaCC.Location = new System.Drawing.Point(607, 46);
            this.bteNhaCC.Name = "bteNhaCC";
            this.bteNhaCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteNhaCC.Size = new System.Drawing.Size(169, 20);
            this.bteNhaCC.TabIndex = 5;
            this.bteNhaCC.Visible = false;
            this.bteNhaCC.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteNhaCC_ButtonClick);
            this.bteNhaCC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteNhaCC_KeyDown);
            this.bteNhaCC.TextChanged += new System.EventHandler(this.bteNhaCC_TextChanged);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(295, 14);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(87, 23);
            this.btnLoc.TabIndex = 13;
            this.btnLoc.Text = "Tìm kiếm";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(295, 44);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 23);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lueTon);
            this.groupBox1.Controls.Add(this.rdoCoCauHinh);
            this.groupBox1.Controls.Add(this.rdoChuaCoCauHinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnLoc);
            this.groupBox1.Controls.Add(this.bteNhaCC);
            this.groupBox1.Controls.Add(this.bteSanPham);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 76);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // lueTon
            // 
            this.lueTon.Location = new System.Drawing.Point(139, 30);
            this.lueTon.Name = "lueTon";
            this.lueTon.Properties.AutoHeight = false;
            this.lueTon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTon.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueTon.Properties.DisplayMember = "Name";
            this.lueTon.Properties.DropDownRows = 3;
            this.lueTon.Properties.NullText = "";
            this.lueTon.Properties.PopupFormMinSize = new System.Drawing.Size(80, 0);
            this.lueTon.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.lueTon.Properties.PopupWidth = 70;
            this.lueTon.Properties.ValueMember = "OID";
            this.lueTon.Size = new System.Drawing.Size(125, 20);
            this.lueTon.TabIndex = 20;
            // 
            // rdoCoCauHinh
            // 
            this.rdoCoCauHinh.AutoSize = true;
            this.rdoCoCauHinh.Location = new System.Drawing.Point(9, 17);
            this.rdoCoCauHinh.Name = "rdoCoCauHinh";
            this.rdoCoCauHinh.Size = new System.Drawing.Size(96, 17);
            this.rdoCoCauHinh.TabIndex = 19;
            this.rdoCoCauHinh.TabStop = true;
            this.rdoCoCauHinh.Text = "Đã có cấu hình";
            this.rdoCoCauHinh.UseVisualStyleBackColor = true;
            // 
            // rdoChuaCoCauHinh
            // 
            this.rdoChuaCoCauHinh.AutoSize = true;
            this.rdoChuaCoCauHinh.Location = new System.Drawing.Point(9, 43);
            this.rdoChuaCoCauHinh.Name = "rdoChuaCoCauHinh";
            this.rdoChuaCoCauHinh.Size = new System.Drawing.Size(108, 17);
            this.rdoChuaCoCauHinh.TabIndex = 18;
            this.rdoChuaCoCauHinh.TabStop = true;
            this.rdoChuaCoCauHinh.Text = "Chưa có cấu hình";
            this.rdoChuaCoCauHinh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nhà cung cấp";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã sản phẩm";
            this.label1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnChiTiet);
            this.groupBox2.Controls.Add(this.btnAddnew);
            this.groupBox2.Location = new System.Drawing.Point(3, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 44);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(690, 15);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbListCauHinh
            // 
            this.grbListCauHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbListCauHinh.Controls.Add(this.grcDMCauHinhSanPham);
            this.grbListCauHinh.Location = new System.Drawing.Point(3, 86);
            this.grbListCauHinh.Name = "grbListCauHinh";
            this.grbListCauHinh.Size = new System.Drawing.Size(784, 330);
            this.grbListCauHinh.TabIndex = 17;
            this.grbListCauHinh.TabStop = false;
            // 
            // frm_DM_CauHinhSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 463);
            this.Controls.Add(this.grbListCauHinh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_DM_CauHinhSanPham";
            this.Text = "Danh mục cấu hình sản phẩm";
            this.Load += new System.EventHandler(this.frm_DM_CauHinhSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcDMCauHinhSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDMCauHinhSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteNhaCC.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueTon.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grbListCauHinh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcDMCauHinhSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDMCauHinhSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraEditors.ButtonEdit bteSanPham;
        private DevExpress.XtraEditors.SimpleButton btnAddnew;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.ButtonEdit bteNhaCC;
        private DevExpress.XtraEditors.SimpleButton btnLoc;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoCoCauHinh;
        private System.Windows.Forms.RadioButton rdoChuaCoCauHinh;
        private System.Windows.Forms.GroupBox grbListCauHinh;
        private DevExpress.XtraEditors.LookUpEdit lueTon;
    }
}