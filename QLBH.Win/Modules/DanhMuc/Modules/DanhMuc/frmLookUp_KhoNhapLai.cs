using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_KhoNhapLai :frmLookUpBaseKho 
    {
        private GridColumn colMaKho;
        private GridColumn colTenKho;
        //private int idTrungTam = 0;
        public frmLookUp_KhoNhapLai()
        {
            InitializeComponent();
        }

        public frmLookUp_KhoNhapLai(string searchInput)
            : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_KhoNhapLai(bool isMultiSelect)
            : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_KhoNhapLai(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_KhoNhapLai(bool isMultiSelect, string searchInput, int idTrungTam, int idNhanVien)
            : base(isMultiSelect, searchInput, idTrungTam, idNhanVien)
        {
            InitializeComponent();
        }
        public frmLookUp_KhoNhapLai(bool isMultiSelect, string searchInput, int idTrungTam, int idNhanVien, int baoHanh)
            : base(isMultiSelect, searchInput, idTrungTam, idNhanVien, baoHanh)
        {
            InitializeComponent();
        }

        protected override void OnLoad()
        {
            if (idTrungTam == -1)
            {
                if (idNhanVien == -1)
                    ListInitInfo = DMKhoDataProvider.GetListDMKhoInfor();
                else
                    ListInitInfo = DMKhoDataProvider.GetListKhoInforByIdNhanVien(idNhanVien);
            }
            else
            {
                ListInitInfo = DMKhoDataProvider.GetListKhoNhapLaiInfoByTTamNVien(idTrungTam, idNhanVien);
            }
            if (baoHanh == 1)
            {
                if (ListInitInfo == null)
                    ListInitInfo = new List<DMKhoInfo>();
                ListInitInfo.Insert(0, new DMKhoInfo()
                {
                    IdKho = 0,
                    MaKho = "BH.KHACH",
                    TenKho = "Kho khách bảo hành",
                    SuDung = 1,
                    IdTrungTam = idTrungTam
                });
            }
        }

        private void InitializeComponent()
        {
            this.colMaKho = new GridColumn();
            this.colTenKho = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new GridColumn[] {
            this.colMaKho,
            this.colTenKho});
            // 
            // colMaKho
            // 
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.Caption = "Mã Kho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.OptionsColumn.AllowEdit = false;
            this.colMaKho.OptionsColumn.ReadOnly = true;
            this.colMaKho.Visible = true;
            //this.colMaKho.Width = 120;
            // 
            // colTenKho
            // 
            //this.colTenKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenKho.FieldName = "TenKho";
            this.colTenKho.Caption = "Tên Kho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.OptionsColumn.AllowEdit = false;
            this.colTenKho.OptionsColumn.ReadOnly = true;
            this.colTenKho.Visible = true;
            // 
            // frmLookUp_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_Kho";
            this.Text = "Tìm kiếm nhanh kho";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
