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
    public partial class FrmCTNganHang : CTNganHangView ,ICTNganHangView 
    {
        public FrmCTNganHang()
        {
            
        }

        private void FrmCTNganHang_Load(object sender, EventArgs e)
        {

        }
        public FrmCTNganHang(object ItemRowHanle):base(ItemRowHanle)
        {
            
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public int IdNganHang { get; set; }

        public string MaNganHang
        {
            get {return txtMa.Text; }
            set { txtMa.Text=value; }
        }

        public string TenNganHang
        {
            get { return txtTen.Text; }
            set { txtTen.Text=value; }
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