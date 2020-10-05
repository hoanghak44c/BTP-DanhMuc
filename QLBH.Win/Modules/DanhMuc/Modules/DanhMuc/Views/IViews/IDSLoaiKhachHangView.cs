using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBH.Core.Interfaces;
using QLBH.Core.Views;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
   public interface IDSLoaiKhachHangView:IBaseView<IDSLoaiKhachHangController>
   {
       object DataSource { get; set; }
       object ItemRowHanle { get; }
       string TenLoaiKhachHang { get; }
       void RefreshDataSource();
   }
}
