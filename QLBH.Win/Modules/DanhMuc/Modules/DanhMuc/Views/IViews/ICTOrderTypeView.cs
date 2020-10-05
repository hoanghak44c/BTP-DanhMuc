using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
   public interface ICTOrderTypeView:IBaseView<ICTOrderTypeController>
   {
       DMOrderTypeInfor OrderInfo { get; set; }
       int IdOrderType { get; set; }
       string OrderType { get; set; }
       string Name { get; set; }
       string GhiChu { get; set; }
       int SuDung { get; set; }
       string LineType { get; set; }
       string LineKm { get; set; }
       string LineCk { get; set; }
       string NganhHang { get; set; }
       object NganhHangDataSource { set; }
    }
}
