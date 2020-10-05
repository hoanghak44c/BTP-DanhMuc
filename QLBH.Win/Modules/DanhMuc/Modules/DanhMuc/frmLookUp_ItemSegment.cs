using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_ItemSegment : frmLookUpBaseItemSegment
    {
        private GridColumn ColMaSanPham;
        private GridColumn ColTenSanPham;

        public frmLookUp_ItemSegment()
        {
            InitializeComponent();
        }

        public frmLookUp_ItemSegment(bool isMultiSelect, int idNhomNguoiDung, int type, int suDung, int chietKhau)
            : base(isMultiSelect, idNhomNguoiDung, type, suDung, chietKhau)
        {
            InitializeComponent();
        }

        public frmLookUp_ItemSegment(bool isMultiSelect, int idNhomNguoiDung, int type, int suDung, int chietKhau, string searchInput)
            : base(isMultiSelect, idNhomNguoiDung, type, suDung, chietKhau, searchInput)
        {
            InitializeComponent();
        }
        
        private void InitializeComponent()
        {
            this.ColMaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColMaSanPham,
            this.ColTenSanPham});
            // 
            // ColMaSanPham
            // 
            this.ColMaSanPham.Caption = "Mã";
            this.ColMaSanPham.FieldName = "Ma";
            this.ColMaSanPham.Name = "ColMaSanPham";
            this.ColMaSanPham.OptionsColumn.AllowEdit = false;
            this.ColMaSanPham.OptionsColumn.ReadOnly = true;
            this.ColMaSanPham.Visible = true;
            this.ColMaSanPham.VisibleIndex = 0;
            this.ColMaSanPham.Width = 102;
            // 
            // ColTenSanPham
            // 
            this.ColTenSanPham.Caption = "Tên";
            this.ColTenSanPham.FieldName = "Ten";
            this.ColTenSanPham.Name = "ColTenSanPham";
            this.ColTenSanPham.OptionsColumn.AllowEdit = false;
            this.ColTenSanPham.OptionsColumn.ReadOnly = true;
            this.ColTenSanPham.Visible = true;
            this.ColTenSanPham.VisibleIndex = 1;
            this.ColTenSanPham.Width = 390;
            // 
            // frmLookUp_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 457);
            this.Name = "frmLookUp_ItemSegment";
            this.Text = "Tìm kiếm nhanh segment sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.grcLookUp)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
