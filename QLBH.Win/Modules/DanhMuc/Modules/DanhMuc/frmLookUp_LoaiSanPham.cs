using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_LoaiSanPham: frmLookUpBaseLoaiSanPham
    {
        private GridColumn colMaLoaiSP;
        private GridColumn colTenLoaiSP;
            public frmLookUp_LoaiSanPham()
        {
            InitializeComponent();
        }

        public frmLookUp_LoaiSanPham(string searchInput) : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_LoaiSanPham(bool isMultiSelect) : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_LoaiSanPham(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.colMaLoaiSP = new GridColumn();
            this.colTenLoaiSP = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLookUp
            // 
            this.txtLookUp.Size = new System.Drawing.Size(684, 21);
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new GridColumn[] {
            this.colMaLoaiSP,
            this.colTenLoaiSP});
            // 
            // colMaLoaiSP
            // 
            this.colMaLoaiSP.FieldName = "MaLoaiSP";
            this.colMaLoaiSP.Caption = "Mã loại sản phẩm";
            this.colMaLoaiSP.Name = "colMaLoaiSP";
            this.colMaLoaiSP.OptionsColumn.AllowEdit = false;
            this.colMaLoaiSP.OptionsColumn.ReadOnly = true;
            this.colMaLoaiSP.Visible = true;
            //this.colMaLoaiSP.Width = 120;
            // 
            // colTenLoaiSP
            // 
            //this.colTenLoaiSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLoaiSP.FieldName = "TenLoaiSP";
            this.colTenLoaiSP.Caption = "Tên loại sản phẩm";
            this.colTenLoaiSP.Name = "colTenLoaiSP";
            this.colTenLoaiSP.OptionsColumn.AllowEdit = false;
            this.colTenLoaiSP.OptionsColumn.ReadOnly = true;
            this.colTenLoaiSP.Visible = true;
            // 
            // frmLookUp_LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_LoaiSanPham";
            this.Text = "Tìm kiếm nhanh loại sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
