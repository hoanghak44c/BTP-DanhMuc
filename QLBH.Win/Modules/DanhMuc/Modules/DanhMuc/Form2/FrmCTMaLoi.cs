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
    public partial class FrmCTMaLoi : CTMaLoiView , ICTMaLoiView 
    {
        public FrmCTMaLoi()
        {
           
        }

        public void Initialize()
        {
            InitializeComponent();
        }
         public FrmCTMaLoi(object ItemRowHanle):base(ItemRowHanle)
         {
             
         }

         public int IdMaLoi { get; set; }

        public string MaLoi
        {
            get { return txtMaLoi.Text; }
            set { txtMaLoi.Text = value;}
        }

        public int IdLoaiItem { get; set; }

        public string TenLoi
        {
            get { return txtTenLoi.Text; }
            set { txtTenLoi.Text = value; }
        }

        public string GhiChu
        {
            get { return memoGhiChu.Text; }
            set { memoGhiChu.Text=value; }
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
            set { chkSuDung.Checked=Convert.ToBoolean(value); }
        }

        public string TenLoaiSP
        {
            get { return txtLoaiSP.Text; }
            set { txtLoaiSP.Text=value; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Controller.Save();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }
    }
}