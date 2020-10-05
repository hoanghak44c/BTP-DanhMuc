using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_KhachHang :frmLookUpBaseKhachHang
    {
        private GridColumn colMaDoiTuong;
        private GridColumn colTenDoiTuong;

        public frmLookUp_KhachHang()
        {
            InitializeComponent();
        }

        public frmLookUp_KhachHang(string searchInput) : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_KhachHang(bool isMultiSelect)
            : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_KhachHang(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_KhachHang(bool isMultiSelect, string searchInput, int idNhomDoiTuong)
            : base(isMultiSelect, searchInput, idNhomDoiTuong)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.colMaDoiTuong = new GridColumn();
            this.colTenDoiTuong = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new GridColumn[] {
            this.colMaDoiTuong,
            this.colTenDoiTuong});
            //this.grvLookUp.ShowRowErrors = false;
            // 
            // colMaDoiTuong
            // 
            this.colMaDoiTuong.FieldName = "MaDoiTuong";
            this.colMaDoiTuong.Caption = "Mã Khách Hàng";
            this.colMaDoiTuong.Name = "colMaDoiTuong";
            this.colMaDoiTuong.OptionsColumn.AllowEdit = false;
            this.colMaDoiTuong.OptionsColumn.ReadOnly = true;
            this.colMaDoiTuong.Visible = true;
            //this.colMaDoiTuong.Width = 120;
            // 
            // colTenDoiTuong
            // 
            //this.colTenDoiTuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenDoiTuong.FieldName = "TenDoiTuong";
            this.colTenDoiTuong.Caption = "Tên đối tượng";
            this.colTenDoiTuong.Name = "colTenDoiTuong";
            this.colTenDoiTuong.OptionsColumn.AllowEdit = false;
            this.colTenDoiTuong.OptionsColumn.ReadOnly = true;
            this.colTenDoiTuong.Visible = true;
            // 
            // frmLookUp_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_KhachHang";
            this.Text = "Tìm kiếm nhanh khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
