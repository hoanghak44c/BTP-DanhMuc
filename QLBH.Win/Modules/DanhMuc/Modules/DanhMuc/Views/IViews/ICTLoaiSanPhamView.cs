using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTLoaiSanPhamView:IBaseView<ICTLoaiSanPhamController>
    {
        DMLoaiSanPhamInfo SanPhamInfo { get; set; }
        int IdLoaiSP { get; set; }
        string MaLoaiSP { get; set; }
        string TenLoaiSP { get; set; }
        string Nganh { get; set; }
        string Chung { get; set; }
        string Hang { get; set; }
        string LinhVuc { get; set; }
        string Loai { get; set; }
        string Nhom { get; set; }
        string Model { get; set; }
        string MoTa { get; set; }
        int SuDung { get; set; }
        int  NhomCha { get; set; }
        object NhomChaDataSource {  set; }


    }
}
