using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;

namespace QLBanHang.Modules.DanhMuc.Form2
{
    public partial class FrmCtPhongBan : CTPhongBanView,ICTPhongBanView
    {
        public FrmCtPhongBan()
        {
            
        }

        public FrmCtPhongBan(object  ItemRowHanle):base(ItemRowHanle)
        {}
        public void Initialize()
        {
            InitializeComponent();
        }

        public int Id
        {
            get; set; }

        public string MaPhongBan
        {
            get { return txtMaPhongBan.Text; }
            set { txtMaPhongBan.Text=value; }
        }

        public string TenPhongBan
        {
            get { return txtTenPhongBan.Text; }
            set { txtTenPhongBan.Text = value; }
        }

        public string GhiChu
        {
            get {return memoGhiChu.Text; }
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
            set { chkSuDung.Checked = Convert.ToBoolean(value); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          Controller.Save();
        }


       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        
    }
}