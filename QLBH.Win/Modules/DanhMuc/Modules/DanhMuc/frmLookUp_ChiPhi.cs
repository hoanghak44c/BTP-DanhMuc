using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Data;
using QLBH.Core.Form;
using System.Collections;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_ChiPhi : frmLookUpBaseChiPhi
    {
        private GridColumn ColMaSanPham;
        private GridColumn ColTenSanPham;

        public frmLookUp_ChiPhi()
        {
            InitializeComponent();
        }

        public frmLookUp_ChiPhi(string searchInput) : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_ChiPhi(bool isMultiSelect) : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_ChiPhi(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ColMaSanPham = new GridColumn();
            this.ColTenSanPham = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new [] {
            this.ColMaSanPham,
            this.ColTenSanPham});
            // 
            // ColMaSanPham
            // 
            this.ColMaSanPham.FieldName = "Ma";
            this.ColMaSanPham.Caption = "Mã";
            this.ColMaSanPham.Name = "ColMaSanPham";
            this.ColMaSanPham.OptionsColumn.AllowEdit = false;
            this.ColMaSanPham.OptionsColumn.ReadOnly = true;
            this.ColMaSanPham.Visible = true;
            // 
            // ColTenSanPham
            // 
            this.ColTenSanPham.FieldName = "Ten";
            this.ColTenSanPham.Caption = "Tên";
            this.ColTenSanPham.Name = "ColTenSanPham";
            this.ColTenSanPham.OptionsColumn.AllowEdit = false;
            this.ColTenSanPham.OptionsColumn.ReadOnly = true;
            this.ColTenSanPham.Visible = true;
            // 
            // frmLookUp_ChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_ChiPhi";
            this.Text = "Tìm kiếm nhanh chi phí";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
