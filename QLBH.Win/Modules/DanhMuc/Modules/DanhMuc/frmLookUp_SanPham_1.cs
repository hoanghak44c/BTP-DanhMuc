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
    public class frmLookUp_SanPham_1 : frmLookUpBaseSanPham_1
    {
        private GridColumn ColMaSanPham;
        private GridColumn ColTenSanPham;
        private int idKho, idTrungTam;
        private bool exists, isTonAo;

        public frmLookUp_SanPham_1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idKho">Id Kho</param>
        /// <param name="idTrungTam">Id Trung Tam</param>
        /// <param name="exists">Chỉ tìm các sản phẩm còn tồn</param>
        /// <param name="isTonAo">Tìm theo tồn ảo</param>
        public frmLookUp_SanPham_1(int idKho, int idTrungTam, bool exists, bool isTonAo)
        {
            this.idKho = idKho;
            this.idTrungTam = idTrungTam;
            this.exists = exists;
            this.isTonAo = isTonAo;
            InitializeComponent();
        }

        public frmLookUp_SanPham_1(string searchInput) : base(searchInput)
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idKho">Id Kho</param>
        /// <param name="idTrungTam">Id Trung Tam</param>
        /// <param name="exists">Chỉ tìm các sản phẩm còn tồn</param>
        /// <param name="isTonAo">Tìm theo tồn ảo</param>
        /// <param name="searchInput"></param>
        public frmLookUp_SanPham_1(int idKho, int idTrungTam, bool exists, bool isTonAo, string searchInput)
            : base(searchInput)
        {
            this.idKho = idKho;
            this.idTrungTam = idTrungTam;
            this.exists = exists;
            this.isTonAo = isTonAo;
            InitializeComponent();
        }

        public frmLookUp_SanPham_1(bool isMultiSelect) : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_SanPham_1(int idKho, int idTrungTam, bool exists, bool isTonAo, bool isMultiSelect)
            : base(isMultiSelect)
        {
            this.idKho = idKho;
            this.idTrungTam = idTrungTam;
            this.exists = exists;
            this.isTonAo = isTonAo;
            InitializeComponent();
        }

        public frmLookUp_SanPham_1(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_SanPham_1(int idKho, int idTrungTam, bool exists, bool isTonAo, bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            this.idKho = idKho;
            this.idTrungTam = idTrungTam;
            this.exists = exists;
            this.isTonAo = isTonAo;
            InitializeComponent();
        }

        protected override void OnLoad()
        {
            if(idKho == 0 && idTrungTam == 0 && !exists)
                base.OnLoad();
            else
            {
                ListInitInfo = DmSanPhamProvider.GetListDmSanPhamInfo(idKho, idTrungTam, exists, isTonAo);
            }
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
