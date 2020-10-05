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
    public partial class FrmDmLoaiKhachHang :DSLoaiKhachHangView ,IDSLoaiKhachHangView 
    {
        public FrmDmLoaiKhachHang()
        {

        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public object DataSource
        {
            get { return grdLoaiDT.DataSource; }
            set { grdLoaiDT.DataSource = value; }
        }

        public object ItemRowHanle
        {
            get { return grvLoaiDT.GetFocusedRow(); }
        }

        public string TenLoaiKhachHang
        {
            get { return txtTenDT.Text; }
        }

        public void RefreshDataSource()
        {
            grdLoaiDT.RefreshDataSource();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Controller.Search();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Controller.Delete();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<DmLoaiDoiTuongInfor>(grvLoaiDT, "DanhMucLoaiDoiTuong");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void grdLoaiDT_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }
    }
}