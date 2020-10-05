namespace QLBanHang.Modules.DanhMuc
{
    partial class frm_ChiTiet_CauHinhSanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pteLogo = new DevExpress.XtraEditors.PictureEdit();
            this.txtNhaCC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnBrowser = new DevExpress.XtraEditors.SimpleButton();
            this.txtLogo = new DevExpress.XtraEditors.TextEdit();
            this.bteSanPham = new DevExpress.XtraEditors.ButtonEdit();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.grvChiTietCauHinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenCauHinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcChiTietCauHinh = new DevExpress.XtraGrid.GridControl();
            this.btnSaoChep = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pteLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTietCauHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcChiTietCauHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pteLogo);
            this.groupBox1.Controls.Add(this.txtNhaCC);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.btnBrowser);
            this.groupBox1.Controls.Add(this.txtLogo);
            this.groupBox1.Controls.Add(this.bteSanPham);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pteLogo
            // 
            this.pteLogo.Location = new System.Drawing.Point(90, 98);
            this.pteLogo.Name = "pteLogo";
            this.pteLogo.Size = new System.Drawing.Size(200, 95);
            this.pteLogo.TabIndex = 11;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.Location = new System.Drawing.Point(90, 46);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(339, 20);
            this.txtNhaCC.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Đường dẫn logo";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(58, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Hãng";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Sản phẩm";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(354, 69);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 4;
            this.btnBrowser.Text = "Browser...";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtLogo
            // 
            this.txtLogo.Location = new System.Drawing.Point(90, 72);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(258, 20);
            this.txtLogo.TabIndex = 2;
            // 
            // bteSanPham
            // 
            this.bteSanPham.Location = new System.Drawing.Point(90, 20);
            this.bteSanPham.Name = "bteSanPham";
            this.bteSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteSanPham.Size = new System.Drawing.Size(339, 20);
            this.bteSanPham.TabIndex = 0;
            this.bteSanPham.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteSanPham_ButtonClick);
            this.bteSanPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteSanPham_KeyDown);
            this.bteSanPham.TextChanged += new System.EventHandler(this.bteSanPham_TextChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(3, 453);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(84, 453);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grvChiTietCauHinh
            // 
            this.grvChiTietCauHinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenCauHinh,
            this.colGiaTri,
            this.colSoTT});
            this.grvChiTietCauHinh.GridControl = this.grcChiTietCauHinh;
            this.grvChiTietCauHinh.Name = "grvChiTietCauHinh";
            this.grvChiTietCauHinh.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvChiTietCauHinh.OptionsNavigation.AutoFocusNewRow = true;
            this.grvChiTietCauHinh.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvChiTietCauHinh.OptionsView.ShowAutoFilterRow = true;
            // 
            // colTenCauHinh
            // 
            this.colTenCauHinh.Caption = "Tên cấu hình";
            this.colTenCauHinh.FieldName = "TenCauHinh";
            this.colTenCauHinh.Name = "colTenCauHinh";
            this.colTenCauHinh.OptionsColumn.FixedWidth = true;
            this.colTenCauHinh.Visible = true;
            this.colTenCauHinh.VisibleIndex = 0;
            this.colTenCauHinh.Width = 150;
            // 
            // colGiaTri
            // 
            this.colGiaTri.Caption = "Giá trị";
            this.colGiaTri.FieldName = "GiaTri";
            this.colGiaTri.Name = "colGiaTri";
            this.colGiaTri.OptionsColumn.FixedWidth = true;
            this.colGiaTri.Visible = true;
            this.colGiaTri.VisibleIndex = 1;
            this.colGiaTri.Width = 250;
            // 
            // colSoTT
            // 
            this.colSoTT.Caption = "Số thứ tự";
            this.colSoTT.FieldName = "SoTT";
            this.colSoTT.Name = "colSoTT";
            this.colSoTT.OptionsColumn.FixedWidth = true;
            this.colSoTT.Visible = true;
            this.colSoTT.VisibleIndex = 2;
            // 
            // grcChiTietCauHinh
            // 
            this.grcChiTietCauHinh.Location = new System.Drawing.Point(3, 209);
            this.grcChiTietCauHinh.MainView = this.grvChiTietCauHinh;
            this.grcChiTietCauHinh.Name = "grcChiTietCauHinh";
            this.grcChiTietCauHinh.Size = new System.Drawing.Size(502, 238);
            this.grcChiTietCauHinh.TabIndex = 1;
            this.grcChiTietCauHinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvChiTietCauHinh});
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaoChep.Location = new System.Drawing.Point(340, 453);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(156, 23);
            this.btnSaoChep.TabIndex = 7;
            this.btnSaoChep.Text = "Sao chép cấu hình này cho";
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // frm_ChiTiet_CauHinhSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 479);
            this.Controls.Add(this.btnSaoChep);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.grcChiTietCauHinh);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ChiTiet_CauHinhSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết cấu hình sản phẩm";
            this.Load += new System.EventHandler(this.frm_ChiTiet_CauHinhSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pteLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTietCauHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcChiTietCauHinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtLogo;
        private DevExpress.XtraEditors.ButtonEdit bteSanPham;
        private DevExpress.XtraEditors.SimpleButton btnBrowser;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.TextEdit txtNhaCC;
        private DevExpress.XtraGrid.Views.Grid.GridView grvChiTietCauHinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCauHinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaTri;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTT;
        private DevExpress.XtraGrid.GridControl grcChiTietCauHinh;
        private DevExpress.XtraEditors.PictureEdit pteLogo;
        private DevExpress.XtraEditors.SimpleButton btnSaoChep;
    }
}