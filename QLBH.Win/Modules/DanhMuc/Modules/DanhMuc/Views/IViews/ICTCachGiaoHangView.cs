using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTCachGiaoHangView:IBaseView<ICTCachGiaoHangController>
    {
        int IdCachGiaoHang { get; set; }
        string Ma { get; set; }
        string Ten { get; set; }
        string GhiChu { get; set; }
        int SuDung { get; set; }
        DMCachGiaoHangInfo _cachgiaohanginfo { get; set; }

    }
}
