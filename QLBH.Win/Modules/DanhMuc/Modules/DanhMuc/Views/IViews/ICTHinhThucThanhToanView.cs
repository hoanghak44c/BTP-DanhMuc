using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTHinhThucThanhToanView:IBaseView<ICTHinhThucThanhToanController >
    {
        int IdThanhToan { get; set; }
        string Ma { get; set; }
        string Ten { get; set; }
        string GhiChu { get; set; }
        int SuDung { get; set; }
        int LoaiThanhToan { get; set; }
        List<LookUpInfor> objLoaiThanhToan {  set; }
        DMThanhToanInfor thanhtoaninfo { get; set; }

    }
}
