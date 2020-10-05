using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_ThoiHanThanhToan : frmLookUpBaseThoiHanTToan
    {
        private GridColumn colMaTrungTam;
        private GridColumn colTenTrungTam;

        public frmLookUp_ThoiHanThanhToan()
        {
            InitializeComponent();
        }

        public frmLookUp_ThoiHanThanhToan(string searchInput)
            : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_ThoiHanThanhToan(bool isMultiSelect)
            : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_ThoiHanThanhToan(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
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
            this.colMaTrungTam.FieldName = "KyHieu";
            this.colMaTrungTam.Caption = "Ký hiệu";
            this.colMaTrungTam.Name = "colMaNhanVien";
            this.colMaTrungTam.OptionsColumn.AllowEdit = false;
            this.colMaTrungTam.OptionsColumn.ReadOnly = true;
            this.colMaTrungTam.Visible = true;
            //this.colMaTrungTam.Width = 120;
            // 
            // colTenTrungTam
            // 
            //this.colTenTrungTam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenTrungTam.FieldName = "Ten";
            this.colTenTrungTam.Caption = "Thời hạn";
            this.colTenTrungTam.Name = "colHoTen";
            this.colTenTrungTam.OptionsColumn.AllowEdit = false;
            this.colTenTrungTam.OptionsColumn.ReadOnly = true;
            this.colTenTrungTam.Visible = true;
            // 
            // frmLookUp_ThoiHanThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_ThoiHanThanhToan";
            this.Text = "Tìm kiếm nhanh thời hạn thanh toán";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
