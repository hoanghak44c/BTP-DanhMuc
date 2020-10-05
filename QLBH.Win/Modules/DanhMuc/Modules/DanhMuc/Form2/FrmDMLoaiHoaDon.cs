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
    public partial class FrmDMLoaiHoaDon : DSLoaiHoaDonView , IDSLoaiHoaDonView 
    {
        public FrmDMLoaiHoaDon()
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           Controller.Search();
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public object DataSource
        {
            get { return grdLoaiHoaDon.DataSource; }
            set { grdLoaiHoaDon.DataSource = value; }
        }

        public object ItemRowHanle
        {
            get { return grvLoaihoaDon.GetFocusedRow(); }
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
            grdLoaiHoaDon.RefreshDataSource();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Controller.Add();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<DMLoaiHoaDonInfo>(grvLoaihoaDon, "Danhmucloaihoadon");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Controller.Delete();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void grdLoaiHoaDon_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }
    }
}