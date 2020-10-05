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
   public class CTPhuongThucBanHangView:AppBaseView<CTPhuongThucBanHangController ,ICTPhuongThucBanHangController ,FrmChiTietPhuongThucBanHang,ICTPhuongThucBanHangView >
   {
       protected CTPhuongThucBanHangView()
       {
           
       }
       protected CTPhuongThucBanHangView(object ItemRowHanle)
       {
           this._PhuongThucBanHangInfo = (DMPhuongThucBanHangInfo) ItemRowHanle;

       }

       public DMPhuongThucBanHangInfo _PhuongThucBanHangInfo { get; set; }
    }
}
