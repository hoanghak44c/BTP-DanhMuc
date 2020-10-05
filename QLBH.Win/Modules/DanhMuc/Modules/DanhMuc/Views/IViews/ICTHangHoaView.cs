using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTHangHoaView:IBaseView<ICTHangHoaController >
    {
        DMSanPhamInfo sanphaminfo { get; set; }
        int IdSanPham { get; set; }
        int IdCha { get; set; }
        string MaVach { get; set; }
        string MaSanPham { get; set; }
        string TenSanPham { get; set; }
        // đối tượng load đơn vị tính
        int IdDonViTinh { get; set; }
        object DonViTinhDataSource { get; set; }

        int GiaNhap { get; set; }
        string MoTa { get; set; }
       int SuDung { get; set; }
       int TrungMaVach { get; set; }
       string TenVietTat { get; set; }
       int ChietKhau { get; set; }
        int BaoHanhHang { get; set; }
        int BaoHanhKhach { get; set; }
        // load VAT
        int TyLeVAT { get; set; }
        object TyLeVATDataSource { get; set; }

       string TenLoaiSP { get; set; } 


    }
}
