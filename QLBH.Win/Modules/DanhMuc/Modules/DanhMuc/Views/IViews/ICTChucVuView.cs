using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTChucVuView:IBaseView<ICTChucVuController>
    {
        int IdChucVu { get; set; }
        string MaChucVu { get; set; }
        string TenChucVu { get; set; }
        string MoTa { get; set; }
        int SuDung { get; set; }
        // đối tượng để gán dữ liệu 
        DMChucVuInfor ChucVuInfor { get;  }
    }
}
