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
    public partial class FrmDMPhuongThucBanHang : DSPhuongThucBanHangView,IDSPhuongThucBanHangView 
    {
        public FrmDMPhuongThucBanHang()
        {
           
        }

        public void Initialize()
        {
             InitializeComponent();
        }

        public object DataSource
        {
            get { return grdPhuongThucBanHang.DataSource; }
            set { grdPhuongThucBanHang.DataSource = value; }
        }

        public object ItemRowHanle
        {
            get { return grvPhuongThucBanHang.GetFocusedRow(); }
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
           grdPhuongThucBanHang.RefreshDataSource();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Controller.Search();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Controller.Add();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Controller.Delete();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<DMPhuongThucBanHangInfo>(grvPhuongThucBanHang, "DanhMucPhuongThucBanHang");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void grdPhuongThucBanHang_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }

    }
}