using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTCauHinhSanPhamView:IBaseView<ICTCauHinhSanPhamController >

    {
        DMCauHinhSanPhamInfo cauhinhspinfo { get; set; }
        int IdSanPham { get; set; }
        string TenCauHinh { get; set; }
        string GiaTri { get; set; }
        int SoTT { get; set; }
        object DataSource { get; set; }
        string Hang { get; set; }
        string logo { get; set; }
        int TrangThai { get; set; }

        
        
    }
}
