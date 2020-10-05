using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTNganHangView:IBaseView<ICTNganHangController >
    {
        int IdNganHang { get; set; }
        string MaNganHang { get; set; }
        string TenNganHang { get; set; }
        string GhiChu { get; set; }
        int SuDung { get; set; }
        DMNganHangInfor nganhanginfor { get; set; }

    }
}
