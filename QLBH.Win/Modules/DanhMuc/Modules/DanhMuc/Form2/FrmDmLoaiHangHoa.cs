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
    public partial class FrmDmLoaiHangHoa : DSLoaiSanPhamView,IDSLoaiSanPhamView 
    {
        public FrmDmLoaiHangHoa()
        {
           
        }

        public void Initialize()
        {
            InitializeComponent();
        }

       

        public object DataSource
        {
            get { return grdSanPham.DataSource; }
            set { grdSanPham.DataSource = value; }
        }

        public object ItemRowHanle
        {
            get { return grvSanPham.GetFocusedRow(); }
        }

        public string TenLoaiSanPham
        {
            get { return txtTenSP.Text; }
        }

        public string MaLoaiSanPham
        {
            get { return txtMaSP.Text; }
        }

        public void RefreshDataSource()
        {
            grdSanPham.RefreshDataSource();
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
            Common.Export2ExcelFromDevGrid<DMLoaiSanPhamInfo>(grvSanPham, "DanhMucLoaiHangHoa");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void grdSanPham_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }
    }
}