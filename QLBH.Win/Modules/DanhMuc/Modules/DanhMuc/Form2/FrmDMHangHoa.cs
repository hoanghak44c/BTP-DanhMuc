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
    public partial class FrmDMHangHoa : DSHangHoaView ,IDSHangHoaView 
    {
        public FrmDMHangHoa()
        {
            
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public object DataSource
        {
            get { return grdHangHoa.DataSource; }
            set { grdHangHoa.DataSource = value; }

        }

        public object ItemRowHanle
        {
            get { return grvHangHoa.GetFocusedRow(); }
        }

        public string Ma
        {
            get { return txtMaHangHoa.Text; }
        }

        public string Ten
        {
            get { return txtTenHangHoa.Text; }
        }

        public void RefreshDataSource()
        {
            grdHangHoa.RefreshDataSource();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Controller.Search();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Controller.Add();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<DMSanPhamInfo>(grvHangHoa, "Danhmuchanghoa");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Controller.Delete();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void grdHangHoa_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();

        }
    }
}