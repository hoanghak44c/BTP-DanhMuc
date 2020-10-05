using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTMaLoiView:IBaseView<ICTMaLoiController >
    {
        DMMaLoiInfor maloiinfor { get; set; }
        int IdMaLoi { get; set; }
        string MaLoi { get; set; }
        int IdLoaiItem { get; set; }
        string TenLoi { get; set; }
        string GhiChu { get; set; }
        int SuDung { get; set; }
        string TenLoaiSP { get; set; }

    }
}
