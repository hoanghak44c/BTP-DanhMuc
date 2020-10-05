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
    public class frmLookUp_TinhThanh : frmLookUpBaseTinhThanh
    {
        private GridColumn ColMaTinhThanh;
        private GridColumn ColTenTinhThanh;

        public frmLookUp_TinhThanh()
        {
            InitializeComponent();
        }

        public frmLookUp_TinhThanh(string searchInput) : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_TinhThanh(bool isMultiSelect) : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_TinhThanh(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ColMaTinhThanh = new GridColumn();
            this.ColTenTinhThanh = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new [] {
            this.ColMaTinhThanh,
            this.ColTenTinhThanh});
            // 
            // ColIdTinhThanh
            // 
            this.ColMaTinhThanh.FieldName = "MaTinh";
            this.ColMaTinhThanh.Caption = "Mã";
            this.ColMaTinhThanh.Name = "ColMaTinhThanh";
            this.ColMaTinhThanh.OptionsColumn.AllowEdit = false;
            this.ColMaTinhThanh.OptionsColumn.ReadOnly = true;
            this.ColMaTinhThanh.Visible = true;
            // 
            // ColTenTinhThanh
            // 
            this.ColTenTinhThanh.FieldName = "TenTinh";
            this.ColTenTinhThanh.Caption = "Tỉnh/Thành Phố";
            this.ColTenTinhThanh.Name = "ColTenTinhThanh";
            this.ColTenTinhThanh.OptionsColumn.AllowEdit = false;
            this.ColTenTinhThanh.OptionsColumn.ReadOnly = true;
            this.ColTenTinhThanh.Visible = true;
            // 
            // frmLookUp_TinhThanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_TinhThanh";
            this.Text = "Tìm kiếm nhanh tỉnh/thành phố";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
