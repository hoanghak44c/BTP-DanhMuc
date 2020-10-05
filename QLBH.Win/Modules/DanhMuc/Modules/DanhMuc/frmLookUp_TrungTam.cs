using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_TrungTam :frmLookUpBaseTrungTam
    {
        private GridColumn colMaTrungTam;
        private GridColumn colTenTrungTam;
        public frmLookUp_TrungTam()
        {
            InitializeComponent();
        }

        public frmLookUp_TrungTam(string searchInput)
            : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_TrungTam(bool isMultiSelect)
            : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_TrungTam(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_TrungTam(bool isMultiSelect, string searchInput, int idNhanVien)
            : base(isMultiSelect, searchInput, idNhanVien)
        {
            InitializeComponent();
        }

        public frmLookUp_TrungTam(bool isMultiSelect, string searchInput, int idNhanVien, int baoHanh)
            : base(isMultiSelect, searchInput, idNhanVien, baoHanh)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.colMaTrungTam = new GridColumn();
            this.colTenTrungTam = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new GridColumn[] {
            this.colMaTrungTam,
            this.colTenTrungTam});
            // 
            // colMaTrungTam
            // 
            this.colMaTrungTam.FieldName = "MaTrungTam";
            this.colMaTrungTam.Caption = "Mã Trung Tâm";
            this.colMaTrungTam.Name = "colMaNhanVien";
            this.colMaTrungTam.OptionsColumn.AllowEdit = false;
            this.colMaTrungTam.OptionsColumn.ReadOnly = true;
            this.colMaTrungTam.Visible = true;
            //this.colMaTrungTam.Width = 120;
            // 
            // colTenTrungTam
            // 
            //this.colTenTrungTam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenTrungTam.FieldName = "TenTrungTam";
            this.colTenTrungTam.Caption = "Tên Trung Tâm";
            this.colTenTrungTam.Name = "colHoTen";
            this.colTenTrungTam.OptionsColumn.AllowEdit = false;
            this.colTenTrungTam.OptionsColumn.ReadOnly = true;
            this.colTenTrungTam.Visible = true;
            // 
            // frmLookUp_TrungTam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_TrungTam";
            this.Text = "Tìm kiếm nhanh trung tâm";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
