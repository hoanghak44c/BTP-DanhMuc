using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
   public interface IDSOrderTypeView:IBaseView<IDSOrderTypeController >
   {
       object DataSource { get; set; }
       object ItemRowHanle { get; }
       string MaOrderType { get; }
       string TenOrderType  { get; }
       void RefreshDataSource();
   }
}
