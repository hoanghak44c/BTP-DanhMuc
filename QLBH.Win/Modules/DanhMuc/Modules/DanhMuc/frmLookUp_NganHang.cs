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
    public class frmLookUp_NganHang : frmLookUpBaseNganHang
    {
        private GridColumn ColIdNganHang;
        private GridColumn ColMaNganHang;
        private GridColumn ColTenNganHang;

        public frmLookUp_NganHang()
        {
            InitializeComponent();
        }

        public frmLookUp_NganHang(string searchInput) : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_NganHang(bool isMultiSelect) : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_NganHang(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ColIdNganHang = new GridColumn();
            this.ColMaNganHang = new GridColumn();
            this.ColTenNganHang = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new [] {
            this.ColIdNganHang,
            this.ColMaNganHang,
            this.ColTenNganHang});
            // 
            // ColIdNganHang
            // 
            this.ColIdNganHang.FieldName = "IdNganHang";
            this.ColIdNganHang.Caption = "IdNganHang";
            this.ColIdNganHang.Name = "ColIdNganHang";
            this.ColIdNganHang.OptionsColumn.AllowEdit = false;
            this.ColIdNganHang.OptionsColumn.ReadOnly = true;
            this.ColIdNganHang.Visible = false;
            // 
            // ColMaNganHang
            // 
            this.ColMaNganHang.FieldName = "MaNganHang";
            this.ColMaNganHang.Caption = "Mã ngân hàng";
            this.ColMaNganHang.Name = "ColMaNganHang";
            this.ColMaNganHang.OptionsColumn.AllowEdit = false;
            this.ColMaNganHang.OptionsColumn.ReadOnly = true;
            this.ColMaNganHang.Visible = true;
            // 
            // ColTenNganHang
            // 
            this.ColTenNganHang.FieldName = "TenNganHang";
            this.ColTenNganHang.Caption = "Tên ngân hàng";
            this.ColTenNganHang.Name = "ColTenNganHang";
            this.ColTenNganHang.OptionsColumn.AllowEdit = false;
            this.ColTenNganHang.OptionsColumn.ReadOnly = true;
            this.ColTenNganHang.Visible = true;            
            // 
            // frmLookUp_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_NganHang";
            this.Text = "Tìm kiếm nhanh ngân hàng";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
