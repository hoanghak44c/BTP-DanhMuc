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
    public partial class FrmDMCauHinhSanPham : DSCauHinhSanPhamView ,IDSCauHinhSanPhamView 
    {
        public FrmDMCauHinhSanPham()
        {
            
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public object DataSource
        {
            get { return grdDMCauHinhSanPham.DataSource; }
            set { grdDMCauHinhSanPham.DataSource=value; }
        }

        public object ItemRowHanle
        {
            get {return grvDMCauHinhSanPham.GetFocusedRow(); }
        }

        public int  IdTon 
        {
            get { return Convert.ToInt32(lueTon.EditValue); }
            set { lueTon.EditValue=Convert.ToInt32(value).ToString(); }
        }

        public List<LookUpInfor> TrangThaiTon
        {

            set { lueTon.Properties.DataSource = value; }
        }

        public void RefreshDataSource()
        {
           grdDMCauHinhSanPham.RefreshDataSource();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(lueTon.EditValue)==0)
            {
                if(radCoCauHinh.Checked)
                {
                   Controller.SearchCoTon();

                }
                else
                {
                    Controller.SearchKhongTon();
                }
            }
            else
            {
                if(radCoCauHinh.Checked)
                {
                    Controller.SearchCoTon();
                }
                else
                {
                    Controller.SearchKhongTon();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Controller.Delete();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<DMCauHinhSanPhamInfo>(grvDMCauHinhSanPham, "Danhmuccauhinhsanpham");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Controller.Add();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Controller.Edit();
        }
    }
}