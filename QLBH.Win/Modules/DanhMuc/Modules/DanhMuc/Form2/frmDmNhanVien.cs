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
    public partial class frmDmNhanVien : DSNhanVienView,IDSNhanVienView 
    {
        public frmDmNhanVien()
        {
            
        }

       public frmDmNhanVien(object ItemRowHanle):base(ItemRowHanle)
       {}

        public void Initialize()
        {
            InitializeComponent(); 
        }

        public object DataSource
        {
            get { return grdNhanVien.DataSource; }
            set { grdNhanVien.DataSource = value; }
        }

        public object ItemRowHanle
        {
            get { return grvNhanVien.GetFocusedRow(); }
        }

        public string MaNhanVien
        {
            get { return txtMaNV.Text; }
        }

        public string TenNhanVien
        {
            get { return txtTenNV.Text; }
        }

        public int IdPhongBan
        {
            get { return Convert.ToInt32(luePhongBan.EditValue); }




        }

        public object PhongBanDataSource
        {
            set { luePhongBan.Properties.DataSource = value; }
        }

        public int IdChucVu
        {
            get { return Convert.ToInt32(lueChucDanh.EditValue); }
        }

        public object ChucVuDataSource
        {
            set { lueChucDanh.Properties.DataSource = value; }
        }

        public void RefreshDataSource()
        {
            grdNhanVien.RefreshDataSource();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Controller.Search();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<DMNhanVienInfo>(grvNhanVien, "Danhmucnhanvien");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Controller.Delete();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void grcNhanVien_DoubleClick(object sender, EventArgs e)
        {
            Controller.Edit();
        }

        private void txtTenNV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Controller.Add();
        }
    }
}