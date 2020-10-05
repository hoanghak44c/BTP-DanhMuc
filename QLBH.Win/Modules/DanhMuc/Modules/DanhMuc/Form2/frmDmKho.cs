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

namespace QLBanHang.Modules.DanhMuc.Views
{
    public partial class frmDmKho : DSKhoView, IDSKhoView
    {
        public frmDmKho()
        {

        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public object DataSource
        {
            get { return grcDmKho.DataSource; }
            set { grcDmKho.DataSource = value; }
        }

        public object ItemRowHanle
        {
            get { return grvDmKho.GetFocusedRow(); }
        }

        public string MaKho
        {
            get { return textEdit1.Text; }
        }

        public string TenKho
        {
            get { return textEdit2.Text; }
        }

        public void RefreshDataSource()
        {
            grcDmKho.RefreshDataSource();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Controller.Search();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Controller.Add();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<DMKhoInfo>(grvDmKho, "DanhMucKho");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Controller.Delete();
        }

        private void grcDmKho_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }
    }
}