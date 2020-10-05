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
    public class frmLookUp_SanPham_CauHinh : frmLookUpBaseSanPham
    {
        private GridColumn ColMaSanPham;
        private GridColumn ColTenSanPham;
        private int idKho, idTrungTam;
        private bool exists, isTonAo;

        public frmLookUp_SanPham_CauHinh()
        {
            InitializeComponent();
        }
        public frmLookUp_SanPham_CauHinh(string searchInput) : base(searchInput)
        {
            InitializeComponent();
        }
        
        public frmLookUp_SanPham_CauHinh(bool isMultiSelect) : base(isMultiSelect)
        {
            InitializeComponent();
        }
        public frmLookUp_SanPham_CauHinh(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }
        protected override void OnLoad()
        {
            ListInitInfo = DmSanPhamProvider.GetListDmSanPhamCauHinhInfo();
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
            this.ColMaSanPham.FieldName = "MaSanPham";
            this.ColMaSanPham.Caption = "Mã Sản Phẩm";
            this.ColMaSanPham.Name = "ColMaSanPham";
            this.ColMaSanPham.OptionsColumn.AllowEdit = false;
            this.ColMaSanPham.OptionsColumn.ReadOnly = true;
            this.ColMaSanPham.Visible = true;
            //this.ColMaSanPham.Width = 120;
            // 
            // ColTenSanPham
            // 
            this.ColTenSanPham.FieldName = "TenSanPham";
            this.ColTenSanPham.Caption = "Tên Sản Phẩm";
            this.ColTenSanPham.Name = "ColTenSanPham";
            this.ColTenSanPham.OptionsColumn.AllowEdit = false;
            this.ColTenSanPham.OptionsColumn.ReadOnly = true;
            this.ColTenSanPham.Visible = true;
            // 
            // frmLookUp_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_SanPham";
            this.Text = "Tìm kiếm nhanh sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
