﻿using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
  public  interface ICTLoaiHoaDonView:IBaseView<ICTLoaiHoaDonController>
  {
      int IdLoaiHoaDon { get; set; }
      string KyHieu { get; set; }
      string Ten { get; set; }
      string GhiChu { get; set; }
      int SuDung { get; set; }
      DMLoaiHoaDonInfo hoadoninfo { get; set; }

    }
}
