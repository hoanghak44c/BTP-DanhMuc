using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
   public interface  IDSThoiHanThanhToanView:IBaseView<IDSThoiHanThanhToanController >
   {
       object DataSource { get; set; }
       object ItemRowHanle { get;  }
       string Ma { get; }
       string Ten { get; }
       void RefreshDataSource();

   }
}
