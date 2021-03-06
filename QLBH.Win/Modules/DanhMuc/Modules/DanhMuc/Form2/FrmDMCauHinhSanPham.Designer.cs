namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class FrmDMCauHinhSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDMCauHinhSanPham));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnChiTiet = new System.Windows.Forms.ToolStripButton();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.panelcauhinhsp = new DevExpress.XtraEditors.PanelControl();
            this.lueTon = new DevExpress.XtraEditors.LookUpEdit();
            this.radKhongCauHinh = new System.Windows.Forms.RadioButton();
            this.radCoCauHinh = new System.Windows.Forms.RadioButton();
            this.grdDMCauHinhSanPham = new DevExpress.XtraGrid.GridControl();
            this.grvDMCauHinhSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelcauhinhsp)).BeginInit();
            this.panelcauhinhsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDMCauHinhSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDMCauHinhSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChiTiet,
            this.btnTimKiem,
            this.btnAdd,
            this.btnExport,
            this.btnDelete,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(870, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Image")));
            this.btnChiTiet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(68, 22);
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
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
            // panelcauhinhsp
            // 
            this.panelcauhinhsp.Controls.Add(this.lueTon);
            this.panelcauhinhsp.Controls.Add(this.radKhongCauHinh);
            this.panelcauhinhsp.Controls.Add(this.radCoCauHinh);
            this.panelcauhinhsp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcauhinhsp.Location = new System.Drawing.Point(0, 25);
            this.panelcauhinhsp.Name = "panelcauhinhsp";
            this.panelcauhinhsp.Size = new System.Drawing.Size(870, 100);
            this.panelcauhinhsp.TabIndex = 1;
            // 
            // lueTon
            // 
            this.lueTon.Location = new System.Drawing.Point(206, 31);
            this.lueTon.Name = "lueTon";
            this.lueTon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTon.Properties.DisplayMember = "Name";
            this.lueTon.Properties.ValueMember = "ID";
            this.lueTon.Size = new System.Drawing.Size(156, 20);
            this.lueTon.TabIndex = 2;
            // 
            // radKhongCauHinh
            // 
            this.radKhongCauHinh.AutoSize = true;
            this.radKhongCauHinh.Location = new System.Drawing.Point(51, 45);
            this.radKhongCauHinh.Name = "radKhongCauHinh";
            this.radKhongCauHinh.Size = new System.Drawing.Size(117, 17);
            this.radKhongCauHinh.TabIndex = 1;
            this.radKhongCauHinh.TabStop = true;
            this.radKhongCauHinh.Text = "Không Có Cấu Hình";
            this.radKhongCauHinh.UseVisualStyleBackColor = true;
            // 
            // radCoCauHinh
            // 
            this.radCoCauHinh.AutoSize = true;
            this.radCoCauHinh.Location = new System.Drawing.Point(51, 22);
            this.radCoCauHinh.Name = "radCoCauHinh";
            this.radCoCauHinh.Size = new System.Drawing.Size(84, 17);
            this.radCoCauHinh.TabIndex = 0;
            this.radCoCauHinh.TabStop = true;
            this.radCoCauHinh.Text = "Có Cấu Hình";
            this.radCoCauHinh.UseVisualStyleBackColor = true;
            // 
            // grdDMCauHinhSanPham
            // 
            this.grdDMCauHinhSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDMCauHinhSanPham.Location = new System.Drawing.Point(0, 125);
            this.grdDMCauHinhSanPham.MainView = this.grvDMCauHinhSanPham;
            this.grdDMCauHinhSanPham.Name = "grdDMCauHinhSanPham";
            this.grdDMCauHinhSanPham.Size = new System.Drawing.Size(870, 287);
            this.grdDMCauHinhSanPham.TabIndex = 2;
            this.grdDMCauHinhSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDMCauHinhSanPham});
            // 
            // grvDMCauHinhSanPham
            // 
            this.grvDMCauHinhSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grvDMCauHinhSanPham.GridControl = this.grdDMCauHinhSanPham;
            this.grvDMCauHinhSanPham.Name = "grvDMCauHinhSanPham";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Mã Sản Phẩm";
            this.gridColumn1.FieldName = "MaSanPham";
            this.gridColumn1.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Tên Sản Phẩm";
            this.gridColumn2.FieldName = "TenSanPham";
            this.gridColumn2.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Hãng";
            this.gridColumn3.FieldName = "Hang";
            this.gridColumn3.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // FrmDMCauHinhSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 412);
            this.Controls.Add(this.grdDMCauHinhSanPham);
            this.Controls.Add(this.panelcauhinhsp);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDMCauHinhSanPham";
            this.Text = "Danh mục cấu hình sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelcauhinhsp)).EndInit();
            this.panelcauhinhsp.ResumeLayout(false);
            this.panelcauhinhsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDMCauHinhSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDMCauHinhSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnChiTiet;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private DevExpress.XtraEditors.PanelControl panelcauhinhsp;
        private DevExpress.XtraGrid.GridControl grdDMCauHinhSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDMCauHinhSanPham;
        private System.Windows.Forms.RadioButton radKhongCauHinh;
        private System.Windows.Forms.RadioButton radCoCauHinh;
        private System.Windows.Forms.ToolStripButton btnExport;
        private DevExpress.XtraEditors.LookUpEdit lueTon;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}