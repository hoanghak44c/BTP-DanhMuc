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
    public partial class FrmCTDoiTuongKhachHang : CTDoiTuongView,ICTDoiTuongView 
    {
        public FrmCTDoiTuongKhachHang()
        {
            
        }
        public FrmCTDoiTuongKhachHang(object ItemRowHanle):base(ItemRowHanle)
        {}


        private void labelControl20_Click(object sender, EventArgs e)
        {

        }

        private void textEdit30_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        public void Initialize()
        {
            InitializeComponent();
        }



        public int IdDoiTuong { get; set; }

        public int IdCha
        {
            get
            {
                try
                {
                    return Convert.ToInt32(beditDTCha.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { beditDTCha.Text =Convert.ToInt32(value).ToString(); }
        }

        public string MaDoiTuong
        {
            get { return txtMaDT.Text; }
            set { txtMaDT.Text=value; }
        }

        public string TenDoiTuong
        {
            get { return txtTenDT.Text; }
            set { txtTenDT.Text=value; }
        }

        public string NguoiLienLac
        {
            get { return txtNLL.Text; }
            set { txtNLL.Text=value; }
        }

        public string DiaChi
        {
            get { return txtDiaChi.Text; }
            set { txtDiaChi.Text=value; }
        }

        public string DienThoai
        {
            get { return txtDienThoai.Text; }
            set { txtDienThoai.Text=value; }
        }

        public string Fax
        {
            get { return txtFax.Text; }
            set { txtFax.Text=value; }
        }

        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text=value; }
        }

        public string MaSoThue
        {
            get { return txtMaSoThue.Text; }
            set { txtMaSoThue.Text=value; }
        }

        public int Type { get; set; }

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
            set { chkSuDung.Checked =Convert.ToBoolean(value); }
        }

        public string GhiChu
        {
            get { return memoGhiChu.Text; }
            set { memoGhiChu.Text=value; }
        }

        public int GioiTinh
        {
            get
            {
                try
                {
                    return Convert.ToInt32(lueGT.EditValue);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { lueGT.EditValue=value; }
        }

        public List<LookUpInfor> objGT
        {
            
            set {
                    lueGT.Properties.DataSource = value;
                }
            }

        public DateTime NgaySinh
        {
            get
            {
                try
                {
                    return Convert.ToDateTime(dateNgaySinh.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
               
            }
            set { dateNgaySinh.Text=Convert.ToDateTime(value).ToString(); }
        }

        public int IdOrderType
        {
            get
            {
                try
                {
                    return Convert.ToInt32(beditOrderType.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { beditOrderType.Text=Convert.ToInt32(value).ToString(); }
        }

        public string MaRieng { get; set; }

        public string SoCMND
        {
            get { return txtSoCMTCDN.Text; }
            set { txtSoCMTCDN.Text = value; }

        }

        public int IdLoaiDoiTuong
        {
            get
            {
                try
                {
                    return Convert.ToInt32(lueLoaiDT.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { lueLoaiDT.Text=Convert.ToInt32(value).ToString(); }
        }

        public object LoaiDoiTuongDataSource
        {
            
            set { lueLoaiDT.Properties.DataSource=value; }
        }

        public string ChuDoanhNghiep
        {
            get { return txtChuDoanhNghiep.Text; }
            set { txtChuDoanhNghiep.Text=value; }
        }

        public string CMND_NLL
        {
            get { return txtSoCMTCDN.Text; }
            set { txtSoCMTCDN.Text=value; }
        }

        public string DienThoai_CDN
        {
            get { return txtDienThoaiCDN.Text; }
            set {txtDienThoaiCDN.Text=value; }
        }

        public string DienThoai_NLL
        {
            get { return txtDienThoaiNLL.Text; }
            set {txtDienThoaiNLL.Text=value; }
        }

        public int DoTuoi
        {
            get { return Convert.ToInt32(txtTuoi.Text); }
            set { txtTuoi.Text=Convert.ToInt32(value).ToString(); }
        }

        public string Email_CDN
        {
            get { return txtEmailCDN.Text; }
            set { txtEmailCDN.Text=value; }
        }

        public double GiaTriMuaHang
        {
            get
            {
                try
                {
                    return Convert.ToDouble(txtGiaTriMuaHang.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { txtGiaTriMuaHang.Text=Convert.ToDouble(value).ToString(); }
        }

        public double HanMucTinDung
        {
            get
            {
                try
                {
                    return Convert.ToDouble(txtHanMuc.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
            
            }
            set { txtHanMuc.Text = Convert.ToDouble(value).ToString(); }
        }

        public double HanMucTDConLai
        {
            get
            {
                try
                {
                    return Convert.ToDouble(txtHanMuc.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { txtHanMuc.Text=Convert.ToDouble(value).ToString(); }
        }

        public double CongNoKhachHang
        {
            get
            {
                try
                {
                    return Convert.ToDouble(txtCongNoKH.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            } 
            set { txtCongNoKH.Text = Convert.ToDouble(value).ToString(); }
        }

        public int HanTra
        {
            get
            {
                try
                {
                    return Convert.ToInt32(txtHanTra.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { txtHanTra.Text=Convert.ToInt32(value).ToString(); }
        }

        public string Huyen
        {
            get { return txtHuyen.Text; }
            set { txtHuyen.Text = value; }
        }

        public string Biet_Ta_Tu
        {
            get { return txtBietTA.Text; }
            set { txtBietTA.Text=value; }
        }

        public int IdLoaiThe { get; set; }

        public string NganHang
        {
            get { return txtNganHang.Text; }
            set { txtNganHang.Text = value; }
        }

        public DateTime NgayCapThe
        {
            get
            {
                try
                {
                    return Convert.ToDateTime(dateNgaySinh.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { dateNgaySinh.Text=Convert.ToDateTime(value).ToString(); }
        }

        public string NgheNghiep
        {
            get { return txtNgheNghiep.Text; }
            set { txtNgheNghiep.Text=value; }
        }

        public string PhongBan
        {
            get { return txtPhongBan.Text; }
            set { txtPhongBan.Text=value; }
        }

        public string QuocGia
        {
            get { return txtQuocGia.Text; }
            set {txtQuocGia.Text=value; }
        }

        public string SoDKKD
        {
            get { return txtSoDKKD.Text; }
            set { txtSoDKKD.Text=value; }
        }

        public int SoLanMuaHang
        {
            get { return Convert.ToInt32(txtSoLanMuaHang.Text); }
            set { txtSoLanMuaHang.Text=Convert.ToInt32(value).ToString(); }
        }

        public string SiteNumber { get; set; }

        public string MaVung { get; set; }

        public string TaiKhoan
        {
            get { return txtTaiKhoan.Text; }
            set { txtTaiKhoan.Text = value; }
        }

        public int ThuNhap
        {
            get
            {
                try
                {
                    return Convert.ToInt32(txtThuNhap.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
               
            }
            set { txtThuNhap.Text = Convert.ToInt32(value).ToString(); }
        }

        public string Tinh
        {
            get { return txtTinh.Text; }
            set { txtTinh.Text = value; }
        }

        public double TyLePhat
        {
            get
            {
                try
                {
                    return Convert.ToDouble(txtTiLePhat.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { txtTiLePhat.Text=Convert.ToDouble(value).ToString(); }
        }

        public string WebSite
        {
            get { return txtWebsite.Text; }
            set { txtWebsite.Text=value; }
        }

        public int BillTo
        {
            get
            {
                try
                {
                    {
                        return Convert.ToInt32(txtBilTo.Text);
                    }
                }
                catch (Exception ex)
                {
                   
                    throw new Exception(ex.Message);
                }
               
            }
            set { txtBilTo.Text=Convert.ToInt32(value).ToString(); }
        }

        public int ShipTo
        {
            get
            {
                try
                {
                    return Convert.ToInt32(txtShipTo.Text);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
               
            }
            set { txtShipTo.Text = Convert.ToInt32(value).ToString(); }
        }

        public object DataSource
        {
            get { return grdDiaChiHD.DataSource; }
            set { grdDiaChiHD.DataSource=value; }
        }

        private void txtMaDT_TextChanged(object sender, EventArgs e)
        {
            Controller.GetDiaChiHoaDonByMaDoiTuong();
        }

       

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Controller.Save();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void beditOrderType_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Controller.ChoseOrderType();
        }

        private void beditDTCha_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Controller.ChoseDTCha();
        }
    }
}