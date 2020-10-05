using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTDuAnView:IBaseView<ICTDuAnController >
    {
        DMDuAnInfor duaninfor { get; set; }
        int IdDuAn { get; set; }
        string MaDuAn { get; set; }
        string TenDuAn { get; set; }
        string GhiChu { get; set; }
        int SuDung { get; set; }

    }
}
