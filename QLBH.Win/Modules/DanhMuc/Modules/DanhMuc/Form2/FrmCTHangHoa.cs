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
    public partial class FrmCTHangHoa : CTHangHoaView,ICTHangHoaView 
    {
        public FrmCTHangHoa()
        {
            
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public FrmCTHangHoa(object ItemRowHanle):base(ItemRowHanle)
        {
            
        }

        public int IdSanPham { get; set; }

        public int IdCha { get; set; }

        public string MaVach
        {
            get { return txtMaVach.Text; }
            set { txtMaVach.Text = value; }
        }

        public string MaSanPham
        {
            get { return txtMa.Text; }
            set { txtMa.Text=value; }
        }

        public string TenSanPham
        {
            get { return memoTenMatHang.Text; }
            set { memoTenMatHang.Text=value; }
        }

        public int IdDonViTinh
        {
            get
            {
                try
                {
                    return Convert.ToInt32(lueDonViTinh.EditValue);

                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { lueDonViTinh.EditValue=value; }
        }

        public object DonViTinhDataSource
        {
            get { return lueDonViTinh.EditValue; }
            set { lueDonViTinh.Properties.DataSource=value; }
        }

        public int GiaNhap
        {
            get
            {
                try
                {
                    return Convert.ToInt32(txtGiaNhap.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { txtGiaNhap.Text=Convert.ToInt32(value).ToString(); }
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
            set {chkSuDung.Checked=Convert.ToBoolean(value); }
        }

        public int TrungMaVach
        {
            get
            {
                try
                {
                    return Convert.ToInt32(chkTrungMaVach.Checked);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
               
            }
            set { chkTrungMaVach.Checked=Convert.ToBoolean(value); }
        }

        public string TenVietTat
        {
            get { return txtTenVietTat.Text; }
            set { txtTenVietTat.Text=value; }
        }

        public int ChietKhau
        {
            get
            {
                try
                {
                    return Convert.ToInt32(chkHangChietKhau.Checked);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
               
            }
            set { chkHangChietKhau.Checked=Convert.ToBoolean(value); }
        }

        public int BaoHanhHang
        {
            get
            {
                try
                {
                    return Convert.ToInt32(txtBaoHanhHang.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { txtBaoHanhHang.Text=Convert.ToInt32(value).ToString(); }
        }

        public int BaoHanhKhach
        {
            get
            {
                try
                {
                    return Convert.ToInt32(txtBaoHanhKhach.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
               
            }
            set { txtBaoHanhKhach.Text=Convert.ToInt32(value).ToString(); }
        }

        public int TyLeVAT
        {
            get
            {
                try
                {
                    return Convert.ToInt32(lueVAT.EditValue);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { lueVAT.EditValue=Convert.ToInt32(value); }
        }

        public object TyLeVATDataSource
        {
            get { return lueVAT.Properties.DataSource; }
            set { lueVAT.Properties.DataSource=value; }
        }

        public string TenLoaiSP
        {
            get { return btnELoaiMatHang.Text; }
            set {btnELoaiMatHang.Text=value; }
        }

        private void btnELoaiMatHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Controller.ChoseLoaiSP();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Controller.Save();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}