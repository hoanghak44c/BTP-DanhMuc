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
    public partial class FrmDMLyDoTraHang : DSLyDoTraHangView,IDSLyDoTraHangView 
    {
        public FrmDMLyDoTraHang()
        {
            
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public object DataSource
        {
            get { return grdLyDoTraHang.DataSource; }
            set { grdLyDoTraHang.DataSource = value; }
        }

        public object ItemRowHanle
        {
            get { return grvLyDoTraHang.GetFocusedRow(); }
        }

        public string MaLyDo
        {
            get { return txtMaLyDo.Text; }
        }

        public string LyDo
        {
            get { return txtTen.Text; }

        }
        public void RefreshDataSource()
        {
            grdLyDoTraHang.RefreshDataSource();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Controller.Search();
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
            Common.Export2ExcelFromDevGrid<DMLyDoTraHangInfo>(grvLyDoTraHang, "Danhmuclydotrahang");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Controller.Delete();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void grdLyDoTraHang_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }
    }
}