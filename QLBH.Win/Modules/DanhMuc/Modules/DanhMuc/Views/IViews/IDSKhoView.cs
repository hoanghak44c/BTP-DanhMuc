using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBH.Core;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface IDSKhoView:IBaseView<IDSKhoController>
    {
         object DataSource { get; set; }
         object ItemRowHanle { get; }
         string MaKho { get;  }
         string TenKho { get; }
         void RefreshDataSource();
    }
}
