using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_OrderType :frmLookUpBaseOrderType
    {
        private GridColumn colOrderType;
        private GridColumn colLineType;
        private GridColumn colName;
        
        public frmLookUp_OrderType()
        {
            InitializeComponent();
        }

        public frmLookUp_OrderType(string searchInput)
            : base(searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_OrderType(bool isMultiSelect)
            : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_OrderType(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.colOrderType = new GridColumn();
            this.colLineType = new GridColumn();
            this.colName = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new GridColumn[] {
            this.colOrderType,
            this.colLineType,
            this.colName});
            // 
            // colOrderType
            // 
            this.colOrderType.FieldName = "OrderType";
            this.colOrderType.Caption = "Order Type";
            this.colOrderType.Name = "colOrderType";
            this.colOrderType.OptionsColumn.AllowEdit = false;
            this.colOrderType.OptionsColumn.ReadOnly = true;
            this.colOrderType.Visible = true;
            //this.colOrderType.Width = 120;
            // 
            // colLineType
            // 
            //this.colLineType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLineType.FieldName = "LineType";
            this.colLineType.Caption = "Line Type";
            this.colLineType.Name = "colLineType";
            this.colLineType.OptionsColumn.AllowEdit = false;
            this.colLineType.OptionsColumn.ReadOnly = true;
            this.colLineType.Visible = true;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Caption = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            // 
            // frmLookUp_OrderType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_OrderType";
            this.Text = "Tìm kiếm nhanh Order Type";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
