using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_HangHoa : frmLookUpBaseHangHoa
    {
        private GridColumn ColMaSanPham;
        private GridColumn ColTenSanPham;
        private GridColumn colDonViTinh;
        private GridColumn colTyleVAT;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem tsiTonChiTiet;
        private GridColumn colTonKho;

        public frmLookUp_HangHoa()
        {
            InitializeComponent();
        }

        public frmLookUp_HangHoa(bool isMultiSelect, int idNguoiDung, int suDung, int chietKhau)
            : base(isMultiSelect, idNguoiDung, suDung, chietKhau)
        {
            InitializeComponent();
            colTonKho.Visible = false;
        }

        public frmLookUp_HangHoa(bool isMultiSelect, int idNguoiDung, int suDung, int chietKhau, int idKho)
            : base(isMultiSelect, idNguoiDung, suDung, chietKhau, idKho)
        {
            InitializeComponent();
        }

        public frmLookUp_HangHoa(bool isMultiSelect, int idNguoiDung, int suDung, int chietKhau, int idKho, int tonAll)
            : base(isMultiSelect, idNguoiDung, suDung, chietKhau, idKho, tonAll)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ColMaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTyleVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiTonChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grcLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLookUp
            // 
            this.txtLookUp.Size = new System.Drawing.Size(3036, 21);
            // 
            // grcLookUp
            // 
            this.grcLookUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.grcLookUp.ContextMenuStrip = this.ctxMenu;
            this.grcLookUp.Size = new System.Drawing.Size(709, 393);
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColMaSanPham,
            this.ColTenSanPham,
            this.colDonViTinh,
            this.colTyleVAT,
            this.colTonKho});
            this.grvLookUp.OptionsCustomization.AllowGroup = false;
            this.grvLookUp.OptionsView.ShowGroupPanel = false;
            // 
            // ColMaSanPham
            // 
            this.ColMaSanPham.Caption = "Mã Sản Phẩm";
            this.ColMaSanPham.FieldName = "MaSanPham";
            this.ColMaSanPham.Name = "ColMaSanPham";
            this.ColMaSanPham.OptionsColumn.AllowEdit = false;
            this.ColMaSanPham.OptionsColumn.ReadOnly = true;
            this.ColMaSanPham.Visible = true;
            this.ColMaSanPham.VisibleIndex = 0;
            this.ColMaSanPham.Width = 102;
            // 
            // ColTenSanPham
            // 
            this.ColTenSanPham.Caption = "Tên Sản Phẩm";
            this.ColTenSanPham.FieldName = "TenSanPham";
            this.ColTenSanPham.Name = "ColTenSanPham";
            this.ColTenSanPham.OptionsColumn.AllowEdit = false;
            this.ColTenSanPham.OptionsColumn.ReadOnly = true;
            this.ColTenSanPham.Visible = true;
            this.ColTenSanPham.VisibleIndex = 1;
            this.ColTenSanPham.Width = 390;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Caption = "Đơn vị tính";
            this.colDonViTinh.FieldName = "TenDonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.OptionsColumn.AllowEdit = false;
            this.colDonViTinh.OptionsColumn.ReadOnly = true;
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 2;
            this.colDonViTinh.Width = 96;
            // 
            // colTyleVAT
            // 
            this.colTyleVAT.Caption = "VAT";
            this.colTyleVAT.FieldName = "TyleVAT";
            this.colTyleVAT.Name = "colTyleVAT";
            this.colTyleVAT.OptionsColumn.AllowEdit = false;
            this.colTyleVAT.OptionsColumn.ReadOnly = true;
            // 
            // colTonKho
            // 
            this.colTonKho.Caption = "Tồn kho";
            this.colTonKho.DisplayFormat.FormatString = "N0";
            this.colTonKho.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTonKho.FieldName = "TonKho";
            this.colTonKho.Name = "colTonKho";
            this.colTonKho.OptionsColumn.AllowEdit = false;
            this.colTonKho.OptionsColumn.ReadOnly = true;
            this.colTonKho.Visible = true;
            this.colTonKho.VisibleIndex = 3;
            this.colTonKho.Width = 100;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiTonChiTiet});
            this.ctxMenu.Name = "contextMenuStrip1";
            this.ctxMenu.Size = new System.Drawing.Size(134, 26);
            // 
            // tsiTonChiTiet
            // 
            this.tsiTonChiTiet.Name = "tsiTonChiTiet";
            this.tsiTonChiTiet.Size = new System.Drawing.Size(133, 22);
            this.tsiTonChiTiet.Text = "Tồn chi tiết";
            this.tsiTonChiTiet.Click += new System.EventHandler(this.tsiTonChiTiet_Click);
            // 
            // frmLookUp_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 457);
            this.Name = "frmLookUp_HangHoa";
            this.Text = "Tìm kiếm nhanh sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.grcLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tsiTonChiTiet_Click(object sender, System.EventArgs e)
        {
            if (grvLookUp.FocusedRowHandle < 0) return;
            DMSanPhamBriefInfo sp = (DMSanPhamBriefInfo) grvLookUp.GetRow(grvLookUp.FocusedRowHandle);
            frmLookUp_HangHoa_TonKho frm = new frmLookUp_HangHoa_TonKho(sp);
            frm.ShowDialog();
        }
    }
}
