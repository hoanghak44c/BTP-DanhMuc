using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_KhachHangLe :frmLookUpBaseKhachHang
    {
        private GridColumn colMaDoiTuong;
        private GridColumn colCMT;
        private GridColumn colTenDoiTuong;
        private int idDoiTuongCha = -1;
        public frmLookUp_KhachHangLe()
        {
            InitializeComponent();
        }

        public frmLookUp_KhachHangLe(bool isMultiSelect)
            : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_KhachHangLe(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_KhachHangLe(bool isMultiSelect, string searchInput, int idDoiTuongCha)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
            this.idDoiTuongCha = idDoiTuongCha;
        }

        protected override void OnLoad()
        {
            if (idDoiTuongCha == -1)
            {
                ListInitInfo = DmDoiTuongProvider.GetListDmDoiTuongInfoEx();
            }

            else
            {
                ListInitInfo = DmDoiTuongProvider.GetListDoiTuongKLInfo(idDoiTuongCha);
            }
        }

        private void InitializeComponent()
        {
            this.colMaDoiTuong = new GridColumn();
            this.colCMT = new GridColumn();
            this.colTenDoiTuong = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new GridColumn[] {
            this.colMaDoiTuong,
            this.colCMT,
            this.colTenDoiTuong});
            // 
            // colMaDoiTuong
            // 
            this.colMaDoiTuong.FieldName = "MaRieng";
            this.colMaDoiTuong.Caption = "Mã khách hàng lẻ";
            this.colMaDoiTuong.Name = "colMaDoiTuong";
            this.colMaDoiTuong.OptionsColumn.AllowEdit = false;
            this.colMaDoiTuong.OptionsColumn.ReadOnly = true;
            this.colMaDoiTuong.Visible = true;
            //this.colMaDoiTuong.Width = 120;
            // 
            // colCMT
            // 
            this.colCMT.FieldName = "SoCMND";
            this.colCMT.Caption = "CMTND";
            this.colCMT.Name = "colCMT";
            this.colCMT.OptionsColumn.AllowEdit = false;
            this.colCMT.OptionsColumn.ReadOnly = true;
            this.colCMT.Visible = true;
            //this.colCMT.Width = 120;
            // 
            // colTenDoiTuong
            // 
            //this.colTenDoiTuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenDoiTuong.FieldName = "TenDoiTuong";
            this.colTenDoiTuong.Caption = "Tên khách hàng lẻ";
            this.colTenDoiTuong.Name = "colTenDoiTuong";
            this.colTenDoiTuong.OptionsColumn.AllowEdit = false;
            this.colTenDoiTuong.OptionsColumn.ReadOnly = true;
            this.colTenDoiTuong.Visible = true;
            // 
            // frmLookUp_KhachHangLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_KhachHangLe";
            this.Text = "Tìm kiếm nhanh khách hàng lẻ";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
