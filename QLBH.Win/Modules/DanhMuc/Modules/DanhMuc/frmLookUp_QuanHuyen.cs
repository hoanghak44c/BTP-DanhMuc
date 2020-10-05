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
    public class frmLookUp_QuanHuyen : frmLookUpBaseQuanHuyen
    {
        private GridColumn ColMaQuanHuyen;
        private GridColumn ColTenQuanHuyen;

        public frmLookUp_QuanHuyen()
        {
            InitializeComponent();
        }

        public frmLookUp_QuanHuyen(string searchInput) : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_QuanHuyen(string searchInput, int idTinh)
            : base(searchInput, idTinh)
        {
            InitializeComponent();
        }

        public frmLookUp_QuanHuyen(bool isMultiSelect) : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_QuanHuyen(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_QuanHuyen(bool isMultiSelect, string searchInput, int idTinh)
            : base(isMultiSelect, searchInput, idTinh)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ColMaQuanHuyen = new GridColumn();
            this.ColTenQuanHuyen = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new [] {
            this.ColMaQuanHuyen,
            this.ColTenQuanHuyen});
            // 
            // ColMaSanPham
            // 
            this.ColMaQuanHuyen.FieldName = "MaHuyen";
            this.ColMaQuanHuyen.Caption = "Mã";
            this.ColMaQuanHuyen.Name = "ColMaQuanHuyen";
            this.ColMaQuanHuyen.OptionsColumn.AllowEdit = false;
            this.ColMaQuanHuyen.OptionsColumn.ReadOnly = true;
            this.ColMaQuanHuyen.Visible = true;
            // 
            // ColTenSanPham
            // 
            this.ColTenQuanHuyen.FieldName = "TenHuyen";
            this.ColTenQuanHuyen.Caption = "Quận/Huyện";
            this.ColTenQuanHuyen.Name = "ColTenQuanHuyen";
            this.ColTenQuanHuyen.OptionsColumn.AllowEdit = false;
            this.ColTenQuanHuyen.OptionsColumn.ReadOnly = true;
            this.ColTenQuanHuyen.Visible = true;
            // 
            // frmLookUp_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_QuanHuyen";
            this.Text = "Tìm kiếm nhanh quận/huyện";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
