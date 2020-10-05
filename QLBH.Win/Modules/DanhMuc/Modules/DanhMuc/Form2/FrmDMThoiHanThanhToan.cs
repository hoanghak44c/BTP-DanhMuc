using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.Form2
{
    public partial class FrmDMThoiHanThanhToan : DSThoiHanThanhToanView ,IDSThoiHanThanhToanView 
    {
        public FrmDMThoiHanThanhToan()
        {
            
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public object DataSource
        {
            get { return grdThoiHanThanhToan.DataSource; }
            set { grdThoiHanThanhToan.DataSource = value; }
        }

        public object ItemRowHanle
        {
            get{return  grvThoiHanThanhToan.GetFocusedRow(); }
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
            grdThoiHanThanhToan.RefreshDataSource();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Controller.Add();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Controller.Search();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<DMLoaiThuChiInfor>(grvThoiHanThanhToan, "Danhmucloaithuchi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Controller.Delete();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void grdThoiHanThanhToan_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }
    }
}