using System;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Form2
{
    public partial class frmDmTrungTam : DSTrungTamView, IDSTrungTamView
    {
        public frmDmTrungTam()
        {}
        public void Initialize()
        {
           
            InitializeComponent();
        
        }

        public object DataSource
        {
            get { return grcDMTrungTam.DataSource; }
            set { grcDMTrungTam.DataSource = value; }
        }

        public object ItemRowHanle
        {
            get { return grvDMTrungTam.GetFocusedRow(); }
            
        }

        public string TenTrungTam
        {
            get { return txtTenTrungTam.Text; }
            
        }

        public string MaTrungTam
        {
            get { return txtMaTrungTam.Text; }
            
        }

        public void RefreshDataSource()
        {
           grcDMTrungTam.RefreshDataSource();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<DMTrungTamInfor>(grvDMTrungTam, "DanhMucTrungTam");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Controller.Delete();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Controller.TimKiem();
        }

        private void grcDMTrungTam_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        
    }
}