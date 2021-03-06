using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.Form2
{
    public partial class FrmCtNhanVien :CTNhanVienView,ICTNhanVienView 
    {
        public FrmCtNhanVien()
        {
            
        }

        private objGridMarkSelection selector;

        public FrmCtNhanVien(object ItemRowHanle) : base(ItemRowHanle)
        {}

        public void Initialize()
        {
            InitializeComponent();
            selector=new objGridMarkSelection(grvKho);
        }

        public int IdNhanVien { get; set; }

        public string MaNhanVien
        {
            get { return txtMaNV.Text; }
            set { txtMaNV.Text=value; }
        }

        public string HoTen
        {
            get { return txtHoTen.Text; }
            set { txtHoTen.Text=value; }
        }

        public DateTime NgaySinh
        {
            get { return  Convert.ToDateTime(dateNgaySinh.Text); }
            set { dateNgaySinh.Text=Convert.ToDateTime(value).ToString(); }
        }

        public int GioiTinh
        {
            get { return Convert.ToInt32(lueGioiTinh.EditValue); }
            set { lueGioiTinh.EditValue=Convert.ToInt32(value).ToString(); }
        }
        public List<LookUpInfor> objGioiTinh
        {

            set { lueGioiTinh.Properties.DataSource = value; }
        }

        public int IdPhongBan
        {
            get
            {
                try
                {
                    return Convert.ToInt32(luePhongBan.EditValue);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { luePhongBan.EditValue=Convert.ToInt32(value).ToString(); }
        }

        public object PhongBanDataSource
        {
            set { luePhongBan.Properties.DataSource=value; }
        }

        public int IdChucVu
        {
            get { return Convert.ToInt32(lueChucDanh.EditValue); }
            set { lueChucDanh.EditValue=Convert.ToInt32(value); }
        }

        public object ChucVuDataSource
        {
            set { lueChucDanh.Properties.DataSource=value; }
        }

        public string DiaChi
        {
            get { return txtDiaChi.Text; }
            set { txtDiaChi.Text=value; }
        }

        public string DienThoai
        {
           get { return txtDienThoai.Text; }
            set
            {
                try
                {
                    if (txtDienThoai.Text != "")
                    {
                        Convert.ToInt32(txtDienThoai.Text);

                    }
                }
                catch
                {

                    MessageBox.Show("Bạn chỉ được phép nhập số !");
                    txtDienThoai.Text = "";

                }
                
            }
           
            
          
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

        public string Email
        {
            get {return txtEmail.Text; }
            set {txtEmail.Text=value; }
        }

        public string GhiChu
        {
            get { return memoGhiChu.Text; }
            set { memoGhiChu.Text=value; }
        }

        public int IdTrungTamHachToan
        {
            get
            {
                try
                {
                    return Convert.ToInt32(btnETrungTam.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { btnETrungTam.Text=Convert.ToInt32(value).ToString(); }
        }
        public object DataSource
        {
            set { grdKho.DataSource=value; }
        }

       


        private void btnETrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Controller.ChoseTrungTam();
        }

        private void chkTick_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Controller.Save();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void btnETrungTam_TextChanged(object sender, EventArgs e)
        {
            Controller.GetKhoByIdTrungTam();
        }

        private void chkTick_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTick.Checked == true)
            {
                selector.SelectAll();
            }
            else
            {
                selector.ClearSelection();
            }
        }

        

        
    }
}