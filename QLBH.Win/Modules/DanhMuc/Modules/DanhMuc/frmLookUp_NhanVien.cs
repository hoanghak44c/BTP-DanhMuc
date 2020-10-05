using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmLookUp_NhanVien :frmLookUpBaseNhanVien
    {
        private GridColumn colMaNhanVien;
        private GridColumn colHoTen;
        private int idTrungTam = 0;
        public frmLookUp_NhanVien()
        {
            InitializeComponent();
        }

        public frmLookUp_NhanVien(string searchInput) : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_NhanVien(bool isMultiSelect)
            : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_NhanVien(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_NhanVien(bool isMultiSelect, string searchInput, int idKho)
            : base(isMultiSelect, searchInput, idKho)
        {
            InitializeComponent();
        }
        public frmLookUp_NhanVien(int idTrungTam, bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
            this.idTrungTam = idTrungTam;
        }

        //11/03/2015 11:24 AM - hah prototype này không được dùng ở đâu cả nên rào lại
        //public frmLookUp_NhanVien(bool isMultiSelect, string searchInput, int idKho, int userId)
        //    : base(isMultiSelect, searchInput, idKho, userId)
        //{
        //    InitializeComponent();
        //}

        public frmLookUp_NhanVien(bool isMultiSelect, string searchInput, int idTrungTam, int idNhomNguoiDung)
            : base(isMultiSelect, searchInput, idTrungTam, idNhomNguoiDung)
        {
            InitializeComponent();
        }

        public frmLookUp_NhanVien(bool isMultiSelect, string searchInput, int idKho, bool isTruongCa)
            : base(isMultiSelect, searchInput, idKho, isTruongCa)
        {
            InitializeComponent();
        }

        protected override void OnLoad()
        {
            if (idTrungTam == 0)
                base.OnLoad();
            else
                ListInitInfo = DmNhanVienDataProvider.GetListDmNhanVienInforByIdTrungTam(idTrungTam);
        }

        private void InitializeComponent()
        {
            this.colMaNhanVien = new GridColumn();
            this.colHoTen = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new GridColumn[] {
            this.colMaNhanVien,
            this.colHoTen});
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.Caption = "Mã Nhân Viên";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.OptionsColumn.AllowEdit = false;
            this.colMaNhanVien.OptionsColumn.ReadOnly = true;
            this.colMaNhanVien.Visible = true;
            //this.colMaNhanVien.Width = 120;
            // 
            // colHoTen
            // 
            //this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Caption = "Họ Tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsColumn.AllowEdit = false;
            this.colHoTen.OptionsColumn.ReadOnly = true;
            this.colHoTen.Visible = true;
            // 
            // frmLookUp_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_NhanVien";
            this.Text = "Tìm kiếm nhanh nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
