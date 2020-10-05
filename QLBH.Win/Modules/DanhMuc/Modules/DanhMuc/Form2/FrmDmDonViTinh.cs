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
    public partial class FrmDmDonViTinh :DSDonViTinhView,IDSDonViTinhView 
    {
        public FrmDmDonViTinh()
        {
            
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public object ItemRowHanle
        {
            get { return grvDonViTinh.GetFocusedRow(); }
           
        }

        public object DataSource
        {
            get { return grdDonViTinh.DataSource; }
            set { grdDonViTinh.DataSource=value; }
        }

        public string MaDonViTinh
        {
            get { return  txtMaDonViTinh.Text; }
        }

        public string TenDonViTinh
        {
            get { return txtTenDonViTinh.Text; }
        }

        public void RefreshDataSource()
        {
            grdDonViTinh.RefreshDataSource();
        }

        

        private void grdDonViTinh_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Controller.Search();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Controller.Delete();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<DMDonViTinhInfor>(grvDonViTinh, "DanhMucDonViTinh");
        }
    }
}