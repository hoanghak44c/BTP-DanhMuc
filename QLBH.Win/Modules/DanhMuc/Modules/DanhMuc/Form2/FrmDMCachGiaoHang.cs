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
    public partial class FrmDMCachGiaoHang :DSCachGiaoHangView,IDSCachGiaoHangView 
    {
        public FrmDMCachGiaoHang()
        {
            
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public object DataSource
        {
            get { return grdCachGiaoHang.DataSource; }
            set { grdCachGiaoHang.DataSource=value; }
        }

        public object ItemRowHanle
        {
            get {return grvCachGiaoHang.GetFocusedRow();}
        }

        public string Ma
        {
            get { return txtMa.Text; }
        }

        public string Ten
        {
            get { return txtTen.Text; }
        }

        public void RefreshDataSource()
        {
            grdCachGiaoHang.RefreshDataSource();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Controller.Search();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Controller.Add();
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
            Common.Export2ExcelFromDevGrid<DMCachGiaoHangInfo>(grvCachGiaoHang, "DanhMucCachGiaoHang");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void grdCachGiaoHang_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }
    }
}