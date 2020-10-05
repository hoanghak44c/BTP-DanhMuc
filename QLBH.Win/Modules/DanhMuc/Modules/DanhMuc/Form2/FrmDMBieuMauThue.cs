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
    public partial class FrmDMBieuMauThue : DSBieuMauThueView,IDSBieuMauThueView 
    {
        public FrmDMBieuMauThue()
        {
        }

        public void Initialize()
        {

            InitializeComponent();
        }

        public object DataSource
        {
            get { return grdDMBieuMauThue.DataSource; }
            set { grdDMBieuMauThue.DataSource = value; }
        }

        public object ItemRowHanle
        {

            get{ return grvDMBieuMauThue.GetFocusedRow(); }
        }

        public string MaTaxCode
        {
            get { return txtMaTaxCode.Text; }
        }

        public string TenTaxCode
        {
            get { return txtTenTaxCode.Text; }
        }

        public void RefreshDataSource()
        {
            grdDMBieuMauThue.RefreshDataSource();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Controller.Search();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<DMTaxCodeInfor>(grvDMBieuMauThue, "Danhmucbieumauthue");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           Controller.Delete();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void grdDMBieuMauThue_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Controller.Add();
        }
    }
}