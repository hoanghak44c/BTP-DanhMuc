using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
  public  interface  IDSMaLoiView:IBaseView<IDSMaLoiController>
  {
      object DataSource { get; set; }
      object ItemRowHanle { get; }
      string MaLoi { get; }
      string TenLoi { get; }
      void RefreshDataSource();

  }
}
