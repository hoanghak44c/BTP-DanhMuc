using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_NhomNguoiDung : frmLookUpBaseNhomNguoiDung
    {
        private GridColumn colMa;
        private GridColumn colTen;

        public frmLookUp_NhomNguoiDung()
        {
            InitializeComponent();
        }

        public frmLookUp_NhomNguoiDung(string searchInput)
            : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_NhomNguoiDung(bool isMultiSelect)
            : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_NhomNguoiDung(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        protected override void OnLoad()
        {
            ListInitInfo =
                DMNhomNguoiDungDataProvider.GetListNhomInfo();
        }

        private void InitializeComponent()
        {
            this.colMa = new GridColumn();
            this.colTen = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new GridColumn[] {
            this.colMa,
            this.colTen});
            // 
            // colMa
            // 
            this.colMa.FieldName = "MaNhom";
            this.colMa.Caption = "Mã Nhóm";
            this.colMa.Name = "colMa";
            this.colMa.OptionsColumn.AllowEdit = false;
            this.colMa.OptionsColumn.ReadOnly = true;
            this.colMa.Visible = true;
            //this.colMa.Width = 120;
            // 
            // colTen
            // 
            //this.colTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTen.FieldName = "TenNhom";
            this.colTen.Caption = "Tên Nhóm";
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.AllowEdit = false;
            this.colTen.OptionsColumn.ReadOnly = true;
            this.colTen.Visible = true;
            // 
            // frmLookUp_Nhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_Nhóm";
            this.Text = "Tìm kiếm nhanh Nhóm Người Dùng";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
