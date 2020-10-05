using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Views.IViews;

namespace QLBanHang.Modules.DanhMuc.Form2
{
    public partial class FrmCtChucVu : CTChucVuView,ICTChucVuView 
    {
        public FrmCtChucVu()
        {
            
        }
        
        public FrmCtChucVu (object ITemRowHanle):base(ITemRowHanle)
        {
            
        }
        public void Initialize()
        {
            InitializeComponent();
        }

        public int IdChucVu
        
        {
            get; set; }

        public string MaChucVu
        {
            get { return txtMaChucVu.Text; }
            set { txtMaChucVu.Text = value; }
        }

        public string TenChucVu
        {
            get { return txtTenChucVu.Text; }
            set { txtTenChucVu.Text = value; }
        }

        public string MoTa
        {
            get { return memoGhiChu.Text; }
            set { memoGhiChu.Text = value; }
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