using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_Kho :frmLookUpBaseKho 
    {
        private GridColumn colMaKho;
        private GridColumn colTenKho;
        //private int idTrungTam = 0;
        public frmLookUp_Kho()
        {
            InitializeComponent();
        }

        public frmLookUp_Kho(string searchInput)
            : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_Kho(bool isMultiSelect)
            : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_Kho(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_Kho(bool isMultiSelect, string searchInput, int idTrungTam, int idNhanVien)
            : base(isMultiSelect, searchInput, idTrungTam, idNhanVien)
        {
            InitializeComponent();
        }
        public frmLookUp_Kho(bool isMultiSelect, string searchInput, int idTrungTam, int idNhanVien, int baoHanh)
            : base(isMultiSelect, searchInput, idTrungTam, idNhanVien, baoHanh)
        {
            InitializeComponent();
        }
        //public frmLookUp_Kho(int idTrungTam, string searchInput)
        //    : base(searchInput)
        //{
        //    this.idTrungTam = idTrungTam;
        //    InitializeComponent();
        //}

        //public frmLookUp_Kho(int idTrungTam, bool isMultiSelect)
        //    : base(isMultiSelect)
        //{
        //    this.idTrungTam = idTrungTam;
        //    InitializeComponent();
        //}

        //protected override void OnLoad()
        //{
        //    if (idTrungTam == 0)
        //        base.OnLoad();
        //    else
        //        ListInitInfo = DMKhoDataProvider.Instance.GetListKhoByTrungTam(idTrungTam);
        //}

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
