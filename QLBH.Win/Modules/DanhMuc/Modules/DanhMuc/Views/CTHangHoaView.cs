﻿using System;
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
    public class CTHangHoaView:AppBaseView<CTHangHoaController,ICTHangHoaController,FrmCTHangHoa,ICTHangHoaView >
    {
        protected CTHangHoaView()
        {
            
        }
        protected CTHangHoaView(object ItemRowHanle)
        {
            this.sanphaminfo = (DMSanPhamInfo) ItemRowHanle;
        }

        public DMSanPhamInfo sanphaminfo { get; set; }
    }
}
