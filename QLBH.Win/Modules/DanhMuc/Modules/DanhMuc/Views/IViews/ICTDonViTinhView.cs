using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
   public interface ICTDonViTinhView:IBaseView<ICTDonViTinhController>
   {
       int IDDonViTinh { get; set; }
       string MaDonViTinh { get; set; }
       string TenDonViTinh { get; set; }
       string GhiChu { get; set; }
       int SuDung { get; set; }
       DMDonViTinhInfor DonViTinhInfor { get; set; }

    }
}
