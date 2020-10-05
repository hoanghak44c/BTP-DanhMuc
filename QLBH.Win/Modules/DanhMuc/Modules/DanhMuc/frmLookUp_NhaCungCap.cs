using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_NhaCungCap : frmLookUpBaseKhachHang
    {
        private bool GiaoVan = false;
        private GridColumn colMaDoiTuong;
        private GridColumn colTenDoiTuong;

        public frmLookUp_NhaCungCap()
        {
            InitializeComponent();
        }

        public frmLookUp_NhaCungCap(string searchInput) : base(searchInput)
        {
            InitializeComponent();
        }
        public frmLookUp_NhaCungCap(string searchInput, bool giaoVan)
            : base(searchInput)
        {
            InitializeComponent();
            this.GiaoVan = giaoVan;
        }
        public frmLookUp_NhaCungCap(bool isMultiSelect)
            : base(isMultiSelect)
        {
            InitializeComponent();
        }
        public frmLookUp_NhaCungCap(bool isMultiSelect, bool giaoVan)
            : base(isMultiSelect)
        {
            InitializeComponent();
            this.GiaoVan = giaoVan;
        }
        public frmLookUp_NhaCungCap(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }
        public frmLookUp_NhaCungCap(bool isMultiSelect, string searchInput, bool giaoVan)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
            this.GiaoVan = giaoVan;
        }
        protected override void OnLoad()
        {
            if (GiaoVan)
                ListInitInfo = DmDoiTuongProvider.GetListDmDoiTuongDTacGVan();
            else
                ListInitInfo = DmDoiTuongProvider.GetListDmDoiTuongNCC();
        }

        private void InitializeComponent()
        {
            this.colMaDoiTuong = new GridColumn();
            this.colTenDoiTuong = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new GridColumn[] {
            this.colMaDoiTuong,
            this.colTenDoiTuong});
            //this.grvLookUp.ShowRowErrors = false;
            // 
            // colMaDoiTuong
            // 
            this.colMaDoiTuong.FieldName = "MaDoiTuong";
            this.colMaDoiTuong.Caption = "Mã Nhà Cung Cấp";
            this.colMaDoiTuong.Name = "colMaDoiTuong";
            this.colMaDoiTuong.OptionsColumn.AllowEdit = false;
            this.colMaDoiTuong.OptionsColumn.ReadOnly = true;
            this.colMaDoiTuong.Visible = true;
            //this.colMaDoiTuong.Width = 120;
            // 
            // colTenDoiTuong
            // 
            //this.colTenDoiTuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenDoiTuong.FieldName = "TenDoiTuong";
            this.colTenDoiTuong.Caption = "Tên nhà cung cấp";
            this.colTenDoiTuong.Name = "colTenDoiTuong";
            this.colTenDoiTuong.OptionsColumn.AllowEdit = false;
            this.colTenDoiTuong.OptionsColumn.ReadOnly = true;
            this.colTenDoiTuong.Visible = true;
            // 
            // frmLookUp_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_NhaCungCap";
            this.Text = "Tìm kiếm nhanh nhà cung cấp";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
