using System.ComponentModel;
using System.Windows.Forms;
using QLBH.Core.Form;
namespace QLBanHang.Modules.DanhMuc
{
    partial class frmDM_ListBaseNew
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_ListBaseNew));
            this.grpThucThi = new System.Windows.Forms.GroupBox();
            this.btnExport = new QLBH.Core.Form.GtidSimpleButton();
            this.btnXoa = new QLBH.Core.Form.GtidSimpleButton();
            this.btnDong = new QLBH.Core.Form.GtidSimpleButton();
            this.btnCapNhat = new QLBH.Core.Form.GtidSimpleButton();
            this.btnThemMoi = new QLBH.Core.Form.GtidSimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.grcBase = new QLBH.Core.Form.GtidXtraGridControl();
            this.dgvDanhSachMatHang = new QLBH.Core.Form.GtidXtraGridView();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThucThi
            // 
            this.grpThucThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThucThi.Controls.Add(this.btnExport);
            this.grpThucThi.Controls.Add(this.btnXoa);
            this.grpThucThi.Controls.Add(this.btnDong);
            this.grpThucThi.Controls.Add(this.btnCapNhat);
            this.grpThucThi.Controls.Add(this.btnThemMoi);
            this.grpThucThi.Location = new System.Drawing.Point(10, 612);
            this.grpThucThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpThucThi.Name = "grpThucThi";
            this.grpThucThi.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpThucThi.Size = new System.Drawing.Size(916, 63);
            this.grpThucThi.TabIndex = 2;
            this.grpThucThi.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(708, 19);
            this.btnExport.Name = "btnExport";
            this.btnExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnExport.Size = new System.Drawing.Size(95, 25);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(209, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShortCutKey = System.Windows.Forms.Keys.F8;
            this.btnXoa.Size = new System.Drawing.Size(95, 25);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(809, 19);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(95, 25);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Thoát (ESC)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(108, 19);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ShortCutKey = System.Windows.Forms.Keys.F2;
            this.btnCapNhat.Size = new System.Drawing.Size(95, 25);
            this.btnCapNhat.TabIndex = 15;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.Location = new System.Drawing.Point(7, 19);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.ShortCutKey = System.Windows.Forms.Keys.F3;
            this.btnThemMoi.Size = new System.Drawing.Size(95, 25);
            this.btnThemMoi.TabIndex = 14;
            this.btnThemMoi.Text = "Thêm mới(F3)";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(911, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.grcBase);
            this.grpThongTin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.ForeColor = System.Drawing.Color.Black;
            this.grpThongTin.Location = new System.Drawing.Point(10, 92);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpThongTin.Size = new System.Drawing.Size(911, 519);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Danh sách mặt hàng";
            // 
            // grcBase
            // 
            this.grcBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grcBase.Location = new System.Drawing.Point(7, 22);
            this.grcBase.MainView = this.dgvDanhSachMatHang;
            this.grcBase.Name = "grcBase";
            this.grcBase.Size = new System.Drawing.Size(897, 490);
            this.grcBase.TabIndex = 1;
            this.grcBase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDanhSachMatHang});
            // 
            // dgvDanhSachMatHang
            // 
            this.dgvDanhSachMatHang.GridControl = this.grcBase;
            this.dgvDanhSachMatHang.Name = "dgvDanhSachMatHang";
            this.dgvDanhSachMatHang.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvDanhSachMatHang.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvDanhSachMatHang.OptionsBehavior.AutoPopulateColumns = false;
            this.dgvDanhSachMatHang.OptionsBehavior.Editable = false;
            this.dgvDanhSachMatHang.OptionsView.ShowAutoFilterRow = true;
            this.dgvDanhSachMatHang.DoubleClick += new System.EventHandler(this.dgvDanhSachMatHang_DoubleClick);
            this.dgvDanhSachMatHang.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.dgvDanhSachMatHang_RowCellClick);
            // 
            // frmDM_ListBaseNew
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpThucThi);
            this.Controls.Add(this.grpThongTin);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDM_ListBaseNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDM_ListBase_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDM_ListBase_MouseUp);
            this.Activated += new System.EventHandler(this.frmDM_ListBaseNew_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDM_ListBaseNew_KeyDown);
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox1;
        public GroupBox grpThucThi;
        public GroupBox grpThongTin;
        public GtidXtraGridView dgvDanhSachMatHang;
        public GtidXtraGridControl grcBase;
        protected GtidSimpleButton btnXoa;
        protected GtidSimpleButton btnDong;
        protected GtidSimpleButton btnCapNhat;
        protected GtidSimpleButton btnThemMoi;
        protected GtidSimpleButton btnExport;
    }
}