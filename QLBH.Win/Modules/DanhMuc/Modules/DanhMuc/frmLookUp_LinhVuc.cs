using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_LinhVuc :frmLookUpBaseSegmentInfo
    {
        private GridColumn colMa;
        private GridColumn colTen;
        private int idTrungTam;
        private List<SegmentInfo> linhVucPrivilegeds;

        public frmLookUp_LinhVuc()
        {
            InitializeComponent();
        }

        public frmLookUp_LinhVuc(string searchInput)
            : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_LinhVuc(string searchInput, List<SegmentInfo> linhVucPrivilegeds)
            : base(searchInput)
        {
            InitializeComponent();
            this.linhVucPrivilegeds = linhVucPrivilegeds;
        }

        public frmLookUp_LinhVuc(bool isMultiSelect)
            : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_LinhVuc(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        protected override void OnLoad()
        {
            if (linhVucPrivilegeds != null && linhVucPrivilegeds.Count > 0)
            {
                ListInitInfo = linhVucPrivilegeds;
                return;
            }

            ListInitInfo = DmLinhVucDataProvider.Instance.GetListSegmentInfor();
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
            this.colMa.Caption = "Mã Lĩnh Vực";
            this.colMa.Name = "colMa";
            this.colMa.OptionsColumn.AllowEdit = false;
            this.colMa.OptionsColumn.ReadOnly = true;
            this.colMa.Visible = true;
            //this.colMa.Width = 120;
            // 
            // colTen
            // 
            //this.colTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTen.FieldName= "Ten";
            this.colTen.Caption = "Tên Lĩnh Vực";
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.AllowEdit = false;
            this.colTen.OptionsColumn.ReadOnly = true;
            this.colTen.Visible = true;
            // 
            // frmLookUp_LinhVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_LinhVuc";
            this.Text = "Tìm kiếm nhanh lĩnh vực";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
