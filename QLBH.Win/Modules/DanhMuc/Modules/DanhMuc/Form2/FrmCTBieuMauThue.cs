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
    public partial class FrmCTBieuMauThue : CTBieuMauThueView ,ICTBieuMauThueView 
    {
        public FrmCTBieuMauThue()
        {
            
        }

        public void Initialize()
        {
            InitializeComponent();
        }
        public FrmCTBieuMauThue(object ItemRowHanle):base(ItemRowHanle)
        {
            
        }

        public int IdTaxCode { get; set; }
        public string Name
        {
            get { return txtTen.Text; }
            set { txtTen.Text = value; }
        }
        public string Code
        {
            get { return txtMa.Text; }
            set { txtMa.Text = value; }
        }

        public string GhiChu
        {
            get { return memoMoTa.Text; }
            set { memoMoTa.Text = value; }
        }

        public int SuDung
        {
            get { return Convert.ToInt32(chkSuDung.Checked); }
            set { chkSuDung.Checked=Convert.ToBoolean(value); }
        }

        public int GiaTri
        {
            get { return Convert.ToInt32(txtGiaTri.Text); }
            set { txtGiaTri.Text=Convert.ToInt32(value).ToString(); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Controller.Save();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

       
    }
}