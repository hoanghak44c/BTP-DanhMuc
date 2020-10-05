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
    public class CTLoaiHoaDonView:AppBaseView<CTLoaiHoaDonController,ICTLoaiHoaDonController,FrmCTLoaiHoaDon,ICTLoaiHoaDonView >
    {
        protected CTLoaiHoaDonView()
        {
            
        }
        protected CTLoaiHoaDonView(object ItemRowHanle)
        {
            this.hoadoninfo = (DMLoaiHoaDonInfo) ItemRowHanle;
        }

        public DMLoaiHoaDonInfo hoadoninfo { get; set; }
    }
}
