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
    public partial class FrmCTHinhThucThanhToan : CTHinhThucThanhToanView,ICTHinhThucThanhToanView 
    {
        public FrmCTHinhThucThanhToan()
        {
            
        }

        public void Initialize()
        {
            InitializeComponent();
        }
        public FrmCTHinhThucThanhToan(object ItemRowHanle):base(ItemRowHanle)
        {
            
        }

        public int IdThanhToan { get; set; }

        public string Ma
        {
            get { return txtCode.Text; }
            set { txtCode.Text=value; }
        }

        public string Ten
        {
            get { return txtName.Text; }
            set { txtName.Text=value; }
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

        public int LoaiThanhToan
        {
            get
            {
                try
                {
                    return Convert.ToInt32(lueLoaiThanhToan.EditValue);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { lueLoaiThanhToan.EditValue=value; }
        }

        public List<LookUpInfor> objLoaiThanhToan
        {

            set { lueLoaiThanhToan.Properties.DataSource = value; }
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