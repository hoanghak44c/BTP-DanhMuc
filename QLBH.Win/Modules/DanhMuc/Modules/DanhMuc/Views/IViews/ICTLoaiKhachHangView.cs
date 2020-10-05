using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTLoaiKhachHangView:IBaseView<ICTLoaiKhachHangController>
    {
        int IDLoaiKhachHang { get; set; }
        string MaLoaiKhachHang { get; set; }
        string TenLoaiKhachHang { get; set; }
        string GhiChu { get; set; }
        int NhomCha { get; set; }
        int SuDung { get; set; }
        DmLoaiDoiTuongInfor LoaiKhachHangInfor { get; set; }
    }
}
