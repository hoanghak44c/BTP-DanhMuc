using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTThoiHanThanhToanView:IBaseView<ICTThoiHanThanhToanController >
    {
        DMLoaiThuChiInfor thuchiinfor { get; set; }
        int IdThuChi { get; set; }
        string KyHieu { get; set; }
        string Ten { get; set; }
        string GhiChu { get; set; }
        int Type { get; set; }
        int SuDung { get; set; }

    }
}
