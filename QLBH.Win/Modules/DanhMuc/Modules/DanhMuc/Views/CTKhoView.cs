using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Views;

namespace QLBanHang.Modules.DanhMuc.Views
{
   public  class CTKhoView:AppBaseView<CTKhoController,ICTKhoController,FrmCtKho,ICTKhoView>
   {
       protected CTKhoView()
       {
           
       }
       protected CTKhoView (object ItemRowHanle)
       {
           this.dmKhoInfo = (DMKhoInfo)ItemRowHanle;
       }

       public DMKhoInfo dmKhoInfo { get; set; }
       public int IdTrungTam { get; set; }
    }
}
