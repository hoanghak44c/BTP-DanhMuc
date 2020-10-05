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
    public partial class FrmCTLoaiKhachHang : CTLoaiKhachHangView,ICTLoaiKhachHangView 
    {
        public FrmCTLoaiKhachHang()
        {
           
        }

        public FrmCTLoaiKhachHang(object ITemRowHanle) : base(ITemRowHanle)
        {
            
        }

        public void Initialize()
        {

            InitializeComponent();
        }

        public int IDLoaiKhachHang { get; set; }

        public string MaLoaiKhachHang
        {
            get { return txtMaLoaiDT.Text; }
            set { txtMaLoaiDT.Text = value; }
        }

        public string TenLoaiKhachHang
        {
            get { return txtTenLoaiDT.Text; }
            set { txtTenLoaiDT.Text=value; }
        }

        public string GhiChu
        {
            get { return txtGhiChu.Text; }
            set { txtGhiChu.Text=value; }
        }

        public int NhomCha
        {
            get { return Convert.ToInt32(txtNhomCha.Text); }
            set { txtNhomCha.Text = Convert.ToInt32(value).ToString(); }
        }

        public int SuDung
        {
            get
            {
                try
                {
                    return Convert.ToInt32(chkSuDung.Checked);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set {chkSuDung.Checked=Convert.ToBoolean(value); }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Controller.Save();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
              Controller.Exit();
        }

        
    }
}