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
    public partial class FrmDmDoiTuongKhachHang : DSDoiTuongView,IDSDoiTuongView 
    {
        public FrmDmDoiTuongKhachHang()
        {
          
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public object ItemRowHanle
        {
            get { return grvDoiTuong.GetFocusedRow(); }
        }

        public object DataSource
        {
            get { return grdDoiTuong.DataSource; }
            set { grdDoiTuong.DataSource = value; }
        }

        public string MaDoiTuong
        {
            get { return txtMaDoiTuong.Text; }
        }

        public string TenDoiTuong
        {
            get { return txtTenDoiTuong.Text; }
            
        }

        public void RefreshDataSource()
        {
            grdDoiTuong.RefreshDataSource();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
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
            Common.Export2ExcelFromDevGrid<DMDoiTuongInfo>(grvDoiTuong, "DanhSachDoiTuongKhachHang");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void grdDoiTuong_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }
    }
}