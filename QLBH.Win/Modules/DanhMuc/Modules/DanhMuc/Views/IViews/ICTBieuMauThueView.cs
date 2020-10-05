using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
   public interface ICTBieuMauThueView:IBaseView<ICTBieuMauThueController >
   {
       int IdTaxCode { get; set; }
       string Code { get; set; }
       string Name { get; set; }
       string GhiChu { get; set; }
       int SuDung { get; set; }
       int GiaTri { get; set; }
       DMTaxCodeInfor taxcodeinfo { get; set; }

    }
}
