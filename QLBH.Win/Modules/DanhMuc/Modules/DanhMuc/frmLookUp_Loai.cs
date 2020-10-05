using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_Loai :frmLookUpBaseSegmentInfo
    {
        private GridColumn colMa;
        private GridColumn colTen;
        private List<SegmentInfo> loaiPrivilegeds;

        public frmLookUp_Loai()
        {
            InitializeComponent();
        }

        public frmLookUp_Loai(string searchInput)
            : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_Loai(string searchInput, List<SegmentInfo> loaiPrivilegeds)
            : base(searchInput)
        {
            InitializeComponent();
            this.loaiPrivilegeds = loaiPrivilegeds;
        }

        public frmLookUp_Loai(bool isMultiSelect)
            : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_Loai(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        protected override void OnLoad()
        {
            if(loaiPrivilegeds != null && loaiPrivilegeds.Count > 0)
            {
                ListInitInfo = loaiPrivilegeds;
                return;
            }

            ListInitInfo =
                DmLoaiDataProvider.Instance.GetListSegmentChildInfor().ConvertAll(
                    delegate(SegmentChildInfo input)
                        {
                            return input as SegmentInfo;
                        });
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
            this.colMa.FieldName = "Ma";
            this.colMa.Caption = "Mã Loại";
            this.colMa.Name = "colMa";
            this.colMa.OptionsColumn.AllowEdit = false;
            this.colMa.OptionsColumn.ReadOnly = true;
            this.colMa.Visible = true;
            //this.colMa.Width = 120;
            // 
            // colTen
            // 
            //this.colTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTen.FieldName = "Ten";
            this.colTen.Caption = "Tên Loại";
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.AllowEdit = false;
            this.colTen.OptionsColumn.ReadOnly = true;
            this.colTen.Visible = true;
            // 
            // frmLookUp_Loai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_Loai";
            this.Text = "Tìm kiếm nhanh Loại";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
