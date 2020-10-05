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
    public partial class frmDmPhongBan : DSPhongBanView,IDSPhongBanView
    {
        public frmDmPhongBan()
        {
            
        }

        public void Initialize()
        {
            InitializeComponent();
        }
       
        public object DataSource
        {
            get { return grcPhongBan.DataSource; }
            set { grcPhongBan.DataSource = value; }
        }

        public object ItemRowHanle
        {
            get { return grvPhongBan.GetFocusedRow(); }

            
        }

        public string MaPhongBan
        {
            get { return txtMaPhongBan.Text; }
            set { txtMaPhongBan.Text = value; }
            
        }
        

        public string TenPhongBan
        {

            get { return txtTenPhongBan.Text; }
            set { txtTenPhongBan.Text = value; }
        }

        public void RefreshDataSource()
        {
            grcPhongBan.RefreshDataSource();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Controller.Delete();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<DMPhongBanInfor>(grvPhongBan, "Danhsachphongban");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Controller.Search();
        }

        private void grcPhongBan_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }
    }
}