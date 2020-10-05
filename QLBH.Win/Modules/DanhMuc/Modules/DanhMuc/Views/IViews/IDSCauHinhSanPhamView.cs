using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface IDSCauHinhSanPhamView:IBaseView<IDSCauHinhSanPhamController>
    {
        object DataSource { get; set; }
        object ItemRowHanle { get;  }
        int  IdTon { get; set; }
        List<LookUpInfor> TrangThaiTon {  set; }
        void RefreshDataSource();

    }
}
