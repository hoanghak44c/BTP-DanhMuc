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
    public partial class FrmCTCachGiaoHang :CTCachGiaoHangView ,ICTCachGiaoHangView 
    {
        public FrmCTCachGiaoHang()
        {
            
        }

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        public FrmCTCachGiaoHang(object ItemRowHanle):base(ItemRowHanle)
        {
            
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public int IdCachGiaoHang { get; set; }

        public string Ma
        {
            get { return txtMa.Text; }
            set { txtMa.Text=value; }
        }

        public string Ten
        {
            get {return txtTen.Text; }
            set { txtTen.Text=value; }
        }

        public string GhiChu
        {
            get { return memoGhiChu.Text; }
            set { memoGhiChu.Text=value; }
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