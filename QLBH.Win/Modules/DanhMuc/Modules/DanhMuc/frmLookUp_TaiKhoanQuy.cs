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
    public class frmLookUp_TaiKhoanQuy : frmLookUpBaseTaiKhoanQuy
    {
        private GridColumn ColTaiKhoanQuy;
        private GridColumn ColNganHang;

        public frmLookUp_TaiKhoanQuy()
        {
            InitializeComponent();
        }

        public frmLookUp_TaiKhoanQuy(string searchInput) : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_TaiKhoanQuy(string searchInput, int idTrungTam)
            : base(searchInput, idTrungTam)
        {
            InitializeComponent();
        }

        public frmLookUp_TaiKhoanQuy(bool isMultiSelect) : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_TaiKhoanQuy(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_TaiKhoanQuy(bool isMultiSelect, string searchInput, int idTrungTam)
            : base(isMultiSelect, searchInput, idTrungTam)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ColTaiKhoanQuy = new GridColumn();
            this.ColNganHang = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new [] {
            this.ColTaiKhoanQuy,
            this.ColNganHang});
            // 
            // ColTaiKhoanQuy
            // 
            this.ColTaiKhoanQuy.FieldName = "TaiKhoanQuy";
            this.ColTaiKhoanQuy.Caption = "Tài khoản quỹ";
            this.ColTaiKhoanQuy.Name = "ColTaiKhoanQuy";
            this.ColTaiKhoanQuy.OptionsColumn.AllowEdit = false;
            this.ColTaiKhoanQuy.OptionsColumn.ReadOnly = true;
            this.ColTaiKhoanQuy.Visible = true;
            // 
            // ColTenSanPham
            // 
            this.ColNganHang.FieldName = "NganHang";
            this.ColNganHang.Caption = "Ngân hàng";
            this.ColNganHang.Name = "ColNganHang";
            this.ColNganHang.OptionsColumn.AllowEdit = false;
            this.ColNganHang.OptionsColumn.ReadOnly = true;
            this.ColNganHang.Visible = true;
            // 
            // frmLookUp_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_TaiKhoanQuy";
            this.Text = "Tìm kiếm nhanh tài khoản quỹ";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
