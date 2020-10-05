using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
  public interface IDSDonViTinhView:IBaseView<IDSDonViTinhController>
    {
      object ItemRowHanle { get;  }
      object DataSource { get; set; }
      string MaDonViTinh { get; }
      string TenDonViTinh { get;  }
      void RefreshDataSource();
    }
}
