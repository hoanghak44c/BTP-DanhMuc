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

namespace QLBanHang.Modules.DanhMuc.Form2
{
    public partial class FrmCTDonViTinh :CTDonViTinhView,ICTDonViTinhView 
    {
        public FrmCTDonViTinh()
        {
            
        }
        public FrmCTDonViTinh(object ItemRowHanle):base(ItemRowHanle)
        {}

        public void Initialize()
        {
            InitializeComponent(); 
        }

        public int IDDonViTinh { get; set; }

        public string MaDonViTinh
        {
            get { return txtMa.Text; }
            set { txtMa.Text = value; }
        }

        public string TenDonViTinh
        {
            get { return txtTenDonViTinh.Text; }
            set { txtTenDonViTinh.Text=value; }
        }

        public string GhiChu
        {
            get { return memoMoTa.Text; }
            set { memoMoTa.Text=value; }
        }

        public int SuDung
        {
            get { return Convert.ToInt32(chkSuDung.Checked); }
            set { chkSuDung.Checked=Convert.ToBoolean(value); }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Controller.Save();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

      
    }
}