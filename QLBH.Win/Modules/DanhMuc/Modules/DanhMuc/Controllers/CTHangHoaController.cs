using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Controllers;

namespace QLBanHang.Modules.DanhMuc.Controllers
{
   public class CTHangHoaController:AppBaseTrustedController<ICTHangHoaView>,ICTHangHoaController 
   {
       private DMSanPhamInfo _sanphaminfo=new DMSanPhamInfo();
       public CTHangHoaController(ICTHangHoaView view) : base(view)
       {
       }

       protected override void DisplayViewInfo()
       {
           GetData();
           LoadDataSource();
           LoadDonViTinh();
           LoadTyLeVAT();

       }
       private void GetData()
       {
           _sanphaminfo = View.sanphaminfo;


       }
       private void LoadDataSource()
       {
           if(_sanphaminfo!=null)
           {
               View.IdSanPham = _sanphaminfo.IdSanPham;
               View.MaSanPham = _sanphaminfo.MaSanPham;
               View.MaVach = _sanphaminfo.MaVach;
               View.TenSanPham = _sanphaminfo.TenSanPham;
               View.TenVietTat = _sanphaminfo.TenVietTat;
               View.TenLoaiSP = _sanphaminfo.TenLoaiSP;
               View.IdDonViTinh = _sanphaminfo.IdDonViTinh;
               View.GiaNhap = _sanphaminfo.GiaNhap;
               View.TyLeVAT = _sanphaminfo.TyLeVAT;
               View.MoTa = _sanphaminfo.MoTa;
               View.TrungMaVach = _sanphaminfo.TrungMaVach;
               View.SuDung = _sanphaminfo.SuDung;
               View.BaoHanhHang = _sanphaminfo.BaoHanhHang;
               View.BaoHanhKhach = _sanphaminfo.BaoHanhKhach;
               View.ChietKhau = _sanphaminfo.ChietKhau;



           }
       }
       private void LoadDonViTinh()
       {
           View.DonViTinhDataSource = DmDonViTinhDAO.Instance.GetListDonViTinhInfo();

       }
       private void LoadTyLeVAT()
       {
           View.TyLeVATDataSource = DmTaxCodeDAO.Instance.GetListTaxCodeInfo();

       }
       private void Insert()
       {
           if(_sanphaminfo==null)
           {
               _sanphaminfo=new DMSanPhamInfo();
               _sanphaminfo.MaSanPham = View.MaSanPham;
              _sanphaminfo.MaVach = View.MaVach;
              _sanphaminfo.TenSanPham = View.TenSanPham;
               _sanphaminfo.TenVietTat = View.TenVietTat;
               _sanphaminfo.TenLoaiSP = View.TenLoaiSP;
               _sanphaminfo.IdDonViTinh = View.IdDonViTinh;
              _sanphaminfo.GiaNhap = View.GiaNhap;
               _sanphaminfo.TyLeVAT = View.TyLeVAT;
               _sanphaminfo.MoTa = View.MoTa;
              _sanphaminfo.TrungMaVach = View.TrungMaVach;
               _sanphaminfo.SuDung = View.SuDung;
               _sanphaminfo.BaoHanhHang = View.BaoHanhHang;
              _sanphaminfo.BaoHanhKhach = View.BaoHanhKhach;
               _sanphaminfo.ChietKhau = View.ChietKhau;
               _sanphaminfo.IdSanPham = DMSanPhamDAO.Instance.Insert(_sanphaminfo);
               ((List<DMSanPhamInfo>)DSHangHoaView.Instance.DataSource).Add(_sanphaminfo);
               DSHangHoaView.Instance.RefreshDataSource();

           }
       }
       private void Update()
       {
           _sanphaminfo.IdSanPham = View.IdSanPham;
           _sanphaminfo.MaSanPham = View.MaSanPham;
           _sanphaminfo.MaVach = View.MaVach;
           _sanphaminfo.TenSanPham = View.TenSanPham;
           _sanphaminfo.TenVietTat = View.TenVietTat;
           _sanphaminfo.TenLoaiSP = View.TenLoaiSP;
           _sanphaminfo.IdDonViTinh = View.IdDonViTinh;
           _sanphaminfo.GiaNhap = View.GiaNhap;
           _sanphaminfo.TyLeVAT = View.TyLeVAT;
           _sanphaminfo.MoTa = View.MoTa;
           _sanphaminfo.TrungMaVach = View.TrungMaVach;
           _sanphaminfo.SuDung = View.SuDung;
           _sanphaminfo.BaoHanhHang = View.BaoHanhHang;
           _sanphaminfo.BaoHanhKhach = View.BaoHanhKhach;
           _sanphaminfo.ChietKhau = View.ChietKhau;
           DMSanPhamDAO.Instance.Update(_sanphaminfo);
           ((List<DMSanPhamInfo>)DSHangHoaView.Instance.DataSource).Add(_sanphaminfo);
           DSHangHoaView.Instance.RefreshDataSource();
       }
       private void Check()
       {
           if (String.IsNullOrEmpty(View.MaSanPham))
           {
              throw new InvalidOperationException("Không được để trống mã sản phẩm!");
           }
           if(String.IsNullOrEmpty(View.TenSanPham))
           {
               throw new InvalidOperationException("Không được để trống tên sản phẩm !");
           }
       }
       public void Save()
       {
           if(_sanphaminfo==null)
           {
               Check();
               Insert();
               View.ShowMessage("Thêm dữ liệu thành công !");
               View.DialogResult = DialogResult.OK;

           }
           else
           {
              Update();
               View.ShowMessage("Sửa dữ liệu thành công !");
               View.DialogResult = DialogResult.OK;
           }
       }
      public void ChoseLoaiSP()
      {
         
          frmLookUp_LoaiSanPham frm=new frmLookUp_LoaiSanPham();
          if(frm.ShowDialog()==DialogResult.OK)
          {
              View.TenLoaiSP = frm.SelectedItem.TenLoaiSP;


          }
      }
       public void Exit()
       {
           View.Close();
       }
   }
    
}
