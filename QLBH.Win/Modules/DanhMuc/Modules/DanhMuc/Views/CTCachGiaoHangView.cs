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
    public class CTCachGiaoHangView:AppBaseView<CTCachGiaoHangController,ICTCachGiaoHangController,FrmCTCachGiaoHang,ICTCachGiaoHangView>
    {
        protected CTCachGiaoHangView()
        {}
        protected CTCachGiaoHangView(object ItemRowHanle)
        {

            this._cachgiaohanginfo = (DMCachGiaoHangInfo) ItemRowHanle;

        }

        public DMCachGiaoHangInfo _cachgiaohanginfo { get; set; }
    }
}
