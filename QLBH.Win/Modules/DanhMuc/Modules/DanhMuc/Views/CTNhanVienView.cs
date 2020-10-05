using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Form2;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Views;

namespace QLBanHang.Modules.DanhMuc.Views
{
   public  class CTNhanVienView:AppBaseView<CTNhanVienController,ICTNhanVienController,FrmCtNhanVien,ICTNhanVienView>
   {
       protected CTNhanVienView()
       {}
       protected CTNhanVienView(object ItemRowHanle)
       {
           this.NhanVienInfo= (DMNhanVienInfo)ItemRowHanle;
       }
       public DMNhanVienInfo NhanVienInfo { get; set; }
       public int IdTrungTam { get; set; }
   }
}
