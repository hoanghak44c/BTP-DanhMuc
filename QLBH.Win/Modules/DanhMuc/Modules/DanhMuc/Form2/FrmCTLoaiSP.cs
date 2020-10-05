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
    public partial class FrmCTLoaiSP : CTLoaiSanPhamView,ICTLoaiSanPhamView 
    {
        public FrmCTLoaiSP()
        {
            
        }


        public void Initialize()
        {
            InitializeComponent();
        }
        public FrmCTLoaiSP(object ItemRowHanle):base(ItemRowHanle)
        {
            
        }

        public int IdLoaiSP { get; set; }

        public string MaLoaiSP
        {
            get { return txtMaSP.Text; }
            set { txtMaSP.Text = value; }
        }

        public string TenLoaiSP
        {
            get { return txtTenSP.Text; }
            set { txtTenSP.Text = value; }
        }

        public string Nganh
        {
            get { return btnENganh.Text; }
            set { btnENganh.Text = value; }
        }

        public string Chung
        {
            get { return btnEChung.Text; }
            set { btnEChung.Text=value; }
        }

        public string Hang
        {
            get { return btnEHang.Text; }
            set { btnEHang.Text = value; }
        }

        public string LinhVuc
        {
            get { return btnELinhVuc.Text; }
            set { btnELinhVuc.Text=value; }
        }

        public string Loai
        {
            get { return btnELoai.Text; }
            set { btnELoai.Text=value; }
        }

        public string Nhom
        {
            get { return btnENhom.Text; }
            set { btnENhom.Text=value; }
        }

        public string Model
        {
            get { return btnEModel.Text; }
            set {btnEModel.Text=value; }
        }

        public string MoTa
        {
            get { return memoMoTa.Text; }
            set { memoMoTa.Text=value; }
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

        public int NhomCha
        {
            get
            {
                try
                {
                    return Convert.ToInt32(lueNhomCha.EditValue);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
               
            }
            set { lueNhomCha.EditValue=Convert.ToInt32(value); }
        }

        public object NhomChaDataSource
        {

            set { lueNhomCha.Properties.DataSource=value; }
        }

        private void btnENganh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Controller.ChoseNganh();
        }

        private void btnEChung_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Controller.ChoseChung();
        }

        private void btnEHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Controller.ChoseHang();
        }

        private void btnELinhVuc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Controller.ChoseLinhVuc();
        }

        private void btnELoai_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Controller.ChoseLoai();
        }

        private void btnENhom_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Controller.ChoseNhom();
        }

        private void btnEModel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Controller.ChoseModel();
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