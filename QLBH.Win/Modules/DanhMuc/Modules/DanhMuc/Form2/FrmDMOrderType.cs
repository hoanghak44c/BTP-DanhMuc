using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.Form2
{
    public partial class FrmDMOrderType :DSOrderTypeView,IDSOrderTypeView 
    {
        public FrmDMOrderType()
        {
        }

        public void Initialize()
        {

            InitializeComponent();
        }

        public object DataSource
        {
            get { return grdDMOrderType.DataSource; }
            set { grdDMOrderType.DataSource = value; }
        }

        public object ItemRowHanle
        {
            get { return grvDMOrderType.GetFocusedRow(); }
        }

        public string MaOrderType
        {
            get { return txtMaOrderType.Text; }
        }

        public string TenOrderType

        {
            get { return txtTenOrderType.Text; }
        }

        public void RefreshDataSource()
        {
            grdDMOrderType.RefreshDataSource();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Controller.Search();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Controller.Add();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<DMOrderTypeInfor>(grvDMOrderType, "DanhmucOderType");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Controller.Delete();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void grdDMOrderType_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }
    }

    
}