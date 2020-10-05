using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.Form2
{
    public partial class frmDmChucVu : DSChucVuView,IDSChucVuView
    {
        public frmDmChucVu()
        {
          
        }

        public void Initialize()
        {
              InitializeComponent();
        }

        public object DataSource
        {
            get { return grcChucVu.DataSource; }
            set { grcChucVu.DataSource = value; }
            
        }

        public object ItemRowHanle
        {
            get { return grvChucVu.GetFocusedRow(); }
            
        }

        public string MaChucVu
        {
            get { return txtMaCV.Text; }
        }

        public string TenChucVu
        {
            get { return txtTenChucVu.Text; }
        }
        public void RefreshDataSource()
        {
            grcChucVu.RefreshDataSource();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Controller.Search();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            Common.Export2ExcelFromDevGrid<DMChucVuInfor>(grvChucVu, "DanhMucChucVu");
        }

        private void grcChucVu_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }
        

       
    }
}